
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System;
using System.Collections.Generic;
namespace Test.Primitive {
    public class VIntObject : IEquatable <VIntObject>, IVIntObject {
        public VIntObject() {
            this.vintValue = default(int);
        }

        public VIntObject(
            int vintValue
        ) {
            this.vintValue = vintValue;
        }

        internal int vintValue;
        public int VintValue {
            get { return this.vintValue; }
            set { this.vintValue = value; }
        }

        public bool Equals(VIntObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is VIntObject)) { return false; }
            VIntObject that = (VIntObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // vintValue
            if (this.vintValue != that.vintValue) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + vintValue.GetHashCode();
                return hash;
            }
        }
    }
}
