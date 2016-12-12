
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System;
using System.Collections.Generic;
namespace Test.Primitive {
    public class StringObject : IEquatable <StringObject>, IStringObject {
        public StringObject() {
            this.stringValue = default(string);
        }

        public StringObject(
            string stringValue
        ) {
            this.stringValue = stringValue;
        }

        internal string stringValue;
        public string StringValue {
            get { return this.stringValue; }
            set { this.stringValue = value; }
        }

        public bool Equals(StringObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is StringObject)) { return false; }
            StringObject that = (StringObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // stringValue
            if (this.stringValue == null && this.stringValue != null) { return false; }
            if (this.stringValue != null && this.stringValue == null) { return false; }
            if ( ! this.stringValue.Equals(that.stringValue)) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + stringValue.GetHashCode();
                return hash;
            }
        }
    }
}
