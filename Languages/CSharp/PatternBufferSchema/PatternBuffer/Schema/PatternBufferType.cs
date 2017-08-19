using System;
using System.Collections.Generic;
using System.Text;

namespace PatternBuffer.Schema {

    /**
     * Represents a PatternBuffer type definition, including its name, fields, base type, etc.
     */
    public class PatternBufferType : AbstractPatternBufferHinted, IPatternBufferReferrable {

        internal string name;
        /**
         * The name of the PatternBuffer type
         */
        public string Name { get { return this.name; } }

        internal ushort typeId;
        /**
         * The unique type ID of this type
         */
        public ushort TypeId { 
            get { return this.typeId; } 
            internal set { this.typeId = value; } 
        }

        /**
         * The referrable name of this type's base type, if any.
         */
        internal string baseTypeName;

        internal PatternBufferType baseType;
        /**
         * A reference to the PatternBufferType object that represents the base type of this
         * type.
         */
        public PatternBufferType BaseType {
            get { return this.baseType; }
            internal set { this.baseType = value; }
        }

        internal IList<PatternBufferField> fields;
        /**
         * All the fields present on this type, in the order they were defined.
         */
        public IList<PatternBufferField> Fields { get { return this.fields; } }

        internal bool isFinal;
        /**
         * If no other type derives from this type, this property returns true. If this type is
         * a base type to any other type, this property returns false.
         */
        public bool IsFinal {
            get { return this.isFinal; }
            set { this.isFinal = value; }
        }

        internal int nullableFieldCount;
        public int NullableFieldCount {
            get { return this.nullableFieldCount; }
        }
        public bool HasNullableFields {
            get { return this.nullableFieldCount > 0; }
        }

        /**
         * Creates a PatternBuffer type object with no base type.
         */
        public PatternBufferType(string name, ushort typeId, IList<PatternBufferField> fields, Dictionary<string,string> hints) : this(name, typeId, fields, hints, (string)null) { }

        /**
         * Creates a PatternBuffer type object with the given base type.
         */
        public PatternBufferType(string name, ushort typeId, IList<PatternBufferField> fields, Dictionary<string, string> hints, string baseTypeName) : base (hints) {
            this.name = name;
            this.typeId = typeId;
            this.fields = fields;
            this.baseTypeName = baseTypeName;
            this.hints = hints;
            this.nullableFieldCount = 0;
            foreach (PatternBufferField field in fields) {
                if (field.FieldType is IOptionalFieldType) {
                    this.nullableFieldCount++;
                }
            }
        }
    }
}
