
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.IO;
using System.Collections.Generic;
using PatternBuffer;
namespace Test.Reference {
    public class ThingSerializer : IPatternBufferSerializer {
        private IPatternBuffer patternBuffer;
        public ThingSerializer(IPatternBuffer patternBuffer) {
            this.patternBuffer = patternBuffer;
            this.TypeId = 11;
            this.TypeName = "Thing";
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
            Thing item = new Thing();
            // PRIMITIVE: intValue
            item.intValue = reader.ReadInt32();
            return item;
        }
        public void ToBytes(BinaryWriter writer, object o) {
            Thing item = (Thing)o;
            // PRIMITIVE: intValue
            writer.Write((int)item.intValue);
        }
        public uint SizeOf(object o) {
            if (!(o is Thing)) {
                throw new PatternBufferException("Cannot size type "+o.GetType().Name+" using serializer "+this.GetType().Name +".");
            }
            Thing item = (Thing)o;
            uint size = 0;
            // intValue = 4 bytes
            size += 4; // all primitives
            return size;
        }
    }
}
