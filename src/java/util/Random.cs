// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public class Random: global::java.lang.Object,global::java.io.Serializable {


private bool _fhaveNextNextGaussian;

private long _fseed;

private double _fnextNextGaussian;

new public void @this(){
//XMLVM_BEGIN_WRAPPER[java.util.Random: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r4_o = null;
    _r4_o = this;
    ((global::java.lang.Object) _r4_o).@this();
    _r0.l = global::java.lang.System.currentTimeMillis();
    _r2.i = ((global::java.lang.Object) _r4_o).hashCode();
    _r2.l = (long) _r2.i;
    _r0.l = _r0.l + _r2.l;
    ((global::java.util.Random) _r4_o).setSeed((long) _r0.l);
    return;
//XMLVM_END_WRAPPER[java.util.Random: void <init>()]
}

public void @this(long n1){
//XMLVM_BEGIN_WRAPPER[java.util.Random: void <init>(long)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.l = n1;
    ((global::java.lang.Object) _r0_o).@this();
    ((global::java.util.Random) _r0_o).setSeed((long) _r1.l);
    return;
//XMLVM_END_WRAPPER[java.util.Random: void <init>(long)]
}

public virtual int next(int n1){
//XMLVM_BEGIN_WRAPPER[java.util.Random: int next(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r4_o = this;
    _r5.i = n1;
    global::System.Threading.Monitor.Enter(_r4_o);
    try {
    _r0.l = ((global::java.util.Random) _r4_o)._fseed;
    _r2.l = 25214903917L;
    _r0.l = _r0.l * _r2.l;
    _r2.l = 11L;
    _r0.l = _r0.l + _r2.l;
    _r2.l = 281474976710655L;
    _r0.l = _r0.l & _r2.l;
    ((global::java.util.Random) _r4_o)._fseed = _r0.l;
    _r0.l = ((global::java.util.Random) _r4_o)._fseed;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label29;
        }
        throw ex;
    } // end catch
    _r2.i = 48;
    _r2.i = _r2.i - _r5.i;
    _r0.l = (long) (((ulong) _r0.l) >> (0x3f & (_r2.i)));
    _r0.i = (int) _r0.l;
    global::System.Threading.Monitor.Exit(_r4_o);
    return _r0.i;
    label29:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    global::System.Threading.Monitor.Exit(_r4_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.Throwable) _r0_o);
//XMLVM_END_WRAPPER[java.util.Random: int next(int)]
}

public virtual bool nextBoolean(){
//XMLVM_BEGIN_WRAPPER[java.util.Random: boolean nextBoolean()]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r1.i = 1;
    _r0.i = ((global::java.util.Random) _r2_o).next((int) _r1.i);
    if (_r0.i == 0) goto label9;
    _r0.i = _r1.i;
    label8:;
    return _r0.i!=0;
    label9:;
    _r0.i = 0;
    goto label8;
//XMLVM_END_WRAPPER[java.util.Random: boolean nextBoolean()]
}

public virtual void nextBytes(global::org.xmlvm._nArrayAdapter<sbyte> n1){
//XMLVM_BEGIN_WRAPPER[java.util.Random: void nextBytes(byte[])]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    _r6_o = this;
    _r7_o = n1;
    _r0.i = 0;
    _r1.i = _r0.i;
    _r2.i = _r0.i;
    label3:;
    _r3.i = ((global::org.xmlvm._nIArray) _r7_o).Length;
    if (_r1.i < _r3.i) goto label7;
    return;
    label7:;
    if (_r0.i != 0) goto label27;
    _r0.i = ((global::java.util.Random) _r6_o).nextInt();
    _r2.i = 3;
    _r5.i = _r2.i;
    _r2.i = _r0.i;
    _r0.i = _r5.i;
    label17:;
    _r3.i = _r1.i + 1;
    _r4.i = (_r2.i << 24) >> 24;
    ((global::org.xmlvm._nArrayAdapter<sbyte>) _r7_o)[_r1.i] = (sbyte)_r4.i;
    _r1.i = _r2.i >> (0x1f & 8);
    _r2.i = _r1.i;
    _r1.i = _r3.i;
    goto label3;
    label27:;
    _r0.i = _r0.i + -1;
    goto label17;
//XMLVM_END_WRAPPER[java.util.Random: void nextBytes(byte[])]
}

