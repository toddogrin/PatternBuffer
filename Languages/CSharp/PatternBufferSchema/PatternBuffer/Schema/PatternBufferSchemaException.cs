using System;
using System.Collections.Generic;
using System.Text;

namespace PatternBuffer.Schema {

    /**
     * An exception thrown when a schema problem is detected, usually during parsing.
     */
    public class PatternBufferSchemaException : Exception {
        public PatternBufferSchemaException(string message) : base(message) { }
    }
}
