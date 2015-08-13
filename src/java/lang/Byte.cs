// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.lang {
public class Byte: global::java.lang.Number,global::java.lang.Comparable {

static Byte() {
    @static();
}


private sbyte _fvalue;

public static sbyte _fMAX_1VALUE = 127;

public static sbyte _fMIN_1VALUE = -128;

public static int _fSIZE = 8;

public static global::java.lang.Class _fTYPE;

private static global::org.xmlvm._nArrayAdapter<global::System.Object> _fCACHE;

new public static void @static(){
//XMLVM_BEGIN_WRAPPER[java.lang.Byte: void <clinit>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    _r0.i = 0;
    _r0_o = new global::org.xmlvm._nArrayAdapter<sbyte>(new sbyte[_r0.i]);
    _r0_o = ((global::java.lang.Object) _r0_o).getClass();
    _r0_o = ((global::java.lang.Class) _r0_o).getComponentType();
    global::java.lang.Byte._fTYPE = (global::java.lang.Class) _r0_o;
    _r0.i = 256;
    _r0_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r0.i]);
    global::java.lang.Byte._fCACHE = (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o;
    return;
//XMLVM_END_WRAPPER[java.lang.Byte: void <clinit>()]
}

public void @this(sbyte n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Byte: void <init>(byte)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.i = n1;
    ((global::java.lang.Number) _r0_o).@this();
    ((global::java.lang.Byte) _r0_o)._fvalue = (sbyte) _r1.i;
    return;
//XMLVM_END_WRAPPER[java.lang.Byte: void <init>(byte)]
}

