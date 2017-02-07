
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System.Text;
using System;
using System.Collections.Generic;

namespace Test.Enum {
    public class EnumTestPatternBuffer {
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
                "SomeEnum",
                new Dictionary<byte,string>() {
                    {(byte)1, "value1"},
                    {(byte)2, "value2"},
                    {(byte)3, "value3"}
                }
            },
            {
                "SomeEnum2",
                new Dictionary<byte,string>() {
                    {(byte)1, "value4"},
                    {(byte)2, "value5"},
                    {(byte)3, "value6"}
                }
            }
        };
        public static readonly Dictionary<string, Dictionary<string, byte>> enumValueIndexMap = new Dictionary<string, Dictionary<string, byte>> {
            {
                "SomeEnum",
                new Dictionary<string,byte>() {
                    {"value1", (byte)1},
                    {"value2", (byte)2},
                    {"value3", (byte)3}
                }
            },
            {
                "SomeEnum2",
                new Dictionary<string,byte>() {
                    {"value4", (byte)1},
                    {"value5", (byte)2},
                    {"value6", (byte)3}
                }
            }
        };
        private byte[] bytes;
        public EnumTestPatternBuffer() : this(4096) { }
        public EnumTestPatternBuffer(uint bufferSize) {
            this.bytes = new byte[bufferSize];
        }