public virtual double nextDouble(){
//XMLVM_BEGIN_WRAPPER[java.util.Random: double nextDouble()]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r4_o = null;
    _r4_o = this;
    _r2.i = 27;
    _r0.i = 26;
    _r0.i = ((global::java.util.Random) _r4_o).next((int) _r0.i);
    _r0.l = (long) _r0.i;
    _r0.l = _r0.l << (0x3f & _r2.i);
    _r2.i = ((global::java.util.Random) _r4_o).next((int) _r2.i);
    _r2.l = (long) _r2.i;
    _r0.l = _r0.l + _r2.l;
    _r0.d = (double) _r0.l;
    _r2.d = 9.007199254740992E15D;
    _r0.d = _r0.d / _r2.d;
    return _r0.d;
//XMLVM_END_WRAPPER[java.util.Random: double nextDouble()]
}

public virtual float nextFloat(){
//XMLVM_BEGIN_WRAPPER[java.util.Random: float nextFloat()]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0.i = 24;
    _r0.i = ((global::java.util.Random) _r2_o).next((int) _r0.i);
    _r0.f = (float) _r0.i;
    _r1.f = (float)1.6777216E7D;
    _r0.f = _r0.f / _r1.f;
    return _r0.f;
//XMLVM_END_WRAPPER[java.util.Random: float nextFloat()]
}

public virtual double nextGaussian(){
//XMLVM_BEGIN_WRAPPER[java.util.Random: double nextGaussian()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r8;
    global::org.xmlvm._nElement _r10;
    global::System.Object _r12_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r12_o = this;
    _r10.d = 2.0D;
    _r8.d = 1.0D;
    global::System.Threading.Monitor.Enter(_r12_o);
    try {
    _r0.i = ((global::java.util.Random) _r12_o)._fhaveNextNextGaussian ? 1 : 0;
    if (_r0.i == 0) goto label16;
    _r0.i = 0;
    ((global::java.util.Random) _r12_o)._fhaveNextNextGaussian = 0!=_r0.i;
    _r0.d = ((global::java.util.Random) _r12_o)._fnextNextGaussian;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label58;
        }
        throw ex;
    } // end catch
    label14:;
    global::System.Threading.Monitor.Exit(_r12_o);
    return _r0.d;
    label16:;
    try {
    _r0.d = ((global::java.util.Random) _r12_o).nextDouble();
    _r0.d = _r0.d * _r10.d;
    _r0.d = _r0.d - _r8.d;
    _r2.d = ((global::java.util.Random) _r12_o).nextDouble();
    _r2.d = _r2.d * _r10.d;
    _r2.d = _r2.d - _r8.d;
    _r4.d = _r0.d * _r0.d;
    _r6.d = _r2.d * _r2.d;
    _r4.d = _r4.d + _r6.d;
    _r6.i = _r4.d > _r8.d ? 1 : (_r4.d == _r8.d ? 0 : -1);
    if (_r6.i >= 0) goto label16;
    _r6.d = -2.0D;
    _r8.d = global::java.lang.Math.log((double) _r4.d);
    _r6.d = _r6.d * _r8.d;
    _r4.d = _r6.d / _r4.d;
    _r4.d = global::java.lang.Math.sqrt((double) _r4.d);
    _r2.d = _r2.d * _r4.d;
    ((global::java.util.Random) _r12_o)._fnextNextGaussian = _r2.d;
    _r2.i = 1;
    ((global::java.util.Random) _r12_o)._fhaveNextNextGaussian = 0!=_r2.i;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label58;
        }
        throw ex;
    } // end catch
    _r0.d = _r0.d * _r4.d;
    goto label14;
    label58:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    global::System.Threading.Monitor.Exit(_r12_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.Throwable) _r0_o);
