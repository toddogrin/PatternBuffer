
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;

using System.Collections.Generic;

namespace Test.Primitive {
    public class PrimitiveTestPatternBuffer : AbstractPatternBuffer {
        protected override void RegisterSerializers() {

            ShortObjectSerializer serializer_0e301a5100 = new ShortObjectSerializer(this);
            this.typeIdSerializerMap[11] = serializer_0e301a5100;
            this.typeSerializerMap[typeof(ShortObject)] = serializer_0e301a5100;
            this.typeNameSerializerMap["ShortObject"] = serializer_0e301a5100;

            IntObjectSerializer serializer_5c31971f51 = new IntObjectSerializer(this);
            this.typeIdSerializerMap[12] = serializer_5c31971f51;
            this.typeSerializerMap[typeof(IntObject)] = serializer_5c31971f51;
            this.typeNameSerializerMap["IntObject"] = serializer_5c31971f51;

            LongObjectSerializer serializer_17b3923a5f = new LongObjectSerializer(this);
            this.typeIdSerializerMap[13] = serializer_17b3923a5f;
            this.typeSerializerMap[typeof(LongObject)] = serializer_17b3923a5f;
            this.typeNameSerializerMap["LongObject"] = serializer_17b3923a5f;

            UShortObjectSerializer serializer_e222db0f83 = new UShortObjectSerializer(this);
            this.typeIdSerializerMap[14] = serializer_e222db0f83;
            this.typeSerializerMap[typeof(UShortObject)] = serializer_e222db0f83;
            this.typeNameSerializerMap["UShortObject"] = serializer_e222db0f83;

            UIntObjectSerializer serializer_17da9e3068 = new UIntObjectSerializer(this);
            this.typeIdSerializerMap[15] = serializer_17da9e3068;
            this.typeSerializerMap[typeof(UIntObject)] = serializer_17da9e3068;
            this.typeNameSerializerMap["UIntObject"] = serializer_17da9e3068;

            ULongObjectSerializer serializer_f81a2eef2c = new ULongObjectSerializer(this);
            this.typeIdSerializerMap[16] = serializer_f81a2eef2c;
            this.typeSerializerMap[typeof(ULongObject)] = serializer_f81a2eef2c;
            this.typeNameSerializerMap["ULongObject"] = serializer_f81a2eef2c;

            StringObjectSerializer serializer_43a9cb3478 = new StringObjectSerializer(this);
            this.typeIdSerializerMap[17] = serializer_43a9cb3478;
            this.typeSerializerMap[typeof(StringObject)] = serializer_43a9cb3478;
            this.typeNameSerializerMap["StringObject"] = serializer_43a9cb3478;

            DoubleObjectSerializer serializer_28cbbc37b9 = new DoubleObjectSerializer(this);
            this.typeIdSerializerMap[18] = serializer_28cbbc37b9;
            this.typeSerializerMap[typeof(DoubleObject)] = serializer_28cbbc37b9;
            this.typeNameSerializerMap["DoubleObject"] = serializer_28cbbc37b9;

            FloatObjectSerializer serializer_b5ad7e8a76 = new FloatObjectSerializer(this);
            this.typeIdSerializerMap[19] = serializer_b5ad7e8a76;
            this.typeSerializerMap[typeof(FloatObject)] = serializer_b5ad7e8a76;
            this.typeNameSerializerMap["FloatObject"] = serializer_b5ad7e8a76;

            BoolObjectSerializer serializer_1b2393a3e4 = new BoolObjectSerializer(this);
            this.typeIdSerializerMap[20] = serializer_1b2393a3e4;
            this.typeSerializerMap[typeof(BoolObject)] = serializer_1b2393a3e4;
            this.typeNameSerializerMap["BoolObject"] = serializer_1b2393a3e4;

            ByteObjectSerializer serializer_c40b544872 = new ByteObjectSerializer(this);
            this.typeIdSerializerMap[21] = serializer_c40b544872;
            this.typeSerializerMap[typeof(ByteObject)] = serializer_c40b544872;
            this.typeNameSerializerMap["ByteObject"] = serializer_c40b544872;

            EverythingObjectSerializer serializer_5f82091cdf = new EverythingObjectSerializer(this);
            this.typeIdSerializerMap[22] = serializer_5f82091cdf;
            this.typeSerializerMap[typeof(EverythingObject)] = serializer_5f82091cdf;
            this.typeNameSerializerMap["EverythingObject"] = serializer_5f82091cdf;

            VIntObjectSerializer serializer_6a32f3a30c = new VIntObjectSerializer(this);
            this.typeIdSerializerMap[112] = serializer_6a32f3a30c;
            this.typeSerializerMap[typeof(VIntObject)] = serializer_6a32f3a30c;
            this.typeNameSerializerMap["VIntObject"] = serializer_6a32f3a30c;

            VLongObjectSerializer serializer_7f4d12f2a2 = new VLongObjectSerializer(this);
            this.typeIdSerializerMap[113] = serializer_7f4d12f2a2;
            this.typeSerializerMap[typeof(VLongObject)] = serializer_7f4d12f2a2;
            this.typeNameSerializerMap["VLongObject"] = serializer_7f4d12f2a2;

            VUShortObjectSerializer serializer_7651feed0f = new VUShortObjectSerializer(this);
            this.typeIdSerializerMap[114] = serializer_7651feed0f;
            this.typeSerializerMap[typeof(VUShortObject)] = serializer_7651feed0f;
            this.typeNameSerializerMap["VUShortObject"] = serializer_7651feed0f;

            VUIntObjectSerializer serializer_898fb2b000 = new VUIntObjectSerializer(this);
            this.typeIdSerializerMap[115] = serializer_898fb2b000;
            this.typeSerializerMap[typeof(VUIntObject)] = serializer_898fb2b000;
            this.typeNameSerializerMap["VUIntObject"] = serializer_898fb2b000;

            VULongObjectSerializer serializer_073ffcb089 = new VULongObjectSerializer(this);
            this.typeIdSerializerMap[116] = serializer_073ffcb089;
            this.typeSerializerMap[typeof(VULongObject)] = serializer_073ffcb089;
            this.typeNameSerializerMap["VULongObject"] = serializer_073ffcb089;

        }
        protected override void RegisterEnums() {

        }
    }
}
