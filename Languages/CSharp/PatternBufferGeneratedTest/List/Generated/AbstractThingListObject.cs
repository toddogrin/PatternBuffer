
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.List {
    public class AbstractThingListObject : IListTestObject, IEquatable<AbstractThingListObject> {

        public const ushort TYPE_ID = 15;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public List<AbstractThing> AbstractThingListValue;

        public AbstractThingListObject() {
            this.AbstractThingListValue = default(List<AbstractThing>);
        }

        public AbstractThingListObject(
            List<AbstractThing> abstractThingListValue
        ) {
            this.AbstractThingListValue = abstractThingListValue;
        }

        public bool Equals(AbstractThingListObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is AbstractThingListObject)) { return false; }
            AbstractThingListObject that = (AbstractThingListObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // AbstractThingListValue
            if (this.AbstractThingListValue == null && that.AbstractThingListValue != null) { return false; }
            if (that.AbstractThingListValue != null && this.AbstractThingListValue == null) { return false; }
            if (this.AbstractThingListValue.Count != that.AbstractThingListValue.Count) { return false; }
            List<AbstractThing>.Enumerator enumerator_b1AF9MsienMM = this.AbstractThingListValue.GetEnumerator();
            List<AbstractThing>.Enumerator enumerator_zNC1yy8gPKDn = that.AbstractThingListValue.GetEnumerator();
            while(true) {
                if ( ! enumerator_b1AF9MsienMM.MoveNext()) { break; }
                enumerator_zNC1yy8gPKDn.MoveNext();
            if (enumerator_b1AF9MsienMM.Current == null && enumerator_zNC1yy8gPKDn.Current != null) { return false; }
            if (enumerator_zNC1yy8gPKDn.Current != null && enumerator_b1AF9MsienMM.Current == null) { return false; }
            if ( ! enumerator_b1AF9MsienMM.Current.Equals(enumerator_zNC1yy8gPKDn.Current)) { return false; }
            }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (this.AbstractThingListValue == null ? 0 : this.AbstractThingListValue.GetHashCode());
                return hash;
            }
        }
    }
}
