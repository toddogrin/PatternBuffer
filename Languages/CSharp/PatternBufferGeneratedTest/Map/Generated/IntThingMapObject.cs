
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System;
using System.Collections.Generic;
namespace Test.Map {
    public class IntThingMapObject : IEquatable <IntThingMapObject>, IIntThingMapObject {
        public IntThingMapObject() {
            this.intThingMap = default(Dictionary<int,IThing>);
        }

        public IntThingMapObject(
            Dictionary<int,IThing> intThingMap
        ) {
            this.intThingMap = intThingMap;
        }

        internal Dictionary<int,IThing> intThingMap;
        public Dictionary<int,IThing> IntThingMap {
            get { return this.intThingMap; }
            set { this.intThingMap = value; }
        }

        public bool Equals(IntThingMapObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is IntThingMapObject)) { return false; }
            IntThingMapObject that = (IntThingMapObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // intThingMap
            if (this.intThingMap == null && that.intThingMap != null) { return false; }
            if (that.intThingMap != null && this.intThingMap == null) { return false; }
            if (that.intThingMap.Count != this.intThingMap.Count) { return false; }
            foreach (int key in this.intThingMap.Keys) {
                if ( ! that.intThingMap.ContainsKey(key)) { return false; }
            }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (intThingMap == null ? 0 : intThingMap.GetHashCode());
                return hash;
            }
        }
    }
}
