// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util.regex {
public class AltGroupQuantifierSet: global::java.util.regex.GroupQuantifierSet {
new public void @this(global::java.util.regex.AbstractSet n1, global::java.util.regex.AbstractSet n2, int n3){
//XMLVM_BEGIN_WRAPPER[java.util.regex.AltGroupQuantifierSet: void <init>(java.util.regex.AbstractSet, java.util.regex.AbstractSet, int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    _r3.i = n3;
    ((global::java.util.regex.GroupQuantifierSet) _r0_o).@this((global::java.util.regex.AbstractSet) _r1_o, (global::java.util.regex.AbstractSet) _r2_o, (int) _r3.i);
    return;
//XMLVM_END_WRAPPER[java.util.regex.AltGroupQuantifierSet: void <init>(java.util.regex.AbstractSet, java.util.regex.AbstractSet, int)]
}

public override int matches(int n1, global::java.lang.CharSequence n2, global::java.util.regex.MatchResultImpl n3){
//XMLVM_BEGIN_WRAPPER[java.util.regex.AltGroupQuantifierSet: int matches(int, java.lang.CharSequence, java.util.regex.MatchResultImpl)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r1_o = this;
    _r2.i = n1;
    _r3_o = n2;
    _r4_o = n3;
    _r0_o = ((global::java.util.regex.AltGroupQuantifierSet) _r1_o)._finnerSet;
    _r0.i = ((global::java.util.regex.AbstractSet) _r0_o).hasConsumed((global::java.util.regex.MatchResultImpl) _r4_o) ? 1 : 0;
    if (_r0.i != 0) goto label15;
    _r0_o = ((global::java.util.regex.AltGroupQuantifierSet) _r1_o)._fnext;
    _r0.i = ((global::java.util.regex.AbstractSet) _r0_o).matches((int) _r2.i, (global::java.lang.CharSequence) _r3_o, (global::java.util.regex.MatchResultImpl) _r4_o);
    label14:;
    return _r0.i;
    label15:;
    _r0_o = ((global::java.util.regex.AltGroupQuantifierSet) _r1_o)._finnerSet;
    _r0.i = ((global::java.util.regex.AbstractSet) _r0_o).matches((int) _r2.i, (global::java.lang.CharSequence) _r3_o, (global::java.util.regex.MatchResultImpl) _r4_o);
    if (_r0.i >= 0) goto label14;
    _r0_o = ((global::java.util.regex.AltGroupQuantifierSet) _r1_o)._fnext;
    _r0.i = ((global::java.util.regex.AbstractSet) _r0_o).matches((int) _r2.i, (global::java.lang.CharSequence) _r3_o, (global::java.util.regex.MatchResultImpl) _r4_o);
    goto label14;
//XMLVM_END_WRAPPER[java.util.regex.AltGroupQuantifierSet: int matches(int, java.lang.CharSequence, java.util.regex.MatchResultImpl)]
}

public override void setNext(global::java.util.regex.AbstractSet n1){
//XMLVM_BEGIN_WRAPPER[java.util.regex.AltGroupQuantifierSet: void setNext(java.util.regex.AbstractSet)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    base.setNext((global::java.util.regex.AbstractSet) _r2_o);
    _r0_o = ((global::java.util.regex.AltGroupQuantifierSet) _r1_o)._finnerSet;
    ((global::java.util.regex.AbstractSet) _r0_o).setNext((global::java.util.regex.AbstractSet) _r2_o);
    return;
//XMLVM_END_WRAPPER[java.util.regex.AltGroupQuantifierSet: void setNext(java.util.regex.AbstractSet)]
}

//XMLVM_BEGIN_WRAPPER[java.util.regex.AltGroupQuantifierSet]
//XMLVM_END_WRAPPER[java.util.regex.AltGroupQuantifierSet]

} // end of class: AltGroupQuantifierSet

} // end of namespace: java.util.regex
