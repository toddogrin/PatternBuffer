
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System;
using System.Collections.Generic;
namespace Test.Reference {
    public class AbstractReferenceObject : IEquatable <AbstractReferenceObject>, IAbstractReferenceObject {
        public AbstractReferenceObject() {
            this.thing = default(IAbstractThing);
        }

        public AbstractReferenceObject(
            IAbstractThing thing
        ) {
            this.thing = thing;
        }

        internal IAbstractThing thing;
        public IAbstractThing Thing {
            get { return this.thing; }
            set { this.thing = value; }
        }

        public bool Equals(AbstractReferenceObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is AbstractReferenceObject)) { return false; }
            AbstractReferenceObject that = (AbstractReferenceObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // thing
            if (this.thing == null && that.thing != null) { return false; }
            if (that.thing != null && this.thing == null) { return false; }
            if ( ! this.thing.Equals(that.thing)) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (thing == null ? 0 : thing.GetHashCode());
                return hash;
            }
        }
    }
}
