using System;
using System.Collections.Generic;
using System.Text;

namespace PatternBuffer.Schema {

    /**
     * A class representing a list field in the schema definition, e.g. list<int> or list<MyType>
     */
    public class ListFieldType : AbstractFieldType, INullableFieldType {

        /**
         * True if this List is allowed to accept null as a value.
         */
        private bool isOptional;
        public bool IsNullable { get { return this.isOptional; } }

        /**
         * The type of object this list is supposed to contain
         */
        public IAggregateableFieldType ElementType { get; protected set; }

        /**
         * Creates a list field that can contain elements of the given type.
         */
        public ListFieldType(IAggregateableFieldType elementType) : this(elementType, false) { }
        public ListFieldType(IAggregateableFieldType elementType, bool isOptional) {
            this.ElementType = elementType;
            this.isOptional = isOptional;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13 * hash) + this.ElementType.GetHashCode();
                hash = (13 * hash) + this.IsNullable.GetHashCode();
                return hash;
            }
        }

    }
}
