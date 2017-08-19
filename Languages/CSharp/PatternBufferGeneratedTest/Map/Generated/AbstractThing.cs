
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Map {
    public class AbstractThing : IMapTestObject, IEquatable<AbstractThing> {

        public const ushort TYPE_ID = 0;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public bool IsSomething; // (required)

        public AbstractThing() {
            this.IsSomething = default(bool);
        }

        public AbstractThing(
            bool isSomething
        ) {
            this.IsSomething = isSomething;
        }

        public bool Equals(AbstractThing other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is AbstractThing)) { return false; }
            AbstractThing that = (AbstractThing)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // IsSomething (required)
            if (this.IsSomething != that.IsSomething) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + this.IsSomething.GetHashCode();
                return hash;
            }
        }
    }
}
