
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System;
using System.Collections.Generic;
namespace Test.List {
    public class AbstractThing : IEquatable <AbstractThing>, IAbstractThing {
        public AbstractThing() {
            this.intValue1 = default(int);
        }

        public AbstractThing(
            int intValue1
        ) {
            this.intValue1 = intValue1;
        }

        internal int intValue1;
        public int IntValue1 {
            get { return this.intValue1; }
            set { this.intValue1 = value; }
        }

        public bool Equals(AbstractThing other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (other == null) { return false; }
            if ( ! (other is AbstractThing)) { return false; }
            AbstractThing that = (AbstractThing)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // intValue1
            if (this.intValue1 != that.intValue1) { return false; }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + intValue1.GetHashCode();
                return hash;
            }
        }
    }
}
