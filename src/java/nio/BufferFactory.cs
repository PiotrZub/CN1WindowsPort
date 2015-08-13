// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.nio {
public class BufferFactory: global::java.lang.Object {
new public void @this(){
//XMLVM_BEGIN_WRAPPER[java.nio.BufferFactory: void <init>()]
    global::org.xmlvm._nElement _r0;
    _r0.i = 0;
    _r0.l = 0;
    _r0.f = 0;
    _r0.d = 0;
    global::System.Object _r0_o = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[java.nio.BufferFactory: void <init>()]
}

public static global::System.Object newByteBuffer(global::org.xmlvm._nArrayAdapter<sbyte> n1){
//XMLVM_BEGIN_WRAPPER[java.nio.BufferFactory: java.nio.ByteBuffer newByteBuffer(byte[])]
    global::org.xmlvm._nElement _r0;
    _r0.i = 0;
    _r0.l = 0;
    _r0.f = 0;
    _r0.d = 0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r1.i = 0;
    _r1.l = 0;
    _r1.f = 0;
    _r1.d = 0;
    global::System.Object _r1_o = null;
    _r1_o = n1;
    _r0_o = new global::java.nio.ReadWriteHeapByteBuffer();
    ((global::java.nio.ReadWriteHeapByteBuffer) _r0_o).@this((global::org.xmlvm._nArrayAdapter<sbyte>) _r1_o);
    return (global::java.nio.ByteBuffer) _r0_o;
//XMLVM_END_WRAPPER[java.nio.BufferFactory: java.nio.ByteBuffer newByteBuffer(byte[])]
}

public static global::System.Object newByteBuffer(int n1){
//XMLVM_BEGIN_WRAPPER[java.nio.BufferFactory: java.nio.ByteBuffer newByteBuffer(int)]
    global::org.xmlvm._nElement _r0;
    _r0.i = 0;
    _r0.l = 0;
    _r0.f = 0;
    _r0.d = 0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r1.i = 0;
    _r1.l = 0;
    _r1.f = 0;
    _r1.d = 0;
    _r1.i = n1;
    _r0_o = new global::java.nio.ReadWriteHeapByteBuffer();
    ((global::java.nio.ReadWriteHeapByteBuffer) _r0_o).@this((int) _r1.i);
    return (global::java.nio.ByteBuffer) _r0_o;
//XMLVM_END_WRAPPER[java.nio.BufferFactory: java.nio.ByteBuffer newByteBuffer(int)]
}

public static global::System.Object newCharBuffer(global::org.xmlvm._nArrayAdapter<char> n1){
//XMLVM_BEGIN_WRAPPER[java.nio.BufferFactory: java.nio.CharBuffer newCharBuffer(char[])]
    global::org.xmlvm._nElement _r0;
    _r0.i = 0;
    _r0.l = 0;
    _r0.f = 0;
    _r0.d = 0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r1.i = 0;
    _r1.l = 0;
    _r1.f = 0;
    _r1.d = 0;
    global::System.Object _r1_o = null;
    _r1_o = n1;
    _r0_o = new global::java.nio.ReadWriteCharArrayBuffer();
    ((global::java.nio.ReadWriteCharArrayBuffer) _r0_o).@this((global::org.xmlvm._nArrayAdapter<char>) _r1_o);
    return (global::java.nio.CharBuffer) _r0_o;
//XMLVM_END_WRAPPER[java.nio.BufferFactory: java.nio.CharBuffer newCharBuffer(char[])]
}

public static global::System.Object newCharBuffer(global::java.lang.CharSequence n1){
//XMLVM_BEGIN_WRAPPER[java.nio.BufferFactory: java.nio.CharBuffer newCharBuffer(java.lang.CharSequence)]
    return new CharSequenceAdapter(n1);
//XMLVM_END_WRAPPER[java.nio.BufferFactory: java.nio.CharBuffer newCharBuffer(java.lang.CharSequence)]
}

public static global::System.Object newCharBuffer(int n1){
//XMLVM_BEGIN_WRAPPER[java.nio.BufferFactory: java.nio.CharBuffer newCharBuffer(int)]
    global::org.xmlvm._nElement _r0;
    _r0.i = 0;
    _r0.l = 0;
    _r0.f = 0;
    _r0.d = 0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r1.i = 0;
    _r1.l = 0;
    _r1.f = 0;
    _r1.d = 0;
    _r1.i = n1;
    _r0_o = new global::java.nio.ReadWriteCharArrayBuffer();
    ((global::java.nio.ReadWriteCharArrayBuffer) _r0_o).@this((int) _r1.i);
    return (global::java.nio.CharBuffer) _r0_o;
//XMLVM_END_WRAPPER[java.nio.BufferFactory: java.nio.CharBuffer newCharBuffer(int)]
}

public static global::System.Object newDirectByteBuffer(int n1){
//XMLVM_BEGIN_WRAPPER[java.nio.BufferFactory: java.nio.ByteBuffer newDirectByteBuffer(int)]
    global::org.xmlvm._nElement _r0;
    _r0.i = 0;
    _r0.l = 0;
    _r0.f = 0;
    _r0.d = 0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r1.i = 0;
    _r1.l = 0;
    _r1.f = 0;
    _r1.d = 0;
    _r1.i = n1;
    _r0_o = new global::java.nio.ReadWriteDirectByteBuffer();
    ((global::java.nio.ReadWriteDirectByteBuffer) _r0_o).@this((int) _r1.i);
    return (global::java.nio.ByteBuffer) _r0_o;
//XMLVM_END_WRAPPER[java.nio.BufferFactory: java.nio.ByteBuffer newDirectByteBuffer(int)]
}

public static global::System.Object newDoubleBuffer(global::org.xmlvm._nArrayAdapter<double> n1){
//XMLVM_BEGIN_WRAPPER[java.nio.BufferFactory: java.nio.DoubleBuffer newDoubleBuffer(double[])]
    global::org.xmlvm._nElement _r0;
    _r0.i = 0;
    _r0.l = 0;
    _r0.f = 0;
    _r0.d = 0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r1.i = 0;
    _r1.l = 0;
    _r1.f = 0;
    _r1.d = 0;
    global::System.Object _r1_o = null;
    _r1_o = n1;
    _r0_o = new global::java.nio.ReadWriteDoubleArrayBuffer();
    ((global::java.nio.ReadWriteDoubleArrayBuffer) _r0_o).@this((global::org.xmlvm._nArrayAdapter<double>) _r1_o);
    return (global::java.nio.DoubleBuffer) _r0_o;
//XMLVM_END_WRAPPER[java.nio.BufferFactory: java.nio.DoubleBuffer newDoubleBuffer(double[])]
}

public static global::System.Object newDoubleBuffer(int n1){
//XMLVM_BEGIN_WRAPPER[java.nio.BufferFactory: java.nio.DoubleBuffer newDoubleBuffer(int)]
    global::org.xmlvm._nElement _r0;
    _r0.i = 0;
    _r0.l = 0;
    _r0.f = 0;
    _r0.d = 0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r1.i = 0;
    _r1.l = 0;
    _r1.f = 0;
    _r1.d = 0;
    _r1.i = n1;
    _r0_o = new global::java.nio.ReadWriteDoubleArrayBuffer();
    ((global::java.nio.ReadWriteDoubleArrayBuffer) _r0_o).@this((int) _r1.i);
    return (global::java.nio.DoubleBuffer) _r0_o;
//XMLVM_END_WRAPPER[java.nio.BufferFactory: java.nio.DoubleBuffer newDoubleBuffer(int)]
}

public static global::System.Object newFloatBuffer(global::org.xmlvm._nArrayAdapter<float> n1){
//XMLVM_BEGIN_WRAPPER[java.nio.BufferFactory: java.nio.FloatBuffer newFloatBuffer(float[])]
    global::org.xmlvm._nElement _r0;
    _r0.i = 0;
    _r0.l = 0;
    _r0.f = 0;
    _r0.d = 0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r1.i = 0;
    _r1.l = 0;
    _r1.f = 0;
    _r1.d = 0;
    global::System.Object _r1_o = null;
    _r1_o = n1;
    _r0_o = new global::java.nio.ReadWriteFloatArrayBuffer();
    ((global::java.nio.ReadWriteFloatArrayBuffer) _r0_o).@this((global::org.xmlvm._nArrayAdapter<float>) _r1_o);
    return (global::java.nio.FloatBuffer) _r0_o;
//XMLVM_END_WRAPPER[java.nio.BufferFactory: java.nio.FloatBuffer newFloatBuffer(float[])]
}

public static global::System.Object newFloatBuffer(int n1){
//XMLVM_BEGIN_WRAPPER[java.nio.BufferFactory: java.nio.FloatBuffer newFloatBuffer(int)]
    global::org.xmlvm._nElement _r0;
    _r0.i = 0;
    _r0.l = 0;
    _r0.f = 0;
    _r0.d = 0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r1.i = 0;
    _r1.l = 0;
    _r1.f = 0;
    _r1.d = 0;
    _r1.i = n1;
    _r0_o = new global::java.nio.ReadWriteFloatArrayBuffer();
    ((global::java.nio.ReadWriteFloatArrayBuffer) _r0_o).@this((int) _r1.i);
    return (global::java.nio.FloatBuffer) _r0_o;
//XMLVM_END_WRAPPER[java.nio.BufferFactory: java.nio.FloatBuffer newFloatBuffer(int)]
}

public static global::System.Object newIntBuffer(int n1){
//XMLVM_BEGIN_WRAPPER[java.nio.BufferFactory: java.nio.IntBuffer newIntBuffer(int)]
    global::org.xmlvm._nElement _r0;
    _r0.i = 0;
    _r0.l = 0;
    _r0.f = 0;
    _r0.d = 0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r1.i = 0;
    _r1.l = 0;
    _r1.f = 0;
    _r1.d = 0;
    _r1.i = n1;
    _r0_o = new global::java.nio.ReadWriteIntArrayBuffer();
    ((global::java.nio.ReadWriteIntArrayBuffer) _r0_o).@this((int) _r1.i);
    return (global::java.nio.IntBuffer) _r0_o;
//XMLVM_END_WRAPPER[java.nio.BufferFactory: java.nio.IntBuffer newIntBuffer(int)]
}

public static global::System.Object newIntBuffer(global::org.xmlvm._nArrayAdapter<int> n1){
//XMLVM_BEGIN_WRAPPER[java.nio.BufferFactory: java.nio.IntBuffer newIntBuffer(int[])]
    global::org.xmlvm._nElement _r0;
    _r0.i = 0;
    _r0.l = 0;
    _r0.f = 0;
    _r0.d = 0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r1.i = 0;
    _r1.l = 0;
    _r1.f = 0;
    _r1.d = 0;
    global::System.Object _r1_o = null;
    _r1_o = n1;
    _r0_o = new global::java.nio.ReadWriteIntArrayBuffer();
    ((global::java.nio.ReadWriteIntArrayBuffer) _r0_o).@this((global::org.xmlvm._nArrayAdapter<int>) _r1_o);
    return (global::java.nio.IntBuffer) _r0_o;
//XMLVM_END_WRAPPER[java.nio.BufferFactory: java.nio.IntBuffer newIntBuffer(int[])]
}

public static global::System.Object newLongBuffer(int n1){
//XMLVM_BEGIN_WRAPPER[java.nio.BufferFactory: java.nio.LongBuffer newLongBuffer(int)]
    global::org.xmlvm._nElement _r0;
    _r0.i = 0;
    _r0.l = 0;
    _r0.f = 0;
    _r0.d = 0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r1.i = 0;
    _r1.l = 0;
    _r1.f = 0;
    _r1.d = 0;
    _r1.i = n1;
    _r0_o = new global::java.nio.ReadWriteLongArrayBuffer();
    ((global::java.nio.ReadWriteLongArrayBuffer) _r0_o).@this((int) _r1.i);
    return (global::java.nio.LongBuffer) _r0_o;
//XMLVM_END_WRAPPER[java.nio.BufferFactory: java.nio.LongBuffer newLongBuffer(int)]
}

public static global::System.Object newLongBuffer(global::org.xmlvm._nArrayAdapter<long> n1){
//XMLVM_BEGIN_WRAPPER[java.nio.BufferFactory: java.nio.LongBuffer newLongBuffer(long[])]
    global::org.xmlvm._nElement _r0;
    _r0.i = 0;
    _r0.l = 0;
    _r0.f = 0;
    _r0.d = 0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r1.i = 0;
    _r1.l = 0;
    _r1.f = 0;
    _r1.d = 0;
    global::System.Object _r1_o = null;
    _r1_o = n1;
    _r0_o = new global::java.nio.ReadWriteLongArrayBuffer();
    ((global::java.nio.ReadWriteLongArrayBuffer) _r0_o).@this((global::org.xmlvm._nArrayAdapter<long>) _r1_o);
    return (global::java.nio.LongBuffer) _r0_o;
//XMLVM_END_WRAPPER[java.nio.BufferFactory: java.nio.LongBuffer newLongBuffer(long[])]
}

public static global::System.Object newShortBuffer(int n1){
//XMLVM_BEGIN_WRAPPER[java.nio.BufferFactory: java.nio.ShortBuffer newShortBuffer(int)]
    global::org.xmlvm._nElement _r0;
    _r0.i = 0;
    _r0.l = 0;
    _r0.f = 0;
    _r0.d = 0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r1.i = 0;
    _r1.l = 0;
    _r1.f = 0;
    _r1.d = 0;
    _r1.i = n1;
    _r0_o = new global::java.nio.ReadWriteShortArrayBuffer();
    ((global::java.nio.ReadWriteShortArrayBuffer) _r0_o).@this((int) _r1.i);
    return (global::java.nio.ShortBuffer) _r0_o;
//XMLVM_END_WRAPPER[java.nio.BufferFactory: java.nio.ShortBuffer newShortBuffer(int)]
}

public static global::System.Object newShortBuffer(global::org.xmlvm._nArrayAdapter<short> n1){
//XMLVM_BEGIN_WRAPPER[java.nio.BufferFactory: java.nio.ShortBuffer newShortBuffer(short[])]
    global::org.xmlvm._nElement _r0;
    _r0.i = 0;
    _r0.l = 0;
    _r0.f = 0;
    _r0.d = 0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r1.i = 0;
    _r1.l = 0;
    _r1.f = 0;
    _r1.d = 0;
    global::System.Object _r1_o = null;
    _r1_o = n1;
    _r0_o = new global::java.nio.ReadWriteShortArrayBuffer();
    ((global::java.nio.ReadWriteShortArrayBuffer) _r0_o).@this((global::org.xmlvm._nArrayAdapter<short>) _r1_o);
    return (global::java.nio.ShortBuffer) _r0_o;
//XMLVM_END_WRAPPER[java.nio.BufferFactory: java.nio.ShortBuffer newShortBuffer(short[])]
}

//XMLVM_BEGIN_WRAPPER[java.nio.BufferFactory]
//XMLVM_END_WRAPPER[java.nio.BufferFactory]

} // end of class: BufferFactory

} // end of namespace: java.nio
