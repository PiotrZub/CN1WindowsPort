// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.spinner {
public class Spinner_21: global::com.codename1.ui.spinner.SpinnerRenderer {
new public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.spinner.Spinner$1: void <init>()]
    global::System.Object _r0_o = null;
    _r0_o = this;
    ((global::com.codename1.ui.spinner.SpinnerRenderer) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.spinner.Spinner$1: void <init>()]
}

public override global::System.Object getListCellRendererComponent(global::com.codename1.ui.List n1, global::java.lang.Object n2, int n3, bool n4){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.spinner.Spinner$1: com.codename1.ui.Component getListCellRendererComponent(com.codename1.ui.List, java.lang.Object, int, boolean)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    global::System.Object _r8_o = null;
    global::System.Object _r9_o = null;
    global::System.Object _r10_o = null;
    global::System.Object _r11_o = null;
    global::org.xmlvm._nElement _r12;
    global::org.xmlvm._nElement _r13;
    _r9_o = this;
    _r10_o = n1;
    _r11_o = n2;
    _r12.i = n3;
    _r13.i = n4 ? 1 : 0;
    // Value=
    _r8_o = new global::java.lang.String();
    ((global::java.lang.String)_r8_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    if (_r11_o == null) goto label47;
    _r6.i = ((_r11_o != null) && (_r11_o is global::java.lang.Double)) ? 1 : 0;
    if (_r6.i == 0) goto label47;
    _r0.d = ((global::java.lang.Double) _r11_o).doubleValue();
    _r2.l = (long) _r0.d;
    _r6.d = 100.0D;
    _r6.d = _r6.d * _r0.d;
    _r4.l = (long) _r6.d;
    _r6.l = 100L;
    _r4.l = _r4.l % _r6.l;
    _r6.l = 0L;
    _r6.i = _r4.l > _r6.l ? 1 : (_r4.l == _r6.l ? 0 : -1);
    if (_r6.i != 0) goto label52;
    _r6_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r6_o).@this();
    // Value=
    _r7_o = new global::java.lang.String();
    ((global::java.lang.String)_r7_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    _r6_o = ((global::java.lang.StringBuilder) _r6_o).append((global::java.lang.String) _r8_o);
    _r6_o = ((global::java.lang.StringBuilder) _r6_o).append((long) _r2.l);
    _r11_o = ((global::java.lang.StringBuilder) _r6_o).toString();
    label47:;
    _r6_o = base.getListCellRendererComponent((global::com.codename1.ui.List) _r10_o, (global::java.lang.Object) _r11_o, (int) _r12.i, 0!=_r13.i);
    return (global::com.codename1.ui.Component) _r6_o;
    label52:;
    _r6_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r6_o).@this();
    // Value=
    _r7_o = new global::java.lang.String();
    ((global::java.lang.String)_r7_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    _r6_o = ((global::java.lang.StringBuilder) _r6_o).append((global::java.lang.String) _r8_o);
    _r6_o = ((global::java.lang.StringBuilder) _r6_o).append((long) _r2.l);
    // Value=.
    _r7_o = new global::java.lang.String();
    ((global::java.lang.String)_r7_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)46))}));
    _r6_o = ((global::java.lang.StringBuilder) _r6_o).append((global::java.lang.String) _r7_o);
    _r6_o = ((global::java.lang.StringBuilder) _r6_o).append((long) _r4.l);
    _r11_o = ((global::java.lang.StringBuilder) _r6_o).toString();
    goto label47;
//XMLVM_END_WRAPPER[com.codename1.ui.spinner.Spinner$1: com.codename1.ui.Component getListCellRendererComponent(com.codename1.ui.List, java.lang.Object, int, boolean)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.spinner.Spinner$1]
//XMLVM_END_WRAPPER[com.codename1.ui.spinner.Spinner$1]

} // end of class: Spinner_21

} // end of namespace: com.codename1.ui.spinner
