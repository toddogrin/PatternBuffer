using System;
using System.Collections.Generic;
using System.IO;

namespace PatternBuffer {

    /**
     * This class defines an abstract base class for all PatternBuffer implementations. It leverages
     * generated Serializer classes to serialize and deserialize obejcts and byte arrays. To accomplish this,
     * it also maintains several maps for bookkeeping purposes.
     * 
     * The final output of the C# compiler is, in part, a class named something like MySchemaPatternBuffer
     * that derives from this class.
     */
    public abstract class AbstractPatternBuffer : IPatternBuffer {

        // Maps C# types to their associated Serializer
        protected Dictionary<Type, IPatternBufferSerializer> typeSerializerMap;

        // Maps type IDs to their associated Serializer
        protected Dictionary<ushort, IPatternBufferSerializer> typeIdSerializerMap;

        // Maps type names to their associated Serializer
        protected Dictionary<string, IPatternBufferSerializer> typeNameSerializerMap;

        // Maps enum names to an index:value map
        protected Dictionary<string, Dictionary<byte, string>> enumIndexValueMap;

        // Maps enum names to an value:index map
        protected Dictionary<string, Dictionary<string, byte>> enumValueIndexMap;

        /**
         * Initializes the AbstractPatternBuffer
         */
        public AbstractPatternBuffer() {
            this.typeSerializerMap = new Dictionary<Type, IPatternBufferSerializer>();
            this.typeIdSerializerMap = new Dictionary<ushort, IPatternBufferSerializer >();
            this.typeNameSerializerMap = new Dictionary<string, IPatternBufferSerializer>();
            this.RegisterSerializers();
            this.enumIndexValueMap = new Dictionary<string, Dictionary<byte, string>>();
            this.enumValueIndexMap = new Dictionary<string, Dictionary<string, byte>>();
            this.RegisterEnums();
        }

        /**
         * Override this message to register serializable types.
         */
        protected abstract void RegisterSerializers();

        /**
         * Override this message to register serializable enums.
         */
        protected abstract void RegisterEnums();

        /**
         * Returns the IPatternBufferSerializer for the given type ID, if any. Returns null
         * if the type ID is not registered.
         */
        public IPatternBufferSerializer GetSerializerByTypeId(ushort typeId) {
            return this.typeIdSerializerMap[typeId];
        }

        /**
         * Returns the IPatternBufferSerializer for the given object's type, if any. Returns null
         * of the object's type is not registered.
         */
        public IPatternBufferSerializer GetSerializerFor(object o) {
            return this.typeSerializerMap[o.GetType()];
        }

        /**
         * Returns the IPatternBufferSerializer for the given type name, if any. Returns null if the
         * type name is not registered.
         */
        public IPatternBufferSerializer GetSerializerByTypeName(string typeName) {
            return this.typeNameSerializerMap[typeName];
        }

        /**
         * Returns true if the object's type can be serialized by this PatternBuffer.
         */
        public bool IsSupportedType(object o) {
            return this.typeSerializerMap.ContainsKey(o.GetType());
        }

        /**
         * Returns true if the given type ID is recognized by this PatternBuffer.
         */
        public bool IsSupportedType(ushort typeId) {
            return this.typeIdSerializerMap.ContainsKey(typeId);
        }

        /**
         * Converts the given object to a byte array. If the object type is not registered, this will
         * throw an exception.
         * 
         * If the type is recognized, a byte array will be returned that contains the serialized object.
         *
         * If the result of this call is passed back into Energize(byte[]), the result will effectively 
         * be a clone of the original object.
         */
        public byte[] Energize(object o) {
            // Check the type
            if (!this.IsSupportedType(o)) {
                throw new PatternBufferException("Cannot energize; object type " + o.GetType().Name + " is not registered.");
            }

            // Get the serializer
            IPatternBufferSerializer serializer = this.typeSerializerMap[o.GetType()];

            // Allocate the stream
            MemoryStream stream = new MemoryStream((int)serializer.SizeOf(o) + PatternBufferUtil.GetUnsignedVariantSize(serializer.TypeId));
            BinaryWriter writer = new BinaryWriter(stream);

            // Write the ID
            PatternBufferUtil.WriteVUInt16(writer, serializer.TypeId);

            // Serialize
            serializer.ToBytes(writer, o);

            // Return result
            return stream.GetBuffer();
        }

