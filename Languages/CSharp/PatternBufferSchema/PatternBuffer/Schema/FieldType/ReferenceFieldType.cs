using System;
using System.Collections.Generic;
using System.Text;

namespace PatternBuffer.Schema {

    /**
     * A class defining a field that references another object (i.e. not a primitive, list, set, or map).
     */
    public class ReferenceFieldType : AbstractFieldType, IAggregateableFieldType {

        /**
         * The name of the type that this field can refer to.
         */
        public string ReferrableName { get; protected set; }

        /**
         * The schema object representing the type that this field can refer to.
         */
        public IPatternBufferReferrable Referrable { get; internal set; }

        /**
         * Creates a field type representing a field that can point to a PatternBuffer object.
         */
        public ReferenceFieldType(string referrableName) {
            this.ReferrableName = referrableName;
        }

    }
}
