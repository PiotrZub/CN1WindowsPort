// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.nio {
public class FloatToByteBufferAdapter: global::java.nio.FloatBuffer,global::org.apache.harmony.nio.@internal.DirectBuffer {

static FloatToByteBufferAdapter() {
    @static();
}

private global::java.nio.ByteBuffer _fbyteBuffer;

public static bool _f_2assertionsDisabled;

new public static void @static(){
//XMLVM_BEGIN_WRAPPER[java.nio.FloatToByteBufferAdapter: void <clinit>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    _r0_o = global::org.xmlvm._nTIB.getClass(typeof(global::java.nio.FloatToByteBufferAdapter));
    _r0.i = ((global::java.lang.Class) _r0_o).desiredAssertionStatus() ? 1 : 0;
    if (_r0.i != 0) goto label12;
    _r0.i = 1;
    label9:;
    global::java.nio.FloatToByteBufferAdapter._f_2assertionsDisabled = 0!=_r0.i;
    return;
    label12:;
    _r0.i = 0;
    goto label9;
//XMLVM_END_WRAPPER[java.nio.FloatToByteBufferAdapter: void <clinit>()]
}

public static global::System.Object wrap(global::java.nio.ByteBuffer n1){
//XMLVM_BEGIN_WRAPPER[java.nio.FloatToByteBufferAdapter: java.nio.FloatBuffer wrap(java.nio.ByteBuffer)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = n1;
    _r0_o = new global::java.nio.FloatToByteBufferAdapter();
    _r1_o = ((global::java.nio.ByteBuffer) _r2_o).slice();
    ((global::java.nio.FloatToByteBufferAdapter) _r0_o).@this((global::java.nio.ByteBuffer) _r1_o);
    return (global::java.nio.FloatBuffer) _r0_o;
//XMLVM_END_WRAPPER[java.nio.FloatToByteBufferAdapter: java.nio.FloatBuffer wrap(java.nio.ByteBuffer)]
}

public void @this(global::java.nio.ByteBuffer n1){
//XMLVM_BEGIN_WRAPPER[java.nio.FloatToByteBufferAdapter: void <init>(java.nio.ByteBuffer)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0.i = ((global::java.nio.ByteBuffer) _r2_o).capacity();
    _r0.i = _r0.i >> (0x1f & 2);
    ((global::java.nio.FloatBuffer) _r1_o).@this((int) _r0.i);
    ((global::java.nio.FloatToByteBufferAdapter) _r1_o)._fbyteBuffer = (global::java.nio.ByteBuffer) _r2_o;
    _r0_o = ((global::java.nio.FloatToByteBufferAdapter) _r1_o)._fbyteBuffer;
    ((global::java.nio.ByteBuffer) _r0_o).clear();
    return;
//XMLVM_END_WRAPPER[java.nio.FloatToByteBufferAdapter: void <init>(java.nio.ByteBuffer)]
}

public virtual int getByteCapacity(){
//XMLVM_BEGIN_WRAPPER[java.nio.FloatToByteBufferAdapter: int getByteCapacity()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = ((global::java.nio.FloatToByteBufferAdapter) _r2_o)._fbyteBuffer;
    _r0.i = ((_r0_o != null) && (_r0_o is global::org.apache.harmony.nio.@internal.DirectBuffer)) ? 1 : 0;
    if (_r0.i == 0) goto label15;
    _r2_o = ((global::java.nio.FloatToByteBufferAdapter) _r2_o)._fbyteBuffer;
    _r0.i = ((global::org.apache.harmony.nio.@internal.DirectBuffer) _r2_o).getByteCapacity();
    label14:;
    return _r0.i;
    label15:;
    _r0.i = global::java.nio.FloatToByteBufferAdapter._f_2assertionsDisabled ? 1 : 0;
    if (_r0.i != 0) goto label27;
    _r0_o = new global::java.lang.AssertionError();
    _r1_o = ((global::java.nio.FloatToByteBufferAdapter) _r2_o)._fbyteBuffer;
    ((global::java.lang.AssertionError) _r0_o).@this((global::java.lang.Object) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.AssertionError) _r0_o);
    label27:;
    _r0.i = -1;
    goto label14;
//XMLVM_END_WRAPPER[java.nio.FloatToByteBufferAdapter: int getByteCapacity()]
}

