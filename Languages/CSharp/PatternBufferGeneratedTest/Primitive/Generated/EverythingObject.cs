
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System;
using System.Collections.Generic;
namespace Test.Primitive {
    public class EverythingObject : IEquatable <EverythingObject>, IEverythingObject {
        public EverythingObject() {
            this.shortValue = default(short);
            this.intValue = default(int);
            this.longValue = default(long);
            this.ushortValue = default(ushort);
            this.uintValue = default(uint);
            this.ulongValue = default(ulong);
            this.stringValue = default(string);
            this.doubleValue = default(double);
            this.floatValue = default(float);
            this.boolValue = default(bool);
            this.byteValue = default(byte);
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
            this.shortValue = shortValue;
            this.intValue = intValue;
            this.longValue = longValue;
            this.ushortValue = ushortValue;
            this.uintValue = uintValue;
            this.ulongValue = ulongValue;
            this.stringValue = stringValue;
            this.doubleValue = doubleValue;
            this.floatValue = floatValue;
            this.boolValue = boolValue;
            this.byteValue = byteValue;
        }

        internal short shortValue;
        public short ShortValue {
            get { return this.shortValue; }
            set { this.shortValue = value; }
        }

        internal int intValue;
        public int IntValue {
            get { return this.intValue; }
            set { this.intValue = value; }
        }

        internal long longValue;
        public long LongValue {
            get { return this.longValue; }
            set { this.longValue = value; }
        }

        internal ushort ushortValue;
        public ushort UshortValue {
            get { return this.ushortValue; }
            set { this.ushortValue = value; }
        }

        internal uint uintValue;
        public uint UintValue {
            get { return this.uintValue; }
            set { this.uintValue = value; }
        }

        internal ulong ulongValue;
        public ulong UlongValue {
            get { return this.ulongValue; }
            set { this.ulongValue = value; }
        }

        internal string stringValue;
        public string StringValue {
            get { return this.stringValue; }
            set { this.stringValue = value; }
        }

        internal double doubleValue;
        public double DoubleValue {
            get { return this.doubleValue; }
            set { this.doubleValue = value; }
        }

        internal float floatValue;
        public float FloatValue {
            get { return this.floatValue; }
            set { this.floatValue = value; }
        }

        internal bool boolValue;
        public bool BoolValue {
            get { return this.boolValue; }
            set { this.boolValue = value; }
        }

        internal byte byteValue;
        public byte ByteValue {
            get { return this.byteValue; }
            set { this.byteValue = value; }
        }

        public bool Equals(EverythingObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is EverythingObject)) { return false; }
            EverythingObject that = (EverythingObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // shortValue
            if (this.shortValue != that.shortValue) { return false; }
            // intValue
            if (this.intValue != that.intValue) { return false; }
            // longValue
            if (this.longValue != that.longValue) { return false; }
            // ushortValue
            if (this.ushortValue != that.ushortValue) { return false; }
            // uintValue
            if (this.uintValue != that.uintValue) { return false; }
            // ulongValue
            if (this.ulongValue != that.ulongValue) { return false; }
            // stringValue
            if (this.stringValue == null && this.stringValue != null) { return false; }
            if (this.stringValue != null && this.stringValue == null) { return false; }
            if ( ! this.stringValue.Equals(that.stringValue)) { return false; }
            // doubleValue
            if (this.doubleValue != that.doubleValue) { return false; }
            // floatValue
            if (this.floatValue != that.floatValue) { return false; }
            // boolValue
            if (this.boolValue != that.boolValue) { return false; }
            // byteValue
            if (this.byteValue != that.byteValue) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + shortValue.GetHashCode();
                hash = (13*hash) + intValue.GetHashCode();
                hash = (13*hash) + longValue.GetHashCode();
                hash = (13*hash) + ushortValue.GetHashCode();
                hash = (13*hash) + uintValue.GetHashCode();
                hash = (13*hash) + ulongValue.GetHashCode();
                hash = (13*hash) + stringValue.GetHashCode();
                hash = (13*hash) + doubleValue.GetHashCode();
                hash = (13*hash) + floatValue.GetHashCode();
                hash = (13*hash) + boolValue.GetHashCode();
                hash = (13*hash) + byteValue.GetHashCode();
                return hash;
            }
        }
    }
}
