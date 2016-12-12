
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.IO;
using System.Collections.Generic;
using PatternBuffer;
namespace Test.List {
    public class Thing2Serializer : IPatternBufferSerializer {
        private IPatternBuffer patternBuffer;
        public Thing2Serializer(IPatternBuffer patternBuffer) {
            this.patternBuffer = patternBuffer;
            this.TypeId = 11;
            this.TypeName = "Thing2";
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
            Thing2 item = new Thing2();
            // PRIMITIVE: intValue1
            item.intValue1 = reader.ReadInt32();
            // PRIMITIVE: intValue3
            item.intValue3 = reader.ReadInt32();
            return item;
        }
        public void ToBytes(BinaryWriter writer, object o) {
            Thing2 item = (Thing2)o;
            // PRIMITIVE: intValue1
            writer.Write((int)item.intValue1);
            // PRIMITIVE: intValue3
            writer.Write((int)item.intValue3);
        }
        public uint SizeOf(object o) {
            if (!(o is Thing2)) {
                throw new PatternBufferException("Cannot size type "+o.GetType().Name+" using serializer "+this.GetType().Name +".");
            }
            Thing2 item = (Thing2)o;
            uint size = 0;
            // intValue1 = 4 bytes
            // intValue3 = 4 bytes
            size += 8; // all primitives
            return size;
        }
    }
}
