// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.charts.views {
public class PointStyle: global::java.lang.Enum {

static PointStyle() {
    @static();
}

public static global::com.codename1.charts.views.PointStyle _fX;

public static global::com.codename1.charts.views.PointStyle _fCIRCLE;

public static global::com.codename1.charts.views.PointStyle _fTRIANGLE;

public static global::com.codename1.charts.views.PointStyle _fSQUARE;

public static global::com.codename1.charts.views.PointStyle _fDIAMOND;

public static global::com.codename1.charts.views.PointStyle _fPOINT;

private global::java.lang.String _fmName;

private static global::org.xmlvm._nArrayAdapter<global::System.Object> _f_2VALUES;

public static global::System.Object values(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.PointStyle: com.codename1.charts.views.PointStyle[] values()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r3.i = 0;
    _r0_o = global::com.codename1.charts.views.PointStyle._f_2VALUES;
    _r0.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    _r0_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r0.i]);
    _r1_o = global::com.codename1.charts.views.PointStyle._f_2VALUES;
    _r2_o = global::com.codename1.charts.views.PointStyle._f_2VALUES;
    _r2.i = ((global::org.xmlvm._nIArray) _r2_o).Length;
    global::java.lang.System.arraycopy((global::java.lang.Object) _r1_o, (int) _r3.i, (global::java.lang.Object) _r0_o, (int) _r3.i, (int) _r2.i);
    return (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.charts.views.PointStyle: com.codename1.charts.views.PointStyle[] values()]
}

public static global::System.Object valueOf(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.PointStyle: com.codename1.charts.views.PointStyle valueOf(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = n1;
    _r0_o = global::org.xmlvm._nTIB.getClass(typeof(global::com.codename1.charts.views.PointStyle));
    _r1_o = global::java.lang.Enum.valueOf((global::java.lang.Class) _r0_o, (global::java.lang.String) _r1_o);
    _r1_o = _r1_o;
    return (global::com.codename1.charts.views.PointStyle) _r1_o;
//XMLVM_END_WRAPPER[com.codename1.charts.views.PointStyle: com.codename1.charts.views.PointStyle valueOf(java.lang.String)]
}

private void @this(global::java.lang.String n1, int n2, global::java.lang.String n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.PointStyle: void <init>(java.lang.String, int, java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    _r2.i = n2;
    _r3_o = n3;
    ((global::java.lang.Enum) _r0_o).@this((global::java.lang.String) _r1_o, (int) _r2.i);
    ((global::com.codename1.charts.views.PointStyle) _r0_o)._fmName = (global::java.lang.String) _r3_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.views.PointStyle: void <init>(java.lang.String, int, java.lang.String)]
}

public virtual global::System.Object getName(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.PointStyle: java.lang.String getName()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.charts.views.PointStyle) _r1_o)._fmName;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.charts.views.PointStyle: java.lang.String getName()]
}

public override global::System.Object toString(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.PointStyle: java.lang.String toString()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.charts.views.PointStyle) _r1_o).getName();
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.charts.views.PointStyle: java.lang.String toString()]
}

public static global::System.Object getPointStyleForName(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.PointStyle: com.codename1.charts.views.PointStyle getPointStyleForName(java.lang.String)]
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
    global::System.Object _r5_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r5_o = n1;
    _r2_o = null;
    _r3_o = global::com.codename1.charts.views.PointStyle.values();
    _r1.i = ((global::org.xmlvm._nIArray) _r3_o).Length;
    _r0.i = 0;
    label7:;
    if (_r0.i >= _r1.i) goto label26;
    if (_r2_o != null) goto label26;
    _r4_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r3_o)[_r0.i];
    _r4_o = ((global::com.codename1.charts.views.PointStyle) _r4_o)._fmName;
    _r4.i = ((global::java.lang.String) _r4_o).equals((global::java.lang.Object) _r5_o) ? 1 : 0;
    if (_r4.i == 0) goto label23;
    _r2_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r3_o)[_r0.i];
    label23:;
    _r0.i = _r0.i + 1;
    goto label7;
    label26:;
    return (global::com.codename1.charts.views.PointStyle) _r2_o;
//XMLVM_END_WRAPPER[com.codename1.charts.views.PointStyle: com.codename1.charts.views.PointStyle getPointStyleForName(java.lang.String)]
}

public static int getIndexForName(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.PointStyle: int getIndexForName(java.lang.String)]
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
    global::System.Object _r5_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r5_o = n1;
    _r1.i = -1;
    _r3_o = global::com.codename1.charts.views.PointStyle.values();
    _r2.i = ((global::org.xmlvm._nIArray) _r3_o).Length;
    _r0.i = 0;
    label7:;
    if (_r0.i >= _r2.i) goto label25;
    if (_r1.i >= 0) goto label25;
    _r4_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r3_o)[_r0.i];
    _r4_o = ((global::com.codename1.charts.views.PointStyle) _r4_o)._fmName;
    _r4.i = ((global::java.lang.String) _r4_o).equals((global::java.lang.Object) _r5_o) ? 1 : 0;
    if (_r4.i == 0) goto label22;
    _r1.i = _r0.i;
    label22:;
    _r0.i = _r0.i + 1;
    goto label7;
    label25:;
    _r4.i = 0;
    _r4.i = global::java.lang.Math.max((int) _r4.i, (int) _r1.i);
    return _r4.i;
//XMLVM_END_WRAPPER[com.codename1.charts.views.PointStyle: int getIndexForName(java.lang.String)]
}

