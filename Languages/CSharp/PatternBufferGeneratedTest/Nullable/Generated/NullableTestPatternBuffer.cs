
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System.Text;
using System;
using System.Collections.Generic;

namespace Test.Nullable {
    public class NullableTestPatternBuffer {
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
        private INullableTestInstantiator instantiator;
        public NullableTestPatternBuffer() : this(4096, new DefaultNullableTestInstantiator()) { }
        public NullableTestPatternBuffer(uint bufferSize) : this (bufferSize, new DefaultNullableTestInstantiator()) { }
        public NullableTestPatternBuffer(INullableTestInstantiator instantiator) : this (4096, instantiator) { }
        public NullableTestPatternBuffer(uint bufferSize, INullableTestInstantiator instantiator) {
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
        public byte[] Energize(ThingContainer o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(ThingContainer3 o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(DerivedType1 o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(DerivedType2 o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(BaseTypeContainer o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(ListContainer o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(SetContainer o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(MapContainer o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(IntThingContainerMap o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(AutogenerateTest o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public void Energize(Thing o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 7;
            }
                // PRIMITIVE: Value
                bytes[index++] = (byte)((o.Value >> 24) & 255);
                bytes[index++] = (byte)((o.Value >> 16) & 255);
                bytes[index++] = (byte)((o.Value >> 8) & 255);
                bytes[index++] = (byte)(o.Value & 255);
        }
        public void Energize(ThingContainer o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 8;
            }
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                bytes[index++] = 0;
                bytes[index++] = 0;
                nullFlagsIndex++;
                // REFERENCE: Thing1
                if (o.Thing1 != null) {
                    bytes[nullFlagsIndex] |= (byte)(128);
                Energize(o.Thing1, bytes, ref index, false);
                }
                // REFERENCE: Thing2
                if (o.Thing2 != null) {
                    bytes[nullFlagsIndex] |= (byte)(64);
                Energize(o.Thing2, bytes, ref index, false);
                }
                // REFERENCE: Thing3
                if (o.Thing3 != null) {
                    bytes[nullFlagsIndex] |= (byte)(32);
                Energize(o.Thing3, bytes, ref index, false);
                }
                // REFERENCE: Thing4
                if (o.Thing4 != null) {
                    bytes[nullFlagsIndex] |= (byte)(16);
                Energize(o.Thing4, bytes, ref index, false);
                }
                // REFERENCE: Thing5
                if (o.Thing5 != null) {
                    bytes[nullFlagsIndex] |= (byte)(8);
                Energize(o.Thing5, bytes, ref index, false);
                }
                // PRIMITIVE: IntValue1
                bytes[index++] = (byte)((o.IntValue1 >> 24) & 255);
                bytes[index++] = (byte)((o.IntValue1 >> 16) & 255);
                bytes[index++] = (byte)((o.IntValue1 >> 8) & 255);
                bytes[index++] = (byte)(o.IntValue1 & 255);
                // REFERENCE: Thing6
                if (o.Thing6 != null) {
                    bytes[nullFlagsIndex] |= (byte)(4);
                Energize(o.Thing6, bytes, ref index, false);
                }
                // REFERENCE: Thing7
                if (o.Thing7 != null) {
                    bytes[nullFlagsIndex] |= (byte)(2);
                Energize(o.Thing7, bytes, ref index, false);
                }
                // REFERENCE: Thing8
                if (o.Thing8 != null) {
                    bytes[nullFlagsIndex] |= (byte)(1);
                Energize(o.Thing8, bytes, ref index, false);
                }
                nullFlagsIndex++;
                // REFERENCE: Thing9
                if (o.Thing9 != null) {
                    bytes[nullFlagsIndex] |= (byte)(128);
                Energize(o.Thing9, bytes, ref index, false);
                }
                // PRIMITIVE: IntValue2
                bytes[index++] = (byte)((o.IntValue2 >> 24) & 255);
                bytes[index++] = (byte)((o.IntValue2 >> 16) & 255);
                bytes[index++] = (byte)((o.IntValue2 >> 8) & 255);
                bytes[index++] = (byte)(o.IntValue2 & 255);
                // REFERENCE: Thing10
                if (o.Thing10 != null) {
                    bytes[nullFlagsIndex] |= (byte)(64);
                Energize(o.Thing10, bytes, ref index, false);
                }
        }
        public void Energize(ThingContainer3 o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 9;
            }
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                bytes[index++] = 0;
                nullFlagsIndex++;
                // REFERENCE: Thing1
                if (o.Thing1 != null) {
                    bytes[nullFlagsIndex] |= (byte)(128);
                Energize(o.Thing1, bytes, ref index, false);
                }
                // REFERENCE: Thing2
                if (o.Thing2 != null) {
                    bytes[nullFlagsIndex] |= (byte)(64);
                Energize(o.Thing2, bytes, ref index, false);
                }
                // REFERENCE: Thing3
                if (o.Thing3 != null) {
                    bytes[nullFlagsIndex] |= (byte)(32);
                Energize(o.Thing3, bytes, ref index, false);
                }
        }
        public void Energize(DerivedType1 o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 10;
            }
                // PRIMITIVE: BooleanValue
                bytes[index++] = o.BooleanValue ? (byte)1 : (byte)0;
                // PRIMITIVE: LongValue
                bytes[index++] = (byte)((o.LongValue >> 56) & 255);
                bytes[index++] = (byte)((o.LongValue >> 48) & 255);
                bytes[index++] = (byte)((o.LongValue >> 40) & 255);
                bytes[index++] = (byte)((o.LongValue >> 32) & 255);
                bytes[index++] = (byte)((o.LongValue >> 24) & 255);
                bytes[index++] = (byte)((o.LongValue >> 16) & 255);
                bytes[index++] = (byte)((o.LongValue >> 8) & 255);
                bytes[index++] = (byte)(o.LongValue & 255);
        }
        public void Energize(DerivedType2 o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 11;
            }
                // PRIMITIVE: BooleanValue
                bytes[index++] = o.BooleanValue ? (byte)1 : (byte)0;
                // PRIMITIVE: ByteValue
                bytes[index++] = o.ByteValue;
        }
        public void Energize(BaseTypeContainer o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 12;
            }
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                bytes[index++] = 0;
                nullFlagsIndex++;
                // REFERENCE: Value1
                if (o.Value1 != null) {
                    bytes[nullFlagsIndex] |= (byte)(128);
                Energize((INullableTestObject)o.Value1, bytes, ref index, true);
                }
                // REFERENCE: Value2
                if (o.Value2 != null) {
                    bytes[nullFlagsIndex] |= (byte)(64);
                Energize((INullableTestObject)o.Value2, bytes, ref index, true);
                }
        }
        public void Energize(ListContainer o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 13;
            }
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                bytes[index++] = 0;
                nullFlagsIndex++;
                // LIST: IntList
                if (o.IntList != null) {
                    bytes[nullFlagsIndex] |= (byte)(128);
            if (o.IntList == null || o.IntList == null || o.IntList.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.IntList.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.IntList.Count;
                int i_iESu4Teun4L2;
                for (i_iESu4Teun4L2 = 0; i_iESu4Teun4L2 < 2; i_iESu4Teun4L2++) {
                    if ((ulong)o.IntList.Count < vuBoundaries[i_iESu4Teun4L2]) {
                       byteCount = (int)(i_iESu4Teun4L2 + 1);
                       goto guvsgoto_nEbKajPMh15E;
                    }
                }
                byteCount = (int)i_iESu4Teun4L2 + 1;
                guvsgoto_nEbKajPMh15E:
                    for (int i_bfRd50XZAbm5 = 0; i_bfRd50XZAbm5 < byteCount; i_bfRd50XZAbm5++) {
                        if (i_bfRd50XZAbm5 < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_bfRd50XZAbm5 < byteCount - 1) {
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
                foreach (int primitive in o.IntList) {
                bytes[index++] = (byte)((primitive >> 24) & 255);
                bytes[index++] = (byte)((primitive >> 16) & 255);
                bytes[index++] = (byte)((primitive >> 8) & 255);
                bytes[index++] = (byte)(primitive & 255);
                }
            }
                }
        }
        public void Energize(SetContainer o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 14;
            }
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                bytes[index++] = 0;
                nullFlagsIndex++;
                // SET: IntSet
                if (o.IntSet != null) {
                    bytes[nullFlagsIndex] |= (byte)(128);
            if (o.IntSet == null || o.IntSet == null || o.IntSet.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.IntSet.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.IntSet.Count;
                int i_ch91BWxL2iF4;
                for (i_ch91BWxL2iF4 = 0; i_ch91BWxL2iF4 < 2; i_ch91BWxL2iF4++) {
                    if ((ulong)o.IntSet.Count < vuBoundaries[i_ch91BWxL2iF4]) {
                       byteCount = (int)(i_ch91BWxL2iF4 + 1);
                       goto guvsgoto_wj14KMk70Jmz;
                    }
                }
                byteCount = (int)i_ch91BWxL2iF4 + 1;
                guvsgoto_wj14KMk70Jmz:
                    for (int i_lLRqdgetsXDV = 0; i_lLRqdgetsXDV < byteCount; i_lLRqdgetsXDV++) {
                        if (i_lLRqdgetsXDV < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_lLRqdgetsXDV < byteCount - 1) {
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
                foreach (int primitive in o.IntSet) {
                bytes[index++] = (byte)((primitive >> 24) & 255);
                bytes[index++] = (byte)((primitive >> 16) & 255);
                bytes[index++] = (byte)((primitive >> 8) & 255);
                bytes[index++] = (byte)(primitive & 255);
                }
            }
                }
        }
        public void Energize(MapContainer o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 15;
            }
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                bytes[index++] = 0;
                nullFlagsIndex++;
                // MAP: IntShortMap
                if (o.IntShortMap != null) {
                    bytes[nullFlagsIndex] |= (byte)(128);
            if (o.IntShortMap == null || o.IntShortMap.Keys == null || o.IntShortMap.Keys.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.IntShortMap.Keys.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.IntShortMap.Keys.Count;
                int i_w6xOOKcSN6B9;
                for (i_w6xOOKcSN6B9 = 0; i_w6xOOKcSN6B9 < 2; i_w6xOOKcSN6B9++) {
                    if ((ulong)o.IntShortMap.Keys.Count < vuBoundaries[i_w6xOOKcSN6B9]) {
                       byteCount = (int)(i_w6xOOKcSN6B9 + 1);
                       goto guvsgoto_wkTLUOcF3r6X;
                    }
                }
                byteCount = (int)i_w6xOOKcSN6B9 + 1;
                guvsgoto_wkTLUOcF3r6X:
                    for (int i_x33UF3htNo8q = 0; i_x33UF3htNo8q < byteCount; i_x33UF3htNo8q++) {
                        if (i_x33UF3htNo8q < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_x33UF3htNo8q < byteCount - 1) {
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
                foreach (int primitive in o.IntShortMap.Keys) {
                bytes[index++] = (byte)((primitive >> 24) & 255);
                bytes[index++] = (byte)((primitive >> 16) & 255);
                bytes[index++] = (byte)((primitive >> 8) & 255);
                bytes[index++] = (byte)(primitive & 255);
                }
            }
            if (o.IntShortMap == null || o.IntShortMap.Values == null || o.IntShortMap.Values.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.IntShortMap.Values.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.IntShortMap.Values.Count;
                int i_sAORVVh5SUQ0;
                for (i_sAORVVh5SUQ0 = 0; i_sAORVVh5SUQ0 < 2; i_sAORVVh5SUQ0++) {
                    if ((ulong)o.IntShortMap.Values.Count < vuBoundaries[i_sAORVVh5SUQ0]) {
                       byteCount = (int)(i_sAORVVh5SUQ0 + 1);
                       goto guvsgoto_bW1ogabkP3zh;
                    }
                }
                byteCount = (int)i_sAORVVh5SUQ0 + 1;
                guvsgoto_bW1ogabkP3zh:
                    for (int i_traakNjM7gL2 = 0; i_traakNjM7gL2 < byteCount; i_traakNjM7gL2++) {
                        if (i_traakNjM7gL2 < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_traakNjM7gL2 < byteCount - 1) {
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
                foreach (short primitive in o.IntShortMap.Values) {
                bytes[index++] = (byte)((primitive >> 8) & 255);
                bytes[index++] = (byte)(primitive & 255);
                }
            }
                }
        }
        public void Energize(IntThingContainerMap o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 16;
            }
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                bytes[index++] = 0;
                nullFlagsIndex++;
                // MAP: TheMap
                if (o.TheMap != null) {
                    bytes[nullFlagsIndex] |= (byte)(128);
            if (o.TheMap == null || o.TheMap.Keys == null || o.TheMap.Keys.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.TheMap.Keys.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.TheMap.Keys.Count;
                int i_fzI2gdIsfaDY;
                for (i_fzI2gdIsfaDY = 0; i_fzI2gdIsfaDY < 2; i_fzI2gdIsfaDY++) {
                    if ((ulong)o.TheMap.Keys.Count < vuBoundaries[i_fzI2gdIsfaDY]) {
                       byteCount = (int)(i_fzI2gdIsfaDY + 1);
                       goto guvsgoto_tXLN5rtbDWbf;
                    }
                }
                byteCount = (int)i_fzI2gdIsfaDY + 1;
                guvsgoto_tXLN5rtbDWbf:
                    for (int i_ab9bTXjLYW87 = 0; i_ab9bTXjLYW87 < byteCount; i_ab9bTXjLYW87++) {
                        if (i_ab9bTXjLYW87 < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_ab9bTXjLYW87 < byteCount - 1) {
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
                foreach (int primitive in o.TheMap.Keys) {
                bytes[index++] = (byte)((primitive >> 24) & 255);
                bytes[index++] = (byte)((primitive >> 16) & 255);
                bytes[index++] = (byte)((primitive >> 8) & 255);
                bytes[index++] = (byte)(primitive & 255);
                }
            }
            if (o.TheMap == null || o.TheMap.Values == null || o.TheMap.Values.Count == 0) {
                bytes[index++] = 0;
            }
            else { 
                if (o.TheMap.Values.Count == 0) {
                    bytes[index++] = (byte)0;
                }
                else {
                    int byteCount;
                    ulong value = (ulong)o.TheMap.Values.Count;
                int i_crF3IsWSuWN4;
                for (i_crF3IsWSuWN4 = 0; i_crF3IsWSuWN4 < 2; i_crF3IsWSuWN4++) {
                    if ((ulong)o.TheMap.Values.Count < vuBoundaries[i_crF3IsWSuWN4]) {
                       byteCount = (int)(i_crF3IsWSuWN4 + 1);
                       goto guvsgoto_eE9BAOx8p5WV;
                    }
                }
                byteCount = (int)i_crF3IsWSuWN4 + 1;
                guvsgoto_eE9BAOx8p5WV:
                    for (int i_hrrPMAqBBLRL = 0; i_hrrPMAqBBLRL < byteCount; i_hrrPMAqBBLRL++) {
                        if (i_hrrPMAqBBLRL < byteCount - 1) {
                            byte b = (byte)(value & 127);
                            if (i_hrrPMAqBBLRL < byteCount - 1) {
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
                foreach (ThingContainer finalObject in o.TheMap.Values) {
                    Energize(finalObject, bytes, ref index, false);
                }
            }
                }
        }
        public void Energize(AutogenerateTest o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 1;
            }
                // PRIMITIVE: Value
                bytes[index++] = (byte)((o.Value >> 24) & 255);
                bytes[index++] = (byte)((o.Value >> 16) & 255);
                bytes[index++] = (byte)((o.Value >> 8) & 255);
                bytes[index++] = (byte)(o.Value & 255);
        }
        public void Energize(INullableTestObject o, byte[] bytes, ref int index, bool writeTypeId) {
            switch (o.TypeId) {
                case 7:
                    Energize((Thing)o, bytes, ref index, writeTypeId);
                    break;
                case 8:
                    Energize((ThingContainer)o, bytes, ref index, writeTypeId);
                    break;
                case 9:
                    Energize((ThingContainer3)o, bytes, ref index, writeTypeId);
                    break;
                case 10:
                    Energize((DerivedType1)o, bytes, ref index, writeTypeId);
                    break;
                case 11:
                    Energize((DerivedType2)o, bytes, ref index, writeTypeId);
                    break;
                case 12:
                    Energize((BaseTypeContainer)o, bytes, ref index, writeTypeId);
                    break;
                case 13:
                    Energize((ListContainer)o, bytes, ref index, writeTypeId);
                    break;
                case 14:
                    Energize((SetContainer)o, bytes, ref index, writeTypeId);
                    break;
                case 15:
                    Energize((MapContainer)o, bytes, ref index, writeTypeId);
                    break;
                case 16:
                    Energize((IntThingContainerMap)o, bytes, ref index, writeTypeId);
                    break;
                case 1:
                    Energize((AutogenerateTest)o, bytes, ref index, writeTypeId);
                    break;
                default:
                    throw new NullableTestPatternBufferException("Unrecognized type ID: "+o.TypeId+" ");
            }
        }
///////////////////////////////////////
// FROM BYTES
///////////////////////////////////////
        public object Energize(byte[] bytes) {
            int index = 0;
                    ulong vuread_bg2ANFJepn6C = 0;
                    for (int i_hqdGapMx1fii = 0; i_hqdGapMx1fii < 9; i_hqdGapMx1fii++) {
                        byte b = bytes[index++];
                        if (i_hqdGapMx1fii < 8) {
                            vuread_bg2ANFJepn6C += (((ulong)b & (ulong)127) << (7 * i_hqdGapMx1fii));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_bg2ANFJepn6C += (ulong)b << (7 * i_hqdGapMx1fii);
                            break;
                        }
                    }
                    ushort typeId = (ushort)vuread_bg2ANFJepn6C;
            switch (typeId) {
            case 7:
                {
                Thing o = this.instantiator.AcquireThing();
                // PRIMITIVE: Value
                o.Value =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    return o;
                }
            case 8:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 2;
                ThingContainer o = this.instantiator.AcquireThingContainer();
                nullFlagsIndex++;
                // REFERENCE: Thing1
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
                o.Thing1 = (Thing)Energize(bytes, ref index, 7);
                }
                // REFERENCE: Thing2
                if ((bytes[nullFlagsIndex] & (byte)64) > 0) {
                o.Thing2 = (Thing)Energize(bytes, ref index, 7);
                }
                // REFERENCE: Thing3
                if ((bytes[nullFlagsIndex] & (byte)32) > 0) {
                o.Thing3 = (Thing)Energize(bytes, ref index, 7);
                }
                // REFERENCE: Thing4
                if ((bytes[nullFlagsIndex] & (byte)16) > 0) {
                o.Thing4 = (Thing)Energize(bytes, ref index, 7);
                }
                // REFERENCE: Thing5
                if ((bytes[nullFlagsIndex] & (byte)8) > 0) {
                o.Thing5 = (Thing)Energize(bytes, ref index, 7);
                }
                // PRIMITIVE: IntValue1
                o.IntValue1 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                // REFERENCE: Thing6
                if ((bytes[nullFlagsIndex] & (byte)4) > 0) {
                o.Thing6 = (Thing)Energize(bytes, ref index, 7);
                }
                // REFERENCE: Thing7
                if ((bytes[nullFlagsIndex] & (byte)2) > 0) {
                o.Thing7 = (Thing)Energize(bytes, ref index, 7);
                }
                // REFERENCE: Thing8
                if ((bytes[nullFlagsIndex] & (byte)1) > 0) {
                o.Thing8 = (Thing)Energize(bytes, ref index, 7);
                }
                nullFlagsIndex++;
                // REFERENCE: Thing9
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
                o.Thing9 = (Thing)Energize(bytes, ref index, 7);
                }
                // PRIMITIVE: IntValue2
                o.IntValue2 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                // REFERENCE: Thing10
                if ((bytes[nullFlagsIndex] & (byte)64) > 0) {
                o.Thing10 = (Thing)Energize(bytes, ref index, 7);
                }
                    return o;
                }
            case 9:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                ThingContainer3 o = this.instantiator.AcquireThingContainer3();
                nullFlagsIndex++;
                // REFERENCE: Thing1
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
                o.Thing1 = (Thing)Energize(bytes, ref index, 7);
                }
                // REFERENCE: Thing2
                if ((bytes[nullFlagsIndex] & (byte)64) > 0) {
                o.Thing2 = (Thing)Energize(bytes, ref index, 7);
                }
                // REFERENCE: Thing3
                if ((bytes[nullFlagsIndex] & (byte)32) > 0) {
                o.Thing3 = (Thing)Energize(bytes, ref index, 7);
                }
                    return o;
                }
            case 10:
                {
                DerivedType1 o = this.instantiator.AcquireDerivedType1();
                // PRIMITIVE: BooleanValue
                o.BooleanValue = bytes[index++] == 1;
                // PRIMITIVE: LongValue
                o.LongValue =
                    (long)(
                        ((long)bytes[index++] << 56) |
                        ((long)bytes[index++] << 48) |
                        ((long)bytes[index++] << 40) |
                        ((long)bytes[index++] << 32) |
                        ((long)bytes[index++] << 24) |
                        ((long)bytes[index++] << 16) |
                        ((long)bytes[index++] << 8) |
                        (long)bytes[index++]
                    );
                    return o;
                }
            case 11:
                {
                DerivedType2 o = this.instantiator.AcquireDerivedType2();
                // PRIMITIVE: BooleanValue
                o.BooleanValue = bytes[index++] == 1;
                // PRIMITIVE: ByteValue
                o.ByteValue = bytes[index++];
                    return o;
                }
            case 12:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                BaseTypeContainer o = this.instantiator.AcquireBaseTypeContainer();
                nullFlagsIndex++;
                // REFERENCE: Value1
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
                o.Value1 = (BaseType)Energize(bytes, ref index);
                }
                // REFERENCE: Value2
                if ((bytes[nullFlagsIndex] & (byte)64) > 0) {
                o.Value2 = (BaseType)Energize(bytes, ref index);
                }
                    return o;
                }
            case 13:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                ListContainer o = this.instantiator.AcquireListContainer();
                nullFlagsIndex++;
                // LIST: IntList
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
            // Read list item count
            ushort count_jRwZPutDJ3ZB;
                    ulong vuread_kvfYnIOevZxv = 0;
                    for (int i_jTAm8uU87Td5 = 0; i_jTAm8uU87Td5 < 9; i_jTAm8uU87Td5++) {
                        byte b = bytes[index++];
                        if (i_jTAm8uU87Td5 < 8) {
                            vuread_kvfYnIOevZxv += (((ulong)b & (ulong)127) << (7 * i_jTAm8uU87Td5));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_kvfYnIOevZxv += (ulong)b << (7 * i_jTAm8uU87Td5);
                            break;
                        }
                    }
                    count_jRwZPutDJ3ZB = (ushort)vuread_kvfYnIOevZxv;
            // Read list items
            if (count_jRwZPutDJ3ZB > 0) {
                o.IntList = this.instantiator.AcquireListOfInt();
                int listValue_dTz44D2xALhO;
                for (int i_dYktBeXItaC6 = 0; i_dYktBeXItaC6 < count_jRwZPutDJ3ZB; i_dYktBeXItaC6++) {
                    // Read Int list item
                listValue_dTz44D2xALhO =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    o.IntList.Add(listValue_dTz44D2xALhO);
                }
            }
                }
                    return o;
                }
            case 14:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                SetContainer o = this.instantiator.AcquireSetContainer();
                nullFlagsIndex++;
                // SET: IntSet
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
            // Read list item count
            ushort count_xhFpj1DPskQD;
                    ulong vuread_dUk16a5VMVck = 0;
                    for (int i_eBG36FLhrDaW = 0; i_eBG36FLhrDaW < 9; i_eBG36FLhrDaW++) {
                        byte b = bytes[index++];
                        if (i_eBG36FLhrDaW < 8) {
                            vuread_dUk16a5VMVck += (((ulong)b & (ulong)127) << (7 * i_eBG36FLhrDaW));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_dUk16a5VMVck += (ulong)b << (7 * i_eBG36FLhrDaW);
                            break;
                        }
                    }
                    count_xhFpj1DPskQD = (ushort)vuread_dUk16a5VMVck;
            // Read list items
            if (count_xhFpj1DPskQD > 0) {
                o.IntSet = this.instantiator.AcquireHashSetOfInt();
                int listValue_yNoIhBw8hQkQ;
                for (int i_x5LtfRuievfS = 0; i_x5LtfRuievfS < count_xhFpj1DPskQD; i_x5LtfRuievfS++) {
                    // Read Int list item
                listValue_yNoIhBw8hQkQ =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    o.IntSet.Add(listValue_yNoIhBw8hQkQ);
                }
            }
                }
                    return o;
                }
            case 15:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                MapContainer o = this.instantiator.AcquireMapContainer();
                nullFlagsIndex++;
                // MAP: IntShortMap
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
                    List<int> intShortMapKeys = this.instantiator.AcquireListOfInt();
                    List<short> intShortMapValues = this.instantiator.AcquireListOfShort();
            // Read list item count
            ushort count_iKTXIImPTx4s;
                    ulong vuread_uxOkzecDrZ9a = 0;
                    for (int i_xscJj2RMIFnH = 0; i_xscJj2RMIFnH < 9; i_xscJj2RMIFnH++) {
                        byte b = bytes[index++];
                        if (i_xscJj2RMIFnH < 8) {
                            vuread_uxOkzecDrZ9a += (((ulong)b & (ulong)127) << (7 * i_xscJj2RMIFnH));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_uxOkzecDrZ9a += (ulong)b << (7 * i_xscJj2RMIFnH);
                            break;
                        }
                    }
                    count_iKTXIImPTx4s = (ushort)vuread_uxOkzecDrZ9a;
            // Read list items
            if (count_iKTXIImPTx4s > 0) {
                intShortMapKeys = this.instantiator.AcquireListOfInt();
                int listValue_sJAJEE7GbsHS;
                for (int i_bjSatMBFKS3q = 0; i_bjSatMBFKS3q < count_iKTXIImPTx4s; i_bjSatMBFKS3q++) {
                    // Read Int list item
                listValue_sJAJEE7GbsHS =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    intShortMapKeys.Add(listValue_sJAJEE7GbsHS);
                }
            }
            // Read list item count
            ushort count_nMG1PsUqjgCZ;
                    ulong vuread_qD9W2D9KUuG9 = 0;
                    for (int i_dRt6eS69Qjd1 = 0; i_dRt6eS69Qjd1 < 9; i_dRt6eS69Qjd1++) {
                        byte b = bytes[index++];
                        if (i_dRt6eS69Qjd1 < 8) {
                            vuread_qD9W2D9KUuG9 += (((ulong)b & (ulong)127) << (7 * i_dRt6eS69Qjd1));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_qD9W2D9KUuG9 += (ulong)b << (7 * i_dRt6eS69Qjd1);
                            break;
                        }
                    }
                    count_nMG1PsUqjgCZ = (ushort)vuread_qD9W2D9KUuG9;
            // Read list items
            if (count_nMG1PsUqjgCZ > 0) {
                intShortMapValues = this.instantiator.AcquireListOfShort();
                short listValue_zf0TIrI6R2wZ;
                for (int i_qOMhSsGlfGS8 = 0; i_qOMhSsGlfGS8 < count_nMG1PsUqjgCZ; i_qOMhSsGlfGS8++) {
                    // Read Short list item
                listValue_zf0TIrI6R2wZ =
                    (short)(
                        ((short)bytes[index++] << 8) |
                        (short)bytes[index++]
                    );
                    intShortMapValues.Add(listValue_zf0TIrI6R2wZ);
                }
            }
                    o.IntShortMap = this.instantiator.AcquireDictionaryOfIntToShort();
                    for (int i_zYlBkCjEzhZW = 0; i_zYlBkCjEzhZW < intShortMapKeys.Count; i_zYlBkCjEzhZW++) {
                        o.IntShortMap[intShortMapKeys[i_zYlBkCjEzhZW]] = intShortMapValues[i_zYlBkCjEzhZW];
                    }
                    this.instantiator.DiscardListOfInt(intShortMapKeys);
                    this.instantiator.DiscardListOfShort(intShortMapValues);
                    intShortMapKeys = null;
                    intShortMapValues = null;
                }
                    return o;
                }
            case 16:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                IntThingContainerMap o = this.instantiator.AcquireIntThingContainerMap();
                nullFlagsIndex++;
                // MAP: TheMap
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
                    List<int> theMapKeys = this.instantiator.AcquireListOfInt();
                    List<ThingContainer> theMapValues = this.instantiator.AcquireListOfThingContainer();
            // Read list item count
            ushort count_qqcCVKsquDtz;
                    ulong vuread_cZqxN1VBx1UT = 0;
                    for (int i_chVoS2zFZZDC = 0; i_chVoS2zFZZDC < 9; i_chVoS2zFZZDC++) {
                        byte b = bytes[index++];
                        if (i_chVoS2zFZZDC < 8) {
                            vuread_cZqxN1VBx1UT += (((ulong)b & (ulong)127) << (7 * i_chVoS2zFZZDC));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_cZqxN1VBx1UT += (ulong)b << (7 * i_chVoS2zFZZDC);
                            break;
                        }
                    }
                    count_qqcCVKsquDtz = (ushort)vuread_cZqxN1VBx1UT;
            // Read list items
            if (count_qqcCVKsquDtz > 0) {
                theMapKeys = this.instantiator.AcquireListOfInt();
                int listValue_gdzFnBNFFVvv;
                for (int i_fW1IwxzVGswO = 0; i_fW1IwxzVGswO < count_qqcCVKsquDtz; i_fW1IwxzVGswO++) {
                    // Read Int list item
                listValue_gdzFnBNFFVvv =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    theMapKeys.Add(listValue_gdzFnBNFFVvv);
                }
            }
            // Read list item count
            ushort count_veHCdXKqvYiJ;
                    ulong vuread_lpn6noouVAc6 = 0;
                    for (int i_a1jBAR66QVQj = 0; i_a1jBAR66QVQj < 9; i_a1jBAR66QVQj++) {
                        byte b = bytes[index++];
                        if (i_a1jBAR66QVQj < 8) {
                            vuread_lpn6noouVAc6 += (((ulong)b & (ulong)127) << (7 * i_a1jBAR66QVQj));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_lpn6noouVAc6 += (ulong)b << (7 * i_a1jBAR66QVQj);
                            break;
                        }
                    }
                    count_veHCdXKqvYiJ = (ushort)vuread_lpn6noouVAc6;
            // Read list items
            if (count_veHCdXKqvYiJ > 0) {
                theMapValues = this.instantiator.AcquireListOfThingContainer();
                for (int li_xlCRle9xNrgg = 0; li_xlCRle9xNrgg < count_veHCdXKqvYiJ; li_xlCRle9xNrgg++) {
                    theMapValues.Add((ThingContainer)Energize(bytes, ref index, 8));
                }
            }
                    o.TheMap = this.instantiator.AcquireDictionaryOfIntToThingContainer();
                    for (int i_eDIrec3xcKBl = 0; i_eDIrec3xcKBl < theMapKeys.Count; i_eDIrec3xcKBl++) {
                        o.TheMap[theMapKeys[i_eDIrec3xcKBl]] = theMapValues[i_eDIrec3xcKBl];
                    }
                    this.instantiator.DiscardListOfInt(theMapKeys);
                    this.instantiator.DiscardListOfThingContainer(theMapValues);
                    theMapKeys = null;
                    theMapValues = null;
                }
                    return o;
                }
            case 1:
                {
                AutogenerateTest o = this.instantiator.AcquireAutogenerateTest();
                // PRIMITIVE: Value
                o.Value =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    return o;
                }
                default:
                    throw new NullableTestPatternBufferException("Unrecognized type ID: "+typeId+" ");
            }
        }
        public object Energize(byte[] bytes, ref int index) {
                    ulong vuread_ri0N1l2QJecc = 0;
                    for (int i_uHjQBOtTUcr6 = 0; i_uHjQBOtTUcr6 < 9; i_uHjQBOtTUcr6++) {
                        byte b = bytes[index++];
                        if (i_uHjQBOtTUcr6 < 8) {
                            vuread_ri0N1l2QJecc += (((ulong)b & (ulong)127) << (7 * i_uHjQBOtTUcr6));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_ri0N1l2QJecc += (ulong)b << (7 * i_uHjQBOtTUcr6);
                            break;
                        }
                    }
                    ushort typeId = (ushort)vuread_ri0N1l2QJecc;
            switch (typeId) {
            case 7:
                {
                Thing o = this.instantiator.AcquireThing();
                // PRIMITIVE: Value
                o.Value =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    return o;
                }
            case 8:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 2;
                ThingContainer o = this.instantiator.AcquireThingContainer();
                nullFlagsIndex++;
                // REFERENCE: Thing1
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
                o.Thing1 = (Thing)Energize(bytes, ref index, 7);
                }
                // REFERENCE: Thing2
                if ((bytes[nullFlagsIndex] & (byte)64) > 0) {
                o.Thing2 = (Thing)Energize(bytes, ref index, 7);
                }
                // REFERENCE: Thing3
                if ((bytes[nullFlagsIndex] & (byte)32) > 0) {
                o.Thing3 = (Thing)Energize(bytes, ref index, 7);
                }
                // REFERENCE: Thing4
                if ((bytes[nullFlagsIndex] & (byte)16) > 0) {
                o.Thing4 = (Thing)Energize(bytes, ref index, 7);
                }
                // REFERENCE: Thing5
                if ((bytes[nullFlagsIndex] & (byte)8) > 0) {
                o.Thing5 = (Thing)Energize(bytes, ref index, 7);
                }
                // PRIMITIVE: IntValue1
                o.IntValue1 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                // REFERENCE: Thing6
                if ((bytes[nullFlagsIndex] & (byte)4) > 0) {
                o.Thing6 = (Thing)Energize(bytes, ref index, 7);
                }
                // REFERENCE: Thing7
                if ((bytes[nullFlagsIndex] & (byte)2) > 0) {
                o.Thing7 = (Thing)Energize(bytes, ref index, 7);
                }
                // REFERENCE: Thing8
                if ((bytes[nullFlagsIndex] & (byte)1) > 0) {
                o.Thing8 = (Thing)Energize(bytes, ref index, 7);
                }
                nullFlagsIndex++;
                // REFERENCE: Thing9
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
                o.Thing9 = (Thing)Energize(bytes, ref index, 7);
                }
                // PRIMITIVE: IntValue2
                o.IntValue2 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                // REFERENCE: Thing10
                if ((bytes[nullFlagsIndex] & (byte)64) > 0) {
                o.Thing10 = (Thing)Energize(bytes, ref index, 7);
                }
                    return o;
                }
            case 9:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                ThingContainer3 o = this.instantiator.AcquireThingContainer3();
                nullFlagsIndex++;
                // REFERENCE: Thing1
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
                o.Thing1 = (Thing)Energize(bytes, ref index, 7);
                }
                // REFERENCE: Thing2
                if ((bytes[nullFlagsIndex] & (byte)64) > 0) {
                o.Thing2 = (Thing)Energize(bytes, ref index, 7);
                }
                // REFERENCE: Thing3
                if ((bytes[nullFlagsIndex] & (byte)32) > 0) {
                o.Thing3 = (Thing)Energize(bytes, ref index, 7);
                }
                    return o;
                }
            case 10:
                {
                DerivedType1 o = this.instantiator.AcquireDerivedType1();
                // PRIMITIVE: BooleanValue
                o.BooleanValue = bytes[index++] == 1;
                // PRIMITIVE: LongValue
                o.LongValue =
                    (long)(
                        ((long)bytes[index++] << 56) |
                        ((long)bytes[index++] << 48) |
                        ((long)bytes[index++] << 40) |
                        ((long)bytes[index++] << 32) |
                        ((long)bytes[index++] << 24) |
                        ((long)bytes[index++] << 16) |
                        ((long)bytes[index++] << 8) |
                        (long)bytes[index++]
                    );
                    return o;
                }
            case 11:
                {
                DerivedType2 o = this.instantiator.AcquireDerivedType2();
                // PRIMITIVE: BooleanValue
                o.BooleanValue = bytes[index++] == 1;
                // PRIMITIVE: ByteValue
                o.ByteValue = bytes[index++];
                    return o;
                }
            case 12:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                BaseTypeContainer o = this.instantiator.AcquireBaseTypeContainer();
                nullFlagsIndex++;
                // REFERENCE: Value1
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
                o.Value1 = (BaseType)Energize(bytes, ref index);
                }
                // REFERENCE: Value2
                if ((bytes[nullFlagsIndex] & (byte)64) > 0) {
                o.Value2 = (BaseType)Energize(bytes, ref index);
                }
                    return o;
                }
            case 13:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                ListContainer o = this.instantiator.AcquireListContainer();
                nullFlagsIndex++;
                // LIST: IntList
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
            // Read list item count
            ushort count_eO2O2sgtUqcc;
                    ulong vuread_fvGBzAGfAFFH = 0;
                    for (int i_xm6xrSBM13Dn = 0; i_xm6xrSBM13Dn < 9; i_xm6xrSBM13Dn++) {
                        byte b = bytes[index++];
                        if (i_xm6xrSBM13Dn < 8) {
                            vuread_fvGBzAGfAFFH += (((ulong)b & (ulong)127) << (7 * i_xm6xrSBM13Dn));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_fvGBzAGfAFFH += (ulong)b << (7 * i_xm6xrSBM13Dn);
                            break;
                        }
                    }
                    count_eO2O2sgtUqcc = (ushort)vuread_fvGBzAGfAFFH;
            // Read list items
            if (count_eO2O2sgtUqcc > 0) {
                o.IntList = this.instantiator.AcquireListOfInt();
                int listValue_ioYq7TsFEgCf;
                for (int i_d1uuFlGOiuUP = 0; i_d1uuFlGOiuUP < count_eO2O2sgtUqcc; i_d1uuFlGOiuUP++) {
                    // Read Int list item
                listValue_ioYq7TsFEgCf =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    o.IntList.Add(listValue_ioYq7TsFEgCf);
                }
            }
                }
                    return o;
                }
            case 14:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                SetContainer o = this.instantiator.AcquireSetContainer();
                nullFlagsIndex++;
                // SET: IntSet
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
            // Read list item count
            ushort count_jSbcZAku2sik;
                    ulong vuread_pqiRnacWT1pA = 0;
                    for (int i_kggQxZe8Di4o = 0; i_kggQxZe8Di4o < 9; i_kggQxZe8Di4o++) {
                        byte b = bytes[index++];
                        if (i_kggQxZe8Di4o < 8) {
                            vuread_pqiRnacWT1pA += (((ulong)b & (ulong)127) << (7 * i_kggQxZe8Di4o));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_pqiRnacWT1pA += (ulong)b << (7 * i_kggQxZe8Di4o);
                            break;
                        }
                    }
                    count_jSbcZAku2sik = (ushort)vuread_pqiRnacWT1pA;
            // Read list items
            if (count_jSbcZAku2sik > 0) {
                o.IntSet = this.instantiator.AcquireHashSetOfInt();
                int listValue_spPe6hnZSjSp;
                for (int i_bYAhs86EDLOT = 0; i_bYAhs86EDLOT < count_jSbcZAku2sik; i_bYAhs86EDLOT++) {
                    // Read Int list item
                listValue_spPe6hnZSjSp =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    o.IntSet.Add(listValue_spPe6hnZSjSp);
                }
            }
                }
                    return o;
                }
            case 15:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                MapContainer o = this.instantiator.AcquireMapContainer();
                nullFlagsIndex++;
                // MAP: IntShortMap
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
                    List<int> intShortMapKeys = this.instantiator.AcquireListOfInt();
                    List<short> intShortMapValues = this.instantiator.AcquireListOfShort();
            // Read list item count
            ushort count_iE7cojRDv3a7;
                    ulong vuread_i80LOARoy0NI = 0;
                    for (int i_k6QFmzVfL6TB = 0; i_k6QFmzVfL6TB < 9; i_k6QFmzVfL6TB++) {
                        byte b = bytes[index++];
                        if (i_k6QFmzVfL6TB < 8) {
                            vuread_i80LOARoy0NI += (((ulong)b & (ulong)127) << (7 * i_k6QFmzVfL6TB));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_i80LOARoy0NI += (ulong)b << (7 * i_k6QFmzVfL6TB);
                            break;
                        }
                    }
                    count_iE7cojRDv3a7 = (ushort)vuread_i80LOARoy0NI;
            // Read list items
            if (count_iE7cojRDv3a7 > 0) {
                intShortMapKeys = this.instantiator.AcquireListOfInt();
                int listValue_ekLICp3jYCWu;
                for (int i_du0d4zuD1yNr = 0; i_du0d4zuD1yNr < count_iE7cojRDv3a7; i_du0d4zuD1yNr++) {
                    // Read Int list item
                listValue_ekLICp3jYCWu =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    intShortMapKeys.Add(listValue_ekLICp3jYCWu);
                }
            }
            // Read list item count
            ushort count_mlq5i4vzoyBD;
                    ulong vuread_viWj7DU6kwx2 = 0;
                    for (int i_oRkmLqKWGtfq = 0; i_oRkmLqKWGtfq < 9; i_oRkmLqKWGtfq++) {
                        byte b = bytes[index++];
                        if (i_oRkmLqKWGtfq < 8) {
                            vuread_viWj7DU6kwx2 += (((ulong)b & (ulong)127) << (7 * i_oRkmLqKWGtfq));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_viWj7DU6kwx2 += (ulong)b << (7 * i_oRkmLqKWGtfq);
                            break;
                        }
                    }
                    count_mlq5i4vzoyBD = (ushort)vuread_viWj7DU6kwx2;
            // Read list items
            if (count_mlq5i4vzoyBD > 0) {
                intShortMapValues = this.instantiator.AcquireListOfShort();
                short listValue_z7a3gxfT3woW;
                for (int i_qlGxORhhYywB = 0; i_qlGxORhhYywB < count_mlq5i4vzoyBD; i_qlGxORhhYywB++) {
                    // Read Short list item
                listValue_z7a3gxfT3woW =
                    (short)(
                        ((short)bytes[index++] << 8) |
                        (short)bytes[index++]
                    );
                    intShortMapValues.Add(listValue_z7a3gxfT3woW);
                }
            }
                    o.IntShortMap = this.instantiator.AcquireDictionaryOfIntToShort();
                    for (int i_tjX8XP6FdGk9 = 0; i_tjX8XP6FdGk9 < intShortMapKeys.Count; i_tjX8XP6FdGk9++) {
                        o.IntShortMap[intShortMapKeys[i_tjX8XP6FdGk9]] = intShortMapValues[i_tjX8XP6FdGk9];
                    }
                    this.instantiator.DiscardListOfInt(intShortMapKeys);
                    this.instantiator.DiscardListOfShort(intShortMapValues);
                    intShortMapKeys = null;
                    intShortMapValues = null;
                }
                    return o;
                }
            case 16:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                IntThingContainerMap o = this.instantiator.AcquireIntThingContainerMap();
                nullFlagsIndex++;
                // MAP: TheMap
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
                    List<int> theMapKeys = this.instantiator.AcquireListOfInt();
                    List<ThingContainer> theMapValues = this.instantiator.AcquireListOfThingContainer();
            // Read list item count
            ushort count_m1ZWqN8mDyJz;
                    ulong vuread_tnhZm7BJLJj7 = 0;
                    for (int i_oh6ozTThbH3W = 0; i_oh6ozTThbH3W < 9; i_oh6ozTThbH3W++) {
                        byte b = bytes[index++];
                        if (i_oh6ozTThbH3W < 8) {
                            vuread_tnhZm7BJLJj7 += (((ulong)b & (ulong)127) << (7 * i_oh6ozTThbH3W));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_tnhZm7BJLJj7 += (ulong)b << (7 * i_oh6ozTThbH3W);
                            break;
                        }
                    }
                    count_m1ZWqN8mDyJz = (ushort)vuread_tnhZm7BJLJj7;
            // Read list items
            if (count_m1ZWqN8mDyJz > 0) {
                theMapKeys = this.instantiator.AcquireListOfInt();
                int listValue_wu0lzj7vKyoK;
                for (int i_nhsfeKx4R2nj = 0; i_nhsfeKx4R2nj < count_m1ZWqN8mDyJz; i_nhsfeKx4R2nj++) {
                    // Read Int list item
                listValue_wu0lzj7vKyoK =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    theMapKeys.Add(listValue_wu0lzj7vKyoK);
                }
            }
            // Read list item count
            ushort count_rUWTPBymtv71;
                    ulong vuread_cpkBLXwl2vRs = 0;
                    for (int i_lNcAj9f9hREP = 0; i_lNcAj9f9hREP < 9; i_lNcAj9f9hREP++) {
                        byte b = bytes[index++];
                        if (i_lNcAj9f9hREP < 8) {
                            vuread_cpkBLXwl2vRs += (((ulong)b & (ulong)127) << (7 * i_lNcAj9f9hREP));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_cpkBLXwl2vRs += (ulong)b << (7 * i_lNcAj9f9hREP);
                            break;
                        }
                    }
                    count_rUWTPBymtv71 = (ushort)vuread_cpkBLXwl2vRs;
            // Read list items
            if (count_rUWTPBymtv71 > 0) {
                theMapValues = this.instantiator.AcquireListOfThingContainer();
                for (int li_jnQiabrmjA9Y = 0; li_jnQiabrmjA9Y < count_rUWTPBymtv71; li_jnQiabrmjA9Y++) {
                    theMapValues.Add((ThingContainer)Energize(bytes, ref index, 8));
                }
            }
                    o.TheMap = this.instantiator.AcquireDictionaryOfIntToThingContainer();
                    for (int i_l5s3FbqvdEsb = 0; i_l5s3FbqvdEsb < theMapKeys.Count; i_l5s3FbqvdEsb++) {
                        o.TheMap[theMapKeys[i_l5s3FbqvdEsb]] = theMapValues[i_l5s3FbqvdEsb];
                    }
                    this.instantiator.DiscardListOfInt(theMapKeys);
                    this.instantiator.DiscardListOfThingContainer(theMapValues);
                    theMapKeys = null;
                    theMapValues = null;
                }
                    return o;
                }
            case 1:
                {
                AutogenerateTest o = this.instantiator.AcquireAutogenerateTest();
                // PRIMITIVE: Value
                o.Value =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    return o;
                }
                default:
                    throw new NullableTestPatternBufferException("Unrecognized type ID: "+typeId+" ");
            }
        }
        public object Energize(byte[] bytes, ref int index, ushort typeId) {
            switch (typeId) {
            case 7:
                {
                Thing o = this.instantiator.AcquireThing();
                // PRIMITIVE: Value
                o.Value =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    return o;
                }
            case 8:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 2;
                ThingContainer o = this.instantiator.AcquireThingContainer();
                nullFlagsIndex++;
                // REFERENCE: Thing1
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
                o.Thing1 = (Thing)Energize(bytes, ref index, 7);
                }
                // REFERENCE: Thing2
                if ((bytes[nullFlagsIndex] & (byte)64) > 0) {
                o.Thing2 = (Thing)Energize(bytes, ref index, 7);
                }
                // REFERENCE: Thing3
                if ((bytes[nullFlagsIndex] & (byte)32) > 0) {
                o.Thing3 = (Thing)Energize(bytes, ref index, 7);
                }
                // REFERENCE: Thing4
                if ((bytes[nullFlagsIndex] & (byte)16) > 0) {
                o.Thing4 = (Thing)Energize(bytes, ref index, 7);
                }
                // REFERENCE: Thing5
                if ((bytes[nullFlagsIndex] & (byte)8) > 0) {
                o.Thing5 = (Thing)Energize(bytes, ref index, 7);
                }
                // PRIMITIVE: IntValue1
                o.IntValue1 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                // REFERENCE: Thing6
                if ((bytes[nullFlagsIndex] & (byte)4) > 0) {
                o.Thing6 = (Thing)Energize(bytes, ref index, 7);
                }
                // REFERENCE: Thing7
                if ((bytes[nullFlagsIndex] & (byte)2) > 0) {
                o.Thing7 = (Thing)Energize(bytes, ref index, 7);
                }
                // REFERENCE: Thing8
                if ((bytes[nullFlagsIndex] & (byte)1) > 0) {
                o.Thing8 = (Thing)Energize(bytes, ref index, 7);
                }
                nullFlagsIndex++;
                // REFERENCE: Thing9
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
                o.Thing9 = (Thing)Energize(bytes, ref index, 7);
                }
                // PRIMITIVE: IntValue2
                o.IntValue2 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                // REFERENCE: Thing10
                if ((bytes[nullFlagsIndex] & (byte)64) > 0) {
                o.Thing10 = (Thing)Energize(bytes, ref index, 7);
                }
                    return o;
                }
            case 9:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                ThingContainer3 o = this.instantiator.AcquireThingContainer3();
                nullFlagsIndex++;
                // REFERENCE: Thing1
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
                o.Thing1 = (Thing)Energize(bytes, ref index, 7);
                }
                // REFERENCE: Thing2
                if ((bytes[nullFlagsIndex] & (byte)64) > 0) {
                o.Thing2 = (Thing)Energize(bytes, ref index, 7);
                }
                // REFERENCE: Thing3
                if ((bytes[nullFlagsIndex] & (byte)32) > 0) {
                o.Thing3 = (Thing)Energize(bytes, ref index, 7);
                }
                    return o;
                }
            case 10:
                {
                DerivedType1 o = this.instantiator.AcquireDerivedType1();
                // PRIMITIVE: BooleanValue
                o.BooleanValue = bytes[index++] == 1;
                // PRIMITIVE: LongValue
                o.LongValue =
                    (long)(
                        ((long)bytes[index++] << 56) |
                        ((long)bytes[index++] << 48) |
                        ((long)bytes[index++] << 40) |
                        ((long)bytes[index++] << 32) |
                        ((long)bytes[index++] << 24) |
                        ((long)bytes[index++] << 16) |
                        ((long)bytes[index++] << 8) |
                        (long)bytes[index++]
                    );
                    return o;
                }
            case 11:
                {
                DerivedType2 o = this.instantiator.AcquireDerivedType2();
                // PRIMITIVE: BooleanValue
                o.BooleanValue = bytes[index++] == 1;
                // PRIMITIVE: ByteValue
                o.ByteValue = bytes[index++];
                    return o;
                }
            case 12:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                BaseTypeContainer o = this.instantiator.AcquireBaseTypeContainer();
                nullFlagsIndex++;
                // REFERENCE: Value1
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
                o.Value1 = (BaseType)Energize(bytes, ref index);
                }
                // REFERENCE: Value2
                if ((bytes[nullFlagsIndex] & (byte)64) > 0) {
                o.Value2 = (BaseType)Energize(bytes, ref index);
                }
                    return o;
                }
            case 13:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                ListContainer o = this.instantiator.AcquireListContainer();
                nullFlagsIndex++;
                // LIST: IntList
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
            // Read list item count
            ushort count_k7dtp8UzUEex;
                    ulong vuread_dol1eFiaOnan = 0;
                    for (int i_slDfAjM25OTc = 0; i_slDfAjM25OTc < 9; i_slDfAjM25OTc++) {
                        byte b = bytes[index++];
                        if (i_slDfAjM25OTc < 8) {
                            vuread_dol1eFiaOnan += (((ulong)b & (ulong)127) << (7 * i_slDfAjM25OTc));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_dol1eFiaOnan += (ulong)b << (7 * i_slDfAjM25OTc);
                            break;
                        }
                    }
                    count_k7dtp8UzUEex = (ushort)vuread_dol1eFiaOnan;
            // Read list items
            if (count_k7dtp8UzUEex > 0) {
                o.IntList = this.instantiator.AcquireListOfInt();
                int listValue_z76lQJd605Vr;
                for (int i_vzqHvsxm6ZMe = 0; i_vzqHvsxm6ZMe < count_k7dtp8UzUEex; i_vzqHvsxm6ZMe++) {
                    // Read Int list item
                listValue_z76lQJd605Vr =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    o.IntList.Add(listValue_z76lQJd605Vr);
                }
            }
                }
                    return o;
                }
            case 14:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                SetContainer o = this.instantiator.AcquireSetContainer();
                nullFlagsIndex++;
                // SET: IntSet
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
            // Read list item count
            ushort count_mO8L1mCDFi3h;
                    ulong vuread_o7tejewVzmpb = 0;
                    for (int i_xeHMqGgiu1Qb = 0; i_xeHMqGgiu1Qb < 9; i_xeHMqGgiu1Qb++) {
                        byte b = bytes[index++];
                        if (i_xeHMqGgiu1Qb < 8) {
                            vuread_o7tejewVzmpb += (((ulong)b & (ulong)127) << (7 * i_xeHMqGgiu1Qb));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_o7tejewVzmpb += (ulong)b << (7 * i_xeHMqGgiu1Qb);
                            break;
                        }
                    }
                    count_mO8L1mCDFi3h = (ushort)vuread_o7tejewVzmpb;
            // Read list items
            if (count_mO8L1mCDFi3h > 0) {
                o.IntSet = this.instantiator.AcquireHashSetOfInt();
                int listValue_pCeOCsWRFj8y;
                for (int i_zsc2C0Psy6SW = 0; i_zsc2C0Psy6SW < count_mO8L1mCDFi3h; i_zsc2C0Psy6SW++) {
                    // Read Int list item
                listValue_pCeOCsWRFj8y =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    o.IntSet.Add(listValue_pCeOCsWRFj8y);
                }
            }
                }
                    return o;
                }
            case 15:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                MapContainer o = this.instantiator.AcquireMapContainer();
                nullFlagsIndex++;
                // MAP: IntShortMap
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
                    List<int> intShortMapKeys = this.instantiator.AcquireListOfInt();
                    List<short> intShortMapValues = this.instantiator.AcquireListOfShort();
            // Read list item count
            ushort count_r0m8cVWRqsDQ;
                    ulong vuread_aSthzIGTgiN8 = 0;
                    for (int i_mnPDmyMOUr9M = 0; i_mnPDmyMOUr9M < 9; i_mnPDmyMOUr9M++) {
                        byte b = bytes[index++];
                        if (i_mnPDmyMOUr9M < 8) {
                            vuread_aSthzIGTgiN8 += (((ulong)b & (ulong)127) << (7 * i_mnPDmyMOUr9M));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_aSthzIGTgiN8 += (ulong)b << (7 * i_mnPDmyMOUr9M);
                            break;
                        }
                    }
                    count_r0m8cVWRqsDQ = (ushort)vuread_aSthzIGTgiN8;
            // Read list items
            if (count_r0m8cVWRqsDQ > 0) {
                intShortMapKeys = this.instantiator.AcquireListOfInt();
                int listValue_cYOTwqhQZv2U;
                for (int i_nI30A8QGnoDY = 0; i_nI30A8QGnoDY < count_r0m8cVWRqsDQ; i_nI30A8QGnoDY++) {
                    // Read Int list item
                listValue_cYOTwqhQZv2U =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    intShortMapKeys.Add(listValue_cYOTwqhQZv2U);
                }
            }
            // Read list item count
            ushort count_csF2PY6SSRbK;
                    ulong vuread_xWxZb6ijv46O = 0;
                    for (int i_nWnWKDy0v0Ne = 0; i_nWnWKDy0v0Ne < 9; i_nWnWKDy0v0Ne++) {
                        byte b = bytes[index++];
                        if (i_nWnWKDy0v0Ne < 8) {
                            vuread_xWxZb6ijv46O += (((ulong)b & (ulong)127) << (7 * i_nWnWKDy0v0Ne));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_xWxZb6ijv46O += (ulong)b << (7 * i_nWnWKDy0v0Ne);
                            break;
                        }
                    }
                    count_csF2PY6SSRbK = (ushort)vuread_xWxZb6ijv46O;
            // Read list items
            if (count_csF2PY6SSRbK > 0) {
                intShortMapValues = this.instantiator.AcquireListOfShort();
                short listValue_tobayjcZGs6O;
                for (int i_p1ErfuDmw1x2 = 0; i_p1ErfuDmw1x2 < count_csF2PY6SSRbK; i_p1ErfuDmw1x2++) {
                    // Read Short list item
                listValue_tobayjcZGs6O =
                    (short)(
                        ((short)bytes[index++] << 8) |
                        (short)bytes[index++]
                    );
                    intShortMapValues.Add(listValue_tobayjcZGs6O);
                }
            }
                    o.IntShortMap = this.instantiator.AcquireDictionaryOfIntToShort();
                    for (int i_pkhpskpdjsdW = 0; i_pkhpskpdjsdW < intShortMapKeys.Count; i_pkhpskpdjsdW++) {
                        o.IntShortMap[intShortMapKeys[i_pkhpskpdjsdW]] = intShortMapValues[i_pkhpskpdjsdW];
                    }
                    this.instantiator.DiscardListOfInt(intShortMapKeys);
                    this.instantiator.DiscardListOfShort(intShortMapValues);
                    intShortMapKeys = null;
                    intShortMapValues = null;
                }
                    return o;
                }
            case 16:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                IntThingContainerMap o = this.instantiator.AcquireIntThingContainerMap();
                nullFlagsIndex++;
                // MAP: TheMap
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
                    List<int> theMapKeys = this.instantiator.AcquireListOfInt();
                    List<ThingContainer> theMapValues = this.instantiator.AcquireListOfThingContainer();
            // Read list item count
            ushort count_xhUl1ghmZJlT;
                    ulong vuread_zhUawBR41iAo = 0;
                    for (int i_aXGvc3EsXSw8 = 0; i_aXGvc3EsXSw8 < 9; i_aXGvc3EsXSw8++) {
                        byte b = bytes[index++];
                        if (i_aXGvc3EsXSw8 < 8) {
                            vuread_zhUawBR41iAo += (((ulong)b & (ulong)127) << (7 * i_aXGvc3EsXSw8));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_zhUawBR41iAo += (ulong)b << (7 * i_aXGvc3EsXSw8);
                            break;
                        }
                    }
                    count_xhUl1ghmZJlT = (ushort)vuread_zhUawBR41iAo;
            // Read list items
            if (count_xhUl1ghmZJlT > 0) {
                theMapKeys = this.instantiator.AcquireListOfInt();
                int listValue_prupTkda9yql;
                for (int i_koQRKj5VRFje = 0; i_koQRKj5VRFje < count_xhUl1ghmZJlT; i_koQRKj5VRFje++) {
                    // Read Int list item
                listValue_prupTkda9yql =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    theMapKeys.Add(listValue_prupTkda9yql);
                }
            }
            // Read list item count
            ushort count_pVk6e25qUWAf;
                    ulong vuread_dCkQfzpNGv6X = 0;
                    for (int i_fXROWKqehpP8 = 0; i_fXROWKqehpP8 < 9; i_fXROWKqehpP8++) {
                        byte b = bytes[index++];
                        if (i_fXROWKqehpP8 < 8) {
                            vuread_dCkQfzpNGv6X += (((ulong)b & (ulong)127) << (7 * i_fXROWKqehpP8));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_dCkQfzpNGv6X += (ulong)b << (7 * i_fXROWKqehpP8);
                            break;
                        }
                    }
                    count_pVk6e25qUWAf = (ushort)vuread_dCkQfzpNGv6X;
            // Read list items
            if (count_pVk6e25qUWAf > 0) {
                theMapValues = this.instantiator.AcquireListOfThingContainer();
                for (int li_ag5gDaANXLKi = 0; li_ag5gDaANXLKi < count_pVk6e25qUWAf; li_ag5gDaANXLKi++) {
                    theMapValues.Add((ThingContainer)Energize(bytes, ref index, 8));
                }
            }
                    o.TheMap = this.instantiator.AcquireDictionaryOfIntToThingContainer();
                    for (int i_zoQspGIoZwUr = 0; i_zoQspGIoZwUr < theMapKeys.Count; i_zoQspGIoZwUr++) {
                        o.TheMap[theMapKeys[i_zoQspGIoZwUr]] = theMapValues[i_zoQspGIoZwUr];
                    }
                    this.instantiator.DiscardListOfInt(theMapKeys);
                    this.instantiator.DiscardListOfThingContainer(theMapValues);
                    theMapKeys = null;
                    theMapValues = null;
                }
                    return o;
                }
            case 1:
                {
                AutogenerateTest o = this.instantiator.AcquireAutogenerateTest();
                // PRIMITIVE: Value
                o.Value =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    return o;
                }
                default:
                    throw new NullableTestPatternBufferException("Unrecognized type ID: "+typeId+" ");
            }
        }
