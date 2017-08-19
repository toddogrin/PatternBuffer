
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

        public List<string> StringListValue; // (required)

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
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is StringListObject)) { return false; }
            StringListObject that = (StringListObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // StringListValue (required)
                if (this.StringListValue == null && that.StringListValue != null) { return false; }
                if (that.StringListValue != null && this.StringListValue == null) { return false; }
            if (this.StringListValue != null && that.StringListValue != null) {
                if (this.StringListValue.Count != that.StringListValue.Count) { return false; }
                List<string>.Enumerator enumerator_t5oPydNWAhj3 = this.StringListValue.GetEnumerator();
                List<string>.Enumerator enumerator_iBQJg5ZSoHVx = that.StringListValue.GetEnumerator();
                while(true) {
                     if ( ! enumerator_t5oPydNWAhj3.MoveNext()) { break; }
                    enumerator_iBQJg5ZSoHVx.MoveNext();
                if (enumerator_t5oPydNWAhj3.Current == null && enumerator_t5oPydNWAhj3.Current != null) { return false; }
                if (enumerator_t5oPydNWAhj3.Current != null && enumerator_t5oPydNWAhj3.Current == null) { return false; }
            if ( ! enumerator_t5oPydNWAhj3.Current.Equals(enumerator_iBQJg5ZSoHVx.Current)) { return false; }
                }
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
