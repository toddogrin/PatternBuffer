using System;
using System.Collections.Generic;
using System.Text;

namespace PatternBuffer.Schema {

    /**
     * A class that defines a field that can contain a single primitve value.
     */
    public class PrimitiveFieldType : AbstractFieldType, IAggregateableFieldType {

        internal PrimitiveType primitiveType;
        /**
         * The type of the primitive that can be stored in the field.
         */
        public PrimitiveType PrimitiveType { get { return this.primitiveType; } }

        /**
         * Creates a primitive field type of the given primitive.
         */
        public PrimitiveFieldType(PrimitiveType primitiveType) {
            this.primitiveType = primitiveType;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13 * hash) + this.PrimitiveType.GetHashCode();
                return hash;
            }
        }

        /**
         * Helper method to convert a PrimitiveType enum to a C# primitive type.
         */
        public static Type ToType(PrimitiveType primitiveType) {
            if (primitiveType == PrimitiveType.Short) {
                return typeof(short);
            }
            else if (primitiveType == PrimitiveType.UShort || primitiveType == PrimitiveType.VUShort) {
                return typeof(ushort);
            }
            else if (primitiveType == PrimitiveType.Int || primitiveType == PrimitiveType.VInt) {
                return typeof(int);
            }
            else if (primitiveType == PrimitiveType.UInt || primitiveType == PrimitiveType.VUInt) {
                return typeof(uint);
            }
            else if (primitiveType == PrimitiveType.Long || primitiveType == PrimitiveType.VLong) {
                return typeof(long);
            }
            else if (primitiveType == PrimitiveType.ULong || primitiveType == PrimitiveType.VULong) {
                return typeof(ulong);
            }
            else if (primitiveType == PrimitiveType.Float) {
                return typeof(float);
            }
            else if (primitiveType == PrimitiveType.Double) {
                return typeof(double);
            }
            else if (primitiveType == PrimitiveType.String) {
                return typeof(string);
            }
            else if (primitiveType == PrimitiveType.Bool) {
                return typeof(bool);
            }
            else if (primitiveType == PrimitiveType.Byte) {
                return typeof(byte);
            }
            else {
                throw new PatternBufferSchemaException("Unrecognized primitive type.");
            }
        }

        ///**
        // * A helper method to convert a C# primitive type to a PrimitiveType enum value.
        // */
        //public static PrimitiveType ToPrimitiveType(Type type) {
        //    if (type == typeof(short)) {
        //        return PrimitiveType.Short;
        //    }
        //    else if (type == typeof(ushort)) {
        //        return PrimitiveType.UShort;
        //    }
        //    else if (type == typeof(int)) {
        //        return PrimitiveType.Int;
        //    }
        //    else if (type == typeof(uint)) {
        //        return PrimitiveType.UInt;
        //    }
        //    else if (type == typeof(long)) {
        //        return PrimitiveType.Long;
        //    }
        //    else if (type == typeof(ulong)) {
        //        return PrimitiveType.ULong;
        //    }
        //    else if (type == typeof(float)) {
        //        return PrimitiveType.Float;
        //    }
        //    else if (type == typeof(double)) {
        //        return PrimitiveType.Double;
        //    }
        //    else if (type == typeof(string)) {
        //        return PrimitiveType.String;
        //    }
        //    else if (type == typeof(bool)) {
        //        return PrimitiveType.Bool;
        //    }
        //    else if (type == typeof(byte)) {
        //        return PrimitiveType.Byte;
        //    }
        //    else {
        //        throw new PatternBufferSchemaException("Unsupported primitive type.");
        //    }
        //}

    }
}
