
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Enum {
    public class EnumListObject : IEnumTestObject, IEquatable<EnumListObject> {

        public const ushort TYPE_ID = 12;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public List<SomeEnum> SomeEnumListValue;

        public EnumListObject() {
            this.SomeEnumListValue = default(List<SomeEnum>);
        }

        public EnumListObject(
            List<SomeEnum> someEnumListValue
        ) {
            this.SomeEnumListValue = someEnumListValue;
        }

        public bool Equals(EnumListObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is EnumListObject)) { return false; }
            EnumListObject that = (EnumListObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // SomeEnumListValue
            if (this.SomeEnumListValue == null && that.SomeEnumListValue != null) { return false; }
            if (that.SomeEnumListValue != null && this.SomeEnumListValue == null) { return false; }
            if (this.SomeEnumListValue.Count != that.SomeEnumListValue.Count) { return false; }
            List<SomeEnum>.Enumerator enumerator_tC27JAyEinfZ = this.SomeEnumListValue.GetEnumerator();
            List<SomeEnum>.Enumerator enumerator_bE71NYlH3LAM = that.SomeEnumListValue.GetEnumerator();
            while(true) {
                if ( ! enumerator_tC27JAyEinfZ.MoveNext()) { break; }
                enumerator_bE71NYlH3LAM.MoveNext();
            if ( enumerator_tC27JAyEinfZ.Current != enumerator_bE71NYlH3LAM.Current) { return false; }
            }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (this.SomeEnumListValue == null ? 0 : this.SomeEnumListValue.GetHashCode());
                return hash;
            }
        }
    }
}
