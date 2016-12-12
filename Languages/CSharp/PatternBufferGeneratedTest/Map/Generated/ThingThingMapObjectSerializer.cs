
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.IO;
using System.Collections.Generic;
using PatternBuffer;
namespace Test.Map {
    public class ThingThingMapObjectSerializer : IPatternBufferSerializer {
        private IPatternBuffer patternBuffer;
        public ThingThingMapObjectSerializer(IPatternBuffer patternBuffer) {
            this.patternBuffer = patternBuffer;
            this.TypeId = 14;
            this.TypeName = "ThingThingMapObject";
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
            ThingThingMapObject item = new ThingThingMapObject();
            // MAP: thingThingMap
            IList<IThing> thingThingMapKeys = new List<IThing>();
            IList<IThing> thingThingMapValues = new List<IThing>();
            thingThingMapKeys = reader.ReadFinalObjectCollection<List<IThing>,IThing>(this.patternBuffer.GetSerializerByTypeName("Thing"));
            thingThingMapValues = reader.ReadFinalObjectCollection<List<IThing>,IThing>(this.patternBuffer.GetSerializerByTypeName("Thing"));
            item.thingThingMap = new Dictionary<IThing,IThing>(thingThingMapKeys.Count);
            for (int i = 0; i < thingThingMapKeys.Count; i++) {
                item.thingThingMap[thingThingMapKeys[i]] = thingThingMapValues[i];
            }
            return item;
        }
        public void ToBytes(BinaryWriter writer, object o) {
            ThingThingMapObject item = (ThingThingMapObject)o;
            // MAP: thingThingMap
            writer.WriteFinalObjectCollection<IThing>(this.patternBuffer.GetSerializerByTypeName("Thing"), item.thingThingMap.Keys);
            writer.WriteFinalObjectCollection<IThing>(this.patternBuffer.GetSerializerByTypeName("Thing"), item.thingThingMap.Values);
        }
        public uint SizeOf(object o) {
            if (!(o is ThingThingMapObject)) {
                throw new PatternBufferException("Cannot size type "+o.GetType().Name+" using serializer "+this.GetType().Name +".");
            }
            ThingThingMapObject item = (ThingThingMapObject)o;
            uint size = 0;
            // thingThingMap
            size += (uint)PatternBufferUtil.GetUnsignedVariantSize((ulong)item.thingThingMap.Keys.Count);
            IPatternBufferSerializer serializer_cb6bda4647 = this.patternBuffer.GetSerializerByTypeName("Thing");
            foreach (Thing s in item.thingThingMap.Keys) {
                size += (uint)serializer_cb6bda4647.SizeOf(s);
            }
            size += (uint)PatternBufferUtil.GetUnsignedVariantSize((ulong)item.thingThingMap.Values.Count);
            IPatternBufferSerializer serializer_f46a72d0a7 = this.patternBuffer.GetSerializerByTypeName("Thing");
            foreach (Thing s in item.thingThingMap.Values) {
                size += (uint)serializer_f46a72d0a7.SizeOf(s);
            }
            // all primitives = 0 bytes
            return size;
        }
    }
}
