
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.IO;
using System.Collections.Generic;
using PatternBuffer;
namespace Test.Primitive {
    public class ShortObjectSerializer : IPatternBufferSerializer {
        private IPatternBuffer patternBuffer;
        public ShortObjectSerializer(IPatternBuffer patternBuffer) {
            this.patternBuffer = patternBuffer;
            this.TypeId = 11;
            this.TypeName = "ShortObject";
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
            ShortObject item = new ShortObject();
            // PRIMITIVE: shortValue
            item.shortValue = reader.ReadInt16();
            return item;
        }
        public void ToBytes(BinaryWriter writer, object o) {
            ShortObject item = (ShortObject)o;
            // PRIMITIVE: shortValue
            writer.Write((short)item.shortValue);
        }
        public uint SizeOf(object o) {
            if (!(o is ShortObject)) {
                throw new PatternBufferException("Cannot size type "+o.GetType().Name+" using serializer "+this.GetType().Name +".");
            }
            ShortObject item = (ShortObject)o;
            uint size = 0;
            // shortValue = 2 bytes
            size += 2; // all primitives
            return size;
        }
    }
}
