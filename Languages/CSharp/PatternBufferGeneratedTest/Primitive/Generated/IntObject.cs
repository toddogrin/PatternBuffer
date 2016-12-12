
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System;
using System.Collections.Generic;
namespace Test.Primitive {
    public class IntObject : IEquatable <IntObject>, IIntObject {
        public IntObject() {
            this.intValue = default(int);
        }

        public IntObject(
            int intValue
        ) {
            this.intValue = intValue;
        }

        internal int intValue;
        public int IntValue {
            get { return this.intValue; }
            set { this.intValue = value; }
        }

        public bool Equals(IntObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is IntObject)) { return false; }
            IntObject that = (IntObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // intValue
            if (this.intValue != that.intValue) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + intValue.GetHashCode();
                return hash;
            }
        }
    }
}
