
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Nullable {
    public class ThingContainer3 : AbstractThingContainer2, INullableTestObject, IEquatable<ThingContainer3> {

        public new const ushort TYPE_ID = 9;
        public new ushort TypeId {
            get { return TYPE_ID; }
        }

        public Thing Thing3; // (optional)

        public ThingContainer3() {
            this.Thing1 = default(Thing);
            this.Thing2 = default(Thing);
            this.Thing3 = default(Thing);
        }

        public ThingContainer3(
            Thing thing1,
            Thing thing2,
            Thing thing3
        ) {
            this.Thing1 = thing1;
            this.Thing2 = thing2;
            this.Thing3 = thing3;
        }

        public bool Equals(ThingContainer3 other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is ThingContainer3)) { return false; }
            ThingContainer3 that = (ThingContainer3)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // Thing3 (optional)
            if ( ! (this.Thing3 == null && that.Thing3 == null)) {
                if (this.Thing3 == null && that.Thing3 != null) { return false; }
                if (that.Thing3 != null && this.Thing3 == null) { return false; }
            if ( ! this.Thing3.Equals(that.Thing3)) { return false; }
            }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (this.Thing1 == null ? 0 : this.Thing1.GetHashCode());
                hash = (13*hash) + (this.Thing2 == null ? 0 : this.Thing2.GetHashCode());
                hash = (13*hash) + (this.Thing3 == null ? 0 : this.Thing3.GetHashCode());
                return hash;
            }
        }
    }
}