public virtual global::System.Object getEffectiveAddress(){
//XMLVM_BEGIN_WRAPPER[java.nio.FloatToByteBufferAdapter: java.lang.Object getEffectiveAddress()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = ((global::java.nio.FloatToByteBufferAdapter) _r2_o)._fbyteBuffer;
    _r0.i = ((_r0_o != null) && (_r0_o is global::org.apache.harmony.nio.@internal.DirectBuffer)) ? 1 : 0;
    if (_r0.i == 0) goto label15;
    _r2_o = ((global::java.nio.FloatToByteBufferAdapter) _r2_o)._fbyteBuffer;
    _r0_o = ((global::org.apache.harmony.nio.@internal.DirectBuffer) _r2_o).getEffectiveAddress();
    label14:;
    return (global::java.lang.Object) _r0_o;
    label15:;
    _r0.i = global::java.nio.FloatToByteBufferAdapter._f_2assertionsDisabled ? 1 : 0;
    if (_r0.i != 0) goto label27;
    _r0_o = new global::java.lang.AssertionError();
    _r1_o = ((global::java.nio.FloatToByteBufferAdapter) _r2_o)._fbyteBuffer;
    ((global::java.lang.AssertionError) _r0_o).@this((global::java.lang.Object) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.AssertionError) _r0_o);
    label27:;
    _r0_o = null;
    goto label14;
//XMLVM_END_WRAPPER[java.nio.FloatToByteBufferAdapter: java.lang.Object getEffectiveAddress()]
}

public virtual global::System.Object getBaseAddress(){
//XMLVM_BEGIN_WRAPPER[java.nio.FloatToByteBufferAdapter: java.lang.Object getBaseAddress()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = ((global::java.nio.FloatToByteBufferAdapter) _r2_o)._fbyteBuffer;
    _r0.i = ((_r0_o != null) && (_r0_o is global::org.apache.harmony.nio.@internal.DirectBuffer)) ? 1 : 0;
    if (_r0.i == 0) goto label15;
    _r2_o = ((global::java.nio.FloatToByteBufferAdapter) _r2_o)._fbyteBuffer;
    _r0_o = ((global::org.apache.harmony.nio.@internal.DirectBuffer) _r2_o).getBaseAddress();
    label14:;
    return (global::java.lang.Object) _r0_o;
    label15:;
    _r0.i = global::java.nio.FloatToByteBufferAdapter._f_2assertionsDisabled ? 1 : 0;
    if (_r0.i != 0) goto label27;
    _r0_o = new global::java.lang.AssertionError();
    _r1_o = ((global::java.nio.FloatToByteBufferAdapter) _r2_o)._fbyteBuffer;
    ((global::java.lang.AssertionError) _r0_o).@this((global::java.lang.Object) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.AssertionError) _r0_o);
    label27:;
    _r0_o = null;
    goto label14;
//XMLVM_END_WRAPPER[java.nio.FloatToByteBufferAdapter: java.lang.Object getBaseAddress()]
}

public virtual bool isAddressValid(){
//XMLVM_BEGIN_WRAPPER[java.nio.FloatToByteBufferAdapter: boolean isAddressValid()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = ((global::java.nio.FloatToByteBufferAdapter) _r2_o)._fbyteBuffer;
    _r0.i = ((_r0_o != null) && (_r0_o is global::org.apache.harmony.nio.@internal.DirectBuffer)) ? 1 : 0;
    if (_r0.i == 0) goto label15;
    _r2_o = ((global::java.nio.FloatToByteBufferAdapter) _r2_o)._fbyteBuffer;
    _r0.i = ((global::org.apache.harmony.nio.@internal.DirectBuffer) _r2_o).isAddressValid() ? 1 : 0;
    label14:;
    return _r0.i!=0;
    label15:;
    _r0.i = global::java.nio.FloatToByteBufferAdapter._f_2assertionsDisabled ? 1 : 0;
    if (_r0.i != 0) goto label27;
    _r0_o = new global::java.lang.AssertionError();
    _r1_o = ((global::java.nio.FloatToByteBufferAdapter) _r2_o)._fbyteBuffer;
    ((global::java.lang.AssertionError) _r0_o).@this((global::java.lang.Object) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.AssertionError) _r0_o);
    label27:;
    _r0.i = 0;
    goto label14;
//XMLVM_END_WRAPPER[java.nio.FloatToByteBufferAdapter: boolean isAddressValid()]
}

