
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;

using System.Collections.Generic;

namespace Test.Map {
    public class MapTestPatternBuffer : AbstractPatternBuffer {
        protected override void RegisterSerializers() {

            ThingSerializer serializer_f189fa0ef0 = new ThingSerializer(this);
            this.typeIdSerializerMap[10] = serializer_f189fa0ef0;
            this.typeSerializerMap[typeof(Thing)] = serializer_f189fa0ef0;
            this.typeNameSerializerMap["Thing"] = serializer_f189fa0ef0;

            IntThingMapObjectSerializer serializer_d26a97aab5 = new IntThingMapObjectSerializer(this);
            this.typeIdSerializerMap[11] = serializer_d26a97aab5;
            this.typeSerializerMap[typeof(IntThingMapObject)] = serializer_d26a97aab5;
            this.typeNameSerializerMap["IntThingMapObject"] = serializer_d26a97aab5;

            ThingIntMapObjectSerializer serializer_ee8adb30c2 = new ThingIntMapObjectSerializer(this);
            this.typeIdSerializerMap[12] = serializer_ee8adb30c2;
            this.typeSerializerMap[typeof(ThingIntMapObject)] = serializer_ee8adb30c2;
            this.typeNameSerializerMap["ThingIntMapObject"] = serializer_ee8adb30c2;

            IntStringMapObjectSerializer serializer_1c820ce7ec = new IntStringMapObjectSerializer(this);
            this.typeIdSerializerMap[13] = serializer_1c820ce7ec;
            this.typeSerializerMap[typeof(IntStringMapObject)] = serializer_1c820ce7ec;
            this.typeNameSerializerMap["IntStringMapObject"] = serializer_1c820ce7ec;

            ThingThingMapObjectSerializer serializer_85cc1cf509 = new ThingThingMapObjectSerializer(this);
            this.typeIdSerializerMap[14] = serializer_85cc1cf509;
            this.typeSerializerMap[typeof(ThingThingMapObject)] = serializer_85cc1cf509;
            this.typeNameSerializerMap["ThingThingMapObject"] = serializer_85cc1cf509;

            EnumIntMapObjectSerializer serializer_83d4beb476 = new EnumIntMapObjectSerializer(this);
            this.typeIdSerializerMap[15] = serializer_83d4beb476;
            this.typeSerializerMap[typeof(EnumIntMapObject)] = serializer_83d4beb476;
            this.typeNameSerializerMap["EnumIntMapObject"] = serializer_83d4beb476;

            VIntVLongMapObjectSerializer serializer_c8970b3b48 = new VIntVLongMapObjectSerializer(this);
            this.typeIdSerializerMap[16] = serializer_c8970b3b48;
            this.typeSerializerMap[typeof(VIntVLongMapObject)] = serializer_c8970b3b48;
            this.typeNameSerializerMap["VIntVLongMapObject"] = serializer_c8970b3b48;

        }
        protected override void RegisterEnums() {

            this.enumIndexValueMap["MyEnum"] = new Dictionary<byte,string>();
            this.enumValueIndexMap["MyEnum"] = new Dictionary<string,byte>();
            this.enumIndexValueMap["MyEnum"][1] = "value1";
            this.enumValueIndexMap["MyEnum"]["value1"] = 1;
            this.enumIndexValueMap["MyEnum"][2] = "value2";
            this.enumValueIndexMap["MyEnum"]["value2"] = 2;
            this.enumIndexValueMap["MyEnum"][3] = "value3";
            this.enumValueIndexMap["MyEnum"]["value3"] = 3;

        }
    }
}
