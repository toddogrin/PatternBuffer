using System;
using System.Collections.Generic;
using System.Text;

namespace PatternBuffer.Schema {

    /**
     * Defines a PatternBuffer enum structure.
     */
    public class PatternBufferEnum : AbstractPatternBufferHinted, IPatternBufferReferrable {

        internal string name;
        /**
         * The referrable name of the enum.
         */
        public string Name { get { return this.name; } }

        internal IList<string> values;
        /**
         * The values that the enum supports.
         */
        public IList<string> Values { get { return this.values; } }

        /**
         * Creates a PatternBuffer enum with the given values and hints.
         */
        public PatternBufferEnum(string name, IList<string> values, Dictionary<string,string> hints) : base(hints) {
            this.name = name;
            this.values = values;
        }
    }
}
