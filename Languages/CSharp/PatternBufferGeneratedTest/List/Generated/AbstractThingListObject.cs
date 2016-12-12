
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System;
using System.Collections.Generic;
namespace Test.List {
    public class AbstractThingListObject : IEquatable <AbstractThingListObject>, IAbstractThingListObject {
        public AbstractThingListObject() {
            this.abstractThingListValue = default(List<IAbstractThing>);
        }

        public AbstractThingListObject(
            List<IAbstractThing> abstractThingListValue
        ) {
            this.abstractThingListValue = abstractThingListValue;
        }

        internal List<IAbstractThing> abstractThingListValue;
        public List<IAbstractThing> AbstractThingListValue {
            get { return this.abstractThingListValue; }
            set { this.abstractThingListValue = value; }
        }

        public bool Equals(AbstractThingListObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is AbstractThingListObject)) { return false; }
            AbstractThingListObject that = (AbstractThingListObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // abstractThingListValue
            if (this.abstractThingListValue == null && that.abstractThingListValue != null) { return false; }
            if (that.abstractThingListValue != null && this.abstractThingListValue == null) { return false; }
            if (this.abstractThingListValue.Count != that.abstractThingListValue.Count) { return false; }
            List<IAbstractThing>.Enumerator enumerator_17bc5a4d8c = this.abstractThingListValue.GetEnumerator();
            List<IAbstractThing>.Enumerator enumerator_e40fd5293b = that.abstractThingListValue.GetEnumerator();
            while(true) {
                if ( ! enumerator_17bc5a4d8c.MoveNext()) { break; }
                enumerator_e40fd5293b.MoveNext();
            if (enumerator_17bc5a4d8c.Current == null && enumerator_e40fd5293b.Current != null) { return false; }
            if (enumerator_e40fd5293b.Current != null && enumerator_17bc5a4d8c.Current == null) { return false; }
            if ( ! enumerator_17bc5a4d8c.Current.Equals(enumerator_e40fd5293b.Current)) { return false; }
            }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (abstractThingListValue == null ? 0 : abstractThingListValue.GetHashCode());
                return hash;
            }
        }
    }
}
