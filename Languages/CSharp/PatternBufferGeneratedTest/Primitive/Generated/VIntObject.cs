
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Primitive {
    public class VIntObject : IPrimitiveTestObject, IEquatable<VIntObject> {

        public const ushort TYPE_ID = 112;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public int VintValue;

        public VIntObject() {
            this.VintValue = default(int);
        }

        public VIntObject(
            int vintValue
        ) {
            this.VintValue = vintValue;
        }

        public bool Equals(VIntObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is VIntObject)) { return false; }
            VIntObject that = (VIntObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // VintValue
            if (this.VintValue != that.VintValue) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + this.VintValue.GetHashCode();
                return hash;
            }
        }
    }
}
