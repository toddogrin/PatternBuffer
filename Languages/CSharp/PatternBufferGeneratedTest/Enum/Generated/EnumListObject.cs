
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System;
using System.Collections.Generic;
namespace Test.Enum {
    public class EnumListObject : IEquatable <EnumListObject>, IEnumListObject {
        public EnumListObject() {
            this.someEnumListValue = default(List<SomeEnum>);
        }

        public EnumListObject(
            List<SomeEnum> someEnumListValue
        ) {
            this.someEnumListValue = someEnumListValue;
        }

        internal List<SomeEnum> someEnumListValue;
        public List<SomeEnum> SomeEnumListValue {
            get { return this.someEnumListValue; }
            set { this.someEnumListValue = value; }
        }

        public bool Equals(EnumListObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is EnumListObject)) { return false; }
            EnumListObject that = (EnumListObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // someEnumListValue
            if (this.someEnumListValue == null && that.someEnumListValue != null) { return false; }
            if (that.someEnumListValue != null && this.someEnumListValue == null) { return false; }
            if (this.someEnumListValue.Count != that.someEnumListValue.Count) { return false; }
            List<SomeEnum>.Enumerator enumerator_d15327999b = this.someEnumListValue.GetEnumerator();
            List<SomeEnum>.Enumerator enumerator_ebf87cf820 = that.someEnumListValue.GetEnumerator();
            while(true) {
                if ( ! enumerator_d15327999b.MoveNext()) { break; }
                enumerator_ebf87cf820.MoveNext();
            if ( enumerator_d15327999b.Current != enumerator_ebf87cf820.Current) { return false; }
            }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (someEnumListValue == null ? 0 : someEnumListValue.GetHashCode());
                return hash;
            }
        }
    }
}
