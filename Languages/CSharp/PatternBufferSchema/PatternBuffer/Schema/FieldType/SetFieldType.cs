using System;
using System.Collections.Generic;
using System.Text;

namespace PatternBuffer.Schema {

    /**
     * A class representing a set field in the schema definition, e.g. set<int> or set<MyType>
     */
    public class SetFieldType : AbstractFieldType, INullableFieldType {

        /**
         * True if this Set is allowed to accept null as a value.
         */
        private bool isOptional;
        public bool IsNullable { get { return this.isOptional; } }

        /**
         * The type of object this set is supposed to contain
         */
        public IAggregateableFieldType ElementType { get; protected set; }

        /**
         * Creates a set field that can contain elements of the given type.
         */
        public SetFieldType(IAggregateableFieldType elementType) : this(elementType, false) { }
        public SetFieldType(IAggregateableFieldType elementType, bool isOptional) {
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
