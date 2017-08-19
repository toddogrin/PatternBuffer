
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System;
using System.Collections.Generic;
namespace Test.Nullable {
    public class ListContainer : INullableTestObject, IEquatable<ListContainer> {

        public const ushort TYPE_ID = 13;
        public ushort TypeId {
            get { return TYPE_ID; }
        }

        public List<int> IntList; // (required)

        public ListContainer() {
            this.IntList = default(List<int>);
        }

        public ListContainer(
            List<int> intList
        ) {
            this.IntList = intList;
        }

        public bool Equals(ListContainer other) {
            return this.Equals((object)other);
        }
        public override bool Equals(object other) {;
            if (Object.ReferenceEquals(this, other)) { return true; }
            if ( ! (other is ListContainer)) { return false; }
            ListContainer that = (ListContainer)other;
            if (this.GetHashCode() != that.GetHashCode()) return false;
            // IntList (required)
                if (this.IntList == null && that.IntList != null) { return false; }
                if (that.IntList != null && this.IntList == null) { return false; }
            if (this.IntList != null && that.IntList != null) {
                if (this.IntList.Count != that.IntList.Count) { return false; }
                List<int>.Enumerator enumerator_a2pqb7mhnOMh = this.IntList.GetEnumerator();
                List<int>.Enumerator enumerator_pClzOiMK3yVy = that.IntList.GetEnumerator();
                while(true) {
                     if ( ! enumerator_a2pqb7mhnOMh.MoveNext()) { break; }
                    enumerator_pClzOiMK3yVy.MoveNext();
            if (enumerator_a2pqb7mhnOMh.Current != enumerator_pClzOiMK3yVy.Current) { return false; }
                }
            }
            return true;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13*hash) + (this.IntList == null ? 0 : this.IntList.GetHashCode());
                return hash;
            }
        }
    }
}
