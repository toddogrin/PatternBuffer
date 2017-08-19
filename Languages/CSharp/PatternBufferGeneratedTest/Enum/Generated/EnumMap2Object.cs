
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Enum {
    public class EnumMap2Object : IEnumTestObject, IEquatable<EnumMap2Object> {

        public const ushort TYPE_ID = 14;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public Dictionary<SomeEnum,int> SomeEnumIntMapValue; // (required)

        public EnumMap2Object() {
            this.SomeEnumIntMapValue = default(Dictionary<SomeEnum,int>);
        }

        public EnumMap2Object(
            Dictionary<SomeEnum,int> someEnumIntMapValue
        ) {
            this.SomeEnumIntMapValue = someEnumIntMapValue;
        }

        public bool Equals(EnumMap2Object other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is EnumMap2Object)) { return false; }
            EnumMap2Object that = (EnumMap2Object)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // SomeEnumIntMapValue (required)
                if (this.SomeEnumIntMapValue == null && that.SomeEnumIntMapValue != null) { return false; }
                if (that.SomeEnumIntMapValue != null && this.SomeEnumIntMapValue == null) { return false; }
            if (that.SomeEnumIntMapValue.Count != this.SomeEnumIntMapValue.Count) { return false; }
            foreach (SomeEnum key in this.SomeEnumIntMapValue.Keys) {
                if ( ! that.SomeEnumIntMapValue.ContainsKey(key)) { return false; }
            }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (this.SomeEnumIntMapValue == null ? 0 : this.SomeEnumIntMapValue.GetHashCode());
                return hash;
            }
        }
    }
}
