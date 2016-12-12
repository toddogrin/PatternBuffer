using System;
using System.Collections.Generic;
using System.Text;

namespace PatternBuffer.Schema {

    /**
     * An interface defining methods for schema elements that want to be referrable by
     * other elements. 
     * 
     * For example, a PatternBuffer type is referrable by its name and is referred to when 
     * declaring a list that contains elements of that type.
     */
    public interface IPatternBufferReferrable {
        
        /**
         * The name of the schema element being referred to, i.e. the type or enum name.
         */
        string Name { get; }
    }
}
