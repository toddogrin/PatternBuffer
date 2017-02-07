
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
                int i_tvF35zuCDb34;
                for (i_tvF35zuCDb34 = 0; i_tvF35zuCDb34 < 2; i_tvF35zuCDb34++) {
                    if ((ulong)o.IntSetValue.Count < vuBoundaries[i_tvF35zuCDb34]) {
                       byteCount = (int)(i_tvF35zuCDb34 + 1);
                       goto guvsgoto_mmBNkTaK8BEx;
                    }
                }
                byteCount = (int)i_tvF35zuCDb34 + 1;
                guvsgoto_mmBNkTaK8BEx:
                    for (int i_p1he05LmkY6f = 0; i_p1he05LmkY6f < byteCount; i_p1he05LmkY6f++) {
                        if (i_p1he05LmkY6f < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_p1he05LmkY6f < byteCount - 1) {
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
                int i_sVQoVstCsGbt;
                for (i_sVQoVstCsGbt = 0; i_sVQoVstCsGbt < 2; i_sVQoVstCsGbt++) {
                    if ((ulong)o.StringSetValue.Count < vuBoundaries[i_sVQoVstCsGbt]) {
                       byteCount = (int)(i_sVQoVstCsGbt + 1);
                       goto guvsgoto_gy4jgAVUEOO8;
                    }
                }
                byteCount = (int)i_sVQoVstCsGbt + 1;
                guvsgoto_gy4jgAVUEOO8:
                    for (int i_p6UdZrm5yANG = 0; i_p6UdZrm5yANG < byteCount; i_p6UdZrm5yANG++) {
                        if (i_p6UdZrm5yANG < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_p6UdZrm5yANG < byteCount - 1) {
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
                uint stringLength_nkvdqjA7nive;
                int i_rS4mCTJsijSK;
                for (i_rS4mCTJsijSK = 0; i_rS4mCTJsijSK < 2; i_rS4mCTJsijSK++) {
                    if ((ulong)primitive.Length < vuBoundaries[i_rS4mCTJsijSK]) {
                       stringLength_nkvdqjA7nive = (uint)(i_rS4mCTJsijSK + 1);
                       goto guvsgoto_gwB2EDWTwKHk;
                    }
                }
                stringLength_nkvdqjA7nive = (uint)i_rS4mCTJsijSK + 1;
                guvsgoto_gwB2EDWTwKHk:
                if (primitive.Length == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    ulong value = (ulong)primitive.Length;
                    for (int i_ypmjgefDKPYC = 0; i_ypmjgefDKPYC < stringLength_nkvdqjA7nive; i_ypmjgefDKPYC++) {
                        if (i_ypmjgefDKPYC < stringLength_nkvdqjA7nive - 1) {
                            byte b = (byte)(value & 127);
                            if (i_ypmjgefDKPYC < stringLength_nkvdqjA7nive - 1) {
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
                int i_gnFEJd6fO06o;
                for (i_gnFEJd6fO06o = 0; i_gnFEJd6fO06o < 2; i_gnFEJd6fO06o++) {
                    if ((ulong)o.ThingSetValue.Count < vuBoundaries[i_gnFEJd6fO06o]) {
                       byteCount = (int)(i_gnFEJd6fO06o + 1);
                       goto guvsgoto_vtB4N3k4NlyH;
                    }
                }
                byteCount = (int)i_gnFEJd6fO06o + 1;
                guvsgoto_vtB4N3k4NlyH:
                    for (int i_hNNsFeJ94Cwi = 0; i_hNNsFeJ94Cwi < byteCount; i_hNNsFeJ94Cwi++) {
                        if (i_hNNsFeJ94Cwi < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_hNNsFeJ94Cwi < byteCount - 1) {
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
                int i_oL4HTTYaxmN9;
                for (i_oL4HTTYaxmN9 = 0; i_oL4HTTYaxmN9 < 2; i_oL4HTTYaxmN9++) {
                    if ((ulong)o.AbstractThingSetValue.Count < vuBoundaries[i_oL4HTTYaxmN9]) {
                       byteCount = (int)(i_oL4HTTYaxmN9 + 1);
                       goto guvsgoto_hPPo9Y7U1P42;
                    }
                }
                byteCount = (int)i_oL4HTTYaxmN9 + 1;
                guvsgoto_hPPo9Y7U1P42:
                    for (int i_g1zIMyNW1wm3 = 0; i_g1zIMyNW1wm3 < byteCount; i_g1zIMyNW1wm3++) {
                        if (i_g1zIMyNW1wm3 < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_g1zIMyNW1wm3 < byteCount - 1) {
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
                int i_ebqlNwUfcQ8i;
                for (i_ebqlNwUfcQ8i = 0; i_ebqlNwUfcQ8i < 2; i_ebqlNwUfcQ8i++) {
                    if ((ulong)o.VintSetValue.Count < vuBoundaries[i_ebqlNwUfcQ8i]) {
                       byteCount = (int)(i_ebqlNwUfcQ8i + 1);
                       goto guvsgoto_kRf02lxLTUT3;
                    }
                }
                byteCount = (int)i_ebqlNwUfcQ8i + 1;
                guvsgoto_kRf02lxLTUT3:
                    for (int i_kyiDchbmzajc = 0; i_kyiDchbmzajc < byteCount; i_kyiDchbmzajc++) {
                        if (i_kyiDchbmzajc < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_kyiDchbmzajc < byteCount - 1) {
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
    long s2ultemp_q8hmZbpGhGyK = primitive;
    if (s2ultemp_q8hmZbpGhGyK == long.MinValue) {
        s2ultemp_q8hmZbpGhGyK = long.MaxValue;
    }
    else {
        if (s2ultemp_q8hmZbpGhGyK > 0) {
            s2ultemp_q8hmZbpGhGyK = -s2ultemp_q8hmZbpGhGyK;
        }
        s2ultemp_q8hmZbpGhGyK -= 1;
    }
    s2ultemp_q8hmZbpGhGyK = ~s2ultemp_q8hmZbpGhGyK;
    ulong s2ulresult_dBiEMg1RT7BD = (ulong)s2ultemp_q8hmZbpGhGyK;
    //// AppendGetSignVariantSize(s2ulresult_dBiEMg1RT7BD)
    byte vr_b4JMTHDj2nHP = 1;
    for (int v_fHqaACa1aIuK = 56; v_fHqaACa1aIuK >= 0; v_fHqaACa1aIuK -= 8) {
        if (((255UL << v_fHqaACa1aIuK) & s2ulresult_dBiEMg1RT7BD) > 0) {
            vr_b4JMTHDj2nHP = (byte)(v_fHqaACa1aIuK / 8 + 2);
            break;
        }
    }
    bytes[index++] = (byte)((byte)(vr_b4JMTHDj2nHP << 1) | (byte)(primitive > 0 ? 0 : 1));
    for (int vi_zGJsjBtQGOk5 = 0; vi_zGJsjBtQGOk5 < vr_b4JMTHDj2nHP - 1; vi_zGJsjBtQGOk5++) {
        bytes[index++] = (byte)(s2ulresult_dBiEMg1RT7BD & 255);
        s2ulresult_dBiEMg1RT7BD = s2ulresult_dBiEMg1RT7BD >> 8;
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
                    ulong vuread_lNWJdpR44Dqe = 0;
                    for (int i_w0rr6KDDJ9Nm = 0; i_w0rr6KDDJ9Nm < 9; i_w0rr6KDDJ9Nm++) {
                        byte b = bytes[index++];
                        if (i_w0rr6KDDJ9Nm < 8) {
                            vuread_lNWJdpR44Dqe += (((ulong)b & (ulong)127) << (7 * i_w0rr6KDDJ9Nm));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_lNWJdpR44Dqe += (ulong)b << (7 * i_w0rr6KDDJ9Nm);
                            break;
                        }
                    }
                    ushort typeId = (ushort)vuread_lNWJdpR44Dqe;
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
            ushort count_zkaA41iJxuJW;
                    ulong vuread_rAYV0APEpEBs = 0;
                    for (int i_ebT6kQvC9KL2 = 0; i_ebT6kQvC9KL2 < 9; i_ebT6kQvC9KL2++) {
                        byte b = bytes[index++];
                        if (i_ebT6kQvC9KL2 < 8) {
                            vuread_rAYV0APEpEBs += (((ulong)b & (ulong)127) << (7 * i_ebT6kQvC9KL2));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_rAYV0APEpEBs += (ulong)b << (7 * i_ebT6kQvC9KL2);
                            break;
                        }
                    }
                    count_zkaA41iJxuJW = (ushort)vuread_rAYV0APEpEBs;
            // Read list items
            if (count_zkaA41iJxuJW > 0) {
                o.IntSetValue = new HashSet<int>();
                int listValue_gq9duQRFrEMF;
                for (int i_uSNjti6DSRq2 = 0; i_uSNjti6DSRq2 < count_zkaA41iJxuJW; i_uSNjti6DSRq2++) {
                    // Read Int list item
                listValue_gq9duQRFrEMF =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    o.IntSetValue.Add(listValue_gq9duQRFrEMF);
                }
            }
                    return o;
                }
            case 13:
                {
                StringSetObject o = new StringSetObject();
                // SET: StringSetValue
            // Read list item count
            ushort count_dmyQ9gXfZ5GJ;
                    ulong vuread_kMkIW5bPznkC = 0;
                    for (int i_bmj0NhjGah4h = 0; i_bmj0NhjGah4h < 9; i_bmj0NhjGah4h++) {
                        byte b = bytes[index++];
                        if (i_bmj0NhjGah4h < 8) {
                            vuread_kMkIW5bPznkC += (((ulong)b & (ulong)127) << (7 * i_bmj0NhjGah4h));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_kMkIW5bPznkC += (ulong)b << (7 * i_bmj0NhjGah4h);
                            break;
                        }
                    }
                    count_dmyQ9gXfZ5GJ = (ushort)vuread_kMkIW5bPznkC;
            // Read list items
            if (count_dmyQ9gXfZ5GJ > 0) {
                o.StringSetValue = new HashSet<string>();
                string listValue_haGlRGQ0mdTQ;
                for (int i_zxQWQLD4c6NW = 0; i_zxQWQLD4c6NW < count_dmyQ9gXfZ5GJ; i_zxQWQLD4c6NW++) {
                    // Read String list item
                    ulong vuread_k072GtqaDC2p = 0;
                    for (int i_lw0yNafvxToV = 0; i_lw0yNafvxToV < 9; i_lw0yNafvxToV++) {
                        byte b = bytes[index++];
                        if (i_lw0yNafvxToV < 8) {
                            vuread_k072GtqaDC2p += (((ulong)b & (ulong)127) << (7 * i_lw0yNafvxToV));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_k072GtqaDC2p += (ulong)b << (7 * i_lw0yNafvxToV);
                            break;
                        }
                    }
                    ushort stringLength_y6CRW9JtRcrW = (ushort)vuread_k072GtqaDC2p;
                listValue_haGlRGQ0mdTQ = Encoding.UTF8.GetString(bytes, index, stringLength_y6CRW9JtRcrW);
                index += stringLength_y6CRW9JtRcrW;
                    o.StringSetValue.Add(listValue_haGlRGQ0mdTQ);
                }
            }
                    return o;
                }
            case 14:
                {
                Thing1SetObject o = new Thing1SetObject();
                // SET: ThingSetValue
            // Read list item count
            ushort count_c9dmDz85g4x0;
                    ulong vuread_qKySQNtEdmqz = 0;
                    for (int i_dlPR75yPLmXG = 0; i_dlPR75yPLmXG < 9; i_dlPR75yPLmXG++) {
                        byte b = bytes[index++];
                        if (i_dlPR75yPLmXG < 8) {
                            vuread_qKySQNtEdmqz += (((ulong)b & (ulong)127) << (7 * i_dlPR75yPLmXG));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_qKySQNtEdmqz += (ulong)b << (7 * i_dlPR75yPLmXG);
                            break;
                        }
                    }
                    count_c9dmDz85g4x0 = (ushort)vuread_qKySQNtEdmqz;
            // Read list items
            if (count_c9dmDz85g4x0 > 0) {
                o.ThingSetValue = new HashSet<Thing1>();
                for (int li_gdGdE6iG8aUd = 0; li_gdGdE6iG8aUd < count_c9dmDz85g4x0; li_gdGdE6iG8aUd++) {
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
            ushort count_pwPTzUS2TOds;
                    ulong vuread_tq8lFRoBW1CM = 0;
                    for (int i_cq9geTAiAMgK = 0; i_cq9geTAiAMgK < 9; i_cq9geTAiAMgK++) {
                        byte b = bytes[index++];
                        if (i_cq9geTAiAMgK < 8) {
                            vuread_tq8lFRoBW1CM += (((ulong)b & (ulong)127) << (7 * i_cq9geTAiAMgK));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_tq8lFRoBW1CM += (ulong)b << (7 * i_cq9geTAiAMgK);
                            break;
                        }
                    }
                    count_pwPTzUS2TOds = (ushort)vuread_tq8lFRoBW1CM;
            // Read list items
            if (count_pwPTzUS2TOds > 0) {
                o.AbstractThingSetValue = new HashSet<AbstractThing>();
                for (int li_gPp1D5XMaosn = 0; li_gPp1D5XMaosn < count_pwPTzUS2TOds; li_gPp1D5XMaosn++) {
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
            ushort count_z7arWsqU4cNj;
                    ulong vuread_tLX9n52ikx40 = 0;
                    for (int i_lw71e0M27Wih = 0; i_lw71e0M27Wih < 9; i_lw71e0M27Wih++) {
                        byte b = bytes[index++];
                        if (i_lw71e0M27Wih < 8) {
                            vuread_tLX9n52ikx40 += (((ulong)b & (ulong)127) << (7 * i_lw71e0M27Wih));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_tLX9n52ikx40 += (ulong)b << (7 * i_lw71e0M27Wih);
                            break;
                        }
                    }
                    count_z7arWsqU4cNj = (ushort)vuread_tLX9n52ikx40;
            // Read list items
            if (count_z7arWsqU4cNj > 0) {
                o.VintSetValue = new HashSet<int>();
                int listValue_sjvhvvQncgh2;
                for (int i_dXyevkcKckYA = 0; i_dXyevkcKckYA < count_z7arWsqU4cNj; i_dXyevkcKckYA++) {
                    // Read VInt list item
    byte rvint_b_izQdAUm8CQrd = bytes[index++];
    byte rvint_sign_pUWYRRYvofTq = (byte)(rvint_b_izQdAUm8CQrd & 1);
    byte rvint_size_lHGWTHeIu5W6 = (byte)(rvint_b_izQdAUm8CQrd >> 1);
    ulong rvint_remaining_rMWr3jzBGvEK = 0;
    for (int i_ko3vvDlpPzL3 = 0; i_ko3vvDlpPzL3 < rvint_size_lHGWTHeIu5W6 - 1; i_ko3vvDlpPzL3++) {
        rvint_remaining_rMWr3jzBGvEK = rvint_remaining_rMWr3jzBGvEK | (((ulong)bytes[index++] << (8 * i_ko3vvDlpPzL3)));
    }
    int rvint_result_fzo4LSSO8Zie = (int)rvint_remaining_rMWr3jzBGvEK;
    rvint_result_fzo4LSSO8Zie = ~rvint_result_fzo4LSSO8Zie;
    if (rvint_result_fzo4LSSO8Zie == int.MaxValue) {
        rvint_result_fzo4LSSO8Zie = int.MinValue;
    }
    else {
        // Add offset
        rvint_result_fzo4LSSO8Zie += 1;
        if (rvint_sign_pUWYRRYvofTq == 0) {
            rvint_result_fzo4LSSO8Zie = -rvint_result_fzo4LSSO8Zie;
        }
    }
    listValue_sjvhvvQncgh2 = rvint_result_fzo4LSSO8Zie;
                    o.VintSetValue.Add(listValue_sjvhvvQncgh2);
                }
            }
                    return o;
                }
                default:
                    throw new SetTestPatternBufferException("Unrecognized type ID: "+typeId+" ");
            }
        }
        public object Energize(byte[] bytes, ref int index) {
                    ulong vuread_xHCfPsUgc5yF = 0;
                    for (int i_rSm1UGrqa3dE = 0; i_rSm1UGrqa3dE < 9; i_rSm1UGrqa3dE++) {
                        byte b = bytes[index++];
                        if (i_rSm1UGrqa3dE < 8) {
                            vuread_xHCfPsUgc5yF += (((ulong)b & (ulong)127) << (7 * i_rSm1UGrqa3dE));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_xHCfPsUgc5yF += (ulong)b << (7 * i_rSm1UGrqa3dE);
                            break;
                        }
                    }
                    ushort typeId = (ushort)vuread_xHCfPsUgc5yF;
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
            ushort count_xEZXMZMIfYBY;
                    ulong vuread_afKxPF0rbTp3 = 0;
                    for (int i_n04BI2dbD8lk = 0; i_n04BI2dbD8lk < 9; i_n04BI2dbD8lk++) {
                        byte b = bytes[index++];
                        if (i_n04BI2dbD8lk < 8) {
                            vuread_afKxPF0rbTp3 += (((ulong)b & (ulong)127) << (7 * i_n04BI2dbD8lk));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_afKxPF0rbTp3 += (ulong)b << (7 * i_n04BI2dbD8lk);
                            break;
                        }
                    }
                    count_xEZXMZMIfYBY = (ushort)vuread_afKxPF0rbTp3;
            // Read list items
            if (count_xEZXMZMIfYBY > 0) {
                o.IntSetValue = new HashSet<int>();
                int listValue_m6DmtZA0ry0O;
                for (int i_y3LFcVClp6sW = 0; i_y3LFcVClp6sW < count_xEZXMZMIfYBY; i_y3LFcVClp6sW++) {
                    // Read Int list item
                listValue_m6DmtZA0ry0O =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    o.IntSetValue.Add(listValue_m6DmtZA0ry0O);
                }
            }
                    return o;
                }
            case 13:
                {
                StringSetObject o = new StringSetObject();
                // SET: StringSetValue
            // Read list item count
            ushort count_ykanUAvc4z4S;
                    ulong vuread_aN8ltzLh9qFO = 0;
                    for (int i_hI8RF95GORrj = 0; i_hI8RF95GORrj < 9; i_hI8RF95GORrj++) {
                        byte b = bytes[index++];
                        if (i_hI8RF95GORrj < 8) {
                            vuread_aN8ltzLh9qFO += (((ulong)b & (ulong)127) << (7 * i_hI8RF95GORrj));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_aN8ltzLh9qFO += (ulong)b << (7 * i_hI8RF95GORrj);
                            break;
                        }
                    }
                    count_ykanUAvc4z4S = (ushort)vuread_aN8ltzLh9qFO;
            // Read list items
            if (count_ykanUAvc4z4S > 0) {
                o.StringSetValue = new HashSet<string>();
                string listValue_vmg1cYUG92Cy;
                for (int i_ur2ZukWPPv6l = 0; i_ur2ZukWPPv6l < count_ykanUAvc4z4S; i_ur2ZukWPPv6l++) {
                    // Read String list item
                    ulong vuread_iTelF8OyfK3n = 0;
                    for (int i_cflD5MDDq4Ay = 0; i_cflD5MDDq4Ay < 9; i_cflD5MDDq4Ay++) {
                        byte b = bytes[index++];
                        if (i_cflD5MDDq4Ay < 8) {
                            vuread_iTelF8OyfK3n += (((ulong)b & (ulong)127) << (7 * i_cflD5MDDq4Ay));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_iTelF8OyfK3n += (ulong)b << (7 * i_cflD5MDDq4Ay);
                            break;
                        }
                    }
                    ushort stringLength_lOH4ExeuwYvg = (ushort)vuread_iTelF8OyfK3n;
                listValue_vmg1cYUG92Cy = Encoding.UTF8.GetString(bytes, index, stringLength_lOH4ExeuwYvg);
                index += stringLength_lOH4ExeuwYvg;
                    o.StringSetValue.Add(listValue_vmg1cYUG92Cy);
                }
            }
                    return o;
                }
            case 14:
                {
                Thing1SetObject o = new Thing1SetObject();
                // SET: ThingSetValue
            // Read list item count
            ushort count_gZcLYic95WGK;
                    ulong vuread_cKjRRIf1UuXy = 0;
                    for (int i_fKzUu2ZztQ5Q = 0; i_fKzUu2ZztQ5Q < 9; i_fKzUu2ZztQ5Q++) {
                        byte b = bytes[index++];
                        if (i_fKzUu2ZztQ5Q < 8) {
                            vuread_cKjRRIf1UuXy += (((ulong)b & (ulong)127) << (7 * i_fKzUu2ZztQ5Q));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_cKjRRIf1UuXy += (ulong)b << (7 * i_fKzUu2ZztQ5Q);
                            break;
                        }
                    }
                    count_gZcLYic95WGK = (ushort)vuread_cKjRRIf1UuXy;
            // Read list items
            if (count_gZcLYic95WGK > 0) {
                o.ThingSetValue = new HashSet<Thing1>();
                for (int li_ydJ7I4ruJLyu = 0; li_ydJ7I4ruJLyu < count_gZcLYic95WGK; li_ydJ7I4ruJLyu++) {
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
            ushort count_lWWSYJN6bOzo;
                    ulong vuread_srOd6hrzPCVO = 0;
                    for (int i_zis0cDYKmfrH = 0; i_zis0cDYKmfrH < 9; i_zis0cDYKmfrH++) {
                        byte b = bytes[index++];
                        if (i_zis0cDYKmfrH < 8) {
                            vuread_srOd6hrzPCVO += (((ulong)b & (ulong)127) << (7 * i_zis0cDYKmfrH));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_srOd6hrzPCVO += (ulong)b << (7 * i_zis0cDYKmfrH);
                            break;
                        }
                    }
                    count_lWWSYJN6bOzo = (ushort)vuread_srOd6hrzPCVO;
            // Read list items
            if (count_lWWSYJN6bOzo > 0) {
                o.AbstractThingSetValue = new HashSet<AbstractThing>();
                for (int li_chKUc9PqNvpq = 0; li_chKUc9PqNvpq < count_lWWSYJN6bOzo; li_chKUc9PqNvpq++) {
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
            ushort count_goxCt8P9biTQ;
                    ulong vuread_gX3H0YcN9g7Z = 0;
                    for (int i_nGxQXFaN2cKX = 0; i_nGxQXFaN2cKX < 9; i_nGxQXFaN2cKX++) {
                        byte b = bytes[index++];
                        if (i_nGxQXFaN2cKX < 8) {
                            vuread_gX3H0YcN9g7Z += (((ulong)b & (ulong)127) << (7 * i_nGxQXFaN2cKX));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_gX3H0YcN9g7Z += (ulong)b << (7 * i_nGxQXFaN2cKX);
                            break;
                        }
                    }
                    count_goxCt8P9biTQ = (ushort)vuread_gX3H0YcN9g7Z;
            // Read list items
            if (count_goxCt8P9biTQ > 0) {
                o.VintSetValue = new HashSet<int>();
                int listValue_cwrnAsG7y4Eo;
                for (int i_chAYtMqjrI5X = 0; i_chAYtMqjrI5X < count_goxCt8P9biTQ; i_chAYtMqjrI5X++) {
                    // Read VInt list item
    byte rvint_b_p8mGhfXnmfCD = bytes[index++];
    byte rvint_sign_oYmRJ9BLciKQ = (byte)(rvint_b_p8mGhfXnmfCD & 1);
    byte rvint_size_bluqVBGGADMB = (byte)(rvint_b_p8mGhfXnmfCD >> 1);
    ulong rvint_remaining_caZsgqc9P6qE = 0;
    for (int i_kJJrhtUCyFB5 = 0; i_kJJrhtUCyFB5 < rvint_size_bluqVBGGADMB - 1; i_kJJrhtUCyFB5++) {
        rvint_remaining_caZsgqc9P6qE = rvint_remaining_caZsgqc9P6qE | (((ulong)bytes[index++] << (8 * i_kJJrhtUCyFB5)));
    }
    int rvint_result_uHBVI5ddlVLI = (int)rvint_remaining_caZsgqc9P6qE;
    rvint_result_uHBVI5ddlVLI = ~rvint_result_uHBVI5ddlVLI;
    if (rvint_result_uHBVI5ddlVLI == int.MaxValue) {
        rvint_result_uHBVI5ddlVLI = int.MinValue;
    }
    else {
        // Add offset
        rvint_result_uHBVI5ddlVLI += 1;
        if (rvint_sign_oYmRJ9BLciKQ == 0) {
            rvint_result_uHBVI5ddlVLI = -rvint_result_uHBVI5ddlVLI;
        }
    }
    listValue_cwrnAsG7y4Eo = rvint_result_uHBVI5ddlVLI;
                    o.VintSetValue.Add(listValue_cwrnAsG7y4Eo);
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
            ushort count_eiEVgKbh4Z1m;
                    ulong vuread_wpygTkcKJ3GJ = 0;
                    for (int i_vqAT3nsN7bh8 = 0; i_vqAT3nsN7bh8 < 9; i_vqAT3nsN7bh8++) {
                        byte b = bytes[index++];
                        if (i_vqAT3nsN7bh8 < 8) {
                            vuread_wpygTkcKJ3GJ += (((ulong)b & (ulong)127) << (7 * i_vqAT3nsN7bh8));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_wpygTkcKJ3GJ += (ulong)b << (7 * i_vqAT3nsN7bh8);
                            break;
                        }
                    }
                    count_eiEVgKbh4Z1m = (ushort)vuread_wpygTkcKJ3GJ;
            // Read list items
            if (count_eiEVgKbh4Z1m > 0) {
                o.IntSetValue = new HashSet<int>();
                int listValue_v8vXEta6Qo3t;
                for (int i_n6ubTa9pM56Z = 0; i_n6ubTa9pM56Z < count_eiEVgKbh4Z1m; i_n6ubTa9pM56Z++) {
                    // Read Int list item
                listValue_v8vXEta6Qo3t =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    o.IntSetValue.Add(listValue_v8vXEta6Qo3t);
                }
            }
                    return o;
                }
            case 13:
                {
                StringSetObject o = new StringSetObject();
                // SET: StringSetValue
            // Read list item count
            ushort count_eroRGnp0izrU;
                    ulong vuread_vpfp3K3Jxhm6 = 0;
                    for (int i_wr46b1w3cFNm = 0; i_wr46b1w3cFNm < 9; i_wr46b1w3cFNm++) {
                        byte b = bytes[index++];
                        if (i_wr46b1w3cFNm < 8) {
                            vuread_vpfp3K3Jxhm6 += (((ulong)b & (ulong)127) << (7 * i_wr46b1w3cFNm));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_vpfp3K3Jxhm6 += (ulong)b << (7 * i_wr46b1w3cFNm);
                            break;
                        }
                    }
                    count_eroRGnp0izrU = (ushort)vuread_vpfp3K3Jxhm6;
            // Read list items
            if (count_eroRGnp0izrU > 0) {
                o.StringSetValue = new HashSet<string>();
                string listValue_ctAC9dkgPKnD;
                for (int i_xTwcbwCbfrZp = 0; i_xTwcbwCbfrZp < count_eroRGnp0izrU; i_xTwcbwCbfrZp++) {
                    // Read String list item
                    ulong vuread_eBKt7frseAbs = 0;
                    for (int i_mu2PcLhYDkjR = 0; i_mu2PcLhYDkjR < 9; i_mu2PcLhYDkjR++) {
                        byte b = bytes[index++];
                        if (i_mu2PcLhYDkjR < 8) {
                            vuread_eBKt7frseAbs += (((ulong)b & (ulong)127) << (7 * i_mu2PcLhYDkjR));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_eBKt7frseAbs += (ulong)b << (7 * i_mu2PcLhYDkjR);
                            break;
                        }
                    }
                    ushort stringLength_isYrdxSsL3jJ = (ushort)vuread_eBKt7frseAbs;
                listValue_ctAC9dkgPKnD = Encoding.UTF8.GetString(bytes, index, stringLength_isYrdxSsL3jJ);
                index += stringLength_isYrdxSsL3jJ;
                    o.StringSetValue.Add(listValue_ctAC9dkgPKnD);
                }
            }
                    return o;
                }
            case 14:
                {
                Thing1SetObject o = new Thing1SetObject();
                // SET: ThingSetValue
            // Read list item count
            ushort count_g3dr241cJW2K;
                    ulong vuread_ujeaaGk2qGWT = 0;
                    for (int i_ndqaVvg9r2dd = 0; i_ndqaVvg9r2dd < 9; i_ndqaVvg9r2dd++) {
                        byte b = bytes[index++];
                        if (i_ndqaVvg9r2dd < 8) {
                            vuread_ujeaaGk2qGWT += (((ulong)b & (ulong)127) << (7 * i_ndqaVvg9r2dd));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_ujeaaGk2qGWT += (ulong)b << (7 * i_ndqaVvg9r2dd);
                            break;
                        }
                    }
                    count_g3dr241cJW2K = (ushort)vuread_ujeaaGk2qGWT;
            // Read list items
            if (count_g3dr241cJW2K > 0) {
                o.ThingSetValue = new HashSet<Thing1>();
                for (int li_a9AkI9SRBr23 = 0; li_a9AkI9SRBr23 < count_g3dr241cJW2K; li_a9AkI9SRBr23++) {
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
            ushort count_nhX6arAThuVY;
                    ulong vuread_q1qnQ3t4fb8a = 0;
                    for (int i_catrXernkwDO = 0; i_catrXernkwDO < 9; i_catrXernkwDO++) {
                        byte b = bytes[index++];
                        if (i_catrXernkwDO < 8) {
                            vuread_q1qnQ3t4fb8a += (((ulong)b & (ulong)127) << (7 * i_catrXernkwDO));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_q1qnQ3t4fb8a += (ulong)b << (7 * i_catrXernkwDO);
                            break;
                        }
                    }
                    count_nhX6arAThuVY = (ushort)vuread_q1qnQ3t4fb8a;
            // Read list items
            if (count_nhX6arAThuVY > 0) {
                o.AbstractThingSetValue = new HashSet<AbstractThing>();
                for (int li_oj9aBu6RoLGR = 0; li_oj9aBu6RoLGR < count_nhX6arAThuVY; li_oj9aBu6RoLGR++) {
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
            ushort count_tEaI88XFiX09;
                    ulong vuread_yj5cdHOryLPH = 0;
                    for (int i_xsCVeqWFEMHt = 0; i_xsCVeqWFEMHt < 9; i_xsCVeqWFEMHt++) {
                        byte b = bytes[index++];
                        if (i_xsCVeqWFEMHt < 8) {
                            vuread_yj5cdHOryLPH += (((ulong)b & (ulong)127) << (7 * i_xsCVeqWFEMHt));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_yj5cdHOryLPH += (ulong)b << (7 * i_xsCVeqWFEMHt);
                            break;
                        }
                    }
                    count_tEaI88XFiX09 = (ushort)vuread_yj5cdHOryLPH;
            // Read list items
            if (count_tEaI88XFiX09 > 0) {
                o.VintSetValue = new HashSet<int>();
                int listValue_bSpmI7GUs9cs;
                for (int i_k4NQ6psiYDOP = 0; i_k4NQ6psiYDOP < count_tEaI88XFiX09; i_k4NQ6psiYDOP++) {
                    // Read VInt list item
    byte rvint_b_ncA1buFvLM8v = bytes[index++];
    byte rvint_sign_hCSAf5o4qkwk = (byte)(rvint_b_ncA1buFvLM8v & 1);
    byte rvint_size_qfIptzFKdJQG = (byte)(rvint_b_ncA1buFvLM8v >> 1);
    ulong rvint_remaining_nOS8ERQW6sxE = 0;
    for (int i_n2d2oUzwQpo5 = 0; i_n2d2oUzwQpo5 < rvint_size_qfIptzFKdJQG - 1; i_n2d2oUzwQpo5++) {
        rvint_remaining_nOS8ERQW6sxE = rvint_remaining_nOS8ERQW6sxE | (((ulong)bytes[index++] << (8 * i_n2d2oUzwQpo5)));
    }
    int rvint_result_upbmhxrSVm3A = (int)rvint_remaining_nOS8ERQW6sxE;
    rvint_result_upbmhxrSVm3A = ~rvint_result_upbmhxrSVm3A;
    if (rvint_result_upbmhxrSVm3A == int.MaxValue) {
        rvint_result_upbmhxrSVm3A = int.MinValue;
    }
    else {
        // Add offset
        rvint_result_upbmhxrSVm3A += 1;
        if (rvint_sign_hCSAf5o4qkwk == 0) {
            rvint_result_upbmhxrSVm3A = -rvint_result_upbmhxrSVm3A;
        }
    }
    listValue_bSpmI7GUs9cs = rvint_result_upbmhxrSVm3A;
                    o.VintSetValue.Add(listValue_bSpmI7GUs9cs);
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
