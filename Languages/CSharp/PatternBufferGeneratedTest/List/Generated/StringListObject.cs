
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System;
using System.Collections.Generic;
namespace Test.List {
    public class StringListObject : IEquatable <StringListObject>, IStringListObject {
        public StringListObject() {
            this.stringListValue = default(List<string>);
        }

        public StringListObject(
            List<string> stringListValue
        ) {
            this.stringListValue = stringListValue;
        }

        internal List<string> stringListValue;
        public List<string> StringListValue {
            get { return this.stringListValue; }
            set { this.stringListValue = value; }
        }

        public bool Equals(StringListObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is StringListObject)) { return false; }
            StringListObject that = (StringListObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // stringListValue
            if (this.stringListValue == null && that.stringListValue != null) { return false; }
            if (that.stringListValue != null && this.stringListValue == null) { return false; }
            if (this.stringListValue.Count != that.stringListValue.Count) { return false; }
            List<string>.Enumerator enumerator_c8e5a1c1a9 = this.stringListValue.GetEnumerator();
            List<string>.Enumerator enumerator_71397ef9fe = that.stringListValue.GetEnumerator();
            while(true) {
                if ( ! enumerator_c8e5a1c1a9.MoveNext()) { break; }
                enumerator_71397ef9fe.MoveNext();
            if (enumerator_c8e5a1c1a9.Current == null && enumerator_c8e5a1c1a9.Current != null) { return false; }
            if (enumerator_c8e5a1c1a9.Current != null && enumerator_c8e5a1c1a9.Current == null) { return false; }
            if ( ! enumerator_c8e5a1c1a9.Current.Equals(enumerator_71397ef9fe.Current)) { return false; }
            }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (stringListValue == null ? 0 : stringListValue.GetHashCode());
                return hash;
            }
        }
    }
}
