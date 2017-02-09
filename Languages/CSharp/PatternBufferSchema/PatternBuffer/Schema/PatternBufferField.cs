using System;
using System.Collections.Generic;
using System.Text;

namespace PatternBuffer.Schema {

    /**
     * Represents a field in a PatternBuffer type definition.
     */
    public class PatternBufferField {

        internal string name;
        /**
         * The name of the field.
         */
        public string Name { get { return this.name; } }

        internal IFieldType fieldType;
        /**
         * The type of the field, e.g. primitive, list of integers, reference, etc.
         */
        public IFieldType FieldType { get { return this.fieldType; } }

        /**
         * Creates a PatternBuffer type field with the given name and type.
         */
        public PatternBufferField(string name, IFieldType fieldType) {
            this.name = name;
            this.fieldType = fieldType;
        }

    }
}
