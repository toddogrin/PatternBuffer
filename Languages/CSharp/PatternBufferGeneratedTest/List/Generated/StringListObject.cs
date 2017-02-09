
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.List {
    public class StringListObject : IListTestObject, IEquatable<StringListObject> {

        public const ushort TYPE_ID = 13;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public List<string> StringListValue;

        public StringListObject() {
            this.StringListValue = default(List<string>);
        }

        public StringListObject(
            List<string> stringListValue
        ) {
            this.StringListValue = stringListValue;
        }

        public bool Equals(StringListObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is StringListObject)) { return false; }
            StringListObject that = (StringListObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // StringListValue
            if (this.StringListValue == null && that.StringListValue != null) { return false; }
            if (that.StringListValue != null && this.StringListValue == null) { return false; }
            if (this.StringListValue.Count != that.StringListValue.Count) { return false; }
            List<string>.Enumerator enumerator_hLJe26c2fBMS = this.StringListValue.GetEnumerator();
            List<string>.Enumerator enumerator_sD30gQ5UEjHv = that.StringListValue.GetEnumerator();
            while(true) {
                if ( ! enumerator_hLJe26c2fBMS.MoveNext()) { break; }
                enumerator_sD30gQ5UEjHv.MoveNext();
            if (enumerator_hLJe26c2fBMS.Current == null && enumerator_hLJe26c2fBMS.Current != null) { return false; }
            if (enumerator_hLJe26c2fBMS.Current != null && enumerator_hLJe26c2fBMS.Current == null) { return false; }
            if ( ! enumerator_hLJe26c2fBMS.Current.Equals(enumerator_sD30gQ5UEjHv.Current)) { return false; }
            }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (this.StringListValue == null ? 0 : this.StringListValue.GetHashCode());
                return hash;
            }
        }
    }
}
