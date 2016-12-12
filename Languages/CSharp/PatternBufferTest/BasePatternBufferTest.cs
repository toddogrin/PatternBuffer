using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using NUnit.Framework;
using PatternBuffer.Schema;

namespace PatternBufferTest.Schema {

    [TestFixture()]
    public class BasePatternBufferTest {

        protected PatternBufferSchema Parse(string schema) {
            PatternBufferSchema s = null;
            try {
                PatternBufferSchemaParser loader = new PatternBufferSchemaParser(@"..\..\..\..\..\PatternBuffer.cgt");
                s = loader.Parse(schema);
            }
            catch (Exception x) {
                //Console.WriteLine(x.StackTrace);
                throw x;
            }
            return s;
        }

        protected bool HasHint(IPatternBufferHinted hinted, string hintName, string hintValue) {
            if (hintValue != null) {
                if (hinted.ContainsHint(hintName)) {
                    if (hintValue.Equals(hinted.GetHint(hintName))) {
                        return true;
                    }
                }
            }
            return false;
        }


        protected bool EnumHasValue(PatternBufferEnum e, string value) {
            return e.Values.Contains(value);
        }

        protected bool EnumHasValues(PatternBufferEnum e, params string[] values) {
            foreach (string value in values) {
                if ( ! this.EnumHasValue(e, value)) {
                    return false;
                }
            }
            return true;
        }

        protected bool HasPrimitiveField(PatternBufferType type, string fieldName, PrimitiveType primitiveType) {
            PatternBufferField field = this.GetField<PrimitiveFieldType>(type, fieldName);
            return ((PrimitiveFieldType)field.FieldType).PrimitiveType == primitiveType;
        }

        protected bool HasReferenceField(PatternBufferType type, string fieldName, String referrableName) {
            PatternBufferField field = this.GetField<ReferenceFieldType>(type, fieldName);
            return ((ReferenceFieldType)field.FieldType).ReferrableName.Equals(referrableName);
        }

        protected bool HasPrimitiveListField(PatternBufferType type, string fieldName, PrimitiveType primitiveType) {
            PatternBufferField field = this.GetField<ListFieldType>(type, fieldName);
            IFieldType elementType = ((ListFieldType)field.FieldType).ElementType;
            return
                elementType is PrimitiveFieldType &&
                ((PrimitiveFieldType)elementType).PrimitiveType == primitiveType;
        }

        protected bool HasReferenceListField(PatternBufferType type, string fieldName, String referrableName) {
            PatternBufferField field = this.GetField<ListFieldType>(type, fieldName);
            IFieldType elementType = ((ListFieldType)field.FieldType).ElementType;
            return
                elementType is ReferenceFieldType &&
                ((ReferenceFieldType)elementType).ReferrableName.Equals(referrableName);
        }

        protected bool HasPrimitiveSetField(PatternBufferType type, string fieldName, PrimitiveType primitiveType) {
            PatternBufferField field = this.GetField<SetFieldType>(type, fieldName);
            IFieldType elementType = ((SetFieldType)field.FieldType).ElementType;
            return
                elementType is PrimitiveFieldType &&
                ((PrimitiveFieldType)elementType).PrimitiveType == primitiveType;
        }

        protected bool HasReferenceSetField(PatternBufferType type, string fieldName, String referrableName) {
            PatternBufferField field = this.GetField<SetFieldType>(type, fieldName);
            IFieldType elementType = ((SetFieldType)field.FieldType).ElementType;
            return
                elementType is ReferenceFieldType &&
                ((ReferenceFieldType)elementType).ReferrableName.Equals(referrableName);
        }

        protected bool HasMapField(PatternBufferType type, string fieldName, object keyType, object valueType) {
            bool has = true;
            PatternBufferField field = this.GetField<MapFieldType>(type, fieldName);
            if (field != null) {
                if (keyType is PrimitiveType && field.FieldType is PrimitiveFieldType) {
                    has = has && (((PrimitiveFieldType)field.FieldType).PrimitiveType == (PrimitiveType)keyType);
                }
                else if (keyType is string && field.FieldType is ReferenceFieldType) {
                    has = has && (((ReferenceFieldType)field.FieldType).ReferrableName == (string)keyType);
                }
                if (valueType is PrimitiveType && field.FieldType is PrimitiveFieldType) {
                    has = has && (((PrimitiveFieldType)field.FieldType).PrimitiveType == (PrimitiveType)valueType);
                }
                else if (keyType is string && field.FieldType is ReferenceFieldType) {
                    has = has && (((ReferenceFieldType)field.FieldType).ReferrableName == (string)valueType);
                }
            }
            return has;
        }

        protected PatternBufferField GetField<T>(PatternBufferType type, string fieldName) {
            foreach (PatternBufferField field in type.Fields) {
                if (fieldName.Equals(field.Name) && field.FieldType is T) {
                    return field;
                }
            }
            throw new Exception("Could not find field \"" + fieldName + "\" on type \"" + type.Name + "\".");
        }

    }
}
