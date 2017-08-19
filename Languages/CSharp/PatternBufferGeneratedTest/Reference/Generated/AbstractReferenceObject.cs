
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Reference {
    public class AbstractReferenceObject : IReferenceTestObject, IEquatable<AbstractReferenceObject> {

        public const ushort TYPE_ID = 24;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public AbstractThing Thing; // (optional)

        public AbstractReferenceObject() {
            this.Thing = default(AbstractThing);
        }

        public AbstractReferenceObject(
            AbstractThing thing
        ) {
            this.Thing = thing;
        }

        public bool Equals(AbstractReferenceObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is AbstractReferenceObject)) { return false; }
            AbstractReferenceObject that = (AbstractReferenceObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // Thing (optional)
            if ( ! (this.Thing == null && that.Thing == null)) {
                if (this.Thing == null && that.Thing != null) { return false; }
                if (that.Thing != null && this.Thing == null) { return false; }
            if ( ! this.Thing.Equals(that.Thing)) { return false; }
            }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (this.Thing == null ? 0 : this.Thing.GetHashCode());
                return hash;
            }
        }
    }
}
