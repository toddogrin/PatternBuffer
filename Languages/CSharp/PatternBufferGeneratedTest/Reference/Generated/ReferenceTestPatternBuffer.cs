
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System.Text;
using System;
using System.Collections.Generic;

namespace Test.Reference {
    public class ReferenceTestPatternBuffer {
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
        private IReferenceTestInstantiator instantiator;
        public ReferenceTestPatternBuffer() : this(4096, new DefaultReferenceTestInstantiator()) { }
        public ReferenceTestPatternBuffer(uint bufferSize) : this (bufferSize, new DefaultReferenceTestInstantiator()) { }
        public ReferenceTestPatternBuffer(IReferenceTestInstantiator instantiator) : this (4096, instantiator) { }
        public ReferenceTestPatternBuffer(uint bufferSize, IReferenceTestInstantiator instantiator) {
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
        public byte[] Energize(FinalObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(FinalThing1 o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(FinalThing2 o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(AbstractReferenceObject o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public void Energize(Thing o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 11;
            }
                // PRIMITIVE: IntValue
                bytes[index++] = (byte)((o.IntValue >> 24) & 255);
                bytes[index++] = (byte)((o.IntValue >> 16) & 255);
                bytes[index++] = (byte)((o.IntValue >> 8) & 255);
                bytes[index++] = (byte)(o.IntValue & 255);
        }
        public void Energize(FinalObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 12;
            }
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                bytes[index++] = 0;
                nullFlagsIndex++;
                // REFERENCE: ThingValue
                if (o.ThingValue != null) {
                    bytes[nullFlagsIndex] |= (byte)(128);
                Energize(o.ThingValue, bytes, ref index, false);
                }
        }
        public void Energize(FinalThing1 o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 22;
            }
                // PRIMITIVE: IntValue1
                bytes[index++] = (byte)((o.IntValue1 >> 24) & 255);
                bytes[index++] = (byte)((o.IntValue1 >> 16) & 255);
                bytes[index++] = (byte)((o.IntValue1 >> 8) & 255);
                bytes[index++] = (byte)(o.IntValue1 & 255);
                // PRIMITIVE: IntValue2a
                bytes[index++] = (byte)((o.IntValue2a >> 24) & 255);
                bytes[index++] = (byte)((o.IntValue2a >> 16) & 255);
                bytes[index++] = (byte)((o.IntValue2a >> 8) & 255);
                bytes[index++] = (byte)(o.IntValue2a & 255);
        }
        public void Energize(FinalThing2 o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 23;
            }
                // PRIMITIVE: IntValue1
                bytes[index++] = (byte)((o.IntValue1 >> 24) & 255);
                bytes[index++] = (byte)((o.IntValue1 >> 16) & 255);
                bytes[index++] = (byte)((o.IntValue1 >> 8) & 255);
                bytes[index++] = (byte)(o.IntValue1 & 255);
                // PRIMITIVE: IntValue2a
                bytes[index++] = (byte)((o.IntValue2a >> 24) & 255);
                bytes[index++] = (byte)((o.IntValue2a >> 16) & 255);
                bytes[index++] = (byte)((o.IntValue2a >> 8) & 255);
                bytes[index++] = (byte)(o.IntValue2a & 255);
        }
        public void Energize(AbstractReferenceObject o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 24;
            }
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                bytes[index++] = 0;
                nullFlagsIndex++;
                // REFERENCE: Thing
                if (o.Thing != null) {
                    bytes[nullFlagsIndex] |= (byte)(128);
                Energize((IReferenceTestObject)o.Thing, bytes, ref index, true);
                }
        }
        public void Energize(IReferenceTestObject o, byte[] bytes, ref int index, bool writeTypeId) {
            switch (o.TypeId) {
                case 11:
                    Energize((Thing)o, bytes, ref index, writeTypeId);
                    break;
                case 12:
                    Energize((FinalObject)o, bytes, ref index, writeTypeId);
                    break;
                case 22:
                    Energize((FinalThing1)o, bytes, ref index, writeTypeId);
                    break;
                case 23:
                    Energize((FinalThing2)o, bytes, ref index, writeTypeId);
                    break;
                case 24:
                    Energize((AbstractReferenceObject)o, bytes, ref index, writeTypeId);
                    break;
                default:
                    throw new ReferenceTestPatternBufferException("Unrecognized type ID: "+o.TypeId+" ");
            }
        }
///////////////////////////////////////
// FROM BYTES
///////////////////////////////////////
        public object Energize(byte[] bytes) {
            int index = 0;
                    ulong vuread_yWDHDgqsgOrV = 0;
                    for (int i_x7T9ggssolTP = 0; i_x7T9ggssolTP < 9; i_x7T9ggssolTP++) {
                        byte b = bytes[index++];
                        if (i_x7T9ggssolTP < 8) {
                            vuread_yWDHDgqsgOrV += (((ulong)b & (ulong)127) << (7 * i_x7T9ggssolTP));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_yWDHDgqsgOrV += (ulong)b << (7 * i_x7T9ggssolTP);
                            break;
                        }
                    }
                    ushort typeId = (ushort)vuread_yWDHDgqsgOrV;
            switch (typeId) {
            case 11:
                {
                Thing o = this.instantiator.AcquireThing();
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
            case 12:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                FinalObject o = this.instantiator.AcquireFinalObject();
                nullFlagsIndex++;
                // REFERENCE: ThingValue
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
                o.ThingValue = (Thing)Energize(bytes, ref index, 11);
                }
                    return o;
                }
            case 22:
                {
                FinalThing1 o = this.instantiator.AcquireFinalThing1();
                // PRIMITIVE: IntValue1
                o.IntValue1 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                // PRIMITIVE: IntValue2a
                o.IntValue2a =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    return o;
                }
            case 23:
                {
                FinalThing2 o = this.instantiator.AcquireFinalThing2();
                // PRIMITIVE: IntValue1
                o.IntValue1 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                // PRIMITIVE: IntValue2a
                o.IntValue2a =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    return o;
                }
            case 24:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                AbstractReferenceObject o = this.instantiator.AcquireAbstractReferenceObject();
                nullFlagsIndex++;
                // REFERENCE: Thing
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
                o.Thing = (AbstractThing)Energize(bytes, ref index);
                }
                    return o;
                }
                default:
                    throw new ReferenceTestPatternBufferException("Unrecognized type ID: "+typeId+" ");
            }
        }
        public object Energize(byte[] bytes, ref int index) {
                    ulong vuread_e2gF4LLKmgmj = 0;
                    for (int i_bUcUI05wA86c = 0; i_bUcUI05wA86c < 9; i_bUcUI05wA86c++) {
                        byte b = bytes[index++];
                        if (i_bUcUI05wA86c < 8) {
                            vuread_e2gF4LLKmgmj += (((ulong)b & (ulong)127) << (7 * i_bUcUI05wA86c));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_e2gF4LLKmgmj += (ulong)b << (7 * i_bUcUI05wA86c);
                            break;
                        }
                    }
                    ushort typeId = (ushort)vuread_e2gF4LLKmgmj;
            switch (typeId) {
            case 11:
                {
                Thing o = this.instantiator.AcquireThing();
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
            case 12:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                FinalObject o = this.instantiator.AcquireFinalObject();
                nullFlagsIndex++;
                // REFERENCE: ThingValue
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
                o.ThingValue = (Thing)Energize(bytes, ref index, 11);
                }
                    return o;
                }
            case 22:
                {
                FinalThing1 o = this.instantiator.AcquireFinalThing1();
                // PRIMITIVE: IntValue1
                o.IntValue1 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                // PRIMITIVE: IntValue2a
                o.IntValue2a =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    return o;
                }
            case 23:
                {
                FinalThing2 o = this.instantiator.AcquireFinalThing2();
                // PRIMITIVE: IntValue1
                o.IntValue1 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                // PRIMITIVE: IntValue2a
                o.IntValue2a =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    return o;
                }
            case 24:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                AbstractReferenceObject o = this.instantiator.AcquireAbstractReferenceObject();
                nullFlagsIndex++;
                // REFERENCE: Thing
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
                o.Thing = (AbstractThing)Energize(bytes, ref index);
                }
                    return o;
                }
                default:
                    throw new ReferenceTestPatternBufferException("Unrecognized type ID: "+typeId+" ");
            }
        }
        public object Energize(byte[] bytes, ref int index, ushort typeId) {
            switch (typeId) {
            case 11:
                {
                Thing o = this.instantiator.AcquireThing();
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
            case 12:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                FinalObject o = this.instantiator.AcquireFinalObject();
                nullFlagsIndex++;
                // REFERENCE: ThingValue
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
                o.ThingValue = (Thing)Energize(bytes, ref index, 11);
                }
                    return o;
                }
            case 22:
                {
                FinalThing1 o = this.instantiator.AcquireFinalThing1();
                // PRIMITIVE: IntValue1
                o.IntValue1 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                // PRIMITIVE: IntValue2a
                o.IntValue2a =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    return o;
                }
            case 23:
                {
                FinalThing2 o = this.instantiator.AcquireFinalThing2();
                // PRIMITIVE: IntValue1
                o.IntValue1 =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                // PRIMITIVE: IntValue2a
                o.IntValue2a =
                    (int)(
                        ((int)bytes[index++] << 24) |
                        ((int)bytes[index++] << 16) |
                        ((int)bytes[index++] << 8) |
                        (int)bytes[index++]
                    );
                    return o;
                }
            case 24:
                {
                // NULL FLAGS
                int nullFlagsIndex = index - 1;
                index += 1;
                AbstractReferenceObject o = this.instantiator.AcquireAbstractReferenceObject();
                nullFlagsIndex++;
                // REFERENCE: Thing
                if ((bytes[nullFlagsIndex] & (byte)128) > 0) {
                o.Thing = (AbstractThing)Energize(bytes, ref index);
                }
                    return o;
                }
                default:
                    throw new ReferenceTestPatternBufferException("Unrecognized type ID: "+typeId+" ");
            }
        }
