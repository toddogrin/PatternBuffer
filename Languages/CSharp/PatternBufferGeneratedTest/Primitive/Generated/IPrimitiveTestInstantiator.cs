
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

using System.Collections.Generic;
namespace Test.Primitive {
    public interface IPrimitiveTestInstantiator {
        ShortObject AcquireShortObject();
        void DiscardShortObject(ShortObject o);
        IntObject AcquireIntObject();
        void DiscardIntObject(IntObject o);
        LongObject AcquireLongObject();
        void DiscardLongObject(LongObject o);
        UShortObject AcquireUShortObject();
        void DiscardUShortObject(UShortObject o);
        UIntObject AcquireUIntObject();
        void DiscardUIntObject(UIntObject o);
        ULongObject AcquireULongObject();
        void DiscardULongObject(ULongObject o);
        StringObject AcquireStringObject();
        void DiscardStringObject(StringObject o);
        DoubleObject AcquireDoubleObject();
        void DiscardDoubleObject(DoubleObject o);
        FloatObject AcquireFloatObject();
        void DiscardFloatObject(FloatObject o);
        BoolObject AcquireBoolObject();
        void DiscardBoolObject(BoolObject o);
        ByteObject AcquireByteObject();
        void DiscardByteObject(ByteObject o);
        EverythingObject AcquireEverythingObject();
        void DiscardEverythingObject(EverythingObject o);
        VIntObject AcquireVIntObject();
        void DiscardVIntObject(VIntObject o);
        VLongObject AcquireVLongObject();
        void DiscardVLongObject(VLongObject o);
        VUShortObject AcquireVUShortObject();
        void DiscardVUShortObject(VUShortObject o);
        VUIntObject AcquireVUIntObject();
        void DiscardVUIntObject(VUIntObject o);
        VULongObject AcquireVULongObject();
        void DiscardVULongObject(VULongObject o);
        HighScoreObject AcquireHighScoreObject();
        void DiscardHighScoreObject(HighScoreObject o);


        byte[] AcquireByteArray(int size);
        void DiscardByteArray(byte[] bytes);

    }
}