public void @this(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Byte: void <init>(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0.i = global::java.lang.Byte.parseByte((global::java.lang.String) _r2_o);
    ((global::java.lang.Byte) _r1_o).@this((sbyte) _r0.i);
    return;
//XMLVM_END_WRAPPER[java.lang.Byte: void <init>(java.lang.String)]
}

public override sbyte byteValue(){
//XMLVM_BEGIN_WRAPPER[java.lang.Byte: byte byteValue()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::java.lang.Byte) _r1_o)._fvalue;
    return (sbyte) _r0.i;
//XMLVM_END_WRAPPER[java.lang.Byte: byte byteValue()]
}

public virtual int compareTo(global::java.lang.Byte n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Byte: int compareTo(java.lang.Byte)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r0.i = ((global::java.lang.Byte) _r2_o)._fvalue;
    _r1.i = ((global::java.lang.Byte) _r3_o)._fvalue;
    if (_r0.i <= _r1.i) goto label8;
    _r0.i = 1;
    label7:;
    return _r0.i;
    label8:;
    _r0.i = ((global::java.lang.Byte) _r2_o)._fvalue;
    _r1.i = ((global::java.lang.Byte) _r3_o)._fvalue;
    if (_r0.i >= _r1.i) goto label16;
    _r0.i = -1;
    goto label7;
    label16:;
    _r0.i = 0;
    goto label7;
//XMLVM_END_WRAPPER[java.lang.Byte: int compareTo(java.lang.Byte)]
}

public static global::System.Object decode(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Byte: java.lang.Byte decode(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    _r2_o = n1;
    _r0_o = global::java.lang.Integer.decode((global::java.lang.String) _r2_o);
    _r0.i = ((global::java.lang.Integer) _r0_o).intValue();
    _r1.i = (_r0.i << 24) >> 24;
    if (_r1.i != _r0.i) goto label16;
    _r0_o = global::java.lang.Byte.valueOf((sbyte) _r1.i);
    return (global::java.lang.Byte) _r0_o;
    label16:;
    _r0_o = new global::java.lang.NumberFormatException();
    ((global::java.lang.NumberFormatException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.NumberFormatException) _r0_o);
//XMLVM_END_WRAPPER[java.lang.Byte: java.lang.Byte decode(java.lang.String)]
}

public override double doubleValue(){
//XMLVM_BEGIN_WRAPPER[java.lang.Byte: double doubleValue()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0.i = ((global::java.lang.Byte) _r2_o)._fvalue;
    _r0.d = (double) _r0.i;
    return _r0.d;
//XMLVM_END_WRAPPER[java.lang.Byte: double doubleValue()]
}

public override bool equals(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Byte: boolean equals(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    if (_r3_o == _r2_o) goto label16;
    _r0.i = ((_r3_o != null) && (_r3_o is global::java.lang.Byte)) ? 1 : 0;
    if (_r0.i == 0) goto label14;
    _r0.i = ((global::java.lang.Byte) _r2_o)._fvalue;
    _r1.i = ((global::java.lang.Byte) _r3_o)._fvalue;
    if (_r0.i == _r1.i) goto label16;
    label14:;
    _r0.i = 0;
    label15:;
    return _r0.i!=0;
    label16:;
    _r0.i = 1;
    goto label15;
//XMLVM_END_WRAPPER[java.lang.Byte: boolean equals(java.lang.Object)]
}

public override float floatValue(){
//XMLVM_BEGIN_WRAPPER[java.lang.Byte: float floatValue()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::java.lang.Byte) _r1_o)._fvalue;
    _r0.f = (float) _r0.i;
    return _r0.f;
//XMLVM_END_WRAPPER[java.lang.Byte: float floatValue()]
}

public override int hashCode(){
//XMLVM_BEGIN_WRAPPER[java.lang.Byte: int hashCode()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::java.lang.Byte) _r1_o)._fvalue;
    return _r0.i;
//XMLVM_END_WRAPPER[java.lang.Byte: int hashCode()]
}

public override int intValue(){
//XMLVM_BEGIN_WRAPPER[java.lang.Byte: int intValue()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::java.lang.Byte) _r1_o)._fvalue;
    return _r0.i;
//XMLVM_END_WRAPPER[java.lang.Byte: int intValue()]
}

public override long longValue(){
//XMLVM_BEGIN_WRAPPER[java.lang.Byte: long longValue()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0.i = ((global::java.lang.Byte) _r2_o)._fvalue;
    _r0.l = (long) _r0.i;
    return _r0.l;
//XMLVM_END_WRAPPER[java.lang.Byte: long longValue()]
}

public static sbyte parseByte(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Byte: byte parseByte(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    _r2_o = n1;
    _r0.i = global::java.lang.Integer.parseInt((global::java.lang.String) _r2_o);
    _r1.i = (_r0.i << 24) >> 24;
    if (_r1.i != _r0.i) goto label8;
    return (sbyte) _r1.i;
    label8:;
    _r0_o = new global::java.lang.NumberFormatException();
    ((global::java.lang.NumberFormatException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.NumberFormatException) _r0_o);
//XMLVM_END_WRAPPER[java.lang.Byte: byte parseByte(java.lang.String)]
}

public static sbyte parseByte(global::java.lang.String n1, int n2){
//XMLVM_BEGIN_WRAPPER[java.lang.Byte: byte parseByte(java.lang.String, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    _r2_o = n1;
    _r3.i = n2;
    _r0.i = global::java.lang.Integer.parseInt((global::java.lang.String) _r2_o, (int) _r3.i);
    _r1.i = (_r0.i << 24) >> 24;
    if (_r1.i != _r0.i) goto label8;
    return (sbyte) _r1.i;
    label8:;
    _r0_o = new global::java.lang.NumberFormatException();
    ((global::java.lang.NumberFormatException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.NumberFormatException) _r0_o);
//XMLVM_END_WRAPPER[java.lang.Byte: byte parseByte(java.lang.String, int)]
}

public override short shortValue(){
//XMLVM_BEGIN_WRAPPER[java.lang.Byte: short shortValue()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::java.lang.Byte) _r1_o)._fvalue;
    return (short) _r0.i;
//XMLVM_END_WRAPPER[java.lang.Byte: short shortValue()]
}

public override global::System.Object toString(){
//XMLVM_BEGIN_WRAPPER[java.lang.Byte: java.lang.String toString()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::java.lang.Byte) _r1_o)._fvalue;
    _r0_o = global::java.lang.Integer.toString((int) _r0.i);
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[java.lang.Byte: java.lang.String toString()]
}

public static global::System.Object toString(sbyte n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Byte: java.lang.String toString(byte)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r1.i = n1;
    _r0_o = global::java.lang.Integer.toString((int) _r1.i);
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[java.lang.Byte: java.lang.String toString(byte)]
}

public static global::System.Object valueOf(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Byte: java.lang.Byte valueOf(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = n1;
    _r0.i = global::java.lang.Byte.parseByte((global::java.lang.String) _r1_o);
    _r0_o = global::java.lang.Byte.valueOf((sbyte) _r0.i);
    return (global::java.lang.Byte) _r0_o;
//XMLVM_END_WRAPPER[java.lang.Byte: java.lang.Byte valueOf(java.lang.String)]
}

public static global::System.Object valueOf(global::java.lang.String n1, int n2){
//XMLVM_BEGIN_WRAPPER[java.lang.Byte: java.lang.Byte valueOf(java.lang.String, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r1_o = n1;
    _r2.i = n2;
    _r0.i = global::java.lang.Byte.parseByte((global::java.lang.String) _r1_o, (int) _r2.i);
    _r0_o = global::java.lang.Byte.valueOf((sbyte) _r0.i);
    return (global::java.lang.Byte) _r0_o;
//XMLVM_END_WRAPPER[java.lang.Byte: java.lang.Byte valueOf(java.lang.String, int)]
}

public static global::System.Object valueOf(sbyte n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Byte: java.lang.Byte valueOf(byte)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r4.i = n1;
    _r0_o = global::java.lang.Byte._fCACHE;
    global::System.Threading.Monitor.Enter(_r0_o);
    _r1.i = -128;
    _r1.i = _r4.i - _r1.i;
    try {
    _r2_o = global::java.lang.Byte._fCACHE;
    _r2_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o)[_r1.i];
    if (_r2_o != null) goto label25;
    _r2_o = global::java.lang.Byte._fCACHE;
    _r3_o = new global::java.lang.Byte();
    ((global::java.lang.Byte) _r3_o).@this((sbyte) _r4.i);
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o)[_r1.i] = _r3_o;
    _r1_o = _r3_o;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label27;
        }
        throw ex;
    } // end catch
    label23:;
    try {
    global::System.Threading.Monitor.Exit(_r0_o);
    return (global::java.lang.Byte) _r1_o;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label27;
        }
        throw ex;
    } // end catch
    label25:;
    try {
    _r1_o = _r2_o;
    goto label23;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label27;
        }
        throw ex;
    } // end catch
    label27:;
    try {
    _r1_o = _ex.getJavaException();
    _ex = null;
    global::System.Threading.Monitor.Exit(_r0_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label27;
        }
        throw ex;
    } // end catch
    throw new global::org.xmlvm._nExceptionAdapter((global::System.Object) _r1_o);
//XMLVM_END_WRAPPER[java.lang.Byte: java.lang.Byte valueOf(byte)]
}

public virtual int compareTo(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Byte: int compareTo(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0.i = ((global::java.lang.Byte) _r1_o).compareTo((global::java.lang.Byte) _r2_o);
    return _r0.i;
//XMLVM_END_WRAPPER[java.lang.Byte: int compareTo(java.lang.Object)]
}

//XMLVM_BEGIN_WRAPPER[java.lang.Byte]
//XMLVM_END_WRAPPER[java.lang.Byte]

} // end of class: Byte

} // end of namespace: java.lang
