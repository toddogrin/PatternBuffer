
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Nullable {
    public class BaseTypeContainer : INullableTestObject, IEquatable<BaseTypeContainer> {

        public const ushort TYPE_ID = 12;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public BaseType Value1; // (optional)
        public BaseType Value2; // (optional)

        public BaseTypeContainer() {
            this.Value1 = default(BaseType);
            this.Value2 = default(BaseType);
        }

        public BaseTypeContainer(
            BaseType value1,
            BaseType value2
        ) {
            this.Value1 = value1;
            this.Value2 = value2;
        }

        public bool Equals(BaseTypeContainer other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is BaseTypeContainer)) { return false; }
            BaseTypeContainer that = (BaseTypeContainer)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // Value1 (optional)
            if ( ! (this.Value1 == null && that.Value1 == null)) {
                if (this.Value1 == null && that.Value1 != null) { return false; }
                if (that.Value1 != null && this.Value1 == null) { return false; }
            if ( ! this.Value1.Equals(that.Value1)) { return false; }
            }
            // Value2 (optional)
            if ( ! (this.Value2 == null && that.Value2 == null)) {
                if (this.Value2 == null && that.Value2 != null) { return false; }
                if (that.Value2 != null && this.Value2 == null) { return false; }
            if ( ! this.Value2.Equals(that.Value2)) { return false; }
            }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (this.Value1 == null ? 0 : this.Value1.GetHashCode());
                hash = (13*hash) + (this.Value2 == null ? 0 : this.Value2.GetHashCode());
                return hash;
            }
        }
    }
}
