
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Set {
    public class StringSetObject : ISetTestObject, IEquatable<StringSetObject> {

        public const ushort TYPE_ID = 13;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public HashSet<string> StringSetValue;

        public StringSetObject() {
            this.StringSetValue = default(HashSet<string>);
        }

        public StringSetObject(
            HashSet<string> stringSetValue
        ) {
            this.StringSetValue = stringSetValue;
        }

        public bool Equals(StringSetObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is StringSetObject)) { return false; }
            StringSetObject that = (StringSetObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // StringSetValue
            if (this.StringSetValue == null && that.StringSetValue != null) { return false; }
            if (that.StringSetValue != null && this.StringSetValue == null) { return false; }
            if (this.StringSetValue.Count != that.StringSetValue.Count) { return false; }
            HashSet<string>.Enumerator enumerator_oiJfm1wKzvxJ = this.StringSetValue.GetEnumerator();
            HashSet<string>.Enumerator enumerator_xgWZdZZqpNhY = that.StringSetValue.GetEnumerator();
            while(true) {
                if ( ! enumerator_oiJfm1wKzvxJ.MoveNext()) { break; }
                enumerator_xgWZdZZqpNhY.MoveNext();
            if (enumerator_oiJfm1wKzvxJ.Current == null && enumerator_oiJfm1wKzvxJ.Current != null) { return false; }
            if (enumerator_oiJfm1wKzvxJ.Current != null && enumerator_oiJfm1wKzvxJ.Current == null) { return false; }
            if ( ! enumerator_oiJfm1wKzvxJ.Current.Equals(enumerator_xgWZdZZqpNhY.Current)) { return false; }
            }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (this.StringSetValue == null ? 0 : this.StringSetValue.GetHashCode());
                return hash;
            }
        }
    }
}
