
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
                int i_pdhrd7Rct3dZ;
                for (i_pdhrd7Rct3dZ = 0; i_pdhrd7Rct3dZ < 2; i_pdhrd7Rct3dZ++) {
                    if ((ulong)o.IntListValue.Count < vuBoundaries[i_pdhrd7Rct3dZ]) {
                       byteCount = (int)(i_pdhrd7Rct3dZ + 1);
                       goto guvsgoto_usxXZouDxnN3;
                    }
                }
                byteCount = (int)i_pdhrd7Rct3dZ + 1;
                guvsgoto_usxXZouDxnN3:
                    for (int i_e0Z9wv6Oq4AS = 0; i_e0Z9wv6Oq4AS < byteCount; i_e0Z9wv6Oq4AS++) {
                        if (i_e0Z9wv6Oq4AS < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_e0Z9wv6Oq4AS < byteCount - 1) {
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
                int i_o6etFXW4oHM8;
                for (i_o6etFXW4oHM8 = 0; i_o6etFXW4oHM8 < 2; i_o6etFXW4oHM8++) {
                    if ((ulong)o.StringListValue.Count < vuBoundaries[i_o6etFXW4oHM8]) {
                       byteCount = (int)(i_o6etFXW4oHM8 + 1);
                       goto guvsgoto_kwZQM1lL5uGn;
                    }
                }
                byteCount = (int)i_o6etFXW4oHM8 + 1;
                guvsgoto_kwZQM1lL5uGn:
                    for (int i_kvgcq8MRMz2R = 0; i_kvgcq8MRMz2R < byteCount; i_kvgcq8MRMz2R++) {
                        if (i_kvgcq8MRMz2R < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_kvgcq8MRMz2R < byteCount - 1) {
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
                uint stringLength_dbzCSB4ZuLAA;
                int i_tju6SYKidxkE;
                for (i_tju6SYKidxkE = 0; i_tju6SYKidxkE < 2; i_tju6SYKidxkE++) {
                    if ((ulong)primitive.Length < vuBoundaries[i_tju6SYKidxkE]) {
                       stringLength_dbzCSB4ZuLAA = (uint)(i_tju6SYKidxkE + 1);
                       goto guvsgoto_hMjDhGD1U0qq;
                    }
                }
                stringLength_dbzCSB4ZuLAA = (uint)i_tju6SYKidxkE + 1;
                guvsgoto_hMjDhGD1U0qq:
                if (primitive.Length == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    ulong value = (ulong)primitive.Length;
                    for (int i_jumXNXOY4QVO = 0; i_jumXNXOY4QVO < stringLength_dbzCSB4ZuLAA; i_jumXNXOY4QVO++) {
                        if (i_jumXNXOY4QVO < stringLength_dbzCSB4ZuLAA - 1) {
                            byte b = (byte)(value & 127);
                            if (i_jumXNXOY4QVO < stringLength_dbzCSB4ZuLAA - 1) {
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
                int i_d8gFasw3CPgW;
                for (i_d8gFasw3CPgW = 0; i_d8gFasw3CPgW < 2; i_d8gFasw3CPgW++) {
                    if ((ulong)o.ThingListValue.Count < vuBoundaries[i_d8gFasw3CPgW]) {
                       byteCount = (int)(i_d8gFasw3CPgW + 1);
                       goto guvsgoto_vjKg6a6sUjRI;
                    }
                }
                byteCount = (int)i_d8gFasw3CPgW + 1;
                guvsgoto_vjKg6a6sUjRI:
                    for (int i_iQo6mBweyQhJ = 0; i_iQo6mBweyQhJ < byteCount; i_iQo6mBweyQhJ++) {
                        if (i_iQo6mBweyQhJ < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_iQo6mBweyQhJ < byteCount - 1) {
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
                int i_riYMu1ljdXWq;
                for (i_riYMu1ljdXWq = 0; i_riYMu1ljdXWq < 2; i_riYMu1ljdXWq++) {
                    if ((ulong)o.AbstractThingListValue.Count < vuBoundaries[i_riYMu1ljdXWq]) {
                       byteCount = (int)(i_riYMu1ljdXWq + 1);
                       goto guvsgoto_gEldA2ToMNPP;
                    }
                }
                byteCount = (int)i_riYMu1ljdXWq + 1;
                guvsgoto_gEldA2ToMNPP:
                    for (int i_uaftXNkB0HrF = 0; i_uaftXNkB0HrF < byteCount; i_uaftXNkB0HrF++) {
                        if (i_uaftXNkB0HrF < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_uaftXNkB0HrF < byteCount - 1) {
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
                int i_qTUGE7GAS5qA;
                for (i_qTUGE7GAS5qA = 0; i_qTUGE7GAS5qA < 2; i_qTUGE7GAS5qA++) {
                    if ((ulong)o.VintListValue.Count < vuBoundaries[i_qTUGE7GAS5qA]) {
                       byteCount = (int)(i_qTUGE7GAS5qA + 1);
                       goto guvsgoto_ctCJ51jQaJqd;
                    }
                }
                byteCount = (int)i_qTUGE7GAS5qA + 1;
                guvsgoto_ctCJ51jQaJqd:
                    for (int i_uzA8DoYj1tGa = 0; i_uzA8DoYj1tGa < byteCount; i_uzA8DoYj1tGa++) {
                        if (i_uzA8DoYj1tGa < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_uzA8DoYj1tGa < byteCount - 1) {
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
    long s2ultemp_kLnlNfqnTcQd = primitive;
    if (s2ultemp_kLnlNfqnTcQd == long.MinValue) {
        s2ultemp_kLnlNfqnTcQd = long.MaxValue;
    }
    else {
        if (s2ultemp_kLnlNfqnTcQd > 0) {
            s2ultemp_kLnlNfqnTcQd = -s2ultemp_kLnlNfqnTcQd;
        }
        s2ultemp_kLnlNfqnTcQd -= 1;
    }
    s2ultemp_kLnlNfqnTcQd = ~s2ultemp_kLnlNfqnTcQd;
    ulong s2ulresult_xO63a0XlccXG = (ulong)s2ultemp_kLnlNfqnTcQd;
    //// AppendGetSignVariantSize(s2ulresult_xO63a0XlccXG)
    byte vr_lknVUhmtnTh2 = 1;
    for (int v_svWMOdQUSxfY = 56; v_svWMOdQUSxfY >= 0; v_svWMOdQUSxfY -= 8) {
        if (((255UL << v_svWMOdQUSxfY) & s2ulresult_xO63a0XlccXG) > 0) {
            vr_lknVUhmtnTh2 = (byte)(v_svWMOdQUSxfY / 8 + 2);
            break;
        }
    }
    bytes[index++] = (byte)((byte)(vr_lknVUhmtnTh2 << 1) | (byte)(primitive > 0 ? 0 : 1));
    for (int vi_h4iaGu8wYRUC = 0; vi_h4iaGu8wYRUC < vr_lknVUhmtnTh2 - 1; vi_h4iaGu8wYRUC++) {
        bytes[index++] = (byte)(s2ulresult_xO63a0XlccXG & 255);
        s2ulresult_xO63a0XlccXG = s2ulresult_xO63a0XlccXG >> 8;
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
                    ulong vuread_wECMZx0kHdkP = 0;
                    for (int i_bkG9vcXdfyD0 = 0; i_bkG9vcXdfyD0 < 9; i_bkG9vcXdfyD0++) {
                        byte b = bytes[index++];
                        if (i_bkG9vcXdfyD0 < 8) {
                            vuread_wECMZx0kHdkP += (((ulong)b & (ulong)127) << (7 * i_bkG9vcXdfyD0));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_wECMZx0kHdkP += (ulong)b << (7 * i_bkG9vcXdfyD0);
                            break;
                        }
                    }
                    ushort typeId = (ushort)vuread_wECMZx0kHdkP;
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
            ushort count_zlX2UUdbLuUk;
                    ulong vuread_pe4vG4roUC7v = 0;
                    for (int i_v9aW4QwDaMNO = 0; i_v9aW4QwDaMNO < 9; i_v9aW4QwDaMNO++) {
                        byte b = bytes[index++];
                        if (i_v9aW4QwDaMNO < 8) {
                            vuread_pe4vG4roUC7v += (((ulong)b & (ulong)127) << (7 * i_v9aW4QwDaMNO));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_pe4vG4roUC7v += (ulong)b << (7 * i_v9aW4QwDaMNO);
                            break;
                        }
                    }
                    count_zlX2UUdbLuUk = (ushort)vuread_pe4vG4roUC7v;
            // Read list items
            if (count_zlX2UUdbLuUk > 0) {
                o.IntListValue = new List<int>();
                int listValue_p7zWajeTAwyr;
                for (int i_dBGlhpgGnBeV = 0; i_dBGlhpgGnBeV < count_zlX2UUdbLuUk; i_dBGlhpgGnBeV++) {
                    // Read Int list item
                listValue_p7zWajeTAwyr =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    o.IntListValue.Add(listValue_p7zWajeTAwyr);
                }
            }
                    return o;
                }
            case 13:
                {
                StringListObject o = new StringListObject();
                // LIST: StringListValue
            // Read list item count
            ushort count_trg47qj8BpVJ;
                    ulong vuread_mEoKxo5BKTOC = 0;
                    for (int i_elvVGgAi3OdS = 0; i_elvVGgAi3OdS < 9; i_elvVGgAi3OdS++) {
                        byte b = bytes[index++];
                        if (i_elvVGgAi3OdS < 8) {
                            vuread_mEoKxo5BKTOC += (((ulong)b & (ulong)127) << (7 * i_elvVGgAi3OdS));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_mEoKxo5BKTOC += (ulong)b << (7 * i_elvVGgAi3OdS);
                            break;
                        }
                    }
                    count_trg47qj8BpVJ = (ushort)vuread_mEoKxo5BKTOC;
            // Read list items
            if (count_trg47qj8BpVJ > 0) {
                o.StringListValue = new List<string>();
                string listValue_bkVjnAZ1Q7QN;
                for (int i_aFi9GMk9MNUV = 0; i_aFi9GMk9MNUV < count_trg47qj8BpVJ; i_aFi9GMk9MNUV++) {
                    // Read String list item
                    ulong vuread_lVok4WWmESTb = 0;
                    for (int i_yALrDdgyzaoZ = 0; i_yALrDdgyzaoZ < 9; i_yALrDdgyzaoZ++) {
                        byte b = bytes[index++];
                        if (i_yALrDdgyzaoZ < 8) {
                            vuread_lVok4WWmESTb += (((ulong)b & (ulong)127) << (7 * i_yALrDdgyzaoZ));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_lVok4WWmESTb += (ulong)b << (7 * i_yALrDdgyzaoZ);
                            break;
                        }
                    }
                    ushort stringLength_xxBvZNP0AFIn = (ushort)vuread_lVok4WWmESTb;
                listValue_bkVjnAZ1Q7QN = Encoding.UTF8.GetString(bytes, index, stringLength_xxBvZNP0AFIn);
                index += stringLength_xxBvZNP0AFIn;
                    o.StringListValue.Add(listValue_bkVjnAZ1Q7QN);
                }
            }
                    return o;
                }
            case 14:
                {
                Thing1ListObject o = new Thing1ListObject();
                // LIST: ThingListValue
            // Read list item count
            ushort count_zEccs0mG64HU;
                    ulong vuread_k9fZ0IrmNAxy = 0;
                    for (int i_aywwyjYCGymz = 0; i_aywwyjYCGymz < 9; i_aywwyjYCGymz++) {
                        byte b = bytes[index++];
                        if (i_aywwyjYCGymz < 8) {
                            vuread_k9fZ0IrmNAxy += (((ulong)b & (ulong)127) << (7 * i_aywwyjYCGymz));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_k9fZ0IrmNAxy += (ulong)b << (7 * i_aywwyjYCGymz);
                            break;
                        }
                    }
                    count_zEccs0mG64HU = (ushort)vuread_k9fZ0IrmNAxy;
            // Read list items
            if (count_zEccs0mG64HU > 0) {
                o.ThingListValue = new List<Thing1>();
                for (int li_tU3NFnec202D = 0; li_tU3NFnec202D < count_zEccs0mG64HU; li_tU3NFnec202D++) {
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
            ushort count_zqH1ScmHgOa3;
                    ulong vuread_mZhWgfnaXPfg = 0;
                    for (int i_qNQAvvFlF3yi = 0; i_qNQAvvFlF3yi < 9; i_qNQAvvFlF3yi++) {
                        byte b = bytes[index++];
                        if (i_qNQAvvFlF3yi < 8) {
                            vuread_mZhWgfnaXPfg += (((ulong)b & (ulong)127) << (7 * i_qNQAvvFlF3yi));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_mZhWgfnaXPfg += (ulong)b << (7 * i_qNQAvvFlF3yi);
                            break;
                        }
                    }
                    count_zqH1ScmHgOa3 = (ushort)vuread_mZhWgfnaXPfg;
            // Read list items
            if (count_zqH1ScmHgOa3 > 0) {
                o.AbstractThingListValue = new List<AbstractThing>();
                for (int li_p6TEmOtfUakQ = 0; li_p6TEmOtfUakQ < count_zqH1ScmHgOa3; li_p6TEmOtfUakQ++) {
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
            ushort count_cr5XM2QtkBne;
                    ulong vuread_jVmViYyKB9kk = 0;
                    for (int i_jTXjvawODaue = 0; i_jTXjvawODaue < 9; i_jTXjvawODaue++) {
                        byte b = bytes[index++];
                        if (i_jTXjvawODaue < 8) {
                            vuread_jVmViYyKB9kk += (((ulong)b & (ulong)127) << (7 * i_jTXjvawODaue));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_jVmViYyKB9kk += (ulong)b << (7 * i_jTXjvawODaue);
                            break;
                        }
                    }
                    count_cr5XM2QtkBne = (ushort)vuread_jVmViYyKB9kk;
            // Read list items
            if (count_cr5XM2QtkBne > 0) {
                o.VintListValue = new List<int>();
                int listValue_kSINne7kTOhA;
                for (int i_lH65MJoggVA3 = 0; i_lH65MJoggVA3 < count_cr5XM2QtkBne; i_lH65MJoggVA3++) {
                    // Read VInt list item
    byte rvint_b_cG7kfILwBhwA = bytes[index++];
    byte rvint_sign_gUxxbaARLxRY = (byte)(rvint_b_cG7kfILwBhwA & 1);
    byte rvint_size_bAc4Vn7OrPIQ = (byte)(rvint_b_cG7kfILwBhwA >> 1);
    ulong rvint_remaining_cXfkdV8ulGO1 = 0;
    for (int i_e1fguTrRZjgO = 0; i_e1fguTrRZjgO < rvint_size_bAc4Vn7OrPIQ - 1; i_e1fguTrRZjgO++) {
        rvint_remaining_cXfkdV8ulGO1 = rvint_remaining_cXfkdV8ulGO1 | (((ulong)bytes[index++] << (8 * i_e1fguTrRZjgO)));
    }
    int rvint_result_nRKokRjLmRpn = (int)rvint_remaining_cXfkdV8ulGO1;
    rvint_result_nRKokRjLmRpn = ~rvint_result_nRKokRjLmRpn;
    if (rvint_result_nRKokRjLmRpn == int.MaxValue) {
        rvint_result_nRKokRjLmRpn = int.MinValue;
    }
    else {
        // Add offset
        rvint_result_nRKokRjLmRpn += 1;
        if (rvint_sign_gUxxbaARLxRY == 0) {
            rvint_result_nRKokRjLmRpn = -rvint_result_nRKokRjLmRpn;
        }
    }
    listValue_kSINne7kTOhA = rvint_result_nRKokRjLmRpn;
                    o.VintListValue.Add(listValue_kSINne7kTOhA);
                }
            }
                    return o;
                }
                default:
                    throw new ListTestPatternBufferException("Unrecognized type ID: "+typeId+" ");
            }
        }
        public object Energize(byte[] bytes, ref int index) {
                    ulong vuread_xqO0ywMHVkS4 = 0;
                    for (int i_d0tIx007QANv = 0; i_d0tIx007QANv < 9; i_d0tIx007QANv++) {
                        byte b = bytes[index++];
                        if (i_d0tIx007QANv < 8) {
                            vuread_xqO0ywMHVkS4 += (((ulong)b & (ulong)127) << (7 * i_d0tIx007QANv));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_xqO0ywMHVkS4 += (ulong)b << (7 * i_d0tIx007QANv);
                            break;
                        }
                    }
                    ushort typeId = (ushort)vuread_xqO0ywMHVkS4;
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
            ushort count_eUjDwdODL2me;
                    ulong vuread_bBtDHJ2w8Pgu = 0;
                    for (int i_kKnv1sGDMsON = 0; i_kKnv1sGDMsON < 9; i_kKnv1sGDMsON++) {
                        byte b = bytes[index++];
                        if (i_kKnv1sGDMsON < 8) {
                            vuread_bBtDHJ2w8Pgu += (((ulong)b & (ulong)127) << (7 * i_kKnv1sGDMsON));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_bBtDHJ2w8Pgu += (ulong)b << (7 * i_kKnv1sGDMsON);
                            break;
                        }
                    }
                    count_eUjDwdODL2me = (ushort)vuread_bBtDHJ2w8Pgu;
            // Read list items
            if (count_eUjDwdODL2me > 0) {
                o.IntListValue = new List<int>();
                int listValue_fikSFptoOpD6;
                for (int i_oxAhHrxGNZfV = 0; i_oxAhHrxGNZfV < count_eUjDwdODL2me; i_oxAhHrxGNZfV++) {
                    // Read Int list item
                listValue_fikSFptoOpD6 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    o.IntListValue.Add(listValue_fikSFptoOpD6);
                }
            }
                    return o;
                }
            case 13:
                {
                StringListObject o = new StringListObject();
                // LIST: StringListValue
            // Read list item count
            ushort count_vtMtvSBVWPpz;
                    ulong vuread_kk0Tw2QihrXD = 0;
                    for (int i_wz5v4iaxcy2m = 0; i_wz5v4iaxcy2m < 9; i_wz5v4iaxcy2m++) {
                        byte b = bytes[index++];
                        if (i_wz5v4iaxcy2m < 8) {
                            vuread_kk0Tw2QihrXD += (((ulong)b & (ulong)127) << (7 * i_wz5v4iaxcy2m));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_kk0Tw2QihrXD += (ulong)b << (7 * i_wz5v4iaxcy2m);
                            break;
                        }
                    }
                    count_vtMtvSBVWPpz = (ushort)vuread_kk0Tw2QihrXD;
            // Read list items
            if (count_vtMtvSBVWPpz > 0) {
                o.StringListValue = new List<string>();
                string listValue_q935YSj2hbSx;
                for (int i_lOjVj6OIFjB6 = 0; i_lOjVj6OIFjB6 < count_vtMtvSBVWPpz; i_lOjVj6OIFjB6++) {
                    // Read String list item
                    ulong vuread_zUuyh4w0RI3q = 0;
                    for (int i_zoofTuQDI6iR = 0; i_zoofTuQDI6iR < 9; i_zoofTuQDI6iR++) {
                        byte b = bytes[index++];
                        if (i_zoofTuQDI6iR < 8) {
                            vuread_zUuyh4w0RI3q += (((ulong)b & (ulong)127) << (7 * i_zoofTuQDI6iR));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_zUuyh4w0RI3q += (ulong)b << (7 * i_zoofTuQDI6iR);
                            break;
                        }
                    }
                    ushort stringLength_ug0OO2wasNgw = (ushort)vuread_zUuyh4w0RI3q;
                listValue_q935YSj2hbSx = Encoding.UTF8.GetString(bytes, index, stringLength_ug0OO2wasNgw);
                index += stringLength_ug0OO2wasNgw;
                    o.StringListValue.Add(listValue_q935YSj2hbSx);
                }
            }
                    return o;
                }
            case 14:
                {
                Thing1ListObject o = new Thing1ListObject();
                // LIST: ThingListValue
            // Read list item count
            ushort count_wFopORfXHXWy;
                    ulong vuread_ppALWKpomKPz = 0;
                    for (int i_qqq77NXcMMHM = 0; i_qqq77NXcMMHM < 9; i_qqq77NXcMMHM++) {
                        byte b = bytes[index++];
                        if (i_qqq77NXcMMHM < 8) {
                            vuread_ppALWKpomKPz += (((ulong)b & (ulong)127) << (7 * i_qqq77NXcMMHM));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_ppALWKpomKPz += (ulong)b << (7 * i_qqq77NXcMMHM);
                            break;
                        }
                    }
                    count_wFopORfXHXWy = (ushort)vuread_ppALWKpomKPz;
            // Read list items
            if (count_wFopORfXHXWy > 0) {
                o.ThingListValue = new List<Thing1>();
                for (int li_rhl9DfSlCZED = 0; li_rhl9DfSlCZED < count_wFopORfXHXWy; li_rhl9DfSlCZED++) {
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
            ushort count_xfQ8R3FrZYLy;
                    ulong vuread_lh049UW9SX4P = 0;
                    for (int i_kpVg1E7YWWd1 = 0; i_kpVg1E7YWWd1 < 9; i_kpVg1E7YWWd1++) {
                        byte b = bytes[index++];
                        if (i_kpVg1E7YWWd1 < 8) {
                            vuread_lh049UW9SX4P += (((ulong)b & (ulong)127) << (7 * i_kpVg1E7YWWd1));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_lh049UW9SX4P += (ulong)b << (7 * i_kpVg1E7YWWd1);
                            break;
                        }
                    }
                    count_xfQ8R3FrZYLy = (ushort)vuread_lh049UW9SX4P;
            // Read list items
            if (count_xfQ8R3FrZYLy > 0) {
                o.AbstractThingListValue = new List<AbstractThing>();
                for (int li_yZuShqX2GXIv = 0; li_yZuShqX2GXIv < count_xfQ8R3FrZYLy; li_yZuShqX2GXIv++) {
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
            ushort count_gYlScEVglaJC;
                    ulong vuread_dyzu1WMPd96k = 0;
                    for (int i_ke1CabjLRz1d = 0; i_ke1CabjLRz1d < 9; i_ke1CabjLRz1d++) {
                        byte b = bytes[index++];
                        if (i_ke1CabjLRz1d < 8) {
                            vuread_dyzu1WMPd96k += (((ulong)b & (ulong)127) << (7 * i_ke1CabjLRz1d));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_dyzu1WMPd96k += (ulong)b << (7 * i_ke1CabjLRz1d);
                            break;
                        }
                    }
                    count_gYlScEVglaJC = (ushort)vuread_dyzu1WMPd96k;
            // Read list items
            if (count_gYlScEVglaJC > 0) {
                o.VintListValue = new List<int>();
                int listValue_ipWrb7Q7p2KS;
                for (int i_wCbTk2sq1as8 = 0; i_wCbTk2sq1as8 < count_gYlScEVglaJC; i_wCbTk2sq1as8++) {
                    // Read VInt list item
    byte rvint_b_qsgj07USHvbL = bytes[index++];
    byte rvint_sign_zuNfs94HDjMH = (byte)(rvint_b_qsgj07USHvbL & 1);
    byte rvint_size_aAAYgLms6XOS = (byte)(rvint_b_qsgj07USHvbL >> 1);
    ulong rvint_remaining_wHgsh1kEAzT0 = 0;
    for (int i_gm71gUEDQIiA = 0; i_gm71gUEDQIiA < rvint_size_aAAYgLms6XOS - 1; i_gm71gUEDQIiA++) {
        rvint_remaining_wHgsh1kEAzT0 = rvint_remaining_wHgsh1kEAzT0 | (((ulong)bytes[index++] << (8 * i_gm71gUEDQIiA)));
    }
    int rvint_result_n6M6jTPmQ5oV = (int)rvint_remaining_wHgsh1kEAzT0;
    rvint_result_n6M6jTPmQ5oV = ~rvint_result_n6M6jTPmQ5oV;
    if (rvint_result_n6M6jTPmQ5oV == int.MaxValue) {
        rvint_result_n6M6jTPmQ5oV = int.MinValue;
    }
    else {
        // Add offset
        rvint_result_n6M6jTPmQ5oV += 1;
        if (rvint_sign_zuNfs94HDjMH == 0) {
            rvint_result_n6M6jTPmQ5oV = -rvint_result_n6M6jTPmQ5oV;
        }
    }
    listValue_ipWrb7Q7p2KS = rvint_result_n6M6jTPmQ5oV;
                    o.VintListValue.Add(listValue_ipWrb7Q7p2KS);
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
            ushort count_xMzM8hhKQKJ3;
                    ulong vuread_qumlslctyQVl = 0;
                    for (int i_govRUHku8m8D = 0; i_govRUHku8m8D < 9; i_govRUHku8m8D++) {
                        byte b = bytes[index++];
                        if (i_govRUHku8m8D < 8) {
                            vuread_qumlslctyQVl += (((ulong)b & (ulong)127) << (7 * i_govRUHku8m8D));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_qumlslctyQVl += (ulong)b << (7 * i_govRUHku8m8D);
                            break;
                        }
                    }
                    count_xMzM8hhKQKJ3 = (ushort)vuread_qumlslctyQVl;
            // Read list items
            if (count_xMzM8hhKQKJ3 > 0) {
                o.IntListValue = new List<int>();
                int listValue_i2EJBIU6wSsZ;
                for (int i_nD3E24xn1oxU = 0; i_nD3E24xn1oxU < count_xMzM8hhKQKJ3; i_nD3E24xn1oxU++) {
                    // Read Int list item
                listValue_i2EJBIU6wSsZ =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    o.IntListValue.Add(listValue_i2EJBIU6wSsZ);
                }
            }
                    return o;
                }
            case 13:
                {
                StringListObject o = new StringListObject();
                // LIST: StringListValue
            // Read list item count
            ushort count_uz0iAp4BvT0A;
                    ulong vuread_rD105YYG5Gkr = 0;
                    for (int i_qPBdZVLgFUXb = 0; i_qPBdZVLgFUXb < 9; i_qPBdZVLgFUXb++) {
                        byte b = bytes[index++];
                        if (i_qPBdZVLgFUXb < 8) {
                            vuread_rD105YYG5Gkr += (((ulong)b & (ulong)127) << (7 * i_qPBdZVLgFUXb));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_rD105YYG5Gkr += (ulong)b << (7 * i_qPBdZVLgFUXb);
                            break;
                        }
                    }
                    count_uz0iAp4BvT0A = (ushort)vuread_rD105YYG5Gkr;
            // Read list items
            if (count_uz0iAp4BvT0A > 0) {
                o.StringListValue = new List<string>();
                string listValue_sLFhX1DXMCXz;
                for (int i_bGrcz0YpoIEV = 0; i_bGrcz0YpoIEV < count_uz0iAp4BvT0A; i_bGrcz0YpoIEV++) {
                    // Read String list item
                    ulong vuread_hRTecxOl1cas = 0;
                    for (int i_mJQO5HXjgUt6 = 0; i_mJQO5HXjgUt6 < 9; i_mJQO5HXjgUt6++) {
                        byte b = bytes[index++];
                        if (i_mJQO5HXjgUt6 < 8) {
                            vuread_hRTecxOl1cas += (((ulong)b & (ulong)127) << (7 * i_mJQO5HXjgUt6));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_hRTecxOl1cas += (ulong)b << (7 * i_mJQO5HXjgUt6);
                            break;
                        }
                    }
                    ushort stringLength_u1MKhT56P0iu = (ushort)vuread_hRTecxOl1cas;
                listValue_sLFhX1DXMCXz = Encoding.UTF8.GetString(bytes, index, stringLength_u1MKhT56P0iu);
                index += stringLength_u1MKhT56P0iu;
                    o.StringListValue.Add(listValue_sLFhX1DXMCXz);
                }
            }
                    return o;
                }
            case 14:
                {
                Thing1ListObject o = new Thing1ListObject();
                // LIST: ThingListValue
            // Read list item count
            ushort count_g2Q2H1Tmy6TS;
                    ulong vuread_cTn13t4W0tgI = 0;
                    for (int i_bqbid9nIxXZj = 0; i_bqbid9nIxXZj < 9; i_bqbid9nIxXZj++) {
                        byte b = bytes[index++];
                        if (i_bqbid9nIxXZj < 8) {
                            vuread_cTn13t4W0tgI += (((ulong)b & (ulong)127) << (7 * i_bqbid9nIxXZj));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_cTn13t4W0tgI += (ulong)b << (7 * i_bqbid9nIxXZj);
                            break;
                        }
                    }
                    count_g2Q2H1Tmy6TS = (ushort)vuread_cTn13t4W0tgI;
            // Read list items
            if (count_g2Q2H1Tmy6TS > 0) {
                o.ThingListValue = new List<Thing1>();
                for (int li_rWNasX3HZ8Im = 0; li_rWNasX3HZ8Im < count_g2Q2H1Tmy6TS; li_rWNasX3HZ8Im++) {
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
            ushort count_i5pX0Hf4WiZq;
                    ulong vuread_vLjzTlut3dlh = 0;
                    for (int i_r3DcAISfSYXh = 0; i_r3DcAISfSYXh < 9; i_r3DcAISfSYXh++) {
                        byte b = bytes[index++];
                        if (i_r3DcAISfSYXh < 8) {
                            vuread_vLjzTlut3dlh += (((ulong)b & (ulong)127) << (7 * i_r3DcAISfSYXh));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_vLjzTlut3dlh += (ulong)b << (7 * i_r3DcAISfSYXh);
                            break;
                        }
                    }
                    count_i5pX0Hf4WiZq = (ushort)vuread_vLjzTlut3dlh;
            // Read list items
            if (count_i5pX0Hf4WiZq > 0) {
                o.AbstractThingListValue = new List<AbstractThing>();
                for (int li_tzS0R4wH6xkR = 0; li_tzS0R4wH6xkR < count_i5pX0Hf4WiZq; li_tzS0R4wH6xkR++) {
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
            ushort count_qEYNNosrThi6;
                    ulong vuread_bdEozUIbXcPt = 0;
                    for (int i_mEM8QNksTWy6 = 0; i_mEM8QNksTWy6 < 9; i_mEM8QNksTWy6++) {
                        byte b = bytes[index++];
                        if (i_mEM8QNksTWy6 < 8) {
                            vuread_bdEozUIbXcPt += (((ulong)b & (ulong)127) << (7 * i_mEM8QNksTWy6));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_bdEozUIbXcPt += (ulong)b << (7 * i_mEM8QNksTWy6);
                            break;
                        }
                    }
                    count_qEYNNosrThi6 = (ushort)vuread_bdEozUIbXcPt;
            // Read list items
            if (count_qEYNNosrThi6 > 0) {
                o.VintListValue = new List<int>();
                int listValue_tfCDGGxMrVWO;
                for (int i_liimYi3LYFli = 0; i_liimYi3LYFli < count_qEYNNosrThi6; i_liimYi3LYFli++) {
                    // Read VInt list item
    byte rvint_b_qtKg7ZmrOIEu = bytes[index++];
    byte rvint_sign_heFrOdbQR7II = (byte)(rvint_b_qtKg7ZmrOIEu & 1);
    byte rvint_size_m7DK3Who4t0m = (byte)(rvint_b_qtKg7ZmrOIEu >> 1);
    ulong rvint_remaining_yrOBJF92NY4U = 0;
    for (int i_qL7UDEAOVcL9 = 0; i_qL7UDEAOVcL9 < rvint_size_m7DK3Who4t0m - 1; i_qL7UDEAOVcL9++) {
        rvint_remaining_yrOBJF92NY4U = rvint_remaining_yrOBJF92NY4U | (((ulong)bytes[index++] << (8 * i_qL7UDEAOVcL9)));
    }
    int rvint_result_jMx2ApA8nsww = (int)rvint_remaining_yrOBJF92NY4U;
    rvint_result_jMx2ApA8nsww = ~rvint_result_jMx2ApA8nsww;
    if (rvint_result_jMx2ApA8nsww == int.MaxValue) {
        rvint_result_jMx2ApA8nsww = int.MinValue;
    }
    else {
        // Add offset
        rvint_result_jMx2ApA8nsww += 1;
        if (rvint_sign_heFrOdbQR7II == 0) {
            rvint_result_jMx2ApA8nsww = -rvint_result_jMx2ApA8nsww;
        }
    }
    listValue_tfCDGGxMrVWO = rvint_result_jMx2ApA8nsww;
                    o.VintListValue.Add(listValue_tfCDGGxMrVWO);
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
