
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.IO;
using System.Collections.Generic;
using PatternBuffer;
namespace Test.List {
    public class Thing1Serializer : IPatternBufferSerializer {
        private IPatternBuffer patternBuffer;
        public Thing1Serializer(IPatternBuffer patternBuffer) {
            this.patternBuffer = patternBuffer;
            this.TypeId = 10;
            this.TypeName = "Thing1";
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
            Thing1 item = new Thing1();
            // PRIMITIVE: intValue1
            item.intValue1 = reader.ReadInt32();
            // PRIMITIVE: intValue2
            item.intValue2 = reader.ReadInt32();
            return item;
        }
        public void ToBytes(BinaryWriter writer, object o) {
            Thing1 item = (Thing1)o;
            // PRIMITIVE: intValue1
            writer.Write((int)item.intValue1);
            // PRIMITIVE: intValue2
            writer.Write((int)item.intValue2);
        }
        public uint SizeOf(object o) {
            if (!(o is Thing1)) {
                throw new PatternBufferException("Cannot size type "+o.GetType().Name+" using serializer "+this.GetType().Name +".");
            }
            Thing1 item = (Thing1)o;
            uint size = 0;
            // intValue1 = 4 bytes
            // intValue2 = 4 bytes
            size += 8; // all primitives
            return size;
        }
    }
}
