// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.text {
public class DateFormat: global::java.text.Format {
public static int _fFULL = 0;

public static int _fLONG = 1;

public static int _fMEDIUM = 2;

public static int _fSHORT = 3;

public static int _fDEFAULT = 2;

private int _fdateStyle;

private int _ftimeStyle;

new public void @this(){
//XMLVM_BEGIN_WRAPPER[java.text.DateFormat: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = 3;
    ((global::java.text.DateFormat) _r1_o).@this((int) _r0.i, (int) _r0.i);
    return;
//XMLVM_END_WRAPPER[java.text.DateFormat: void <init>()]
}

public void @this(int n1, int n2){
//XMLVM_BEGIN_WRAPPER[java.text.DateFormat: void <init>(int, int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    _r0_o = this;
    _r1.i = n1;
    _r2.i = n2;
    ((global::java.text.Format) _r0_o).@this();
    ((global::java.text.DateFormat) _r0_o)._fdateStyle = _r1.i;
    ((global::java.text.DateFormat) _r0_o)._ftimeStyle = _r2.i;
    return;
//XMLVM_END_WRAPPER[java.text.DateFormat: void <init>(int, int)]
}

public override global::System.Object format(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.text.DateFormat: java.lang.String format(java.lang.Object)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = new global::java.lang.StringBuffer();
    ((global::java.lang.StringBuffer) _r0_o).@this();
    _r0_o = ((global::java.text.DateFormat) _r1_o).format((global::java.lang.Object) _r2_o, (global::java.lang.StringBuffer) _r0_o);
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[java.text.DateFormat: java.lang.String format(java.lang.Object)]
}

public virtual global::System.Object format(global::java.lang.Object n1, global::java.lang.StringBuffer n2){
//XMLVM_BEGIN_WRAPPER[java.text.DateFormat: java.lang.String format(java.lang.Object, java.lang.StringBuffer)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r6_o = this;
    _r7_o = n1;
    _r8_o = n2;
    _r4.i = ((_r7_o != null) && (_r7_o is global::java.lang.Long)) ? 1 : 0;
    if (_r4.i == 0) goto label16;
    _r1_o = new global::java.util.Date();
    _r4.l = ((global::java.lang.Long) _r7_o).longValue();
    ((global::java.util.Date) _r1_o).@this((long) _r4.l);
    _r7_o = _r1_o;
    label16:;
    _r3_o = null;
    _r4.i = ((_r7_o != null) && (_r7_o is global::java.util.Date)) ? 1 : 0;
    if (_r4.i == 0) goto label37;
    _r0_o = _r7_o;
    _r3_o = _r0_o;
    label25:;
    if (_r3_o != null) goto label67;
    _r4_o = new global::java.lang.IllegalArgumentException();
    if (_r7_o != null) goto label62;
    // Value=null
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)110)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 108))}));
    label33:;
    ((global::java.lang.IllegalArgumentException) _r4_o).@this((global::java.lang.String) _r5_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r4_o);
    label37:;
    _r4.i = ((_r7_o != null) && (_r7_o is global::java.lang.String)) ? 1 : 0;
    if (_r4.i == 0) goto label25;
    try {
    _r0_o = _r7_o;
    _r4_o = _r0_o;
    _r3_o = ((global::java.text.DateFormat) _r6_o).parse((global::java.lang.String) _r4_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.text.ParseException) {
            _ex = ex;
            goto label50;
        }
        throw ex;
    } // end catch
    goto label25;
    label50:;
    _r4_o = _ex.getJavaException();
    _ex = null;
    _r2_o = _r4_o;
    _r4_o = new global::java.lang.RuntimeException();
    _r5_o = ((global::java.text.ParseException) _r2_o).toString();
    ((global::java.lang.RuntimeException) _r4_o).@this((global::java.lang.String) _r5_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.RuntimeException) _r4_o);
    label62:;
    _r5_o = ((global::java.lang.Object) _r7_o).toString();
    goto label33;
    label67:;
    _r4_o = ((global::java.text.DateFormat) _r6_o).format((global::java.util.Date) _r3_o, (global::java.lang.StringBuffer) _r8_o);
    return (global::java.lang.String) _r4_o;
