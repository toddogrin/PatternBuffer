
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Enum {
    public class EnumObject : IEnumTestObject, IEquatable<EnumObject> {

        public const ushort TYPE_ID = 11;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public SomeEnum SomeEnumValue;

        public EnumObject() {
            this.SomeEnumValue = default(SomeEnum);
        }

        public EnumObject(
            SomeEnum someEnumValue
        ) {
            this.SomeEnumValue = someEnumValue;
        }

        public bool Equals(EnumObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is EnumObject)) { return false; }
            EnumObject that = (EnumObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // SomeEnumValue
            if ( this.SomeEnumValue != that.SomeEnumValue) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + this.SomeEnumValue.GetHashCode();
                return hash;
            }
        }
    }
}
