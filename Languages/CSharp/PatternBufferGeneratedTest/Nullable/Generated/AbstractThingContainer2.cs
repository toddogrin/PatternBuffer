
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Nullable {
    public class AbstractThingContainer2 : AbstractThingContainer1, INullableTestObject, IEquatable<AbstractThingContainer2> {

        public new const ushort TYPE_ID = 0;
        public new ushort TypeId {
            get { return TYPE_ID; }
        }

        public Thing Thing2; // (optional)

        public AbstractThingContainer2() {
            this.Thing1 = default(Thing);
            this.Thing2 = default(Thing);
        }

        public AbstractThingContainer2(
            Thing thing1,
            Thing thing2
        ) {
            this.Thing1 = thing1;
            this.Thing2 = thing2;
        }

        public bool Equals(AbstractThingContainer2 other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is AbstractThingContainer2)) { return false; }
            AbstractThingContainer2 that = (AbstractThingContainer2)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // Thing2 (optional)
            if ( ! (this.Thing2 == null && that.Thing2 == null)) {
                if (this.Thing2 == null && that.Thing2 != null) { return false; }
                if (that.Thing2 != null && this.Thing2 == null) { return false; }
            if ( ! this.Thing2.Equals(that.Thing2)) { return false; }
            }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (this.Thing1 == null ? 0 : this.Thing1.GetHashCode());
                hash = (13*hash) + (this.Thing2 == null ? 0 : this.Thing2.GetHashCode());
                return hash;
            }
        }
    }
}