public virtual void addressValidityCheck(){
//XMLVM_BEGIN_WRAPPER[java.nio.FloatToByteBufferAdapter: void addressValidityCheck()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = ((global::java.nio.FloatToByteBufferAdapter) _r2_o)._fbyteBuffer;
    _r0.i = ((_r0_o != null) && (_r0_o is global::org.apache.harmony.nio.@internal.DirectBuffer)) ? 1 : 0;
    if (_r0.i == 0) goto label14;
    _r2_o = ((global::java.nio.FloatToByteBufferAdapter) _r2_o)._fbyteBuffer;
    ((global::org.apache.harmony.nio.@internal.DirectBuffer) _r2_o).addressValidityCheck();
    label13:;
    return;
    label14:;
    _r0.i = global::java.nio.FloatToByteBufferAdapter._f_2assertionsDisabled ? 1 : 0;
    if (_r0.i != 0) goto label13;
    _r0_o = new global::java.lang.AssertionError();
    _r1_o = ((global::java.nio.FloatToByteBufferAdapter) _r2_o)._fbyteBuffer;
    ((global::java.lang.AssertionError) _r0_o).@this((global::java.lang.Object) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.AssertionError) _r0_o);
//XMLVM_END_WRAPPER[java.nio.FloatToByteBufferAdapter: void addressValidityCheck()]
}

public virtual void free(){
//XMLVM_BEGIN_WRAPPER[java.nio.FloatToByteBufferAdapter: void free()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = ((global::java.nio.FloatToByteBufferAdapter) _r2_o)._fbyteBuffer;
    _r0.i = ((_r0_o != null) && (_r0_o is global::org.apache.harmony.nio.@internal.DirectBuffer)) ? 1 : 0;
    if (_r0.i == 0) goto label14;
    _r2_o = ((global::java.nio.FloatToByteBufferAdapter) _r2_o)._fbyteBuffer;
    ((global::org.apache.harmony.nio.@internal.DirectBuffer) _r2_o).free();
    label13:;
    return;
    label14:;
    _r0.i = global::java.nio.FloatToByteBufferAdapter._f_2assertionsDisabled ? 1 : 0;
    if (_r0.i != 0) goto label13;
    _r0_o = new global::java.lang.AssertionError();
    _r1_o = ((global::java.nio.FloatToByteBufferAdapter) _r2_o)._fbyteBuffer;
    ((global::java.lang.AssertionError) _r0_o).@this((global::java.lang.Object) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.AssertionError) _r0_o);
//XMLVM_END_WRAPPER[java.nio.FloatToByteBufferAdapter: void free()]
}

public override global::System.Object asReadOnlyBuffer(){
//XMLVM_BEGIN_WRAPPER[java.nio.FloatToByteBufferAdapter: java.nio.FloatBuffer asReadOnlyBuffer()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = new global::java.nio.FloatToByteBufferAdapter();
    _r1_o = ((global::java.nio.FloatToByteBufferAdapter) _r2_o)._fbyteBuffer;
    _r1_o = ((global::java.nio.ByteBuffer) _r1_o).asReadOnlyBuffer();
    ((global::java.nio.FloatToByteBufferAdapter) _r0_o).@this((global::java.nio.ByteBuffer) _r1_o);
    _r1.i = ((global::java.nio.FloatToByteBufferAdapter) _r2_o)._flimit;
    ((global::java.nio.FloatToByteBufferAdapter) _r0_o)._flimit = _r1.i;
    _r1.i = ((global::java.nio.FloatToByteBufferAdapter) _r2_o)._fposition;
    ((global::java.nio.FloatToByteBufferAdapter) _r0_o)._fposition = _r1.i;
    _r1.i = ((global::java.nio.FloatToByteBufferAdapter) _r2_o)._fmark;
    ((global::java.nio.FloatToByteBufferAdapter) _r0_o)._fmark = _r1.i;
    return (global::java.nio.FloatBuffer) _r0_o;
//XMLVM_END_WRAPPER[java.nio.FloatToByteBufferAdapter: java.nio.FloatBuffer asReadOnlyBuffer()]
}

