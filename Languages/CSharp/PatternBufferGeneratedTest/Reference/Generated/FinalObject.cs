
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System;
using System.Collections.Generic;
namespace Test.Reference {
    public class FinalObject : IEquatable <FinalObject>, IFinalObject {
        public FinalObject() {
            this.thingValue = default(IThing);
        }

        public FinalObject(
            IThing thingValue
        ) {
            this.thingValue = thingValue;
        }

        internal IThing thingValue;
        public IThing ThingValue {
            get { return this.thingValue; }
            set { this.thingValue = value; }
        }

        public bool Equals(FinalObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is FinalObject)) { return false; }
            FinalObject that = (FinalObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // thingValue
            if (this.thingValue == null && that.thingValue != null) { return false; }
            if (that.thingValue != null && this.thingValue == null) { return false; }
            if ( ! this.thingValue.Equals(that.thingValue)) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (thingValue == null ? 0 : thingValue.GetHashCode());
                return hash;
            }
        }
    }
}