///////////////////////////////////////
// FROM BYTES (TYPED)
///////////////////////////////////////
        public TYPE Energize< TYPE > (byte[] bytes) {
            object o = this.Energize(bytes);
            if (!(o is TYPE)) {
                throw new ReferenceTestPatternBufferException("Deserialized type (" + o.GetType().Name + ") does not match expected type (" + typeof(TYPE).Name + ").");
            }
            return (TYPE)o;
        }
///////////////////////////////////////
// RECLAIM
///////////////////////////////////////
        public void Reclaim(Thing o) {
            if (o != null) {
                o.IntValue = default(int);
                this.instantiator.DiscardThing(o);
            }
        }
        public void Reclaim(FinalObject o) {
            if (o != null) {
                if (o.ThingValue != null) {
                    this.Reclaim(o.ThingValue);
                }
                o.ThingValue = default(Thing);
                this.instantiator.DiscardFinalObject(o);
            }
        }
        public void Reclaim(AbstractThing o) {
            if (o != null) {
                if (o is FinalThing1) {
                    this.Reclaim((FinalThing1)o);
                }
                else if (o is FinalThing2) {
                    this.Reclaim((FinalThing2)o);
                }
                o.IntValue1 = default(int);
            }
        }
        public void Reclaim(FinalThing1 o) {
            if (o != null) {
                o.IntValue2a = default(int);
                this.instantiator.DiscardFinalThing1(o);
            }
        }
        public void Reclaim(FinalThing2 o) {
            if (o != null) {
                o.IntValue2a = default(int);
                this.instantiator.DiscardFinalThing2(o);
            }
        }
        public void Reclaim(AbstractReferenceObject o) {
            if (o != null) {
                if (o.Thing != null) {
                    this.Reclaim(o.Thing);
                }
                o.Thing = default(AbstractThing);
                this.instantiator.DiscardAbstractReferenceObject(o);
            }
        }
    }
}
