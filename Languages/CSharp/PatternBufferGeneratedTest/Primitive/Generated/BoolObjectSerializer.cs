
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.IO;
using System.Collections.Generic;
using PatternBuffer;
namespace Test.Primitive {
    public class BoolObjectSerializer : IPatternBufferSerializer {
        private IPatternBuffer patternBuffer;
        public BoolObjectSerializer(IPatternBuffer patternBuffer) {
            this.patternBuffer = patternBuffer;
            this.TypeId = 20;
            this.TypeName = "BoolObject";
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
            BoolObject item = new BoolObject();
            // PRIMITIVE: boolValue
            item.boolValue = reader.ReadBoolean();
            return item;
        }
        public void ToBytes(BinaryWriter writer, object o) {
            BoolObject item = (BoolObject)o;
            // PRIMITIVE: boolValue
            writer.Write((bool)item.boolValue);
        }
        public uint SizeOf(object o) {
            if (!(o is BoolObject)) {
                throw new PatternBufferException("Cannot size type "+o.GetType().Name+" using serializer "+this.GetType().Name +".");
            }
            BoolObject item = (BoolObject)o;
            uint size = 0;
            // boolValue = 1 bytes
            size += 1; // all primitives
            return size;
        }
    }
}
