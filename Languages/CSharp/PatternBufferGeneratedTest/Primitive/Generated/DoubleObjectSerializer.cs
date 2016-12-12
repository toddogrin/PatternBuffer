
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.IO;
using System.Collections.Generic;
using PatternBuffer;
namespace Test.Primitive {
    public class DoubleObjectSerializer : IPatternBufferSerializer {
        private IPatternBuffer patternBuffer;
        public DoubleObjectSerializer(IPatternBuffer patternBuffer) {
            this.patternBuffer = patternBuffer;
            this.TypeId = 18;
            this.TypeName = "DoubleObject";
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
            DoubleObject item = new DoubleObject();
            // PRIMITIVE: doubleValue
            item.doubleValue = reader.ReadDouble();
            return item;
        }
        public void ToBytes(BinaryWriter writer, object o) {
            DoubleObject item = (DoubleObject)o;
            // PRIMITIVE: doubleValue
            writer.Write((double)item.doubleValue);
        }
        public uint SizeOf(object o) {
            if (!(o is DoubleObject)) {
                throw new PatternBufferException("Cannot size type "+o.GetType().Name+" using serializer "+this.GetType().Name +".");
            }
            DoubleObject item = (DoubleObject)o;
            uint size = 0;
            // doubleValue = 8 bytes
            size += 8; // all primitives
            return size;
        }
    }
}
