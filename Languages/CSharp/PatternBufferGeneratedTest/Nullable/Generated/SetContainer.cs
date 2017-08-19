
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Nullable {
    public class SetContainer : INullableTestObject, IEquatable<SetContainer> {

        public const ushort TYPE_ID = 14;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public HashSet<int> IntSet; // (required)

        public SetContainer() {
            this.IntSet = default(HashSet<int>);
        }

        public SetContainer(
            HashSet<int> intSet
        ) {
            this.IntSet = intSet;
        }

        public bool Equals(SetContainer other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is SetContainer)) { return false; }
            SetContainer that = (SetContainer)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // IntSet (required)
                if (this.IntSet == null && that.IntSet != null) { return false; }
                if (that.IntSet != null && this.IntSet == null) { return false; }
            if (this.IntSet != null && that.IntSet != null) {
                if (this.IntSet.Count != that.IntSet.Count) { return false; }
                HashSet<int>.Enumerator enumerator_iHMRz2T2dqor = this.IntSet.GetEnumerator();
                HashSet<int>.Enumerator enumerator_vVeH3ZC4KFgL = that.IntSet.GetEnumerator();
                while(true) {
                     if ( ! enumerator_iHMRz2T2dqor.MoveNext()) { break; }
                    enumerator_vVeH3ZC4KFgL.MoveNext();
            if (enumerator_iHMRz2T2dqor.Current != enumerator_vVeH3ZC4KFgL.Current) { return false; }
                }
            }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (this.IntSet == null ? 0 : this.IntSet.GetHashCode());
                return hash;
            }
        }
    }
}
