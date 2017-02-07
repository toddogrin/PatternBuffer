
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System.Text;
using System;
using System.Collections.Generic;

namespace Test.List {
    public class ListTestPatternBuffer {
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
        private byte[] bytes;
        public ListTestPatternBuffer() : this(4096) { }
        public ListTestPatternBuffer(uint bufferSize) {
            this.bytes = new byte[bufferSize];
        }
///////////////////////////////////////
// TO BYTES
///////////////////////////////////////
        public byte[] Energize(AbstractThing o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(Thing1 o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(Thing2 o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(IntListObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(StringListObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(Thing1ListObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(AbstractThingListObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(VIntListObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public void Energize(AbstractThing o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 9;
            }
                // PRIMITIVE: IntValue1
                bytes[index++] = (byte)((o.IntValue1 >> 24) & 255);
                bytes[index++] = (byte)((o.IntValue1 >> 16) & 255);
                bytes[index++] = (byte)((o.IntValue1 >> 8) & 255);
                bytes[index++] = (byte)(o.IntValue1 & 255);
        }
        public void Energize(Thing1 o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 10;
            }
                // PRIMITIVE: IntValue1
                bytes[index++] = (byte)((o.IntValue1 >> 24) & 255);
                bytes[index++] = (byte)((o.IntValue1 >> 16) & 255);
                bytes[index++] = (byte)((o.IntValue1 >> 8) & 255);
                bytes[index++] = (byte)(o.IntValue1 & 255);
                // PRIMITIVE: IntValue2
                bytes[index++] = (byte)((o.IntValue2 >> 24) & 255);
                bytes[index++] = (byte)((o.IntValue2 >> 16) & 255);
                bytes[index++] = (byte)((o.IntValue2 >> 8) & 255);
                bytes[index++] = (byte)(o.IntValue2 & 255);
        }
        public void Energize(Thing2 o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 11;
            }
                // PRIMITIVE: IntValue1
                bytes[index++] = (byte)((o.IntValue1 >> 24) & 255);
                bytes[index++] = (byte)((o.IntValue1 >> 16) & 255);
                bytes[index++] = (byte)((o.IntValue1 >> 8) & 255);
                bytes[index++] = (byte)(o.IntValue1 & 255);
                // PRIMITIVE: IntValue3
                bytes[index++] = (byte)((o.IntValue3 >> 24) & 255);
                bytes[index++] = (byte)((o.IntValue3 >> 16) & 255);
                bytes[index++] = (byte)((o.IntValue3 >> 8) & 255);
                bytes[index++] = (byte)(o.IntValue3 & 255);
        }
        public void Energize(IntListObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 12;
            }
                // LIST: IntListValue
            if (o.IntListValue == null || o.IntListValue.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.IntListValue.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.IntListValue.Count;
                int i_srQ80oJJmnab;
                for (i_srQ80oJJmnab = 0; i_srQ80oJJmnab < 2; i_srQ80oJJmnab++) {
                    if ((ulong)o.IntListValue.Count < vuBoundaries[i_srQ80oJJmnab]) {
                       byteCount = (int)(i_srQ80oJJmnab + 1);
                       goto guvsgoto_dhrxpmPXeQh3;
                    }
                }
                byteCount = (int)i_srQ80oJJmnab + 1;
                guvsgoto_dhrxpmPXeQh3:
                    for (int i_d9Gx8B95RZ1K = 0; i_d9Gx8B95RZ1K < byteCount; i_d9Gx8B95RZ1K++) {
                        if (i_d9Gx8B95RZ1K < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_d9Gx8B95RZ1K < byteCount - 1) {
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
                foreach (int primitive in o.IntListValue) {
                bytes[index++] = (byte)((primitive >> 24) & 255);
                bytes[index++] = (byte)((primitive >> 16) & 255);
                bytes[index++] = (byte)((primitive >> 8) & 255);
                bytes[index++] = (byte)(primitive & 255);
                }
            }
        }
        public void Energize(StringListObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 13;
            }
                // LIST: StringListValue
            if (o.StringListValue == null || o.StringListValue.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.StringListValue.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.StringListValue.Count;
                int i_b6gtY7F5hpqp;
                for (i_b6gtY7F5hpqp = 0; i_b6gtY7F5hpqp < 2; i_b6gtY7F5hpqp++) {
                    if ((ulong)o.StringListValue.Count < vuBoundaries[i_b6gtY7F5hpqp]) {
                       byteCount = (int)(i_b6gtY7F5hpqp + 1);
                       goto guvsgoto_pYNF5Csyxhs0;
                    }
                }
                byteCount = (int)i_b6gtY7F5hpqp + 1;
                guvsgoto_pYNF5Csyxhs0:
                    for (int i_rrYNRmm2zgyc = 0; i_rrYNRmm2zgyc < byteCount; i_rrYNRmm2zgyc++) {
                        if (i_rrYNRmm2zgyc < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_rrYNRmm2zgyc < byteCount - 1) {
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
                foreach (string primitive in o.StringListValue) {
                uint stringLength_pdOU5LO9RPuc;
                int i_qORl5zB7HdSU;
                for (i_qORl5zB7HdSU = 0; i_qORl5zB7HdSU < 2; i_qORl5zB7HdSU++) {
                    if ((ulong)primitive.Length < vuBoundaries[i_qORl5zB7HdSU]) {
                       stringLength_pdOU5LO9RPuc = (uint)(i_qORl5zB7HdSU + 1);
                       goto guvsgoto_jQgUu5CvHyZO;
                    }
                }
                stringLength_pdOU5LO9RPuc = (uint)i_qORl5zB7HdSU + 1;
                guvsgoto_jQgUu5CvHyZO:
                if (primitive.Length == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    ulong value = (ulong)primitive.Length;
                    for (int i_iU9FLqIa7Wra = 0; i_iU9FLqIa7Wra < stringLength_pdOU5LO9RPuc; i_iU9FLqIa7Wra++) {
                        if (i_iU9FLqIa7Wra < stringLength_pdOU5LO9RPuc - 1) {
                            byte b = (byte)(value & 127);
                            if (i_iU9FLqIa7Wra < stringLength_pdOU5LO9RPuc - 1) {
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
        public void Energize(Thing1ListObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 14;
            }
                // LIST: ThingListValue
            if (o.ThingListValue == null || o.ThingListValue.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.ThingListValue.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.ThingListValue.Count;
                int i_xCerowEs7wAJ;
                for (i_xCerowEs7wAJ = 0; i_xCerowEs7wAJ < 2; i_xCerowEs7wAJ++) {
                    if ((ulong)o.ThingListValue.Count < vuBoundaries[i_xCerowEs7wAJ]) {
                       byteCount = (int)(i_xCerowEs7wAJ + 1);
                       goto guvsgoto_cBIENdEmoagq;
                    }
                }
                byteCount = (int)i_xCerowEs7wAJ + 1;
                guvsgoto_cBIENdEmoagq:
                    for (int i_y6TrZZQ1xQgD = 0; i_y6TrZZQ1xQgD < byteCount; i_y6TrZZQ1xQgD++) {
                        if (i_y6TrZZQ1xQgD < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_y6TrZZQ1xQgD < byteCount - 1) {
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
                foreach (Thing1 finalObject in o.ThingListValue) {
                    Energize(finalObject, bytes, ref index, false);
                }
            }
        }
        public void Energize(AbstractThingListObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 15;
            }
                // LIST: AbstractThingListValue
            if (o.AbstractThingListValue == null || o.AbstractThingListValue.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.AbstractThingListValue.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.AbstractThingListValue.Count;
                int i_fqVKr9cTb9IR;
                for (i_fqVKr9cTb9IR = 0; i_fqVKr9cTb9IR < 2; i_fqVKr9cTb9IR++) {
                    if ((ulong)o.AbstractThingListValue.Count < vuBoundaries[i_fqVKr9cTb9IR]) {
                       byteCount = (int)(i_fqVKr9cTb9IR + 1);
                       goto guvsgoto_w6tEIGFtOTLj;
                    }
                }
                byteCount = (int)i_fqVKr9cTb9IR + 1;
                guvsgoto_w6tEIGFtOTLj:
                    for (int i_inwztp3nvKBr = 0; i_inwztp3nvKBr < byteCount; i_inwztp3nvKBr++) {
                        if (i_inwztp3nvKBr < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_inwztp3nvKBr < byteCount - 1) {
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
                foreach (IListTestObject abstractObject in o.AbstractThingListValue) {
                    Energize((IListTestObject)abstractObject, bytes, ref index, true);
                }
            }
        }
        public void Energize(VIntListObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 16;
            }
                // LIST: VintListValue
            if (o.VintListValue == null || o.VintListValue.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.VintListValue.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.VintListValue.Count;
                int i_bfJxOxB1yMlv;
                for (i_bfJxOxB1yMlv = 0; i_bfJxOxB1yMlv < 2; i_bfJxOxB1yMlv++) {
                    if ((ulong)o.VintListValue.Count < vuBoundaries[i_bfJxOxB1yMlv]) {
                       byteCount = (int)(i_bfJxOxB1yMlv + 1);
                       goto guvsgoto_b9TB0g4mvKeJ;
                    }
                }
                byteCount = (int)i_bfJxOxB1yMlv + 1;
                guvsgoto_b9TB0g4mvKeJ:
                    for (int i_egazZxXLZEIr = 0; i_egazZxXLZEIr < byteCount; i_egazZxXLZEIr++) {
                        if (i_egazZxXLZEIr < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_egazZxXLZEIr < byteCount - 1) {
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
                foreach (int primitive in o.VintListValue) {
    //// AppendSignedToULong(primitive)
    long s2ultemp_gL24evvSiXwn = primitive;
    if (s2ultemp_gL24evvSiXwn == long.MinValue) {
        s2ultemp_gL24evvSiXwn = long.MaxValue;
    }
    else {
        if (s2ultemp_gL24evvSiXwn > 0) {
            s2ultemp_gL24evvSiXwn = -s2ultemp_gL24evvSiXwn;
        }
        s2ultemp_gL24evvSiXwn -= 1;
    }
    s2ultemp_gL24evvSiXwn = ~s2ultemp_gL24evvSiXwn;
    ulong s2ulresult_rFJ8iJ3zYxqT = (ulong)s2ultemp_gL24evvSiXwn;
    //// AppendGetSignVariantSize(s2ulresult_rFJ8iJ3zYxqT)
    byte vr_cFx8XDTJHrhc = 1;
    for (int v_mHWdrCnxUWTt = 56; v_mHWdrCnxUWTt >= 0; v_mHWdrCnxUWTt -= 8) {
        if (((255UL << v_mHWdrCnxUWTt) & s2ulresult_rFJ8iJ3zYxqT) > 0) {
            vr_cFx8XDTJHrhc = (byte)(v_mHWdrCnxUWTt / 8 + 2);
            break;
        }
    }
    bytes[index++] = (byte)((byte)(vr_cFx8XDTJHrhc << 1) | (byte)(primitive > 0 ? 0 : 1));
    for (int vi_uYCpLiD2vjYJ = 0; vi_uYCpLiD2vjYJ < vr_cFx8XDTJHrhc - 1; vi_uYCpLiD2vjYJ++) {
        bytes[index++] = (byte)(s2ulresult_rFJ8iJ3zYxqT & 255);
        s2ulresult_rFJ8iJ3zYxqT = s2ulresult_rFJ8iJ3zYxqT >> 8;
    }
                }
            }
        }
        public void Energize(IListTestObject o, byte[] bytes, ref int index, bool writeTypeId) {
            switch (o.TypeId) {
                case 9:
                    Energize((AbstractThing)o, bytes, ref index, writeTypeId);
                    break;
                case 10:
                    Energize((Thing1)o, bytes, ref index, writeTypeId);
                    break;
                case 11:
                    Energize((Thing2)o, bytes, ref index, writeTypeId);
                    break;
                case 12:
                    Energize((IntListObject)o, bytes, ref index, writeTypeId);
                    break;
                case 13:
                    Energize((StringListObject)o, bytes, ref index, writeTypeId);
                    break;
                case 14:
                    Energize((Thing1ListObject)o, bytes, ref index, writeTypeId);
                    break;
                case 15:
                    Energize((AbstractThingListObject)o, bytes, ref index, writeTypeId);
                    break;
                case 16:
                    Energize((VIntListObject)o, bytes, ref index, writeTypeId);
                    break;
                default:
                    throw new ListTestPatternBufferException("Unrecognized type ID: "+o.TypeId+" ");
            }
        }
///////////////////////////////////////
// FROM BYTES
///////////////////////////////////////
        public object Energize(byte[] bytes) {
            int index = 0;
                    ulong vuread_zx5PdWPxyGEL = 0;
                    for (int i_uZiwk29uVdk8 = 0; i_uZiwk29uVdk8 < 9; i_uZiwk29uVdk8++) {
                        byte b = bytes[index++];
                        if (i_uZiwk29uVdk8 < 8) {
                            vuread_zx5PdWPxyGEL += (((ulong)b & (ulong)127) << (7 * i_uZiwk29uVdk8));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_zx5PdWPxyGEL += (ulong)b << (7 * i_uZiwk29uVdk8);
                            break;
                        }
                    }
                    ushort typeId = (ushort)vuread_zx5PdWPxyGEL;
            switch (typeId) {
            case 9:
                {
                AbstractThing o = new AbstractThing();
                // PRIMITIVE: IntValue1
                o.IntValue1 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    return o;
                }
            case 10:
                {
                Thing1 o = new Thing1();
                // PRIMITIVE: IntValue1
                o.IntValue1 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                // PRIMITIVE: IntValue2
                o.IntValue2 =
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
                Thing2 o = new Thing2();
                // PRIMITIVE: IntValue1
                o.IntValue1 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                // PRIMITIVE: IntValue3
                o.IntValue3 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    return o;
                }
            case 12:
                {
                IntListObject o = new IntListObject();
                // LIST: IntListValue
            // Read list item count
            ushort count_aD8zYoRvSmf4;
                    ulong vuread_nHu7gw4ru1BV = 0;
                    for (int i_zhSCjEX4m6OJ = 0; i_zhSCjEX4m6OJ < 9; i_zhSCjEX4m6OJ++) {
                        byte b = bytes[index++];
                        if (i_zhSCjEX4m6OJ < 8) {
                            vuread_nHu7gw4ru1BV += (((ulong)b & (ulong)127) << (7 * i_zhSCjEX4m6OJ));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_nHu7gw4ru1BV += (ulong)b << (7 * i_zhSCjEX4m6OJ);
                            break;
                        }
                    }
                    count_aD8zYoRvSmf4 = (ushort)vuread_nHu7gw4ru1BV;
            // Read list items
            if (count_aD8zYoRvSmf4 > 0) {
                o.IntListValue = new List<int>();
                int listValue_vqIkYi2KUoYM;
                for (int i_ocnzj3OjbmzR = 0; i_ocnzj3OjbmzR < count_aD8zYoRvSmf4; i_ocnzj3OjbmzR++) {
                    // Read Int list item
                listValue_vqIkYi2KUoYM =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    o.IntListValue.Add(listValue_vqIkYi2KUoYM);
                }
            }
                    return o;
                }
            case 13:
                {
                StringListObject o = new StringListObject();
                // LIST: StringListValue
            // Read list item count
            ushort count_nplozkRL3Ui0;
                    ulong vuread_uUCm81aVsf3h = 0;
                    for (int i_hyVssFHL01OI = 0; i_hyVssFHL01OI < 9; i_hyVssFHL01OI++) {
                        byte b = bytes[index++];
                        if (i_hyVssFHL01OI < 8) {
                            vuread_uUCm81aVsf3h += (((ulong)b & (ulong)127) << (7 * i_hyVssFHL01OI));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_uUCm81aVsf3h += (ulong)b << (7 * i_hyVssFHL01OI);
                            break;
                        }
                    }
                    count_nplozkRL3Ui0 = (ushort)vuread_uUCm81aVsf3h;
            // Read list items
            if (count_nplozkRL3Ui0 > 0) {
                o.StringListValue = new List<string>();
                string listValue_yNlJGnTX3wLy;
                for (int i_lCkkmOyAwe7a = 0; i_lCkkmOyAwe7a < count_nplozkRL3Ui0; i_lCkkmOyAwe7a++) {
                    // Read String list item
                    ulong vuread_rBpevfn4Xw10 = 0;
                    for (int i_jwzmDnm1Plkh = 0; i_jwzmDnm1Plkh < 9; i_jwzmDnm1Plkh++) {
                        byte b = bytes[index++];
                        if (i_jwzmDnm1Plkh < 8) {
                            vuread_rBpevfn4Xw10 += (((ulong)b & (ulong)127) << (7 * i_jwzmDnm1Plkh));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_rBpevfn4Xw10 += (ulong)b << (7 * i_jwzmDnm1Plkh);
                            break;
                        }
                    }
                    ushort stringLength_kysxnGa5f3pv = (ushort)vuread_rBpevfn4Xw10;
                listValue_yNlJGnTX3wLy = Encoding.UTF8.GetString(bytes, index, stringLength_kysxnGa5f3pv);
                index += stringLength_kysxnGa5f3pv;
                    o.StringListValue.Add(listValue_yNlJGnTX3wLy);
                }
            }
                    return o;
                }
            case 14:
                {
                Thing1ListObject o = new Thing1ListObject();
                // LIST: ThingListValue
            // Read list item count
            ushort count_xwKxwPtHmYFV;
                    ulong vuread_ktfq1dncHCb0 = 0;
                    for (int i_cXC2QxPEqhk9 = 0; i_cXC2QxPEqhk9 < 9; i_cXC2QxPEqhk9++) {
                        byte b = bytes[index++];
                        if (i_cXC2QxPEqhk9 < 8) {
                            vuread_ktfq1dncHCb0 += (((ulong)b & (ulong)127) << (7 * i_cXC2QxPEqhk9));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_ktfq1dncHCb0 += (ulong)b << (7 * i_cXC2QxPEqhk9);
                            break;
                        }
                    }
                    count_xwKxwPtHmYFV = (ushort)vuread_ktfq1dncHCb0;
            // Read list items
            if (count_xwKxwPtHmYFV > 0) {
                o.ThingListValue = new List<Thing1>();
                for (int li_n0HhduNG1OXj = 0; li_n0HhduNG1OXj < count_xwKxwPtHmYFV; li_n0HhduNG1OXj++) {
                    o.ThingListValue.Add((Thing1)Energize(bytes, ref index, 10));
                }
            }
                    return o;
                }
            case 15:
                {
                AbstractThingListObject o = new AbstractThingListObject();
                // LIST: AbstractThingListValue
            // Read list item count
            ushort count_d6aM7hKBuTpI;
                    ulong vuread_fB0ZjaErjfUb = 0;
                    for (int i_nf9mZF8CatTU = 0; i_nf9mZF8CatTU < 9; i_nf9mZF8CatTU++) {
                        byte b = bytes[index++];
                        if (i_nf9mZF8CatTU < 8) {
                            vuread_fB0ZjaErjfUb += (((ulong)b & (ulong)127) << (7 * i_nf9mZF8CatTU));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_fB0ZjaErjfUb += (ulong)b << (7 * i_nf9mZF8CatTU);
                            break;
                        }
                    }
                    count_d6aM7hKBuTpI = (ushort)vuread_fB0ZjaErjfUb;
            // Read list items
            if (count_d6aM7hKBuTpI > 0) {
                o.AbstractThingListValue = new List<AbstractThing>();
                for (int li_jdGjHSPVK95L = 0; li_jdGjHSPVK95L < count_d6aM7hKBuTpI; li_jdGjHSPVK95L++) {
                    o.AbstractThingListValue.Add((AbstractThing)Energize(bytes, ref index));
                }
            }
                    return o;
                }
            case 16:
                {
                VIntListObject o = new VIntListObject();
                // LIST: VintListValue
            // Read list item count
            ushort count_mYw0kF9cl8g2;
                    ulong vuread_dxMYVXH3RgBg = 0;
                    for (int i_mvUBA9BGjySb = 0; i_mvUBA9BGjySb < 9; i_mvUBA9BGjySb++) {
                        byte b = bytes[index++];
                        if (i_mvUBA9BGjySb < 8) {
                            vuread_dxMYVXH3RgBg += (((ulong)b & (ulong)127) << (7 * i_mvUBA9BGjySb));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_dxMYVXH3RgBg += (ulong)b << (7 * i_mvUBA9BGjySb);
                            break;
                        }
                    }
                    count_mYw0kF9cl8g2 = (ushort)vuread_dxMYVXH3RgBg;
            // Read list items
            if (count_mYw0kF9cl8g2 > 0) {
                o.VintListValue = new List<int>();
                int listValue_disFtRIy6Nbj;
                for (int i_c0aWBc4ywqwY = 0; i_c0aWBc4ywqwY < count_mYw0kF9cl8g2; i_c0aWBc4ywqwY++) {
                    // Read VInt list item
    byte rvint_b_tIMmHKSTPLQM = bytes[index++];
    byte rvint_sign_ncJaHdk0tLvJ = (byte)(rvint_b_tIMmHKSTPLQM & 1);
    byte rvint_size_zOehEuO1VDTV = (byte)(rvint_b_tIMmHKSTPLQM >> 1);
    ulong rvint_remaining_cv0v5sDEkxry = 0;
    for (int i_m30sgGFkncn3 = 0; i_m30sgGFkncn3 < rvint_size_zOehEuO1VDTV - 1; i_m30sgGFkncn3++) {
        rvint_remaining_cv0v5sDEkxry = rvint_remaining_cv0v5sDEkxry | (((ulong)bytes[index++] << (8 * i_m30sgGFkncn3)));
    }
    int rvint_result_nLpv6Y1csY5m = (int)rvint_remaining_cv0v5sDEkxry;
    rvint_result_nLpv6Y1csY5m = ~rvint_result_nLpv6Y1csY5m;
    if (rvint_result_nLpv6Y1csY5m == int.MaxValue) {
        rvint_result_nLpv6Y1csY5m = int.MinValue;
    }
    else {
        // Add offset
        rvint_result_nLpv6Y1csY5m += 1;
        if (rvint_sign_ncJaHdk0tLvJ == 0) {
            rvint_result_nLpv6Y1csY5m = -rvint_result_nLpv6Y1csY5m;
        }
    }
    listValue_disFtRIy6Nbj = rvint_result_nLpv6Y1csY5m;
                    o.VintListValue.Add(listValue_disFtRIy6Nbj);
                }
            }
                    return o;
                }
                default:
                    throw new ListTestPatternBufferException("Unrecognized type ID: "+typeId+" ");
            }
        }
        public object Energize(byte[] bytes, ref int index) {
                    ulong vuread_fY4bh0zLwPOK = 0;
                    for (int i_mwVo8JIci7Zu = 0; i_mwVo8JIci7Zu < 9; i_mwVo8JIci7Zu++) {
                        byte b = bytes[index++];
                        if (i_mwVo8JIci7Zu < 8) {
                            vuread_fY4bh0zLwPOK += (((ulong)b & (ulong)127) << (7 * i_mwVo8JIci7Zu));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_fY4bh0zLwPOK += (ulong)b << (7 * i_mwVo8JIci7Zu);
                            break;
                        }
                    }
                    ushort typeId = (ushort)vuread_fY4bh0zLwPOK;
            switch (typeId) {
            case 9:
                {
                AbstractThing o = new AbstractThing();
                // PRIMITIVE: IntValue1
                o.IntValue1 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    return o;
                }
            case 10:
                {
                Thing1 o = new Thing1();
                // PRIMITIVE: IntValue1
                o.IntValue1 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                // PRIMITIVE: IntValue2
                o.IntValue2 =
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
                Thing2 o = new Thing2();
                // PRIMITIVE: IntValue1
                o.IntValue1 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                // PRIMITIVE: IntValue3
                o.IntValue3 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    return o;
                }
            case 12:
                {
                IntListObject o = new IntListObject();
                // LIST: IntListValue
            // Read list item count
            ushort count_biIvFpgO8Ofs;
                    ulong vuread_pDcwNMG06O0K = 0;
                    for (int i_bMeTq3ep8K98 = 0; i_bMeTq3ep8K98 < 9; i_bMeTq3ep8K98++) {
                        byte b = bytes[index++];
                        if (i_bMeTq3ep8K98 < 8) {
                            vuread_pDcwNMG06O0K += (((ulong)b & (ulong)127) << (7 * i_bMeTq3ep8K98));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_pDcwNMG06O0K += (ulong)b << (7 * i_bMeTq3ep8K98);
                            break;
                        }
                    }
                    count_biIvFpgO8Ofs = (ushort)vuread_pDcwNMG06O0K;
            // Read list items
            if (count_biIvFpgO8Ofs > 0) {
                o.IntListValue = new List<int>();
                int listValue_hdfhJaM0qDNE;
                for (int i_nlzFA8xxr8s3 = 0; i_nlzFA8xxr8s3 < count_biIvFpgO8Ofs; i_nlzFA8xxr8s3++) {
                    // Read Int list item
                listValue_hdfhJaM0qDNE =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    o.IntListValue.Add(listValue_hdfhJaM0qDNE);
                }
            }
                    return o;
                }
            case 13:
                {
                StringListObject o = new StringListObject();
                // LIST: StringListValue
            // Read list item count
            ushort count_ewyeJ0tbEedJ;
                    ulong vuread_nyr6cauJ9Jle = 0;
                    for (int i_mIZamLQuUm6m = 0; i_mIZamLQuUm6m < 9; i_mIZamLQuUm6m++) {
                        byte b = bytes[index++];
                        if (i_mIZamLQuUm6m < 8) {
                            vuread_nyr6cauJ9Jle += (((ulong)b & (ulong)127) << (7 * i_mIZamLQuUm6m));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_nyr6cauJ9Jle += (ulong)b << (7 * i_mIZamLQuUm6m);
                            break;
                        }
                    }
                    count_ewyeJ0tbEedJ = (ushort)vuread_nyr6cauJ9Jle;
            // Read list items
            if (count_ewyeJ0tbEedJ > 0) {
                o.StringListValue = new List<string>();
                string listValue_pHqzjMaDiZ8b;
                for (int i_sBvrNS3LltKb = 0; i_sBvrNS3LltKb < count_ewyeJ0tbEedJ; i_sBvrNS3LltKb++) {
                    // Read String list item
                    ulong vuread_t4AxJS5OJXsU = 0;
                    for (int i_gzQcsubr7oz0 = 0; i_gzQcsubr7oz0 < 9; i_gzQcsubr7oz0++) {
                        byte b = bytes[index++];
                        if (i_gzQcsubr7oz0 < 8) {
                            vuread_t4AxJS5OJXsU += (((ulong)b & (ulong)127) << (7 * i_gzQcsubr7oz0));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_t4AxJS5OJXsU += (ulong)b << (7 * i_gzQcsubr7oz0);
                            break;
                        }
                    }
                    ushort stringLength_atY2xSYuCeuE = (ushort)vuread_t4AxJS5OJXsU;
                listValue_pHqzjMaDiZ8b = Encoding.UTF8.GetString(bytes, index, stringLength_atY2xSYuCeuE);
                index += stringLength_atY2xSYuCeuE;
                    o.StringListValue.Add(listValue_pHqzjMaDiZ8b);
                }
            }
                    return o;
                }
            case 14:
                {
                Thing1ListObject o = new Thing1ListObject();
                // LIST: ThingListValue
            // Read list item count
            ushort count_uhfzaOIMh0GT;
                    ulong vuread_hGcCy5CmadM7 = 0;
                    for (int i_aWcidcHGFJJB = 0; i_aWcidcHGFJJB < 9; i_aWcidcHGFJJB++) {
                        byte b = bytes[index++];
                        if (i_aWcidcHGFJJB < 8) {
                            vuread_hGcCy5CmadM7 += (((ulong)b & (ulong)127) << (7 * i_aWcidcHGFJJB));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_hGcCy5CmadM7 += (ulong)b << (7 * i_aWcidcHGFJJB);
                            break;
                        }
                    }
                    count_uhfzaOIMh0GT = (ushort)vuread_hGcCy5CmadM7;
            // Read list items
            if (count_uhfzaOIMh0GT > 0) {
                o.ThingListValue = new List<Thing1>();
                for (int li_qGN4oQMz37TW = 0; li_qGN4oQMz37TW < count_uhfzaOIMh0GT; li_qGN4oQMz37TW++) {
                    o.ThingListValue.Add((Thing1)Energize(bytes, ref index, 10));
                }
            }
                    return o;
                }
            case 15:
                {
                AbstractThingListObject o = new AbstractThingListObject();
                // LIST: AbstractThingListValue
            // Read list item count
            ushort count_hI3bWmZTEixo;
                    ulong vuread_qAIft9oS6LZ1 = 0;
                    for (int i_hH7uAnefcp0E = 0; i_hH7uAnefcp0E < 9; i_hH7uAnefcp0E++) {
                        byte b = bytes[index++];
                        if (i_hH7uAnefcp0E < 8) {
                            vuread_qAIft9oS6LZ1 += (((ulong)b & (ulong)127) << (7 * i_hH7uAnefcp0E));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_qAIft9oS6LZ1 += (ulong)b << (7 * i_hH7uAnefcp0E);
                            break;
                        }
                    }
                    count_hI3bWmZTEixo = (ushort)vuread_qAIft9oS6LZ1;
            // Read list items
            if (count_hI3bWmZTEixo > 0) {
                o.AbstractThingListValue = new List<AbstractThing>();
                for (int li_dFUsUZ6EjzsY = 0; li_dFUsUZ6EjzsY < count_hI3bWmZTEixo; li_dFUsUZ6EjzsY++) {
                    o.AbstractThingListValue.Add((AbstractThing)Energize(bytes, ref index));
                }
            }
                    return o;
                }
            case 16:
                {
                VIntListObject o = new VIntListObject();
                // LIST: VintListValue
            // Read list item count
            ushort count_dHg3SaZQTbUo;
                    ulong vuread_gEtrdrlwKe7X = 0;
                    for (int i_g58gOuS2ojn3 = 0; i_g58gOuS2ojn3 < 9; i_g58gOuS2ojn3++) {
                        byte b = bytes[index++];
                        if (i_g58gOuS2ojn3 < 8) {
                            vuread_gEtrdrlwKe7X += (((ulong)b & (ulong)127) << (7 * i_g58gOuS2ojn3));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_gEtrdrlwKe7X += (ulong)b << (7 * i_g58gOuS2ojn3);
                            break;
                        }
                    }
                    count_dHg3SaZQTbUo = (ushort)vuread_gEtrdrlwKe7X;
            // Read list items
            if (count_dHg3SaZQTbUo > 0) {
                o.VintListValue = new List<int>();
                int listValue_ckwbAjVgVFep;
                for (int i_nOA1n6ndKsOW = 0; i_nOA1n6ndKsOW < count_dHg3SaZQTbUo; i_nOA1n6ndKsOW++) {
                    // Read VInt list item
    byte rvint_b_aTbys1aerzk3 = bytes[index++];
    byte rvint_sign_xj5As0cT1TJ9 = (byte)(rvint_b_aTbys1aerzk3 & 1);
    byte rvint_size_x1Os6ksYGK9R = (byte)(rvint_b_aTbys1aerzk3 >> 1);
    ulong rvint_remaining_dxX3F97gEH6e = 0;
    for (int i_aWUTp44tjbEB = 0; i_aWUTp44tjbEB < rvint_size_x1Os6ksYGK9R - 1; i_aWUTp44tjbEB++) {
        rvint_remaining_dxX3F97gEH6e = rvint_remaining_dxX3F97gEH6e | (((ulong)bytes[index++] << (8 * i_aWUTp44tjbEB)));
    }
    int rvint_result_fSihgwxujos5 = (int)rvint_remaining_dxX3F97gEH6e;
    rvint_result_fSihgwxujos5 = ~rvint_result_fSihgwxujos5;
    if (rvint_result_fSihgwxujos5 == int.MaxValue) {
        rvint_result_fSihgwxujos5 = int.MinValue;
    }
    else {
        // Add offset
        rvint_result_fSihgwxujos5 += 1;
        if (rvint_sign_xj5As0cT1TJ9 == 0) {
            rvint_result_fSihgwxujos5 = -rvint_result_fSihgwxujos5;
        }
    }
    listValue_ckwbAjVgVFep = rvint_result_fSihgwxujos5;
                    o.VintListValue.Add(listValue_ckwbAjVgVFep);
                }
            }
                    return o;
                }
                default:
                    throw new ListTestPatternBufferException("Unrecognized type ID: "+typeId+" ");
            }
        }
        public object Energize(byte[] bytes, ref int index, ushort typeId) {
            switch (typeId) {
            case 9:
                {
                AbstractThing o = new AbstractThing();
                // PRIMITIVE: IntValue1
                o.IntValue1 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    return o;
                }
            case 10:
                {
                Thing1 o = new Thing1();
                // PRIMITIVE: IntValue1
                o.IntValue1 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                // PRIMITIVE: IntValue2
                o.IntValue2 =
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
                Thing2 o = new Thing2();
                // PRIMITIVE: IntValue1
                o.IntValue1 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                // PRIMITIVE: IntValue3
                o.IntValue3 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    return o;
                }
            case 12:
                {
                IntListObject o = new IntListObject();
                // LIST: IntListValue
            // Read list item count
            ushort count_bjo2VDFx5Krj;
                    ulong vuread_kJILPQHg3wPX = 0;
                    for (int i_w09hjL4VEZRg = 0; i_w09hjL4VEZRg < 9; i_w09hjL4VEZRg++) {
                        byte b = bytes[index++];
                        if (i_w09hjL4VEZRg < 8) {
                            vuread_kJILPQHg3wPX += (((ulong)b & (ulong)127) << (7 * i_w09hjL4VEZRg));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_kJILPQHg3wPX += (ulong)b << (7 * i_w09hjL4VEZRg);
                            break;
                        }
                    }
                    count_bjo2VDFx5Krj = (ushort)vuread_kJILPQHg3wPX;
            // Read list items
            if (count_bjo2VDFx5Krj > 0) {
                o.IntListValue = new List<int>();
                int listValue_rcHQGgFNA9RH;
                for (int i_uVPDQmcQDBb4 = 0; i_uVPDQmcQDBb4 < count_bjo2VDFx5Krj; i_uVPDQmcQDBb4++) {
                    // Read Int list item
                listValue_rcHQGgFNA9RH =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    o.IntListValue.Add(listValue_rcHQGgFNA9RH);
                }
            }
                    return o;
                }
            case 13:
                {
                StringListObject o = new StringListObject();
                // LIST: StringListValue
            // Read list item count
            ushort count_mynuPFOK1C6N;
                    ulong vuread_d1KW1cw1jCuy = 0;
                    for (int i_yAesXaNnaMni = 0; i_yAesXaNnaMni < 9; i_yAesXaNnaMni++) {
                        byte b = bytes[index++];
                        if (i_yAesXaNnaMni < 8) {
                            vuread_d1KW1cw1jCuy += (((ulong)b & (ulong)127) << (7 * i_yAesXaNnaMni));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_d1KW1cw1jCuy += (ulong)b << (7 * i_yAesXaNnaMni);
                            break;
                        }
                    }
                    count_mynuPFOK1C6N = (ushort)vuread_d1KW1cw1jCuy;
            // Read list items
            if (count_mynuPFOK1C6N > 0) {
                o.StringListValue = new List<string>();
                string listValue_xk74ugPvYbuZ;
                for (int i_ppYBfkUaeYyo = 0; i_ppYBfkUaeYyo < count_mynuPFOK1C6N; i_ppYBfkUaeYyo++) {
                    // Read String list item
                    ulong vuread_bBHdW8J3gpQH = 0;
                    for (int i_fliZ2mefVTD8 = 0; i_fliZ2mefVTD8 < 9; i_fliZ2mefVTD8++) {
                        byte b = bytes[index++];
                        if (i_fliZ2mefVTD8 < 8) {
                            vuread_bBHdW8J3gpQH += (((ulong)b & (ulong)127) << (7 * i_fliZ2mefVTD8));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_bBHdW8J3gpQH += (ulong)b << (7 * i_fliZ2mefVTD8);
                            break;
                        }
                    }
                    ushort stringLength_lwX0YSNGOC2Q = (ushort)vuread_bBHdW8J3gpQH;
                listValue_xk74ugPvYbuZ = Encoding.UTF8.GetString(bytes, index, stringLength_lwX0YSNGOC2Q);
                index += stringLength_lwX0YSNGOC2Q;
                    o.StringListValue.Add(listValue_xk74ugPvYbuZ);
                }
            }
                    return o;
                }
            case 14:
                {
                Thing1ListObject o = new Thing1ListObject();
                // LIST: ThingListValue
            // Read list item count
            ushort count_hYGgyYkjxixN;
                    ulong vuread_qRofoEhlPqON = 0;
                    for (int i_oXOCxX4u8IV7 = 0; i_oXOCxX4u8IV7 < 9; i_oXOCxX4u8IV7++) {
                        byte b = bytes[index++];
                        if (i_oXOCxX4u8IV7 < 8) {
                            vuread_qRofoEhlPqON += (((ulong)b & (ulong)127) << (7 * i_oXOCxX4u8IV7));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_qRofoEhlPqON += (ulong)b << (7 * i_oXOCxX4u8IV7);
                            break;
                        }
                    }
                    count_hYGgyYkjxixN = (ushort)vuread_qRofoEhlPqON;
            // Read list items
            if (count_hYGgyYkjxixN > 0) {
                o.ThingListValue = new List<Thing1>();
                for (int li_lDFsfGkdYFmk = 0; li_lDFsfGkdYFmk < count_hYGgyYkjxixN; li_lDFsfGkdYFmk++) {
                    o.ThingListValue.Add((Thing1)Energize(bytes, ref index, 10));
                }
            }
                    return o;
                }
            case 15:
                {
                AbstractThingListObject o = new AbstractThingListObject();
                // LIST: AbstractThingListValue
            // Read list item count
            ushort count_z80qLssbk3HL;
                    ulong vuread_eRVJncPe6rOV = 0;
                    for (int i_zZfigLZeKDEz = 0; i_zZfigLZeKDEz < 9; i_zZfigLZeKDEz++) {
                        byte b = bytes[index++];
                        if (i_zZfigLZeKDEz < 8) {
                            vuread_eRVJncPe6rOV += (((ulong)b & (ulong)127) << (7 * i_zZfigLZeKDEz));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_eRVJncPe6rOV += (ulong)b << (7 * i_zZfigLZeKDEz);
                            break;
                        }
                    }
                    count_z80qLssbk3HL = (ushort)vuread_eRVJncPe6rOV;
            // Read list items
            if (count_z80qLssbk3HL > 0) {
                o.AbstractThingListValue = new List<AbstractThing>();
                for (int li_yOTPqTXI54ix = 0; li_yOTPqTXI54ix < count_z80qLssbk3HL; li_yOTPqTXI54ix++) {
                    o.AbstractThingListValue.Add((AbstractThing)Energize(bytes, ref index));
                }
            }
                    return o;
                }
            case 16:
                {
                VIntListObject o = new VIntListObject();
                // LIST: VintListValue
            // Read list item count
            ushort count_tK0VZioQuerV;
                    ulong vuread_fk5IeCaQmwNJ = 0;
                    for (int i_h9YmDfZfQSxG = 0; i_h9YmDfZfQSxG < 9; i_h9YmDfZfQSxG++) {
                        byte b = bytes[index++];
                        if (i_h9YmDfZfQSxG < 8) {
                            vuread_fk5IeCaQmwNJ += (((ulong)b & (ulong)127) << (7 * i_h9YmDfZfQSxG));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_fk5IeCaQmwNJ += (ulong)b << (7 * i_h9YmDfZfQSxG);
                            break;
                        }
                    }
                    count_tK0VZioQuerV = (ushort)vuread_fk5IeCaQmwNJ;
            // Read list items
            if (count_tK0VZioQuerV > 0) {
                o.VintListValue = new List<int>();
                int listValue_tdoCoYf2w7Df;
                for (int i_uoED3Bky6qC0 = 0; i_uoED3Bky6qC0 < count_tK0VZioQuerV; i_uoED3Bky6qC0++) {
                    // Read VInt list item
    byte rvint_b_ibmoolfEWzXa = bytes[index++];
    byte rvint_sign_fICyrVmvGSzp = (byte)(rvint_b_ibmoolfEWzXa & 1);
    byte rvint_size_pwmoH9JELyim = (byte)(rvint_b_ibmoolfEWzXa >> 1);
    ulong rvint_remaining_p0Nl28tyAEov = 0;
    for (int i_zWgldgtLM6M2 = 0; i_zWgldgtLM6M2 < rvint_size_pwmoH9JELyim - 1; i_zWgldgtLM6M2++) {
        rvint_remaining_p0Nl28tyAEov = rvint_remaining_p0Nl28tyAEov | (((ulong)bytes[index++] << (8 * i_zWgldgtLM6M2)));
    }
    int rvint_result_z07XZsyZApWA = (int)rvint_remaining_p0Nl28tyAEov;
    rvint_result_z07XZsyZApWA = ~rvint_result_z07XZsyZApWA;
    if (rvint_result_z07XZsyZApWA == int.MaxValue) {
        rvint_result_z07XZsyZApWA = int.MinValue;
    }
    else {
        // Add offset
        rvint_result_z07XZsyZApWA += 1;
        if (rvint_sign_fICyrVmvGSzp == 0) {
            rvint_result_z07XZsyZApWA = -rvint_result_z07XZsyZApWA;
        }
    }
    listValue_tdoCoYf2w7Df = rvint_result_z07XZsyZApWA;
                    o.VintListValue.Add(listValue_tdoCoYf2w7Df);
                }
            }
                    return o;
                }
                default:
                    throw new ListTestPatternBufferException("Unrecognized type ID: "+typeId+" ");
            }
        }
///////////////////////////////////////
// FROM BYTES (TYPED)
///////////////////////////////////////
        public TYPE Energize< TYPE > (byte[] bytes) {
            object o = this.Energize(bytes);
            if (!(o is TYPE)) {
                throw new ListTestPatternBufferException("Deserialized type (" + o.GetType().Name + ") does not match expected type (" + typeof(TYPE).Name + ").");
            }
            return (TYPE)o;
        }
    }
}