public static void @static(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.PointStyle: void <clinit>()]
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
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nElement _r8;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r8.i = 4;
    _r7.i = 3;
    _r6.i = 2;
    _r5.i = 1;
    _r4.i = 0;
    _r0_o = new global::com.codename1.charts.views.PointStyle();
    // Value=X
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)88))}));
    // Value=x
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)120))}));
    ((global::com.codename1.charts.views.PointStyle) _r0_o).@this((global::java.lang.String) _r1_o, (int) _r4.i, (global::java.lang.String) _r2_o);
    global::com.codename1.charts.views.PointStyle._fX = (global::com.codename1.charts.views.PointStyle) _r0_o;
    _r0_o = new global::com.codename1.charts.views.PointStyle();
    // Value=CIRCLE
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)67)), unchecked((char) unchecked((uint) 73)), unchecked((char) unchecked((uint) 82)), unchecked((char) unchecked((uint) 67)), unchecked((char) unchecked((uint) 76)), unchecked((char) unchecked((uint) 69))}));
    // Value=circle
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)99)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101))}));
    ((global::com.codename1.charts.views.PointStyle) _r0_o).@this((global::java.lang.String) _r1_o, (int) _r5.i, (global::java.lang.String) _r2_o);
    global::com.codename1.charts.views.PointStyle._fCIRCLE = (global::com.codename1.charts.views.PointStyle) _r0_o;
    _r0_o = new global::com.codename1.charts.views.PointStyle();
    // Value=TRIANGLE
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)84)), unchecked((char) unchecked((uint) 82)), unchecked((char) unchecked((uint) 73)), unchecked((char) unchecked((uint) 65)), unchecked((char) unchecked((uint) 78)), unchecked((char) unchecked((uint) 71)), unchecked((char) unchecked((uint) 76)), unchecked((char) unchecked((uint) 69))}));
    // Value=triangle
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)116)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101))}));
    ((global::com.codename1.charts.views.PointStyle) _r0_o).@this((global::java.lang.String) _r1_o, (int) _r6.i, (global::java.lang.String) _r2_o);
    global::com.codename1.charts.views.PointStyle._fTRIANGLE = (global::com.codename1.charts.views.PointStyle) _r0_o;
    _r0_o = new global::com.codename1.charts.views.PointStyle();
    // Value=SQUARE
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)83)), unchecked((char) unchecked((uint) 81)), unchecked((char) unchecked((uint) 85)), unchecked((char) unchecked((uint) 65)), unchecked((char) unchecked((uint) 82)), unchecked((char) unchecked((uint) 69))}));
    // Value=square
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)115)), unchecked((char) unchecked((uint) 113)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 101))}));
    ((global::com.codename1.charts.views.PointStyle) _r0_o).@this((global::java.lang.String) _r1_o, (int) _r7.i, (global::java.lang.String) _r2_o);
    global::com.codename1.charts.views.PointStyle._fSQUARE = (global::com.codename1.charts.views.PointStyle) _r0_o;
    _r0_o = new global::com.codename1.charts.views.PointStyle();
    // Value=DIAMOND
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)68)), unchecked((char) unchecked((uint) 73)), unchecked((char) unchecked((uint) 65)), unchecked((char) unchecked((uint) 77)), unchecked((char) unchecked((uint) 79)), unchecked((char) unchecked((uint) 78)), unchecked((char) unchecked((uint) 68))}));
    // Value=diamond
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)100)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 100))}));
    ((global::com.codename1.charts.views.PointStyle) _r0_o).@this((global::java.lang.String) _r1_o, (int) _r8.i, (global::java.lang.String) _r2_o);
    global::com.codename1.charts.views.PointStyle._fDIAMOND = (global::com.codename1.charts.views.PointStyle) _r0_o;
    _r0_o = new global::com.codename1.charts.views.PointStyle();
    // Value=POINT
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)80)), unchecked((char) unchecked((uint) 79)), unchecked((char) unchecked((uint) 73)), unchecked((char) unchecked((uint) 78)), unchecked((char) unchecked((uint) 84))}));
    _r2.i = 5;
    // Value=point
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)112)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116))}));
    ((global::com.codename1.charts.views.PointStyle) _r0_o).@this((global::java.lang.String) _r1_o, (int) _r2.i, (global::java.lang.String) _r3_o);
    global::com.codename1.charts.views.PointStyle._fPOINT = (global::com.codename1.charts.views.PointStyle) _r0_o;
    _r0.i = 6;
    _r0_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r0.i]);
    _r1_o = global::com.codename1.charts.views.PointStyle._fX;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r4.i] = _r1_o;
    _r1_o = global::com.codename1.charts.views.PointStyle._fCIRCLE;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r5.i] = _r1_o;
    _r1_o = global::com.codename1.charts.views.PointStyle._fTRIANGLE;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r6.i] = _r1_o;
    _r1_o = global::com.codename1.charts.views.PointStyle._fSQUARE;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r7.i] = _r1_o;
    _r1_o = global::com.codename1.charts.views.PointStyle._fDIAMOND;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r8.i] = _r1_o;
    _r1.i = 5;
    _r2_o = global::com.codename1.charts.views.PointStyle._fPOINT;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r2_o;
    global::com.codename1.charts.views.PointStyle._f_2VALUES = (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.views.PointStyle: void <clinit>()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.PointStyle]
//XMLVM_END_WRAPPER[com.codename1.charts.views.PointStyle]

} // end of class: PointStyle

} // end of namespace: com.codename1.charts.views
