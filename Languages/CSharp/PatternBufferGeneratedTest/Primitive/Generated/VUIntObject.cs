
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System;
using System.Collections.Generic;
namespace Test.Primitive {
    public class VUIntObject : IEquatable <VUIntObject>, IVUIntObject {
        public VUIntObject() {
            this.vuintValue = default(uint);
        }

        public VUIntObject(
            uint vuintValue
        ) {
            this.vuintValue = vuintValue;
        }

        internal uint vuintValue;
        public uint VuintValue {
            get { return this.vuintValue; }
            set { this.vuintValue = value; }
        }

        public bool Equals(VUIntObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is VUIntObject)) { return false; }
            VUIntObject that = (VUIntObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // vuintValue
            if (this.vuintValue != that.vuintValue) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + vuintValue.GetHashCode();
                return hash;
            }
        }
    }
}
