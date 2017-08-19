
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Nullable {
    public class AbstractThingContainer1 : INullableTestObject, IEquatable<AbstractThingContainer1> {

        public const ushort TYPE_ID = 0;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public Thing Thing1; // (optional)

        public AbstractThingContainer1() {
            this.Thing1 = default(Thing);
        }

        public AbstractThingContainer1(
            Thing thing1
        ) {
            this.Thing1 = thing1;
        }

        public bool Equals(AbstractThingContainer1 other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is AbstractThingContainer1)) { return false; }
            AbstractThingContainer1 that = (AbstractThingContainer1)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // Thing1 (optional)
            if ( ! (this.Thing1 == null && that.Thing1 == null)) {
                if (this.Thing1 == null && that.Thing1 != null) { return false; }
                if (that.Thing1 != null && this.Thing1 == null) { return false; }
            if ( ! this.Thing1.Equals(that.Thing1)) { return false; }
            }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (this.Thing1 == null ? 0 : this.Thing1.GetHashCode());
                return hash;
            }
        }
    }
}
