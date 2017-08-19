
using System;
using System.IO;
using System.Runtime.Serialization;
using com.calitha.goldparser.lalr;
using com.calitha.commons;

namespace com.calitha.goldparser
{

    [Serializable()]
    public class SymbolException : System.Exception
    {
        public SymbolException(string message) : base(message)
        {
        }

        public SymbolException(string message,
            Exception inner) : base(message, inner)
        {
        }

        protected SymbolException(SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }

    }

    [Serializable()]
    public class RuleException : System.Exception
    {

        public RuleException(string message) : base(message)
        {
        }

        public RuleException(string message,
                             Exception inner) : base(message, inner)
        {
        }

        protected RuleException(SerializationInfo info,
                                StreamingContext context) : base(info, context)
        {
        }

    }

    enum SymbolConstants : int
    {
        SYMBOL_EOF                =  0, // (EOF)
        SYMBOL_ERROR              =  1, // (Error)
        SYMBOL_COMMENT            =  2, // Comment
        SYMBOL_NEWLINE            =  3, // NewLine
        SYMBOL_WHITESPACE         =  4, // Whitespace
        SYMBOL_TIMESDIV           =  5, // '*/'
        SYMBOL_DIVTIMES           =  6, // '/*'
        SYMBOL_DIVDIV             =  7, // '//'
        SYMBOL_LPAREN             =  8, // '('
        SYMBOL_RPAREN             =  9, // ')'
        SYMBOL_COMMA              = 10, // ','
        SYMBOL_COLON              = 11, // ':'
        SYMBOL_SEMI               = 12, // ';'
        SYMBOL_LBRACKET           = 13, // '['
        SYMBOL_RBRACKET           = 14, // ']'
        SYMBOL_LBRACE             = 15, // '{'
        SYMBOL_RBRACE             = 16, // '}'
        SYMBOL_LT                 = 17, // '<'
        SYMBOL_EQ                 = 18, // '='
        SYMBOL_GT                 = 19, // '>'
        SYMBOL_ENUM               = 20, // enum
        SYMBOL_HINTNAME           = 21, // HintName
        SYMBOL_LIST               = 22, // list
        SYMBOL_MAP                = 23, // map
        SYMBOL_NAME               = 24, // Name
        SYMBOL_PRIMITIVE          = 25, // Primitive
        SYMBOL_SET                = 26, // set
        SYMBOL_STRING             = 27, // String
        SYMBOL_TYPE               = 28, // type
        SYMBOL_TYPEID             = 29, // TypeId
        SYMBOL_AGGREGATEARG       = 30, // <AggregateArg>
        SYMBOL_BASETYPE           = 31, // <BaseType>
        SYMBOL_BASETYPENAME       = 32, // <BaseTypeName>
        SYMBOL_ENUM2              = 33, // <Enum>
        SYMBOL_ENUMHINTS          = 34, // <EnumHints>
        SYMBOL_ENUMNAME           = 35, // <EnumName>
        SYMBOL_ENUMVALUE          = 36, // <EnumValue>
        SYMBOL_ENUMVALUES         = 37, // <EnumValues>
        SYMBOL_FIELDNAME          = 38, // <FieldName>
        SYMBOL_HINT               = 39, // <Hint>
        SYMBOL_HINTNAME2          = 40, // <HintName>
        SYMBOL_HINTVALUE          = 41, // <HintValue>
        SYMBOL_LISTFIELD          = 42, // <ListField>
        SYMBOL_MAPFIELD           = 43, // <MapField>
        SYMBOL_PRIMITIVEFIELD     = 44, // <PrimitiveField>
        SYMBOL_PRIMITIVEFIELDTYPE = 45, // <PrimitiveFieldType>
        SYMBOL_REFERENCEFIELD     = 46, // <ReferenceField>
        SYMBOL_REFERENCEFIELDTYPE = 47, // <ReferenceFieldType>
        SYMBOL_SCHEMA             = 48, // <Schema>
        SYMBOL_SCHEMAELEMENTS     = 49, // <SchemaElements>
        SYMBOL_SCHEMANAME         = 50, // <SchemaName>
        SYMBOL_SCHEMANAMEELEMENT  = 51, // <SchemaNameElement>
        SYMBOL_SETFIELD           = 52, // <SetField>
        SYMBOL_TYPE2              = 53, // <Type>
        SYMBOL_TYPEFIELD          = 54, // <TypeField>
        SYMBOL_TYPEFIELDS         = 55, // <TypeFields>
        SYMBOL_TYPEHINTS          = 56, // <TypeHints>
        SYMBOL_TYPEID2            = 57, // <TypeId>
        SYMBOL_TYPENAME           = 58  // <TypeName>
    };

