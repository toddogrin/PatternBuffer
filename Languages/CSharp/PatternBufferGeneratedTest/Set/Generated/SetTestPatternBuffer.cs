
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;

using System.Collections.Generic;

namespace Test.Set {
    public class SetTestPatternBuffer : AbstractPatternBuffer {
        protected override void RegisterSerializers() {

            AbstractThingSerializer serializer_adb82e2b57 = new AbstractThingSerializer(this);
            this.typeIdSerializerMap[9] = serializer_adb82e2b57;
            this.typeSerializerMap[typeof(AbstractThing)] = serializer_adb82e2b57;
            this.typeNameSerializerMap["AbstractThing"] = serializer_adb82e2b57;

            Thing1Serializer serializer_8af23fa188 = new Thing1Serializer(this);
            this.typeIdSerializerMap[10] = serializer_8af23fa188;
            this.typeSerializerMap[typeof(Thing1)] = serializer_8af23fa188;
            this.typeNameSerializerMap["Thing1"] = serializer_8af23fa188;

            Thing2Serializer serializer_dd8326ec6b = new Thing2Serializer(this);
            this.typeIdSerializerMap[11] = serializer_dd8326ec6b;
            this.typeSerializerMap[typeof(Thing2)] = serializer_dd8326ec6b;
            this.typeNameSerializerMap["Thing2"] = serializer_dd8326ec6b;

            IntSetObjectSerializer serializer_b993c27233 = new IntSetObjectSerializer(this);
            this.typeIdSerializerMap[12] = serializer_b993c27233;
            this.typeSerializerMap[typeof(IntSetObject)] = serializer_b993c27233;
            this.typeNameSerializerMap["IntSetObject"] = serializer_b993c27233;

            StringSetObjectSerializer serializer_5ae5a7c8f0 = new StringSetObjectSerializer(this);
            this.typeIdSerializerMap[13] = serializer_5ae5a7c8f0;
            this.typeSerializerMap[typeof(StringSetObject)] = serializer_5ae5a7c8f0;
            this.typeNameSerializerMap["StringSetObject"] = serializer_5ae5a7c8f0;

            Thing1SetObjectSerializer serializer_568b44f4f6 = new Thing1SetObjectSerializer(this);
            this.typeIdSerializerMap[14] = serializer_568b44f4f6;
            this.typeSerializerMap[typeof(Thing1SetObject)] = serializer_568b44f4f6;
            this.typeNameSerializerMap["Thing1SetObject"] = serializer_568b44f4f6;

            AbstractThingSetObjectSerializer serializer_607d3177fa = new AbstractThingSetObjectSerializer(this);
            this.typeIdSerializerMap[15] = serializer_607d3177fa;
            this.typeSerializerMap[typeof(AbstractThingSetObject)] = serializer_607d3177fa;
            this.typeNameSerializerMap["AbstractThingSetObject"] = serializer_607d3177fa;

            VIntSetObjectSerializer serializer_bb8606d571 = new VIntSetObjectSerializer(this);
            this.typeIdSerializerMap[16] = serializer_bb8606d571;
            this.typeSerializerMap[typeof(VIntSetObject)] = serializer_bb8606d571;
            this.typeNameSerializerMap["VIntSetObject"] = serializer_bb8606d571;

        }
        protected override void RegisterEnums() {

        }
    }
}
