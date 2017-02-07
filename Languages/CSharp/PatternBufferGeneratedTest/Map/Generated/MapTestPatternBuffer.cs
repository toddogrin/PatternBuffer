
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System.Text;
using System;
using System.Collections.Generic;

namespace Test.Map {
    public class MapTestPatternBuffer {
        private static readonly ulong[] vuBoundaries = new ulong[] {
            128,
            16384,
            2097152,
            268435456,
            34359738368,
            4398046511104,
            562949953421312,
            72057594037927936,
            9223372036854775808
        };
        public static readonly Dictionary<string, Dictionary<byte, string>> enumIndexValueMap = new Dictionary<string, Dictionary<byte, string>>() {            {
                "MyEnum",
                new Dictionary<byte,string>() {
                    {(byte)1, "value1"},
                    {(byte)2, "value2"},
                    {(byte)3, "value3"}
                }
            }
        };
        public static readonly Dictionary<string, Dictionary<string, byte>> enumValueIndexMap = new Dictionary<string, Dictionary<string, byte>> {
            {
                "MyEnum",
                new Dictionary<string,byte>() {
                    {"value1", (byte)1},
                    {"value2", (byte)2},
                    {"value3", (byte)3}
                }
            }
        };
        private byte[] bytes;
        public MapTestPatternBuffer() : this(4096) { }
        public MapTestPatternBuffer(uint bufferSize) {
            this.bytes = new byte[bufferSize];
        }
///////////////////////////////////////
// TO BYTES
///////////////////////////////////////
        public byte[] Energize(Thing o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(IntThingMapObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(ThingIntMapObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(IntStringMapObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(ThingThingMapObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(EnumIntMapObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(VIntVLongMapObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public void Energize(Thing o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 10;
            }
                // PRIMITIVE: IntValue
                bytes[index++] = (byte)((o.IntValue >> 24) & 255);
                bytes[index++] = (byte)((o.IntValue >> 16) & 255);
                bytes[index++] = (byte)((o.IntValue >> 8) & 255);
                bytes[index++] = (byte)(o.IntValue & 255);
        }
        public void Energize(IntThingMapObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 11;
            }
                // MAP: IntThingMap
            if (o.IntThingMap.Keys == null || o.IntThingMap.Keys.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.IntThingMap.Keys.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.IntThingMap.Keys.Count;
                int i_vwVz2lA3PPf7;
                for (i_vwVz2lA3PPf7 = 0; i_vwVz2lA3PPf7 < 2; i_vwVz2lA3PPf7++) {
                    if ((ulong)o.IntThingMap.Keys.Count < vuBoundaries[i_vwVz2lA3PPf7]) {
                       byteCount = (int)(i_vwVz2lA3PPf7 + 1);
                       goto guvsgoto_kJhm8Q4QdT6r;
                    }
                }
                byteCount = (int)i_vwVz2lA3PPf7 + 1;
                guvsgoto_kJhm8Q4QdT6r:
                    for (int i_dhBxx5GvpKw3 = 0; i_dhBxx5GvpKw3 < byteCount; i_dhBxx5GvpKw3++) {
                        if (i_dhBxx5GvpKw3 < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_dhBxx5GvpKw3 < byteCount - 1) {
                                b += 128;
                            }
                            bytes[index++] = b;
                            value = value >> 7;
                        }
                        else {
                            bytes[index++] = (byte)value;
                            value = value >> 8;
                        }
                    }
                }
                foreach (int primitive in o.IntThingMap.Keys) {
                bytes[index++] = (byte)((primitive >> 24) & 255);
                bytes[index++] = (byte)((primitive >> 16) & 255);
                bytes[index++] = (byte)((primitive >> 8) & 255);
                bytes[index++] = (byte)(primitive & 255);
                }
            }
            if (o.IntThingMap.Values == null || o.IntThingMap.Values.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.IntThingMap.Values.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.IntThingMap.Values.Count;
                int i_magc2DRTEke1;
                for (i_magc2DRTEke1 = 0; i_magc2DRTEke1 < 2; i_magc2DRTEke1++) {
                    if ((ulong)o.IntThingMap.Values.Count < vuBoundaries[i_magc2DRTEke1]) {
                       byteCount = (int)(i_magc2DRTEke1 + 1);
                       goto guvsgoto_joQfh46MPfdd;
                    }
                }
                byteCount = (int)i_magc2DRTEke1 + 1;
                guvsgoto_joQfh46MPfdd:
                    for (int i_fHthnLcoa1dO = 0; i_fHthnLcoa1dO < byteCount; i_fHthnLcoa1dO++) {
                        if (i_fHthnLcoa1dO < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_fHthnLcoa1dO < byteCount - 1) {
                                b += 128;
                            }
                            bytes[index++] = b;
                            value = value >> 7;
                        }
                        else {
                            bytes[index++] = (byte)value;
                            value = value >> 8;
                        }
                    }
                }
                foreach (Thing finalObject in o.IntThingMap.Values) {
                    Energize(finalObject, bytes, ref index, false);
                }
            }
        }
        public void Energize(ThingIntMapObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 12;
            }
                // MAP: ThingIntMap
            if (o.ThingIntMap.Keys == null || o.ThingIntMap.Keys.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.ThingIntMap.Keys.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.ThingIntMap.Keys.Count;
                int i_vEDW3MzlkZ1K;
                for (i_vEDW3MzlkZ1K = 0; i_vEDW3MzlkZ1K < 2; i_vEDW3MzlkZ1K++) {
                    if ((ulong)o.ThingIntMap.Keys.Count < vuBoundaries[i_vEDW3MzlkZ1K]) {
                       byteCount = (int)(i_vEDW3MzlkZ1K + 1);
                       goto guvsgoto_nvVVTCrbey3x;
                    }
                }
                byteCount = (int)i_vEDW3MzlkZ1K + 1;
                guvsgoto_nvVVTCrbey3x:
                    for (int i_pYzdcZcM6CGG = 0; i_pYzdcZcM6CGG < byteCount; i_pYzdcZcM6CGG++) {
                        if (i_pYzdcZcM6CGG < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_pYzdcZcM6CGG < byteCount - 1) {
                                b += 128;
                            }
                            bytes[index++] = b;
                            value = value >> 7;
                        }
                        else {
                            bytes[index++] = (byte)value;
                            value = value >> 8;
                        }
                    }
                }
                foreach (Thing finalObject in o.ThingIntMap.Keys) {
                    Energize(finalObject, bytes, ref index, false);
                }
            }
            if (o.ThingIntMap.Values == null || o.ThingIntMap.Values.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.ThingIntMap.Values.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.ThingIntMap.Values.Count;
                int i_dquxC1EQDlj4;
                for (i_dquxC1EQDlj4 = 0; i_dquxC1EQDlj4 < 2; i_dquxC1EQDlj4++) {
                    if ((ulong)o.ThingIntMap.Values.Count < vuBoundaries[i_dquxC1EQDlj4]) {
                       byteCount = (int)(i_dquxC1EQDlj4 + 1);
                       goto guvsgoto_s6ac2cWZN5rT;
                    }
                }
                byteCount = (int)i_dquxC1EQDlj4 + 1;
                guvsgoto_s6ac2cWZN5rT:
                    for (int i_bo8pwqAx76e7 = 0; i_bo8pwqAx76e7 < byteCount; i_bo8pwqAx76e7++) {
                        if (i_bo8pwqAx76e7 < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_bo8pwqAx76e7 < byteCount - 1) {
                                b += 128;
                            }
                            bytes[index++] = b;
                            value = value >> 7;
                        }
                        else {
                            bytes[index++] = (byte)value;
                            value = value >> 8;
                        }
                    }
                }
                foreach (int primitive in o.ThingIntMap.Values) {
                bytes[index++] = (byte)((primitive >> 24) & 255);
                bytes[index++] = (byte)((primitive >> 16) & 255);
                bytes[index++] = (byte)((primitive >> 8) & 255);
                bytes[index++] = (byte)(primitive & 255);
                }
            }
        }
        public void Energize(IntStringMapObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 13;
            }
                // MAP: IntStringMap
            if (o.IntStringMap.Keys == null || o.IntStringMap.Keys.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.IntStringMap.Keys.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.IntStringMap.Keys.Count;
                int i_mOje80dGWf9O;
                for (i_mOje80dGWf9O = 0; i_mOje80dGWf9O < 2; i_mOje80dGWf9O++) {
                    if ((ulong)o.IntStringMap.Keys.Count < vuBoundaries[i_mOje80dGWf9O]) {
                       byteCount = (int)(i_mOje80dGWf9O + 1);
                       goto guvsgoto_qxthcc6PGQ4W;
                    }
                }
                byteCount = (int)i_mOje80dGWf9O + 1;
                guvsgoto_qxthcc6PGQ4W:
                    for (int i_bHDxE4VmmwVf = 0; i_bHDxE4VmmwVf < byteCount; i_bHDxE4VmmwVf++) {
                        if (i_bHDxE4VmmwVf < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_bHDxE4VmmwVf < byteCount - 1) {
                                b += 128;
                            }
                            bytes[index++] = b;
                            value = value >> 7;
                        }
                        else {
                            bytes[index++] = (byte)value;
                            value = value >> 8;
                        }
                    }
                }
                foreach (int primitive in o.IntStringMap.Keys) {
                bytes[index++] = (byte)((primitive >> 24) & 255);
                bytes[index++] = (byte)((primitive >> 16) & 255);
                bytes[index++] = (byte)((primitive >> 8) & 255);
                bytes[index++] = (byte)(primitive & 255);
                }
            }
            if (o.IntStringMap.Values == null || o.IntStringMap.Values.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.IntStringMap.Values.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.IntStringMap.Values.Count;
                int i_cvzh3IlHxPdE;
                for (i_cvzh3IlHxPdE = 0; i_cvzh3IlHxPdE < 2; i_cvzh3IlHxPdE++) {
                    if ((ulong)o.IntStringMap.Values.Count < vuBoundaries[i_cvzh3IlHxPdE]) {
                       byteCount = (int)(i_cvzh3IlHxPdE + 1);
                       goto guvsgoto_owNBoDxwumUR;
                    }
                }
                byteCount = (int)i_cvzh3IlHxPdE + 1;
                guvsgoto_owNBoDxwumUR:
                    for (int i_oJlM4RKi3dGL = 0; i_oJlM4RKi3dGL < byteCount; i_oJlM4RKi3dGL++) {
                        if (i_oJlM4RKi3dGL < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_oJlM4RKi3dGL < byteCount - 1) {
                                b += 128;
                            }
                            bytes[index++] = b;
                            value = value >> 7;
                        }
                        else {
                            bytes[index++] = (byte)value;
                            value = value >> 8;
                        }
                    }
                }
                foreach (string primitive in o.IntStringMap.Values) {
                uint stringLength_fLrsRMu0XVpi;
                int i_hVCMMMYdZY4r;
                for (i_hVCMMMYdZY4r = 0; i_hVCMMMYdZY4r < 2; i_hVCMMMYdZY4r++) {
                    if ((ulong)primitive.Length < vuBoundaries[i_hVCMMMYdZY4r]) {
                       stringLength_fLrsRMu0XVpi = (uint)(i_hVCMMMYdZY4r + 1);
                       goto guvsgoto_mOtOloS3si2P;
                    }
                }
                stringLength_fLrsRMu0XVpi = (uint)i_hVCMMMYdZY4r + 1;
                guvsgoto_mOtOloS3si2P:
                if (primitive.Length == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    ulong value = (ulong)primitive.Length;
                    for (int i_g2ZUvnRXtchp = 0; i_g2ZUvnRXtchp < stringLength_fLrsRMu0XVpi; i_g2ZUvnRXtchp++) {
                        if (i_g2ZUvnRXtchp < stringLength_fLrsRMu0XVpi - 1) {
                            byte b = (byte)(value & 127);
                            if (i_g2ZUvnRXtchp < stringLength_fLrsRMu0XVpi - 1) {
                                b += 128;
                            }
                            bytes[index++] = b;
                            value = value >> 7;
                        }
                        else {
                            bytes[index++] = (byte)value;
                            value = value >> 8;
                        }
                    }
                }
                index += Encoding.UTF8.GetBytes(primitive, 0, primitive.Length, bytes, index);
                }
            }
        }
        public void Energize(ThingThingMapObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 14;
            }
                // MAP: ThingThingMap
            if (o.ThingThingMap.Keys == null || o.ThingThingMap.Keys.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.ThingThingMap.Keys.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.ThingThingMap.Keys.Count;
                int i_eRol7mtQUcys;
                for (i_eRol7mtQUcys = 0; i_eRol7mtQUcys < 2; i_eRol7mtQUcys++) {
                    if ((ulong)o.ThingThingMap.Keys.Count < vuBoundaries[i_eRol7mtQUcys]) {
                       byteCount = (int)(i_eRol7mtQUcys + 1);
                       goto guvsgoto_k66PvNteSMa6;
                    }
                }
                byteCount = (int)i_eRol7mtQUcys + 1;
                guvsgoto_k66PvNteSMa6:
                    for (int i_k7IfBfvqNmnQ = 0; i_k7IfBfvqNmnQ < byteCount; i_k7IfBfvqNmnQ++) {
                        if (i_k7IfBfvqNmnQ < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_k7IfBfvqNmnQ < byteCount - 1) {
                                b += 128;
                            }
                            bytes[index++] = b;
                            value = value >> 7;
                        }
                        else {
                            bytes[index++] = (byte)value;
                            value = value >> 8;
                        }
                    }
                }
                foreach (Thing finalObject in o.ThingThingMap.Keys) {
                    Energize(finalObject, bytes, ref index, false);
                }
            }
            if (o.ThingThingMap.Values == null || o.ThingThingMap.Values.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.ThingThingMap.Values.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.ThingThingMap.Values.Count;
                int i_zGZgSBFwHNqy;
                for (i_zGZgSBFwHNqy = 0; i_zGZgSBFwHNqy < 2; i_zGZgSBFwHNqy++) {
                    if ((ulong)o.ThingThingMap.Values.Count < vuBoundaries[i_zGZgSBFwHNqy]) {
                       byteCount = (int)(i_zGZgSBFwHNqy + 1);
                       goto guvsgoto_rjRmF0IN23KN;
                    }
                }
                byteCount = (int)i_zGZgSBFwHNqy + 1;
                guvsgoto_rjRmF0IN23KN:
                    for (int i_cnNMrTs8EIFY = 0; i_cnNMrTs8EIFY < byteCount; i_cnNMrTs8EIFY++) {
                        if (i_cnNMrTs8EIFY < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_cnNMrTs8EIFY < byteCount - 1) {
                                b += 128;
                            }
                            bytes[index++] = b;
                            value = value >> 7;
                        }
                        else {
                            bytes[index++] = (byte)value;
                            value = value >> 8;
                        }
                    }
                }
                foreach (Thing finalObject in o.ThingThingMap.Values) {
                    Energize(finalObject, bytes, ref index, false);
                }
            }
        }
        public void Energize(EnumIntMapObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 15;
            }
                // MAP: EnumIntMap
            if (o.EnumIntMap.Keys == null || o.EnumIntMap.Keys.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.EnumIntMap.Keys.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.EnumIntMap.Keys.Count;
                int i_goHmR1ib2shr;
                for (i_goHmR1ib2shr = 0; i_goHmR1ib2shr < 2; i_goHmR1ib2shr++) {
                    if ((ulong)o.EnumIntMap.Keys.Count < vuBoundaries[i_goHmR1ib2shr]) {
                       byteCount = (int)(i_goHmR1ib2shr + 1);
                       goto guvsgoto_nhl3DVAFw5g4;
                    }
                }
                byteCount = (int)i_goHmR1ib2shr + 1;
                guvsgoto_nhl3DVAFw5g4:
                    for (int i_f5viLMiAabLL = 0; i_f5viLMiAabLL < byteCount; i_f5viLMiAabLL++) {
                        if (i_f5viLMiAabLL < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_f5viLMiAabLL < byteCount - 1) {
                                b += 128;
                            }
                            bytes[index++] = b;
                            value = value >> 7;
                        }
                        else {
                            bytes[index++] = (byte)value;
                            value = value >> 8;
                        }
                    }
                }
                foreach (MyEnum enumValue in o.EnumIntMap.Keys) {
                bytes[index++] = enumValueIndexMap["MyEnum"][enumValue.ToString()];
;
                }
            }
            if (o.EnumIntMap.Values == null || o.EnumIntMap.Values.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.EnumIntMap.Values.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.EnumIntMap.Values.Count;
                int i_ffrMzE5m93QH;
                for (i_ffrMzE5m93QH = 0; i_ffrMzE5m93QH < 2; i_ffrMzE5m93QH++) {
                    if ((ulong)o.EnumIntMap.Values.Count < vuBoundaries[i_ffrMzE5m93QH]) {
                       byteCount = (int)(i_ffrMzE5m93QH + 1);
                       goto guvsgoto_gL2WnVcjgSwc;
                    }
                }
                byteCount = (int)i_ffrMzE5m93QH + 1;
                guvsgoto_gL2WnVcjgSwc:
                    for (int i_kr3UWQ4oM56f = 0; i_kr3UWQ4oM56f < byteCount; i_kr3UWQ4oM56f++) {
                        if (i_kr3UWQ4oM56f < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_kr3UWQ4oM56f < byteCount - 1) {
                                b += 128;
                            }
                            bytes[index++] = b;
                            value = value >> 7;
                        }
                        else {
                            bytes[index++] = (byte)value;
                            value = value >> 8;
                        }
                    }
                }
                foreach (int primitive in o.EnumIntMap.Values) {
                bytes[index++] = (byte)((primitive >> 24) & 255);
                bytes[index++] = (byte)((primitive >> 16) & 255);
                bytes[index++] = (byte)((primitive >> 8) & 255);
                bytes[index++] = (byte)(primitive & 255);
                }
            }
        }
        public void Energize(VIntVLongMapObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 16;
            }
                // MAP: VintVlongMap
            if (o.VintVlongMap.Keys == null || o.VintVlongMap.Keys.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.VintVlongMap.Keys.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.VintVlongMap.Keys.Count;
                int i_iFaGgzMv4vx5;
                for (i_iFaGgzMv4vx5 = 0; i_iFaGgzMv4vx5 < 2; i_iFaGgzMv4vx5++) {
                    if ((ulong)o.VintVlongMap.Keys.Count < vuBoundaries[i_iFaGgzMv4vx5]) {
                       byteCount = (int)(i_iFaGgzMv4vx5 + 1);
                       goto guvsgoto_zvYhq7kEIs5F;
                    }
                }
                byteCount = (int)i_iFaGgzMv4vx5 + 1;
                guvsgoto_zvYhq7kEIs5F:
                    for (int i_wrxAYiArjlOe = 0; i_wrxAYiArjlOe < byteCount; i_wrxAYiArjlOe++) {
                        if (i_wrxAYiArjlOe < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_wrxAYiArjlOe < byteCount - 1) {
                                b += 128;
                            }
                            bytes[index++] = b;
                            value = value >> 7;
                        }
                        else {
                            bytes[index++] = (byte)value;
                            value = value >> 8;
                        }
                    }
                }
                foreach (int primitive in o.VintVlongMap.Keys) {
    //// AppendSignedToULong(primitive)
    long s2ultemp_rY5cTm8gvyyq = primitive;
    if (s2ultemp_rY5cTm8gvyyq == long.MinValue) {
        s2ultemp_rY5cTm8gvyyq = long.MaxValue;
    }
    else {
        if (s2ultemp_rY5cTm8gvyyq > 0) {
            s2ultemp_rY5cTm8gvyyq = -s2ultemp_rY5cTm8gvyyq;
        }
        s2ultemp_rY5cTm8gvyyq -= 1;
    }
    s2ultemp_rY5cTm8gvyyq = ~s2ultemp_rY5cTm8gvyyq;
    ulong s2ulresult_ryintKkM72p9 = (ulong)s2ultemp_rY5cTm8gvyyq;
    //// AppendGetSignVariantSize(s2ulresult_ryintKkM72p9)
    byte vr_pTQA2Ovj16Zs = 1;
    for (int v_mJMSwqJC2hVA = 56; v_mJMSwqJC2hVA >= 0; v_mJMSwqJC2hVA -= 8) {
        if (((255UL << v_mJMSwqJC2hVA) & s2ulresult_ryintKkM72p9) > 0) {
            vr_pTQA2Ovj16Zs = (byte)(v_mJMSwqJC2hVA / 8 + 2);
            break;
        }
    }
    bytes[index++] = (byte)((byte)(vr_pTQA2Ovj16Zs << 1) | (byte)(primitive > 0 ? 0 : 1));
    for (int vi_am7IabgXI6C9 = 0; vi_am7IabgXI6C9 < vr_pTQA2Ovj16Zs - 1; vi_am7IabgXI6C9++) {
        bytes[index++] = (byte)(s2ulresult_ryintKkM72p9 & 255);
        s2ulresult_ryintKkM72p9 = s2ulresult_ryintKkM72p9 >> 8;
    }
                }
            }
            if (o.VintVlongMap.Values == null || o.VintVlongMap.Values.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.VintVlongMap.Values.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.VintVlongMap.Values.Count;
                int i_zCqRtWgC8qzP;
                for (i_zCqRtWgC8qzP = 0; i_zCqRtWgC8qzP < 2; i_zCqRtWgC8qzP++) {
                    if ((ulong)o.VintVlongMap.Values.Count < vuBoundaries[i_zCqRtWgC8qzP]) {
                       byteCount = (int)(i_zCqRtWgC8qzP + 1);
                       goto guvsgoto_nIoRcozTI0TT;
                    }
                }
                byteCount = (int)i_zCqRtWgC8qzP + 1;
                guvsgoto_nIoRcozTI0TT:
                    for (int i_sWjZZcTHhNnX = 0; i_sWjZZcTHhNnX < byteCount; i_sWjZZcTHhNnX++) {
                        if (i_sWjZZcTHhNnX < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_sWjZZcTHhNnX < byteCount - 1) {
                                b += 128;
                            }
                            bytes[index++] = b;
                            value = value >> 7;
                        }
                        else {
                            bytes[index++] = (byte)value;
                            value = value >> 8;
                        }
                    }
                }
                foreach (long primitive in o.VintVlongMap.Values) {
    //// AppendSignedToULong(primitive)
    long s2ultemp_a2zNSb2kDoKI = primitive;
    if (s2ultemp_a2zNSb2kDoKI == long.MinValue) {
        s2ultemp_a2zNSb2kDoKI = long.MaxValue;
    }
    else {
        if (s2ultemp_a2zNSb2kDoKI > 0) {
            s2ultemp_a2zNSb2kDoKI = -s2ultemp_a2zNSb2kDoKI;
        }
        s2ultemp_a2zNSb2kDoKI -= 1;
    }
    s2ultemp_a2zNSb2kDoKI = ~s2ultemp_a2zNSb2kDoKI;
    ulong s2ulresult_tzEV09apiIaq = (ulong)s2ultemp_a2zNSb2kDoKI;
    //// AppendGetSignVariantSize(s2ulresult_tzEV09apiIaq)
    byte vr_cJ3FglLvoCOA = 1;
    for (int v_jCU6yplCmKeA = 56; v_jCU6yplCmKeA >= 0; v_jCU6yplCmKeA -= 8) {
        if (((255UL << v_jCU6yplCmKeA) & s2ulresult_tzEV09apiIaq) > 0) {
            vr_cJ3FglLvoCOA = (byte)(v_jCU6yplCmKeA / 8 + 2);
            break;
        }
    }
    bytes[index++] = (byte)((byte)(vr_cJ3FglLvoCOA << 1) | (byte)(primitive > 0 ? 0 : 1));
    for (int vi_o7RiM7PD2jIi = 0; vi_o7RiM7PD2jIi < vr_cJ3FglLvoCOA - 1; vi_o7RiM7PD2jIi++) {
        bytes[index++] = (byte)(s2ulresult_tzEV09apiIaq & 255);
        s2ulresult_tzEV09apiIaq = s2ulresult_tzEV09apiIaq >> 8;
    }
                }
            }
        }
        public void Energize(IMapTestObject o, byte[] bytes, ref int index, bool writeTypeId) {
            switch (o.TypeId) {
                case 10:
                    Energize((Thing)o, bytes, ref index, writeTypeId);
                    break;
                case 11:
                    Energize((IntThingMapObject)o, bytes, ref index, writeTypeId);
                    break;
                case 12:
                    Energize((ThingIntMapObject)o, bytes, ref index, writeTypeId);
                    break;
                case 13:
                    Energize((IntStringMapObject)o, bytes, ref index, writeTypeId);
                    break;
                case 14:
                    Energize((ThingThingMapObject)o, bytes, ref index, writeTypeId);
                    break;
                case 15:
                    Energize((EnumIntMapObject)o, bytes, ref index, writeTypeId);
                    break;
                case 16:
                    Energize((VIntVLongMapObject)o, bytes, ref index, writeTypeId);
                    break;
                default:
                    throw new MapTestPatternBufferException("Unrecognized type ID: "+o.TypeId+" ");
            }
        }
