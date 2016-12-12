
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System;
using System.Collections.Generic;
namespace Test.Enum {
    public class EnumMap2Object : IEquatable <EnumMap2Object>, IEnumMap2Object {
        public EnumMap2Object() {
            this.someEnumIntMapValue = default(Dictionary<SomeEnum,int>);
        }

        public EnumMap2Object(
            Dictionary<SomeEnum,int> someEnumIntMapValue
        ) {
            this.someEnumIntMapValue = someEnumIntMapValue;
        }

        internal Dictionary<SomeEnum,int> someEnumIntMapValue;
        public Dictionary<SomeEnum,int> SomeEnumIntMapValue {
            get { return this.someEnumIntMapValue; }
            set { this.someEnumIntMapValue = value; }
        }

        public bool Equals(EnumMap2Object other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is EnumMap2Object)) { return false; }
            EnumMap2Object that = (EnumMap2Object)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // someEnumIntMapValue
            if (this.someEnumIntMapValue == null && that.someEnumIntMapValue != null) { return false; }
            if (that.someEnumIntMapValue != null && this.someEnumIntMapValue == null) { return false; }
            if (that.someEnumIntMapValue.Count != this.someEnumIntMapValue.Count) { return false; }
            foreach (SomeEnum key in this.someEnumIntMapValue.Keys) {
                if ( ! that.someEnumIntMapValue.ContainsKey(key)) { return false; }
            }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (someEnumIntMapValue == null ? 0 : someEnumIntMapValue.GetHashCode());
                return hash;
            }
        }
    }
}
