
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System;
using System.Collections.Generic;
namespace Test.Map {
    public class ThingThingMapObject : IEquatable <ThingThingMapObject>, IThingThingMapObject {
        public ThingThingMapObject() {
            this.thingThingMap = default(Dictionary<IThing,IThing>);
        }

        public ThingThingMapObject(
            Dictionary<IThing,IThing> thingThingMap
        ) {
            this.thingThingMap = thingThingMap;
        }

        internal Dictionary<IThing,IThing> thingThingMap;
        public Dictionary<IThing,IThing> ThingThingMap {
            get { return this.thingThingMap; }
            set { this.thingThingMap = value; }
        }

        public bool Equals(ThingThingMapObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is ThingThingMapObject)) { return false; }
            ThingThingMapObject that = (ThingThingMapObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // thingThingMap
            if (this.thingThingMap == null && that.thingThingMap != null) { return false; }
            if (that.thingThingMap != null && this.thingThingMap == null) { return false; }
            if (that.thingThingMap.Count != this.thingThingMap.Count) { return false; }
            foreach (IThing key in this.thingThingMap.Keys) {
                if ( ! that.thingThingMap.ContainsKey(key)) { return false; }
            }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (thingThingMap == null ? 0 : thingThingMap.GetHashCode());
                return hash;
            }
        }
    }
}
