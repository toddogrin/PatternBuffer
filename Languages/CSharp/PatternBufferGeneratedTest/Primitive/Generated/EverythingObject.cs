
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Primitive {
    public class EverythingObject : IPrimitiveTestObject, IEquatable<EverythingObject> {

        public const ushort TYPE_ID = 22;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public short ShortValue; // (required)
        public int IntValue; // (required)
        public long LongValue; // (required)
        public ushort UshortValue; // (required)
        public uint UintValue; // (required)
        public ulong UlongValue; // (required)
        public string StringValue; // (required)
        public double DoubleValue; // (required)
        public float FloatValue; // (required)
        public bool BoolValue; // (required)
        public byte ByteValue; // (required)

        public EverythingObject() {
            this.ShortValue = default(short);
            this.IntValue = default(int);
            this.LongValue = default(long);
            this.UshortValue = default(ushort);
            this.UintValue = default(uint);
            this.UlongValue = default(ulong);
            this.StringValue = default(string);
            this.DoubleValue = default(double);
            this.FloatValue = default(float);
            this.BoolValue = default(bool);
            this.ByteValue = default(byte);
        }

        public EverythingObject(
            short shortValue,
            int intValue,
            long longValue,
            ushort ushortValue,
            uint uintValue,
            ulong ulongValue,
            string stringValue,
            double doubleValue,
            float floatValue,
            bool boolValue,
            byte byteValue
        ) {
            this.ShortValue = shortValue;
            this.IntValue = intValue;
            this.LongValue = longValue;
            this.UshortValue = ushortValue;
            this.UintValue = uintValue;
            this.UlongValue = ulongValue;
            this.StringValue = stringValue;
            this.DoubleValue = doubleValue;
            this.FloatValue = floatValue;
            this.BoolValue = boolValue;
            this.ByteValue = byteValue;
        }

        public bool Equals(EverythingObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is EverythingObject)) { return false; }
            EverythingObject that = (EverythingObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // ShortValue (required)
            if (this.ShortValue != that.ShortValue) { return false; }
            // IntValue (required)
            if (this.IntValue != that.IntValue) { return false; }
            // LongValue (required)
            if (this.LongValue != that.LongValue) { return false; }
            // UshortValue (required)
            if (this.UshortValue != that.UshortValue) { return false; }
            // UintValue (required)
            if (this.UintValue != that.UintValue) { return false; }
            // UlongValue (required)
            if (this.UlongValue != that.UlongValue) { return false; }
            // StringValue (required)
                if (this.StringValue == null && this.StringValue != null) { return false; }
                if (this.StringValue != null && this.StringValue == null) { return false; }
            if ( ! this.StringValue.Equals(that.StringValue)) { return false; }
            // DoubleValue (required)
            if (this.DoubleValue != that.DoubleValue) { return false; }
            // FloatValue (required)
            if (this.FloatValue != that.FloatValue) { return false; }
            // BoolValue (required)
            if (this.BoolValue != that.BoolValue) { return false; }
            // ByteValue (required)
            if (this.ByteValue != that.ByteValue) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + this.ShortValue.GetHashCode();
                hash = (13*hash) + this.IntValue.GetHashCode();
                hash = (13*hash) + this.LongValue.GetHashCode();
                hash = (13*hash) + this.UshortValue.GetHashCode();
                hash = (13*hash) + this.UintValue.GetHashCode();
                hash = (13*hash) + this.UlongValue.GetHashCode();
                hash = (13*hash) + this.StringValue.GetHashCode();
                hash = (13*hash) + this.DoubleValue.GetHashCode();
                hash = (13*hash) + this.FloatValue.GetHashCode();
                hash = (13*hash) + this.BoolValue.GetHashCode();
                hash = (13*hash) + this.ByteValue.GetHashCode();
                return hash;
            }
        }
    }
}
