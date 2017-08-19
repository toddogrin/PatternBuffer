
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Enum {
    public class EnumMapObject : IEnumTestObject, IEquatable<EnumMapObject> {

        public const ushort TYPE_ID = 13;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public Dictionary<int,SomeEnum> IntSomeEnumMapValue; // (required)

        public EnumMapObject() {
            this.IntSomeEnumMapValue = default(Dictionary<int,SomeEnum>);
        }

        public EnumMapObject(
            Dictionary<int,SomeEnum> intSomeEnumMapValue
        ) {
            this.IntSomeEnumMapValue = intSomeEnumMapValue;
        }

        public bool Equals(EnumMapObject other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is EnumMapObject)) { return false; }
            EnumMapObject that = (EnumMapObject)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // IntSomeEnumMapValue (required)
                if (this.IntSomeEnumMapValue == null && that.IntSomeEnumMapValue != null) { return false; }
                if (that.IntSomeEnumMapValue != null && this.IntSomeEnumMapValue == null) { return false; }
            if (that.IntSomeEnumMapValue.Count != this.IntSomeEnumMapValue.Count) { return false; }
            foreach (int key in this.IntSomeEnumMapValue.Keys) {
                if ( ! that.IntSomeEnumMapValue.ContainsKey(key)) { return false; }
            }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (this.IntSomeEnumMapValue == null ? 0 : this.IntSomeEnumMapValue.GetHashCode());
                return hash;
            }
        }
    }
}