//XMLVM_END_WRAPPER[java.util.Random: double nextGaussian()]
}

public virtual int nextInt(){
//XMLVM_BEGIN_WRAPPER[java.util.Random: int nextInt()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = 32;
    _r0.i = ((global::java.util.Random) _r1_o).next((int) _r0.i);
    return _r0.i;
//XMLVM_END_WRAPPER[java.util.Random: int nextInt()]
}

public virtual int nextInt(int n1){
//XMLVM_BEGIN_WRAPPER[java.util.Random: int nextInt(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    _r5_o = this;
    _r6.i = n1;
    _r4.i = 31;
    if (_r6.i <= 0) goto label33;
    _r0.i = -_r6.i;
    _r0.i = _r0.i & _r6.i;
    if (_r0.i != _r6.i) goto label18;
    _r0.l = (long) _r6.i;
    _r2.i = ((global::java.util.Random) _r5_o).next((int) _r4.i);
    _r2.l = (long) _r2.i;
    _r0.l = _r0.l * _r2.l;
    _r0.l = _r0.l >> (0x3f & _r4.i);
    _r0.i = (int) _r0.l;
    label17:;
    return _r0.i;
    label18:;
    _r0.i = ((global::java.util.Random) _r5_o).next((int) _r4.i);
    _r1.i = _r0.i % _r6.i;
    _r0.i = _r0.i - _r1.i;
    _r2.i = 1;
    _r2.i = _r6.i - _r2.i;
    _r0.i = _r0.i + _r2.i;
    if (_r0.i < 0) goto label18;
    _r0.i = _r1.i;
    goto label17;
    label33:;
    _r0_o = new global::java.lang.IllegalArgumentException();
    ((global::java.lang.IllegalArgumentException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r0_o);
//XMLVM_END_WRAPPER[java.util.Random: int nextInt(int)]
}

public virtual long nextLong(){
//XMLVM_BEGIN_WRAPPER[java.util.Random: long nextLong()]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r4_o = null;
    _r4_o = this;
    _r2.i = 32;
    _r0.i = ((global::java.util.Random) _r4_o).next((int) _r2.i);
    _r0.l = (long) _r0.i;
    _r0.l = _r0.l << (0x3f & _r2.i);
    _r2.i = ((global::java.util.Random) _r4_o).next((int) _r2.i);
    _r2.l = (long) _r2.i;
    _r0.l = _r0.l + _r2.l;
    return _r0.l;
//XMLVM_END_WRAPPER[java.util.Random: long nextLong()]
}

public virtual void setSeed(long n1){
//XMLVM_BEGIN_WRAPPER[java.util.Random: void setSeed(long)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r4_o = this;
    _r5.l = n1;
    global::System.Threading.Monitor.Enter(_r4_o);
    _r0.l = 25214903917L;
    _r0.l = _r0.l ^ _r5.l;
    _r2.l = 281474976710655L;
    _r0.l = _r0.l & _r2.l;
    try {
    ((global::java.util.Random) _r4_o)._fseed = _r0.l;
    _r0.i = 0;
    ((global::java.util.Random) _r4_o)._fhaveNextNextGaussian = 0!=_r0.i;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label20;
        }
        throw ex;
    } // end catch
    global::System.Threading.Monitor.Exit(_r4_o);
    return;
    label20:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    global::System.Threading.Monitor.Exit(_r4_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.Throwable) _r0_o);
//XMLVM_END_WRAPPER[java.util.Random: void setSeed(long)]
}

//XMLVM_BEGIN_WRAPPER[java.util.Random]
//XMLVM_END_WRAPPER[java.util.Random]

} // end of class: Random

} // end of namespace: java.util
