using System;
using System.Collections.Generic;
using System.Text;

namespace PatternBuffer.Schema {

    /**
     * A class defining a field that references another object (i.e. not a primitive, list, set, or map).
     */
    public class ReferenceFieldType : AbstractFieldType, IAggregateableFieldType, INullableFieldType {

        /**
         * True if this reference is allowed to accept null as a value.
         */
        private bool isOptional;
        //public bool IsOptional { get { return this.isOptional; } }
        public bool IsNullable { get { return true; } }

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
        public ReferenceFieldType(string referrableName) : this(referrableName, false) { }
        public ReferenceFieldType(string referrableName, bool isOptional) {
            this.ReferrableName = referrableName;
            this.isOptional = isOptional;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13 * hash) + this.ReferrableName.GetHashCode();
                hash = (13 * hash) + this.IsNullable.GetHashCode();
                return hash;
            }
        }

    }
}
