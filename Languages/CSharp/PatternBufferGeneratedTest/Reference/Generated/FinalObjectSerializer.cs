
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.IO;
using System.Collections.Generic;
using PatternBuffer;
namespace Test.Reference {
    public class FinalObjectSerializer : IPatternBufferSerializer {
        private IPatternBuffer patternBuffer;
        public FinalObjectSerializer(IPatternBuffer patternBuffer) {
            this.patternBuffer = patternBuffer;
            this.TypeId = 12;
            this.TypeName = "FinalObject";
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
            FinalObject item = new FinalObject();
            // REFERENCE: thingValue
            item.thingValue = (IThing)this.patternBuffer.GetSerializerByTypeName("Thing").FromBytes(reader);
            return item;
        }
        public void ToBytes(BinaryWriter writer, object o) {
            FinalObject item = (FinalObject)o;
            // REFERENCE: thingValue
            this.patternBuffer.GetSerializerByTypeName("Thing").ToBytes(writer, item.thingValue);
        }
        public uint SizeOf(object o) {
            if (!(o is FinalObject)) {
                throw new PatternBufferException("Cannot size type "+o.GetType().Name+" using serializer "+this.GetType().Name +".");
            }
            FinalObject item = (FinalObject)o;
            uint size = 0;
            // thingValue
            size += (uint)this.patternBuffer.GetSerializerByTypeName("Thing").SizeOf(item.thingValue);
            // all primitives = 0 bytes
            return size;
        }
    }
}
