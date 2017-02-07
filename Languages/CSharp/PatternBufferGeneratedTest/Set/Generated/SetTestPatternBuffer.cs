
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System.Text;
using System;
using System.Collections.Generic;

namespace Test.Set {
    public class SetTestPatternBuffer {
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
        public SetTestPatternBuffer() : this(4096) { }
        public SetTestPatternBuffer(uint bufferSize) {
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
        public byte[] Energize(IntSetObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(StringSetObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(Thing1SetObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(AbstractThingSetObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = new byte[index];
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(VIntSetObject o) {
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
        public void Energize(IntSetObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 12;
            }
                // SET: IntSetValue
            if (o.IntSetValue == null || o.IntSetValue.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.IntSetValue.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.IntSetValue.Count;
                int i_nY1iPbcXpYdJ;
                for (i_nY1iPbcXpYdJ = 0; i_nY1iPbcXpYdJ < 2; i_nY1iPbcXpYdJ++) {
                    if ((ulong)o.IntSetValue.Count < vuBoundaries[i_nY1iPbcXpYdJ]) {
                       byteCount = (int)(i_nY1iPbcXpYdJ + 1);
                       goto guvsgoto_cGxTdJZiuxWp;
                    }
                }
                byteCount = (int)i_nY1iPbcXpYdJ + 1;
                guvsgoto_cGxTdJZiuxWp:
                    for (int i_gkN3bvj25LjH = 0; i_gkN3bvj25LjH < byteCount; i_gkN3bvj25LjH++) {
                        if (i_gkN3bvj25LjH < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_gkN3bvj25LjH < byteCount - 1) {
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
                foreach (int primitive in o.IntSetValue) {
                bytes[index++] = (byte)((primitive >> 24) & 255);
                bytes[index++] = (byte)((primitive >> 16) & 255);
                bytes[index++] = (byte)((primitive >> 8) & 255);
                bytes[index++] = (byte)(primitive & 255);
                }
            }
        }
        public void Energize(StringSetObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 13;
            }
                // SET: StringSetValue
            if (o.StringSetValue == null || o.StringSetValue.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.StringSetValue.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.StringSetValue.Count;
                int i_hTlYCRlqCYD2;
                for (i_hTlYCRlqCYD2 = 0; i_hTlYCRlqCYD2 < 2; i_hTlYCRlqCYD2++) {
                    if ((ulong)o.StringSetValue.Count < vuBoundaries[i_hTlYCRlqCYD2]) {
                       byteCount = (int)(i_hTlYCRlqCYD2 + 1);
                       goto guvsgoto_mvkvqzWMHC4s;
                    }
                }
                byteCount = (int)i_hTlYCRlqCYD2 + 1;
                guvsgoto_mvkvqzWMHC4s:
                    for (int i_y5g9n4u3OuOt = 0; i_y5g9n4u3OuOt < byteCount; i_y5g9n4u3OuOt++) {
                        if (i_y5g9n4u3OuOt < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_y5g9n4u3OuOt < byteCount - 1) {
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
                foreach (string primitive in o.StringSetValue) {
                uint stringLength_wRHZcAcYqvMs;
                int i_iXzNhaN6f27V;
                for (i_iXzNhaN6f27V = 0; i_iXzNhaN6f27V < 2; i_iXzNhaN6f27V++) {
                    if ((ulong)primitive.Length < vuBoundaries[i_iXzNhaN6f27V]) {
                       stringLength_wRHZcAcYqvMs = (uint)(i_iXzNhaN6f27V + 1);
                       goto guvsgoto_dvznA3fP2rzu;
                    }
                }
                stringLength_wRHZcAcYqvMs = (uint)i_iXzNhaN6f27V + 1;
                guvsgoto_dvznA3fP2rzu:
                if (primitive.Length == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    ulong value = (ulong)primitive.Length;
                    for (int i_evnbWPLKtY02 = 0; i_evnbWPLKtY02 < stringLength_wRHZcAcYqvMs; i_evnbWPLKtY02++) {
                        if (i_evnbWPLKtY02 < stringLength_wRHZcAcYqvMs - 1) {
                            byte b = (byte)(value & 127);
                            if (i_evnbWPLKtY02 < stringLength_wRHZcAcYqvMs - 1) {
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
        public void Energize(Thing1SetObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 14;
            }
                // SET: ThingSetValue
            if (o.ThingSetValue == null || o.ThingSetValue.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.ThingSetValue.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.ThingSetValue.Count;
                int i_azQqRPmqyOdf;
                for (i_azQqRPmqyOdf = 0; i_azQqRPmqyOdf < 2; i_azQqRPmqyOdf++) {
                    if ((ulong)o.ThingSetValue.Count < vuBoundaries[i_azQqRPmqyOdf]) {
                       byteCount = (int)(i_azQqRPmqyOdf + 1);
                       goto guvsgoto_mgDVo8AJrmGp;
                    }
                }
                byteCount = (int)i_azQqRPmqyOdf + 1;
                guvsgoto_mgDVo8AJrmGp:
                    for (int i_rd3nQZbF6Hia = 0; i_rd3nQZbF6Hia < byteCount; i_rd3nQZbF6Hia++) {
                        if (i_rd3nQZbF6Hia < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_rd3nQZbF6Hia < byteCount - 1) {
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
                foreach (Thing1 finalObject in o.ThingSetValue) {
                    Energize(finalObject, bytes, ref index, false);
                }
            }
        }
        public void Energize(AbstractThingSetObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 15;
            }
                // SET: AbstractThingSetValue
            if (o.AbstractThingSetValue == null || o.AbstractThingSetValue.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.AbstractThingSetValue.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.AbstractThingSetValue.Count;
                int i_zv2OLJE0cyfl;
                for (i_zv2OLJE0cyfl = 0; i_zv2OLJE0cyfl < 2; i_zv2OLJE0cyfl++) {
                    if ((ulong)o.AbstractThingSetValue.Count < vuBoundaries[i_zv2OLJE0cyfl]) {
                       byteCount = (int)(i_zv2OLJE0cyfl + 1);
                       goto guvsgoto_n2RhBxE7Y89x;
                    }
                }
                byteCount = (int)i_zv2OLJE0cyfl + 1;
                guvsgoto_n2RhBxE7Y89x:
                    for (int i_bn2BlbsEqPSZ = 0; i_bn2BlbsEqPSZ < byteCount; i_bn2BlbsEqPSZ++) {
                        if (i_bn2BlbsEqPSZ < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_bn2BlbsEqPSZ < byteCount - 1) {
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
                foreach (ISetTestObject abstractObject in o.AbstractThingSetValue) {
                    Energize((ISetTestObject)abstractObject, bytes, ref index, true);
                }
            }
        }
        public void Energize(VIntSetObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 16;
            }
                // SET: VintSetValue
            if (o.VintSetValue == null || o.VintSetValue.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.VintSetValue.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.VintSetValue.Count;
                int i_zw3xcs7iWGcn;
                for (i_zw3xcs7iWGcn = 0; i_zw3xcs7iWGcn < 2; i_zw3xcs7iWGcn++) {
                    if ((ulong)o.VintSetValue.Count < vuBoundaries[i_zw3xcs7iWGcn]) {
                       byteCount = (int)(i_zw3xcs7iWGcn + 1);
                       goto guvsgoto_yfZajgqQeGou;
                    }
                }
                byteCount = (int)i_zw3xcs7iWGcn + 1;
                guvsgoto_yfZajgqQeGou:
                    for (int i_mdWXQFgsMcQG = 0; i_mdWXQFgsMcQG < byteCount; i_mdWXQFgsMcQG++) {
                        if (i_mdWXQFgsMcQG < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_mdWXQFgsMcQG < byteCount - 1) {
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
                foreach (int primitive in o.VintSetValue) {
    //// AppendSignedToULong(primitive)
    long s2ultemp_tDQ6izhI9IDY = primitive;
    if (s2ultemp_tDQ6izhI9IDY == long.MinValue) {
        s2ultemp_tDQ6izhI9IDY = long.MaxValue;
    }
    else {
        if (s2ultemp_tDQ6izhI9IDY > 0) {
            s2ultemp_tDQ6izhI9IDY = -s2ultemp_tDQ6izhI9IDY;
        }
        s2ultemp_tDQ6izhI9IDY -= 1;
    }
    s2ultemp_tDQ6izhI9IDY = ~s2ultemp_tDQ6izhI9IDY;
    ulong s2ulresult_d4B7SKdAcLFg = (ulong)s2ultemp_tDQ6izhI9IDY;
    //// AppendGetSignVariantSize(s2ulresult_d4B7SKdAcLFg)
    byte vr_iCaIz5S5QxOJ = 1;
    for (int v_qaaxzEo6J8PW = 56; v_qaaxzEo6J8PW >= 0; v_qaaxzEo6J8PW -= 8) {
        if (((255UL << v_qaaxzEo6J8PW) & s2ulresult_d4B7SKdAcLFg) > 0) {
            vr_iCaIz5S5QxOJ = (byte)(v_qaaxzEo6J8PW / 8 + 2);
            break;
        }
    }
    bytes[index++] = (byte)((byte)(vr_iCaIz5S5QxOJ << 1) | (byte)(primitive > 0 ? 0 : 1));
    for (int vi_bjKc8qDh8JNP = 0; vi_bjKc8qDh8JNP < vr_iCaIz5S5QxOJ - 1; vi_bjKc8qDh8JNP++) {
        bytes[index++] = (byte)(s2ulresult_d4B7SKdAcLFg & 255);
        s2ulresult_d4B7SKdAcLFg = s2ulresult_d4B7SKdAcLFg >> 8;
    }
                }
            }
        }
        public void Energize(ISetTestObject o, byte[] bytes, ref int index, bool writeTypeId) {
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
                    Energize((IntSetObject)o, bytes, ref index, writeTypeId);
                    break;
                case 13:
                    Energize((StringSetObject)o, bytes, ref index, writeTypeId);
                    break;
                case 14:
                    Energize((Thing1SetObject)o, bytes, ref index, writeTypeId);
                    break;
                case 15:
                    Energize((AbstractThingSetObject)o, bytes, ref index, writeTypeId);
                    break;
                case 16:
                    Energize((VIntSetObject)o, bytes, ref index, writeTypeId);
                    break;
                default:
                    throw new SetTestPatternBufferException("Unrecognized type ID: "+o.TypeId+" ");
            }
        }
///////////////////////////////////////
// FROM BYTES
///////////////////////////////////////
        public object Energize(byte[] bytes) {
            int index = 0;
                    ulong vuread_kIidZHiUq2vR = 0;
                    for (int i_oQaHxIHuXoFq = 0; i_oQaHxIHuXoFq < 9; i_oQaHxIHuXoFq++) {
                        byte b = bytes[index++];
                        if (i_oQaHxIHuXoFq < 8) {
                            vuread_kIidZHiUq2vR += (((ulong)b & (ulong)127) << (7 * i_oQaHxIHuXoFq));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_kIidZHiUq2vR += (ulong)b << (7 * i_oQaHxIHuXoFq);
                            break;
                        }
                    }
                    ushort typeId = (ushort)vuread_kIidZHiUq2vR;
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
                IntSetObject o = new IntSetObject();
                // SET: IntSetValue
            // Read list item count
            ushort count_iP7z3GLdxv81;
                    ulong vuread_jlhc05FlY2Cr = 0;
                    for (int i_g5Uzbt2kc1Sj = 0; i_g5Uzbt2kc1Sj < 9; i_g5Uzbt2kc1Sj++) {
                        byte b = bytes[index++];
                        if (i_g5Uzbt2kc1Sj < 8) {
                            vuread_jlhc05FlY2Cr += (((ulong)b & (ulong)127) << (7 * i_g5Uzbt2kc1Sj));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_jlhc05FlY2Cr += (ulong)b << (7 * i_g5Uzbt2kc1Sj);
                            break;
                        }
                    }
                    count_iP7z3GLdxv81 = (ushort)vuread_jlhc05FlY2Cr;
            // Read list items
            if (count_iP7z3GLdxv81 > 0) {
                o.IntSetValue = new HashSet<int>();
                int listValue_pS0TrruoSjlm;
                for (int i_lFE1SuCCnPk8 = 0; i_lFE1SuCCnPk8 < count_iP7z3GLdxv81; i_lFE1SuCCnPk8++) {
                    // Read Int list item
                listValue_pS0TrruoSjlm =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    o.IntSetValue.Add(listValue_pS0TrruoSjlm);
                }
            }
                    return o;
                }
            case 13:
                {
                StringSetObject o = new StringSetObject();
                // SET: StringSetValue
            // Read list item count
            ushort count_ulbeCXYEC7Bi;
                    ulong vuread_cW3GIoJfTH8G = 0;
                    for (int i_vaCSzp64H26f = 0; i_vaCSzp64H26f < 9; i_vaCSzp64H26f++) {
                        byte b = bytes[index++];
                        if (i_vaCSzp64H26f < 8) {
                            vuread_cW3GIoJfTH8G += (((ulong)b & (ulong)127) << (7 * i_vaCSzp64H26f));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_cW3GIoJfTH8G += (ulong)b << (7 * i_vaCSzp64H26f);
                            break;
                        }
                    }
                    count_ulbeCXYEC7Bi = (ushort)vuread_cW3GIoJfTH8G;
            // Read list items
            if (count_ulbeCXYEC7Bi > 0) {
                o.StringSetValue = new HashSet<string>();
                string listValue_gqV4uRTEdvW5;
                for (int i_l638feopnFpC = 0; i_l638feopnFpC < count_ulbeCXYEC7Bi; i_l638feopnFpC++) {
                    // Read String list item
                    ulong vuread_mPVcXDDDnGsD = 0;
                    for (int i_j8ZDNR2UbsIo = 0; i_j8ZDNR2UbsIo < 9; i_j8ZDNR2UbsIo++) {
                        byte b = bytes[index++];
                        if (i_j8ZDNR2UbsIo < 8) {
                            vuread_mPVcXDDDnGsD += (((ulong)b & (ulong)127) << (7 * i_j8ZDNR2UbsIo));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_mPVcXDDDnGsD += (ulong)b << (7 * i_j8ZDNR2UbsIo);
                            break;
                        }
                    }
                    ushort stringLength_jgenaGKm0Yqs = (ushort)vuread_mPVcXDDDnGsD;
                listValue_gqV4uRTEdvW5 = Encoding.UTF8.GetString(bytes, index, stringLength_jgenaGKm0Yqs);
                index += stringLength_jgenaGKm0Yqs;
                    o.StringSetValue.Add(listValue_gqV4uRTEdvW5);
                }
            }
                    return o;
                }
            case 14:
                {
                Thing1SetObject o = new Thing1SetObject();
                // SET: ThingSetValue
            // Read list item count
            ushort count_qGDGVKfLPLFA;
                    ulong vuread_imBTbVpYXL1c = 0;
                    for (int i_shIi6FrkgGyr = 0; i_shIi6FrkgGyr < 9; i_shIi6FrkgGyr++) {
                        byte b = bytes[index++];
                        if (i_shIi6FrkgGyr < 8) {
                            vuread_imBTbVpYXL1c += (((ulong)b & (ulong)127) << (7 * i_shIi6FrkgGyr));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_imBTbVpYXL1c += (ulong)b << (7 * i_shIi6FrkgGyr);
                            break;
                        }
                    }
                    count_qGDGVKfLPLFA = (ushort)vuread_imBTbVpYXL1c;
            // Read list items
            if (count_qGDGVKfLPLFA > 0) {
                o.ThingSetValue = new HashSet<Thing1>();
                for (int li_a6SNBQYUCyjB = 0; li_a6SNBQYUCyjB < count_qGDGVKfLPLFA; li_a6SNBQYUCyjB++) {
                    o.ThingSetValue.Add((Thing1)Energize(bytes, ref index, 10));
                }
            }
                    return o;
                }
            case 15:
                {
                AbstractThingSetObject o = new AbstractThingSetObject();
                // SET: AbstractThingSetValue
            // Read list item count
            ushort count_giSpdTAbOBZN;
                    ulong vuread_a6PjuvuXXjTf = 0;
                    for (int i_bLxhXhJs7h2X = 0; i_bLxhXhJs7h2X < 9; i_bLxhXhJs7h2X++) {
                        byte b = bytes[index++];
                        if (i_bLxhXhJs7h2X < 8) {
                            vuread_a6PjuvuXXjTf += (((ulong)b & (ulong)127) << (7 * i_bLxhXhJs7h2X));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_a6PjuvuXXjTf += (ulong)b << (7 * i_bLxhXhJs7h2X);
                            break;
                        }
                    }
                    count_giSpdTAbOBZN = (ushort)vuread_a6PjuvuXXjTf;
            // Read list items
            if (count_giSpdTAbOBZN > 0) {
                o.AbstractThingSetValue = new HashSet<AbstractThing>();
                for (int li_ubgwfwMJgeLE = 0; li_ubgwfwMJgeLE < count_giSpdTAbOBZN; li_ubgwfwMJgeLE++) {
                    o.AbstractThingSetValue.Add((AbstractThing)Energize(bytes, ref index));
                }
            }
                    return o;
                }
            case 16:
                {
                VIntSetObject o = new VIntSetObject();
                // SET: VintSetValue
            // Read list item count
            ushort count_aOzhewOgzNlB;
                    ulong vuread_jtoH1GQ4e1ws = 0;
                    for (int i_g8RAGk89a3gi = 0; i_g8RAGk89a3gi < 9; i_g8RAGk89a3gi++) {
                        byte b = bytes[index++];
                        if (i_g8RAGk89a3gi < 8) {
                            vuread_jtoH1GQ4e1ws += (((ulong)b & (ulong)127) << (7 * i_g8RAGk89a3gi));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_jtoH1GQ4e1ws += (ulong)b << (7 * i_g8RAGk89a3gi);
                            break;
                        }
                    }
                    count_aOzhewOgzNlB = (ushort)vuread_jtoH1GQ4e1ws;
            // Read list items
            if (count_aOzhewOgzNlB > 0) {
                o.VintSetValue = new HashSet<int>();
                int listValue_sCoKDWyj0OaW;
                for (int i_deRKxRAirh2g = 0; i_deRKxRAirh2g < count_aOzhewOgzNlB; i_deRKxRAirh2g++) {
                    // Read VInt list item
    byte rvint_b_rnJpOlBCmg0z = bytes[index++];
    byte rvint_sign_hfBrDnBJ74sC = (byte)(rvint_b_rnJpOlBCmg0z & 1);
    byte rvint_size_myMtD81JJi5p = (byte)(rvint_b_rnJpOlBCmg0z >> 1);
    ulong rvint_remaining_fjEPnHKcossr = 0;
    for (int i_giPdPsiU5hWq = 0; i_giPdPsiU5hWq < rvint_size_myMtD81JJi5p - 1; i_giPdPsiU5hWq++) {
        rvint_remaining_fjEPnHKcossr = rvint_remaining_fjEPnHKcossr | (((ulong)bytes[index++] << (8 * i_giPdPsiU5hWq)));
    }
    int rvint_result_oi9noqZjklfu = (int)rvint_remaining_fjEPnHKcossr;
    rvint_result_oi9noqZjklfu = ~rvint_result_oi9noqZjklfu;
    if (rvint_result_oi9noqZjklfu == int.MaxValue) {
        rvint_result_oi9noqZjklfu = int.MinValue;
    }
    else {
        // Add offset
        rvint_result_oi9noqZjklfu += 1;
        if (rvint_sign_hfBrDnBJ74sC == 0) {
            rvint_result_oi9noqZjklfu = -rvint_result_oi9noqZjklfu;
        }
    }
    listValue_sCoKDWyj0OaW = rvint_result_oi9noqZjklfu;
                    o.VintSetValue.Add(listValue_sCoKDWyj0OaW);
                }
            }
                    return o;
                }
                default:
                    throw new SetTestPatternBufferException("Unrecognized type ID: "+typeId+" ");
            }
        }
        public object Energize(byte[] bytes, ref int index) {
                    ulong vuread_sWwAuqnkgudu = 0;
                    for (int i_hX4q9kufwoge = 0; i_hX4q9kufwoge < 9; i_hX4q9kufwoge++) {
                        byte b = bytes[index++];
                        if (i_hX4q9kufwoge < 8) {
                            vuread_sWwAuqnkgudu += (((ulong)b & (ulong)127) << (7 * i_hX4q9kufwoge));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_sWwAuqnkgudu += (ulong)b << (7 * i_hX4q9kufwoge);
                            break;
                        }
                    }
                    ushort typeId = (ushort)vuread_sWwAuqnkgudu;
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
                IntSetObject o = new IntSetObject();
                // SET: IntSetValue
            // Read list item count
            ushort count_owX7Cihdduv2;
                    ulong vuread_ySAO3MjoeO4B = 0;
                    for (int i_jJk9197EQr17 = 0; i_jJk9197EQr17 < 9; i_jJk9197EQr17++) {
                        byte b = bytes[index++];
                        if (i_jJk9197EQr17 < 8) {
                            vuread_ySAO3MjoeO4B += (((ulong)b & (ulong)127) << (7 * i_jJk9197EQr17));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_ySAO3MjoeO4B += (ulong)b << (7 * i_jJk9197EQr17);
                            break;
                        }
                    }
                    count_owX7Cihdduv2 = (ushort)vuread_ySAO3MjoeO4B;
            // Read list items
            if (count_owX7Cihdduv2 > 0) {
                o.IntSetValue = new HashSet<int>();
                int listValue_mqS8n9r8Cbur;
                for (int i_tPlUe1a3BvK2 = 0; i_tPlUe1a3BvK2 < count_owX7Cihdduv2; i_tPlUe1a3BvK2++) {
                    // Read Int list item
                listValue_mqS8n9r8Cbur =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    o.IntSetValue.Add(listValue_mqS8n9r8Cbur);
                }
            }
                    return o;
                }
            case 13:
                {
                StringSetObject o = new StringSetObject();
                // SET: StringSetValue
            // Read list item count
            ushort count_zhmdw1mO0DlN;
                    ulong vuread_xlbex69uo3pm = 0;
                    for (int i_vnzYr8FhPZaf = 0; i_vnzYr8FhPZaf < 9; i_vnzYr8FhPZaf++) {
                        byte b = bytes[index++];
                        if (i_vnzYr8FhPZaf < 8) {
                            vuread_xlbex69uo3pm += (((ulong)b & (ulong)127) << (7 * i_vnzYr8FhPZaf));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_xlbex69uo3pm += (ulong)b << (7 * i_vnzYr8FhPZaf);
                            break;
                        }
                    }
                    count_zhmdw1mO0DlN = (ushort)vuread_xlbex69uo3pm;
            // Read list items
            if (count_zhmdw1mO0DlN > 0) {
                o.StringSetValue = new HashSet<string>();
                string listValue_unLKZQAqDI03;
                for (int i_w5FFwpOe29pj = 0; i_w5FFwpOe29pj < count_zhmdw1mO0DlN; i_w5FFwpOe29pj++) {
                    // Read String list item
                    ulong vuread_jyFIC8SpxF7w = 0;
                    for (int i_maVAl5nX7BiB = 0; i_maVAl5nX7BiB < 9; i_maVAl5nX7BiB++) {
                        byte b = bytes[index++];
                        if (i_maVAl5nX7BiB < 8) {
                            vuread_jyFIC8SpxF7w += (((ulong)b & (ulong)127) << (7 * i_maVAl5nX7BiB));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_jyFIC8SpxF7w += (ulong)b << (7 * i_maVAl5nX7BiB);
                            break;
                        }
                    }
                    ushort stringLength_lxw18e7ek5rk = (ushort)vuread_jyFIC8SpxF7w;
                listValue_unLKZQAqDI03 = Encoding.UTF8.GetString(bytes, index, stringLength_lxw18e7ek5rk);
                index += stringLength_lxw18e7ek5rk;
                    o.StringSetValue.Add(listValue_unLKZQAqDI03);
                }
            }
                    return o;
                }
            case 14:
                {
                Thing1SetObject o = new Thing1SetObject();
                // SET: ThingSetValue
            // Read list item count
            ushort count_iJszLVS5Ovj7;
                    ulong vuread_tfM3raW6zaz7 = 0;
                    for (int i_iH3pSDm3pdp3 = 0; i_iH3pSDm3pdp3 < 9; i_iH3pSDm3pdp3++) {
                        byte b = bytes[index++];
                        if (i_iH3pSDm3pdp3 < 8) {
                            vuread_tfM3raW6zaz7 += (((ulong)b & (ulong)127) << (7 * i_iH3pSDm3pdp3));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_tfM3raW6zaz7 += (ulong)b << (7 * i_iH3pSDm3pdp3);
                            break;
                        }
                    }
                    count_iJszLVS5Ovj7 = (ushort)vuread_tfM3raW6zaz7;
            // Read list items
            if (count_iJszLVS5Ovj7 > 0) {
                o.ThingSetValue = new HashSet<Thing1>();
                for (int li_rtOLWcRh0XPf = 0; li_rtOLWcRh0XPf < count_iJszLVS5Ovj7; li_rtOLWcRh0XPf++) {
                    o.ThingSetValue.Add((Thing1)Energize(bytes, ref index, 10));
                }
            }
                    return o;
                }
            case 15:
                {
                AbstractThingSetObject o = new AbstractThingSetObject();
                // SET: AbstractThingSetValue
            // Read list item count
            ushort count_itG7Pmbskuge;
                    ulong vuread_wDnlipRQ0Tn8 = 0;
                    for (int i_jkjxsrhF1X5y = 0; i_jkjxsrhF1X5y < 9; i_jkjxsrhF1X5y++) {
                        byte b = bytes[index++];
                        if (i_jkjxsrhF1X5y < 8) {
                            vuread_wDnlipRQ0Tn8 += (((ulong)b & (ulong)127) << (7 * i_jkjxsrhF1X5y));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_wDnlipRQ0Tn8 += (ulong)b << (7 * i_jkjxsrhF1X5y);
                            break;
                        }
                    }
                    count_itG7Pmbskuge = (ushort)vuread_wDnlipRQ0Tn8;
            // Read list items
            if (count_itG7Pmbskuge > 0) {
                o.AbstractThingSetValue = new HashSet<AbstractThing>();
                for (int li_ypndb6TvmJTt = 0; li_ypndb6TvmJTt < count_itG7Pmbskuge; li_ypndb6TvmJTt++) {
                    o.AbstractThingSetValue.Add((AbstractThing)Energize(bytes, ref index));
                }
            }
                    return o;
                }
            case 16:
                {
                VIntSetObject o = new VIntSetObject();
                // SET: VintSetValue
            // Read list item count
            ushort count_vG8Kg8pJgHLF;
                    ulong vuread_bOa2nKmeHYo3 = 0;
                    for (int i_aNP4a1VWB0IW = 0; i_aNP4a1VWB0IW < 9; i_aNP4a1VWB0IW++) {
                        byte b = bytes[index++];
                        if (i_aNP4a1VWB0IW < 8) {
                            vuread_bOa2nKmeHYo3 += (((ulong)b & (ulong)127) << (7 * i_aNP4a1VWB0IW));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_bOa2nKmeHYo3 += (ulong)b << (7 * i_aNP4a1VWB0IW);
                            break;
                        }
                    }
                    count_vG8Kg8pJgHLF = (ushort)vuread_bOa2nKmeHYo3;
            // Read list items
            if (count_vG8Kg8pJgHLF > 0) {
                o.VintSetValue = new HashSet<int>();
                int listValue_hGz2IwszNSax;
                for (int i_y0iMwOVasfIC = 0; i_y0iMwOVasfIC < count_vG8Kg8pJgHLF; i_y0iMwOVasfIC++) {
                    // Read VInt list item
    byte rvint_b_ivIoWZemfnJQ = bytes[index++];
    byte rvint_sign_euGlGZptMs8k = (byte)(rvint_b_ivIoWZemfnJQ & 1);
    byte rvint_size_tjzWeIDm76Jn = (byte)(rvint_b_ivIoWZemfnJQ >> 1);
    ulong rvint_remaining_udMYOYrSqBAc = 0;
    for (int i_dKDDZoZbwyFM = 0; i_dKDDZoZbwyFM < rvint_size_tjzWeIDm76Jn - 1; i_dKDDZoZbwyFM++) {
        rvint_remaining_udMYOYrSqBAc = rvint_remaining_udMYOYrSqBAc | (((ulong)bytes[index++] << (8 * i_dKDDZoZbwyFM)));
    }
    int rvint_result_kriHTwSoUtxC = (int)rvint_remaining_udMYOYrSqBAc;
    rvint_result_kriHTwSoUtxC = ~rvint_result_kriHTwSoUtxC;
    if (rvint_result_kriHTwSoUtxC == int.MaxValue) {
        rvint_result_kriHTwSoUtxC = int.MinValue;
    }
    else {
        // Add offset
        rvint_result_kriHTwSoUtxC += 1;
        if (rvint_sign_euGlGZptMs8k == 0) {
            rvint_result_kriHTwSoUtxC = -rvint_result_kriHTwSoUtxC;
        }
    }
    listValue_hGz2IwszNSax = rvint_result_kriHTwSoUtxC;
                    o.VintSetValue.Add(listValue_hGz2IwszNSax);
                }
            }
                    return o;
                }
                default:
                    throw new SetTestPatternBufferException("Unrecognized type ID: "+typeId+" ");
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
                IntSetObject o = new IntSetObject();
                // SET: IntSetValue
            // Read list item count
            ushort count_fBPYaq3rSwND;
                    ulong vuread_baxThI0yI9yw = 0;
                    for (int i_rU83SmsZnaqy = 0; i_rU83SmsZnaqy < 9; i_rU83SmsZnaqy++) {
                        byte b = bytes[index++];
                        if (i_rU83SmsZnaqy < 8) {
                            vuread_baxThI0yI9yw += (((ulong)b & (ulong)127) << (7 * i_rU83SmsZnaqy));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_baxThI0yI9yw += (ulong)b << (7 * i_rU83SmsZnaqy);
                            break;
                        }
                    }
                    count_fBPYaq3rSwND = (ushort)vuread_baxThI0yI9yw;
            // Read list items
            if (count_fBPYaq3rSwND > 0) {
                o.IntSetValue = new HashSet<int>();
                int listValue_oaagFn4dNOCT;
                for (int i_z9gmD84mdtjq = 0; i_z9gmD84mdtjq < count_fBPYaq3rSwND; i_z9gmD84mdtjq++) {
                    // Read Int list item
                listValue_oaagFn4dNOCT =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    o.IntSetValue.Add(listValue_oaagFn4dNOCT);
                }
            }
                    return o;
                }
            case 13:
                {
                StringSetObject o = new StringSetObject();
                // SET: StringSetValue
            // Read list item count
            ushort count_h9JGeYqdU9kh;
                    ulong vuread_oT3vfuSarp3T = 0;
                    for (int i_cfwogeup1UYF = 0; i_cfwogeup1UYF < 9; i_cfwogeup1UYF++) {
                        byte b = bytes[index++];
                        if (i_cfwogeup1UYF < 8) {
                            vuread_oT3vfuSarp3T += (((ulong)b & (ulong)127) << (7 * i_cfwogeup1UYF));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_oT3vfuSarp3T += (ulong)b << (7 * i_cfwogeup1UYF);
                            break;
                        }
                    }
                    count_h9JGeYqdU9kh = (ushort)vuread_oT3vfuSarp3T;
            // Read list items
            if (count_h9JGeYqdU9kh > 0) {
                o.StringSetValue = new HashSet<string>();
                string listValue_qx8Yyz8aZ9OT;
                for (int i_cIhSKi9cfZA9 = 0; i_cIhSKi9cfZA9 < count_h9JGeYqdU9kh; i_cIhSKi9cfZA9++) {
                    // Read String list item
                    ulong vuread_j3M1q33fAMiI = 0;
                    for (int i_yLPSVVzY79ww = 0; i_yLPSVVzY79ww < 9; i_yLPSVVzY79ww++) {
                        byte b = bytes[index++];
                        if (i_yLPSVVzY79ww < 8) {
                            vuread_j3M1q33fAMiI += (((ulong)b & (ulong)127) << (7 * i_yLPSVVzY79ww));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_j3M1q33fAMiI += (ulong)b << (7 * i_yLPSVVzY79ww);
                            break;
                        }
                    }
                    ushort stringLength_mc6QO4pX5xRR = (ushort)vuread_j3M1q33fAMiI;
                listValue_qx8Yyz8aZ9OT = Encoding.UTF8.GetString(bytes, index, stringLength_mc6QO4pX5xRR);
                index += stringLength_mc6QO4pX5xRR;
                    o.StringSetValue.Add(listValue_qx8Yyz8aZ9OT);
                }
            }
                    return o;
                }
            case 14:
                {
                Thing1SetObject o = new Thing1SetObject();
                // SET: ThingSetValue
            // Read list item count
            ushort count_msv4T1XS1zwQ;
                    ulong vuread_nhWm5vIZ3yTd = 0;
                    for (int i_gHbj72UwHpz7 = 0; i_gHbj72UwHpz7 < 9; i_gHbj72UwHpz7++) {
                        byte b = bytes[index++];
                        if (i_gHbj72UwHpz7 < 8) {
                            vuread_nhWm5vIZ3yTd += (((ulong)b & (ulong)127) << (7 * i_gHbj72UwHpz7));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_nhWm5vIZ3yTd += (ulong)b << (7 * i_gHbj72UwHpz7);
                            break;
                        }
                    }
                    count_msv4T1XS1zwQ = (ushort)vuread_nhWm5vIZ3yTd;
            // Read list items
            if (count_msv4T1XS1zwQ > 0) {
                o.ThingSetValue = new HashSet<Thing1>();
                for (int li_o8vIYAQHp8mO = 0; li_o8vIYAQHp8mO < count_msv4T1XS1zwQ; li_o8vIYAQHp8mO++) {
                    o.ThingSetValue.Add((Thing1)Energize(bytes, ref index, 10));
                }
            }
                    return o;
                }
            case 15:
                {
                AbstractThingSetObject o = new AbstractThingSetObject();
                // SET: AbstractThingSetValue
            // Read list item count
            ushort count_zn2LBGCdJsPm;
                    ulong vuread_vOU8P9jqRYO6 = 0;
                    for (int i_z9aDSlXqvxkU = 0; i_z9aDSlXqvxkU < 9; i_z9aDSlXqvxkU++) {
                        byte b = bytes[index++];
                        if (i_z9aDSlXqvxkU < 8) {
                            vuread_vOU8P9jqRYO6 += (((ulong)b & (ulong)127) << (7 * i_z9aDSlXqvxkU));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_vOU8P9jqRYO6 += (ulong)b << (7 * i_z9aDSlXqvxkU);
                            break;
                        }
                    }
                    count_zn2LBGCdJsPm = (ushort)vuread_vOU8P9jqRYO6;
            // Read list items
            if (count_zn2LBGCdJsPm > 0) {
                o.AbstractThingSetValue = new HashSet<AbstractThing>();
                for (int li_ai5bWvxptjSk = 0; li_ai5bWvxptjSk < count_zn2LBGCdJsPm; li_ai5bWvxptjSk++) {
                    o.AbstractThingSetValue.Add((AbstractThing)Energize(bytes, ref index));
                }
            }
                    return o;
                }
            case 16:
                {
                VIntSetObject o = new VIntSetObject();
                // SET: VintSetValue
            // Read list item count
            ushort count_rR2pZ56kJ5MB;
                    ulong vuread_n9vxEz1CEa8G = 0;
                    for (int i_biDwAzN0r0Xa = 0; i_biDwAzN0r0Xa < 9; i_biDwAzN0r0Xa++) {
                        byte b = bytes[index++];
                        if (i_biDwAzN0r0Xa < 8) {
                            vuread_n9vxEz1CEa8G += (((ulong)b & (ulong)127) << (7 * i_biDwAzN0r0Xa));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_n9vxEz1CEa8G += (ulong)b << (7 * i_biDwAzN0r0Xa);
                            break;
                        }
                    }
                    count_rR2pZ56kJ5MB = (ushort)vuread_n9vxEz1CEa8G;
            // Read list items
            if (count_rR2pZ56kJ5MB > 0) {
                o.VintSetValue = new HashSet<int>();
                int listValue_iIBzA9kfGEFX;
                for (int i_zaU3spPOTvkR = 0; i_zaU3spPOTvkR < count_rR2pZ56kJ5MB; i_zaU3spPOTvkR++) {
                    // Read VInt list item
    byte rvint_b_lKTjrWjOlve6 = bytes[index++];
    byte rvint_sign_zBcFZ3aKMQwA = (byte)(rvint_b_lKTjrWjOlve6 & 1);
    byte rvint_size_rUHckiq7xT80 = (byte)(rvint_b_lKTjrWjOlve6 >> 1);
    ulong rvint_remaining_gbXTu0MO5X50 = 0;
    for (int i_fkZ0vKeVnsEH = 0; i_fkZ0vKeVnsEH < rvint_size_rUHckiq7xT80 - 1; i_fkZ0vKeVnsEH++) {
        rvint_remaining_gbXTu0MO5X50 = rvint_remaining_gbXTu0MO5X50 | (((ulong)bytes[index++] << (8 * i_fkZ0vKeVnsEH)));
    }
    int rvint_result_ghEcegIoClpY = (int)rvint_remaining_gbXTu0MO5X50;
    rvint_result_ghEcegIoClpY = ~rvint_result_ghEcegIoClpY;
    if (rvint_result_ghEcegIoClpY == int.MaxValue) {
        rvint_result_ghEcegIoClpY = int.MinValue;
    }
    else {
        // Add offset
        rvint_result_ghEcegIoClpY += 1;
        if (rvint_sign_zBcFZ3aKMQwA == 0) {
            rvint_result_ghEcegIoClpY = -rvint_result_ghEcegIoClpY;
        }
    }
    listValue_iIBzA9kfGEFX = rvint_result_ghEcegIoClpY;
                    o.VintSetValue.Add(listValue_iIBzA9kfGEFX);
                }
            }
                    return o;
                }
                default:
                    throw new SetTestPatternBufferException("Unrecognized type ID: "+typeId+" ");
            }
        }
///////////////////////////////////////
// FROM BYTES (TYPED)
///////////////////////////////////////
        public TYPE Energize< TYPE > (byte[] bytes) {
            object o = this.Energize(bytes);
            if (!(o is TYPE)) {
                throw new SetTestPatternBufferException("Deserialized type (" + o.GetType().Name + ") does not match expected type (" + typeof(TYPE).Name + ").");
            }
            return (TYPE)o;
        }
    }
}
