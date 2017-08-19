
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using PatternBuffer;
using System.Text;
using System;
using System.Collections.Generic;

namespace Test.Autonumber {
    public class AutonumberTestPatternBuffer {
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
        private IAutonumberTestInstantiator instantiator;
        public AutonumberTestPatternBuffer() : this(4096, new DefaultAutonumberTestInstantiator()) { }
        public AutonumberTestPatternBuffer(uint bufferSize) : this (bufferSize, new DefaultAutonumberTestInstantiator()) { }
        public AutonumberTestPatternBuffer(IAutonumberTestInstantiator instantiator) : this (4096, instantiator) { }
        public AutonumberTestPatternBuffer(uint bufferSize, IAutonumberTestInstantiator instantiator) {
            this.bytes = new byte[bufferSize];
            this.instantiator = instantiator;
        }
///////////////////////////////////////
// TO BYTES
///////////////////////////////////////
        public byte[] Energize(ShouldBe1 o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(ShouldBe2 o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(ShouldBe3 o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(BaseThingShouldBe17 o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(ShouldBe4 o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(BaseThingShouldBe5 o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(ShouldBe57 o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(NewAbstractShouldBe6 o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(NewAbstractShouldBe7 o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(NewAbstractShouldBe8 o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public byte[] Energize(ShouldBe566 o) {
            int index = 0;
            Energize(o, bytes, ref index, true);
            byte[] result = this.instantiator.AcquireByteArray(index);
            Buffer.BlockCopy(bytes, 0, result, 0, index);
            return result;
        }
        public void Energize(ShouldBe1 o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 1;
            }
                // PRIMITIVE: Value
                bytes[index++] = (byte)((o.Value >> 24) & 255);
                bytes[index++] = (byte)((o.Value >> 16) & 255);
                bytes[index++] = (byte)((o.Value >> 8) & 255);
                bytes[index++] = (byte)(o.Value & 255);
        }
        public void Energize(ShouldBe2 o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 2;
            }
                // PRIMITIVE: Value
                bytes[index++] = (byte)((o.Value >> 24) & 255);
                bytes[index++] = (byte)((o.Value >> 16) & 255);
                bytes[index++] = (byte)((o.Value >> 8) & 255);
                bytes[index++] = (byte)(o.Value & 255);
        }
        public void Energize(ShouldBe3 o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 3;
            }
                // PRIMITIVE: Value
                bytes[index++] = (byte)((o.Value >> 24) & 255);
                bytes[index++] = (byte)((o.Value >> 16) & 255);
                bytes[index++] = (byte)((o.Value >> 8) & 255);
                bytes[index++] = (byte)(o.Value & 255);
        }
        public void Energize(BaseThingShouldBe17 o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 17;
            }
                // PRIMITIVE: Dunno1
                bytes[index++] = o.Dunno1 ? (byte)1 : (byte)0;
                // PRIMITIVE: Dunno2
                bytes[index++] = o.Dunno2 ? (byte)1 : (byte)0;
        }
        public void Energize(ShouldBe4 o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 4;
            }
                // PRIMITIVE: Dunno1
                bytes[index++] = o.Dunno1 ? (byte)1 : (byte)0;
                // PRIMITIVE: Dunno2
                bytes[index++] = o.Dunno2 ? (byte)1 : (byte)0;
                // PRIMITIVE: Dunno3
                bytes[index++] = o.Dunno3 ? (byte)1 : (byte)0;
        }
        public void Energize(BaseThingShouldBe5 o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 5;
            }
                // PRIMITIVE: Dunno1
                bytes[index++] = o.Dunno1 ? (byte)1 : (byte)0;
                // PRIMITIVE: Dunno4
                bytes[index++] = o.Dunno4 ? (byte)1 : (byte)0;
        }
        public void Energize(ShouldBe57 o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 57;
            }
                // PRIMITIVE: Dunno1
                bytes[index++] = o.Dunno1 ? (byte)1 : (byte)0;
                // PRIMITIVE: Dunno4
                bytes[index++] = o.Dunno4 ? (byte)1 : (byte)0;
                // PRIMITIVE: Dunno5
                bytes[index++] = o.Dunno5 ? (byte)1 : (byte)0;
        }
        public void Energize(NewAbstractShouldBe6 o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 6;
            }
                // PRIMITIVE: Dunno6
                bytes[index++] = o.Dunno6 ? (byte)1 : (byte)0;
        }
        public void Energize(NewAbstractShouldBe7 o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 7;
            }
                // PRIMITIVE: Dunno7
                bytes[index++] = o.Dunno7 ? (byte)1 : (byte)0;
        }
        public void Energize(NewAbstractShouldBe8 o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 8;
            }
                // PRIMITIVE: Dunno8
                bytes[index++] = o.Dunno8 ? (byte)1 : (byte)0;
        }
        public void Energize(ShouldBe566 o, byte[] bytes, ref int index, bool writeTypeId) {
            if (writeTypeId) {
            bytes[index++] = 182;
            bytes[index++] = 4;
            }
                // PRIMITIVE: Dunno566
                bytes[index++] = o.Dunno566 ? (byte)1 : (byte)0;
        }
        public void Energize(IAutonumberTestObject o, byte[] bytes, ref int index, bool writeTypeId) {
            switch (o.TypeId) {
                case 1:
                    Energize((ShouldBe1)o, bytes, ref index, writeTypeId);
                    break;
                case 2:
                    Energize((ShouldBe2)o, bytes, ref index, writeTypeId);
                    break;
                case 3:
                    Energize((ShouldBe3)o, bytes, ref index, writeTypeId);
                    break;
                case 17:
                    Energize((BaseThingShouldBe17)o, bytes, ref index, writeTypeId);
                    break;
                case 4:
                    Energize((ShouldBe4)o, bytes, ref index, writeTypeId);
                    break;
                case 5:
                    Energize((BaseThingShouldBe5)o, bytes, ref index, writeTypeId);
                    break;
                case 57:
                    Energize((ShouldBe57)o, bytes, ref index, writeTypeId);
                    break;
                case 6:
                    Energize((NewAbstractShouldBe6)o, bytes, ref index, writeTypeId);
                    break;
                case 7:
                    Energize((NewAbstractShouldBe7)o, bytes, ref index, writeTypeId);
                    break;
                case 8:
                    Energize((NewAbstractShouldBe8)o, bytes, ref index, writeTypeId);
                    break;
                case 566:
                    Energize((ShouldBe566)o, bytes, ref index, writeTypeId);
                    break;
                default:
                    throw new AutonumberTestPatternBufferException("Unrecognized type ID: "+o.TypeId+" ");
            }
        }
///////////////////////////////////////
// FROM BYTES
///////////////////////////////////////
        public object Energize(byte[] bytes) {
            int index = 0;
                    ulong vuread_b9uz8QbXm7Mq = 0;
                    for (int i_j4vNKq1p5LVX = 0; i_j4vNKq1p5LVX < 9; i_j4vNKq1p5LVX++) {
                        byte b = bytes[index++];
                        if (i_j4vNKq1p5LVX < 8) {
                            vuread_b9uz8QbXm7Mq += (((ulong)b & (ulong)127) << (7 * i_j4vNKq1p5LVX));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_b9uz8QbXm7Mq += (ulong)b << (7 * i_j4vNKq1p5LVX);
                            break;
                        }
                    }
                    ushort typeId = (ushort)vuread_b9uz8QbXm7Mq;
            switch (typeId) {
            case 1:
                {
                ShouldBe1 o = this.instantiator.AcquireShouldBe1();
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
            case 2:
                {
                ShouldBe2 o = this.instantiator.AcquireShouldBe2();
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
            case 3:
                {
                ShouldBe3 o = this.instantiator.AcquireShouldBe3();
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
            case 17:
                {
                BaseThingShouldBe17 o = this.instantiator.AcquireBaseThingShouldBe17();
                // PRIMITIVE: Dunno1
                o.Dunno1 = bytes[index++] == 1;
                // PRIMITIVE: Dunno2
                o.Dunno2 = bytes[index++] == 1;
                    return o;
                }
            case 4:
                {
                ShouldBe4 o = this.instantiator.AcquireShouldBe4();
                // PRIMITIVE: Dunno1
                o.Dunno1 = bytes[index++] == 1;
                // PRIMITIVE: Dunno2
                o.Dunno2 = bytes[index++] == 1;
                // PRIMITIVE: Dunno3
                o.Dunno3 = bytes[index++] == 1;
                    return o;
                }
            case 5:
                {
                BaseThingShouldBe5 o = this.instantiator.AcquireBaseThingShouldBe5();
                // PRIMITIVE: Dunno1
                o.Dunno1 = bytes[index++] == 1;
                // PRIMITIVE: Dunno4
                o.Dunno4 = bytes[index++] == 1;
                    return o;
                }
            case 57:
                {
                ShouldBe57 o = this.instantiator.AcquireShouldBe57();
                // PRIMITIVE: Dunno1
                o.Dunno1 = bytes[index++] == 1;
                // PRIMITIVE: Dunno4
                o.Dunno4 = bytes[index++] == 1;
                // PRIMITIVE: Dunno5
                o.Dunno5 = bytes[index++] == 1;
                    return o;
                }
            case 6:
                {
                NewAbstractShouldBe6 o = this.instantiator.AcquireNewAbstractShouldBe6();
                // PRIMITIVE: Dunno6
                o.Dunno6 = bytes[index++] == 1;
                    return o;
                }
            case 7:
                {
                NewAbstractShouldBe7 o = this.instantiator.AcquireNewAbstractShouldBe7();
                // PRIMITIVE: Dunno7
                o.Dunno7 = bytes[index++] == 1;
                    return o;
                }
            case 8:
                {
                NewAbstractShouldBe8 o = this.instantiator.AcquireNewAbstractShouldBe8();
                // PRIMITIVE: Dunno8
                o.Dunno8 = bytes[index++] == 1;
                    return o;
                }
            case 566:
                {
                ShouldBe566 o = this.instantiator.AcquireShouldBe566();
                // PRIMITIVE: Dunno566
                o.Dunno566 = bytes[index++] == 1;
                    return o;
                }
                default:
                    throw new AutonumberTestPatternBufferException("Unrecognized type ID: "+typeId+" ");
            }
        }
        public object Energize(byte[] bytes, ref int index) {
                    ulong vuread_oyX8cM7RTc4d = 0;
                    for (int i_vCfPWczt1cch = 0; i_vCfPWczt1cch < 9; i_vCfPWczt1cch++) {
                        byte b = bytes[index++];
                        if (i_vCfPWczt1cch < 8) {
                            vuread_oyX8cM7RTc4d += (((ulong)b & (ulong)127) << (7 * i_vCfPWczt1cch));
                            if ((int)(b & 128) == 0) {
                                break;
                            }
                        }
                        else {
                            vuread_oyX8cM7RTc4d += (ulong)b << (7 * i_vCfPWczt1cch);
                            break;
                        }
                    }
                    ushort typeId = (ushort)vuread_oyX8cM7RTc4d;
            switch (typeId) {
            case 1:
                {
                ShouldBe1 o = this.instantiator.AcquireShouldBe1();
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
            case 2:
                {
                ShouldBe2 o = this.instantiator.AcquireShouldBe2();
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
            case 3:
                {
                ShouldBe3 o = this.instantiator.AcquireShouldBe3();
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
            case 17:
                {
                BaseThingShouldBe17 o = this.instantiator.AcquireBaseThingShouldBe17();
                // PRIMITIVE: Dunno1
                o.Dunno1 = bytes[index++] == 1;
                // PRIMITIVE: Dunno2
                o.Dunno2 = bytes[index++] == 1;
                    return o;
                }
            case 4:
                {
                ShouldBe4 o = this.instantiator.AcquireShouldBe4();
                // PRIMITIVE: Dunno1
                o.Dunno1 = bytes[index++] == 1;
                // PRIMITIVE: Dunno2
                o.Dunno2 = bytes[index++] == 1;
                // PRIMITIVE: Dunno3
                o.Dunno3 = bytes[index++] == 1;
                    return o;
                }
            case 5:
                {
                BaseThingShouldBe5 o = this.instantiator.AcquireBaseThingShouldBe5();
                // PRIMITIVE: Dunno1
                o.Dunno1 = bytes[index++] == 1;
                // PRIMITIVE: Dunno4
                o.Dunno4 = bytes[index++] == 1;
                    return o;
                }
            case 57:
                {
                ShouldBe57 o = this.instantiator.AcquireShouldBe57();
                // PRIMITIVE: Dunno1
                o.Dunno1 = bytes[index++] == 1;
                // PRIMITIVE: Dunno4
                o.Dunno4 = bytes[index++] == 1;
                // PRIMITIVE: Dunno5
                o.Dunno5 = bytes[index++] == 1;
                    return o;
                }
            case 6:
                {
                NewAbstractShouldBe6 o = this.instantiator.AcquireNewAbstractShouldBe6();
                // PRIMITIVE: Dunno6
                o.Dunno6 = bytes[index++] == 1;
                    return o;
                }
            case 7:
                {
                NewAbstractShouldBe7 o = this.instantiator.AcquireNewAbstractShouldBe7();
                // PRIMITIVE: Dunno7
                o.Dunno7 = bytes[index++] == 1;
                    return o;
                }
            case 8:
                {
                NewAbstractShouldBe8 o = this.instantiator.AcquireNewAbstractShouldBe8();
                // PRIMITIVE: Dunno8
                o.Dunno8 = bytes[index++] == 1;
                    return o;
                }
            case 566:
                {
                ShouldBe566 o = this.instantiator.AcquireShouldBe566();
                // PRIMITIVE: Dunno566
                o.Dunno566 = bytes[index++] == 1;
                    return o;
                }
                default:
                    throw new AutonumberTestPatternBufferException("Unrecognized type ID: "+typeId+" ");
            }
        }
        public object Energize(byte[] bytes, ref int index, ushort typeId) {
            switch (typeId) {
            case 1:
                {
                ShouldBe1 o = this.instantiator.AcquireShouldBe1();
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
            case 2:
                {
                ShouldBe2 o = this.instantiator.AcquireShouldBe2();
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
            case 3:
                {
                ShouldBe3 o = this.instantiator.AcquireShouldBe3();
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
            case 17:
                {
                BaseThingShouldBe17 o = this.instantiator.AcquireBaseThingShouldBe17();
                // PRIMITIVE: Dunno1
                o.Dunno1 = bytes[index++] == 1;
                // PRIMITIVE: Dunno2
                o.Dunno2 = bytes[index++] == 1;
                    return o;
                }
            case 4:
                {
                ShouldBe4 o = this.instantiator.AcquireShouldBe4();
                // PRIMITIVE: Dunno1
                o.Dunno1 = bytes[index++] == 1;
                // PRIMITIVE: Dunno2
                o.Dunno2 = bytes[index++] == 1;
                // PRIMITIVE: Dunno3
                o.Dunno3 = bytes[index++] == 1;
                    return o;
                }
            case 5:
                {
                BaseThingShouldBe5 o = this.instantiator.AcquireBaseThingShouldBe5();
                // PRIMITIVE: Dunno1
                o.Dunno1 = bytes[index++] == 1;
                // PRIMITIVE: Dunno4
                o.Dunno4 = bytes[index++] == 1;
                    return o;
                }
            case 57:
                {
                ShouldBe57 o = this.instantiator.AcquireShouldBe57();
                // PRIMITIVE: Dunno1
                o.Dunno1 = bytes[index++] == 1;
                // PRIMITIVE: Dunno4
                o.Dunno4 = bytes[index++] == 1;
                // PRIMITIVE: Dunno5
                o.Dunno5 = bytes[index++] == 1;
                    return o;
                }
            case 6:
                {
                NewAbstractShouldBe6 o = this.instantiator.AcquireNewAbstractShouldBe6();
                // PRIMITIVE: Dunno6
                o.Dunno6 = bytes[index++] == 1;
                    return o;
                }
            case 7:
                {
                NewAbstractShouldBe7 o = this.instantiator.AcquireNewAbstractShouldBe7();
                // PRIMITIVE: Dunno7
                o.Dunno7 = bytes[index++] == 1;
                    return o;
                }
            case 8:
                {
                NewAbstractShouldBe8 o = this.instantiator.AcquireNewAbstractShouldBe8();
                // PRIMITIVE: Dunno8
                o.Dunno8 = bytes[index++] == 1;
                    return o;
                }
            case 566:
                {
                ShouldBe566 o = this.instantiator.AcquireShouldBe566();
                // PRIMITIVE: Dunno566
                o.Dunno566 = bytes[index++] == 1;
                    return o;
                }
                default:
                    throw new AutonumberTestPatternBufferException("Unrecognized type ID: "+typeId+" ");
            }
        }
///////////////////////////////////////
// FROM BYTES (TYPED)
///////////////////////////////////////
        public TYPE Energize< TYPE > (byte[] bytes) {
            object o = this.Energize(bytes);
            if (!(o is TYPE)) {
                throw new AutonumberTestPatternBufferException("Deserialized type (" + o.GetType().Name + ") does not match expected type (" + typeof(TYPE).Name + ").");
            }
            return (TYPE)o;
        }
///////////////////////////////////////
// RECLAIM
///////////////////////////////////////
        public void Reclaim(ShouldBe1 o) {
            if (o != null) {
                o.Value = default(int);
                this.instantiator.DiscardShouldBe1(o);
            }
        }
        public void Reclaim(ShouldBe2 o) {
            if (o != null) {
                o.Value = default(int);
                this.instantiator.DiscardShouldBe2(o);
            }
        }
        public void Reclaim(ShouldBe3 o) {
            if (o != null) {
                o.Value = default(int);
                this.instantiator.DiscardShouldBe3(o);
            }
        }
        public void Reclaim(AbstractThingShouldBe0 o) {
            if (o != null) {
                if (o is BaseThingShouldBe17) {
                    this.Reclaim((BaseThingShouldBe17)o);
                }
                else if (o is BaseThingShouldBe5) {
                    this.Reclaim((BaseThingShouldBe5)o);
                }
                o.Dunno1 = default(bool);
            }
        }
        public void Reclaim(BaseThingShouldBe17 o) {
            if (o != null) {
                if (o is ShouldBe4) {
                    this.Reclaim((ShouldBe4)o);
                }
                o.Dunno2 = default(bool);
            }
        }
        public void Reclaim(ShouldBe4 o) {
            if (o != null) {
                o.Dunno3 = default(bool);
                this.instantiator.DiscardShouldBe4(o);
            }
        }
        public void Reclaim(BaseThingShouldBe5 o) {
            if (o != null) {
                if (o is ShouldBe57) {
                    this.Reclaim((ShouldBe57)o);
                }
                o.Dunno4 = default(bool);
            }
        }
        public void Reclaim(ShouldBe57 o) {
            if (o != null) {
                o.Dunno5 = default(bool);
                this.instantiator.DiscardShouldBe57(o);
            }
        }
        public void Reclaim(NewAbstractShouldBe6 o) {
            if (o != null) {
                o.Dunno6 = default(bool);
                this.instantiator.DiscardNewAbstractShouldBe6(o);
            }
        }
        public void Reclaim(NewAbstractShouldBe7 o) {
            if (o != null) {
                o.Dunno7 = default(bool);
                this.instantiator.DiscardNewAbstractShouldBe7(o);
            }
        }
        public void Reclaim(NewAbstractShouldBe8 o) {
            if (o != null) {
                o.Dunno8 = default(bool);
                this.instantiator.DiscardNewAbstractShouldBe8(o);
            }
        }
        public void Reclaim(ShouldBe566 o) {
            if (o != null) {
                o.Dunno566 = default(bool);
                this.instantiator.DiscardShouldBe566(o);
            }
        }
    }
}
