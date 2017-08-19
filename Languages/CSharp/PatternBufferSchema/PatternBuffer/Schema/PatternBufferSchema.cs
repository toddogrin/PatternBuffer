using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

namespace PatternBuffer.Schema {

    /**
     * Represents the fully parsed and validated PatternBuffer schema file.
     */
    public class PatternBufferSchema {

        internal string name;
        /**
         * The name of the schema.
         */
        public string Name { get { return this.name; } }

        internal IList<PatternBufferType> types;
        /**
         * The types defined as a part of this schema.
         */
        public IList<PatternBufferType> Types {  get { return this.types; } }

        // Maps type names to PtternBufferTypes
        internal Dictionary<string, PatternBufferType> nameTypeMap;

        internal IList<PatternBufferEnum> enums;
        /**
         * The enus defined as a part of this schema.
         */
        public IList<PatternBufferEnum> Enums { get { return this.enums; } }

        // Maps enum names to PatternBufferEnums
        internal Dictionary<string, PatternBufferEnum> nameEnumMap;

        internal Dictionary<string, string> hintMap;
        /**
         * The hints associated with this schema.
         */
        public Dictionary<string, string> Hints { get { return this.hintMap; } }

        /**
         * Creates a PatternBuffer schema with the given name, types, enums, and hints.
         */
        public PatternBufferSchema(string name, IList<PatternBufferType> types, IList<PatternBufferEnum> enums, Dictionary<string,string> hints) {

            this.name = name;

            this.types = types;

            this.nameTypeMap = new Dictionary<string, PatternBufferType>();
            foreach (PatternBufferType type in types) {
                this.nameTypeMap[type.Name] = type;
            }
           
            this.enums = enums;

            this.nameEnumMap = new Dictionary<string, PatternBufferEnum>();
            foreach (PatternBufferEnum e in enums) {
                this.nameEnumMap[e.Name] = e;
            }

            this.hintMap = hints;
        }

        /**
         * Returns the PatternBufferType associated with the given name, if any.
         */
        public PatternBufferType GetPatternBufferType(string name) {
            return this.nameTypeMap[name];
        }

        /**
         * Returns the PatternBufferEnum associated with the given name, if any.
         */
        public PatternBufferEnum GetPatternBufferEnum(string name) {
            return this.nameEnumMap[name];
        }

        /**
         * Returns the PatternBufferType or PatternBufferENum associated with the given name, if any.
         */
        public IPatternBufferReferrable GetPatternBufferReferrable(string name) {
            if (this.nameTypeMap.ContainsKey(name)) {
                return this.GetPatternBufferType(name);
            }
            else {
                return this.GetPatternBufferEnum(name);
            }
        }

    }

}