    enum RuleConstants : int
    {
        RULE_SCHEMA                                =  0, // <Schema> ::= <SchemaNameElement> <SchemaElements>
        RULE_SCHEMANAMEELEMENT_NAME_SEMI           =  1, // <SchemaNameElement> ::= Name <SchemaName> ';'
        RULE_SCHEMANAME_NAME                       =  2, // <SchemaName> ::= Name
        RULE_SCHEMAELEMENTS                        =  3, // <SchemaElements> ::= <Type> <SchemaElements>
        RULE_SCHEMAELEMENTS2                       =  4, // <SchemaElements> ::= <Enum> <SchemaElements>
        RULE_SCHEMAELEMENTS3                       =  5, // <SchemaElements> ::= <Hint> <SchemaElements>
        RULE_SCHEMAELEMENTS4                       =  6, // <SchemaElements> ::= 
        RULE_BASETYPE_COLON                        =  7, // <BaseType> ::= ':' <BaseTypeName>
        RULE_BASETYPE                              =  8, // <BaseType> ::= 
        RULE_BASETYPENAME_NAME                     =  9, // <BaseTypeName> ::= Name
        RULE_TYPE_TYPE_LPAREN_RPAREN_LBRACE_RBRACE = 10, // <Type> ::= type '(' <TypeId> ')' <TypeName> <BaseType> '{' <TypeHints> <TypeFields> '}'
        RULE_TYPENAME_NAME                         = 11, // <TypeName> ::= Name
        RULE_TYPEID_TYPEID                         = 12, // <TypeId> ::= TypeId
        RULE_TYPEID                                = 13, // <TypeId> ::= 
        RULE_TYPEHINTS                             = 14, // <TypeHints> ::= <Hint> <TypeHints>
        RULE_TYPEHINTS2                            = 15, // <TypeHints> ::= 
        RULE_TYPEFIELDS                            = 16, // <TypeFields> ::= <TypeField> <TypeFields>
        RULE_TYPEFIELDS2                           = 17, // <TypeFields> ::= 
        RULE_TYPEFIELD                             = 18, // <TypeField> ::= <PrimitiveField>
        RULE_TYPEFIELD2                            = 19, // <TypeField> ::= <ReferenceField>
        RULE_TYPEFIELD3                            = 20, // <TypeField> ::= <ListField>
        RULE_TYPEFIELD4                            = 21, // <TypeField> ::= <SetField>
        RULE_TYPEFIELD5                            = 22, // <TypeField> ::= <MapField>
        RULE_PRIMITIVEFIELD_SEMI                   = 23, // <PrimitiveField> ::= <PrimitiveFieldType> <FieldName> ';'
        RULE_PRIMITIVEFIELDTYPE_PRIMITIVE          = 24, // <PrimitiveFieldType> ::= Primitive
        RULE_REFERENCEFIELD_SEMI                   = 25, // <ReferenceField> ::= <ReferenceFieldType> <FieldName> ';'
        RULE_REFERENCEFIELDTYPE_NAME               = 26, // <ReferenceFieldType> ::= Name
        RULE_FIELDNAME_NAME                        = 27, // <FieldName> ::= Name
        RULE_LISTFIELD_LIST_LT_GT_SEMI             = 28, // <ListField> ::= list '<' <AggregateArg> '>' <FieldName> ';'
        RULE_SETFIELD_SET_LT_GT_SEMI               = 29, // <SetField> ::= set '<' <AggregateArg> '>' <FieldName> ';'
        RULE_MAPFIELD_MAP_LT_COMMA_GT_SEMI         = 30, // <MapField> ::= map '<' <AggregateArg> ',' <AggregateArg> '>' <FieldName> ';'
        RULE_AGGREGATEARG                          = 31, // <AggregateArg> ::= <PrimitiveFieldType>
        RULE_AGGREGATEARG2                         = 32, // <AggregateArg> ::= <ReferenceFieldType>
        RULE_ENUM_ENUM_LBRACE_RBRACE               = 33, // <Enum> ::= enum <EnumName> '{' <EnumHints> <EnumValues> '}'
        RULE_ENUMNAME_NAME                         = 34, // <EnumName> ::= Name
        RULE_ENUMHINTS                             = 35, // <EnumHints> ::= <Hint> <EnumHints>
        RULE_ENUMHINTS2                            = 36, // <EnumHints> ::= 
        RULE_ENUMVALUES                            = 37, // <EnumValues> ::= <EnumValue>
        RULE_ENUMVALUES_COMMA                      = 38, // <EnumValues> ::= <EnumValue> ',' <EnumValues>
        RULE_ENUMVALUES2                           = 39, // <EnumValues> ::= 
        RULE_ENUMVALUE_NAME                        = 40, // <EnumValue> ::= Name
        RULE_HINT_LBRACKET_EQ_RBRACKET             = 41, // <Hint> ::= '[' <HintName> '=' <HintValue> ']'
        RULE_HINTNAME_HINTNAME                     = 42, // <HintName> ::= HintName
        RULE_HINTVALUE_STRING                      = 43  // <HintValue> ::= String
    };

