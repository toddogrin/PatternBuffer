using System;

namespace PatternBuffer {
    /**
     * A run-time exception thrown for PatternBuffer problems.
     */
    public class PatternBufferException : Exception {
        public PatternBufferException(string message) : base(message) { }
    }
}