public override global::System.Object compact(){
//XMLVM_BEGIN_WRAPPER[java.nio.FloatToByteBufferAdapter: java.nio.FloatBuffer compact()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = ((global::java.nio.FloatToByteBufferAdapter) _r2_o)._fbyteBuffer;
    _r0.i = ((global::java.nio.ByteBuffer) _r0_o).isReadOnly() ? 1 : 0;
    if (_r0.i == 0) goto label14;
    _r0_o = new global::java.nio.ReadOnlyBufferException();
    ((global::java.nio.ReadOnlyBufferException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.nio.ReadOnlyBufferException) _r0_o);
    label14:;
    _r0_o = ((global::java.nio.FloatToByteBufferAdapter) _r2_o)._fbyteBuffer;
    _r1.i = ((global::java.nio.FloatToByteBufferAdapter) _r2_o)._flimit;
    _r1.i = _r1.i << (0x1f & 2);
    ((global::java.nio.ByteBuffer) _r0_o).limit((int) _r1.i);
    _r0_o = ((global::java.nio.FloatToByteBufferAdapter) _r2_o)._fbyteBuffer;
    _r1.i = ((global::java.nio.FloatToByteBufferAdapter) _r2_o)._fposition;
    _r1.i = _r1.i << (0x1f & 2);
    ((global::java.nio.ByteBuffer) _r0_o).position((int) _r1.i);
    _r0_o = ((global::java.nio.FloatToByteBufferAdapter) _r2_o)._fbyteBuffer;
    ((global::java.nio.ByteBuffer) _r0_o).compact();
    _r0_o = ((global::java.nio.FloatToByteBufferAdapter) _r2_o)._fbyteBuffer;
    ((global::java.nio.ByteBuffer) _r0_o).clear();
    _r0.i = ((global::java.nio.FloatToByteBufferAdapter) _r2_o)._flimit;
    _r1.i = ((global::java.nio.FloatToByteBufferAdapter) _r2_o)._fposition;
    _r0.i = _r0.i - _r1.i;
    ((global::java.nio.FloatToByteBufferAdapter) _r2_o)._fposition = _r0.i;
    _r0.i = ((global::java.nio.FloatToByteBufferAdapter) _r2_o)._fcapacity;
    ((global::java.nio.FloatToByteBufferAdapter) _r2_o)._flimit = _r0.i;
    _r0.i = -1;
    ((global::java.nio.FloatToByteBufferAdapter) _r2_o)._fmark = _r0.i;
    return (global::java.nio.FloatBuffer) _r2_o;
//XMLVM_END_WRAPPER[java.nio.FloatToByteBufferAdapter: java.nio.FloatBuffer compact()]
}

public override global::System.Object duplicate(){
//XMLVM_BEGIN_WRAPPER[java.nio.FloatToByteBufferAdapter: java.nio.FloatBuffer duplicate()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = new global::java.nio.FloatToByteBufferAdapter();
    _r1_o = ((global::java.nio.FloatToByteBufferAdapter) _r2_o)._fbyteBuffer;
    _r1_o = ((global::java.nio.ByteBuffer) _r1_o).duplicate();
    ((global::java.nio.FloatToByteBufferAdapter) _r0_o).@this((global::java.nio.ByteBuffer) _r1_o);
    _r1.i = ((global::java.nio.FloatToByteBufferAdapter) _r2_o)._flimit;
    ((global::java.nio.FloatToByteBufferAdapter) _r0_o)._flimit = _r1.i;
    _r1.i = ((global::java.nio.FloatToByteBufferAdapter) _r2_o)._fposition;
    ((global::java.nio.FloatToByteBufferAdapter) _r0_o)._fposition = _r1.i;
    _r1.i = ((global::java.nio.FloatToByteBufferAdapter) _r2_o)._fmark;
    ((global::java.nio.FloatToByteBufferAdapter) _r0_o)._fmark = _r1.i;
    return (global::java.nio.FloatBuffer) _r0_o;
//XMLVM_END_WRAPPER[java.nio.FloatToByteBufferAdapter: java.nio.FloatBuffer duplicate()]
}