    public class MyParser
    {
        private LALRParser parser;

        public MyParser(string filename)
        {
            FileStream stream = new FileStream(filename,
                                               FileMode.Open, 
                                               FileAccess.Read, 
                                               FileShare.Read);
            Init(stream);
            stream.Close();
        }

        public MyParser(string baseName, string resourceName)
        {
            byte[] buffer = ResourceUtil.GetByteArrayResource(
                System.Reflection.Assembly.GetExecutingAssembly(),
                baseName,
                resourceName);
            MemoryStream stream = new MemoryStream(buffer);
            Init(stream);
            stream.Close();
        }

        public MyParser(Stream stream)
        {
            Init(stream);
        }

        private void Init(Stream stream)
        {
            CGTReader reader = new CGTReader(stream);
            parser = reader.CreateNewParser();
            parser.TrimReductions = false;
            parser.StoreTokens = LALRParser.StoreTokensMode.NoUserObject;

            parser.OnTokenError += new LALRParser.TokenErrorHandler(TokenErrorEvent);
            parser.OnParseError += new LALRParser.ParseErrorHandler(ParseErrorEvent);
        }

        public void Parse(string source)
        {
            NonterminalToken token = parser.Parse(source);
            if (token != null)
            {
                Object obj = CreateObject(token);
                //todo: Use your object any way you like
            }
        }

        private Object CreateObject(Token token)
        {
            if (token is TerminalToken)
                return CreateObjectFromTerminal((TerminalToken)token);
            else
                return CreateObjectFromNonterminal((NonterminalToken)token);
        }

        private Object CreateObjectFromTerminal(TerminalToken token)
        {
            switch (token.Symbol.Id)
            {
                case (int)SymbolConstants.SYMBOL_EOF :
                //(EOF)
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ERROR :
                //(Error)
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_COMMENT :
                //Comment
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_NEWLINE :
                //NewLine
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_WHITESPACE :
                //Whitespace
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_TIMESDIV :
                //'*/'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_DIVTIMES :
                //'/*'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_DIVDIV :
                //'//'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LPAREN :
                //'('
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_RPAREN :
                //')'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_COMMA :
                //','
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_COLON :
                //':'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_SEMI :
                //';'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LBRACKET :
                //'['
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_RBRACKET :
                //']'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LBRACE :
                //'{'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_RBRACE :
                //'}'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LT :
                //'<'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_EQ :
                //'='
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_GT :
                //'>'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ENUM :
                //enum
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_HINTNAME :
                //HintName
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LIST :
                //list
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_MAP :
                //map
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_NAME :
                //Name
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PRIMITIVE :
                //Primitive
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_SET :
                //set
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_STRING :
                //String
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_TYPE :
                //type
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_TYPEID :
                //TypeId
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_AGGREGATEARG :
                //<AggregateArg>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_BASETYPE :
                //<BaseType>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_BASETYPENAME :
                //<BaseTypeName>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ENUM2 :
                //<Enum>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ENUMHINTS :
                //<EnumHints>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ENUMNAME :
                //<EnumName>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ENUMVALUE :
                //<EnumValue>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ENUMVALUES :
                //<EnumValues>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_FIELDNAME :
                //<FieldName>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_HINT :
                //<Hint>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_HINTNAME2 :
                //<HintName>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_HINTVALUE :
                //<HintValue>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LISTFIELD :
                //<ListField>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_MAPFIELD :
                //<MapField>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PRIMITIVEFIELD :
                //<PrimitiveField>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PRIMITIVEFIELDTYPE :
                //<PrimitiveFieldType>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_REFERENCEFIELD :
                //<ReferenceField>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_REFERENCEFIELDTYPE :
                //<ReferenceFieldType>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_SCHEMA :
                //<Schema>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_SCHEMAELEMENTS :
                //<SchemaElements>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_SCHEMANAME :
                //<SchemaName>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_SCHEMANAMEELEMENT :
                //<SchemaNameElement>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_SETFIELD :
                //<SetField>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_TYPE2 :
                //<Type>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_TYPEFIELD :
                //<TypeField>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_TYPEFIELDS :
                //<TypeFields>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_TYPEHINTS :
                //<TypeHints>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_TYPEID2 :
                //<TypeId>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_TYPENAME :
                //<TypeName>
                //todo: Create a new object that corresponds to the symbol
                return null;

            }
            throw new SymbolException("Unknown symbol");
        }

