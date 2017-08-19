using System;
using System.Collections.Generic;
using System.Text;

namespace PatternBuffer.Schema {

    /**
     * A class representing a list field in the schema definition, e.g. list<int> or list<MyType>
     */
    public class ListFieldType : AbstractFieldType {

        /**
         * The type of object this list is supposed to contain
         */
        public IAggregateableFieldType ElementType { get; protected set; }

        /**
         * Creates a list field that can contain elements of the given type.
         */
        public ListFieldType(IAggregateableFieldType elementType) {
            this.ElementType = elementType;
        }

    }
}