public override float get(){
//XMLVM_BEGIN_WRAPPER[java.nio.FloatToByteBufferAdapter: float get()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    _r3_o = this;
    _r0.i = ((global::java.nio.FloatToByteBufferAdapter) _r3_o)._fposition;
    _r1.i = ((global::java.nio.FloatToByteBufferAdapter) _r3_o)._flimit;
    if (_r0.i != _r1.i) goto label12;
    _r0_o = new global::java.nio.BufferUnderflowException();
    ((global::java.nio.BufferUnderflowException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.nio.BufferUnderflowException) _r0_o);
    label12:;
    _r0_o = ((global::java.nio.FloatToByteBufferAdapter) _r3_o)._fbyteBuffer;
    _r1.i = ((global::java.nio.FloatToByteBufferAdapter) _r3_o)._fposition;
    _r2.i = _r1.i + 1;
    ((global::java.nio.FloatToByteBufferAdapter) _r3_o)._fposition = _r2.i;
    _r1.i = _r1.i << (0x1f & 2);
    _r0.f = ((global::java.nio.ByteBuffer) _r0_o).getFloat((int) _r1.i);
    return _r0.f;
//XMLVM_END_WRAPPER[java.nio.FloatToByteBufferAdapter: float get()]
}

public override float get(int n1){
//XMLVM_BEGIN_WRAPPER[java.nio.FloatToByteBufferAdapter: float get(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    _r2_o = this;
    _r3.i = n1;
    if (_r3.i < 0) goto label6;
    _r0.i = ((global::java.nio.FloatToByteBufferAdapter) _r2_o)._flimit;
    if (_r3.i < _r0.i) goto label12;
    label6:;
    _r0_o = new global::java.lang.IndexOutOfBoundsException();
    ((global::java.lang.IndexOutOfBoundsException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IndexOutOfBoundsException) _r0_o);
    label12:;
    _r0_o = ((global::java.nio.FloatToByteBufferAdapter) _r2_o)._fbyteBuffer;
    _r1.i = _r3.i << (0x1f & 2);
    _r0.f = ((global::java.nio.ByteBuffer) _r0_o).getFloat((int) _r1.i);
    return _r0.f;
//XMLVM_END_WRAPPER[java.nio.FloatToByteBufferAdapter: float get(int)]
}

public override bool isDirect(){
//XMLVM_BEGIN_WRAPPER[java.nio.FloatToByteBufferAdapter: boolean isDirect()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.nio.FloatToByteBufferAdapter) _r1_o)._fbyteBuffer;
    _r0.i = ((global::java.nio.ByteBuffer) _r0_o).isDirect() ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.nio.FloatToByteBufferAdapter: boolean isDirect()]
}

public override bool isReadOnly(){
//XMLVM_BEGIN_WRAPPER[java.nio.FloatToByteBufferAdapter: boolean isReadOnly()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.nio.FloatToByteBufferAdapter) _r1_o)._fbyteBuffer;
    _r0.i = ((global::java.nio.ByteBuffer) _r0_o).isReadOnly() ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.nio.FloatToByteBufferAdapter: boolean isReadOnly()]
}

public override global::System.Object order(){
//XMLVM_BEGIN_WRAPPER[java.nio.FloatToByteBufferAdapter: java.nio.ByteOrder order()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.nio.FloatToByteBufferAdapter) _r1_o)._fbyteBuffer;
    _r0_o = ((global::java.nio.ByteBuffer) _r0_o).order();
    return (global::java.nio.ByteOrder) _r0_o;
//XMLVM_END_WRAPPER[java.nio.FloatToByteBufferAdapter: java.nio.ByteOrder order()]
}

public override global::System.Object protectedArray(){
//XMLVM_BEGIN_WRAPPER[java.nio.FloatToByteBufferAdapter: float[] protectedArray()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = new global::java.lang.UnsupportedOperationException();
    ((global::java.lang.UnsupportedOperationException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.UnsupportedOperationException) _r0_o);
//XMLVM_END_WRAPPER[java.nio.FloatToByteBufferAdapter: float[] protectedArray()]
}

public override int protectedArrayOffset(){
//XMLVM_BEGIN_WRAPPER[java.nio.FloatToByteBufferAdapter: int protectedArrayOffset()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = new global::java.lang.UnsupportedOperationException();
    ((global::java.lang.UnsupportedOperationException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.UnsupportedOperationException) _r0_o);
//XMLVM_END_WRAPPER[java.nio.FloatToByteBufferAdapter: int protectedArrayOffset()]
}

public override bool protectedHasArray(){
//XMLVM_BEGIN_WRAPPER[java.nio.FloatToByteBufferAdapter: boolean protectedHasArray()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.nio.FloatToByteBufferAdapter: boolean protectedHasArray()]
}