        public Object CreateObjectFromNonterminal(NonterminalToken token)
        {
            switch (token.Rule.Id)
            {
                case (int)RuleConstants.RULE_SCHEMA :
                //<Schema> ::= <SchemaNameElement> <SchemaElements>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_SCHEMANAMEELEMENT_NAME_SEMI :
                //<SchemaNameElement> ::= Name <SchemaName> ';'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_SCHEMANAME_NAME :
                //<SchemaName> ::= Name
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_SCHEMAELEMENTS :
                //<SchemaElements> ::= <Type> <SchemaElements>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_SCHEMAELEMENTS2 :
                //<SchemaElements> ::= <Enum> <SchemaElements>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_SCHEMAELEMENTS3 :
                //<SchemaElements> ::= <Hint> <SchemaElements>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_SCHEMAELEMENTS4 :
                //<SchemaElements> ::= 
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_BASETYPE_COLON :
                //<BaseType> ::= ':' <BaseTypeName>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_BASETYPE :
                //<BaseType> ::= 
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_BASETYPENAME_NAME :
                //<BaseTypeName> ::= Name
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_TYPE_TYPE_LPAREN_RPAREN_LBRACE_RBRACE :
                //<Type> ::= type '(' <TypeId> ')' <TypeName> <BaseType> '{' <TypeHints> <TypeFields> '}'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_TYPENAME_NAME :
                //<TypeName> ::= Name
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_TYPEID_TYPEID :
                //<TypeId> ::= TypeId
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_TYPEID :
                //<TypeId> ::= 
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_TYPEHINTS :
                //<TypeHints> ::= <Hint> <TypeHints>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_TYPEHINTS2 :
                //<TypeHints> ::= 
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_TYPEFIELDS :
                //<TypeFields> ::= <TypeField> <TypeFields>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_TYPEFIELDS2 :
                //<TypeFields> ::= 
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_TYPEFIELD :
                //<TypeField> ::= <PrimitiveField>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_TYPEFIELD2 :
                //<TypeField> ::= <ReferenceField>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_TYPEFIELD3 :
                //<TypeField> ::= <ListField>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_TYPEFIELD4 :
                //<TypeField> ::= <SetField>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_TYPEFIELD5 :
                //<TypeField> ::= <MapField>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_PRIMITIVEFIELD_SEMI :
                //<PrimitiveField> ::= <PrimitiveFieldType> <FieldName> ';'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_PRIMITIVEFIELDTYPE_PRIMITIVE :
                //<PrimitiveFieldType> ::= Primitive
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_REFERENCEFIELD_SEMI :
                //<ReferenceField> ::= <ReferenceFieldType> <FieldName> ';'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_REFERENCEFIELDTYPE_NAME :
                //<ReferenceFieldType> ::= Name
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_FIELDNAME_NAME :
                //<FieldName> ::= Name
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_LISTFIELD_LIST_LT_GT_SEMI :
                //<ListField> ::= list '<' <AggregateArg> '>' <FieldName> ';'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_SETFIELD_SET_LT_GT_SEMI :
                //<SetField> ::= set '<' <AggregateArg> '>' <FieldName> ';'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_MAPFIELD_MAP_LT_COMMA_GT_SEMI :
                //<MapField> ::= map '<' <AggregateArg> ',' <AggregateArg> '>' <FieldName> ';'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_AGGREGATEARG :
                //<AggregateArg> ::= <PrimitiveFieldType>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_AGGREGATEARG2 :
                //<AggregateArg> ::= <ReferenceFieldType>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ENUM_ENUM_LBRACE_RBRACE :
                //<Enum> ::= enum <EnumName> '{' <EnumHints> <EnumValues> '}'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ENUMNAME_NAME :
                //<EnumName> ::= Name
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ENUMHINTS :
                //<EnumHints> ::= <Hint> <EnumHints>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ENUMHINTS2 :
                //<EnumHints> ::= 
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ENUMVALUES :
                //<EnumValues> ::= <EnumValue>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ENUMVALUES_COMMA :
                //<EnumValues> ::= <EnumValue> ',' <EnumValues>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ENUMVALUES2 :
                //<EnumValues> ::= 
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ENUMVALUE_NAME :
                //<EnumValue> ::= Name
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_HINT_LBRACKET_EQ_RBRACKET :
                //<Hint> ::= '[' <HintName> '=' <HintValue> ']'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_HINTNAME_HINTNAME :
                //<HintName> ::= HintName
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_HINTVALUE_STRING :
                //<HintValue> ::= String
                //todo: Create a new object using the stored tokens.
                return null;

            }
            throw new RuleException("Unknown rule");
        }

        private void TokenErrorEvent(LALRParser parser, TokenErrorEventArgs args)
        {
            string message = "Token error with input: '"+args.Token.ToString()+"'";
            //todo: Report message to UI?
        }

        private void ParseErrorEvent(LALRParser parser, ParseErrorEventArgs args)
        {
            string message = "Parse error caused by token: '"+args.UnexpectedToken.ToString()+"'";
            //todo: Report message to UI?
        }

    }
}
