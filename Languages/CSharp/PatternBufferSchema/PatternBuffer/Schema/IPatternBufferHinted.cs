using System;
using System.Collections.Generic;
using System.Text;

namespace PatternBuffer.Schema {

    /**
     * An interface defining methods for querying hints on a schema, type, or enum.
     */
    public interface IPatternBufferHinted {

        /**
         * Returns the string value of the hint with the given name, or null, if there is no
         * hint present with that name.
         */
        string GetHint(string name);

        /**
         * Returns true if a hint of the given name is present, false otherwise.
         */
        bool ContainsHint(string name);
        
        /**
         * Returns the number of hints present on the schema element.
         */
        int HintCount { get; }

    }
}
