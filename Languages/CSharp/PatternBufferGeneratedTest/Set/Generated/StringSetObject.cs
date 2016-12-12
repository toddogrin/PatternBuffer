
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System;
using System.Collections.Generic;
namespace Test.Set {
    public class StringSetObject : IEquatable <StringSetObject>, IStringSetObject {
        public StringSetObject() {
            this.stringSetValue = default(HashSet<string>);
        }

        public StringSetObject(
            HashSet<string> stringSetValue
        ) {
            this.stringSetValue = stringSetValue;
        }

        internal HashSet<string> stringSetValue;
        public HashSet<string> StringSetValue {
            get { return this.stringSetValue; }
            set { this.stringSetValue = value; }
        }

        public bool Equals(StringSetObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is StringSetObject)) { return false; }
            StringSetObject that = (StringSetObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // stringSetValue
            if (this.stringSetValue == null && that.stringSetValue != null) { return false; }
            if (that.stringSetValue != null && this.stringSetValue == null) { return false; }
            if (this.stringSetValue.Count != that.stringSetValue.Count) { return false; }
            HashSet<string>.Enumerator enumerator_5e94eede45 = this.stringSetValue.GetEnumerator();
            HashSet<string>.Enumerator enumerator_7c061d88e4 = that.stringSetValue.GetEnumerator();
            while(true) {
                if ( ! enumerator_5e94eede45.MoveNext()) { break; }
                enumerator_7c061d88e4.MoveNext();
            if (enumerator_5e94eede45.Current == null && enumerator_5e94eede45.Current != null) { return false; }
            if (enumerator_5e94eede45.Current != null && enumerator_5e94eede45.Current == null) { return false; }
            if ( ! enumerator_5e94eede45.Current.Equals(enumerator_7c061d88e4.Current)) { return false; }
            }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (stringSetValue == null ? 0 : stringSetValue.GetHashCode());
                return hash;
            }
        }
    }
}
