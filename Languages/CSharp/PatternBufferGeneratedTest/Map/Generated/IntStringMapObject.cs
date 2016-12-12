
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System;
using System.Collections.Generic;
namespace Test.Map {
    public class IntStringMapObject : IEquatable <IntStringMapObject>, IIntStringMapObject {
        public IntStringMapObject() {
            this.intStringMap = default(Dictionary<int,string>);
        }

        public IntStringMapObject(
            Dictionary<int,string> intStringMap
        ) {
            this.intStringMap = intStringMap;
        }

        internal Dictionary<int,string> intStringMap;
        public Dictionary<int,string> IntStringMap {
            get { return this.intStringMap; }
            set { this.intStringMap = value; }
        }

        public bool Equals(IntStringMapObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is IntStringMapObject)) { return false; }
            IntStringMapObject that = (IntStringMapObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // intStringMap
            if (this.intStringMap == null && that.intStringMap != null) { return false; }
            if (that.intStringMap != null && this.intStringMap == null) { return false; }
            if (that.intStringMap.Count != this.intStringMap.Count) { return false; }
            foreach (int key in this.intStringMap.Keys) {
                if ( ! that.intStringMap.ContainsKey(key)) { return false; }
            }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (intStringMap == null ? 0 : intStringMap.GetHashCode());
                return hash;
            }
        }
    }
}
