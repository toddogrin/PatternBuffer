
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System;
using System.Collections.Generic;
namespace Test.Enum {
    public class EnumObject : IEquatable <EnumObject>, IEnumObject {
        public EnumObject() {
            this.someEnumValue = default(SomeEnum);
        }

        public EnumObject(
            SomeEnum someEnumValue
        ) {
            this.someEnumValue = someEnumValue;
        }

        internal SomeEnum someEnumValue;
        public SomeEnum SomeEnumValue {
            get { return this.someEnumValue; }
            set { this.someEnumValue = value; }
        }

        public bool Equals(EnumObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is EnumObject)) { return false; }
            EnumObject that = (EnumObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // someEnumValue
            if ( this.someEnumValue != that.someEnumValue) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + someEnumValue.GetHashCode();
                return hash;
            }
        }
    }
}
