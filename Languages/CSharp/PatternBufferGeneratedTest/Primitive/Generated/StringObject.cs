
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Primitive {
    public class StringObject : IPrimitiveTestObject, IEquatable<StringObject> {

        public const ushort TYPE_ID = 17;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public string StringValue;

        public StringObject() {
            this.StringValue = default(string);
        }

        public StringObject(
            string stringValue
        ) {
            this.StringValue = stringValue;
        }

        public bool Equals(StringObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is StringObject)) { return false; }
            StringObject that = (StringObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // StringValue
            if (this.StringValue == null && this.StringValue != null) { return false; }
            if (this.StringValue != null && this.StringValue == null) { return false; }
            if ( ! this.StringValue.Equals(that.StringValue)) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + this.StringValue.GetHashCode();
                return hash;
            }
        }
    }
}