///////////////////////////////////////
// FROM BYTES (TYPED)
///////////////////////////////////////
        public TYPE Energize< TYPE > (byte[] bytes) {
            object o = this.Energize(bytes);
            if (!(o is TYPE)) {
                throw new NullableTestPatternBufferException("Deserialized type (" + o.GetType().Name + ") does not match expected type (" + typeof(TYPE).Name + ").");
            }
            return (TYPE)o;
        }
///////////////////////////////////////
// RECLAIM
///////////////////////////////////////
        public void Reclaim(Thing o) {
            if (o != null) {
                o.Value = default(int);
                this.instantiator.DiscardThing(o);
            }
        }
        public void Reclaim(ThingContainer o) {
            if (o != null) {
                if (o.Thing1 != null) {
                    this.Reclaim(o.Thing1);
                }
                o.Thing1 = default(Thing);
                if (o.Thing2 != null) {
                    this.Reclaim(o.Thing2);
                }
                o.Thing2 = default(Thing);
                if (o.Thing3 != null) {
                    this.Reclaim(o.Thing3);
                }
                o.Thing3 = default(Thing);
                if (o.Thing4 != null) {
                    this.Reclaim(o.Thing4);
                }
                o.Thing4 = default(Thing);
                if (o.Thing5 != null) {
                    this.Reclaim(o.Thing5);
                }
                o.Thing5 = default(Thing);
                o.IntValue1 = default(int);
                if (o.Thing6 != null) {
                    this.Reclaim(o.Thing6);
                }
                o.Thing6 = default(Thing);
                if (o.Thing7 != null) {
                    this.Reclaim(o.Thing7);
                }
                o.Thing7 = default(Thing);
                if (o.Thing8 != null) {
                    this.Reclaim(o.Thing8);
                }
                o.Thing8 = default(Thing);
                if (o.Thing9 != null) {
                    this.Reclaim(o.Thing9);
                }
                o.Thing9 = default(Thing);
                o.IntValue2 = default(int);
                if (o.Thing10 != null) {
                    this.Reclaim(o.Thing10);
                }
                o.Thing10 = default(Thing);
                this.instantiator.DiscardThingContainer(o);
            }
        }
        public void Reclaim(AbstractThingContainer1 o) {
            if (o != null) {
                if (o is AbstractThingContainer2) {
                    this.Reclaim((AbstractThingContainer2)o);
                }
                if (o.Thing1 != null) {
                    this.Reclaim(o.Thing1);
                }
                o.Thing1 = default(Thing);
            }
        }
        public void Reclaim(AbstractThingContainer2 o) {
            if (o != null) {
                if (o is ThingContainer3) {
                    this.Reclaim((ThingContainer3)o);
                }
                if (o.Thing2 != null) {
                    this.Reclaim(o.Thing2);
                }
                o.Thing2 = default(Thing);
            }
        }
        public void Reclaim(ThingContainer3 o) {
            if (o != null) {
                if (o.Thing3 != null) {
                    this.Reclaim(o.Thing3);
                }
                o.Thing3 = default(Thing);
                this.instantiator.DiscardThingContainer3(o);
            }
        }
        public void Reclaim(BaseType o) {
            if (o != null) {
                if (o is DerivedType1) {
                    this.Reclaim((DerivedType1)o);
                }
                else if (o is DerivedType2) {
                    this.Reclaim((DerivedType2)o);
                }
                o.BooleanValue = default(bool);
            }
        }
        public void Reclaim(DerivedType1 o) {
            if (o != null) {
                o.LongValue = default(long);
                this.instantiator.DiscardDerivedType1(o);
            }
        }
        public void Reclaim(DerivedType2 o) {
            if (o != null) {
                o.ByteValue = default(byte);
                this.instantiator.DiscardDerivedType2(o);
            }
        }
        public void Reclaim(BaseTypeContainer o) {
            if (o != null) {
                if (o.Value1 != null) {
                    this.Reclaim(o.Value1);
                }
                o.Value1 = default(BaseType);
                if (o.Value2 != null) {
                    this.Reclaim(o.Value2);
                }
                o.Value2 = default(BaseType);
                this.instantiator.DiscardBaseTypeContainer(o);
            }
        }
        public void Reclaim(ListContainer o) {
            if (o != null) {
                this.instantiator.DiscardListContainer(o);
            }
        }
        public void Reclaim(SetContainer o) {
            if (o != null) {
                this.instantiator.DiscardSetContainer(o);
            }
        }
        public void Reclaim(MapContainer o) {
            if (o != null) {
                if (o.IntShortMap != null) {
                    this.instantiator.DiscardDictionaryOfIntToShort((Dictionary<int,short>)o.IntShortMap);
                }
                this.instantiator.DiscardMapContainer(o);
            }
        }
        public void Reclaim(IntThingContainerMap o) {
            if (o != null) {
                if (o.TheMap != null) {
                    foreach (ThingContainer v in o.TheMap.Values) {
                        this.Reclaim(v);
                    }
                    this.instantiator.DiscardDictionaryOfIntToThingContainer((Dictionary<int,ThingContainer>)o.TheMap);
                }
                this.instantiator.DiscardIntThingContainerMap(o);
            }
        }
        public void Reclaim(AutogenerateTest o) {
            if (o != null) {
                o.Value = default(int);
                this.instantiator.DiscardAutogenerateTest(o);
            }
        }
    }
}
