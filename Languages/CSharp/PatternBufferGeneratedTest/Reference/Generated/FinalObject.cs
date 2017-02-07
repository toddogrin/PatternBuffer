
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Reference {
    public class FinalObject : IReferenceTestObject, IEquatable<FinalObject> {

        public const ushort TYPE_ID = 12;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public Thing ThingValue;

        public FinalObject() {
            this.ThingValue = default(Thing);
        }

        public FinalObject(
            Thing thingValue
        ) {
            this.ThingValue = thingValue;
        }

        public bool Equals(FinalObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is FinalObject)) { return false; }
            FinalObject that = (FinalObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // ThingValue
            if (this.ThingValue == null && that.ThingValue != null) { return false; }
            if (that.ThingValue != null && this.ThingValue == null) { return false; }
            if ( ! this.ThingValue.Equals(that.ThingValue)) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (this.ThingValue == null ? 0 : this.ThingValue.GetHashCode());
                return hash;
            }
        }
    }
}
