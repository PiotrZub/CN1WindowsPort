// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public class HashMap_2Entry: global::java.util.MapEntry {
public int _forigKeyHash;

public global::java.util.HashMap_2Entry _fnext;

public void @this(global::java.lang.Object n1, int n2){
//XMLVM_BEGIN_WRAPPER[java.util.HashMap$Entry: void <init>(java.lang.Object, int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    _r1_o = this;
    _r2_o = n1;
    _r3.i = n2;
    _r0_o = null;
    ((global::java.util.MapEntry) _r1_o).@this((global::java.lang.Object) _r2_o, (global::java.lang.Object) _r0_o);
    ((global::java.util.HashMap_2Entry) _r1_o)._forigKeyHash = _r3.i;
    return;
//XMLVM_END_WRAPPER[java.util.HashMap$Entry: void <init>(java.lang.Object, int)]
}

new public void @this(global::java.lang.Object n1, global::java.lang.Object n2){
//XMLVM_BEGIN_WRAPPER[java.util.HashMap$Entry: void <init>(java.lang.Object, java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    ((global::java.util.MapEntry) _r1_o).@this((global::java.lang.Object) _r2_o, (global::java.lang.Object) _r3_o);
    if (_r2_o != null) goto label9;
    _r0.i = 0;
    label6:;
    ((global::java.util.HashMap_2Entry) _r1_o)._forigKeyHash = _r0.i;
    return;
    label9:;
    _r0.i = global::java.util.HashMap.computeHashCode((global::java.lang.Object) _r2_o);
    goto label6;
//XMLVM_END_WRAPPER[java.util.HashMap$Entry: void <init>(java.lang.Object, java.lang.Object)]
}

public override global::System.Object clone(){
//XMLVM_BEGIN_WRAPPER[java.util.HashMap$Entry: java.lang.Object clone()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = base.clone();
    _r1_o = ((global::java.util.HashMap_2Entry) _r2_o)._fnext;
    if (_r1_o == null) goto label20;
    _r1_o = ((global::java.util.HashMap_2Entry) _r2_o)._fnext;
    _r2_o = ((global::java.util.HashMap_2Entry) _r1_o).clone();
    ((global::java.util.HashMap_2Entry) _r0_o)._fnext = (global::java.util.HashMap_2Entry) _r2_o;
    label20:;
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[java.util.HashMap$Entry: java.lang.Object clone()]
}

//XMLVM_BEGIN_WRAPPER[java.util.HashMap$Entry]
//XMLVM_END_WRAPPER[java.util.HashMap$Entry]

} // end of class: HashMap_2Entry

} // end of namespace: java.util
