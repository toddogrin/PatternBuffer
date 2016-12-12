
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System;
using System.Collections.Generic;
namespace Test.Primitive {
    public class ShortObject : IEquatable <ShortObject>, IShortObject {
        public ShortObject() {
            this.shortValue = default(short);
        }

        public ShortObject(
            short shortValue
        ) {
            this.shortValue = shortValue;
        }

        internal short shortValue;
        public short ShortValue {
            get { return this.shortValue; }
            set { this.shortValue = value; }
        }

        public bool Equals(ShortObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is ShortObject)) { return false; }
            ShortObject that = (ShortObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // shortValue
            if (this.shortValue != that.shortValue) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + shortValue.GetHashCode();
                return hash;
            }
        }
    }
}
