
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System;
using System.Collections.Generic;
namespace Test.Set {
    public class AbstractThingSetObject : IEquatable <AbstractThingSetObject>, IAbstractThingSetObject {
        public AbstractThingSetObject() {
            this.abstractThingSetValue = default(HashSet<IAbstractThing>);
        }

        public AbstractThingSetObject(
            HashSet<IAbstractThing> abstractThingSetValue
        ) {
            this.abstractThingSetValue = abstractThingSetValue;
        }

        internal HashSet<IAbstractThing> abstractThingSetValue;
        public HashSet<IAbstractThing> AbstractThingSetValue {
            get { return this.abstractThingSetValue; }
            set { this.abstractThingSetValue = value; }
        }

        public bool Equals(AbstractThingSetObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is AbstractThingSetObject)) { return false; }
            AbstractThingSetObject that = (AbstractThingSetObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // abstractThingSetValue
            if (this.abstractThingSetValue == null && that.abstractThingSetValue != null) { return false; }
            if (that.abstractThingSetValue != null && this.abstractThingSetValue == null) { return false; }
            if (this.abstractThingSetValue.Count != that.abstractThingSetValue.Count) { return false; }
            HashSet<IAbstractThing>.Enumerator enumerator_c11e43ee31 = this.abstractThingSetValue.GetEnumerator();
            HashSet<IAbstractThing>.Enumerator enumerator_a5a3d09c2e = that.abstractThingSetValue.GetEnumerator();
            while(true) {
                if ( ! enumerator_c11e43ee31.MoveNext()) { break; }
                enumerator_a5a3d09c2e.MoveNext();
            if (enumerator_c11e43ee31.Current == null && enumerator_a5a3d09c2e.Current != null) { return false; }
            if (enumerator_a5a3d09c2e.Current != null && enumerator_c11e43ee31.Current == null) { return false; }
            if ( ! enumerator_c11e43ee31.Current.Equals(enumerator_a5a3d09c2e.Current)) { return false; }
            }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (abstractThingSetValue == null ? 0 : abstractThingSetValue.GetHashCode());
                return hash;
            }
        }
    }
}
