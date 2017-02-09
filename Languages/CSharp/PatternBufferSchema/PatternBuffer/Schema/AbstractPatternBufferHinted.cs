using System;
using System.Collections.Generic;
using System.Text;

namespace PatternBuffer.Schema {

    /**
     * A base implementation of IPatternBufferHinted.
     */
    public abstract class AbstractPatternBufferHinted : IPatternBufferHinted {

        internal Dictionary<string,string> hints;

        protected AbstractPatternBufferHinted(Dictionary<string, string> hints) {
            this.hints = hints;
        }

        public string GetHint(string name) {
            return this.hints[name];
        }

        public bool ContainsHint(string name) {
            return this.hints.ContainsKey(name);
        }

        public int HintCount {
            get {
                return this.hints.Count;
            }
        }

    }

}
