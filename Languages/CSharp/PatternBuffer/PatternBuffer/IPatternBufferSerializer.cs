using System.IO;

namespace PatternBuffer {

    /**
     * Defines an interface to be implemented by classes that can serialize and deserialize
     * PatternBuffer objects. 
     * 
     * Implementations of this interface are usually automatically generated using the 
     * PatternBufferCompiler.
     */
    public interface IPatternBufferSerializer {
       
        /**
         * The type ID of the type that the implementation can serialize and deserialize.
         */
        ushort TypeId { get; }

        /**
         * The name of the type that the implementation can serialize and deserialize.
         */
        string TypeName { get; }

        /**
         * Reads bytes from the given BinaryReader and creates an object from them.
         */
        object FromBytes(BinaryReader reader);

        /**
         * Converts the given object into bytes and writes those bytes to the given BinaryWriter.
         */
        void ToBytes(BinaryWriter writer, object o);

        /**
         * Returns the serialized size of the given object.
         */
        uint SizeOf(object o);
    }
}
