using System;
using System.Collections.Generic;
using System.Text;

namespace PatternBuffer.Schema {

    /**
     * A marker interface applied to field types that can be stored in a list, set, or map.
     */
    public interface IAggregateableFieldType : IFieldType { }
}
