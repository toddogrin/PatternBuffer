using System;
using System.Collections.Generic;
using System.Text;

namespace PatternBuffer.Schema {

    /**
     * A class representing a set field in the schema definition, e.g. set<int> or set<MyType>
     */
    public class SetFieldType : AbstractFieldType {

        /**
         * The type of object this set is supposed to contain
         */
        public IAggregateableFieldType ElementType { get; protected set; }

        /**
         * Creates a set field that can contain elements of the given type.
         */
        public SetFieldType(IAggregateableFieldType elementType) {
            this.ElementType = elementType;
        }

    }
}
