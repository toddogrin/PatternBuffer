
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
            List<AbstractThing>.Enumerator enumerator_sDnAjprx0chr = this.AbstractThingListValue.GetEnumerator();
            List<AbstractThing>.Enumerator enumerator_eCLfHiaOh3yG = that.AbstractThingListValue.GetEnumerator();
            while(true) {
                if ( ! enumerator_sDnAjprx0chr.MoveNext()) { break; }
                enumerator_eCLfHiaOh3yG.MoveNext();
            if (enumerator_sDnAjprx0chr.Current == null && enumerator_eCLfHiaOh3yG.Current != null) { return false; }
            if (enumerator_eCLfHiaOh3yG.Current != null && enumerator_sDnAjprx0chr.Current == null) { return false; }
            if ( ! enumerator_sDnAjprx0chr.Current.Equals(enumerator_eCLfHiaOh3yG.Current)) { return false; }
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