///////////////////////////////////////
// TO BYTES
///////////////////////////////////////
        public byte[] Energize(EnumObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(EnumListObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(EnumMapObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(EnumMap2Object o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(EnumSetObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public void Energize(EnumObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 11;
            }
                // REFERENCE: SomeEnumValue
                bytes[index++] = enumValueIndexMap["SomeEnum"][o.SomeEnumValue.ToString()];
;
        }
        public void Energize(EnumListObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 12;
            }
                // LIST: SomeEnumListValue
            if (o.SomeEnumListValue == null || o.SomeEnumListValue.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.SomeEnumListValue.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.SomeEnumListValue.Count;
                int i_yt6IJNt4mFFG;
                for (i_yt6IJNt4mFFG = 0; i_yt6IJNt4mFFG < 2; i_yt6IJNt4mFFG++) {
                    if ((ulong)o.SomeEnumListValue.Count < vuBoundaries[i_yt6IJNt4mFFG]) {
                       byteCount = (int)(i_yt6IJNt4mFFG + 1);
                       goto guvsgoto_d03IcJdmety7;
                    }
                }
                byteCount = (int)i_yt6IJNt4mFFG + 1;
                guvsgoto_d03IcJdmety7:
                    for (int i_hqBMBRkcXkxZ = 0; i_hqBMBRkcXkxZ < byteCount; i_hqBMBRkcXkxZ++) {
                        if (i_hqBMBRkcXkxZ < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_hqBMBRkcXkxZ < byteCount - 1) {
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
                foreach (SomeEnum enumValue in o.SomeEnumListValue) {
                bytes[index++] = enumValueIndexMap["SomeEnum"][enumValue.ToString()];
;
                }
            }
        }
        public void Energize(EnumMapObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 13;
            }
                // MAP: IntSomeEnumMapValue
            if (o.IntSomeEnumMapValue.Keys == null || o.IntSomeEnumMapValue.Keys.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.IntSomeEnumMapValue.Keys.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.IntSomeEnumMapValue.Keys.Count;
                int i_sTCzQSgMuxqV;
                for (i_sTCzQSgMuxqV = 0; i_sTCzQSgMuxqV < 2; i_sTCzQSgMuxqV++) {
                    if ((ulong)o.IntSomeEnumMapValue.Keys.Count < vuBoundaries[i_sTCzQSgMuxqV]) {
                       byteCount = (int)(i_sTCzQSgMuxqV + 1);
                       goto guvsgoto_gV6WJwNbFRIc;
                    }
                }
                byteCount = (int)i_sTCzQSgMuxqV + 1;
                guvsgoto_gV6WJwNbFRIc:
                    for (int i_dBUwiwjU5gsY = 0; i_dBUwiwjU5gsY < byteCount; i_dBUwiwjU5gsY++) {
                        if (i_dBUwiwjU5gsY < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_dBUwiwjU5gsY < byteCount - 1) {
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
                foreach (int primitive in o.IntSomeEnumMapValue.Keys) {
                bytes[index++] = (byte)((primitive >> 24) & 255);
                bytes[index++] = (byte)((primitive >> 16) & 255);
                bytes[index++] = (byte)((primitive >> 8) & 255);
                bytes[index++] = (byte)(primitive & 255);
                }
            }
            if (o.IntSomeEnumMapValue.Values == null || o.IntSomeEnumMapValue.Values.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.IntSomeEnumMapValue.Values.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.IntSomeEnumMapValue.Values.Count;
                int i_gVwedVF2EkOi;
                for (i_gVwedVF2EkOi = 0; i_gVwedVF2EkOi < 2; i_gVwedVF2EkOi++) {
                    if ((ulong)o.IntSomeEnumMapValue.Values.Count < vuBoundaries[i_gVwedVF2EkOi]) {
                       byteCount = (int)(i_gVwedVF2EkOi + 1);
                       goto guvsgoto_sHuZ2EbJSy4S;
                    }
                }
                byteCount = (int)i_gVwedVF2EkOi + 1;
                guvsgoto_sHuZ2EbJSy4S:
                    for (int i_pq2jHXhLAORi = 0; i_pq2jHXhLAORi < byteCount; i_pq2jHXhLAORi++) {
                        if (i_pq2jHXhLAORi < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_pq2jHXhLAORi < byteCount - 1) {
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
                foreach (SomeEnum enumValue in o.IntSomeEnumMapValue.Values) {
                bytes[index++] = enumValueIndexMap["SomeEnum"][enumValue.ToString()];
;
                }
            }
        }
        public void Energize(EnumMap2Object o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 14;
            }
                // MAP: SomeEnumIntMapValue
            if (o.SomeEnumIntMapValue.Keys == null || o.SomeEnumIntMapValue.Keys.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.SomeEnumIntMapValue.Keys.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.SomeEnumIntMapValue.Keys.Count;
                int i_zfRkLAtH2lnM;
                for (i_zfRkLAtH2lnM = 0; i_zfRkLAtH2lnM < 2; i_zfRkLAtH2lnM++) {
                    if ((ulong)o.SomeEnumIntMapValue.Keys.Count < vuBoundaries[i_zfRkLAtH2lnM]) {
                       byteCount = (int)(i_zfRkLAtH2lnM + 1);
                       goto guvsgoto_krT0wQdTGbhx;
                    }
                }
                byteCount = (int)i_zfRkLAtH2lnM + 1;
                guvsgoto_krT0wQdTGbhx:
                    for (int i_p2c5rtsKdnQW = 0; i_p2c5rtsKdnQW < byteCount; i_p2c5rtsKdnQW++) {
                        if (i_p2c5rtsKdnQW < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_p2c5rtsKdnQW < byteCount - 1) {
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
                foreach (SomeEnum enumValue in o.SomeEnumIntMapValue.Keys) {
                bytes[index++] = enumValueIndexMap["SomeEnum"][enumValue.ToString()];
;
                }
            }
            if (o.SomeEnumIntMapValue.Values == null || o.SomeEnumIntMapValue.Values.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.SomeEnumIntMapValue.Values.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.SomeEnumIntMapValue.Values.Count;
                int i_c799vjqmdhoE;
                for (i_c799vjqmdhoE = 0; i_c799vjqmdhoE < 2; i_c799vjqmdhoE++) {
                    if ((ulong)o.SomeEnumIntMapValue.Values.Count < vuBoundaries[i_c799vjqmdhoE]) {
                       byteCount = (int)(i_c799vjqmdhoE + 1);
                       goto guvsgoto_aOGXg4LJiFjC;
                    }
                }
                byteCount = (int)i_c799vjqmdhoE + 1;
                guvsgoto_aOGXg4LJiFjC:
                    for (int i_rhBnTHtVy4i6 = 0; i_rhBnTHtVy4i6 < byteCount; i_rhBnTHtVy4i6++) {
                        if (i_rhBnTHtVy4i6 < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_rhBnTHtVy4i6 < byteCount - 1) {
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
                foreach (int primitive in o.SomeEnumIntMapValue.Values) {
                bytes[index++] = (byte)((primitive >> 24) & 255);
                bytes[index++] = (byte)((primitive >> 16) & 255);
                bytes[index++] = (byte)((primitive >> 8) & 255);
                bytes[index++] = (byte)(primitive & 255);
                }
            }
        }
        public void Energize(EnumSetObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 15;
            }
                // SET: SomeEnumSetValue
            if (o.SomeEnumSetValue == null || o.SomeEnumSetValue.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.SomeEnumSetValue.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.SomeEnumSetValue.Count;
                int i_isp47ET4Aci8;
                for (i_isp47ET4Aci8 = 0; i_isp47ET4Aci8 < 2; i_isp47ET4Aci8++) {
                    if ((ulong)o.SomeEnumSetValue.Count < vuBoundaries[i_isp47ET4Aci8]) {
                       byteCount = (int)(i_isp47ET4Aci8 + 1);
                       goto guvsgoto_xFB7KNDgSJZu;
                    }
                }
                byteCount = (int)i_isp47ET4Aci8 + 1;
                guvsgoto_xFB7KNDgSJZu:
                    for (int i_mx0LmxelYdgZ = 0; i_mx0LmxelYdgZ < byteCount; i_mx0LmxelYdgZ++) {
                        if (i_mx0LmxelYdgZ < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_mx0LmxelYdgZ < byteCount - 1) {
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
                foreach (SomeEnum enumValue in o.SomeEnumSetValue) {
                bytes[index++] = enumValueIndexMap["SomeEnum"][enumValue.ToString()];
;
                }
            }
        }
        public void Energize(IEnumTestObject o, byte[] bytes, ref int index, bool writeTypeId) {
            switch (o.TypeId) {
                case 11:
                    Energize((EnumObject)o, bytes, ref index, writeTypeId);
                    break;
                case 12:
                    Energize((EnumListObject)o, bytes, ref index, writeTypeId);
                    break;
                case 13:
                    Energize((EnumMapObject)o, bytes, ref index, writeTypeId);
                    break;
                case 14:
                    Energize((EnumMap2Object)o, bytes, ref index, writeTypeId);
                    break;
                case 15:
                    Energize((EnumSetObject)o, bytes, ref index, writeTypeId);
                    break;
                default:
                    throw new EnumTestPatternBufferException("Unrecognized type ID: "+o.TypeId+" ");
            }
        }
///////////////////////////////////////
// FROM BYTES
///////////////////////////////////////
        public object Energize(byte[] bytes) {
            int index = 0;
                    ulong vuread_ssMzNiVfsh4B = 0;
                    for (int i_hyY4loF1xCEm = 0; i_hyY4loF1xCEm < 9; i_hyY4loF1xCEm++) {
                        byte b = bytes[index++];
                        if (i_hyY4loF1xCEm < 8) {
                            vuread_ssMzNiVfsh4B += (((ulong)b & (ulong)127) << (7 * i_hyY4loF1xCEm));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_ssMzNiVfsh4B += (ulong)b << (7 * i_hyY4loF1xCEm);
                            break;
                        }
                    }
                    ushort typeId = (ushort)vuread_ssMzNiVfsh4B;
            switch (typeId) {
            case 11:
                {
                EnumObject o = new EnumObject();
                // REFERENCE: SomeEnumValue
                byte enumValue_u23uFOFqmAlP;
                enumValue_u23uFOFqmAlP = bytes[index++];
                o.SomeEnumValue = (SomeEnum)System.Enum.Parse(typeof(SomeEnum), enumIndexValueMap["SomeEnum"][enumValue_u23uFOFqmAlP]);
                    return o;
                }
            case 12:
                {
                EnumListObject o = new EnumListObject();
                // LIST: SomeEnumListValue
            // Read list item count
            ushort count_wtrsqcQvDytX;
                    ulong vuread_oj9KHoBqXzMU = 0;
                    for (int i_gAKOMNp1nic2 = 0; i_gAKOMNp1nic2 < 9; i_gAKOMNp1nic2++) {
                        byte b = bytes[index++];
                        if (i_gAKOMNp1nic2 < 8) {
                            vuread_oj9KHoBqXzMU += (((ulong)b & (ulong)127) << (7 * i_gAKOMNp1nic2));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_oj9KHoBqXzMU += (ulong)b << (7 * i_gAKOMNp1nic2);
                            break;
                        }
                    }
                    count_wtrsqcQvDytX = (ushort)vuread_oj9KHoBqXzMU;
            // Read list items
            if (count_wtrsqcQvDytX > 0) {
                o.SomeEnumListValue = new List<SomeEnum>();
                for (int i_ynLuWjSzIgVv = 0; i_ynLuWjSzIgVv < count_wtrsqcQvDytX; i_ynLuWjSzIgVv++) {
                    o.SomeEnumListValue.Add((SomeEnum)System.Enum.Parse(typeof(SomeEnum), enumIndexValueMap["SomeEnum"][bytes[index++]]));
                }
            }
                    return o;
                }
            case 13:
                {
                EnumMapObject o = new EnumMapObject();
                // MAP: IntSomeEnumMapValue
                IList<int> intSomeEnumMapValueKeys = new List<int>();
                IList<SomeEnum> intSomeEnumMapValueValues = new List<SomeEnum>();
            // Read list item count
            ushort count_r4T7852CQGdZ;
                    ulong vuread_lcT0iBKAhhNt = 0;
                    for (int i_qhENQmliPo9R = 0; i_qhENQmliPo9R < 9; i_qhENQmliPo9R++) {
                        byte b = bytes[index++];
                        if (i_qhENQmliPo9R < 8) {
                            vuread_lcT0iBKAhhNt += (((ulong)b & (ulong)127) << (7 * i_qhENQmliPo9R));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_lcT0iBKAhhNt += (ulong)b << (7 * i_qhENQmliPo9R);
                            break;
                        }
                    }
                    count_r4T7852CQGdZ = (ushort)vuread_lcT0iBKAhhNt;
            // Read list items
            if (count_r4T7852CQGdZ > 0) {
                intSomeEnumMapValueKeys = new List<int>();
                int listValue_xr3rqJlAkV2U;
                for (int i_l2qhFvoHrAu0 = 0; i_l2qhFvoHrAu0 < count_r4T7852CQGdZ; i_l2qhFvoHrAu0++) {
                    // Read Int list item
                listValue_xr3rqJlAkV2U =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    intSomeEnumMapValueKeys.Add(listValue_xr3rqJlAkV2U);
                }
            }
            // Read list item count
            ushort count_loVDu5kncb50;
                    ulong vuread_otjH5mi1pTnX = 0;
                    for (int i_yeMuaCzE7cZb = 0; i_yeMuaCzE7cZb < 9; i_yeMuaCzE7cZb++) {
                        byte b = bytes[index++];
                        if (i_yeMuaCzE7cZb < 8) {
                            vuread_otjH5mi1pTnX += (((ulong)b & (ulong)127) << (7 * i_yeMuaCzE7cZb));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_otjH5mi1pTnX += (ulong)b << (7 * i_yeMuaCzE7cZb);
                            break;
                        }
                    }
                    count_loVDu5kncb50 = (ushort)vuread_otjH5mi1pTnX;
            // Read list items
            if (count_loVDu5kncb50 > 0) {
                intSomeEnumMapValueValues = new List<SomeEnum>();
                for (int i_vRfpLORy7AJm = 0; i_vRfpLORy7AJm < count_loVDu5kncb50; i_vRfpLORy7AJm++) {
                    intSomeEnumMapValueValues.Add((SomeEnum)System.Enum.Parse(typeof(SomeEnum), enumIndexValueMap["SomeEnum"][bytes[index++]]));
                }
            }
                o.IntSomeEnumMapValue = new Dictionary<int,SomeEnum>(intSomeEnumMapValueKeys.Count);
                for (int i_eRLerCLRb7Hq = 0; i_eRLerCLRb7Hq < intSomeEnumMapValueKeys.Count; i_eRLerCLRb7Hq++) {
                    o.IntSomeEnumMapValue[intSomeEnumMapValueKeys[i_eRLerCLRb7Hq]] = intSomeEnumMapValueValues[i_eRLerCLRb7Hq];
                }
                    return o;
                }
            case 14:
                {
                EnumMap2Object o = new EnumMap2Object();
                // MAP: SomeEnumIntMapValue
                IList<SomeEnum> someEnumIntMapValueKeys = new List<SomeEnum>();
                IList<int> someEnumIntMapValueValues = new List<int>();
            // Read list item count
            ushort count_hZnKMB3FDiSo;
                    ulong vuread_c3qKcZ0GFzjt = 0;
                    for (int i_wvnEBha0jZ6V = 0; i_wvnEBha0jZ6V < 9; i_wvnEBha0jZ6V++) {
                        byte b = bytes[index++];
                        if (i_wvnEBha0jZ6V < 8) {
                            vuread_c3qKcZ0GFzjt += (((ulong)b & (ulong)127) << (7 * i_wvnEBha0jZ6V));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_c3qKcZ0GFzjt += (ulong)b << (7 * i_wvnEBha0jZ6V);
                            break;
                        }
                    }
                    count_hZnKMB3FDiSo = (ushort)vuread_c3qKcZ0GFzjt;
            // Read list items
            if (count_hZnKMB3FDiSo > 0) {
                someEnumIntMapValueKeys = new List<SomeEnum>();
                for (int i_lhWFHdTc8x7x = 0; i_lhWFHdTc8x7x < count_hZnKMB3FDiSo; i_lhWFHdTc8x7x++) {
                    someEnumIntMapValueKeys.Add((SomeEnum)System.Enum.Parse(typeof(SomeEnum), enumIndexValueMap["SomeEnum"][bytes[index++]]));
                }
            }
            // Read list item count
            ushort count_faPmgbV3Q3Tq;
                    ulong vuread_fyevh2er7Fj4 = 0;
                    for (int i_bv9BPguDy0tA = 0; i_bv9BPguDy0tA < 9; i_bv9BPguDy0tA++) {
                        byte b = bytes[index++];
                        if (i_bv9BPguDy0tA < 8) {
                            vuread_fyevh2er7Fj4 += (((ulong)b & (ulong)127) << (7 * i_bv9BPguDy0tA));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_fyevh2er7Fj4 += (ulong)b << (7 * i_bv9BPguDy0tA);
                            break;
                        }
                    }
                    count_faPmgbV3Q3Tq = (ushort)vuread_fyevh2er7Fj4;
            // Read list items
            if (count_faPmgbV3Q3Tq > 0) {
                someEnumIntMapValueValues = new List<int>();
                int listValue_lYTieceHyFri;
                for (int i_zx5gtPzQ1UjV = 0; i_zx5gtPzQ1UjV < count_faPmgbV3Q3Tq; i_zx5gtPzQ1UjV++) {
                    // Read Int list item
                listValue_lYTieceHyFri =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    someEnumIntMapValueValues.Add(listValue_lYTieceHyFri);
                }
            }
                o.SomeEnumIntMapValue = new Dictionary<SomeEnum,int>(someEnumIntMapValueKeys.Count);
                for (int i_atnKJp2xfO3t = 0; i_atnKJp2xfO3t < someEnumIntMapValueKeys.Count; i_atnKJp2xfO3t++) {
                    o.SomeEnumIntMapValue[someEnumIntMapValueKeys[i_atnKJp2xfO3t]] = someEnumIntMapValueValues[i_atnKJp2xfO3t];
                }
                    return o;
                }
            case 15:
                {
                EnumSetObject o = new EnumSetObject();
                // SET: SomeEnumSetValue
            // Read list item count
            ushort count_d5n5ALGHd0Br;
                    ulong vuread_eokSBMISO8gU = 0;
                    for (int i_vE8iN3dvEL7x = 0; i_vE8iN3dvEL7x < 9; i_vE8iN3dvEL7x++) {
                        byte b = bytes[index++];
                        if (i_vE8iN3dvEL7x < 8) {
                            vuread_eokSBMISO8gU += (((ulong)b & (ulong)127) << (7 * i_vE8iN3dvEL7x));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_eokSBMISO8gU += (ulong)b << (7 * i_vE8iN3dvEL7x);
                            break;
                        }
                    }
                    count_d5n5ALGHd0Br = (ushort)vuread_eokSBMISO8gU;
            // Read list items
            if (count_d5n5ALGHd0Br > 0) {
                o.SomeEnumSetValue = new HashSet<SomeEnum>();
                for (int i_mDqqnMRl26zu = 0; i_mDqqnMRl26zu < count_d5n5ALGHd0Br; i_mDqqnMRl26zu++) {
                    o.SomeEnumSetValue.Add((SomeEnum)System.Enum.Parse(typeof(SomeEnum), enumIndexValueMap["SomeEnum"][bytes[index++]]));
                }
            }
                    return o;
                }
                default:
                    throw new EnumTestPatternBufferException("Unrecognized type ID: "+typeId+" ");
            }
        }
        public object Energize(byte[] bytes, ref int index) {
                    ulong vuread_ck6CfkPkZCh5 = 0;
                    for (int i_qy4kWgWJrWp7 = 0; i_qy4kWgWJrWp7 < 9; i_qy4kWgWJrWp7++) {
                        byte b = bytes[index++];
                        if (i_qy4kWgWJrWp7 < 8) {
                            vuread_ck6CfkPkZCh5 += (((ulong)b & (ulong)127) << (7 * i_qy4kWgWJrWp7));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_ck6CfkPkZCh5 += (ulong)b << (7 * i_qy4kWgWJrWp7);
                            break;
                        }
                    }
                    ushort typeId = (ushort)vuread_ck6CfkPkZCh5;
            switch (typeId) {
            case 11:
                {
                EnumObject o = new EnumObject();
                // REFERENCE: SomeEnumValue
                byte enumValue_jsEcq422fNcC;
                enumValue_jsEcq422fNcC = bytes[index++];
                o.SomeEnumValue = (SomeEnum)System.Enum.Parse(typeof(SomeEnum), enumIndexValueMap["SomeEnum"][enumValue_jsEcq422fNcC]);
                    return o;
                }
            case 12:
                {
                EnumListObject o = new EnumListObject();
                // LIST: SomeEnumListValue
            // Read list item count
            ushort count_yLpu6WI9wuMZ;
                    ulong vuread_sHzWjZdt49gX = 0;
                    for (int i_rM44Ko0avBnl = 0; i_rM44Ko0avBnl < 9; i_rM44Ko0avBnl++) {
                        byte b = bytes[index++];
                        if (i_rM44Ko0avBnl < 8) {
                            vuread_sHzWjZdt49gX += (((ulong)b & (ulong)127) << (7 * i_rM44Ko0avBnl));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_sHzWjZdt49gX += (ulong)b << (7 * i_rM44Ko0avBnl);
                            break;
                        }
                    }
                    count_yLpu6WI9wuMZ = (ushort)vuread_sHzWjZdt49gX;
            // Read list items
            if (count_yLpu6WI9wuMZ > 0) {
                o.SomeEnumListValue = new List<SomeEnum>();
                for (int i_vCNEopLaPOuT = 0; i_vCNEopLaPOuT < count_yLpu6WI9wuMZ; i_vCNEopLaPOuT++) {
                    o.SomeEnumListValue.Add((SomeEnum)System.Enum.Parse(typeof(SomeEnum), enumIndexValueMap["SomeEnum"][bytes[index++]]));
                }
            }
                    return o;
                }
            case 13:
                {
                EnumMapObject o = new EnumMapObject();
                // MAP: IntSomeEnumMapValue
                IList<int> intSomeEnumMapValueKeys = new List<int>();
                IList<SomeEnum> intSomeEnumMapValueValues = new List<SomeEnum>();
            // Read list item count
            ushort count_mfTqJTI7ECNt;
                    ulong vuread_wNzhEMDqto6Q = 0;
                    for (int i_fIfOyghbskAE = 0; i_fIfOyghbskAE < 9; i_fIfOyghbskAE++) {
                        byte b = bytes[index++];
                        if (i_fIfOyghbskAE < 8) {
                            vuread_wNzhEMDqto6Q += (((ulong)b & (ulong)127) << (7 * i_fIfOyghbskAE));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_wNzhEMDqto6Q += (ulong)b << (7 * i_fIfOyghbskAE);
                            break;
                        }
                    }
                    count_mfTqJTI7ECNt = (ushort)vuread_wNzhEMDqto6Q;
            // Read list items
            if (count_mfTqJTI7ECNt > 0) {
                intSomeEnumMapValueKeys = new List<int>();
                int listValue_nJAM3qRxZtMK;
                for (int i_vDGcldAqjcdb = 0; i_vDGcldAqjcdb < count_mfTqJTI7ECNt; i_vDGcldAqjcdb++) {
                    // Read Int list item
                listValue_nJAM3qRxZtMK =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    intSomeEnumMapValueKeys.Add(listValue_nJAM3qRxZtMK);
                }
            }
            // Read list item count
            ushort count_q3JyuLbRn4M4;
                    ulong vuread_f0xdHI026EY4 = 0;
                    for (int i_pe0oUjuCGz89 = 0; i_pe0oUjuCGz89 < 9; i_pe0oUjuCGz89++) {
                        byte b = bytes[index++];
                        if (i_pe0oUjuCGz89 < 8) {
                            vuread_f0xdHI026EY4 += (((ulong)b & (ulong)127) << (7 * i_pe0oUjuCGz89));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_f0xdHI026EY4 += (ulong)b << (7 * i_pe0oUjuCGz89);
                            break;
                        }
                    }
                    count_q3JyuLbRn4M4 = (ushort)vuread_f0xdHI026EY4;
            // Read list items
            if (count_q3JyuLbRn4M4 > 0) {
                intSomeEnumMapValueValues = new List<SomeEnum>();
                for (int i_sscnr4w50L0u = 0; i_sscnr4w50L0u < count_q3JyuLbRn4M4; i_sscnr4w50L0u++) {
                    intSomeEnumMapValueValues.Add((SomeEnum)System.Enum.Parse(typeof(SomeEnum), enumIndexValueMap["SomeEnum"][bytes[index++]]));
                }
            }
                o.IntSomeEnumMapValue = new Dictionary<int,SomeEnum>(intSomeEnumMapValueKeys.Count);
                for (int i_rwSLlkfjeOYp = 0; i_rwSLlkfjeOYp < intSomeEnumMapValueKeys.Count; i_rwSLlkfjeOYp++) {
                    o.IntSomeEnumMapValue[intSomeEnumMapValueKeys[i_rwSLlkfjeOYp]] = intSomeEnumMapValueValues[i_rwSLlkfjeOYp];
                }
                    return o;
                }
            case 14:
                {
                EnumMap2Object o = new EnumMap2Object();
                // MAP: SomeEnumIntMapValue
                IList<SomeEnum> someEnumIntMapValueKeys = new List<SomeEnum>();
                IList<int> someEnumIntMapValueValues = new List<int>();
            // Read list item count
            ushort count_tX7dJjyX1xwo;
                    ulong vuread_nNLbh2d8oFHx = 0;
                    for (int i_lTqvuZ4cEWCE = 0; i_lTqvuZ4cEWCE < 9; i_lTqvuZ4cEWCE++) {
                        byte b = bytes[index++];
                        if (i_lTqvuZ4cEWCE < 8) {
                            vuread_nNLbh2d8oFHx += (((ulong)b & (ulong)127) << (7 * i_lTqvuZ4cEWCE));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_nNLbh2d8oFHx += (ulong)b << (7 * i_lTqvuZ4cEWCE);
                            break;
                        }
                    }
                    count_tX7dJjyX1xwo = (ushort)vuread_nNLbh2d8oFHx;
            // Read list items
            if (count_tX7dJjyX1xwo > 0) {
                someEnumIntMapValueKeys = new List<SomeEnum>();
                for (int i_ytwQmcDsaEfI = 0; i_ytwQmcDsaEfI < count_tX7dJjyX1xwo; i_ytwQmcDsaEfI++) {
                    someEnumIntMapValueKeys.Add((SomeEnum)System.Enum.Parse(typeof(SomeEnum), enumIndexValueMap["SomeEnum"][bytes[index++]]));
                }
            }
            // Read list item count
            ushort count_odbmKZbqpJN0;
                    ulong vuread_xdDcCtTTlheY = 0;
                    for (int i_nxWlbpw6ORWq = 0; i_nxWlbpw6ORWq < 9; i_nxWlbpw6ORWq++) {
                        byte b = bytes[index++];
                        if (i_nxWlbpw6ORWq < 8) {
                            vuread_xdDcCtTTlheY += (((ulong)b & (ulong)127) << (7 * i_nxWlbpw6ORWq));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_xdDcCtTTlheY += (ulong)b << (7 * i_nxWlbpw6ORWq);
                            break;
                        }
                    }
                    count_odbmKZbqpJN0 = (ushort)vuread_xdDcCtTTlheY;
            // Read list items
            if (count_odbmKZbqpJN0 > 0) {
                someEnumIntMapValueValues = new List<int>();
                int listValue_uSCPVloxQFXj;
                for (int i_oB0RUvxB8mPn = 0; i_oB0RUvxB8mPn < count_odbmKZbqpJN0; i_oB0RUvxB8mPn++) {
                    // Read Int list item
                listValue_uSCPVloxQFXj =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    someEnumIntMapValueValues.Add(listValue_uSCPVloxQFXj);
                }
            }
                o.SomeEnumIntMapValue = new Dictionary<SomeEnum,int>(someEnumIntMapValueKeys.Count);
                for (int i_bZoanQllrmoT = 0; i_bZoanQllrmoT < someEnumIntMapValueKeys.Count; i_bZoanQllrmoT++) {
                    o.SomeEnumIntMapValue[someEnumIntMapValueKeys[i_bZoanQllrmoT]] = someEnumIntMapValueValues[i_bZoanQllrmoT];
                }
                    return o;
                }
            case 15:
                {
                EnumSetObject o = new EnumSetObject();
                // SET: SomeEnumSetValue
            // Read list item count
            ushort count_we792RiaJMMK;
                    ulong vuread_kPlsuusLdpL6 = 0;
                    for (int i_yok9uL2wng0P = 0; i_yok9uL2wng0P < 9; i_yok9uL2wng0P++) {
                        byte b = bytes[index++];
                        if (i_yok9uL2wng0P < 8) {
                            vuread_kPlsuusLdpL6 += (((ulong)b & (ulong)127) << (7 * i_yok9uL2wng0P));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_kPlsuusLdpL6 += (ulong)b << (7 * i_yok9uL2wng0P);
                            break;
                        }
                    }
                    count_we792RiaJMMK = (ushort)vuread_kPlsuusLdpL6;
            // Read list items
            if (count_we792RiaJMMK > 0) {
                o.SomeEnumSetValue = new HashSet<SomeEnum>();
                for (int i_kxJreONAmNLH = 0; i_kxJreONAmNLH < count_we792RiaJMMK; i_kxJreONAmNLH++) {
                    o.SomeEnumSetValue.Add((SomeEnum)System.Enum.Parse(typeof(SomeEnum), enumIndexValueMap["SomeEnum"][bytes[index++]]));
                }
            }
                    return o;
                }
                default:
                    throw new EnumTestPatternBufferException("Unrecognized type ID: "+typeId+" ");
            }
        }
        public object Energize(byte[] bytes, ref int index, ushort typeId) {
            switch (typeId) {
            case 11:
                {
                EnumObject o = new EnumObject();
                // REFERENCE: SomeEnumValue
                byte enumValue_m3174NQLCbcO;
                enumValue_m3174NQLCbcO = bytes[index++];
                o.SomeEnumValue = (SomeEnum)System.Enum.Parse(typeof(SomeEnum), enumIndexValueMap["SomeEnum"][enumValue_m3174NQLCbcO]);
                    return o;
                }
            case 12:
                {
                EnumListObject o = new EnumListObject();
                // LIST: SomeEnumListValue
            // Read list item count
            ushort count_ojQ7UpxsYG46;
                    ulong vuread_taGyLlTtMMEA = 0;
                    for (int i_t5CJAomwv4T5 = 0; i_t5CJAomwv4T5 < 9; i_t5CJAomwv4T5++) {
                        byte b = bytes[index++];
                        if (i_t5CJAomwv4T5 < 8) {
                            vuread_taGyLlTtMMEA += (((ulong)b & (ulong)127) << (7 * i_t5CJAomwv4T5));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_taGyLlTtMMEA += (ulong)b << (7 * i_t5CJAomwv4T5);
                            break;
                        }
                    }
                    count_ojQ7UpxsYG46 = (ushort)vuread_taGyLlTtMMEA;
            // Read list items
            if (count_ojQ7UpxsYG46 > 0) {
                o.SomeEnumListValue = new List<SomeEnum>();
                for (int i_zQP7qtS884m3 = 0; i_zQP7qtS884m3 < count_ojQ7UpxsYG46; i_zQP7qtS884m3++) {
                    o.SomeEnumListValue.Add((SomeEnum)System.Enum.Parse(typeof(SomeEnum), enumIndexValueMap["SomeEnum"][bytes[index++]]));
                }
            }
                    return o;
                }
            case 13:
                {
                EnumMapObject o = new EnumMapObject();
                // MAP: IntSomeEnumMapValue
                IList<int> intSomeEnumMapValueKeys = new List<int>();
                IList<SomeEnum> intSomeEnumMapValueValues = new List<SomeEnum>();
            // Read list item count
            ushort count_crarsTc5OpmZ;
                    ulong vuread_uX2KtIL0rLA5 = 0;
                    for (int i_nWdt3FB0SIDi = 0; i_nWdt3FB0SIDi < 9; i_nWdt3FB0SIDi++) {
                        byte b = bytes[index++];
                        if (i_nWdt3FB0SIDi < 8) {
                            vuread_uX2KtIL0rLA5 += (((ulong)b & (ulong)127) << (7 * i_nWdt3FB0SIDi));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_uX2KtIL0rLA5 += (ulong)b << (7 * i_nWdt3FB0SIDi);
                            break;
                        }
                    }
                    count_crarsTc5OpmZ = (ushort)vuread_uX2KtIL0rLA5;
            // Read list items
            if (count_crarsTc5OpmZ > 0) {
                intSomeEnumMapValueKeys = new List<int>();
                int listValue_g5dM1YqSDZjC;
                for (int i_liOAsvMF0eVF = 0; i_liOAsvMF0eVF < count_crarsTc5OpmZ; i_liOAsvMF0eVF++) {
                    // Read Int list item
                listValue_g5dM1YqSDZjC =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    intSomeEnumMapValueKeys.Add(listValue_g5dM1YqSDZjC);
                }
            }
            // Read list item count
            ushort count_rSbjYwgpuTvy;
                    ulong vuread_m98CvSBQNK2V = 0;
                    for (int i_wbHx58rjjI6i = 0; i_wbHx58rjjI6i < 9; i_wbHx58rjjI6i++) {
                        byte b = bytes[index++];
                        if (i_wbHx58rjjI6i < 8) {
                            vuread_m98CvSBQNK2V += (((ulong)b & (ulong)127) << (7 * i_wbHx58rjjI6i));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_m98CvSBQNK2V += (ulong)b << (7 * i_wbHx58rjjI6i);
                            break;
                        }
                    }
                    count_rSbjYwgpuTvy = (ushort)vuread_m98CvSBQNK2V;
            // Read list items
            if (count_rSbjYwgpuTvy > 0) {
                intSomeEnumMapValueValues = new List<SomeEnum>();
                for (int i_uh3hS4iQXq6t = 0; i_uh3hS4iQXq6t < count_rSbjYwgpuTvy; i_uh3hS4iQXq6t++) {
                    intSomeEnumMapValueValues.Add((SomeEnum)System.Enum.Parse(typeof(SomeEnum), enumIndexValueMap["SomeEnum"][bytes[index++]]));
                }
            }
                o.IntSomeEnumMapValue = new Dictionary<int,SomeEnum>(intSomeEnumMapValueKeys.Count);
                for (int i_jjjiMf2f0psX = 0; i_jjjiMf2f0psX < intSomeEnumMapValueKeys.Count; i_jjjiMf2f0psX++) {
                    o.IntSomeEnumMapValue[intSomeEnumMapValueKeys[i_jjjiMf2f0psX]] = intSomeEnumMapValueValues[i_jjjiMf2f0psX];
                }
                    return o;
                }
            case 14:
                {
                EnumMap2Object o = new EnumMap2Object();
                // MAP: SomeEnumIntMapValue
                IList<SomeEnum> someEnumIntMapValueKeys = new List<SomeEnum>();
                IList<int> someEnumIntMapValueValues = new List<int>();
            // Read list item count
            ushort count_vTtvClo6dZPo;
                    ulong vuread_vu7SCl8KeobW = 0;
                    for (int i_vjGeP0sHZgs9 = 0; i_vjGeP0sHZgs9 < 9; i_vjGeP0sHZgs9++) {
                        byte b = bytes[index++];
                        if (i_vjGeP0sHZgs9 < 8) {
                            vuread_vu7SCl8KeobW += (((ulong)b & (ulong)127) << (7 * i_vjGeP0sHZgs9));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_vu7SCl8KeobW += (ulong)b << (7 * i_vjGeP0sHZgs9);
                            break;
                        }
                    }
                    count_vTtvClo6dZPo = (ushort)vuread_vu7SCl8KeobW;
            // Read list items
            if (count_vTtvClo6dZPo > 0) {
                someEnumIntMapValueKeys = new List<SomeEnum>();
                for (int i_pWoLbaqGE5ts = 0; i_pWoLbaqGE5ts < count_vTtvClo6dZPo; i_pWoLbaqGE5ts++) {
                    someEnumIntMapValueKeys.Add((SomeEnum)System.Enum.Parse(typeof(SomeEnum), enumIndexValueMap["SomeEnum"][bytes[index++]]));
                }
            }
            // Read list item count
            ushort count_djNOrRSJRHHs;
                    ulong vuread_rjqmHhzRc7iP = 0;
                    for (int i_ywJe8Er20o7F = 0; i_ywJe8Er20o7F < 9; i_ywJe8Er20o7F++) {
                        byte b = bytes[index++];
                        if (i_ywJe8Er20o7F < 8) {
                            vuread_rjqmHhzRc7iP += (((ulong)b & (ulong)127) << (7 * i_ywJe8Er20o7F));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_rjqmHhzRc7iP += (ulong)b << (7 * i_ywJe8Er20o7F);
                            break;
                        }
                    }
                    count_djNOrRSJRHHs = (ushort)vuread_rjqmHhzRc7iP;
            // Read list items
            if (count_djNOrRSJRHHs > 0) {
                someEnumIntMapValueValues = new List<int>();
                int listValue_fOphySsdp661;
                for (int i_td9wGLpkb7R4 = 0; i_td9wGLpkb7R4 < count_djNOrRSJRHHs; i_td9wGLpkb7R4++) {
                    // Read Int list item
                listValue_fOphySsdp661 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    someEnumIntMapValueValues.Add(listValue_fOphySsdp661);
                }
            }
                o.SomeEnumIntMapValue = new Dictionary<SomeEnum,int>(someEnumIntMapValueKeys.Count);
                for (int i_dOLmpOCAmV82 = 0; i_dOLmpOCAmV82 < someEnumIntMapValueKeys.Count; i_dOLmpOCAmV82++) {
                    o.SomeEnumIntMapValue[someEnumIntMapValueKeys[i_dOLmpOCAmV82]] = someEnumIntMapValueValues[i_dOLmpOCAmV82];
                }
                    return o;
                }
            case 15:
                {
                EnumSetObject o = new EnumSetObject();
                // SET: SomeEnumSetValue
            // Read list item count
            ushort count_wrttPeAaARu4;
                    ulong vuread_n4wo8WDq7v9T = 0;
                    for (int i_dfXLEFP7egFp = 0; i_dfXLEFP7egFp < 9; i_dfXLEFP7egFp++) {
                        byte b = bytes[index++];
                        if (i_dfXLEFP7egFp < 8) {
                            vuread_n4wo8WDq7v9T += (((ulong)b & (ulong)127) << (7 * i_dfXLEFP7egFp));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_n4wo8WDq7v9T += (ulong)b << (7 * i_dfXLEFP7egFp);
                            break;
                        }
                    }
                    count_wrttPeAaARu4 = (ushort)vuread_n4wo8WDq7v9T;
            // Read list items
            if (count_wrttPeAaARu4 > 0) {
                o.SomeEnumSetValue = new HashSet<SomeEnum>();
                for (int i_h6E6GQEAtQRv = 0; i_h6E6GQEAtQRv < count_wrttPeAaARu4; i_h6E6GQEAtQRv++) {
                    o.SomeEnumSetValue.Add((SomeEnum)System.Enum.Parse(typeof(SomeEnum), enumIndexValueMap["SomeEnum"][bytes[index++]]));
                }
            }
                    return o;
                }
                default:
                    throw new EnumTestPatternBufferException("Unrecognized type ID: "+typeId+" ");
            }
        }
///////////////////////////////////////
// FROM BYTES (TYPED)
///////////////////////////////////////
        public TYPE Energize< TYPE > (byte[] bytes) {
            object o = this.Energize(bytes);
            if (!(o is TYPE)) {
                throw new EnumTestPatternBufferException("Deserialized type (" + o.GetType().Name + ") does not match expected type (" + typeof(TYPE).Name + ").");
            }
            return (TYPE)o;
        }
    }
}
