
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.IO;
using System.Collections.Generic;
using PatternBuffer;
namespace Test.Primitive {
    public class FloatObjectSerializer : IPatternBufferSerializer {
        private IPatternBuffer patternBuffer;
        public FloatObjectSerializer(IPatternBuffer patternBuffer) {
            this.patternBuffer = patternBuffer;
            this.TypeId = 19;
            this.TypeName = "FloatObject";
        }
        private ushort typeId;
        public ushort TypeId {
            get { return this.typeId; }
            protected set { this.typeId = value; }
        }
        private string typeName;
        public string TypeName {
            get { return this.typeName; }
            protected set { this.typeName = value; }
        }
        public object FromBytes(BinaryReader reader) {
            FloatObject item = new FloatObject();
            // PRIMITIVE: floatValue
            item.floatValue = reader.ReadSingle();
            return item;
        }
        public void ToBytes(BinaryWriter writer, object o) {
            FloatObject item = (FloatObject)o;
            // PRIMITIVE: floatValue
            writer.Write((float)item.floatValue);
        }
        public uint SizeOf(object o) {
            if (!(o is FloatObject)) {
                throw new PatternBufferException("Cannot size type "+o.GetType().Name+" using serializer "+this.GetType().Name +".");
            }
            FloatObject item = (FloatObject)o;
            uint size = 0;
            // floatValue = 4 bytes
            size += 4; // all primitives
            return size;
        }
    }
}
