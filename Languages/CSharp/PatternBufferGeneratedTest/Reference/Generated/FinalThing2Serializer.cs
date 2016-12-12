
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.IO;
using System.Collections.Generic;
using PatternBuffer;
namespace Test.Reference {
    public class FinalThing2Serializer : IPatternBufferSerializer {
        private IPatternBuffer patternBuffer;
        public FinalThing2Serializer(IPatternBuffer patternBuffer) {
            this.patternBuffer = patternBuffer;
            this.TypeId = 23;
            this.TypeName = "FinalThing2";
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
            FinalThing2 item = new FinalThing2();
            // PRIMITIVE: intValue1
            item.intValue1 = reader.ReadInt32();
            // PRIMITIVE: intValue2a
            item.intValue2a = reader.ReadInt32();
            return item;
        }
        public void ToBytes(BinaryWriter writer, object o) {
            FinalThing2 item = (FinalThing2)o;
            // PRIMITIVE: intValue1
            writer.Write((int)item.intValue1);
            // PRIMITIVE: intValue2a
            writer.Write((int)item.intValue2a);
        }
        public uint SizeOf(object o) {
            if (!(o is FinalThing2)) {
                throw new PatternBufferException("Cannot size type "+o.GetType().Name+" using serializer "+this.GetType().Name +".");
            }
            FinalThing2 item = (FinalThing2)o;
            uint size = 0;
            // intValue1 = 4 bytes
            // intValue2a = 4 bytes
            size += 8; // all primitives
            return size;
        }
    }
}
