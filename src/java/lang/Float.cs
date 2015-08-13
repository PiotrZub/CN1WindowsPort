// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.lang {
public class Float: global::java.lang.Number,global::java.lang.Comparable {

static Float() {
    @static();
}


private float _fvalue;

public static float _fMAX_1VALUE = (float)3.4028235E38D;

public static float _fMIN_1VALUE = (float)1.4E-45D;

public static float _fMIN_1NORMAL = (float)1.17549435E-38D;

public static float _fNaN = global::System.Single.NaN;

public static float _fPOSITIVE_1INFINITY = global::System.Single.PositiveInfinity;

public static float _fNEGATIVE_1INFINITY = global::System.Single.NegativeInfinity;

public static global::java.lang.Class _fTYPE;

public static int _fMAX_1EXPONENT = 127;

public static int _fMIN_1EXPONENT = -126;

public static int _fSIZE = 32;

new public static void @static(){
//XMLVM_BEGIN_WRAPPER[java.lang.Float: void <clinit>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    _r0.i = 0;
    _r0_o = new global::org.xmlvm._nArrayAdapter<float>(new float[_r0.i]);
    _r0_o = ((global::java.lang.Object) _r0_o).getClass();
    _r0_o = ((global::java.lang.Class) _r0_o).getComponentType();
    global::java.lang.Float._fTYPE = (global::java.lang.Class) _r0_o;
    return;
//XMLVM_END_WRAPPER[java.lang.Float: void <clinit>()]
}

public void @this(float n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Float: void <init>(float)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.f = n1;
    ((global::java.lang.Number) _r0_o).@this();
    ((global::java.lang.Float) _r0_o)._fvalue = _r1.f;
    return;
//XMLVM_END_WRAPPER[java.lang.Float: void <init>(float)]
}

public void @this(double n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Float: void <init>(double)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r1_o = this;
    _r2.d = n1;
    ((global::java.lang.Number) _r1_o).@this();
    _r0.f = (float) _r2.d;
    ((global::java.lang.Float) _r1_o)._fvalue = _r0.f;
    return;
//XMLVM_END_WRAPPER[java.lang.Float: void <init>(double)]
}

public void @this(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Float: void <init>(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0.f = global::java.lang.Float.parseFloat((global::java.lang.String) _r2_o);
    ((global::java.lang.Float) _r1_o).@this((float) _r0.f);
    return;
//XMLVM_END_WRAPPER[java.lang.Float: void <init>(java.lang.String)]
}

public virtual int compareTo(global::java.lang.Float n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Float: int compareTo(java.lang.Float)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r0.f = ((global::java.lang.Float) _r2_o)._fvalue;
    _r1.f = ((global::java.lang.Float) _r3_o)._fvalue;
    _r0.i = global::java.lang.Float.compare((float) _r0.f, (float) _r1.f);
    return _r0.i;
//XMLVM_END_WRAPPER[java.lang.Float: int compareTo(java.lang.Float)]
}

public override sbyte byteValue(){
//XMLVM_BEGIN_WRAPPER[java.lang.Float: byte byteValue()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.f = ((global::java.lang.Float) _r1_o)._fvalue;
    _r0.i = (int) _r0.f;
    _r0.i = (_r0.i << 24) >> 24;
    return (sbyte) _r0.i;
//XMLVM_END_WRAPPER[java.lang.Float: byte byteValue()]
}

public override double doubleValue(){
//XMLVM_BEGIN_WRAPPER[java.lang.Float: double doubleValue()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0.f = ((global::java.lang.Float) _r2_o)._fvalue;
    _r0.d = (double) _r0.f;
    return _r0.d;
//XMLVM_END_WRAPPER[java.lang.Float: double doubleValue()]
}

public override bool equals(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Float: boolean equals(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    if (_r3_o == _r2_o) goto label24;
    _r0.i = ((_r3_o != null) && (_r3_o is global::java.lang.Float)) ? 1 : 0;
    if (_r0.i == 0) goto label22;
    _r0.f = ((global::java.lang.Float) _r2_o)._fvalue;
    _r0.i = global::java.lang.Float.floatToIntBits((float) _r0.f);
    _r1.f = ((global::java.lang.Float) _r3_o)._fvalue;
    _r1.i = global::java.lang.Float.floatToIntBits((float) _r1.f);
    if (_r0.i == _r1.i) goto label24;
    label22:;
    _r0.i = 0;
    label23:;
    return _r0.i!=0;
    label24:;
    _r0.i = 1;
    goto label23;
//XMLVM_END_WRAPPER[java.lang.Float: boolean equals(java.lang.Object)]
}

public static int floatToIntBits(float n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Float: int floatToIntBits(float)]
    if (global::System.Single.IsNaN(n1)) {
        return 0x7FC00000;
    }
    return global::System.BitConverter.ToInt32(global::System.BitConverter.GetBytes(n1),0);
//XMLVM_END_WRAPPER[java.lang.Float: int floatToIntBits(float)]
}

public static int floatToRawIntBits(float n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Float: int floatToRawIntBits(float)]
      return global::System.BitConverter.ToInt32(global::System.BitConverter.GetBytes(n1), 0);
//XMLVM_END_WRAPPER[java.lang.Float: int floatToRawIntBits(float)]
}

public override float floatValue(){
//XMLVM_BEGIN_WRAPPER[java.lang.Float: float floatValue()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.f = ((global::java.lang.Float) _r1_o)._fvalue;
    return _r0.f;
//XMLVM_END_WRAPPER[java.lang.Float: float floatValue()]
}

public override int hashCode(){
//XMLVM_BEGIN_WRAPPER[java.lang.Float: int hashCode()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.f = ((global::java.lang.Float) _r1_o)._fvalue;
    _r0.i = global::java.lang.Float.floatToIntBits((float) _r0.f);
    return _r0.i;
//XMLVM_END_WRAPPER[java.lang.Float: int hashCode()]
}

public static float intBitsToFloat(int n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Float: float intBitsToFloat(int)]
    return global::System.BitConverter.ToSingle(global::System.BitConverter.GetBytes(n1),0);
//XMLVM_END_WRAPPER[java.lang.Float: float intBitsToFloat(int)]
}

