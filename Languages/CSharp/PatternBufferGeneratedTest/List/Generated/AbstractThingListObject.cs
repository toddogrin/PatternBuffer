
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

        public List<AbstractThing> AbstractThingListValue; // (required)

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
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is AbstractThingListObject)) { return false; }
            AbstractThingListObject that = (AbstractThingListObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // AbstractThingListValue (required)
                if (this.AbstractThingListValue == null && that.AbstractThingListValue != null) { return false; }
                if (that.AbstractThingListValue != null && this.AbstractThingListValue == null) { return false; }
            if (this.AbstractThingListValue != null && that.AbstractThingListValue != null) {
                if (this.AbstractThingListValue.Count != that.AbstractThingListValue.Count) { return false; }
                List<AbstractThing>.Enumerator enumerator_j6gW6c9mj0HB = this.AbstractThingListValue.GetEnumerator();
                List<AbstractThing>.Enumerator enumerator_yiWq0rqP8MRG = that.AbstractThingListValue.GetEnumerator();
                while(true) {
                     if ( ! enumerator_j6gW6c9mj0HB.MoveNext()) { break; }
                    enumerator_yiWq0rqP8MRG.MoveNext();
            if ( ! (enumerator_j6gW6c9mj0HB.Current == null && enumerator_yiWq0rqP8MRG.Current == null)) {
                if (enumerator_j6gW6c9mj0HB.Current == null && enumerator_yiWq0rqP8MRG.Current != null) { return false; }
                if (enumerator_yiWq0rqP8MRG.Current != null && enumerator_j6gW6c9mj0HB.Current == null) { return false; }
            if ( ! enumerator_j6gW6c9mj0HB.Current.Equals(enumerator_yiWq0rqP8MRG.Current)) { return false; }
            }
                }
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
