
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System;
using System.Collections.Generic;
namespace Test.Primitive {
    public class ULongObject : IEquatable <ULongObject>, IULongObject {
        public ULongObject() {
            this.ulongValue = default(ulong);
        }

        public ULongObject(
            ulong ulongValue
        ) {
            this.ulongValue = ulongValue;
        }

        internal ulong ulongValue;
        public ulong UlongValue {
            get { return this.ulongValue; }
            set { this.ulongValue = value; }
        }

        public bool Equals(ULongObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is ULongObject)) { return false; }
            ULongObject that = (ULongObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // ulongValue
            if (this.ulongValue != that.ulongValue) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + ulongValue.GetHashCode();
                return hash;
            }
        }
    }
}
