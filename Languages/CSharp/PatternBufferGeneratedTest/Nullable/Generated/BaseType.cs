
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Nullable {
    public class BaseType : INullableTestObject, IEquatable<BaseType> {

        public const ushort TYPE_ID = 0;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public bool BooleanValue; // (required)

        public BaseType() {
            this.BooleanValue = default(bool);
        }

        public BaseType(
            bool booleanValue
        ) {
            this.BooleanValue = booleanValue;
        }

        public bool Equals(BaseType other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is BaseType)) { return false; }
            BaseType that = (BaseType)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // BooleanValue (required)
            if (this.BooleanValue != that.BooleanValue) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + this.BooleanValue.GetHashCode();
                return hash;
            }
        }
    }
}
