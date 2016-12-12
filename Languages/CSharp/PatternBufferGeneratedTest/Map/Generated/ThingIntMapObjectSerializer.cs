
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.IO;
using System.Collections.Generic;
using PatternBuffer;
namespace Test.Map {
    public class ThingIntMapObjectSerializer : IPatternBufferSerializer {
        private IPatternBuffer patternBuffer;
        public ThingIntMapObjectSerializer(IPatternBuffer patternBuffer) {
            this.patternBuffer = patternBuffer;
            this.TypeId = 12;
            this.TypeName = "ThingIntMapObject";
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
            ThingIntMapObject item = new ThingIntMapObject();
            // MAP: thingIntMap
            IList<IThing> thingIntMapKeys = new List<IThing>();
            IList<int> thingIntMapValues = new List<int>();
            thingIntMapKeys = reader.ReadFinalObjectCollection<List<IThing>,IThing>(this.patternBuffer.GetSerializerByTypeName("Thing"));
            int count_0738f532eb = (int)reader.ReadVUInt64();
            if (count_0738f532eb > 0) {
                thingIntMapValues = new List<int>();
                for (int i = 0; i < count_0738f532eb; i++) {
                    thingIntMapValues.Add(reader.ReadInt32());
                }
            }
            item.thingIntMap = new Dictionary<IThing,int>(thingIntMapKeys.Count);
            for (int i = 0; i < thingIntMapKeys.Count; i++) {
                item.thingIntMap[thingIntMapKeys[i]] = thingIntMapValues[i];
            }
            return item;
        }
        public void ToBytes(BinaryWriter writer, object o) {
            ThingIntMapObject item = (ThingIntMapObject)o;
            // MAP: thingIntMap
            writer.WriteFinalObjectCollection<IThing>(this.patternBuffer.GetSerializerByTypeName("Thing"), item.thingIntMap.Keys);
            if (item.thingIntMap.Values != null) {
                writer.WriteVUInt64((ulong)item.thingIntMap.Values.Count);
                foreach (int primitive in item.thingIntMap.Values) {
                    writer.Write(primitive);
                }
            }
            else {
                writer.WriteVUInt64(0);
            }
        }
        public uint SizeOf(object o) {
            if (!(o is ThingIntMapObject)) {
                throw new PatternBufferException("Cannot size type "+o.GetType().Name+" using serializer "+this.GetType().Name +".");
            }
            ThingIntMapObject item = (ThingIntMapObject)o;
            uint size = 0;
            // thingIntMap
            size += (uint)PatternBufferUtil.GetUnsignedVariantSize((ulong)item.thingIntMap.Keys.Count);
            IPatternBufferSerializer serializer_beec784914 = this.patternBuffer.GetSerializerByTypeName("Thing");
            foreach (Thing s in item.thingIntMap.Keys) {
                size += (uint)serializer_beec784914.SizeOf(s);
            }
            size += (uint)PatternBufferUtil.GetUnsignedVariantSize((ulong)item.thingIntMap.Values.Count);
            size += (uint)(item.thingIntMap.Values.Count * 4);
            // all primitives = 0 bytes
            return size;
        }
    }
}
