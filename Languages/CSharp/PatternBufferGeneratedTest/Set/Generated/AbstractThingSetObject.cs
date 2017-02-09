
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Set {
    public class AbstractThingSetObject : ISetTestObject, IEquatable<AbstractThingSetObject> {

        public const ushort TYPE_ID = 15;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public HashSet<AbstractThing> AbstractThingSetValue;

        public AbstractThingSetObject() {
            this.AbstractThingSetValue = default(HashSet<AbstractThing>);
        }

        public AbstractThingSetObject(
            HashSet<AbstractThing> abstractThingSetValue
        ) {
            this.AbstractThingSetValue = abstractThingSetValue;
        }

        public bool Equals(AbstractThingSetObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is AbstractThingSetObject)) { return false; }
            AbstractThingSetObject that = (AbstractThingSetObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // AbstractThingSetValue
            if (this.AbstractThingSetValue == null && that.AbstractThingSetValue != null) { return false; }
            if (that.AbstractThingSetValue != null && this.AbstractThingSetValue == null) { return false; }
            if (this.AbstractThingSetValue.Count != that.AbstractThingSetValue.Count) { return false; }
            HashSet<AbstractThing>.Enumerator enumerator_aHwjQIc5aVo7 = this.AbstractThingSetValue.GetEnumerator();
            HashSet<AbstractThing>.Enumerator enumerator_xW6d28LUc4m9 = that.AbstractThingSetValue.GetEnumerator();
            while(true) {
                if ( ! enumerator_aHwjQIc5aVo7.MoveNext()) { break; }
                enumerator_xW6d28LUc4m9.MoveNext();
            if (enumerator_aHwjQIc5aVo7.Current == null && enumerator_xW6d28LUc4m9.Current != null) { return false; }
            if (enumerator_xW6d28LUc4m9.Current != null && enumerator_aHwjQIc5aVo7.Current == null) { return false; }
            if ( ! enumerator_aHwjQIc5aVo7.Current.Equals(enumerator_xW6d28LUc4m9.Current)) { return false; }
            }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (this.AbstractThingSetValue == null ? 0 : this.AbstractThingSetValue.GetHashCode());
                return hash;
            }
        }
    }
}
