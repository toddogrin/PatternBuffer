
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Nullable {
    public class DerivedType1 : BaseType, INullableTestObject, IEquatable<DerivedType1> {

        public new const ushort TYPE_ID = 10;
        public new ushort TypeId {
            get { return TYPE_ID; }
        }

        public long LongValue; // (required)

        public DerivedType1() {
            this.BooleanValue = default(bool);
            this.LongValue = default(long);
        }

        public DerivedType1(
            bool booleanValue,
            long longValue
        ) {
            this.BooleanValue = booleanValue;
            this.LongValue = longValue;
        }

        public bool Equals(DerivedType1 other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is DerivedType1)) { return false; }
            DerivedType1 that = (DerivedType1)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // LongValue (required)
            if (this.LongValue != that.LongValue) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + this.BooleanValue.GetHashCode();
                hash = (13*hash) + this.LongValue.GetHashCode();
                return hash;
            }
        }
    }
}
