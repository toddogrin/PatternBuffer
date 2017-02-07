
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Map {
    public class ThingIntMapObject : IMapTestObject, IEquatable<ThingIntMapObject> {

        public const ushort TYPE_ID = 12;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public Dictionary<Thing,int> ThingIntMap;

        public ThingIntMapObject() {
            this.ThingIntMap = default(Dictionary<Thing,int>);
        }

        public ThingIntMapObject(
            Dictionary<Thing,int> thingIntMap
        ) {
            this.ThingIntMap = thingIntMap;
        }

        public bool Equals(ThingIntMapObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is ThingIntMapObject)) { return false; }
            ThingIntMapObject that = (ThingIntMapObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // ThingIntMap
            if (this.ThingIntMap == null && that.ThingIntMap != null) { return false; }
            if (that.ThingIntMap != null && this.ThingIntMap == null) { return false; }
            if (that.ThingIntMap.Count != this.ThingIntMap.Count) { return false; }
            foreach (Thing key in this.ThingIntMap.Keys) {
                if ( ! that.ThingIntMap.ContainsKey(key)) { return false; }
            }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (this.ThingIntMap == null ? 0 : this.ThingIntMap.GetHashCode());
                return hash;
            }
        }
    }
}
