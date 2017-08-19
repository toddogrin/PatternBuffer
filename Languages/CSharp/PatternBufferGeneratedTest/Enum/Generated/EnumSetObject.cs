
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Enum {
    public class EnumSetObject : IEnumTestObject, IEquatable<EnumSetObject> {

        public const ushort TYPE_ID = 15;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public HashSet<SomeEnum> SomeEnumSetValue;

        public EnumSetObject() {
            this.SomeEnumSetValue = default(HashSet<SomeEnum>);
        }

        public EnumSetObject(
            HashSet<SomeEnum> someEnumSetValue
        ) {
            this.SomeEnumSetValue = someEnumSetValue;
        }

        public bool Equals(EnumSetObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is EnumSetObject)) { return false; }
            EnumSetObject that = (EnumSetObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // SomeEnumSetValue
            if (this.SomeEnumSetValue == null && that.SomeEnumSetValue != null) { return false; }
            if (that.SomeEnumSetValue != null && this.SomeEnumSetValue == null) { return false; }
            if (this.SomeEnumSetValue.Count != that.SomeEnumSetValue.Count) { return false; }
            HashSet<SomeEnum>.Enumerator enumerator_kFNgkA6a6KKg = this.SomeEnumSetValue.GetEnumerator();
            HashSet<SomeEnum>.Enumerator enumerator_wK4cXtykRrAD = that.SomeEnumSetValue.GetEnumerator();
            while(true) {
                if ( ! enumerator_kFNgkA6a6KKg.MoveNext()) { break; }
                enumerator_wK4cXtykRrAD.MoveNext();
            if ( enumerator_kFNgkA6a6KKg.Current != enumerator_wK4cXtykRrAD.Current) { return false; }
            }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (this.SomeEnumSetValue == null ? 0 : this.SomeEnumSetValue.GetHashCode());
                return hash;
            }
        }
    }
}
