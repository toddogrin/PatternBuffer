
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

        public List<SomeEnum> SomeEnumListValue; // (required)

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
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is EnumListObject)) { return false; }
            EnumListObject that = (EnumListObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // SomeEnumListValue (required)
                if (this.SomeEnumListValue == null && that.SomeEnumListValue != null) { return false; }
                if (that.SomeEnumListValue != null && this.SomeEnumListValue == null) { return false; }
            if (this.SomeEnumListValue != null && that.SomeEnumListValue != null) {
                if (this.SomeEnumListValue.Count != that.SomeEnumListValue.Count) { return false; }
                List<SomeEnum>.Enumerator enumerator_m1SQ2sqCnH1J = this.SomeEnumListValue.GetEnumerator();
                List<SomeEnum>.Enumerator enumerator_xcVJa5Gu9sYh = that.SomeEnumListValue.GetEnumerator();
                while(true) {
                     if ( ! enumerator_m1SQ2sqCnH1J.MoveNext()) { break; }
                    enumerator_xcVJa5Gu9sYh.MoveNext();
            if ( enumerator_m1SQ2sqCnH1J.Current != enumerator_xcVJa5Gu9sYh.Current) { return false; }
                }
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
