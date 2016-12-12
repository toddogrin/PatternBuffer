
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System;
using System.Collections.Generic;
namespace Test.Enum {
    public class EnumSetObject : IEquatable <EnumSetObject>, IEnumSetObject {
        public EnumSetObject() {
            this.someEnumSetValue = default(HashSet<SomeEnum>);
        }

        public EnumSetObject(
            HashSet<SomeEnum> someEnumSetValue
        ) {
            this.someEnumSetValue = someEnumSetValue;
        }

        internal HashSet<SomeEnum> someEnumSetValue;
        public HashSet<SomeEnum> SomeEnumSetValue {
            get { return this.someEnumSetValue; }
            set { this.someEnumSetValue = value; }
        }

        public bool Equals(EnumSetObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is EnumSetObject)) { return false; }
            EnumSetObject that = (EnumSetObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // someEnumSetValue
            if (this.someEnumSetValue == null && that.someEnumSetValue != null) { return false; }
            if (that.someEnumSetValue != null && this.someEnumSetValue == null) { return false; }
            if (this.someEnumSetValue.Count != that.someEnumSetValue.Count) { return false; }
            HashSet<SomeEnum>.Enumerator enumerator_64fa8fa9fb = this.someEnumSetValue.GetEnumerator();
            HashSet<SomeEnum>.Enumerator enumerator_9d841fb72e = that.someEnumSetValue.GetEnumerator();
            while(true) {
                if ( ! enumerator_64fa8fa9fb.MoveNext()) { break; }
                enumerator_9d841fb72e.MoveNext();
            if ( enumerator_64fa8fa9fb.Current != enumerator_9d841fb72e.Current) { return false; }
            }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (someEnumSetValue == null ? 0 : someEnumSetValue.GetHashCode());
                return hash;
            }
        }
    }
}
