
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System;
using System.Collections.Generic;
namespace Test.Primitive {
    public class LongObject : IEquatable <LongObject>, ILongObject {
        public LongObject() {
            this.longValue = default(long);
        }

        public LongObject(
            long longValue
        ) {
            this.longValue = longValue;
        }

        internal long longValue;
        public long LongValue {
            get { return this.longValue; }
            set { this.longValue = value; }
        }

        public bool Equals(LongObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is LongObject)) { return false; }
            LongObject that = (LongObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // longValue
            if (this.longValue != that.longValue) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + longValue.GetHashCode();
                return hash;
            }
        }
    }
}
