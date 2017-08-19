using System;
using System.Collections.Generic;
using System.Text;

namespace PatternBuffer.Schema {

    /**
     * An interface implemented by field types whose fields can either contain a value, or null.
     */
    public interface INullableFieldType : IFieldType {
        bool IsNullable { get; }
    }
}
