
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.List {
    public class Thing1ListObject : IListTestObject, IEquatable<Thing1ListObject> {

        public const ushort TYPE_ID = 14;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public List<Thing1> ThingListValue; // (required)

        public Thing1ListObject() {
            this.ThingListValue = default(List<Thing1>);
        }

        public Thing1ListObject(
            List<Thing1> thingListValue
        ) {
            this.ThingListValue = thingListValue;
        }

        public bool Equals(Thing1ListObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is Thing1ListObject)) { return false; }
            Thing1ListObject that = (Thing1ListObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // ThingListValue (required)
                if (this.ThingListValue == null && that.ThingListValue != null) { return false; }
                if (that.ThingListValue != null && this.ThingListValue == null) { return false; }
            if (this.ThingListValue != null && that.ThingListValue != null) {
                if (this.ThingListValue.Count != that.ThingListValue.Count) { return false; }
                List<Thing1>.Enumerator enumerator_d6gE9kr1NNCe = this.ThingListValue.GetEnumerator();
                List<Thing1>.Enumerator enumerator_wKaecprPTzqJ = that.ThingListValue.GetEnumerator();
                while(true) {
                     if ( ! enumerator_d6gE9kr1NNCe.MoveNext()) { break; }
                    enumerator_wKaecprPTzqJ.MoveNext();
            if ( ! (enumerator_d6gE9kr1NNCe.Current == null && enumerator_wKaecprPTzqJ.Current == null)) {
                if (enumerator_d6gE9kr1NNCe.Current == null && enumerator_wKaecprPTzqJ.Current != null) { return false; }
                if (enumerator_wKaecprPTzqJ.Current != null && enumerator_d6gE9kr1NNCe.Current == null) { return false; }
            if ( ! enumerator_d6gE9kr1NNCe.Current.Equals(enumerator_wKaecprPTzqJ.Current)) { return false; }
            }
                }
            }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (this.ThingListValue == null ? 0 : this.ThingListValue.GetHashCode());
                return hash;
            }
        }
    }
}