        /**
         * Serializes the given object (if registered) to the given BinaryWriter.
         */
        public void EnergizeTo(object o, BinaryWriter writer) {
            if ( ! this.IsSupportedType(o)) {
                throw new PatternBufferException("Cannot energize; object type " + o.GetType().Name + " is not registered.");
            }
            if (writer == null) {
                throw new ArgumentNullException("writer", "BinaryWriter cannot be null.");
            }
            this.typeSerializerMap[o.GetType()].ToBytes(writer, o);
        }

        /**
         * Converts the given byte array into an object. If the byte array is malformed, or the type ID can't be
         * resolved from the byte array, this will throw an exception.
         * 
         * If the result of this call is passed back into Energize(object), the result will effectively 
         * be a clone of the original byte array.
         */
        public object Energize(byte[] bytes) {
            return this.EnergizeFrom(new BinaryReader(new MemoryStream(bytes)));
        }

        /**
         * An explicitly typed deserialization method. This returns a pre-cast version of the deserialized
         * object and is useful when you are certain of the contents of a byte array befor deserializing it.
         * 
         * If the byte array deserializes into an object that cannot be cast to TYPE, an exception is thrown.
         */
        public TYPE Energize<TYPE>(byte[] bytes) {
            object o = this.Energize(bytes);
            if ( ! (o is TYPE)) {
                throw new PatternBufferException("Deserialized type (" + o.GetType().Name + ") does not match expected type (" + typeof(TYPE).Name + ").");
            }
            return (TYPE)o;
        }

        /**
         * Deserializes an object directly from the gien BinaryReader. The BinaryReader must not be null 
         * and must be readable.
         */
        public object EnergizeFrom(BinaryReader reader) {

            // Verify we have a reader
            if (reader == null) {
                throw new ArgumentNullException("reader", "BinaryReader mustnot be null.");
            }

            // Get the type ID
            ushort typeId = (ushort)PatternBufferUtil.ReadVUInt16(reader);

            // Verify support for that type
            if ( ! this.IsSupportedType(typeId)) {
                throw new PatternBufferException("The type ID " + typeId + " is not supported.");
            }
            
            // Deserialize
            return this.typeIdSerializerMap[typeId].FromBytes(reader);
        }
        
        /**
         * For a given enum name and index, returns the enum value in that index position, if any.
         * 
         * If the enum name does not exist, or if the index is out of range, this will throw an exception.
         */
        public string GetEnumValue(string enumName, byte index) {
            if ( ! this.enumIndexValueMap.ContainsKey(enumName)) {
                throw new PatternBufferException("Unrecognized enum: " + enumName);
            }
            if ( ! this.enumIndexValueMap[enumName].ContainsKey(index)) {
                throw new PatternBufferException("The index " + index + " is invalid for enum \"" + enumName +"\" which has " + this.enumIndexValueMap[enumName].Count + " values.");
            }
            return this.enumIndexValueMap[enumName][index];
        }

        /**
         * For a given enum name and value, returns the index of that value, if any.
         * 
         * If the enum name does not exist, or if the value is not present in the enum, this will throw an exception.
         */
        public byte GetEnumIndex(string enumName, string value) {
            if ( ! this.enumIndexValueMap.ContainsKey(enumName)) {
                throw new PatternBufferException("Unrecognized enum: " + enumName);
            }
            if ( ! this.enumIndexValueMap[enumName].ContainsValue(value)) {
                throw new PatternBufferException("The value \"" + value + "\" is not part of enum \"" + enumName + "\".");
            }
            return this.enumValueIndexMap[enumName][value];
        }
    }

}
