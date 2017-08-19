using System;
using com.calitha.goldparser;

namespace PatternBuffer.Schema {

    /**
     * A class that contains GOLD parser token object extensions
     */
    public static class TokenExtensions {

        /**
         * Returns the user object for the subtoken with the given symbol ID
         */
        public static object GetUserObjectForSubToken(this NonterminalToken token, int symbolId) {
            if (token == null) { throw new ArgumentNullException("token"); }
            foreach (Token subtoken in token.Tokens) {
                if (subtoken is NonterminalToken) {
                    NonterminalToken nonterminalSubToken = (NonterminalToken)subtoken;
                    if (nonterminalSubToken.Symbol.Id == symbolId) {
                        return nonterminalSubToken.UserObject;
                    }
                }
                else if (subtoken is TerminalToken) {
                    TerminalToken terminalSubtoken = (TerminalToken)subtoken;
                    if (terminalSubtoken.Symbol.Id == symbolId) {
                        return terminalSubtoken.UserObject;
                    }
                }
                else {
                    Console.WriteLine("huh wha token?");
                }

            }
            return null;
        }

        /**
         * A generically typed version of the similarly-named method. This will attempt to cast to the 
         * templated type and throw an error if it can't be done.
         */
        public static T GetUserObjectForSubToken<T>(this NonterminalToken token, int symbolId) {
            object userObject = GetUserObjectForSubToken(token, symbolId);
            if (userObject != null && !(userObject is T)) {
                throw new ArgumentException("User object is " + userObject.GetType().Name + ", not " + typeof(T).Name + ".");
            }
            return (T)userObject;
        }

        /**
         * Returns the subtoken of the given symbol ID, if it exists.
         */
        private static Token GetSubToken(this NonterminalToken token, int symbolId) {
            if (token == null) { throw new ArgumentNullException("token"); }
            foreach (Token subtoken in token.Tokens) {
                if (subtoken is NonterminalToken) {
                    NonterminalToken nonterminalSubToken = (NonterminalToken)subtoken;
                    if (nonterminalSubToken.Symbol.Id == symbolId) {
                        return nonterminalSubToken;
                    }
                }
                else if (subtoken is TerminalToken) {
                    TerminalToken terminalSubtoken = (TerminalToken)subtoken;
                    if (terminalSubtoken.Symbol.Id == symbolId) {
                        return terminalSubtoken;
                    }
                }
                else {
                    Console.WriteLine("huh wha token?");
                }

            }
            return null;
        }


    }

}