//XMLVM_END_WRAPPER[java.text.DateFormat: java.lang.String format(java.lang.Object, java.lang.StringBuffer)]
}

public virtual global::System.Object format(global::java.util.Date n1){
//XMLVM_BEGIN_WRAPPER[java.text.DateFormat: java.lang.String format(java.util.Date)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = new global::java.lang.StringBuffer();
    ((global::java.lang.StringBuffer) _r0_o).@this();
    _r0_o = ((global::java.text.DateFormat) _r1_o).format((global::java.util.Date) _r2_o, (global::java.lang.StringBuffer) _r0_o);
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[java.text.DateFormat: java.lang.String format(java.util.Date)]
}

public virtual global::System.Object format(global::java.util.Date n1, global::java.lang.StringBuffer n2){
//XMLVM_BEGIN_WRAPPER[java.text.DateFormat: java.lang.String format(java.util.Date, java.lang.StringBuffer)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r0_o = ((global::java.util.Date) _r2_o).toString();
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[java.text.DateFormat: java.lang.String format(java.util.Date, java.lang.StringBuffer)]
}

public override global::System.Object parseObject(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[java.text.DateFormat: java.lang.Object parseObject(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r3_o = this;
    _r4_o = n1;
    _r0_o = new global::java.text.ParseException();
    // Value=Not implemented
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)78)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100))}));
    _r2.i = 0;
    ((global::java.text.ParseException) _r0_o).@this((global::java.lang.String) _r1_o, (int) _r2.i);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.text.ParseException) _r0_o);
//XMLVM_END_WRAPPER[java.text.DateFormat: java.lang.Object parseObject(java.lang.String)]
}