public override int intValue(){
//XMLVM_BEGIN_WRAPPER[java.lang.Float: int intValue()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.f = ((global::java.lang.Float) _r1_o)._fvalue;
    _r0.i = (int) _r0.f;
    return _r0.i;
//XMLVM_END_WRAPPER[java.lang.Float: int intValue()]
}

public virtual bool isInfinite(){
//XMLVM_BEGIN_WRAPPER[java.lang.Float: boolean isInfinite()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.f = ((global::java.lang.Float) _r1_o)._fvalue;
    _r0.i = global::java.lang.Float.isInfinite((float) _r0.f) ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.lang.Float: boolean isInfinite()]
}

public static bool isInfinite(float n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Float: boolean isInfinite(float)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    _r1.f = n1;
    _r0.f = global::System.Single.PositiveInfinity;
    _r0.i = _r1.f > _r0.f ? 1 : (_r1.f == _r0.f ? 0 : -1);
    if (_r0.i == 0) goto label14;
    _r0.f = global::System.Single.NegativeInfinity;
    _r0.i = _r1.f > _r0.f ? 1 : (_r1.f == _r0.f ? 0 : -1);
    if (_r0.i == 0) goto label14;
    _r0.i = 0;
    label13:;
    return _r0.i!=0;
    label14:;
    _r0.i = 1;
    goto label13;
//XMLVM_END_WRAPPER[java.lang.Float: boolean isInfinite(float)]
}

public virtual bool isNaN(){
//XMLVM_BEGIN_WRAPPER[java.lang.Float: boolean isNaN()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.f = ((global::java.lang.Float) _r1_o)._fvalue;
    _r0.i = global::java.lang.Float.isNaN((float) _r0.f) ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.lang.Float: boolean isNaN()]
}

