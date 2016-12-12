
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.IO;
using System.Collections.Generic;
using PatternBuffer;
namespace Test.Set {
    public class AbstractThingSerializer : IPatternBufferSerializer {
        private IPatternBuffer patternBuffer;
        public AbstractThingSerializer(IPatternBuffer patternBuffer) {
            this.patternBuffer = patternBuffer;
            this.TypeId = 9;
            this.TypeName = "AbstractThing";
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
            AbstractThing item = new AbstractThing();
            // PRIMITIVE: intValue1
            item.intValue1 = reader.ReadInt32();
            return item;
        }
        public void ToBytes(BinaryWriter writer, object o) {
            AbstractThing item = (AbstractThing)o;
            // PRIMITIVE: intValue1
            writer.Write((int)item.intValue1);
        }
        public uint SizeOf(object o) {
            if (!(o is AbstractThing)) {
                throw new PatternBufferException("Cannot size type "+o.GetType().Name+" using serializer "+this.GetType().Name +".");
            }
            AbstractThing item = (AbstractThing)o;
            uint size = 0;
            // intValue1 = 4 bytes
            size += 4; // all primitives
            return size;
        }
    }
}