public virtual global::System.Object parse(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[java.text.DateFormat: java.util.Date parse(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    _r0_o = ((global::java.text.DateFormat) _r0_o).parseObject((global::java.lang.String) _r1_o);
    return (global::java.util.Date) _r0_o;
//XMLVM_END_WRAPPER[java.text.DateFormat: java.util.Date parse(java.lang.String)]
}

public static global::System.Object getInstance(){
//XMLVM_BEGIN_WRAPPER[java.text.DateFormat: java.text.DateFormat getInstance()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    _r0.i = 3;
    _r0_o = global::java.text.DateFormat.getDateTimeInstance((int) _r0.i, (int) _r0.i);
    return (global::java.text.DateFormat) _r0_o;
//XMLVM_END_WRAPPER[java.text.DateFormat: java.text.DateFormat getInstance()]
}

public static global::System.Object getDateInstance(){
//XMLVM_BEGIN_WRAPPER[java.text.DateFormat: java.text.DateFormat getDateInstance()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    _r0.i = 3;
    _r0_o = global::java.text.DateFormat.getDateInstance((int) _r0.i);
    return (global::java.text.DateFormat) _r0_o;
//XMLVM_END_WRAPPER[java.text.DateFormat: java.text.DateFormat getDateInstance()]
}

public static global::System.Object getTimeInstance(){
//XMLVM_BEGIN_WRAPPER[java.text.DateFormat: java.text.DateFormat getTimeInstance()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    _r0.i = 3;
    _r0_o = global::java.text.DateFormat.getTimeInstance((int) _r0.i);
    return (global::java.text.DateFormat) _r0_o;
//XMLVM_END_WRAPPER[java.text.DateFormat: java.text.DateFormat getTimeInstance()]
}

public static global::System.Object getDateInstance(int n1){
//XMLVM_BEGIN_WRAPPER[java.text.DateFormat: java.text.DateFormat getDateInstance(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r1.i = n1;
    _r0.i = 2;
    _r0_o = global::java.text.DateFormat.getDateTimeInstance((int) _r1.i, (int) _r0.i);
    return (global::java.text.DateFormat) _r0_o;
//XMLVM_END_WRAPPER[java.text.DateFormat: java.text.DateFormat getDateInstance(int)]
}

public static global::System.Object getTimeInstance(int n1){
//XMLVM_BEGIN_WRAPPER[java.text.DateFormat: java.text.DateFormat getTimeInstance(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r1.i = n1;
    _r0.i = 2;
    _r0_o = global::java.text.DateFormat.getDateTimeInstance((int) _r0.i, (int) _r1.i);
    return (global::java.text.DateFormat) _r0_o;
//XMLVM_END_WRAPPER[java.text.DateFormat: java.text.DateFormat getTimeInstance(int)]
}

public static global::System.Object getDateTimeInstance(int n1, int n2){
//XMLVM_BEGIN_WRAPPER[java.text.DateFormat: java.text.DateFormat getDateTimeInstance(int, int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    _r1.i = n1;
    _r2.i = n2;
    _r0_o = new global::java.text.DateFormat();
    ((global::java.text.DateFormat) _r0_o).@this((int) _r1.i, (int) _r2.i);
    return (global::java.text.DateFormat) _r0_o;
//XMLVM_END_WRAPPER[java.text.DateFormat: java.text.DateFormat getDateTimeInstance(int, int)]
}

public override int hashCode(){
//XMLVM_BEGIN_WRAPPER[java.text.DateFormat: int hashCode()]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    _r4_o = this;
    _r0.i = 31;
    _r1.i = 1;
    _r2.i = _r1.i * 31;
    _r2.i = ((global::java.text.DateFormat) _r4_o)._fdateStyle;
    _r1.i = _r2.i + 31;
    _r2.i = _r1.i * 31;
    _r3.i = ((global::java.text.DateFormat) _r4_o)._ftimeStyle;
    _r1.i = _r2.i + _r3.i;
    return _r1.i;
//XMLVM_END_WRAPPER[java.text.DateFormat: int hashCode()]
}

public override bool equals(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.text.DateFormat: boolean equals(java.lang.Object)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    _r6_o = this;
    _r7_o = n1;
    _r5.i = 1;
    _r4.i = 0;
    if (_r6_o != _r7_o) goto label6;
    _r2.i = _r5.i;
    label5:;
    return _r2.i!=0;
    label6:;
    if (_r7_o != null) goto label10;
    _r2.i = _r4.i;
    goto label5;
    label10:;
    _r2_o = ((global::java.lang.Object) _r6_o).getClass();
    _r3_o = ((global::java.lang.Object) _r7_o).getClass();
    if (_r2_o == _r3_o) goto label22;
    _r2.i = _r4.i;
    goto label5;
    label22:;
    _r0_o = _r7_o;
    _r1_o = _r0_o;
    _r2.i = ((global::java.text.DateFormat) _r6_o)._fdateStyle;
    _r3.i = ((global::java.text.DateFormat) _r1_o)._fdateStyle;
    if (_r2.i == _r3.i) goto label34;
    _r2.i = _r4.i;
    goto label5;
    label34:;
    _r2.i = ((global::java.text.DateFormat) _r6_o)._ftimeStyle;
    _r3.i = ((global::java.text.DateFormat) _r1_o)._ftimeStyle;
    if (_r2.i == _r3.i) goto label42;
    _r2.i = _r4.i;
    goto label5;
    label42:;
    _r2.i = _r5.i;
    goto label5;
//XMLVM_END_WRAPPER[java.text.DateFormat: boolean equals(java.lang.Object)]
}

public override global::System.Object clone(){
//XMLVM_BEGIN_WRAPPER[java.text.DateFormat: java.lang.Object clone()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    _r3_o = this;
    _r0_o = new global::java.text.DateFormat();
    _r1.i = ((global::java.text.DateFormat) _r3_o)._fdateStyle;
    _r2.i = ((global::java.text.DateFormat) _r3_o)._ftimeStyle;
    ((global::java.text.DateFormat) _r0_o).@this((int) _r1.i, (int) _r2.i);
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[java.text.DateFormat: java.lang.Object clone()]
}

//XMLVM_BEGIN_WRAPPER[java.text.DateFormat]
//XMLVM_END_WRAPPER[java.text.DateFormat]

} // end of class: DateFormat

} // end of namespace: java.text
