
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System;
using System.Collections.Generic;
namespace Test.Enum {
    public class EnumMapObject : IEquatable <EnumMapObject>, IEnumMapObject {
        public EnumMapObject() {
            this.intSomeEnumMapValue = default(Dictionary<int,SomeEnum>);
        }

        public EnumMapObject(
            Dictionary<int,SomeEnum> intSomeEnumMapValue
        ) {
            this.intSomeEnumMapValue = intSomeEnumMapValue;
        }

        internal Dictionary<int,SomeEnum> intSomeEnumMapValue;
        public Dictionary<int,SomeEnum> IntSomeEnumMapValue {
            get { return this.intSomeEnumMapValue; }
            set { this.intSomeEnumMapValue = value; }
        }

        public bool Equals(EnumMapObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is EnumMapObject)) { return false; }
            EnumMapObject that = (EnumMapObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // intSomeEnumMapValue
            if (this.intSomeEnumMapValue == null && that.intSomeEnumMapValue != null) { return false; }
            if (that.intSomeEnumMapValue != null && this.intSomeEnumMapValue == null) { return false; }
            if (that.intSomeEnumMapValue.Count != this.intSomeEnumMapValue.Count) { return false; }
            foreach (int key in this.intSomeEnumMapValue.Keys) {
                if ( ! that.intSomeEnumMapValue.ContainsKey(key)) { return false; }
            }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (intSomeEnumMapValue == null ? 0 : intSomeEnumMapValue.GetHashCode());
                return hash;
            }
        }
    }
}
