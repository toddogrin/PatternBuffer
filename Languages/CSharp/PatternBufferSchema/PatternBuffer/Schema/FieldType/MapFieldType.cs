using System;
using System.Collections.Generic;
using System.Text;

namespace PatternBuffer.Schema {

    /**
     * A class representing a map field in the schema definition, e.g. list<int,string> or list<MyType,bool>
     */
    public class MapFieldType : AbstractFieldType, INullableFieldType {

        /**
         * True if this Map is allowed to accept null as a value.
         */
        private bool isOptional;
        public bool IsNullable { get { return this.isOptional; } }

        /**
         * The key type supported by this map. Keys can be primitives or objects (final or abstract).
         */
        public IAggregateableFieldType KeyType { get; protected set; }

        /**
         * The value type supported by this map. Like keys, values can be primitives or objects (final or abstract).
         */
        public IAggregateableFieldType ValueType { get; protected set; }

        /**
         * Creates a map field with the given key and value types.
         */
        public MapFieldType(IAggregateableFieldType keyType, IAggregateableFieldType valueType) : this(keyType, valueType, false) { }
        public MapFieldType(IAggregateableFieldType keyType, IAggregateableFieldType valueType, bool isOptional) {
            this.KeyType = keyType;
            this.ValueType = valueType;
            this.isOptional = isOptional;
        }

        public override int GetHashCode() {
            unchecked {
                int hash = 27;
                hash = (13 * hash) + this.KeyType.GetHashCode();
                hash = (13 * hash) + this.ValueType.GetHashCode();
                return hash;
            }
        }

    }

}