///////////////////////////////////////
// FROM BYTES
///////////////////////////////////////
        public object Energize(byte[] bytes) {
            int index = 0;
                    ulong vuread_dwdsMptsUdzx = 0;
                    for (int i_gd12xHdFEC8i = 0; i_gd12xHdFEC8i < 9; i_gd12xHdFEC8i++) {
                        byte b = bytes[index++];
                        if (i_gd12xHdFEC8i < 8) {
                            vuread_dwdsMptsUdzx += (((ulong)b & (ulong)127) << (7 * i_gd12xHdFEC8i));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_dwdsMptsUdzx += (ulong)b << (7 * i_gd12xHdFEC8i);
                            break;
                        }
                    }
                    ushort typeId = (ushort)vuread_dwdsMptsUdzx;
            switch (typeId) {
            case 10:
                {
                Thing o = new Thing();
                // PRIMITIVE: IntValue
                o.IntValue =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    return o;
                }
            case 11:
                {
                IntThingMapObject o = new IntThingMapObject();
                // MAP: IntThingMap
                IList<int> intThingMapKeys = new List<int>();
                IList<Thing> intThingMapValues = new List<Thing>();
            // Read list item count
            ushort count_mDSrXlIm3LYc;
                    ulong vuread_e206qWPDIt3I = 0;
                    for (int i_cWgugdNPx5Zj = 0; i_cWgugdNPx5Zj < 9; i_cWgugdNPx5Zj++) {
                        byte b = bytes[index++];
                        if (i_cWgugdNPx5Zj < 8) {
                            vuread_e206qWPDIt3I += (((ulong)b & (ulong)127) << (7 * i_cWgugdNPx5Zj));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_e206qWPDIt3I += (ulong)b << (7 * i_cWgugdNPx5Zj);
                            break;
                        }
                    }
                    count_mDSrXlIm3LYc = (ushort)vuread_e206qWPDIt3I;
            // Read list items
            if (count_mDSrXlIm3LYc > 0) {
                intThingMapKeys = new List<int>();
                int listValue_ncFJFmDNpZRE;
                for (int i_rgoSXEKjJjkb = 0; i_rgoSXEKjJjkb < count_mDSrXlIm3LYc; i_rgoSXEKjJjkb++) {
                    // Read Int list item
                listValue_ncFJFmDNpZRE =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    intThingMapKeys.Add(listValue_ncFJFmDNpZRE);
                }
            }
            // Read list item count
            ushort count_cng07iOqdRzo;
                    ulong vuread_hg8wZptrfLO9 = 0;
                    for (int i_v423vPJw2DDr = 0; i_v423vPJw2DDr < 9; i_v423vPJw2DDr++) {
                        byte b = bytes[index++];
                        if (i_v423vPJw2DDr < 8) {
                            vuread_hg8wZptrfLO9 += (((ulong)b & (ulong)127) << (7 * i_v423vPJw2DDr));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_hg8wZptrfLO9 += (ulong)b << (7 * i_v423vPJw2DDr);
                            break;
                        }
                    }
                    count_cng07iOqdRzo = (ushort)vuread_hg8wZptrfLO9;
            // Read list items
            if (count_cng07iOqdRzo > 0) {
                intThingMapValues = new List<Thing>();
                for (int li_cNPgkAA9QaBQ = 0; li_cNPgkAA9QaBQ < count_cng07iOqdRzo; li_cNPgkAA9QaBQ++) {
                    intThingMapValues.Add((Thing)Energize(bytes, ref index, 10));
                }
            }
                o.IntThingMap = new Dictionary<int,Thing>(intThingMapKeys.Count);
                for (int i_nntu025DJhbc = 0; i_nntu025DJhbc < intThingMapKeys.Count; i_nntu025DJhbc++) {
                    o.IntThingMap[intThingMapKeys[i_nntu025DJhbc]] = intThingMapValues[i_nntu025DJhbc];
                }
                    return o;
                }
            case 12:
                {
                ThingIntMapObject o = new ThingIntMapObject();
                // MAP: ThingIntMap
                IList<Thing> thingIntMapKeys = new List<Thing>();
                IList<int> thingIntMapValues = new List<int>();
            // Read list item count
            ushort count_gU5yidvXNQqm;
                    ulong vuread_pmgPlOsYDmxh = 0;
                    for (int i_jpGaIaR8LN1A = 0; i_jpGaIaR8LN1A < 9; i_jpGaIaR8LN1A++) {
                        byte b = bytes[index++];
                        if (i_jpGaIaR8LN1A < 8) {
                            vuread_pmgPlOsYDmxh += (((ulong)b & (ulong)127) << (7 * i_jpGaIaR8LN1A));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_pmgPlOsYDmxh += (ulong)b << (7 * i_jpGaIaR8LN1A);
                            break;
                        }
                    }
                    count_gU5yidvXNQqm = (ushort)vuread_pmgPlOsYDmxh;
            // Read list items
            if (count_gU5yidvXNQqm > 0) {
                thingIntMapKeys = new List<Thing>();
                for (int li_mc1NOOdZ7gUO = 0; li_mc1NOOdZ7gUO < count_gU5yidvXNQqm; li_mc1NOOdZ7gUO++) {
                    thingIntMapKeys.Add((Thing)Energize(bytes, ref index, 10));
                }
            }
            // Read list item count
            ushort count_tqs4YmJdwYc2;
                    ulong vuread_nvoM9rL6vQki = 0;
                    for (int i_uOkYjIjpF1or = 0; i_uOkYjIjpF1or < 9; i_uOkYjIjpF1or++) {
                        byte b = bytes[index++];
                        if (i_uOkYjIjpF1or < 8) {
                            vuread_nvoM9rL6vQki += (((ulong)b & (ulong)127) << (7 * i_uOkYjIjpF1or));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_nvoM9rL6vQki += (ulong)b << (7 * i_uOkYjIjpF1or);
                            break;
                        }
                    }
                    count_tqs4YmJdwYc2 = (ushort)vuread_nvoM9rL6vQki;
            // Read list items
            if (count_tqs4YmJdwYc2 > 0) {
                thingIntMapValues = new List<int>();
                int listValue_sWjydXdQa8hs;
                for (int i_kA0QEXtfgjhk = 0; i_kA0QEXtfgjhk < count_tqs4YmJdwYc2; i_kA0QEXtfgjhk++) {
                    // Read Int list item
                listValue_sWjydXdQa8hs =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    thingIntMapValues.Add(listValue_sWjydXdQa8hs);
                }
            }
                o.ThingIntMap = new Dictionary<Thing,int>(thingIntMapKeys.Count);
                for (int i_aV4YOWxPg74m = 0; i_aV4YOWxPg74m < thingIntMapKeys.Count; i_aV4YOWxPg74m++) {
                    o.ThingIntMap[thingIntMapKeys[i_aV4YOWxPg74m]] = thingIntMapValues[i_aV4YOWxPg74m];
                }
                    return o;
                }
            case 13:
                {
                IntStringMapObject o = new IntStringMapObject();
                // MAP: IntStringMap
                IList<int> intStringMapKeys = new List<int>();
                IList<string> intStringMapValues = new List<string>();
            // Read list item count
            ushort count_dn2HMDiYH1yS;
                    ulong vuread_sDURIjlIP9vs = 0;
                    for (int i_xpbnKBmCFNIr = 0; i_xpbnKBmCFNIr < 9; i_xpbnKBmCFNIr++) {
                        byte b = bytes[index++];
                        if (i_xpbnKBmCFNIr < 8) {
                            vuread_sDURIjlIP9vs += (((ulong)b & (ulong)127) << (7 * i_xpbnKBmCFNIr));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_sDURIjlIP9vs += (ulong)b << (7 * i_xpbnKBmCFNIr);
                            break;
                        }
                    }
                    count_dn2HMDiYH1yS = (ushort)vuread_sDURIjlIP9vs;
            // Read list items
            if (count_dn2HMDiYH1yS > 0) {
                intStringMapKeys = new List<int>();
                int listValue_xVCMatMkxlfl;
                for (int i_aQg7VvGh1KOx = 0; i_aQg7VvGh1KOx < count_dn2HMDiYH1yS; i_aQg7VvGh1KOx++) {
                    // Read Int list item
                listValue_xVCMatMkxlfl =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    intStringMapKeys.Add(listValue_xVCMatMkxlfl);
                }
            }
            // Read list item count
            ushort count_l5nfP5ne5DWX;
                    ulong vuread_sIIvwl4Rj0l4 = 0;
                    for (int i_jpRjgAzugekf = 0; i_jpRjgAzugekf < 9; i_jpRjgAzugekf++) {
                        byte b = bytes[index++];
                        if (i_jpRjgAzugekf < 8) {
                            vuread_sIIvwl4Rj0l4 += (((ulong)b & (ulong)127) << (7 * i_jpRjgAzugekf));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_sIIvwl4Rj0l4 += (ulong)b << (7 * i_jpRjgAzugekf);
                            break;
                        }
                    }
                    count_l5nfP5ne5DWX = (ushort)vuread_sIIvwl4Rj0l4;
            // Read list items
            if (count_l5nfP5ne5DWX > 0) {
                intStringMapValues = new List<string>();
                string listValue_cHFC8bpJ4tpn;
                for (int i_ulVQP6oLTtUz = 0; i_ulVQP6oLTtUz < count_l5nfP5ne5DWX; i_ulVQP6oLTtUz++) {
                    // Read String list item
                    ulong vuread_rCThKMac9Dw5 = 0;
                    for (int i_rTPjZIvWXfo5 = 0; i_rTPjZIvWXfo5 < 9; i_rTPjZIvWXfo5++) {
                        byte b = bytes[index++];
                        if (i_rTPjZIvWXfo5 < 8) {
                            vuread_rCThKMac9Dw5 += (((ulong)b & (ulong)127) << (7 * i_rTPjZIvWXfo5));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_rCThKMac9Dw5 += (ulong)b << (7 * i_rTPjZIvWXfo5);
                            break;
                        }
                    }
                    ushort stringLength_fd7EdBQMyCqZ = (ushort)vuread_rCThKMac9Dw5;
                listValue_cHFC8bpJ4tpn = Encoding.UTF8.GetString(bytes, index, stringLength_fd7EdBQMyCqZ);
                index += stringLength_fd7EdBQMyCqZ;
                    intStringMapValues.Add(listValue_cHFC8bpJ4tpn);
                }
            }
                o.IntStringMap = new Dictionary<int,string>(intStringMapKeys.Count);
                for (int i_bVFCMMYu45bn = 0; i_bVFCMMYu45bn < intStringMapKeys.Count; i_bVFCMMYu45bn++) {
                    o.IntStringMap[intStringMapKeys[i_bVFCMMYu45bn]] = intStringMapValues[i_bVFCMMYu45bn];
                }
                    return o;
                }
            case 14:
                {
                ThingThingMapObject o = new ThingThingMapObject();
                // MAP: ThingThingMap
                IList<Thing> thingThingMapKeys = new List<Thing>();
                IList<Thing> thingThingMapValues = new List<Thing>();
            // Read list item count
            ushort count_fgbhsRAUQbZu;
                    ulong vuread_uGX0hEcKoXeZ = 0;
                    for (int i_cHAwPbbTSC6S = 0; i_cHAwPbbTSC6S < 9; i_cHAwPbbTSC6S++) {
                        byte b = bytes[index++];
                        if (i_cHAwPbbTSC6S < 8) {
                            vuread_uGX0hEcKoXeZ += (((ulong)b & (ulong)127) << (7 * i_cHAwPbbTSC6S));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_uGX0hEcKoXeZ += (ulong)b << (7 * i_cHAwPbbTSC6S);
                            break;
                        }
                    }
                    count_fgbhsRAUQbZu = (ushort)vuread_uGX0hEcKoXeZ;
            // Read list items
            if (count_fgbhsRAUQbZu > 0) {
                thingThingMapKeys = new List<Thing>();
                for (int li_onDfPEob6lQf = 0; li_onDfPEob6lQf < count_fgbhsRAUQbZu; li_onDfPEob6lQf++) {
                    thingThingMapKeys.Add((Thing)Energize(bytes, ref index, 10));
                }
            }
            // Read list item count
            ushort count_v8nA3A8zclbU;
                    ulong vuread_hdePafMuKes3 = 0;
                    for (int i_a64TJc341uHQ = 0; i_a64TJc341uHQ < 9; i_a64TJc341uHQ++) {
                        byte b = bytes[index++];
                        if (i_a64TJc341uHQ < 8) {
                            vuread_hdePafMuKes3 += (((ulong)b & (ulong)127) << (7 * i_a64TJc341uHQ));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_hdePafMuKes3 += (ulong)b << (7 * i_a64TJc341uHQ);
                            break;
                        }
                    }
                    count_v8nA3A8zclbU = (ushort)vuread_hdePafMuKes3;
            // Read list items
            if (count_v8nA3A8zclbU > 0) {
                thingThingMapValues = new List<Thing>();
                for (int li_uL0rDGQvmSYL = 0; li_uL0rDGQvmSYL < count_v8nA3A8zclbU; li_uL0rDGQvmSYL++) {
                    thingThingMapValues.Add((Thing)Energize(bytes, ref index, 10));
                }
            }
                o.ThingThingMap = new Dictionary<Thing,Thing>(thingThingMapKeys.Count);
                for (int i_kJb0JvEVQuz7 = 0; i_kJb0JvEVQuz7 < thingThingMapKeys.Count; i_kJb0JvEVQuz7++) {
                    o.ThingThingMap[thingThingMapKeys[i_kJb0JvEVQuz7]] = thingThingMapValues[i_kJb0JvEVQuz7];
                }
                    return o;
                }
            case 15:
                {
                EnumIntMapObject o = new EnumIntMapObject();
                // MAP: EnumIntMap
                IList<MyEnum> enumIntMapKeys = new List<MyEnum>();
                IList<int> enumIntMapValues = new List<int>();
            // Read list item count
            ushort count_np0asg37Gx1z;
                    ulong vuread_gu1ex6Qsitua = 0;
                    for (int i_acuGZVaDl3Un = 0; i_acuGZVaDl3Un < 9; i_acuGZVaDl3Un++) {
                        byte b = bytes[index++];
                        if (i_acuGZVaDl3Un < 8) {
                            vuread_gu1ex6Qsitua += (((ulong)b & (ulong)127) << (7 * i_acuGZVaDl3Un));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_gu1ex6Qsitua += (ulong)b << (7 * i_acuGZVaDl3Un);
                            break;
                        }
                    }
                    count_np0asg37Gx1z = (ushort)vuread_gu1ex6Qsitua;
            // Read list items
            if (count_np0asg37Gx1z > 0) {
                enumIntMapKeys = new List<MyEnum>();
                for (int i_rQdfZ1fbRMLo = 0; i_rQdfZ1fbRMLo < count_np0asg37Gx1z; i_rQdfZ1fbRMLo++) {
                    enumIntMapKeys.Add((MyEnum)System.Enum.Parse(typeof(MyEnum), enumIndexValueMap["MyEnum"][bytes[index++]]));
                }
            }
            // Read list item count
            ushort count_mAyTOgZn409p;
                    ulong vuread_uwhVwynvJNyR = 0;
                    for (int i_wLDqnssyAfcz = 0; i_wLDqnssyAfcz < 9; i_wLDqnssyAfcz++) {
                        byte b = bytes[index++];
                        if (i_wLDqnssyAfcz < 8) {
                            vuread_uwhVwynvJNyR += (((ulong)b & (ulong)127) << (7 * i_wLDqnssyAfcz));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_uwhVwynvJNyR += (ulong)b << (7 * i_wLDqnssyAfcz);
                            break;
                        }
                    }
                    count_mAyTOgZn409p = (ushort)vuread_uwhVwynvJNyR;
            // Read list items
            if (count_mAyTOgZn409p > 0) {
                enumIntMapValues = new List<int>();
                int listValue_jrZfdHtZRYtC;
                for (int i_tuPtypO0cQ0c = 0; i_tuPtypO0cQ0c < count_mAyTOgZn409p; i_tuPtypO0cQ0c++) {
                    // Read Int list item
                listValue_jrZfdHtZRYtC =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    enumIntMapValues.Add(listValue_jrZfdHtZRYtC);
                }
            }
                o.EnumIntMap = new Dictionary<MyEnum,int>(enumIntMapKeys.Count);
                for (int i_qI9MIKYQuRxf = 0; i_qI9MIKYQuRxf < enumIntMapKeys.Count; i_qI9MIKYQuRxf++) {
                    o.EnumIntMap[enumIntMapKeys[i_qI9MIKYQuRxf]] = enumIntMapValues[i_qI9MIKYQuRxf];
                }
                    return o;
                }
            case 16:
                {
                VIntVLongMapObject o = new VIntVLongMapObject();
                // MAP: VintVlongMap
                IList<int> vintVlongMapKeys = new List<int>();
                IList<long> vintVlongMapValues = new List<long>();
            // Read list item count
            ushort count_oircuIaeraG3;
                    ulong vuread_q89lAlwQAWBF = 0;
                    for (int i_oQrg9Nhb6KUq = 0; i_oQrg9Nhb6KUq < 9; i_oQrg9Nhb6KUq++) {
                        byte b = bytes[index++];
                        if (i_oQrg9Nhb6KUq < 8) {
                            vuread_q89lAlwQAWBF += (((ulong)b & (ulong)127) << (7 * i_oQrg9Nhb6KUq));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_q89lAlwQAWBF += (ulong)b << (7 * i_oQrg9Nhb6KUq);
                            break;
                        }
                    }
                    count_oircuIaeraG3 = (ushort)vuread_q89lAlwQAWBF;
            // Read list items
            if (count_oircuIaeraG3 > 0) {
                vintVlongMapKeys = new List<int>();
                int listValue_zMGEQWVMbf9J;
                for (int i_pNpjvROWQWDN = 0; i_pNpjvROWQWDN < count_oircuIaeraG3; i_pNpjvROWQWDN++) {
                    // Read VInt list item
    byte rvint_b_h3fO3F7cnTnY = bytes[index++];
    byte rvint_sign_r29OaYECQRGv = (byte)(rvint_b_h3fO3F7cnTnY & 1);
    byte rvint_size_k7Qo57Jlj2nX = (byte)(rvint_b_h3fO3F7cnTnY >> 1);
    ulong rvint_remaining_shTGi6v0ABEC = 0;
    for (int i_saV2rb6IwTq5 = 0; i_saV2rb6IwTq5 < rvint_size_k7Qo57Jlj2nX - 1; i_saV2rb6IwTq5++) {
        rvint_remaining_shTGi6v0ABEC = rvint_remaining_shTGi6v0ABEC | (((ulong)bytes[index++] << (8 * i_saV2rb6IwTq5)));
    }
    int rvint_result_vShpjbOWPm73 = (int)rvint_remaining_shTGi6v0ABEC;
    rvint_result_vShpjbOWPm73 = ~rvint_result_vShpjbOWPm73;
    if (rvint_result_vShpjbOWPm73 == int.MaxValue) {
        rvint_result_vShpjbOWPm73 = int.MinValue;
    }
    else {
        // Add offset
        rvint_result_vShpjbOWPm73 += 1;
        if (rvint_sign_r29OaYECQRGv == 0) {
            rvint_result_vShpjbOWPm73 = -rvint_result_vShpjbOWPm73;
        }
    }
    listValue_zMGEQWVMbf9J = rvint_result_vShpjbOWPm73;
                    vintVlongMapKeys.Add(listValue_zMGEQWVMbf9J);
                }
            }
            // Read list item count
            ushort count_c8tUvP57DoG4;
                    ulong vuread_fR4h5OA71YRz = 0;
                    for (int i_vgRzWSXEd2Xs = 0; i_vgRzWSXEd2Xs < 9; i_vgRzWSXEd2Xs++) {
                        byte b = bytes[index++];
                        if (i_vgRzWSXEd2Xs < 8) {
                            vuread_fR4h5OA71YRz += (((ulong)b & (ulong)127) << (7 * i_vgRzWSXEd2Xs));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_fR4h5OA71YRz += (ulong)b << (7 * i_vgRzWSXEd2Xs);
                            break;
                        }
                    }
                    count_c8tUvP57DoG4 = (ushort)vuread_fR4h5OA71YRz;
            // Read list items
            if (count_c8tUvP57DoG4 > 0) {
                vintVlongMapValues = new List<long>();
                long listValue_smnRYtCJlmdC;
                for (int i_cG0bW9crq35p = 0; i_cG0bW9crq35p < count_c8tUvP57DoG4; i_cG0bW9crq35p++) {
                    // Read VLong list item
    byte rvlong_b_zGkUBc1t3LAT = bytes[index++];
    byte rvlong_sign_lTiHvioLcorp = (byte)(rvlong_b_zGkUBc1t3LAT & 1);
    byte rvlong_size_wVRdZGcXq7Ss = (byte)(rvlong_b_zGkUBc1t3LAT >> 1);
    ulong rvlong_remaining_dRijvUIFggJd = 0;
    for (int i_wE5iPtnUo52P = 0; i_wE5iPtnUo52P < rvlong_size_wVRdZGcXq7Ss - 1; i_wE5iPtnUo52P++) {
        rvlong_remaining_dRijvUIFggJd = rvlong_remaining_dRijvUIFggJd | (((ulong)bytes[index++] << (8 * i_wE5iPtnUo52P)));
    }
    long rvlong_result_iYExIMCEa0zO = (long)rvlong_remaining_dRijvUIFggJd;
    rvlong_result_iYExIMCEa0zO = ~rvlong_result_iYExIMCEa0zO;
    if (rvlong_result_iYExIMCEa0zO == long.MaxValue) {
        rvlong_result_iYExIMCEa0zO = long.MinValue;
    }
    else {
        // Add offset
        rvlong_result_iYExIMCEa0zO += 1;
        if (rvlong_sign_lTiHvioLcorp == 0) {
            rvlong_result_iYExIMCEa0zO = -rvlong_result_iYExIMCEa0zO;
        }
    }
    listValue_smnRYtCJlmdC = rvlong_result_iYExIMCEa0zO;
                    vintVlongMapValues.Add(listValue_smnRYtCJlmdC);
                }
            }
                o.VintVlongMap = new Dictionary<int,long>(vintVlongMapKeys.Count);
                for (int i_zeqsPWiVlOmu = 0; i_zeqsPWiVlOmu < vintVlongMapKeys.Count; i_zeqsPWiVlOmu++) {
                    o.VintVlongMap[vintVlongMapKeys[i_zeqsPWiVlOmu]] = vintVlongMapValues[i_zeqsPWiVlOmu];
                }
                    return o;
                }
                default:
                    throw new MapTestPatternBufferException("Unrecognized type ID: "+typeId+" ");
            }
        }
        public object Energize(byte[] bytes, ref int index) {
                    ulong vuread_p3h7T8emZDZH = 0;
                    for (int i_gk6DOfcafrjL = 0; i_gk6DOfcafrjL < 9; i_gk6DOfcafrjL++) {
                        byte b = bytes[index++];
                        if (i_gk6DOfcafrjL < 8) {
                            vuread_p3h7T8emZDZH += (((ulong)b & (ulong)127) << (7 * i_gk6DOfcafrjL));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_p3h7T8emZDZH += (ulong)b << (7 * i_gk6DOfcafrjL);
                            break;
                        }
                    }
                    ushort typeId = (ushort)vuread_p3h7T8emZDZH;
            switch (typeId) {
            case 10:
                {
                Thing o = new Thing();
                // PRIMITIVE: IntValue
                o.IntValue =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    return o;
                }
            case 11:
                {
                IntThingMapObject o = new IntThingMapObject();
                // MAP: IntThingMap
                IList<int> intThingMapKeys = new List<int>();
                IList<Thing> intThingMapValues = new List<Thing>();
            // Read list item count
            ushort count_b5eBWgDPLjWP;
                    ulong vuread_nEUcWmYGpTcE = 0;
                    for (int i_vPhfLmptUG4X = 0; i_vPhfLmptUG4X < 9; i_vPhfLmptUG4X++) {
                        byte b = bytes[index++];
                        if (i_vPhfLmptUG4X < 8) {
                            vuread_nEUcWmYGpTcE += (((ulong)b & (ulong)127) << (7 * i_vPhfLmptUG4X));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_nEUcWmYGpTcE += (ulong)b << (7 * i_vPhfLmptUG4X);
                            break;
                        }
                    }
                    count_b5eBWgDPLjWP = (ushort)vuread_nEUcWmYGpTcE;
            // Read list items
            if (count_b5eBWgDPLjWP > 0) {
                intThingMapKeys = new List<int>();
                int listValue_xMAT9j5fyr8j;
                for (int i_iao2CMwt3JMg = 0; i_iao2CMwt3JMg < count_b5eBWgDPLjWP; i_iao2CMwt3JMg++) {
                    // Read Int list item
                listValue_xMAT9j5fyr8j =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    intThingMapKeys.Add(listValue_xMAT9j5fyr8j);
                }
            }
            // Read list item count
            ushort count_zxez3C48K6jj;
                    ulong vuread_ufGfX6gHR8UL = 0;
                    for (int i_zx1hkK4t9tUM = 0; i_zx1hkK4t9tUM < 9; i_zx1hkK4t9tUM++) {
                        byte b = bytes[index++];
                        if (i_zx1hkK4t9tUM < 8) {
                            vuread_ufGfX6gHR8UL += (((ulong)b & (ulong)127) << (7 * i_zx1hkK4t9tUM));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_ufGfX6gHR8UL += (ulong)b << (7 * i_zx1hkK4t9tUM);
                            break;
                        }
                    }
                    count_zxez3C48K6jj = (ushort)vuread_ufGfX6gHR8UL;
            // Read list items
            if (count_zxez3C48K6jj > 0) {
                intThingMapValues = new List<Thing>();
                for (int li_cGl5x9Iy0egw = 0; li_cGl5x9Iy0egw < count_zxez3C48K6jj; li_cGl5x9Iy0egw++) {
                    intThingMapValues.Add((Thing)Energize(bytes, ref index, 10));
                }
            }
                o.IntThingMap = new Dictionary<int,Thing>(intThingMapKeys.Count);
                for (int i_cqG6CfzaMCBG = 0; i_cqG6CfzaMCBG < intThingMapKeys.Count; i_cqG6CfzaMCBG++) {
                    o.IntThingMap[intThingMapKeys[i_cqG6CfzaMCBG]] = intThingMapValues[i_cqG6CfzaMCBG];
                }
                    return o;
                }
            case 12:
                {
                ThingIntMapObject o = new ThingIntMapObject();
                // MAP: ThingIntMap
                IList<Thing> thingIntMapKeys = new List<Thing>();
                IList<int> thingIntMapValues = new List<int>();
            // Read list item count
            ushort count_pWY9cZkCv4ar;
                    ulong vuread_tljRzwU3rFb4 = 0;
                    for (int i_b7143T9MePuL = 0; i_b7143T9MePuL < 9; i_b7143T9MePuL++) {
                        byte b = bytes[index++];
                        if (i_b7143T9MePuL < 8) {
                            vuread_tljRzwU3rFb4 += (((ulong)b & (ulong)127) << (7 * i_b7143T9MePuL));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_tljRzwU3rFb4 += (ulong)b << (7 * i_b7143T9MePuL);
                            break;
                        }
                    }
                    count_pWY9cZkCv4ar = (ushort)vuread_tljRzwU3rFb4;
            // Read list items
            if (count_pWY9cZkCv4ar > 0) {
                thingIntMapKeys = new List<Thing>();
                for (int li_eJwb3Nbmppmr = 0; li_eJwb3Nbmppmr < count_pWY9cZkCv4ar; li_eJwb3Nbmppmr++) {
                    thingIntMapKeys.Add((Thing)Energize(bytes, ref index, 10));
                }
            }
            // Read list item count
            ushort count_ySKqRHpgV45e;
                    ulong vuread_zqIL4ymf1IH0 = 0;
                    for (int i_zT9NDYPYVK8l = 0; i_zT9NDYPYVK8l < 9; i_zT9NDYPYVK8l++) {
                        byte b = bytes[index++];
                        if (i_zT9NDYPYVK8l < 8) {
                            vuread_zqIL4ymf1IH0 += (((ulong)b & (ulong)127) << (7 * i_zT9NDYPYVK8l));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_zqIL4ymf1IH0 += (ulong)b << (7 * i_zT9NDYPYVK8l);
                            break;
                        }
                    }
                    count_ySKqRHpgV45e = (ushort)vuread_zqIL4ymf1IH0;
            // Read list items
            if (count_ySKqRHpgV45e > 0) {
                thingIntMapValues = new List<int>();
                int listValue_dS4HAn0pNrdN;
                for (int i_bzr0chzxlTq8 = 0; i_bzr0chzxlTq8 < count_ySKqRHpgV45e; i_bzr0chzxlTq8++) {
                    // Read Int list item
                listValue_dS4HAn0pNrdN =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    thingIntMapValues.Add(listValue_dS4HAn0pNrdN);
                }
            }
                o.ThingIntMap = new Dictionary<Thing,int>(thingIntMapKeys.Count);
                for (int i_oLM6pgsxrxCm = 0; i_oLM6pgsxrxCm < thingIntMapKeys.Count; i_oLM6pgsxrxCm++) {
                    o.ThingIntMap[thingIntMapKeys[i_oLM6pgsxrxCm]] = thingIntMapValues[i_oLM6pgsxrxCm];
                }
                    return o;
                }
            case 13:
                {
                IntStringMapObject o = new IntStringMapObject();
                // MAP: IntStringMap
                IList<int> intStringMapKeys = new List<int>();
                IList<string> intStringMapValues = new List<string>();
            // Read list item count
            ushort count_mPONSrnSPvJe;
                    ulong vuread_nYWOkKazB59Z = 0;
                    for (int i_p3aH8PwR7fwx = 0; i_p3aH8PwR7fwx < 9; i_p3aH8PwR7fwx++) {
                        byte b = bytes[index++];
                        if (i_p3aH8PwR7fwx < 8) {
                            vuread_nYWOkKazB59Z += (((ulong)b & (ulong)127) << (7 * i_p3aH8PwR7fwx));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_nYWOkKazB59Z += (ulong)b << (7 * i_p3aH8PwR7fwx);
                            break;
                        }
                    }
                    count_mPONSrnSPvJe = (ushort)vuread_nYWOkKazB59Z;
            // Read list items
            if (count_mPONSrnSPvJe > 0) {
                intStringMapKeys = new List<int>();
                int listValue_lVP3GIslbIzB;
                for (int i_iNnRxdUIQZcY = 0; i_iNnRxdUIQZcY < count_mPONSrnSPvJe; i_iNnRxdUIQZcY++) {
                    // Read Int list item
                listValue_lVP3GIslbIzB =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    intStringMapKeys.Add(listValue_lVP3GIslbIzB);
                }
            }
            // Read list item count
            ushort count_hQTa92hBCymy;
                    ulong vuread_yg23MXXdDJmu = 0;
                    for (int i_mPt3vXRMT0M0 = 0; i_mPt3vXRMT0M0 < 9; i_mPt3vXRMT0M0++) {
                        byte b = bytes[index++];
                        if (i_mPt3vXRMT0M0 < 8) {
                            vuread_yg23MXXdDJmu += (((ulong)b & (ulong)127) << (7 * i_mPt3vXRMT0M0));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_yg23MXXdDJmu += (ulong)b << (7 * i_mPt3vXRMT0M0);
                            break;
                        }
                    }
                    count_hQTa92hBCymy = (ushort)vuread_yg23MXXdDJmu;
            // Read list items
            if (count_hQTa92hBCymy > 0) {
                intStringMapValues = new List<string>();
                string listValue_vsmjA885BYVq;
                for (int i_e152c8uRDyHu = 0; i_e152c8uRDyHu < count_hQTa92hBCymy; i_e152c8uRDyHu++) {
                    // Read String list item
                    ulong vuread_pNMFKq3O3dSE = 0;
                    for (int i_wYKVF5xAV1Ln = 0; i_wYKVF5xAV1Ln < 9; i_wYKVF5xAV1Ln++) {
                        byte b = bytes[index++];
                        if (i_wYKVF5xAV1Ln < 8) {
                            vuread_pNMFKq3O3dSE += (((ulong)b & (ulong)127) << (7 * i_wYKVF5xAV1Ln));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_pNMFKq3O3dSE += (ulong)b << (7 * i_wYKVF5xAV1Ln);
                            break;
                        }
                    }
                    ushort stringLength_onfORJPeDbet = (ushort)vuread_pNMFKq3O3dSE;
                listValue_vsmjA885BYVq = Encoding.UTF8.GetString(bytes, index, stringLength_onfORJPeDbet);
                index += stringLength_onfORJPeDbet;
                    intStringMapValues.Add(listValue_vsmjA885BYVq);
                }
            }
                o.IntStringMap = new Dictionary<int,string>(intStringMapKeys.Count);
                for (int i_wto1jQXjWMrz = 0; i_wto1jQXjWMrz < intStringMapKeys.Count; i_wto1jQXjWMrz++) {
                    o.IntStringMap[intStringMapKeys[i_wto1jQXjWMrz]] = intStringMapValues[i_wto1jQXjWMrz];
                }
                    return o;
                }
            case 14:
                {
                ThingThingMapObject o = new ThingThingMapObject();
                // MAP: ThingThingMap
                IList<Thing> thingThingMapKeys = new List<Thing>();
                IList<Thing> thingThingMapValues = new List<Thing>();
            // Read list item count
            ushort count_jZhmE2BFELX2;
                    ulong vuread_z3JIONITcyMq = 0;
                    for (int i_abFmpJRpGlzQ = 0; i_abFmpJRpGlzQ < 9; i_abFmpJRpGlzQ++) {
                        byte b = bytes[index++];
                        if (i_abFmpJRpGlzQ < 8) {
                            vuread_z3JIONITcyMq += (((ulong)b & (ulong)127) << (7 * i_abFmpJRpGlzQ));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_z3JIONITcyMq += (ulong)b << (7 * i_abFmpJRpGlzQ);
                            break;
                        }
                    }
                    count_jZhmE2BFELX2 = (ushort)vuread_z3JIONITcyMq;
            // Read list items
            if (count_jZhmE2BFELX2 > 0) {
                thingThingMapKeys = new List<Thing>();
                for (int li_uk52AgTrGw2p = 0; li_uk52AgTrGw2p < count_jZhmE2BFELX2; li_uk52AgTrGw2p++) {
                    thingThingMapKeys.Add((Thing)Energize(bytes, ref index, 10));
                }
            }
            // Read list item count
            ushort count_doFjdIx7m1kD;
                    ulong vuread_jop53HvYE2UD = 0;
                    for (int i_sQs5PvTPjqfb = 0; i_sQs5PvTPjqfb < 9; i_sQs5PvTPjqfb++) {
                        byte b = bytes[index++];
                        if (i_sQs5PvTPjqfb < 8) {
                            vuread_jop53HvYE2UD += (((ulong)b & (ulong)127) << (7 * i_sQs5PvTPjqfb));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_jop53HvYE2UD += (ulong)b << (7 * i_sQs5PvTPjqfb);
                            break;
                        }
                    }
                    count_doFjdIx7m1kD = (ushort)vuread_jop53HvYE2UD;
            // Read list items
            if (count_doFjdIx7m1kD > 0) {
                thingThingMapValues = new List<Thing>();
                for (int li_bHm8XCD69CEm = 0; li_bHm8XCD69CEm < count_doFjdIx7m1kD; li_bHm8XCD69CEm++) {
                    thingThingMapValues.Add((Thing)Energize(bytes, ref index, 10));
                }
            }
                o.ThingThingMap = new Dictionary<Thing,Thing>(thingThingMapKeys.Count);
                for (int i_wYx8adVoDbCx = 0; i_wYx8adVoDbCx < thingThingMapKeys.Count; i_wYx8adVoDbCx++) {
                    o.ThingThingMap[thingThingMapKeys[i_wYx8adVoDbCx]] = thingThingMapValues[i_wYx8adVoDbCx];
                }
                    return o;
                }
            case 15:
                {
                EnumIntMapObject o = new EnumIntMapObject();
                // MAP: EnumIntMap
                IList<MyEnum> enumIntMapKeys = new List<MyEnum>();
                IList<int> enumIntMapValues = new List<int>();
            // Read list item count
            ushort count_gBr1hFthio0w;
                    ulong vuread_jxabzYDolgf1 = 0;
                    for (int i_zUPgE1HcfZSw = 0; i_zUPgE1HcfZSw < 9; i_zUPgE1HcfZSw++) {
                        byte b = bytes[index++];
                        if (i_zUPgE1HcfZSw < 8) {
                            vuread_jxabzYDolgf1 += (((ulong)b & (ulong)127) << (7 * i_zUPgE1HcfZSw));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_jxabzYDolgf1 += (ulong)b << (7 * i_zUPgE1HcfZSw);
                            break;
                        }
                    }
                    count_gBr1hFthio0w = (ushort)vuread_jxabzYDolgf1;
            // Read list items
            if (count_gBr1hFthio0w > 0) {
                enumIntMapKeys = new List<MyEnum>();
                for (int i_eLZEjxdM7bNM = 0; i_eLZEjxdM7bNM < count_gBr1hFthio0w; i_eLZEjxdM7bNM++) {
                    enumIntMapKeys.Add((MyEnum)System.Enum.Parse(typeof(MyEnum), enumIndexValueMap["MyEnum"][bytes[index++]]));
                }
            }
            // Read list item count
            ushort count_bTYPHnlivz4w;
                    ulong vuread_vnMrRYqGPN0X = 0;
                    for (int i_z9fYdD46hcdV = 0; i_z9fYdD46hcdV < 9; i_z9fYdD46hcdV++) {
                        byte b = bytes[index++];
                        if (i_z9fYdD46hcdV < 8) {
                            vuread_vnMrRYqGPN0X += (((ulong)b & (ulong)127) << (7 * i_z9fYdD46hcdV));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_vnMrRYqGPN0X += (ulong)b << (7 * i_z9fYdD46hcdV);
                            break;
                        }
                    }
                    count_bTYPHnlivz4w = (ushort)vuread_vnMrRYqGPN0X;
            // Read list items
            if (count_bTYPHnlivz4w > 0) {
                enumIntMapValues = new List<int>();
                int listValue_a1E1NJaVRCO5;
                for (int i_tV5iUg7z2bQH = 0; i_tV5iUg7z2bQH < count_bTYPHnlivz4w; i_tV5iUg7z2bQH++) {
                    // Read Int list item
                listValue_a1E1NJaVRCO5 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    enumIntMapValues.Add(listValue_a1E1NJaVRCO5);
                }
            }
                o.EnumIntMap = new Dictionary<MyEnum,int>(enumIntMapKeys.Count);
                for (int i_dxf2F7oXk1pZ = 0; i_dxf2F7oXk1pZ < enumIntMapKeys.Count; i_dxf2F7oXk1pZ++) {
                    o.EnumIntMap[enumIntMapKeys[i_dxf2F7oXk1pZ]] = enumIntMapValues[i_dxf2F7oXk1pZ];
                }
                    return o;
                }
            case 16:
                {
                VIntVLongMapObject o = new VIntVLongMapObject();
                // MAP: VintVlongMap
                IList<int> vintVlongMapKeys = new List<int>();
                IList<long> vintVlongMapValues = new List<long>();
            // Read list item count
            ushort count_iy2fNffGvjdr;
                    ulong vuread_oVlafO2al6Tq = 0;
                    for (int i_mhpTo0V3GfYv = 0; i_mhpTo0V3GfYv < 9; i_mhpTo0V3GfYv++) {
                        byte b = bytes[index++];
                        if (i_mhpTo0V3GfYv < 8) {
                            vuread_oVlafO2al6Tq += (((ulong)b & (ulong)127) << (7 * i_mhpTo0V3GfYv));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_oVlafO2al6Tq += (ulong)b << (7 * i_mhpTo0V3GfYv);
                            break;
                        }
                    }
                    count_iy2fNffGvjdr = (ushort)vuread_oVlafO2al6Tq;
            // Read list items
            if (count_iy2fNffGvjdr > 0) {
                vintVlongMapKeys = new List<int>();
                int listValue_f1WW5km9tYuT;
                for (int i_uoRG8oOwPMMF = 0; i_uoRG8oOwPMMF < count_iy2fNffGvjdr; i_uoRG8oOwPMMF++) {
                    // Read VInt list item
    byte rvint_b_vvrExkVC6ZWo = bytes[index++];
    byte rvint_sign_wgfaUT6PWF7a = (byte)(rvint_b_vvrExkVC6ZWo & 1);
    byte rvint_size_dp4rBCPKpq6J = (byte)(rvint_b_vvrExkVC6ZWo >> 1);
    ulong rvint_remaining_wRLjc2X6BDN2 = 0;
    for (int i_dNM5Q6Suyrwh = 0; i_dNM5Q6Suyrwh < rvint_size_dp4rBCPKpq6J - 1; i_dNM5Q6Suyrwh++) {
        rvint_remaining_wRLjc2X6BDN2 = rvint_remaining_wRLjc2X6BDN2 | (((ulong)bytes[index++] << (8 * i_dNM5Q6Suyrwh)));
    }
    int rvint_result_gEbEkl9LjGid = (int)rvint_remaining_wRLjc2X6BDN2;
    rvint_result_gEbEkl9LjGid = ~rvint_result_gEbEkl9LjGid;
    if (rvint_result_gEbEkl9LjGid == int.MaxValue) {
        rvint_result_gEbEkl9LjGid = int.MinValue;
    }
    else {
        // Add offset
        rvint_result_gEbEkl9LjGid += 1;
        if (rvint_sign_wgfaUT6PWF7a == 0) {
            rvint_result_gEbEkl9LjGid = -rvint_result_gEbEkl9LjGid;
        }
    }
    listValue_f1WW5km9tYuT = rvint_result_gEbEkl9LjGid;
                    vintVlongMapKeys.Add(listValue_f1WW5km9tYuT);
                }
            }
            // Read list item count
            ushort count_dWM4SbIPLchX;
                    ulong vuread_vU4sILlKvE4I = 0;
                    for (int i_wsWpDcSNFIX4 = 0; i_wsWpDcSNFIX4 < 9; i_wsWpDcSNFIX4++) {
                        byte b = bytes[index++];
                        if (i_wsWpDcSNFIX4 < 8) {
                            vuread_vU4sILlKvE4I += (((ulong)b & (ulong)127) << (7 * i_wsWpDcSNFIX4));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_vU4sILlKvE4I += (ulong)b << (7 * i_wsWpDcSNFIX4);
                            break;
                        }
                    }
                    count_dWM4SbIPLchX = (ushort)vuread_vU4sILlKvE4I;
            // Read list items
            if (count_dWM4SbIPLchX > 0) {
                vintVlongMapValues = new List<long>();
                long listValue_iXMwSQFnwnOA;
                for (int i_hQcIuHRO2edz = 0; i_hQcIuHRO2edz < count_dWM4SbIPLchX; i_hQcIuHRO2edz++) {
                    // Read VLong list item
    byte rvlong_b_gtmJtEsr699V = bytes[index++];
    byte rvlong_sign_zY2O8QmNOw7X = (byte)(rvlong_b_gtmJtEsr699V & 1);
    byte rvlong_size_aks70jcpUnhz = (byte)(rvlong_b_gtmJtEsr699V >> 1);
    ulong rvlong_remaining_m6415xDsRrJG = 0;
    for (int i_rdQl2zV3wyIi = 0; i_rdQl2zV3wyIi < rvlong_size_aks70jcpUnhz - 1; i_rdQl2zV3wyIi++) {
        rvlong_remaining_m6415xDsRrJG = rvlong_remaining_m6415xDsRrJG | (((ulong)bytes[index++] << (8 * i_rdQl2zV3wyIi)));
    }
    long rvlong_result_fuAW7UaVRCkb = (long)rvlong_remaining_m6415xDsRrJG;
    rvlong_result_fuAW7UaVRCkb = ~rvlong_result_fuAW7UaVRCkb;
    if (rvlong_result_fuAW7UaVRCkb == long.MaxValue) {
        rvlong_result_fuAW7UaVRCkb = long.MinValue;
    }
    else {
        // Add offset
        rvlong_result_fuAW7UaVRCkb += 1;
        if (rvlong_sign_zY2O8QmNOw7X == 0) {
            rvlong_result_fuAW7UaVRCkb = -rvlong_result_fuAW7UaVRCkb;
        }
    }
    listValue_iXMwSQFnwnOA = rvlong_result_fuAW7UaVRCkb;
                    vintVlongMapValues.Add(listValue_iXMwSQFnwnOA);
                }
            }
                o.VintVlongMap = new Dictionary<int,long>(vintVlongMapKeys.Count);
                for (int i_uuSr2PfSLWsX = 0; i_uuSr2PfSLWsX < vintVlongMapKeys.Count; i_uuSr2PfSLWsX++) {
                    o.VintVlongMap[vintVlongMapKeys[i_uuSr2PfSLWsX]] = vintVlongMapValues[i_uuSr2PfSLWsX];
                }
                    return o;
                }
                default:
                    throw new MapTestPatternBufferException("Unrecognized type ID: "+typeId+" ");
            }
        }
        public object Energize(byte[] bytes, ref int index, ushort typeId) {
            switch (typeId) {
            case 10:
                {
                Thing o = new Thing();
                // PRIMITIVE: IntValue
                o.IntValue =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    return o;
                }
            case 11:
                {
                IntThingMapObject o = new IntThingMapObject();
                // MAP: IntThingMap
                IList<int> intThingMapKeys = new List<int>();
                IList<Thing> intThingMapValues = new List<Thing>();
            // Read list item count
            ushort count_m0wvBndfyVPK;
                    ulong vuread_yQu6qXYm2PyH = 0;
                    for (int i_rEbQsZHzcMtg = 0; i_rEbQsZHzcMtg < 9; i_rEbQsZHzcMtg++) {
                        byte b = bytes[index++];
                        if (i_rEbQsZHzcMtg < 8) {
                            vuread_yQu6qXYm2PyH += (((ulong)b & (ulong)127) << (7 * i_rEbQsZHzcMtg));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_yQu6qXYm2PyH += (ulong)b << (7 * i_rEbQsZHzcMtg);
                            break;
                        }
                    }
                    count_m0wvBndfyVPK = (ushort)vuread_yQu6qXYm2PyH;
            // Read list items
            if (count_m0wvBndfyVPK > 0) {
                intThingMapKeys = new List<int>();
                int listValue_jPtDzfMaOiul;
                for (int i_ijCX8f5YBZO7 = 0; i_ijCX8f5YBZO7 < count_m0wvBndfyVPK; i_ijCX8f5YBZO7++) {
                    // Read Int list item
                listValue_jPtDzfMaOiul =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    intThingMapKeys.Add(listValue_jPtDzfMaOiul);
                }
            }
            // Read list item count
            ushort count_fwWIoqIuxoJL;
                    ulong vuread_muWXcy3IkZwj = 0;
                    for (int i_jUB6QEOIavrd = 0; i_jUB6QEOIavrd < 9; i_jUB6QEOIavrd++) {
                        byte b = bytes[index++];
                        if (i_jUB6QEOIavrd < 8) {
                            vuread_muWXcy3IkZwj += (((ulong)b & (ulong)127) << (7 * i_jUB6QEOIavrd));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_muWXcy3IkZwj += (ulong)b << (7 * i_jUB6QEOIavrd);
                            break;
                        }
                    }
                    count_fwWIoqIuxoJL = (ushort)vuread_muWXcy3IkZwj;
            // Read list items
            if (count_fwWIoqIuxoJL > 0) {
                intThingMapValues = new List<Thing>();
                for (int li_heWxJ9XfJ0sN = 0; li_heWxJ9XfJ0sN < count_fwWIoqIuxoJL; li_heWxJ9XfJ0sN++) {
                    intThingMapValues.Add((Thing)Energize(bytes, ref index, 10));
                }
            }
                o.IntThingMap = new Dictionary<int,Thing>(intThingMapKeys.Count);
                for (int i_hiWd5gXx9MkD = 0; i_hiWd5gXx9MkD < intThingMapKeys.Count; i_hiWd5gXx9MkD++) {
                    o.IntThingMap[intThingMapKeys[i_hiWd5gXx9MkD]] = intThingMapValues[i_hiWd5gXx9MkD];
                }
                    return o;
                }
            case 12:
                {
                ThingIntMapObject o = new ThingIntMapObject();
                // MAP: ThingIntMap
                IList<Thing> thingIntMapKeys = new List<Thing>();
                IList<int> thingIntMapValues = new List<int>();
            // Read list item count
            ushort count_vMN2KaKidTE8;
                    ulong vuread_pF8kbqJHBXNI = 0;
                    for (int i_sKM4I4dQ3sI7 = 0; i_sKM4I4dQ3sI7 < 9; i_sKM4I4dQ3sI7++) {
                        byte b = bytes[index++];
                        if (i_sKM4I4dQ3sI7 < 8) {
                            vuread_pF8kbqJHBXNI += (((ulong)b & (ulong)127) << (7 * i_sKM4I4dQ3sI7));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_pF8kbqJHBXNI += (ulong)b << (7 * i_sKM4I4dQ3sI7);
                            break;
                        }
                    }
                    count_vMN2KaKidTE8 = (ushort)vuread_pF8kbqJHBXNI;
            // Read list items
            if (count_vMN2KaKidTE8 > 0) {
                thingIntMapKeys = new List<Thing>();
                for (int li_j4FJpkKJNYCA = 0; li_j4FJpkKJNYCA < count_vMN2KaKidTE8; li_j4FJpkKJNYCA++) {
                    thingIntMapKeys.Add((Thing)Energize(bytes, ref index, 10));
                }
            }
            // Read list item count
            ushort count_dNvScNcb8fk9;
                    ulong vuread_kQKjPYes7aYh = 0;
                    for (int i_tarrmd44imW4 = 0; i_tarrmd44imW4 < 9; i_tarrmd44imW4++) {
                        byte b = bytes[index++];
                        if (i_tarrmd44imW4 < 8) {
                            vuread_kQKjPYes7aYh += (((ulong)b & (ulong)127) << (7 * i_tarrmd44imW4));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_kQKjPYes7aYh += (ulong)b << (7 * i_tarrmd44imW4);
                            break;
                        }
                    }
                    count_dNvScNcb8fk9 = (ushort)vuread_kQKjPYes7aYh;
            // Read list items
            if (count_dNvScNcb8fk9 > 0) {
                thingIntMapValues = new List<int>();
                int listValue_ouNpqG8qUFlJ;
                for (int i_oB3ZTkCgYo7c = 0; i_oB3ZTkCgYo7c < count_dNvScNcb8fk9; i_oB3ZTkCgYo7c++) {
                    // Read Int list item
                listValue_ouNpqG8qUFlJ =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    thingIntMapValues.Add(listValue_ouNpqG8qUFlJ);
                }
            }
                o.ThingIntMap = new Dictionary<Thing,int>(thingIntMapKeys.Count);
                for (int i_jUY5kp1l4PKv = 0; i_jUY5kp1l4PKv < thingIntMapKeys.Count; i_jUY5kp1l4PKv++) {
                    o.ThingIntMap[thingIntMapKeys[i_jUY5kp1l4PKv]] = thingIntMapValues[i_jUY5kp1l4PKv];
                }
                    return o;
                }
            case 13:
                {
                IntStringMapObject o = new IntStringMapObject();
                // MAP: IntStringMap
                IList<int> intStringMapKeys = new List<int>();
                IList<string> intStringMapValues = new List<string>();
            // Read list item count
            ushort count_eZbAcHwpZSRV;
                    ulong vuread_eek7TPfuxL3G = 0;
                    for (int i_sdgFO9P31IO4 = 0; i_sdgFO9P31IO4 < 9; i_sdgFO9P31IO4++) {
                        byte b = bytes[index++];
                        if (i_sdgFO9P31IO4 < 8) {
                            vuread_eek7TPfuxL3G += (((ulong)b & (ulong)127) << (7 * i_sdgFO9P31IO4));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_eek7TPfuxL3G += (ulong)b << (7 * i_sdgFO9P31IO4);
                            break;
                        }
                    }
                    count_eZbAcHwpZSRV = (ushort)vuread_eek7TPfuxL3G;
            // Read list items
            if (count_eZbAcHwpZSRV > 0) {
                intStringMapKeys = new List<int>();
                int listValue_dcer1RmOcdUf;
                for (int i_b3BoJp8J5FS8 = 0; i_b3BoJp8J5FS8 < count_eZbAcHwpZSRV; i_b3BoJp8J5FS8++) {
                    // Read Int list item
                listValue_dcer1RmOcdUf =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    intStringMapKeys.Add(listValue_dcer1RmOcdUf);
                }
            }
            // Read list item count
            ushort count_l1LZdX4LAqZR;
                    ulong vuread_pYDPyoDOsaAU = 0;
                    for (int i_oAtLKe8Ntf0a = 0; i_oAtLKe8Ntf0a < 9; i_oAtLKe8Ntf0a++) {
                        byte b = bytes[index++];
                        if (i_oAtLKe8Ntf0a < 8) {
                            vuread_pYDPyoDOsaAU += (((ulong)b & (ulong)127) << (7 * i_oAtLKe8Ntf0a));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_pYDPyoDOsaAU += (ulong)b << (7 * i_oAtLKe8Ntf0a);
                            break;
                        }
                    }
                    count_l1LZdX4LAqZR = (ushort)vuread_pYDPyoDOsaAU;
            // Read list items
            if (count_l1LZdX4LAqZR > 0) {
                intStringMapValues = new List<string>();
                string listValue_cwLpiiPYeTNV;
                for (int i_uslRcePAA1rM = 0; i_uslRcePAA1rM < count_l1LZdX4LAqZR; i_uslRcePAA1rM++) {
                    // Read String list item
                    ulong vuread_qoFjvMQYXIZr = 0;
                    for (int i_xrLpzzJof9V0 = 0; i_xrLpzzJof9V0 < 9; i_xrLpzzJof9V0++) {
                        byte b = bytes[index++];
                        if (i_xrLpzzJof9V0 < 8) {
                            vuread_qoFjvMQYXIZr += (((ulong)b & (ulong)127) << (7 * i_xrLpzzJof9V0));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_qoFjvMQYXIZr += (ulong)b << (7 * i_xrLpzzJof9V0);
                            break;
                        }
                    }
                    ushort stringLength_msbvrmxF8CJb = (ushort)vuread_qoFjvMQYXIZr;
                listValue_cwLpiiPYeTNV = Encoding.UTF8.GetString(bytes, index, stringLength_msbvrmxF8CJb);
                index += stringLength_msbvrmxF8CJb;
                    intStringMapValues.Add(listValue_cwLpiiPYeTNV);
                }
            }
                o.IntStringMap = new Dictionary<int,string>(intStringMapKeys.Count);
                for (int i_dtG2whXtTkdX = 0; i_dtG2whXtTkdX < intStringMapKeys.Count; i_dtG2whXtTkdX++) {
                    o.IntStringMap[intStringMapKeys[i_dtG2whXtTkdX]] = intStringMapValues[i_dtG2whXtTkdX];
                }
                    return o;
                }
            case 14:
                {
                ThingThingMapObject o = new ThingThingMapObject();
                // MAP: ThingThingMap
                IList<Thing> thingThingMapKeys = new List<Thing>();
                IList<Thing> thingThingMapValues = new List<Thing>();
            // Read list item count
            ushort count_oGeYlCY5CUCa;
                    ulong vuread_pifI3u5OCPcc = 0;
                    for (int i_cYCQVGITnXQ3 = 0; i_cYCQVGITnXQ3 < 9; i_cYCQVGITnXQ3++) {
                        byte b = bytes[index++];
                        if (i_cYCQVGITnXQ3 < 8) {
                            vuread_pifI3u5OCPcc += (((ulong)b & (ulong)127) << (7 * i_cYCQVGITnXQ3));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_pifI3u5OCPcc += (ulong)b << (7 * i_cYCQVGITnXQ3);
                            break;
                        }
                    }
                    count_oGeYlCY5CUCa = (ushort)vuread_pifI3u5OCPcc;
            // Read list items
            if (count_oGeYlCY5CUCa > 0) {
                thingThingMapKeys = new List<Thing>();
                for (int li_iVdNk0xw0Grn = 0; li_iVdNk0xw0Grn < count_oGeYlCY5CUCa; li_iVdNk0xw0Grn++) {
                    thingThingMapKeys.Add((Thing)Energize(bytes, ref index, 10));
                }
            }
            // Read list item count
            ushort count_aoAyozv3DcSx;
                    ulong vuread_aij6mTWXClni = 0;
                    for (int i_hsDMrPlJHoOH = 0; i_hsDMrPlJHoOH < 9; i_hsDMrPlJHoOH++) {
                        byte b = bytes[index++];
                        if (i_hsDMrPlJHoOH < 8) {
                            vuread_aij6mTWXClni += (((ulong)b & (ulong)127) << (7 * i_hsDMrPlJHoOH));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_aij6mTWXClni += (ulong)b << (7 * i_hsDMrPlJHoOH);
                            break;
                        }
                    }
                    count_aoAyozv3DcSx = (ushort)vuread_aij6mTWXClni;
            // Read list items
            if (count_aoAyozv3DcSx > 0) {
                thingThingMapValues = new List<Thing>();
                for (int li_cjEYBWAtcQMc = 0; li_cjEYBWAtcQMc < count_aoAyozv3DcSx; li_cjEYBWAtcQMc++) {
                    thingThingMapValues.Add((Thing)Energize(bytes, ref index, 10));
                }
            }
                o.ThingThingMap = new Dictionary<Thing,Thing>(thingThingMapKeys.Count);
                for (int i_rAkhTDV0bsg6 = 0; i_rAkhTDV0bsg6 < thingThingMapKeys.Count; i_rAkhTDV0bsg6++) {
                    o.ThingThingMap[thingThingMapKeys[i_rAkhTDV0bsg6]] = thingThingMapValues[i_rAkhTDV0bsg6];
                }
                    return o;
                }
            case 15:
                {
                EnumIntMapObject o = new EnumIntMapObject();
                // MAP: EnumIntMap
                IList<MyEnum> enumIntMapKeys = new List<MyEnum>();
                IList<int> enumIntMapValues = new List<int>();
            // Read list item count
            ushort count_yTLX0j0VEM0c;
                    ulong vuread_g8vPV3fLPB50 = 0;
                    for (int i_ne0dCXFYdI2S = 0; i_ne0dCXFYdI2S < 9; i_ne0dCXFYdI2S++) {
                        byte b = bytes[index++];
                        if (i_ne0dCXFYdI2S < 8) {
                            vuread_g8vPV3fLPB50 += (((ulong)b & (ulong)127) << (7 * i_ne0dCXFYdI2S));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_g8vPV3fLPB50 += (ulong)b << (7 * i_ne0dCXFYdI2S);
                            break;
                        }
                    }
                    count_yTLX0j0VEM0c = (ushort)vuread_g8vPV3fLPB50;
            // Read list items
            if (count_yTLX0j0VEM0c > 0) {
                enumIntMapKeys = new List<MyEnum>();
                for (int i_eMC301IdKi2V = 0; i_eMC301IdKi2V < count_yTLX0j0VEM0c; i_eMC301IdKi2V++) {
                    enumIntMapKeys.Add((MyEnum)System.Enum.Parse(typeof(MyEnum), enumIndexValueMap["MyEnum"][bytes[index++]]));
                }
            }
            // Read list item count
            ushort count_dgehmFqEXVsW;
                    ulong vuread_iWsQgc9QgMEi = 0;
                    for (int i_lmVY21qwle6w = 0; i_lmVY21qwle6w < 9; i_lmVY21qwle6w++) {
                        byte b = bytes[index++];
                        if (i_lmVY21qwle6w < 8) {
                            vuread_iWsQgc9QgMEi += (((ulong)b & (ulong)127) << (7 * i_lmVY21qwle6w));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_iWsQgc9QgMEi += (ulong)b << (7 * i_lmVY21qwle6w);
                            break;
                        }
                    }
                    count_dgehmFqEXVsW = (ushort)vuread_iWsQgc9QgMEi;
            // Read list items
            if (count_dgehmFqEXVsW > 0) {
                enumIntMapValues = new List<int>();
                int listValue_syLIrx5zuQKd;
                for (int i_o17IjmPEL6Q9 = 0; i_o17IjmPEL6Q9 < count_dgehmFqEXVsW; i_o17IjmPEL6Q9++) {
                    // Read Int list item
                listValue_syLIrx5zuQKd =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    enumIntMapValues.Add(listValue_syLIrx5zuQKd);
                }
            }
                o.EnumIntMap = new Dictionary<MyEnum,int>(enumIntMapKeys.Count);
                for (int i_tCL5E5Lo067S = 0; i_tCL5E5Lo067S < enumIntMapKeys.Count; i_tCL5E5Lo067S++) {
                    o.EnumIntMap[enumIntMapKeys[i_tCL5E5Lo067S]] = enumIntMapValues[i_tCL5E5Lo067S];
                }
                    return o;
                }
            case 16:
                {
                VIntVLongMapObject o = new VIntVLongMapObject();
                // MAP: VintVlongMap
                IList<int> vintVlongMapKeys = new List<int>();
                IList<long> vintVlongMapValues = new List<long>();
            // Read list item count
            ushort count_lBySRfYVMRpb;
                    ulong vuread_xSn8zBUWSMYZ = 0;
                    for (int i_u95zevnL4oiR = 0; i_u95zevnL4oiR < 9; i_u95zevnL4oiR++) {
                        byte b = bytes[index++];
                        if (i_u95zevnL4oiR < 8) {
                            vuread_xSn8zBUWSMYZ += (((ulong)b & (ulong)127) << (7 * i_u95zevnL4oiR));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_xSn8zBUWSMYZ += (ulong)b << (7 * i_u95zevnL4oiR);
                            break;
                        }
                    }
                    count_lBySRfYVMRpb = (ushort)vuread_xSn8zBUWSMYZ;
            // Read list items
            if (count_lBySRfYVMRpb > 0) {
                vintVlongMapKeys = new List<int>();
                int listValue_v6XGi5xcmKbW;
                for (int i_sMYzlkaYMI6R = 0; i_sMYzlkaYMI6R < count_lBySRfYVMRpb; i_sMYzlkaYMI6R++) {
                    // Read VInt list item
    byte rvint_b_ezQqDNgQJFkC = bytes[index++];
    byte rvint_sign_qoOWoWMl8iRC = (byte)(rvint_b_ezQqDNgQJFkC & 1);
    byte rvint_size_nYATotfpagwS = (byte)(rvint_b_ezQqDNgQJFkC >> 1);
    ulong rvint_remaining_ggIIEvmlCwV7 = 0;
    for (int i_nnJ05VSbRnUP = 0; i_nnJ05VSbRnUP < rvint_size_nYATotfpagwS - 1; i_nnJ05VSbRnUP++) {
        rvint_remaining_ggIIEvmlCwV7 = rvint_remaining_ggIIEvmlCwV7 | (((ulong)bytes[index++] << (8 * i_nnJ05VSbRnUP)));
    }
    int rvint_result_fwBpA4CG15Hi = (int)rvint_remaining_ggIIEvmlCwV7;
    rvint_result_fwBpA4CG15Hi = ~rvint_result_fwBpA4CG15Hi;
    if (rvint_result_fwBpA4CG15Hi == int.MaxValue) {
        rvint_result_fwBpA4CG15Hi = int.MinValue;
    }
    else {
        // Add offset
        rvint_result_fwBpA4CG15Hi += 1;
        if (rvint_sign_qoOWoWMl8iRC == 0) {
            rvint_result_fwBpA4CG15Hi = -rvint_result_fwBpA4CG15Hi;
        }
    }
    listValue_v6XGi5xcmKbW = rvint_result_fwBpA4CG15Hi;
                    vintVlongMapKeys.Add(listValue_v6XGi5xcmKbW);
                }
            }
            // Read list item count
            ushort count_feRN5FakcDoa;
                    ulong vuread_touoyubbw3vh = 0;
                    for (int i_x6VH3pfJPAN1 = 0; i_x6VH3pfJPAN1 < 9; i_x6VH3pfJPAN1++) {
                        byte b = bytes[index++];
                        if (i_x6VH3pfJPAN1 < 8) {
                            vuread_touoyubbw3vh += (((ulong)b & (ulong)127) << (7 * i_x6VH3pfJPAN1));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_touoyubbw3vh += (ulong)b << (7 * i_x6VH3pfJPAN1);
                            break;
                        }
                    }
                    count_feRN5FakcDoa = (ushort)vuread_touoyubbw3vh;
            // Read list items
            if (count_feRN5FakcDoa > 0) {
                vintVlongMapValues = new List<long>();
                long listValue_befmnJMTiBFm;
                for (int i_pniG4GWuTJU8 = 0; i_pniG4GWuTJU8 < count_feRN5FakcDoa; i_pniG4GWuTJU8++) {
                    // Read VLong list item
    byte rvlong_b_tCrXyOutLCkt = bytes[index++];
    byte rvlong_sign_gYXWqL9BBI6P = (byte)(rvlong_b_tCrXyOutLCkt & 1);
    byte rvlong_size_cIOjOsiEuhBV = (byte)(rvlong_b_tCrXyOutLCkt >> 1);
    ulong rvlong_remaining_hYvDhlLhdZsf = 0;
    for (int i_s9eiKtHlFLRZ = 0; i_s9eiKtHlFLRZ < rvlong_size_cIOjOsiEuhBV - 1; i_s9eiKtHlFLRZ++) {
        rvlong_remaining_hYvDhlLhdZsf = rvlong_remaining_hYvDhlLhdZsf | (((ulong)bytes[index++] << (8 * i_s9eiKtHlFLRZ)));
    }
    long rvlong_result_zlPsuP9hxcEB = (long)rvlong_remaining_hYvDhlLhdZsf;
    rvlong_result_zlPsuP9hxcEB = ~rvlong_result_zlPsuP9hxcEB;
    if (rvlong_result_zlPsuP9hxcEB == long.MaxValue) {
        rvlong_result_zlPsuP9hxcEB = long.MinValue;
    }
    else {
        // Add offset
        rvlong_result_zlPsuP9hxcEB += 1;
        if (rvlong_sign_gYXWqL9BBI6P == 0) {
            rvlong_result_zlPsuP9hxcEB = -rvlong_result_zlPsuP9hxcEB;
        }
    }
    listValue_befmnJMTiBFm = rvlong_result_zlPsuP9hxcEB;
                    vintVlongMapValues.Add(listValue_befmnJMTiBFm);
                }
            }
                o.VintVlongMap = new Dictionary<int,long>(vintVlongMapKeys.Count);
                for (int i_gFuq7ZMrqIAP = 0; i_gFuq7ZMrqIAP < vintVlongMapKeys.Count; i_gFuq7ZMrqIAP++) {
                    o.VintVlongMap[vintVlongMapKeys[i_gFuq7ZMrqIAP]] = vintVlongMapValues[i_gFuq7ZMrqIAP];
                }
                    return o;
                }
                default:
                    throw new MapTestPatternBufferException("Unrecognized type ID: "+typeId+" ");
            }
        }
///////////////////////////////////////
// FROM BYTES (TYPED)
///////////////////////////////////////
        public TYPE Energize< TYPE > (byte[] bytes) {
            object o = this.Energize(bytes);
            if (!(o is TYPE)) {
                throw new MapTestPatternBufferException("Deserialized type (" + o.GetType().Name + ") does not match expected type (" + typeof(TYPE).Name + ").");
            }
            return (TYPE)o;
        }
    }
}