public override global::System.Object put(float n1){
//XMLVM_BEGIN_WRAPPER[java.nio.FloatToByteBufferAdapter: java.nio.FloatBuffer put(float)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    _r3_o = this;
    _r4.f = n1;
    _r0.i = ((global::java.nio.FloatToByteBufferAdapter) _r3_o)._fposition;
    _r1.i = ((global::java.nio.FloatToByteBufferAdapter) _r3_o)._flimit;
    if (_r0.i != _r1.i) goto label12;
    _r0_o = new global::java.nio.BufferOverflowException();
    ((global::java.nio.BufferOverflowException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.nio.BufferOverflowException) _r0_o);
    label12:;
    _r0_o = ((global::java.nio.FloatToByteBufferAdapter) _r3_o)._fbyteBuffer;
    _r1.i = ((global::java.nio.FloatToByteBufferAdapter) _r3_o)._fposition;
    _r2.i = _r1.i + 1;
    ((global::java.nio.FloatToByteBufferAdapter) _r3_o)._fposition = _r2.i;
    _r1.i = _r1.i << (0x1f & 2);
    ((global::java.nio.ByteBuffer) _r0_o).putFloat((int) _r1.i, (float) _r4.f);
    return (global::java.nio.FloatBuffer) _r3_o;
//XMLVM_END_WRAPPER[java.nio.FloatToByteBufferAdapter: java.nio.FloatBuffer put(float)]
}

public override global::System.Object put(int n1, float n2){
//XMLVM_BEGIN_WRAPPER[java.nio.FloatToByteBufferAdapter: java.nio.FloatBuffer put(int, float)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    _r2_o = this;
    _r3.i = n1;
    _r4.f = n2;
    if (_r3.i < 0) goto label6;
    _r0.i = ((global::java.nio.FloatToByteBufferAdapter) _r2_o)._flimit;
    if (_r3.i < _r0.i) goto label12;
    label6:;
    _r0_o = new global::java.lang.IndexOutOfBoundsException();
    ((global::java.lang.IndexOutOfBoundsException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IndexOutOfBoundsException) _r0_o);
    label12:;
    _r0_o = ((global::java.nio.FloatToByteBufferAdapter) _r2_o)._fbyteBuffer;
    _r1.i = _r3.i << (0x1f & 2);
    ((global::java.nio.ByteBuffer) _r0_o).putFloat((int) _r1.i, (float) _r4.f);
    return (global::java.nio.FloatBuffer) _r2_o;
//XMLVM_END_WRAPPER[java.nio.FloatToByteBufferAdapter: java.nio.FloatBuffer put(int, float)]
}

public override global::System.Object slice(){
//XMLVM_BEGIN_WRAPPER[java.nio.FloatToByteBufferAdapter: java.nio.FloatBuffer slice()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = ((global::java.nio.FloatToByteBufferAdapter) _r2_o)._fbyteBuffer;
    _r1.i = ((global::java.nio.FloatToByteBufferAdapter) _r2_o)._flimit;
    _r1.i = _r1.i << (0x1f & 2);
    ((global::java.nio.ByteBuffer) _r0_o).limit((int) _r1.i);
    _r0_o = ((global::java.nio.FloatToByteBufferAdapter) _r2_o)._fbyteBuffer;
    _r1.i = ((global::java.nio.FloatToByteBufferAdapter) _r2_o)._fposition;
    _r1.i = _r1.i << (0x1f & 2);
    ((global::java.nio.ByteBuffer) _r0_o).position((int) _r1.i);
    _r0_o = new global::java.nio.FloatToByteBufferAdapter();
    _r1_o = ((global::java.nio.FloatToByteBufferAdapter) _r2_o)._fbyteBuffer;
    _r1_o = ((global::java.nio.ByteBuffer) _r1_o).slice();
    ((global::java.nio.FloatToByteBufferAdapter) _r0_o).@this((global::java.nio.ByteBuffer) _r1_o);
    _r1_o = ((global::java.nio.FloatToByteBufferAdapter) _r2_o)._fbyteBuffer;
    ((global::java.nio.ByteBuffer) _r1_o).clear();
    return (global::java.nio.FloatBuffer) _r0_o;
//XMLVM_END_WRAPPER[java.nio.FloatToByteBufferAdapter: java.nio.FloatBuffer slice()]
}

//XMLVM_BEGIN_WRAPPER[java.nio.FloatToByteBufferAdapter]
//XMLVM_END_WRAPPER[java.nio.FloatToByteBufferAdapter]

} // end of class: FloatToByteBufferAdapter

} // end of namespace: java.nio
