
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
        private IMapTestInstantiator instantiator;
        public MapTestPatternBuffer() : this(4096, new DefaultMapTestInstantiator()) { }
        public MapTestPatternBuffer(uint bufferSize) : this (bufferSize, new DefaultMapTestInstantiator()) { }
        public MapTestPatternBuffer(IMapTestInstantiator instantiator) : this (4096, instantiator) { }
        public MapTestPatternBuffer(uint bufferSize, IMapTestInstantiator instantiator) {
            this.bytes = new byte[bufferSize];
            this.instantiator = instantiator;
        }
///////////////////////////////////////
// TO BYTES
///////////////////////////////////////
        public byte[] Energize(Thing o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(IntThingMapObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(ThingIntMapObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(IntStringMapObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(ThingThingMapObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(EnumIntMapObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(VIntVLongMapObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(IntAbstractThingMapObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public void Energize(Thing o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 10;
            }
                // PRIMITIVE: IsSomething
                bytes[index++] = o.IsSomething ? (byte)1 : (byte)0;
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
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                bytes[index++] = 0;
                nullFlagsIndex++;
                // MAP: IntThingMap
                if (o.IntThingMap != null) {
                    bytes[nullFlagsIndex] |= (byte)(128);
            if (o.IntThingMap == null || o.IntThingMap.Keys == null || o.IntThingMap.Keys.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.IntThingMap.Keys.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.IntThingMap.Keys.Count;
                int i_cpvuiAwr7Ftm;
                for (i_cpvuiAwr7Ftm = 0; i_cpvuiAwr7Ftm < 2; i_cpvuiAwr7Ftm++) {
                    if ((ulong)o.IntThingMap.Keys.Count < vuBoundaries[i_cpvuiAwr7Ftm]) {
                       byteCount = (int)(i_cpvuiAwr7Ftm + 1);
                       goto guvsgoto_byAXLlLUzixE;
                    }
                }
                byteCount = (int)i_cpvuiAwr7Ftm + 1;
                guvsgoto_byAXLlLUzixE:
                    for (int i_oiSXGd10GRqP = 0; i_oiSXGd10GRqP < byteCount; i_oiSXGd10GRqP++) {
                        if (i_oiSXGd10GRqP < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_oiSXGd10GRqP < byteCount - 1) {
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
            if (o.IntThingMap == null || o.IntThingMap.Values == null || o.IntThingMap.Values.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.IntThingMap.Values.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.IntThingMap.Values.Count;
                int i_zC7LbQBGfooD;
                for (i_zC7LbQBGfooD = 0; i_zC7LbQBGfooD < 2; i_zC7LbQBGfooD++) {
                    if ((ulong)o.IntThingMap.Values.Count < vuBoundaries[i_zC7LbQBGfooD]) {
                       byteCount = (int)(i_zC7LbQBGfooD + 1);
                       goto guvsgoto_irAqJrbpInea;
                    }
                }
                byteCount = (int)i_zC7LbQBGfooD + 1;
                guvsgoto_irAqJrbpInea:
                    for (int i_lXowqH7z8Qa1 = 0; i_lXowqH7z8Qa1 < byteCount; i_lXowqH7z8Qa1++) {
                        if (i_lXowqH7z8Qa1 < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_lXowqH7z8Qa1 < byteCount - 1) {
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
        }
        public void Energize(ThingIntMapObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 12;
            }
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                bytes[index++] = 0;
                nullFlagsIndex++;
                // MAP: ThingIntMap
                if (o.ThingIntMap != null) {
                    bytes[nullFlagsIndex] |= (byte)(128);
            if (o.ThingIntMap == null || o.ThingIntMap.Keys == null || o.ThingIntMap.Keys.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.ThingIntMap.Keys.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.ThingIntMap.Keys.Count;
                int i_cpY0qUKfd7YV;
                for (i_cpY0qUKfd7YV = 0; i_cpY0qUKfd7YV < 2; i_cpY0qUKfd7YV++) {
                    if ((ulong)o.ThingIntMap.Keys.Count < vuBoundaries[i_cpY0qUKfd7YV]) {
                       byteCount = (int)(i_cpY0qUKfd7YV + 1);
                       goto guvsgoto_zgSQEeNvdSZd;
                    }
                }
                byteCount = (int)i_cpY0qUKfd7YV + 1;
                guvsgoto_zgSQEeNvdSZd:
                    for (int i_bP8apPbrBgM5 = 0; i_bP8apPbrBgM5 < byteCount; i_bP8apPbrBgM5++) {
                        if (i_bP8apPbrBgM5 < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_bP8apPbrBgM5 < byteCount - 1) {
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
            if (o.ThingIntMap == null || o.ThingIntMap.Values == null || o.ThingIntMap.Values.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.ThingIntMap.Values.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.ThingIntMap.Values.Count;
                int i_shiof5Xcr6NZ;
                for (i_shiof5Xcr6NZ = 0; i_shiof5Xcr6NZ < 2; i_shiof5Xcr6NZ++) {
                    if ((ulong)o.ThingIntMap.Values.Count < vuBoundaries[i_shiof5Xcr6NZ]) {
                       byteCount = (int)(i_shiof5Xcr6NZ + 1);
                       goto guvsgoto_zUcaK2zT7kqb;
                    }
                }
                byteCount = (int)i_shiof5Xcr6NZ + 1;
                guvsgoto_zUcaK2zT7kqb:
                    for (int i_cMfxQIL8N32F = 0; i_cMfxQIL8N32F < byteCount; i_cMfxQIL8N32F++) {
                        if (i_cMfxQIL8N32F < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_cMfxQIL8N32F < byteCount - 1) {
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
        }
        public void Energize(IntStringMapObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 13;
            }
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                bytes[index++] = 0;
                nullFlagsIndex++;
                // MAP: IntStringMap
                if (o.IntStringMap != null) {
                    bytes[nullFlagsIndex] |= (byte)(128);
            if (o.IntStringMap == null || o.IntStringMap.Keys == null || o.IntStringMap.Keys.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.IntStringMap.Keys.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.IntStringMap.Keys.Count;
                int i_nWlGtJNbhn58;
                for (i_nWlGtJNbhn58 = 0; i_nWlGtJNbhn58 < 2; i_nWlGtJNbhn58++) {
                    if ((ulong)o.IntStringMap.Keys.Count < vuBoundaries[i_nWlGtJNbhn58]) {
                       byteCount = (int)(i_nWlGtJNbhn58 + 1);
                       goto guvsgoto_sJElHeX2y7si;
                    }
                }
                byteCount = (int)i_nWlGtJNbhn58 + 1;
                guvsgoto_sJElHeX2y7si:
                    for (int i_ubdzIrxZoNHG = 0; i_ubdzIrxZoNHG < byteCount; i_ubdzIrxZoNHG++) {
                        if (i_ubdzIrxZoNHG < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_ubdzIrxZoNHG < byteCount - 1) {
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
            if (o.IntStringMap == null || o.IntStringMap.Values == null || o.IntStringMap.Values.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.IntStringMap.Values.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.IntStringMap.Values.Count;
                int i_jfPdp1yEOGyF;
                for (i_jfPdp1yEOGyF = 0; i_jfPdp1yEOGyF < 2; i_jfPdp1yEOGyF++) {
                    if ((ulong)o.IntStringMap.Values.Count < vuBoundaries[i_jfPdp1yEOGyF]) {
                       byteCount = (int)(i_jfPdp1yEOGyF + 1);
                       goto guvsgoto_lMEmiUAiu614;
                    }
                }
                byteCount = (int)i_jfPdp1yEOGyF + 1;
                guvsgoto_lMEmiUAiu614:
                    for (int i_ayugKC43pPfR = 0; i_ayugKC43pPfR < byteCount; i_ayugKC43pPfR++) {
                        if (i_ayugKC43pPfR < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_ayugKC43pPfR < byteCount - 1) {
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
                uint stringLength_cA2wWWO0kicD;
                int i_luI1c7ORa88Y;
                for (i_luI1c7ORa88Y = 0; i_luI1c7ORa88Y < 2; i_luI1c7ORa88Y++) {
                    if ((ulong)primitive.Length < vuBoundaries[i_luI1c7ORa88Y]) {
                       stringLength_cA2wWWO0kicD = (uint)(i_luI1c7ORa88Y + 1);
                       goto guvsgoto_qtJwoc15o8lU;
                    }
                }
                stringLength_cA2wWWO0kicD = (uint)i_luI1c7ORa88Y + 1;
                guvsgoto_qtJwoc15o8lU:
                if (primitive.Length == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    ulong value = (ulong)primitive.Length;
                    for (int i_zcS11Hv2v1Eq = 0; i_zcS11Hv2v1Eq < stringLength_cA2wWWO0kicD; i_zcS11Hv2v1Eq++) {
                        if (i_zcS11Hv2v1Eq < stringLength_cA2wWWO0kicD - 1) {
                            byte b = (byte)(value & 127);
                            if (i_zcS11Hv2v1Eq < stringLength_cA2wWWO0kicD - 1) {
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
        }
        public void Energize(ThingThingMapObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 14;
            }
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                bytes[index++] = 0;
                nullFlagsIndex++;
                // MAP: ThingThingMap
                if (o.ThingThingMap != null) {
                    bytes[nullFlagsIndex] |= (byte)(128);
            if (o.ThingThingMap == null || o.ThingThingMap.Keys == null || o.ThingThingMap.Keys.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.ThingThingMap.Keys.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.ThingThingMap.Keys.Count;
                int i_fWYmEvCOvUyl;
                for (i_fWYmEvCOvUyl = 0; i_fWYmEvCOvUyl < 2; i_fWYmEvCOvUyl++) {
                    if ((ulong)o.ThingThingMap.Keys.Count < vuBoundaries[i_fWYmEvCOvUyl]) {
                       byteCount = (int)(i_fWYmEvCOvUyl + 1);
                       goto guvsgoto_xHPnXkChpi5B;
                    }
                }
                byteCount = (int)i_fWYmEvCOvUyl + 1;
                guvsgoto_xHPnXkChpi5B:
                    for (int i_i9dQMsyJ0r7E = 0; i_i9dQMsyJ0r7E < byteCount; i_i9dQMsyJ0r7E++) {
                        if (i_i9dQMsyJ0r7E < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_i9dQMsyJ0r7E < byteCount - 1) {
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
            if (o.ThingThingMap == null || o.ThingThingMap.Values == null || o.ThingThingMap.Values.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.ThingThingMap.Values.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.ThingThingMap.Values.Count;
                int i_tjyayZ5ijD3X;
                for (i_tjyayZ5ijD3X = 0; i_tjyayZ5ijD3X < 2; i_tjyayZ5ijD3X++) {
                    if ((ulong)o.ThingThingMap.Values.Count < vuBoundaries[i_tjyayZ5ijD3X]) {
                       byteCount = (int)(i_tjyayZ5ijD3X + 1);
                       goto guvsgoto_hB4ZF1J0hqNf;
                    }
                }
                byteCount = (int)i_tjyayZ5ijD3X + 1;
                guvsgoto_hB4ZF1J0hqNf:
                    for (int i_dWE6TvL6Yt3c = 0; i_dWE6TvL6Yt3c < byteCount; i_dWE6TvL6Yt3c++) {
                        if (i_dWE6TvL6Yt3c < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_dWE6TvL6Yt3c < byteCount - 1) {
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
        }
        public void Energize(EnumIntMapObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 15;
            }
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                bytes[index++] = 0;
                nullFlagsIndex++;
                // MAP: EnumIntMap
                if (o.EnumIntMap != null) {
                    bytes[nullFlagsIndex] |= (byte)(128);
            if (o.EnumIntMap == null || o.EnumIntMap.Keys == null || o.EnumIntMap.Keys.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.EnumIntMap.Keys.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.EnumIntMap.Keys.Count;
                int i_xylavZvZIhST;
                for (i_xylavZvZIhST = 0; i_xylavZvZIhST < 2; i_xylavZvZIhST++) {
                    if ((ulong)o.EnumIntMap.Keys.Count < vuBoundaries[i_xylavZvZIhST]) {
                       byteCount = (int)(i_xylavZvZIhST + 1);
                       goto guvsgoto_lNiDlHedw76D;
                    }
                }
                byteCount = (int)i_xylavZvZIhST + 1;
                guvsgoto_lNiDlHedw76D:
                    for (int i_jNgVOQqApvJV = 0; i_jNgVOQqApvJV < byteCount; i_jNgVOQqApvJV++) {
                        if (i_jNgVOQqApvJV < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_jNgVOQqApvJV < byteCount - 1) {
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
            if (o.EnumIntMap == null || o.EnumIntMap.Values == null || o.EnumIntMap.Values.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.EnumIntMap.Values.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.EnumIntMap.Values.Count;
                int i_eLL97eEt4zgH;
                for (i_eLL97eEt4zgH = 0; i_eLL97eEt4zgH < 2; i_eLL97eEt4zgH++) {
                    if ((ulong)o.EnumIntMap.Values.Count < vuBoundaries[i_eLL97eEt4zgH]) {
                       byteCount = (int)(i_eLL97eEt4zgH + 1);
                       goto guvsgoto_sB7LzZBjZabv;
                    }
                }
                byteCount = (int)i_eLL97eEt4zgH + 1;
                guvsgoto_sB7LzZBjZabv:
                    for (int i_lsyPRGoJYAt3 = 0; i_lsyPRGoJYAt3 < byteCount; i_lsyPRGoJYAt3++) {
                        if (i_lsyPRGoJYAt3 < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_lsyPRGoJYAt3 < byteCount - 1) {
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
        }
        public void Energize(VIntVLongMapObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 16;
            }
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                bytes[index++] = 0;
                nullFlagsIndex++;
                // MAP: VintVlongMap
                if (o.VintVlongMap != null) {
                    bytes[nullFlagsIndex] |= (byte)(128);
            if (o.VintVlongMap == null || o.VintVlongMap.Keys == null || o.VintVlongMap.Keys.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.VintVlongMap.Keys.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.VintVlongMap.Keys.Count;
                int i_cqCk0q0rvzjh;
                for (i_cqCk0q0rvzjh = 0; i_cqCk0q0rvzjh < 2; i_cqCk0q0rvzjh++) {
                    if ((ulong)o.VintVlongMap.Keys.Count < vuBoundaries[i_cqCk0q0rvzjh]) {
                       byteCount = (int)(i_cqCk0q0rvzjh + 1);
                       goto guvsgoto_wUzSQJ3wLULd;
                    }
                }
                byteCount = (int)i_cqCk0q0rvzjh + 1;
                guvsgoto_wUzSQJ3wLULd:
                    for (int i_lVCtVBHTsRin = 0; i_lVCtVBHTsRin < byteCount; i_lVCtVBHTsRin++) {
                        if (i_lVCtVBHTsRin < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_lVCtVBHTsRin < byteCount - 1) {
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
    long s2ultemp_rWNvGU6QQuJA = primitive;
    if (s2ultemp_rWNvGU6QQuJA == long.MinValue) {
        s2ultemp_rWNvGU6QQuJA = long.MaxValue;
    }
    else {
        if (s2ultemp_rWNvGU6QQuJA > 0) {
            s2ultemp_rWNvGU6QQuJA = -s2ultemp_rWNvGU6QQuJA;
        }
        s2ultemp_rWNvGU6QQuJA -= 1;
    }
    s2ultemp_rWNvGU6QQuJA = ~s2ultemp_rWNvGU6QQuJA;
    ulong s2ulresult_bdTIJbIBKsq4 = (ulong)s2ultemp_rWNvGU6QQuJA;
    //// AppendGetSignVariantSize(s2ulresult_bdTIJbIBKsq4)
    byte vr_cJKjn2VyipGd = 1;
    for (int v_qFVKDDAhmbqS = 56; v_qFVKDDAhmbqS >= 0; v_qFVKDDAhmbqS -= 8) {
        if (((255UL << v_qFVKDDAhmbqS) & s2ulresult_bdTIJbIBKsq4) > 0) {
            vr_cJKjn2VyipGd = (byte)(v_qFVKDDAhmbqS / 8 + 2);
            break;
        }
    }
    bytes[index++] = (byte)((byte)(vr_cJKjn2VyipGd << 1) | (byte)(primitive > 0 ? 0 : 1));
    for (int vi_s9jqiQMwFTo6 = 0; vi_s9jqiQMwFTo6 < vr_cJKjn2VyipGd - 1; vi_s9jqiQMwFTo6++) {
        bytes[index++] = (byte)(s2ulresult_bdTIJbIBKsq4 & 255);
        s2ulresult_bdTIJbIBKsq4 = s2ulresult_bdTIJbIBKsq4 >> 8;
    }
                }
            }
            if (o.VintVlongMap == null || o.VintVlongMap.Values == null || o.VintVlongMap.Values.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.VintVlongMap.Values.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.VintVlongMap.Values.Count;
                int i_g88g1jSft2Bo;
                for (i_g88g1jSft2Bo = 0; i_g88g1jSft2Bo < 2; i_g88g1jSft2Bo++) {
                    if ((ulong)o.VintVlongMap.Values.Count < vuBoundaries[i_g88g1jSft2Bo]) {
                       byteCount = (int)(i_g88g1jSft2Bo + 1);
                       goto guvsgoto_eWCYJlrXHP5e;
                    }
                }
                byteCount = (int)i_g88g1jSft2Bo + 1;
                guvsgoto_eWCYJlrXHP5e:
                    for (int i_sEpCNjH2qZAQ = 0; i_sEpCNjH2qZAQ < byteCount; i_sEpCNjH2qZAQ++) {
                        if (i_sEpCNjH2qZAQ < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_sEpCNjH2qZAQ < byteCount - 1) {
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
    long s2ultemp_aMHbTCkddfbk = primitive;
    if (s2ultemp_aMHbTCkddfbk == long.MinValue) {
        s2ultemp_aMHbTCkddfbk = long.MaxValue;
    }
    else {
        if (s2ultemp_aMHbTCkddfbk > 0) {
            s2ultemp_aMHbTCkddfbk = -s2ultemp_aMHbTCkddfbk;
        }
        s2ultemp_aMHbTCkddfbk -= 1;
    }
    s2ultemp_aMHbTCkddfbk = ~s2ultemp_aMHbTCkddfbk;
    ulong s2ulresult_sFEwbjNrvnfe = (ulong)s2ultemp_aMHbTCkddfbk;
    //// AppendGetSignVariantSize(s2ulresult_sFEwbjNrvnfe)
    byte vr_xZkxhcXAHrgp = 1;
    for (int v_pRv0SylNDfTh = 56; v_pRv0SylNDfTh >= 0; v_pRv0SylNDfTh -= 8) {
        if (((255UL << v_pRv0SylNDfTh) & s2ulresult_sFEwbjNrvnfe) > 0) {
            vr_xZkxhcXAHrgp = (byte)(v_pRv0SylNDfTh / 8 + 2);
            break;
        }
    }
    bytes[index++] = (byte)((byte)(vr_xZkxhcXAHrgp << 1) | (byte)(primitive > 0 ? 0 : 1));
    for (int vi_rl1hmjvXHCf4 = 0; vi_rl1hmjvXHCf4 < vr_xZkxhcXAHrgp - 1; vi_rl1hmjvXHCf4++) {
        bytes[index++] = (byte)(s2ulresult_sFEwbjNrvnfe & 255);
        s2ulresult_sFEwbjNrvnfe = s2ulresult_sFEwbjNrvnfe >> 8;
    }
                }
            }
                }
        }
        public void Energize(IntAbstractThingMapObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 17;
            }
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                bytes[index++] = 0;
                nullFlagsIndex++;
                // MAP: IntAbstractThingMap
                if (o.IntAbstractThingMap != null) {
                    bytes[nullFlagsIndex] |= (byte)(128);
            if (o.IntAbstractThingMap == null || o.IntAbstractThingMap.Keys == null || o.IntAbstractThingMap.Keys.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.IntAbstractThingMap.Keys.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.IntAbstractThingMap.Keys.Count;
                int i_uWJ7cBLZgcS6;
                for (i_uWJ7cBLZgcS6 = 0; i_uWJ7cBLZgcS6 < 2; i_uWJ7cBLZgcS6++) {
                    if ((ulong)o.IntAbstractThingMap.Keys.Count < vuBoundaries[i_uWJ7cBLZgcS6]) {
                       byteCount = (int)(i_uWJ7cBLZgcS6 + 1);
                       goto guvsgoto_hW5arKNAzoUu;
                    }
                }
                byteCount = (int)i_uWJ7cBLZgcS6 + 1;
                guvsgoto_hW5arKNAzoUu:
                    for (int i_eQoy6tRiLBH5 = 0; i_eQoy6tRiLBH5 < byteCount; i_eQoy6tRiLBH5++) {
                        if (i_eQoy6tRiLBH5 < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_eQoy6tRiLBH5 < byteCount - 1) {
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
                foreach (int primitive in o.IntAbstractThingMap.Keys) {
                bytes[index++] = (byte)((primitive >> 24) & 255);
                bytes[index++] = (byte)((primitive >> 16) & 255);
                bytes[index++] = (byte)((primitive >> 8) & 255);
                bytes[index++] = (byte)(primitive & 255);
                }
            }
            if (o.IntAbstractThingMap == null || o.IntAbstractThingMap.Values == null || o.IntAbstractThingMap.Values.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.IntAbstractThingMap.Values.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.IntAbstractThingMap.Values.Count;
                int i_pxUf1qXqe8YK;
                for (i_pxUf1qXqe8YK = 0; i_pxUf1qXqe8YK < 2; i_pxUf1qXqe8YK++) {
                    if ((ulong)o.IntAbstractThingMap.Values.Count < vuBoundaries[i_pxUf1qXqe8YK]) {
                       byteCount = (int)(i_pxUf1qXqe8YK + 1);
                       goto guvsgoto_mlw2CtRAAHtz;
                    }
                }
                byteCount = (int)i_pxUf1qXqe8YK + 1;
                guvsgoto_mlw2CtRAAHtz:
                    for (int i_jpDgHLTwoOE0 = 0; i_jpDgHLTwoOE0 < byteCount; i_jpDgHLTwoOE0++) {
                        if (i_jpDgHLTwoOE0 < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_jpDgHLTwoOE0 < byteCount - 1) {
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
                foreach (IMapTestObject abstractObject in o.IntAbstractThingMap.Values) {
                    Energize((IMapTestObject)abstractObject, bytes, ref index, true);
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
                case 17:
                    Energize((IntAbstractThingMapObject)o, bytes, ref index, writeTypeId);
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
                    ulong vuread_cTxWurFNwYYJ = 0;
                    for (int i_oMruNr0DwVFn = 0; i_oMruNr0DwVFn < 9; i_oMruNr0DwVFn++) {
                        byte b = bytes[index++];
                        if (i_oMruNr0DwVFn < 8) {
                            vuread_cTxWurFNwYYJ += (((ulong)b & (ulong)127) << (7 * i_oMruNr0DwVFn));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_cTxWurFNwYYJ += (ulong)b << (7 * i_oMruNr0DwVFn);
                            break;
                        }
                    }
                    ushort typeId = (ushort)vuread_cTxWurFNwYYJ;
            switch (typeId) {
            case 10:
                {
                Thing o = this.instantiator.AcquireThing();
                // PRIMITIVE: IsSomething
                o.IsSomething = bytes[index++] == 1;
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
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                IntThingMapObject o = this.instantiator.AcquireIntThingMapObject();
                nullFlagsIndex++;
                // MAP: IntThingMap
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
                    List<int> intThingMapKeys = this.instantiator.AcquireListOfInt();
                    List<Thing> intThingMapValues = this.instantiator.AcquireListOfThing();
            // Read list item count
            ushort count_vL3YY7k523ah;
                    ulong vuread_wa5XDloHA4I5 = 0;
                    for (int i_iyT7XaEtnk7T = 0; i_iyT7XaEtnk7T < 9; i_iyT7XaEtnk7T++) {
                        byte b = bytes[index++];
                        if (i_iyT7XaEtnk7T < 8) {
                            vuread_wa5XDloHA4I5 += (((ulong)b & (ulong)127) << (7 * i_iyT7XaEtnk7T));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_wa5XDloHA4I5 += (ulong)b << (7 * i_iyT7XaEtnk7T);
                            break;
                        }
                    }
                    count_vL3YY7k523ah = (ushort)vuread_wa5XDloHA4I5;
            // Read list items
            if (count_vL3YY7k523ah > 0) {
                intThingMapKeys = this.instantiator.AcquireListOfInt();
                int listValue_jQZzO2QOLkCM;
                for (int i_jdalH8W4c8Fz = 0; i_jdalH8W4c8Fz < count_vL3YY7k523ah; i_jdalH8W4c8Fz++) {
                    // Read Int list item
                listValue_jQZzO2QOLkCM =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    intThingMapKeys.Add(listValue_jQZzO2QOLkCM);
                }
            }
            // Read list item count
            ushort count_fni1zR3SdlzW;
                    ulong vuread_jY3Io3tj6gLT = 0;
                    for (int i_atVpxdQzlzlA = 0; i_atVpxdQzlzlA < 9; i_atVpxdQzlzlA++) {
                        byte b = bytes[index++];
                        if (i_atVpxdQzlzlA < 8) {
                            vuread_jY3Io3tj6gLT += (((ulong)b & (ulong)127) << (7 * i_atVpxdQzlzlA));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_jY3Io3tj6gLT += (ulong)b << (7 * i_atVpxdQzlzlA);
                            break;
                        }
                    }
                    count_fni1zR3SdlzW = (ushort)vuread_jY3Io3tj6gLT;
            // Read list items
            if (count_fni1zR3SdlzW > 0) {
                intThingMapValues = this.instantiator.AcquireListOfThing();
                for (int li_tYp4qTJkNoZT = 0; li_tYp4qTJkNoZT < count_fni1zR3SdlzW; li_tYp4qTJkNoZT++) {
                    intThingMapValues.Add((Thing)Energize(bytes, ref index, 10));
                }
            }
                    o.IntThingMap = this.instantiator.AcquireDictionaryOfIntToThing();
                    for (int i_boPjPvDgMz1g = 0; i_boPjPvDgMz1g < intThingMapKeys.Count; i_boPjPvDgMz1g++) {
                        o.IntThingMap[intThingMapKeys[i_boPjPvDgMz1g]] = intThingMapValues[i_boPjPvDgMz1g];
                    }
                    this.instantiator.DiscardListOfInt(intThingMapKeys);
                    this.instantiator.DiscardListOfThing(intThingMapValues);
                    intThingMapKeys = null;
                    intThingMapValues = null;
                }
                    return o;
                }
            case 12:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                ThingIntMapObject o = this.instantiator.AcquireThingIntMapObject();
                nullFlagsIndex++;
                // MAP: ThingIntMap
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
                    List<Thing> thingIntMapKeys = this.instantiator.AcquireListOfThing();
                    List<int> thingIntMapValues = this.instantiator.AcquireListOfInt();
            // Read list item count
            ushort count_xOu9FaK6MCYA;
                    ulong vuread_qy2mHAfWDckj = 0;
                    for (int i_jHTZ6eYu6j9M = 0; i_jHTZ6eYu6j9M < 9; i_jHTZ6eYu6j9M++) {
                        byte b = bytes[index++];
                        if (i_jHTZ6eYu6j9M < 8) {
                            vuread_qy2mHAfWDckj += (((ulong)b & (ulong)127) << (7 * i_jHTZ6eYu6j9M));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_qy2mHAfWDckj += (ulong)b << (7 * i_jHTZ6eYu6j9M);
                            break;
                        }
                    }
                    count_xOu9FaK6MCYA = (ushort)vuread_qy2mHAfWDckj;
            // Read list items
            if (count_xOu9FaK6MCYA > 0) {
                thingIntMapKeys = this.instantiator.AcquireListOfThing();
                for (int li_kJPNN3gMzpEq = 0; li_kJPNN3gMzpEq < count_xOu9FaK6MCYA; li_kJPNN3gMzpEq++) {
                    thingIntMapKeys.Add((Thing)Energize(bytes, ref index, 10));
                }
            }
            // Read list item count
            ushort count_mqJltfM2DkM7;
                    ulong vuread_hU9HNEDFzqX8 = 0;
                    for (int i_tCjK6IUicDwP = 0; i_tCjK6IUicDwP < 9; i_tCjK6IUicDwP++) {
                        byte b = bytes[index++];
                        if (i_tCjK6IUicDwP < 8) {
                            vuread_hU9HNEDFzqX8 += (((ulong)b & (ulong)127) << (7 * i_tCjK6IUicDwP));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_hU9HNEDFzqX8 += (ulong)b << (7 * i_tCjK6IUicDwP);
                            break;
                        }
                    }
                    count_mqJltfM2DkM7 = (ushort)vuread_hU9HNEDFzqX8;
            // Read list items
            if (count_mqJltfM2DkM7 > 0) {
                thingIntMapValues = this.instantiator.AcquireListOfInt();
                int listValue_nNa1Ghin7Rw2;
                for (int i_xI85W90mCKA1 = 0; i_xI85W90mCKA1 < count_mqJltfM2DkM7; i_xI85W90mCKA1++) {
                    // Read Int list item
                listValue_nNa1Ghin7Rw2 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    thingIntMapValues.Add(listValue_nNa1Ghin7Rw2);
                }
            }
                    o.ThingIntMap = this.instantiator.AcquireDictionaryOfThingToInt();
                    for (int i_yb54AD5Wyuca = 0; i_yb54AD5Wyuca < thingIntMapKeys.Count; i_yb54AD5Wyuca++) {
                        o.ThingIntMap[thingIntMapKeys[i_yb54AD5Wyuca]] = thingIntMapValues[i_yb54AD5Wyuca];
                    }
                    this.instantiator.DiscardListOfThing(thingIntMapKeys);
                    this.instantiator.DiscardListOfInt(thingIntMapValues);
                    thingIntMapKeys = null;
                    thingIntMapValues = null;
                }
                    return o;
                }
            case 13:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                IntStringMapObject o = this.instantiator.AcquireIntStringMapObject();
                nullFlagsIndex++;
                // MAP: IntStringMap
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
                    List<int> intStringMapKeys = this.instantiator.AcquireListOfInt();
                    List<string> intStringMapValues = this.instantiator.AcquireListOfString();
            // Read list item count
            ushort count_mL8rhJbdfqQx;
                    ulong vuread_pZwcNkm4ni5E = 0;
                    for (int i_eoXDWJEIG8Bk = 0; i_eoXDWJEIG8Bk < 9; i_eoXDWJEIG8Bk++) {
                        byte b = bytes[index++];
                        if (i_eoXDWJEIG8Bk < 8) {
                            vuread_pZwcNkm4ni5E += (((ulong)b & (ulong)127) << (7 * i_eoXDWJEIG8Bk));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_pZwcNkm4ni5E += (ulong)b << (7 * i_eoXDWJEIG8Bk);
                            break;
                        }
                    }
                    count_mL8rhJbdfqQx = (ushort)vuread_pZwcNkm4ni5E;
            // Read list items
            if (count_mL8rhJbdfqQx > 0) {
                intStringMapKeys = this.instantiator.AcquireListOfInt();
                int listValue_aIe2JwVPuHuL;
                for (int i_d2johhWuPDg3 = 0; i_d2johhWuPDg3 < count_mL8rhJbdfqQx; i_d2johhWuPDg3++) {
                    // Read Int list item
                listValue_aIe2JwVPuHuL =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    intStringMapKeys.Add(listValue_aIe2JwVPuHuL);
                }
            }
            // Read list item count
            ushort count_uIrGWi0Mxlbe;
                    ulong vuread_cuv0wqjN3mv3 = 0;
                    for (int i_kqBzlgEHClgb = 0; i_kqBzlgEHClgb < 9; i_kqBzlgEHClgb++) {
                        byte b = bytes[index++];
                        if (i_kqBzlgEHClgb < 8) {
                            vuread_cuv0wqjN3mv3 += (((ulong)b & (ulong)127) << (7 * i_kqBzlgEHClgb));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_cuv0wqjN3mv3 += (ulong)b << (7 * i_kqBzlgEHClgb);
                            break;
                        }
                    }
                    count_uIrGWi0Mxlbe = (ushort)vuread_cuv0wqjN3mv3;
            // Read list items
            if (count_uIrGWi0Mxlbe > 0) {
                intStringMapValues = this.instantiator.AcquireListOfString();
                string listValue_bp2mRSn61fiX;
                for (int i_u57ztC9KmygG = 0; i_u57ztC9KmygG < count_uIrGWi0Mxlbe; i_u57ztC9KmygG++) {
                    // Read String list item
                    ulong vuread_j66l8zbuhNNp = 0;
                    for (int i_dfoalFYQjwGp = 0; i_dfoalFYQjwGp < 9; i_dfoalFYQjwGp++) {
                        byte b = bytes[index++];
                        if (i_dfoalFYQjwGp < 8) {
                            vuread_j66l8zbuhNNp += (((ulong)b & (ulong)127) << (7 * i_dfoalFYQjwGp));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_j66l8zbuhNNp += (ulong)b << (7 * i_dfoalFYQjwGp);
                            break;
                        }
                    }
                    ushort stringLength_rBArRDL4ntWh = (ushort)vuread_j66l8zbuhNNp;
                listValue_bp2mRSn61fiX = Encoding.UTF8.GetString(bytes, index, stringLength_rBArRDL4ntWh);
                index += stringLength_rBArRDL4ntWh;
                    intStringMapValues.Add(listValue_bp2mRSn61fiX);
                }
            }
                    o.IntStringMap = this.instantiator.AcquireDictionaryOfIntToString();
                    for (int i_h5oyEoJCj0bw = 0; i_h5oyEoJCj0bw < intStringMapKeys.Count; i_h5oyEoJCj0bw++) {
                        o.IntStringMap[intStringMapKeys[i_h5oyEoJCj0bw]] = intStringMapValues[i_h5oyEoJCj0bw];
                    }
                    this.instantiator.DiscardListOfInt(intStringMapKeys);
                    this.instantiator.DiscardListOfString(intStringMapValues);
                    intStringMapKeys = null;
                    intStringMapValues = null;
                }
                    return o;
                }
            case 14:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                ThingThingMapObject o = this.instantiator.AcquireThingThingMapObject();
                nullFlagsIndex++;
                // MAP: ThingThingMap
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
                    List<Thing> thingThingMapKeys = this.instantiator.AcquireListOfThing();
                    List<Thing> thingThingMapValues = this.instantiator.AcquireListOfThing();
            // Read list item count
            ushort count_nYLXxWycXkjL;
                    ulong vuread_gLSSFg7bAQ3c = 0;
                    for (int i_eM02elgrd1Fw = 0; i_eM02elgrd1Fw < 9; i_eM02elgrd1Fw++) {
                        byte b = bytes[index++];
                        if (i_eM02elgrd1Fw < 8) {
                            vuread_gLSSFg7bAQ3c += (((ulong)b & (ulong)127) << (7 * i_eM02elgrd1Fw));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_gLSSFg7bAQ3c += (ulong)b << (7 * i_eM02elgrd1Fw);
                            break;
                        }
                    }
                    count_nYLXxWycXkjL = (ushort)vuread_gLSSFg7bAQ3c;
            // Read list items
            if (count_nYLXxWycXkjL > 0) {
                thingThingMapKeys = this.instantiator.AcquireListOfThing();
                for (int li_xasx7DChWNj2 = 0; li_xasx7DChWNj2 < count_nYLXxWycXkjL; li_xasx7DChWNj2++) {
                    thingThingMapKeys.Add((Thing)Energize(bytes, ref index, 10));
                }
            }
            // Read list item count
            ushort count_n16d2a5Y4JNU;
                    ulong vuread_yG8Me1IxgwYF = 0;
                    for (int i_uKd7oWqHD7wn = 0; i_uKd7oWqHD7wn < 9; i_uKd7oWqHD7wn++) {
                        byte b = bytes[index++];
                        if (i_uKd7oWqHD7wn < 8) {
                            vuread_yG8Me1IxgwYF += (((ulong)b & (ulong)127) << (7 * i_uKd7oWqHD7wn));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_yG8Me1IxgwYF += (ulong)b << (7 * i_uKd7oWqHD7wn);
                            break;
                        }
                    }
                    count_n16d2a5Y4JNU = (ushort)vuread_yG8Me1IxgwYF;
            // Read list items
            if (count_n16d2a5Y4JNU > 0) {
                thingThingMapValues = this.instantiator.AcquireListOfThing();
                for (int li_gcyc5QBuxIAB = 0; li_gcyc5QBuxIAB < count_n16d2a5Y4JNU; li_gcyc5QBuxIAB++) {
                    thingThingMapValues.Add((Thing)Energize(bytes, ref index, 10));
                }
            }
                    o.ThingThingMap = this.instantiator.AcquireDictionaryOfThingToThing();
                    for (int i_mZc5eWWjcBqs = 0; i_mZc5eWWjcBqs < thingThingMapKeys.Count; i_mZc5eWWjcBqs++) {
                        o.ThingThingMap[thingThingMapKeys[i_mZc5eWWjcBqs]] = thingThingMapValues[i_mZc5eWWjcBqs];
                    }
                    this.instantiator.DiscardListOfThing(thingThingMapKeys);
                    this.instantiator.DiscardListOfThing(thingThingMapValues);
                    thingThingMapKeys = null;
                    thingThingMapValues = null;
                }
                    return o;
                }
            case 15:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                EnumIntMapObject o = this.instantiator.AcquireEnumIntMapObject();
                nullFlagsIndex++;
                // MAP: EnumIntMap
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
                    List<MyEnum> enumIntMapKeys = this.instantiator.AcquireListOfMyEnum();
                    List<int> enumIntMapValues = this.instantiator.AcquireListOfInt();
            // Read list item count
            ushort count_y8Jitgr8jVxc;
                    ulong vuread_mFBz4EhojMCz = 0;
                    for (int i_tvCQknkXWgf7 = 0; i_tvCQknkXWgf7 < 9; i_tvCQknkXWgf7++) {
                        byte b = bytes[index++];
                        if (i_tvCQknkXWgf7 < 8) {
                            vuread_mFBz4EhojMCz += (((ulong)b & (ulong)127) << (7 * i_tvCQknkXWgf7));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_mFBz4EhojMCz += (ulong)b << (7 * i_tvCQknkXWgf7);
                            break;
                        }
                    }
                    count_y8Jitgr8jVxc = (ushort)vuread_mFBz4EhojMCz;
            // Read list items
            if (count_y8Jitgr8jVxc > 0) {
                enumIntMapKeys = this.instantiator.AcquireListOfMyEnum();
                for (int i_ctbrrCsTCaBI = 0; i_ctbrrCsTCaBI < count_y8Jitgr8jVxc; i_ctbrrCsTCaBI++) {
                    enumIntMapKeys.Add((MyEnum)System.Enum.Parse(typeof(MyEnum), enumIndexValueMap["MyEnum"][bytes[index++]]));
                }
            }
            // Read list item count
            ushort count_jxpItbivGkx7;
                    ulong vuread_qLY5KKqwADtK = 0;
                    for (int i_l07RuT7T34uW = 0; i_l07RuT7T34uW < 9; i_l07RuT7T34uW++) {
                        byte b = bytes[index++];
                        if (i_l07RuT7T34uW < 8) {
                            vuread_qLY5KKqwADtK += (((ulong)b & (ulong)127) << (7 * i_l07RuT7T34uW));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_qLY5KKqwADtK += (ulong)b << (7 * i_l07RuT7T34uW);
                            break;
                        }
                    }
                    count_jxpItbivGkx7 = (ushort)vuread_qLY5KKqwADtK;
            // Read list items
            if (count_jxpItbivGkx7 > 0) {
                enumIntMapValues = this.instantiator.AcquireListOfInt();
                int listValue_zMDU7TB56dNP;
                for (int i_qwi2Ufi1eOfC = 0; i_qwi2Ufi1eOfC < count_jxpItbivGkx7; i_qwi2Ufi1eOfC++) {
                    // Read Int list item
                listValue_zMDU7TB56dNP =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    enumIntMapValues.Add(listValue_zMDU7TB56dNP);
                }
            }
                    o.EnumIntMap = this.instantiator.AcquireDictionaryOfMyEnumToInt();
                    for (int i_bAbWnNeTqb78 = 0; i_bAbWnNeTqb78 < enumIntMapKeys.Count; i_bAbWnNeTqb78++) {
                        o.EnumIntMap[enumIntMapKeys[i_bAbWnNeTqb78]] = enumIntMapValues[i_bAbWnNeTqb78];
                    }
                    this.instantiator.DiscardListOfMyEnum(enumIntMapKeys);
                    this.instantiator.DiscardListOfInt(enumIntMapValues);
                    enumIntMapKeys = null;
                    enumIntMapValues = null;
                }
                    return o;
                }
            case 16:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                VIntVLongMapObject o = this.instantiator.AcquireVIntVLongMapObject();
                nullFlagsIndex++;
                // MAP: VintVlongMap
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
                    List<int> vintVlongMapKeys = this.instantiator.AcquireListOfInt();
                    List<long> vintVlongMapValues = this.instantiator.AcquireListOfLong();
            // Read list item count
            ushort count_cFyQcxOzmre7;
                    ulong vuread_pf9XVCStGaQH = 0;
                    for (int i_sOSs84zLyjVo = 0; i_sOSs84zLyjVo < 9; i_sOSs84zLyjVo++) {
                        byte b = bytes[index++];
                        if (i_sOSs84zLyjVo < 8) {
                            vuread_pf9XVCStGaQH += (((ulong)b & (ulong)127) << (7 * i_sOSs84zLyjVo));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_pf9XVCStGaQH += (ulong)b << (7 * i_sOSs84zLyjVo);
                            break;
                        }
                    }
                    count_cFyQcxOzmre7 = (ushort)vuread_pf9XVCStGaQH;
            // Read list items
            if (count_cFyQcxOzmre7 > 0) {
                vintVlongMapKeys = this.instantiator.AcquireListOfInt();
                int listValue_rBYRaQqWwdmi;
                for (int i_qr7XtOCfZ17y = 0; i_qr7XtOCfZ17y < count_cFyQcxOzmre7; i_qr7XtOCfZ17y++) {
                    // Read VInt list item
    byte rvint_b_rvAs2CJBtVhu = bytes[index++];
    byte rvint_sign_qbsZU3kPCJOR = (byte)(rvint_b_rvAs2CJBtVhu & 1);
    byte rvint_size_yLsUQQzYDAcO = (byte)(rvint_b_rvAs2CJBtVhu >> 1);
    ulong rvint_remaining_g833EUZ2jMjs = 0;
    for (int i_iNu5Qs6eRSuq = 0; i_iNu5Qs6eRSuq < rvint_size_yLsUQQzYDAcO - 1; i_iNu5Qs6eRSuq++) {
        rvint_remaining_g833EUZ2jMjs = rvint_remaining_g833EUZ2jMjs | (((ulong)bytes[index++] << (8 * i_iNu5Qs6eRSuq)));
    }
    int rvint_result_eYUMvs0o8NIW = (int)rvint_remaining_g833EUZ2jMjs;
    rvint_result_eYUMvs0o8NIW = ~rvint_result_eYUMvs0o8NIW;
    if (rvint_result_eYUMvs0o8NIW == int.MaxValue) {
        rvint_result_eYUMvs0o8NIW = int.MinValue;
    }
    else {
        // Add offset
        rvint_result_eYUMvs0o8NIW += 1;
        if (rvint_sign_qbsZU3kPCJOR == 0) {
            rvint_result_eYUMvs0o8NIW = -rvint_result_eYUMvs0o8NIW;
        }
    }
    listValue_rBYRaQqWwdmi = rvint_result_eYUMvs0o8NIW;
                    vintVlongMapKeys.Add(listValue_rBYRaQqWwdmi);
                }
            }
            // Read list item count
            ushort count_arlRUVHuCazc;
                    ulong vuread_jDhlD77HNNTP = 0;
                    for (int i_znH1V5tRfH5z = 0; i_znH1V5tRfH5z < 9; i_znH1V5tRfH5z++) {
                        byte b = bytes[index++];
                        if (i_znH1V5tRfH5z < 8) {
                            vuread_jDhlD77HNNTP += (((ulong)b & (ulong)127) << (7 * i_znH1V5tRfH5z));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_jDhlD77HNNTP += (ulong)b << (7 * i_znH1V5tRfH5z);
                            break;
                        }
                    }
                    count_arlRUVHuCazc = (ushort)vuread_jDhlD77HNNTP;
            // Read list items
            if (count_arlRUVHuCazc > 0) {
                vintVlongMapValues = this.instantiator.AcquireListOfLong();
                long listValue_cpu6laYkzSp2;
                for (int i_ePUaQbjwIFRG = 0; i_ePUaQbjwIFRG < count_arlRUVHuCazc; i_ePUaQbjwIFRG++) {
                    // Read VLong list item
    byte rvlong_b_gQIHQR7YIReo = bytes[index++];
    byte rvlong_sign_qbwMZIqr7OQg = (byte)(rvlong_b_gQIHQR7YIReo & 1);
    byte rvlong_size_esbeyI1LHXRF = (byte)(rvlong_b_gQIHQR7YIReo >> 1);
    ulong rvlong_remaining_lrDRUAuCLGxO = 0;
    for (int i_rGH9pzJJ9Cwy = 0; i_rGH9pzJJ9Cwy < rvlong_size_esbeyI1LHXRF - 1; i_rGH9pzJJ9Cwy++) {
        rvlong_remaining_lrDRUAuCLGxO = rvlong_remaining_lrDRUAuCLGxO | (((ulong)bytes[index++] << (8 * i_rGH9pzJJ9Cwy)));
    }
    long rvlong_result_r3A90DQZt1kI = (long)rvlong_remaining_lrDRUAuCLGxO;
    rvlong_result_r3A90DQZt1kI = ~rvlong_result_r3A90DQZt1kI;
    if (rvlong_result_r3A90DQZt1kI == long.MaxValue) {
        rvlong_result_r3A90DQZt1kI = long.MinValue;
    }
    else {
        // Add offset
        rvlong_result_r3A90DQZt1kI += 1;
        if (rvlong_sign_qbwMZIqr7OQg == 0) {
            rvlong_result_r3A90DQZt1kI = -rvlong_result_r3A90DQZt1kI;
        }
    }
    listValue_cpu6laYkzSp2 = rvlong_result_r3A90DQZt1kI;
                    vintVlongMapValues.Add(listValue_cpu6laYkzSp2);
                }
            }
                    o.VintVlongMap = this.instantiator.AcquireDictionaryOfIntToLong();
                    for (int i_cJHGunFO5wz1 = 0; i_cJHGunFO5wz1 < vintVlongMapKeys.Count; i_cJHGunFO5wz1++) {
                        o.VintVlongMap[vintVlongMapKeys[i_cJHGunFO5wz1]] = vintVlongMapValues[i_cJHGunFO5wz1];
                    }
                    this.instantiator.DiscardListOfInt(vintVlongMapKeys);
                    this.instantiator.DiscardListOfLong(vintVlongMapValues);
                    vintVlongMapKeys = null;
                    vintVlongMapValues = null;
                }
                    return o;
                }
            case 17:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                IntAbstractThingMapObject o = this.instantiator.AcquireIntAbstractThingMapObject();
                nullFlagsIndex++;
                // MAP: IntAbstractThingMap
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
                    List<int> intAbstractThingMapKeys = this.instantiator.AcquireListOfInt();
                    List<AbstractThing> intAbstractThingMapValues = this.instantiator.AcquireListOfAbstractThing();
            // Read list item count
            ushort count_a2vhoiF94fa1;
                    ulong vuread_auMiZHvXv93Q = 0;
                    for (int i_wcoW6RCuEI87 = 0; i_wcoW6RCuEI87 < 9; i_wcoW6RCuEI87++) {
                        byte b = bytes[index++];
                        if (i_wcoW6RCuEI87 < 8) {
                            vuread_auMiZHvXv93Q += (((ulong)b & (ulong)127) << (7 * i_wcoW6RCuEI87));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_auMiZHvXv93Q += (ulong)b << (7 * i_wcoW6RCuEI87);
                            break;
                        }
                    }
                    count_a2vhoiF94fa1 = (ushort)vuread_auMiZHvXv93Q;
            // Read list items
            if (count_a2vhoiF94fa1 > 0) {
                intAbstractThingMapKeys = this.instantiator.AcquireListOfInt();
                int listValue_dILlvlNaIQGa;
                for (int i_pxZxbLGc8Ppl = 0; i_pxZxbLGc8Ppl < count_a2vhoiF94fa1; i_pxZxbLGc8Ppl++) {
                    // Read Int list item
                listValue_dILlvlNaIQGa =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    intAbstractThingMapKeys.Add(listValue_dILlvlNaIQGa);
                }
            }
            // Read list item count
            ushort count_xTdnMQwBwOaq;
                    ulong vuread_yjCkv3hmFokJ = 0;
                    for (int i_wfs2c68CtzsM = 0; i_wfs2c68CtzsM < 9; i_wfs2c68CtzsM++) {
                        byte b = bytes[index++];
                        if (i_wfs2c68CtzsM < 8) {
                            vuread_yjCkv3hmFokJ += (((ulong)b & (ulong)127) << (7 * i_wfs2c68CtzsM));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_yjCkv3hmFokJ += (ulong)b << (7 * i_wfs2c68CtzsM);
                            break;
                        }
                    }
                    count_xTdnMQwBwOaq = (ushort)vuread_yjCkv3hmFokJ;
            // Read list items
            if (count_xTdnMQwBwOaq > 0) {
                intAbstractThingMapValues = this.instantiator.AcquireListOfAbstractThing();
                for (int li_dAy2teN6wIB2 = 0; li_dAy2teN6wIB2 < count_xTdnMQwBwOaq; li_dAy2teN6wIB2++) {
                    intAbstractThingMapValues.Add((AbstractThing)Energize(bytes, ref index));
                }
            }
                    o.IntAbstractThingMap = this.instantiator.AcquireDictionaryOfIntToAbstractThing();
                    for (int i_dwQfHcPOIDuG = 0; i_dwQfHcPOIDuG < intAbstractThingMapKeys.Count; i_dwQfHcPOIDuG++) {
                        o.IntAbstractThingMap[intAbstractThingMapKeys[i_dwQfHcPOIDuG]] = intAbstractThingMapValues[i_dwQfHcPOIDuG];
                    }
                    this.instantiator.DiscardListOfInt(intAbstractThingMapKeys);
                    this.instantiator.DiscardListOfAbstractThing(intAbstractThingMapValues);
                    intAbstractThingMapKeys = null;
                    intAbstractThingMapValues = null;
                }
                    return o;
                }
                default:
                    throw new MapTestPatternBufferException("Unrecognized type ID: "+typeId+" ");
            }
        }
        public object Energize(byte[] bytes, ref int index) {
                    ulong vuread_jDzAQI6G0Zc5 = 0;
                    for (int i_np3BKonuOATQ = 0; i_np3BKonuOATQ < 9; i_np3BKonuOATQ++) {
                        byte b = bytes[index++];
                        if (i_np3BKonuOATQ < 8) {
                            vuread_jDzAQI6G0Zc5 += (((ulong)b & (ulong)127) << (7 * i_np3BKonuOATQ));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_jDzAQI6G0Zc5 += (ulong)b << (7 * i_np3BKonuOATQ);
                            break;
                        }
                    }
                    ushort typeId = (ushort)vuread_jDzAQI6G0Zc5;
            switch (typeId) {
            case 10:
                {
                Thing o = this.instantiator.AcquireThing();
                // PRIMITIVE: IsSomething
                o.IsSomething = bytes[index++] == 1;
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
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                IntThingMapObject o = this.instantiator.AcquireIntThingMapObject();
                nullFlagsIndex++;
                // MAP: IntThingMap
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
                    List<int> intThingMapKeys = this.instantiator.AcquireListOfInt();
                    List<Thing> intThingMapValues = this.instantiator.AcquireListOfThing();
            // Read list item count
            ushort count_g34rTNdOf1EZ;
                    ulong vuread_rnqYL4bttUKr = 0;
                    for (int i_dodtqa26UTkW = 0; i_dodtqa26UTkW < 9; i_dodtqa26UTkW++) {
                        byte b = bytes[index++];
                        if (i_dodtqa26UTkW < 8) {
                            vuread_rnqYL4bttUKr += (((ulong)b & (ulong)127) << (7 * i_dodtqa26UTkW));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_rnqYL4bttUKr += (ulong)b << (7 * i_dodtqa26UTkW);
                            break;
                        }
                    }
                    count_g34rTNdOf1EZ = (ushort)vuread_rnqYL4bttUKr;
            // Read list items
            if (count_g34rTNdOf1EZ > 0) {
                intThingMapKeys = this.instantiator.AcquireListOfInt();
                int listValue_qPXmVx0NVdVx;
                for (int i_zzSTzAwFtMiE = 0; i_zzSTzAwFtMiE < count_g34rTNdOf1EZ; i_zzSTzAwFtMiE++) {
                    // Read Int list item
                listValue_qPXmVx0NVdVx =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    intThingMapKeys.Add(listValue_qPXmVx0NVdVx);
                }
            }
            // Read list item count
            ushort count_pUye8If5dDk6;
                    ulong vuread_dYH646GfCQu1 = 0;
                    for (int i_hjGtxODaHsMb = 0; i_hjGtxODaHsMb < 9; i_hjGtxODaHsMb++) {
                        byte b = bytes[index++];
                        if (i_hjGtxODaHsMb < 8) {
                            vuread_dYH646GfCQu1 += (((ulong)b & (ulong)127) << (7 * i_hjGtxODaHsMb));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_dYH646GfCQu1 += (ulong)b << (7 * i_hjGtxODaHsMb);
                            break;
                        }
                    }
                    count_pUye8If5dDk6 = (ushort)vuread_dYH646GfCQu1;
            // Read list items
            if (count_pUye8If5dDk6 > 0) {
                intThingMapValues = this.instantiator.AcquireListOfThing();
                for (int li_zVPn80tFoWML = 0; li_zVPn80tFoWML < count_pUye8If5dDk6; li_zVPn80tFoWML++) {
                    intThingMapValues.Add((Thing)Energize(bytes, ref index, 10));
                }
            }
                    o.IntThingMap = this.instantiator.AcquireDictionaryOfIntToThing();
                    for (int i_xALxgdc4zHWZ = 0; i_xALxgdc4zHWZ < intThingMapKeys.Count; i_xALxgdc4zHWZ++) {
                        o.IntThingMap[intThingMapKeys[i_xALxgdc4zHWZ]] = intThingMapValues[i_xALxgdc4zHWZ];
                    }
                    this.instantiator.DiscardListOfInt(intThingMapKeys);
                    this.instantiator.DiscardListOfThing(intThingMapValues);
                    intThingMapKeys = null;
                    intThingMapValues = null;
                }
                    return o;
                }
            case 12:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                ThingIntMapObject o = this.instantiator.AcquireThingIntMapObject();
                nullFlagsIndex++;
                // MAP: ThingIntMap
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
                    List<Thing> thingIntMapKeys = this.instantiator.AcquireListOfThing();
                    List<int> thingIntMapValues = this.instantiator.AcquireListOfInt();
            // Read list item count
            ushort count_aVIy9jzZlF6i;
                    ulong vuread_htgMwZMFH5A7 = 0;
                    for (int i_bg4DqSLB8Zlm = 0; i_bg4DqSLB8Zlm < 9; i_bg4DqSLB8Zlm++) {
                        byte b = bytes[index++];
                        if (i_bg4DqSLB8Zlm < 8) {
                            vuread_htgMwZMFH5A7 += (((ulong)b & (ulong)127) << (7 * i_bg4DqSLB8Zlm));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_htgMwZMFH5A7 += (ulong)b << (7 * i_bg4DqSLB8Zlm);
                            break;
                        }
                    }
                    count_aVIy9jzZlF6i = (ushort)vuread_htgMwZMFH5A7;
            // Read list items
            if (count_aVIy9jzZlF6i > 0) {
                thingIntMapKeys = this.instantiator.AcquireListOfThing();
                for (int li_h5FfxWAxDCgX = 0; li_h5FfxWAxDCgX < count_aVIy9jzZlF6i; li_h5FfxWAxDCgX++) {
                    thingIntMapKeys.Add((Thing)Energize(bytes, ref index, 10));
                }
            }
            // Read list item count
            ushort count_yzHK5rsgvKu3;
                    ulong vuread_g5JD4EkBh3uA = 0;
                    for (int i_iGhUEdELahH0 = 0; i_iGhUEdELahH0 < 9; i_iGhUEdELahH0++) {
                        byte b = bytes[index++];
                        if (i_iGhUEdELahH0 < 8) {
                            vuread_g5JD4EkBh3uA += (((ulong)b & (ulong)127) << (7 * i_iGhUEdELahH0));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_g5JD4EkBh3uA += (ulong)b << (7 * i_iGhUEdELahH0);
                            break;
                        }
                    }
                    count_yzHK5rsgvKu3 = (ushort)vuread_g5JD4EkBh3uA;
            // Read list items
            if (count_yzHK5rsgvKu3 > 0) {
                thingIntMapValues = this.instantiator.AcquireListOfInt();
                int listValue_ebGQHf1RKM0C;
                for (int i_f6D8sPPcfhqy = 0; i_f6D8sPPcfhqy < count_yzHK5rsgvKu3; i_f6D8sPPcfhqy++) {
                    // Read Int list item
                listValue_ebGQHf1RKM0C =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    thingIntMapValues.Add(listValue_ebGQHf1RKM0C);
                }
            }
                    o.ThingIntMap = this.instantiator.AcquireDictionaryOfThingToInt();
                    for (int i_eILrgT2hxSs2 = 0; i_eILrgT2hxSs2 < thingIntMapKeys.Count; i_eILrgT2hxSs2++) {
                        o.ThingIntMap[thingIntMapKeys[i_eILrgT2hxSs2]] = thingIntMapValues[i_eILrgT2hxSs2];
                    }
                    this.instantiator.DiscardListOfThing(thingIntMapKeys);
                    this.instantiator.DiscardListOfInt(thingIntMapValues);
                    thingIntMapKeys = null;
                    thingIntMapValues = null;
                }
                    return o;
                }
            case 13:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                IntStringMapObject o = this.instantiator.AcquireIntStringMapObject();
                nullFlagsIndex++;
                // MAP: IntStringMap
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
                    List<int> intStringMapKeys = this.instantiator.AcquireListOfInt();
                    List<string> intStringMapValues = this.instantiator.AcquireListOfString();
            // Read list item count
            ushort count_zD4bcM0RPPGH;
                    ulong vuread_pGsvBEVdViG8 = 0;
                    for (int i_mJK1TTeEOKaY = 0; i_mJK1TTeEOKaY < 9; i_mJK1TTeEOKaY++) {
                        byte b = bytes[index++];
                        if (i_mJK1TTeEOKaY < 8) {
                            vuread_pGsvBEVdViG8 += (((ulong)b & (ulong)127) << (7 * i_mJK1TTeEOKaY));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_pGsvBEVdViG8 += (ulong)b << (7 * i_mJK1TTeEOKaY);
                            break;
                        }
                    }
                    count_zD4bcM0RPPGH = (ushort)vuread_pGsvBEVdViG8;
            // Read list items
            if (count_zD4bcM0RPPGH > 0) {
                intStringMapKeys = this.instantiator.AcquireListOfInt();
                int listValue_tOaDrJSEbdRK;
                for (int i_lHQ37pgZ65GC = 0; i_lHQ37pgZ65GC < count_zD4bcM0RPPGH; i_lHQ37pgZ65GC++) {
                    // Read Int list item
                listValue_tOaDrJSEbdRK =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    intStringMapKeys.Add(listValue_tOaDrJSEbdRK);
                }
            }
            // Read list item count
            ushort count_a876Kb39FEKX;
                    ulong vuread_msWmzc7B2aAl = 0;
                    for (int i_blHyDk2ZhIBs = 0; i_blHyDk2ZhIBs < 9; i_blHyDk2ZhIBs++) {
                        byte b = bytes[index++];
                        if (i_blHyDk2ZhIBs < 8) {
                            vuread_msWmzc7B2aAl += (((ulong)b & (ulong)127) << (7 * i_blHyDk2ZhIBs));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_msWmzc7B2aAl += (ulong)b << (7 * i_blHyDk2ZhIBs);
                            break;
                        }
                    }
                    count_a876Kb39FEKX = (ushort)vuread_msWmzc7B2aAl;
            // Read list items
            if (count_a876Kb39FEKX > 0) {
                intStringMapValues = this.instantiator.AcquireListOfString();
                string listValue_pW49jSe673yP;
                for (int i_m4A47fJbIV2z = 0; i_m4A47fJbIV2z < count_a876Kb39FEKX; i_m4A47fJbIV2z++) {
                    // Read String list item
                    ulong vuread_d8rk5EokW15J = 0;
                    for (int i_t72b8AUZ3EEO = 0; i_t72b8AUZ3EEO < 9; i_t72b8AUZ3EEO++) {
                        byte b = bytes[index++];
                        if (i_t72b8AUZ3EEO < 8) {
                            vuread_d8rk5EokW15J += (((ulong)b & (ulong)127) << (7 * i_t72b8AUZ3EEO));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_d8rk5EokW15J += (ulong)b << (7 * i_t72b8AUZ3EEO);
                            break;
                        }
                    }
                    ushort stringLength_mFFvLUP60DKM = (ushort)vuread_d8rk5EokW15J;
                listValue_pW49jSe673yP = Encoding.UTF8.GetString(bytes, index, stringLength_mFFvLUP60DKM);
                index += stringLength_mFFvLUP60DKM;
                    intStringMapValues.Add(listValue_pW49jSe673yP);
                }
            }
                    o.IntStringMap = this.instantiator.AcquireDictionaryOfIntToString();
                    for (int i_fTumnCY9uXW9 = 0; i_fTumnCY9uXW9 < intStringMapKeys.Count; i_fTumnCY9uXW9++) {
                        o.IntStringMap[intStringMapKeys[i_fTumnCY9uXW9]] = intStringMapValues[i_fTumnCY9uXW9];
                    }
                    this.instantiator.DiscardListOfInt(intStringMapKeys);
                    this.instantiator.DiscardListOfString(intStringMapValues);
                    intStringMapKeys = null;
                    intStringMapValues = null;
                }
                    return o;
                }
            case 14:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                ThingThingMapObject o = this.instantiator.AcquireThingThingMapObject();
                nullFlagsIndex++;
                // MAP: ThingThingMap
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
                    List<Thing> thingThingMapKeys = this.instantiator.AcquireListOfThing();
                    List<Thing> thingThingMapValues = this.instantiator.AcquireListOfThing();
            // Read list item count
            ushort count_vzfdHSMMK6KO;
                    ulong vuread_wN8ATUSNDM7m = 0;
                    for (int i_eb6ud5o7l2nI = 0; i_eb6ud5o7l2nI < 9; i_eb6ud5o7l2nI++) {
                        byte b = bytes[index++];
                        if (i_eb6ud5o7l2nI < 8) {
                            vuread_wN8ATUSNDM7m += (((ulong)b & (ulong)127) << (7 * i_eb6ud5o7l2nI));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_wN8ATUSNDM7m += (ulong)b << (7 * i_eb6ud5o7l2nI);
                            break;
                        }
                    }
                    count_vzfdHSMMK6KO = (ushort)vuread_wN8ATUSNDM7m;
            // Read list items
            if (count_vzfdHSMMK6KO > 0) {
                thingThingMapKeys = this.instantiator.AcquireListOfThing();
                for (int li_iQsl22eqiQuJ = 0; li_iQsl22eqiQuJ < count_vzfdHSMMK6KO; li_iQsl22eqiQuJ++) {
                    thingThingMapKeys.Add((Thing)Energize(bytes, ref index, 10));
                }
            }
            // Read list item count
            ushort count_myqJejFlC33F;
                    ulong vuread_urJORND9AAgc = 0;
                    for (int i_mHULIQdDRw0O = 0; i_mHULIQdDRw0O < 9; i_mHULIQdDRw0O++) {
                        byte b = bytes[index++];
                        if (i_mHULIQdDRw0O < 8) {
                            vuread_urJORND9AAgc += (((ulong)b & (ulong)127) << (7 * i_mHULIQdDRw0O));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_urJORND9AAgc += (ulong)b << (7 * i_mHULIQdDRw0O);
                            break;
                        }
                    }
                    count_myqJejFlC33F = (ushort)vuread_urJORND9AAgc;
            // Read list items
            if (count_myqJejFlC33F > 0) {
                thingThingMapValues = this.instantiator.AcquireListOfThing();
                for (int li_rP2bxbfAWWyL = 0; li_rP2bxbfAWWyL < count_myqJejFlC33F; li_rP2bxbfAWWyL++) {
                    thingThingMapValues.Add((Thing)Energize(bytes, ref index, 10));
                }
            }
                    o.ThingThingMap = this.instantiator.AcquireDictionaryOfThingToThing();
                    for (int i_hzIFmujdrngG = 0; i_hzIFmujdrngG < thingThingMapKeys.Count; i_hzIFmujdrngG++) {
                        o.ThingThingMap[thingThingMapKeys[i_hzIFmujdrngG]] = thingThingMapValues[i_hzIFmujdrngG];
                    }
                    this.instantiator.DiscardListOfThing(thingThingMapKeys);
                    this.instantiator.DiscardListOfThing(thingThingMapValues);
                    thingThingMapKeys = null;
                    thingThingMapValues = null;
                }
                    return o;
                }
            case 15:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                EnumIntMapObject o = this.instantiator.AcquireEnumIntMapObject();
                nullFlagsIndex++;
                // MAP: EnumIntMap
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
                    List<MyEnum> enumIntMapKeys = this.instantiator.AcquireListOfMyEnum();
                    List<int> enumIntMapValues = this.instantiator.AcquireListOfInt();
            // Read list item count
            ushort count_k4NV0zYzA49c;
                    ulong vuread_tBMyuPpQjjsi = 0;
                    for (int i_dIrwnWxBIwNC = 0; i_dIrwnWxBIwNC < 9; i_dIrwnWxBIwNC++) {
                        byte b = bytes[index++];
                        if (i_dIrwnWxBIwNC < 8) {
                            vuread_tBMyuPpQjjsi += (((ulong)b & (ulong)127) << (7 * i_dIrwnWxBIwNC));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_tBMyuPpQjjsi += (ulong)b << (7 * i_dIrwnWxBIwNC);
                            break;
                        }
                    }
                    count_k4NV0zYzA49c = (ushort)vuread_tBMyuPpQjjsi;
            // Read list items
            if (count_k4NV0zYzA49c > 0) {
                enumIntMapKeys = this.instantiator.AcquireListOfMyEnum();
                for (int i_kuKx89kyAGUV = 0; i_kuKx89kyAGUV < count_k4NV0zYzA49c; i_kuKx89kyAGUV++) {
                    enumIntMapKeys.Add((MyEnum)System.Enum.Parse(typeof(MyEnum), enumIndexValueMap["MyEnum"][bytes[index++]]));
                }
            }
            // Read list item count
            ushort count_sUTL7AxpMENs;
                    ulong vuread_dBlNHHEyYj99 = 0;
                    for (int i_c2Sk93SLXGOD = 0; i_c2Sk93SLXGOD < 9; i_c2Sk93SLXGOD++) {
                        byte b = bytes[index++];
                        if (i_c2Sk93SLXGOD < 8) {
                            vuread_dBlNHHEyYj99 += (((ulong)b & (ulong)127) << (7 * i_c2Sk93SLXGOD));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_dBlNHHEyYj99 += (ulong)b << (7 * i_c2Sk93SLXGOD);
                            break;
                        }
                    }
                    count_sUTL7AxpMENs = (ushort)vuread_dBlNHHEyYj99;
            // Read list items
            if (count_sUTL7AxpMENs > 0) {
                enumIntMapValues = this.instantiator.AcquireListOfInt();
                int listValue_bVEh9x04QsoG;
                for (int i_uG12bw6IUUGe = 0; i_uG12bw6IUUGe < count_sUTL7AxpMENs; i_uG12bw6IUUGe++) {
                    // Read Int list item
                listValue_bVEh9x04QsoG =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    enumIntMapValues.Add(listValue_bVEh9x04QsoG);
                }
            }
                    o.EnumIntMap = this.instantiator.AcquireDictionaryOfMyEnumToInt();
                    for (int i_smqSWcEMWSKV = 0; i_smqSWcEMWSKV < enumIntMapKeys.Count; i_smqSWcEMWSKV++) {
                        o.EnumIntMap[enumIntMapKeys[i_smqSWcEMWSKV]] = enumIntMapValues[i_smqSWcEMWSKV];
                    }
                    this.instantiator.DiscardListOfMyEnum(enumIntMapKeys);
                    this.instantiator.DiscardListOfInt(enumIntMapValues);
                    enumIntMapKeys = null;
                    enumIntMapValues = null;
                }
                    return o;
                }
            case 16:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                VIntVLongMapObject o = this.instantiator.AcquireVIntVLongMapObject();
                nullFlagsIndex++;
                // MAP: VintVlongMap
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
                    List<int> vintVlongMapKeys = this.instantiator.AcquireListOfInt();
                    List<long> vintVlongMapValues = this.instantiator.AcquireListOfLong();
            // Read list item count
            ushort count_bwyAtfsXOlxC;
                    ulong vuread_bZJBJgStpzzW = 0;
                    for (int i_dhiOXMUe6fZO = 0; i_dhiOXMUe6fZO < 9; i_dhiOXMUe6fZO++) {
                        byte b = bytes[index++];
                        if (i_dhiOXMUe6fZO < 8) {
                            vuread_bZJBJgStpzzW += (((ulong)b & (ulong)127) << (7 * i_dhiOXMUe6fZO));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_bZJBJgStpzzW += (ulong)b << (7 * i_dhiOXMUe6fZO);
                            break;
                        }
                    }
                    count_bwyAtfsXOlxC = (ushort)vuread_bZJBJgStpzzW;
            // Read list items
            if (count_bwyAtfsXOlxC > 0) {
                vintVlongMapKeys = this.instantiator.AcquireListOfInt();
                int listValue_zFoPBSAHZXP6;
                for (int i_lddQarGN7Lsl = 0; i_lddQarGN7Lsl < count_bwyAtfsXOlxC; i_lddQarGN7Lsl++) {
                    // Read VInt list item
    byte rvint_b_yO9cAsG7a4Dd = bytes[index++];
    byte rvint_sign_wd1G916uBlmU = (byte)(rvint_b_yO9cAsG7a4Dd & 1);
    byte rvint_size_oeeOImRwmcSW = (byte)(rvint_b_yO9cAsG7a4Dd >> 1);
    ulong rvint_remaining_sygHqS6HK9Y6 = 0;
    for (int i_kaNgP8UVBpDw = 0; i_kaNgP8UVBpDw < rvint_size_oeeOImRwmcSW - 1; i_kaNgP8UVBpDw++) {
        rvint_remaining_sygHqS6HK9Y6 = rvint_remaining_sygHqS6HK9Y6 | (((ulong)bytes[index++] << (8 * i_kaNgP8UVBpDw)));
    }
    int rvint_result_f1yYnh0ZveXL = (int)rvint_remaining_sygHqS6HK9Y6;
    rvint_result_f1yYnh0ZveXL = ~rvint_result_f1yYnh0ZveXL;
    if (rvint_result_f1yYnh0ZveXL == int.MaxValue) {
        rvint_result_f1yYnh0ZveXL = int.MinValue;
    }
    else {
        // Add offset
        rvint_result_f1yYnh0ZveXL += 1;
        if (rvint_sign_wd1G916uBlmU == 0) {
            rvint_result_f1yYnh0ZveXL = -rvint_result_f1yYnh0ZveXL;
        }
    }
    listValue_zFoPBSAHZXP6 = rvint_result_f1yYnh0ZveXL;
                    vintVlongMapKeys.Add(listValue_zFoPBSAHZXP6);
                }
            }
            // Read list item count
            ushort count_tzdTpOkJphpI;
                    ulong vuread_oLQos6vD5Utz = 0;
                    for (int i_iitDi9Lumcvp = 0; i_iitDi9Lumcvp < 9; i_iitDi9Lumcvp++) {
                        byte b = bytes[index++];
                        if (i_iitDi9Lumcvp < 8) {
                            vuread_oLQos6vD5Utz += (((ulong)b & (ulong)127) << (7 * i_iitDi9Lumcvp));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_oLQos6vD5Utz += (ulong)b << (7 * i_iitDi9Lumcvp);
                            break;
                        }
                    }
                    count_tzdTpOkJphpI = (ushort)vuread_oLQos6vD5Utz;
            // Read list items
            if (count_tzdTpOkJphpI > 0) {
                vintVlongMapValues = this.instantiator.AcquireListOfLong();
                long listValue_yaFWf3ggMZpM;
                for (int i_lMGyTtQagOyh = 0; i_lMGyTtQagOyh < count_tzdTpOkJphpI; i_lMGyTtQagOyh++) {
                    // Read VLong list item
    byte rvlong_b_iQAqG4wGpAtr = bytes[index++];
    byte rvlong_sign_lIybNmWF2RdG = (byte)(rvlong_b_iQAqG4wGpAtr & 1);
    byte rvlong_size_mmK2vujrMyBy = (byte)(rvlong_b_iQAqG4wGpAtr >> 1);
    ulong rvlong_remaining_lZKSDTw9to7l = 0;
    for (int i_yOw323oON4Xt = 0; i_yOw323oON4Xt < rvlong_size_mmK2vujrMyBy - 1; i_yOw323oON4Xt++) {
        rvlong_remaining_lZKSDTw9to7l = rvlong_remaining_lZKSDTw9to7l | (((ulong)bytes[index++] << (8 * i_yOw323oON4Xt)));
    }
    long rvlong_result_iDk5rcPdg9JY = (long)rvlong_remaining_lZKSDTw9to7l;
    rvlong_result_iDk5rcPdg9JY = ~rvlong_result_iDk5rcPdg9JY;
    if (rvlong_result_iDk5rcPdg9JY == long.MaxValue) {
        rvlong_result_iDk5rcPdg9JY = long.MinValue;
    }
    else {
        // Add offset
        rvlong_result_iDk5rcPdg9JY += 1;
        if (rvlong_sign_lIybNmWF2RdG == 0) {
            rvlong_result_iDk5rcPdg9JY = -rvlong_result_iDk5rcPdg9JY;
        }
    }
    listValue_yaFWf3ggMZpM = rvlong_result_iDk5rcPdg9JY;
                    vintVlongMapValues.Add(listValue_yaFWf3ggMZpM);
                }
            }
                    o.VintVlongMap = this.instantiator.AcquireDictionaryOfIntToLong();
                    for (int i_qdcjudnopz6R = 0; i_qdcjudnopz6R < vintVlongMapKeys.Count; i_qdcjudnopz6R++) {
                        o.VintVlongMap[vintVlongMapKeys[i_qdcjudnopz6R]] = vintVlongMapValues[i_qdcjudnopz6R];
                    }
                    this.instantiator.DiscardListOfInt(vintVlongMapKeys);
                    this.instantiator.DiscardListOfLong(vintVlongMapValues);
                    vintVlongMapKeys = null;
                    vintVlongMapValues = null;
                }
                    return o;
                }
            case 17:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                IntAbstractThingMapObject o = this.instantiator.AcquireIntAbstractThingMapObject();
                nullFlagsIndex++;
                // MAP: IntAbstractThingMap
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
                    List<int> intAbstractThingMapKeys = this.instantiator.AcquireListOfInt();
                    List<AbstractThing> intAbstractThingMapValues = this.instantiator.AcquireListOfAbstractThing();
            // Read list item count
            ushort count_ypzTjXUHbqz9;
                    ulong vuread_oBSrJ4e6fIrY = 0;
                    for (int i_wftKRJe3GD8b = 0; i_wftKRJe3GD8b < 9; i_wftKRJe3GD8b++) {
                        byte b = bytes[index++];
                        if (i_wftKRJe3GD8b < 8) {
                            vuread_oBSrJ4e6fIrY += (((ulong)b & (ulong)127) << (7 * i_wftKRJe3GD8b));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_oBSrJ4e6fIrY += (ulong)b << (7 * i_wftKRJe3GD8b);
                            break;
                        }
                    }
                    count_ypzTjXUHbqz9 = (ushort)vuread_oBSrJ4e6fIrY;
            // Read list items
            if (count_ypzTjXUHbqz9 > 0) {
                intAbstractThingMapKeys = this.instantiator.AcquireListOfInt();
                int listValue_q53tobWwOcJ3;
                for (int i_i5OvvaLz8K2d = 0; i_i5OvvaLz8K2d < count_ypzTjXUHbqz9; i_i5OvvaLz8K2d++) {
                    // Read Int list item
                listValue_q53tobWwOcJ3 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    intAbstractThingMapKeys.Add(listValue_q53tobWwOcJ3);
                }
            }
            // Read list item count
            ushort count_mk0ClFDgCQON;
                    ulong vuread_aUReW5jYGAoV = 0;
                    for (int i_xTIF1JdcdZZd = 0; i_xTIF1JdcdZZd < 9; i_xTIF1JdcdZZd++) {
                        byte b = bytes[index++];
                        if (i_xTIF1JdcdZZd < 8) {
                            vuread_aUReW5jYGAoV += (((ulong)b & (ulong)127) << (7 * i_xTIF1JdcdZZd));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_aUReW5jYGAoV += (ulong)b << (7 * i_xTIF1JdcdZZd);
                            break;
                        }
                    }
                    count_mk0ClFDgCQON = (ushort)vuread_aUReW5jYGAoV;
            // Read list items
            if (count_mk0ClFDgCQON > 0) {
                intAbstractThingMapValues = this.instantiator.AcquireListOfAbstractThing();
                for (int li_etkjIDAOrbuK = 0; li_etkjIDAOrbuK < count_mk0ClFDgCQON; li_etkjIDAOrbuK++) {
                    intAbstractThingMapValues.Add((AbstractThing)Energize(bytes, ref index));
                }
            }
                    o.IntAbstractThingMap = this.instantiator.AcquireDictionaryOfIntToAbstractThing();
                    for (int i_hGMcBdHe5fHC = 0; i_hGMcBdHe5fHC < intAbstractThingMapKeys.Count; i_hGMcBdHe5fHC++) {
                        o.IntAbstractThingMap[intAbstractThingMapKeys[i_hGMcBdHe5fHC]] = intAbstractThingMapValues[i_hGMcBdHe5fHC];
                    }
                    this.instantiator.DiscardListOfInt(intAbstractThingMapKeys);
                    this.instantiator.DiscardListOfAbstractThing(intAbstractThingMapValues);
                    intAbstractThingMapKeys = null;
                    intAbstractThingMapValues = null;
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
                Thing o = this.instantiator.AcquireThing();
                // PRIMITIVE: IsSomething
                o.IsSomething = bytes[index++] == 1;
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
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                IntThingMapObject o = this.instantiator.AcquireIntThingMapObject();
                nullFlagsIndex++;
                // MAP: IntThingMap
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
                    List<int> intThingMapKeys = this.instantiator.AcquireListOfInt();
                    List<Thing> intThingMapValues = this.instantiator.AcquireListOfThing();
            // Read list item count
            ushort count_y7o3NLJl5N4C;
                    ulong vuread_taqc9KD3y7mv = 0;
                    for (int i_yaLarVifWRlK = 0; i_yaLarVifWRlK < 9; i_yaLarVifWRlK++) {
                        byte b = bytes[index++];
                        if (i_yaLarVifWRlK < 8) {
                            vuread_taqc9KD3y7mv += (((ulong)b & (ulong)127) << (7 * i_yaLarVifWRlK));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_taqc9KD3y7mv += (ulong)b << (7 * i_yaLarVifWRlK);
                            break;
                        }
                    }
                    count_y7o3NLJl5N4C = (ushort)vuread_taqc9KD3y7mv;
            // Read list items
            if (count_y7o3NLJl5N4C > 0) {
                intThingMapKeys = this.instantiator.AcquireListOfInt();
                int listValue_gGbPBjPPMkrA;
                for (int i_uEevLNdaV37M = 0; i_uEevLNdaV37M < count_y7o3NLJl5N4C; i_uEevLNdaV37M++) {
                    // Read Int list item
                listValue_gGbPBjPPMkrA =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    intThingMapKeys.Add(listValue_gGbPBjPPMkrA);
                }
            }
            // Read list item count
            ushort count_aJ3kFYPdYPYC;
                    ulong vuread_oYCpsHSVSknW = 0;
                    for (int i_rWDiNlZvJyO1 = 0; i_rWDiNlZvJyO1 < 9; i_rWDiNlZvJyO1++) {
                        byte b = bytes[index++];
                        if (i_rWDiNlZvJyO1 < 8) {
                            vuread_oYCpsHSVSknW += (((ulong)b & (ulong)127) << (7 * i_rWDiNlZvJyO1));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_oYCpsHSVSknW += (ulong)b << (7 * i_rWDiNlZvJyO1);
                            break;
                        }
                    }
                    count_aJ3kFYPdYPYC = (ushort)vuread_oYCpsHSVSknW;
            // Read list items
            if (count_aJ3kFYPdYPYC > 0) {
                intThingMapValues = this.instantiator.AcquireListOfThing();
                for (int li_gEjXEoMhQLWX = 0; li_gEjXEoMhQLWX < count_aJ3kFYPdYPYC; li_gEjXEoMhQLWX++) {
                    intThingMapValues.Add((Thing)Energize(bytes, ref index, 10));
                }
            }
                    o.IntThingMap = this.instantiator.AcquireDictionaryOfIntToThing();
                    for (int i_eXRokl30wgDT = 0; i_eXRokl30wgDT < intThingMapKeys.Count; i_eXRokl30wgDT++) {
                        o.IntThingMap[intThingMapKeys[i_eXRokl30wgDT]] = intThingMapValues[i_eXRokl30wgDT];
                    }
                    this.instantiator.DiscardListOfInt(intThingMapKeys);
                    this.instantiator.DiscardListOfThing(intThingMapValues);
                    intThingMapKeys = null;
                    intThingMapValues = null;
                }
                    return o;
                }
            case 12:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                ThingIntMapObject o = this.instantiator.AcquireThingIntMapObject();
                nullFlagsIndex++;
                // MAP: ThingIntMap
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
                    List<Thing> thingIntMapKeys = this.instantiator.AcquireListOfThing();
                    List<int> thingIntMapValues = this.instantiator.AcquireListOfInt();
            // Read list item count
            ushort count_iHzM0C3kjKaX;
                    ulong vuread_j4rEHffe9Q60 = 0;
                    for (int i_mLkxEYFiaAC7 = 0; i_mLkxEYFiaAC7 < 9; i_mLkxEYFiaAC7++) {
                        byte b = bytes[index++];
                        if (i_mLkxEYFiaAC7 < 8) {
                            vuread_j4rEHffe9Q60 += (((ulong)b & (ulong)127) << (7 * i_mLkxEYFiaAC7));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_j4rEHffe9Q60 += (ulong)b << (7 * i_mLkxEYFiaAC7);
                            break;
                        }
                    }
                    count_iHzM0C3kjKaX = (ushort)vuread_j4rEHffe9Q60;
            // Read list items
            if (count_iHzM0C3kjKaX > 0) {
                thingIntMapKeys = this.instantiator.AcquireListOfThing();
                for (int li_v9roSMOLX40p = 0; li_v9roSMOLX40p < count_iHzM0C3kjKaX; li_v9roSMOLX40p++) {
                    thingIntMapKeys.Add((Thing)Energize(bytes, ref index, 10));
                }
            }
            // Read list item count
            ushort count_xzsqbzTOKJio;
                    ulong vuread_hGPve1W7CtQH = 0;
                    for (int i_v1wxcvcJU4Cf = 0; i_v1wxcvcJU4Cf < 9; i_v1wxcvcJU4Cf++) {
                        byte b = bytes[index++];
                        if (i_v1wxcvcJU4Cf < 8) {
                            vuread_hGPve1W7CtQH += (((ulong)b & (ulong)127) << (7 * i_v1wxcvcJU4Cf));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_hGPve1W7CtQH += (ulong)b << (7 * i_v1wxcvcJU4Cf);
                            break;
                        }
                    }
                    count_xzsqbzTOKJio = (ushort)vuread_hGPve1W7CtQH;
            // Read list items
            if (count_xzsqbzTOKJio > 0) {
                thingIntMapValues = this.instantiator.AcquireListOfInt();
                int listValue_nphLQYwp1c6l;
                for (int i_ytG5h2XLSVBj = 0; i_ytG5h2XLSVBj < count_xzsqbzTOKJio; i_ytG5h2XLSVBj++) {
                    // Read Int list item
                listValue_nphLQYwp1c6l =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    thingIntMapValues.Add(listValue_nphLQYwp1c6l);
                }
            }
                    o.ThingIntMap = this.instantiator.AcquireDictionaryOfThingToInt();
                    for (int i_bwMpGIDxeKZZ = 0; i_bwMpGIDxeKZZ < thingIntMapKeys.Count; i_bwMpGIDxeKZZ++) {
                        o.ThingIntMap[thingIntMapKeys[i_bwMpGIDxeKZZ]] = thingIntMapValues[i_bwMpGIDxeKZZ];
                    }
                    this.instantiator.DiscardListOfThing(thingIntMapKeys);
                    this.instantiator.DiscardListOfInt(thingIntMapValues);
                    thingIntMapKeys = null;
                    thingIntMapValues = null;
                }
                    return o;
                }
            case 13:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                IntStringMapObject o = this.instantiator.AcquireIntStringMapObject();
                nullFlagsIndex++;
                // MAP: IntStringMap
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
                    List<int> intStringMapKeys = this.instantiator.AcquireListOfInt();
                    List<string> intStringMapValues = this.instantiator.AcquireListOfString();
            // Read list item count
            ushort count_tlrO6BQW5lAT;
                    ulong vuread_vhC2h1wUX7Ju = 0;
                    for (int i_fhSsIIhwDRk6 = 0; i_fhSsIIhwDRk6 < 9; i_fhSsIIhwDRk6++) {
                        byte b = bytes[index++];
                        if (i_fhSsIIhwDRk6 < 8) {
                            vuread_vhC2h1wUX7Ju += (((ulong)b & (ulong)127) << (7 * i_fhSsIIhwDRk6));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_vhC2h1wUX7Ju += (ulong)b << (7 * i_fhSsIIhwDRk6);
                            break;
                        }
                    }
                    count_tlrO6BQW5lAT = (ushort)vuread_vhC2h1wUX7Ju;
            // Read list items
            if (count_tlrO6BQW5lAT > 0) {
                intStringMapKeys = this.instantiator.AcquireListOfInt();
                int listValue_pjOrePo152Ay;
                for (int i_cLqmnfbWL6CY = 0; i_cLqmnfbWL6CY < count_tlrO6BQW5lAT; i_cLqmnfbWL6CY++) {
                    // Read Int list item
                listValue_pjOrePo152Ay =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    intStringMapKeys.Add(listValue_pjOrePo152Ay);
                }
            }
            // Read list item count
            ushort count_synwdeqg6Gq7;
                    ulong vuread_ffPhTSytQtl6 = 0;
                    for (int i_h4ixQyuORZJP = 0; i_h4ixQyuORZJP < 9; i_h4ixQyuORZJP++) {
                        byte b = bytes[index++];
                        if (i_h4ixQyuORZJP < 8) {
                            vuread_ffPhTSytQtl6 += (((ulong)b & (ulong)127) << (7 * i_h4ixQyuORZJP));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_ffPhTSytQtl6 += (ulong)b << (7 * i_h4ixQyuORZJP);
                            break;
                        }
                    }
                    count_synwdeqg6Gq7 = (ushort)vuread_ffPhTSytQtl6;
            // Read list items
            if (count_synwdeqg6Gq7 > 0) {
                intStringMapValues = this.instantiator.AcquireListOfString();
                string listValue_l2X1MuCKvsai;
                for (int i_k3d3Iiiymqdj = 0; i_k3d3Iiiymqdj < count_synwdeqg6Gq7; i_k3d3Iiiymqdj++) {
                    // Read String list item
                    ulong vuread_xHQw1LL94a7X = 0;
                    for (int i_iAgIRkClYO5T = 0; i_iAgIRkClYO5T < 9; i_iAgIRkClYO5T++) {
                        byte b = bytes[index++];
                        if (i_iAgIRkClYO5T < 8) {
                            vuread_xHQw1LL94a7X += (((ulong)b & (ulong)127) << (7 * i_iAgIRkClYO5T));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_xHQw1LL94a7X += (ulong)b << (7 * i_iAgIRkClYO5T);
                            break;
                        }
                    }
                    ushort stringLength_y2zIlLpxFaP0 = (ushort)vuread_xHQw1LL94a7X;
                listValue_l2X1MuCKvsai = Encoding.UTF8.GetString(bytes, index, stringLength_y2zIlLpxFaP0);
                index += stringLength_y2zIlLpxFaP0;
                    intStringMapValues.Add(listValue_l2X1MuCKvsai);
                }
            }
                    o.IntStringMap = this.instantiator.AcquireDictionaryOfIntToString();
                    for (int i_x3yUcMMznm9b = 0; i_x3yUcMMznm9b < intStringMapKeys.Count; i_x3yUcMMznm9b++) {
                        o.IntStringMap[intStringMapKeys[i_x3yUcMMznm9b]] = intStringMapValues[i_x3yUcMMznm9b];
                    }
                    this.instantiator.DiscardListOfInt(intStringMapKeys);
                    this.instantiator.DiscardListOfString(intStringMapValues);
                    intStringMapKeys = null;
                    intStringMapValues = null;
                }
                    return o;
                }
            case 14:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                ThingThingMapObject o = this.instantiator.AcquireThingThingMapObject();
                nullFlagsIndex++;
                // MAP: ThingThingMap
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
                    List<Thing> thingThingMapKeys = this.instantiator.AcquireListOfThing();
                    List<Thing> thingThingMapValues = this.instantiator.AcquireListOfThing();
            // Read list item count
            ushort count_lVGLPdo55MoU;
                    ulong vuread_nRPvHEcpL6B8 = 0;
                    for (int i_f06ryHJhBeg5 = 0; i_f06ryHJhBeg5 < 9; i_f06ryHJhBeg5++) {
                        byte b = bytes[index++];
                        if (i_f06ryHJhBeg5 < 8) {
                            vuread_nRPvHEcpL6B8 += (((ulong)b & (ulong)127) << (7 * i_f06ryHJhBeg5));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_nRPvHEcpL6B8 += (ulong)b << (7 * i_f06ryHJhBeg5);
                            break;
                        }
                    }
                    count_lVGLPdo55MoU = (ushort)vuread_nRPvHEcpL6B8;
            // Read list items
            if (count_lVGLPdo55MoU > 0) {
                thingThingMapKeys = this.instantiator.AcquireListOfThing();
                for (int li_q1FVzaYsPNov = 0; li_q1FVzaYsPNov < count_lVGLPdo55MoU; li_q1FVzaYsPNov++) {
                    thingThingMapKeys.Add((Thing)Energize(bytes, ref index, 10));
                }
            }
            // Read list item count
            ushort count_yr2TkTzGuIyY;
                    ulong vuread_c7GycgtALTRQ = 0;
                    for (int i_zqZLiitJMLuh = 0; i_zqZLiitJMLuh < 9; i_zqZLiitJMLuh++) {
                        byte b = bytes[index++];
                        if (i_zqZLiitJMLuh < 8) {
                            vuread_c7GycgtALTRQ += (((ulong)b & (ulong)127) << (7 * i_zqZLiitJMLuh));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_c7GycgtALTRQ += (ulong)b << (7 * i_zqZLiitJMLuh);
                            break;
                        }
                    }
                    count_yr2TkTzGuIyY = (ushort)vuread_c7GycgtALTRQ;
            // Read list items
            if (count_yr2TkTzGuIyY > 0) {
                thingThingMapValues = this.instantiator.AcquireListOfThing();
                for (int li_r07ROJLfCROC = 0; li_r07ROJLfCROC < count_yr2TkTzGuIyY; li_r07ROJLfCROC++) {
                    thingThingMapValues.Add((Thing)Energize(bytes, ref index, 10));
                }
            }
                    o.ThingThingMap = this.instantiator.AcquireDictionaryOfThingToThing();
                    for (int i_mApIuYUnJlV3 = 0; i_mApIuYUnJlV3 < thingThingMapKeys.Count; i_mApIuYUnJlV3++) {
                        o.ThingThingMap[thingThingMapKeys[i_mApIuYUnJlV3]] = thingThingMapValues[i_mApIuYUnJlV3];
                    }
                    this.instantiator.DiscardListOfThing(thingThingMapKeys);
                    this.instantiator.DiscardListOfThing(thingThingMapValues);
                    thingThingMapKeys = null;
                    thingThingMapValues = null;
                }
                    return o;
                }
            case 15:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                EnumIntMapObject o = this.instantiator.AcquireEnumIntMapObject();
                nullFlagsIndex++;
                // MAP: EnumIntMap
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
                    List<MyEnum> enumIntMapKeys = this.instantiator.AcquireListOfMyEnum();
                    List<int> enumIntMapValues = this.instantiator.AcquireListOfInt();
            // Read list item count
            ushort count_xYxlpZmFNzSm;
                    ulong vuread_dLVbiLnqMxhS = 0;
                    for (int i_xUoX0gHDedX0 = 0; i_xUoX0gHDedX0 < 9; i_xUoX0gHDedX0++) {
                        byte b = bytes[index++];
                        if (i_xUoX0gHDedX0 < 8) {
                            vuread_dLVbiLnqMxhS += (((ulong)b & (ulong)127) << (7 * i_xUoX0gHDedX0));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_dLVbiLnqMxhS += (ulong)b << (7 * i_xUoX0gHDedX0);
                            break;
                        }
                    }
                    count_xYxlpZmFNzSm = (ushort)vuread_dLVbiLnqMxhS;
            // Read list items
            if (count_xYxlpZmFNzSm > 0) {
                enumIntMapKeys = this.instantiator.AcquireListOfMyEnum();
                for (int i_fA0NEjZdRczS = 0; i_fA0NEjZdRczS < count_xYxlpZmFNzSm; i_fA0NEjZdRczS++) {
                    enumIntMapKeys.Add((MyEnum)System.Enum.Parse(typeof(MyEnum), enumIndexValueMap["MyEnum"][bytes[index++]]));
                }
            }
            // Read list item count
            ushort count_bSe88ErGQPrE;
                    ulong vuread_pyOG2pifX5ZR = 0;
                    for (int i_tJWDIda0uGUi = 0; i_tJWDIda0uGUi < 9; i_tJWDIda0uGUi++) {
                        byte b = bytes[index++];
                        if (i_tJWDIda0uGUi < 8) {
                            vuread_pyOG2pifX5ZR += (((ulong)b & (ulong)127) << (7 * i_tJWDIda0uGUi));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_pyOG2pifX5ZR += (ulong)b << (7 * i_tJWDIda0uGUi);
                            break;
                        }
                    }
                    count_bSe88ErGQPrE = (ushort)vuread_pyOG2pifX5ZR;
            // Read list items
            if (count_bSe88ErGQPrE > 0) {
                enumIntMapValues = this.instantiator.AcquireListOfInt();
                int listValue_aIEKVrjGivdf;
                for (int i_mslB4t4h3wnz = 0; i_mslB4t4h3wnz < count_bSe88ErGQPrE; i_mslB4t4h3wnz++) {
                    // Read Int list item
                listValue_aIEKVrjGivdf =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    enumIntMapValues.Add(listValue_aIEKVrjGivdf);
                }
            }
                    o.EnumIntMap = this.instantiator.AcquireDictionaryOfMyEnumToInt();
                    for (int i_sY8MOBkdOGEt = 0; i_sY8MOBkdOGEt < enumIntMapKeys.Count; i_sY8MOBkdOGEt++) {
                        o.EnumIntMap[enumIntMapKeys[i_sY8MOBkdOGEt]] = enumIntMapValues[i_sY8MOBkdOGEt];
                    }
                    this.instantiator.DiscardListOfMyEnum(enumIntMapKeys);
                    this.instantiator.DiscardListOfInt(enumIntMapValues);
                    enumIntMapKeys = null;
                    enumIntMapValues = null;
                }
                    return o;
                }
            case 16:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                VIntVLongMapObject o = this.instantiator.AcquireVIntVLongMapObject();
                nullFlagsIndex++;
                // MAP: VintVlongMap
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
                    List<int> vintVlongMapKeys = this.instantiator.AcquireListOfInt();
                    List<long> vintVlongMapValues = this.instantiator.AcquireListOfLong();
            // Read list item count
            ushort count_tHuGVsJzFQ8p;
                    ulong vuread_wJ5bLNoPvf17 = 0;
                    for (int i_hH1Ql9B8Y2Rw = 0; i_hH1Ql9B8Y2Rw < 9; i_hH1Ql9B8Y2Rw++) {
                        byte b = bytes[index++];
                        if (i_hH1Ql9B8Y2Rw < 8) {
                            vuread_wJ5bLNoPvf17 += (((ulong)b & (ulong)127) << (7 * i_hH1Ql9B8Y2Rw));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_wJ5bLNoPvf17 += (ulong)b << (7 * i_hH1Ql9B8Y2Rw);
                            break;
                        }
                    }
                    count_tHuGVsJzFQ8p = (ushort)vuread_wJ5bLNoPvf17;
            // Read list items
            if (count_tHuGVsJzFQ8p > 0) {
                vintVlongMapKeys = this.instantiator.AcquireListOfInt();
                int listValue_zxvKXX3c0SUf;
                for (int i_njCarZ7PQxno = 0; i_njCarZ7PQxno < count_tHuGVsJzFQ8p; i_njCarZ7PQxno++) {
                    // Read VInt list item
    byte rvint_b_l2oFoaB92Ibn = bytes[index++];
    byte rvint_sign_hN1IlZgJWWkc = (byte)(rvint_b_l2oFoaB92Ibn & 1);
    byte rvint_size_oAQ94bQMjgj4 = (byte)(rvint_b_l2oFoaB92Ibn >> 1);
    ulong rvint_remaining_oyX0rUn7hoSN = 0;
    for (int i_yzD0qNBPSm7X = 0; i_yzD0qNBPSm7X < rvint_size_oAQ94bQMjgj4 - 1; i_yzD0qNBPSm7X++) {
        rvint_remaining_oyX0rUn7hoSN = rvint_remaining_oyX0rUn7hoSN | (((ulong)bytes[index++] << (8 * i_yzD0qNBPSm7X)));
    }
    int rvint_result_iCf01zdkE79X = (int)rvint_remaining_oyX0rUn7hoSN;
    rvint_result_iCf01zdkE79X = ~rvint_result_iCf01zdkE79X;
    if (rvint_result_iCf01zdkE79X == int.MaxValue) {
        rvint_result_iCf01zdkE79X = int.MinValue;
    }
    else {
        // Add offset
        rvint_result_iCf01zdkE79X += 1;
        if (rvint_sign_hN1IlZgJWWkc == 0) {
            rvint_result_iCf01zdkE79X = -rvint_result_iCf01zdkE79X;
        }
    }
    listValue_zxvKXX3c0SUf = rvint_result_iCf01zdkE79X;
                    vintVlongMapKeys.Add(listValue_zxvKXX3c0SUf);
                }
            }
            // Read list item count
            ushort count_aqscJm4tScbF;
                    ulong vuread_o0vFOEmwAaGZ = 0;
                    for (int i_rwgSkHjaAPY9 = 0; i_rwgSkHjaAPY9 < 9; i_rwgSkHjaAPY9++) {
                        byte b = bytes[index++];
                        if (i_rwgSkHjaAPY9 < 8) {
                            vuread_o0vFOEmwAaGZ += (((ulong)b & (ulong)127) << (7 * i_rwgSkHjaAPY9));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_o0vFOEmwAaGZ += (ulong)b << (7 * i_rwgSkHjaAPY9);
                            break;
                        }
                    }
                    count_aqscJm4tScbF = (ushort)vuread_o0vFOEmwAaGZ;
            // Read list items
            if (count_aqscJm4tScbF > 0) {
                vintVlongMapValues = this.instantiator.AcquireListOfLong();
                long listValue_jzgFrOfrAJrb;
                for (int i_bHGaUMxbUCxm = 0; i_bHGaUMxbUCxm < count_aqscJm4tScbF; i_bHGaUMxbUCxm++) {
                    // Read VLong list item
    byte rvlong_b_cmik3be3bvkp = bytes[index++];
    byte rvlong_sign_kReV4pzffeOM = (byte)(rvlong_b_cmik3be3bvkp & 1);
    byte rvlong_size_aipXrXp2c3yf = (byte)(rvlong_b_cmik3be3bvkp >> 1);
    ulong rvlong_remaining_n5xzFxaRxqMc = 0;
    for (int i_oLhEdrgcHFiU = 0; i_oLhEdrgcHFiU < rvlong_size_aipXrXp2c3yf - 1; i_oLhEdrgcHFiU++) {
        rvlong_remaining_n5xzFxaRxqMc = rvlong_remaining_n5xzFxaRxqMc | (((ulong)bytes[index++] << (8 * i_oLhEdrgcHFiU)));
    }
    long rvlong_result_trLngrmEt9p9 = (long)rvlong_remaining_n5xzFxaRxqMc;
    rvlong_result_trLngrmEt9p9 = ~rvlong_result_trLngrmEt9p9;
    if (rvlong_result_trLngrmEt9p9 == long.MaxValue) {
        rvlong_result_trLngrmEt9p9 = long.MinValue;
    }
    else {
        // Add offset
        rvlong_result_trLngrmEt9p9 += 1;
        if (rvlong_sign_kReV4pzffeOM == 0) {
            rvlong_result_trLngrmEt9p9 = -rvlong_result_trLngrmEt9p9;
        }
    }
    listValue_jzgFrOfrAJrb = rvlong_result_trLngrmEt9p9;
                    vintVlongMapValues.Add(listValue_jzgFrOfrAJrb);
                }
            }
                    o.VintVlongMap = this.instantiator.AcquireDictionaryOfIntToLong();
                    for (int i_w9KRd7pVGnpQ = 0; i_w9KRd7pVGnpQ < vintVlongMapKeys.Count; i_w9KRd7pVGnpQ++) {
                        o.VintVlongMap[vintVlongMapKeys[i_w9KRd7pVGnpQ]] = vintVlongMapValues[i_w9KRd7pVGnpQ];
                    }
                    this.instantiator.DiscardListOfInt(vintVlongMapKeys);
                    this.instantiator.DiscardListOfLong(vintVlongMapValues);
                    vintVlongMapKeys = null;
                    vintVlongMapValues = null;
                }
                    return o;
                }
            case 17:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                IntAbstractThingMapObject o = this.instantiator.AcquireIntAbstractThingMapObject();
                nullFlagsIndex++;
                // MAP: IntAbstractThingMap
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
                    List<int> intAbstractThingMapKeys = this.instantiator.AcquireListOfInt();
                    List<AbstractThing> intAbstractThingMapValues = this.instantiator.AcquireListOfAbstractThing();
            // Read list item count
            ushort count_rUZUXwIaWNOn;
                    ulong vuread_uWLgdiTIwhNd = 0;
                    for (int i_sz8KqxoIb5Hv = 0; i_sz8KqxoIb5Hv < 9; i_sz8KqxoIb5Hv++) {
                        byte b = bytes[index++];
                        if (i_sz8KqxoIb5Hv < 8) {
                            vuread_uWLgdiTIwhNd += (((ulong)b & (ulong)127) << (7 * i_sz8KqxoIb5Hv));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_uWLgdiTIwhNd += (ulong)b << (7 * i_sz8KqxoIb5Hv);
                            break;
                        }
                    }
                    count_rUZUXwIaWNOn = (ushort)vuread_uWLgdiTIwhNd;
            // Read list items
            if (count_rUZUXwIaWNOn > 0) {
                intAbstractThingMapKeys = this.instantiator.AcquireListOfInt();
                int listValue_lCR7Apmnvw5r;
                for (int i_jjRyDRuIhVcy = 0; i_jjRyDRuIhVcy < count_rUZUXwIaWNOn; i_jjRyDRuIhVcy++) {
                    // Read Int list item
                listValue_lCR7Apmnvw5r =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    intAbstractThingMapKeys.Add(listValue_lCR7Apmnvw5r);
                }
            }
            // Read list item count
            ushort count_j7Uzyfm0pqOL;
                    ulong vuread_lWhh4zSvERoh = 0;
                    for (int i_r0euL8oQztJD = 0; i_r0euL8oQztJD < 9; i_r0euL8oQztJD++) {
                        byte b = bytes[index++];
                        if (i_r0euL8oQztJD < 8) {
                            vuread_lWhh4zSvERoh += (((ulong)b & (ulong)127) << (7 * i_r0euL8oQztJD));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_lWhh4zSvERoh += (ulong)b << (7 * i_r0euL8oQztJD);
                            break;
                        }
                    }
                    count_j7Uzyfm0pqOL = (ushort)vuread_lWhh4zSvERoh;
            // Read list items
            if (count_j7Uzyfm0pqOL > 0) {
                intAbstractThingMapValues = this.instantiator.AcquireListOfAbstractThing();
                for (int li_mWZpjecfEf7Q = 0; li_mWZpjecfEf7Q < count_j7Uzyfm0pqOL; li_mWZpjecfEf7Q++) {
                    intAbstractThingMapValues.Add((AbstractThing)Energize(bytes, ref index));
                }
            }
                    o.IntAbstractThingMap = this.instantiator.AcquireDictionaryOfIntToAbstractThing();
                    for (int i_onNRdR3QTMTI = 0; i_onNRdR3QTMTI < intAbstractThingMapKeys.Count; i_onNRdR3QTMTI++) {
                        o.IntAbstractThingMap[intAbstractThingMapKeys[i_onNRdR3QTMTI]] = intAbstractThingMapValues[i_onNRdR3QTMTI];
                    }
                    this.instantiator.DiscardListOfInt(intAbstractThingMapKeys);
                    this.instantiator.DiscardListOfAbstractThing(intAbstractThingMapValues);
                    intAbstractThingMapKeys = null;
                    intAbstractThingMapValues = null;
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
///////////////////////////////////////
// RECLAIM
///////////////////////////////////////
        public void Reclaim(AbstractThing o) {
            if (o != null) {
                if (o is Thing) {
                    this.Reclaim((Thing)o);
                }
                o.IsSomething = default(bool);
            }
        }
        public void Reclaim(Thing o) {
            if (o != null) {
                o.IntValue = default(int);
                this.instantiator.DiscardThing(o);
            }
        }
        public void Reclaim(IntThingMapObject o) {
            if (o != null) {
                if (o.IntThingMap != null) {
                    foreach (Thing v in o.IntThingMap.Values) {
                        this.Reclaim(v);
                    }
                    this.instantiator.DiscardDictionaryOfIntToThing((Dictionary<int,Thing>)o.IntThingMap);
                }
                this.instantiator.DiscardIntThingMapObject(o);
            }
        }
        public void Reclaim(ThingIntMapObject o) {
            if (o != null) {
                if (o.ThingIntMap != null) {
                    foreach (Thing k in o.ThingIntMap.Keys) {
                        this.Reclaim(k);
                    }
                    this.instantiator.DiscardDictionaryOfThingToInt((Dictionary<Thing,int>)o.ThingIntMap);
                }
                this.instantiator.DiscardThingIntMapObject(o);
            }
        }
        public void Reclaim(IntStringMapObject o) {
            if (o != null) {
                if (o.IntStringMap != null) {
                    this.instantiator.DiscardDictionaryOfIntToString((Dictionary<int,string>)o.IntStringMap);
                }
                this.instantiator.DiscardIntStringMapObject(o);
            }
        }
        public void Reclaim(ThingThingMapObject o) {
            if (o != null) {
                if (o.ThingThingMap != null) {
                    foreach (Thing k in o.ThingThingMap.Keys) {
                        this.Reclaim(k);
                    }
                    foreach (Thing v in o.ThingThingMap.Values) {
                        this.Reclaim(v);
                    }
                    this.instantiator.DiscardDictionaryOfThingToThing((Dictionary<Thing,Thing>)o.ThingThingMap);
                }
                this.instantiator.DiscardThingThingMapObject(o);
            }
        }
        public void Reclaim(EnumIntMapObject o) {
            if (o != null) {
                if (o.EnumIntMap != null) {
                    this.instantiator.DiscardDictionaryOfMyEnumToInt((Dictionary<MyEnum,int>)o.EnumIntMap);
                }
                this.instantiator.DiscardEnumIntMapObject(o);
            }
        }
        public void Reclaim(VIntVLongMapObject o) {
            if (o != null) {
                if (o.VintVlongMap != null) {
                    this.instantiator.DiscardDictionaryOfIntToLong((Dictionary<int,long>)o.VintVlongMap);
                }
                this.instantiator.DiscardVIntVLongMapObject(o);
            }
        }
        public void Reclaim(IntAbstractThingMapObject o) {
            if (o != null) {
                if (o.IntAbstractThingMap != null) {
                    foreach (AbstractThing v in o.IntAbstractThingMap.Values) {
                        this.Reclaim(v);
                    }
                    this.instantiator.DiscardDictionaryOfIntToAbstractThing((Dictionary<int,AbstractThing>)o.IntAbstractThingMap);
                }
                this.instantiator.DiscardIntAbstractThingMapObject(o);
            }
        }
    }
}
