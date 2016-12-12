
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System;
using System.Collections.Generic;
namespace Test.Map {
    public class ThingIntMapObject : IEquatable <ThingIntMapObject>, IThingIntMapObject {
        public ThingIntMapObject() {
            this.thingIntMap = default(Dictionary<IThing,int>);
        }

        public ThingIntMapObject(
            Dictionary<IThing,int> thingIntMap
        ) {
            this.thingIntMap = thingIntMap;
        }

        internal Dictionary<IThing,int> thingIntMap;
        public Dictionary<IThing,int> ThingIntMap {
            get { return this.thingIntMap; }
            set { this.thingIntMap = value; }
        }

        public bool Equals(ThingIntMapObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is ThingIntMapObject)) { return false; }
            ThingIntMapObject that = (ThingIntMapObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // thingIntMap
            if (this.thingIntMap == null && that.thingIntMap != null) { return false; }
            if (that.thingIntMap != null && this.thingIntMap == null) { return false; }
            if (that.thingIntMap.Count != this.thingIntMap.Count) { return false; }
            foreach (IThing key in this.thingIntMap.Keys) {
                if ( ! that.thingIntMap.ContainsKey(key)) { return false; }
            }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (thingIntMap == null ? 0 : thingIntMap.GetHashCode());
                return hash;
            }
        }
    }
}