public static bool isNaN(float n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Float: boolean isNaN(float)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    _r1.f = n1;
    _r0.i = _r1.f > _r1.f ? 1 : (_r1.f == _r1.f ? 0 : -1);
    if (_r0.i == 0) goto label6;
    _r0.i = 1;
    label5:;
    return _r0.i!=0;
    label6:;
    _r0.i = 0;
    goto label5;
//XMLVM_END_WRAPPER[java.lang.Float: boolean isNaN(float)]
}

public override long longValue(){
//XMLVM_BEGIN_WRAPPER[java.lang.Float: long longValue()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0.f = ((global::java.lang.Float) _r2_o)._fvalue;
    _r0.l = (long) _r0.f;
    return _r0.l;
//XMLVM_END_WRAPPER[java.lang.Float: long longValue()]
}

public static float parseFloat(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Float: float parseFloat(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = n1;
    _r0.f = global::org.apache.harmony.luni.util.FloatingPointParser.parseFloat((global::java.lang.String) _r1_o);
    return _r0.f;
//XMLVM_END_WRAPPER[java.lang.Float: float parseFloat(java.lang.String)]
}

public override short shortValue(){
//XMLVM_BEGIN_WRAPPER[java.lang.Float: short shortValue()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.f = ((global::java.lang.Float) _r1_o)._fvalue;
    _r0.i = (int) _r0.f;
    _r0.i = (_r0.i << 16) >> 16;
    return (short) _r0.i;
//XMLVM_END_WRAPPER[java.lang.Float: short shortValue()]
}

public override global::System.Object toString(){
//XMLVM_BEGIN_WRAPPER[java.lang.Float: java.lang.String toString()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.f = ((global::java.lang.Float) _r1_o)._fvalue;
    _r0_o = global::java.lang.Float.toString((float) _r0.f);
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[java.lang.Float: java.lang.String toString()]
}

public static global::System.Object toString(float n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Float: java.lang.String toString(float)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r1.f = n1;
    _r0_o = global::org.apache.harmony.luni.util.NumberConverter.convert((float) _r1.f);
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[java.lang.Float: java.lang.String toString(float)]
}

public static global::System.Object valueOf(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Float: java.lang.Float valueOf(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = n1;
    _r0.f = global::java.lang.Float.parseFloat((global::java.lang.String) _r1_o);
    _r0_o = global::java.lang.Float.valueOf((float) _r0.f);
    return (global::java.lang.Float) _r0_o;
//XMLVM_END_WRAPPER[java.lang.Float: java.lang.Float valueOf(java.lang.String)]
}

public static int compare(float n1, float n2){
//XMLVM_BEGIN_WRAPPER[java.lang.Float: int compare(float, float)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    _r4.f = n1;
    _r5.f = n2;
    _r3.i = 1;
    _r2.i = 0;
    _r1.i = -1;
    _r0.i = _r4.f > _r5.f ? 1 : (_r4.f == _r5.f ? 0 : -1);
    if (_r0.i <= 0) goto label9;
    _r0.i = _r3.i;
    label8:;
    return _r0.i;
    label9:;
    _r0.i = _r5.f > _r4.f ? 1 : (_r5.f == _r4.f ? 0 : -1);
    if (_r0.i <= 0) goto label15;
    _r0.i = _r1.i;
    goto label8;
    label15:;
    _r0.i = _r4.f > _r5.f ? 1 : (_r4.f == _r5.f ? 0 : -1);
    if (_r0.i != 0) goto label26;
    _r0.f = (float)0.0D;
    _r0.i = _r0.f > _r4.f ? 1 : (_r0.f == _r4.f ? 0 : -1);
    if (_r0.i == 0) goto label26;
    _r0.i = _r2.i;
    goto label8;
    label26:;
    _r0.i = global::java.lang.Float.isNaN((float) _r4.f) ? 1 : 0;
    if (_r0.i == 0) goto label42;
    _r0.i = global::java.lang.Float.isNaN((float) _r5.f) ? 1 : 0;
    if (_r0.i == 0) goto label40;
    _r0.i = _r2.i;
    goto label8;
    label40:;
    _r0.i = _r3.i;
    goto label8;
    label42:;
    _r0.i = global::java.lang.Float.isNaN((float) _r5.f) ? 1 : 0;
    if (_r0.i == 0) goto label50;
    _r0.i = _r1.i;
    goto label8;
    label50:;
    _r0.i = global::java.lang.Float.floatToRawIntBits((float) _r4.f);
    _r1.i = global::java.lang.Float.floatToRawIntBits((float) _r5.f);
    _r0.i = _r0.i >> (0x1f & 31);
    _r1.i = _r1.i >> (0x1f & 31);
    _r0.i = _r0.i - _r1.i;
    goto label8;
//XMLVM_END_WRAPPER[java.lang.Float: int compare(float, float)]
}

public static global::System.Object valueOf(float n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Float: java.lang.Float valueOf(float)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r1.f = n1;
    _r0_o = new global::java.lang.Float();
    ((global::java.lang.Float) _r0_o).@this((float) _r1.f);
    return (global::java.lang.Float) _r0_o;
//XMLVM_END_WRAPPER[java.lang.Float: java.lang.Float valueOf(float)]
}

public static global::System.Object toHexString(float n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Float: java.lang.String toHexString(float)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r7;
    _r7.f = n1;
    _r6.i = 48;
    _r5.i = 6;
    _r0.i = _r7.f > _r7.f ? 1 : (_r7.f == _r7.f ? 0 : -1);
    if (_r0.i == 0) goto label10;
    // Value=NaN
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)78)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 78))}));
    label9:;
    return (global::java.lang.String) _r0_o;
    label10:;
    _r0.f = global::System.Single.PositiveInfinity;
    _r0.i = _r7.f > _r0.f ? 1 : (_r7.f == _r0.f ? 0 : -1);
    if (_r0.i != 0) goto label19;
    // Value=Infinity
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)73)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 121))}));
    goto label9;
    label19:;
    _r0.f = global::System.Single.NegativeInfinity;
    _r0.i = _r7.f > _r0.f ? 1 : (_r7.f == _r0.f ? 0 : -1);
    if (_r0.i != 0) goto label28;
    // Value=-Infinity
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)45)), unchecked((char) unchecked((uint) 73)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 121))}));
    goto label9;
    label28:;
    _r0.i = global::java.lang.Float.floatToIntBits((float) _r7.f);
    _r1.i = -2147483648;
    _r1.i = _r1.i & _r0.i;
    if (_r1.i == 0) goto label58;
    _r1.i = 1;
    label38:;
    _r2.i = 2139095040;
    _r2.i = _r2.i & _r0.i;
    _r2.i = (int) (((uint) _r2.i) >> (0x1f & ((int) 23)));
    _r3.i = 8388607;
    _r0.i = _r0.i & _r3.i;
    _r0.i = _r0.i << (0x1f & 1);
    if (_r2.i != 0) goto label63;
    if (_r0.i != 0) goto label63;
    if (_r1.i == 0) goto label60;
    // Value=-0x0.0p0
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)45)), unchecked((char) unchecked((uint) 48)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 48)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 48)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 48))}));
    goto label9;
    label58:;
    _r1.i = 0;
    goto label38;
    label60:;
    // Value=0x0.0p0
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)48)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 48)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 48)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 48))}));
    goto label9;
    label63:;
    _r3_o = new global::java.lang.StringBuilder();
    _r4.i = 10;
    ((global::java.lang.StringBuilder) _r3_o).@this((int) _r4.i);
    if (_r1.i == 0) goto label126;
    // Value=-0x
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)45)), unchecked((char) unchecked((uint) 48)), unchecked((char) unchecked((uint) 120))}));
    ((global::java.lang.StringBuilder) _r3_o).append((global::java.lang.String) _r1_o);
    label77:;
    if (_r2.i != 0) goto label142;
    // Value=0.
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)48)), unchecked((char) unchecked((uint) 46))}));
    ((global::java.lang.StringBuilder) _r3_o).append((global::java.lang.String) _r1_o);
    _r1.i = _r0.i;
    _r0.i = _r5.i;
    label86:;
    if (_r1.i == 0) goto label92;
    _r2.i = _r1.i & 15;
    if (_r2.i == 0) goto label132;
    label92:;
    _r2_o = global::java.lang.Integer.toHexString((int) _r1.i);
    if (_r1.i == 0) goto label113;
    _r1.i = ((global::java.lang.String) _r2_o).length();
    if (_r0.i <= _r1.i) goto label113;
    _r1.i = ((global::java.lang.String) _r2_o).length();
    _r0.i = _r0.i - _r1.i;
    label109:;
    _r1.i = _r0.i + -1;
    if (_r0.i != 0) goto label137;
    label113:;
    ((global::java.lang.StringBuilder) _r3_o).append((global::java.lang.String) _r2_o);
    // Value=p-126
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)112)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 49)), unchecked((char) unchecked((uint) 50)), unchecked((char) unchecked((uint) 54))}));
    ((global::java.lang.StringBuilder) _r3_o).append((global::java.lang.String) _r0_o);
    label121:;
    _r0_o = ((global::java.lang.StringBuilder) _r3_o).toString();
    goto label9;
    label126:;
    // Value=0x
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)48)), unchecked((char) unchecked((uint) 120))}));
    ((global::java.lang.StringBuilder) _r3_o).append((global::java.lang.String) _r1_o);
    goto label77;
    label132:;
    _r1.i = (int) (((uint) _r1.i) >> (0x1f & ((int) 4)));
    _r0.i = _r0.i + -1;
    goto label86;
    label137:;
    ((global::java.lang.StringBuilder) _r3_o).append((char) _r6.i);
    _r0.i = _r1.i;
    goto label109;
    label142:;
    // Value=1.
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)49)), unchecked((char) unchecked((uint) 46))}));
    ((global::java.lang.StringBuilder) _r3_o).append((global::java.lang.String) _r1_o);
    _r1.i = _r0.i;
    _r0.i = _r5.i;
    label149:;
    if (_r1.i == 0) goto label155;
    _r4.i = _r1.i & 15;
    if (_r4.i == 0) goto label196;
    label155:;
    _r4_o = global::java.lang.Integer.toHexString((int) _r1.i);
    if (_r1.i == 0) goto label176;
    _r1.i = ((global::java.lang.String) _r4_o).length();
    if (_r0.i <= _r1.i) goto label176;
    _r1.i = ((global::java.lang.String) _r4_o).length();
    _r0.i = _r0.i - _r1.i;
    label172:;
    _r1.i = _r0.i + -1;
    if (_r0.i != 0) goto label201;
    label176:;
    ((global::java.lang.StringBuilder) _r3_o).append((global::java.lang.String) _r4_o);
    _r0.i = 112;
    ((global::java.lang.StringBuilder) _r3_o).append((char) _r0.i);
    _r0.i = 127;
    _r0.i = _r2.i - _r0.i;
    _r0_o = global::java.lang.Integer.toString((int) _r0.i);
    ((global::java.lang.StringBuilder) _r3_o).append((global::java.lang.String) _r0_o);
    goto label121;
    label196:;
    _r1.i = (int) (((uint) _r1.i) >> (0x1f & ((int) 4)));
    _r0.i = _r0.i + -1;
    goto label149;
    label201:;
    ((global::java.lang.StringBuilder) _r3_o).append((char) _r6.i);
    _r0.i = _r1.i;
    goto label172;
//XMLVM_END_WRAPPER[java.lang.Float: java.lang.String toHexString(float)]
}

public virtual int compareTo(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.lang.Float: int compareTo(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0.i = ((global::java.lang.Float) _r1_o).compareTo((global::java.lang.Float) _r2_o);
    return _r0.i;
//XMLVM_END_WRAPPER[java.lang.Float: int compareTo(java.lang.Object)]
}

//XMLVM_BEGIN_WRAPPER[java.lang.Float]
//XMLVM_END_WRAPPER[java.lang.Float]

} // end of class: Float

} // end of namespace: java.lang
