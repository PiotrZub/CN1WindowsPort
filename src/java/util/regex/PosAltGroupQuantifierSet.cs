// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util.regex {
public class PosAltGroupQuantifierSet: global::java.util.regex.AltGroupQuantifierSet {
new public void @this(global::java.util.regex.AbstractSet n1, global::java.util.regex.AbstractSet n2, int n3){
//XMLVM_BEGIN_WRAPPER[java.util.regex.PosAltGroupQuantifierSet: void <init>(java.util.regex.AbstractSet, java.util.regex.AbstractSet, int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r4.i = n3;
    ((global::java.util.regex.AltGroupQuantifierSet) _r1_o).@this((global::java.util.regex.AbstractSet) _r2_o, (global::java.util.regex.AbstractSet) _r3_o, (int) _r4.i);
    _r0_o = global::java.util.regex.FSet._fposFSet;
    ((global::java.util.regex.JointSet) _r2_o).setNext((global::java.util.regex.AbstractSet) _r0_o);
    return;
//XMLVM_END_WRAPPER[java.util.regex.PosAltGroupQuantifierSet: void <init>(java.util.regex.AbstractSet, java.util.regex.AbstractSet, int)]
}

public override int matches(int n1, global::java.lang.CharSequence n2, global::java.util.regex.MatchResultImpl n3){
//XMLVM_BEGIN_WRAPPER[java.util.regex.PosAltGroupQuantifierSet: int matches(int, java.lang.CharSequence, java.util.regex.MatchResultImpl)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    _r2_o = this;
    _r3.i = n1;
    _r4_o = n2;
    _r5_o = n3;
    _r0_o = ((global::java.util.regex.PosAltGroupQuantifierSet) _r2_o)._finnerSet;
    _r0.i = ((global::java.util.regex.AbstractSet) _r0_o).matches((int) _r3.i, (global::java.lang.CharSequence) _r4_o, (global::java.util.regex.MatchResultImpl) _r5_o);
    if (_r0.i <= 0) goto label15;
    label8:;
    _r1_o = ((global::java.util.regex.PosAltGroupQuantifierSet) _r2_o)._fnext;
    _r0.i = ((global::java.util.regex.AbstractSet) _r1_o).matches((int) _r0.i, (global::java.lang.CharSequence) _r4_o, (global::java.util.regex.MatchResultImpl) _r5_o);
    return _r0.i;
    label15:;
    _r0.i = _r3.i;
    goto label8;
//XMLVM_END_WRAPPER[java.util.regex.PosAltGroupQuantifierSet: int matches(int, java.lang.CharSequence, java.util.regex.MatchResultImpl)]
}

public override void setNext(global::java.util.regex.AbstractSet n1){
//XMLVM_BEGIN_WRAPPER[java.util.regex.PosAltGroupQuantifierSet: void setNext(java.util.regex.AbstractSet)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.util.regex.PosAltGroupQuantifierSet) _r0_o)._fnext = (global::java.util.regex.AbstractSet) _r1_o;
    return;
//XMLVM_END_WRAPPER[java.util.regex.PosAltGroupQuantifierSet: void setNext(java.util.regex.AbstractSet)]
}

//XMLVM_BEGIN_WRAPPER[java.util.regex.PosAltGroupQuantifierSet]
//XMLVM_END_WRAPPER[java.util.regex.PosAltGroupQuantifierSet]

} // end of class: PosAltGroupQuantifierSet

} // end of namespace: java.util.regex
