// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util.regex {
public class PossessiveGroupQuantifierSet: global::java.util.regex.GroupQuantifierSet {
new public void @this(global::java.util.regex.AbstractSet n1, global::java.util.regex.AbstractSet n2, int n3){
//XMLVM_BEGIN_WRAPPER[java.util.regex.PossessiveGroupQuantifierSet: void <init>(java.util.regex.AbstractSet, java.util.regex.AbstractSet, int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r4.i = n3;
    ((global::java.util.regex.GroupQuantifierSet) _r1_o).@this((global::java.util.regex.AbstractSet) _r2_o, (global::java.util.regex.AbstractSet) _r3_o, (int) _r4.i);
    _r0_o = global::java.util.regex.FSet._fposFSet;
    ((global::java.util.regex.AbstractSet) _r2_o).setNext((global::java.util.regex.AbstractSet) _r0_o);
    return;
//XMLVM_END_WRAPPER[java.util.regex.PossessiveGroupQuantifierSet: void <init>(java.util.regex.AbstractSet, java.util.regex.AbstractSet, int)]
}

public override int matches(int n1, global::java.lang.CharSequence n2, global::java.util.regex.MatchResultImpl n3){
//XMLVM_BEGIN_WRAPPER[java.util.regex.PossessiveGroupQuantifierSet: int matches(int, java.lang.CharSequence, java.util.regex.MatchResultImpl)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    _r2_o = this;
    _r3.i = n1;
    _r4_o = n2;
    _r5_o = n3;
    _r0.i = _r3.i;
    label1:;
    _r1_o = ((global::java.util.regex.PossessiveGroupQuantifierSet) _r2_o)._finnerSet;
    _r1.i = ((global::java.util.regex.AbstractSet) _r1_o).matches((int) _r0.i, (global::java.lang.CharSequence) _r4_o, (global::java.util.regex.MatchResultImpl) _r5_o);
    if (_r1.i > 0) goto label16;
    _r1_o = ((global::java.util.regex.PossessiveGroupQuantifierSet) _r2_o)._fnext;
    _r0.i = ((global::java.util.regex.AbstractSet) _r1_o).matches((int) _r0.i, (global::java.lang.CharSequence) _r4_o, (global::java.util.regex.MatchResultImpl) _r5_o);
    return _r0.i;
    label16:;
    _r0.i = _r1.i;
    goto label1;
//XMLVM_END_WRAPPER[java.util.regex.PossessiveGroupQuantifierSet: int matches(int, java.lang.CharSequence, java.util.regex.MatchResultImpl)]
}

//XMLVM_BEGIN_WRAPPER[java.util.regex.PossessiveGroupQuantifierSet]
//XMLVM_END_WRAPPER[java.util.regex.PossessiveGroupQuantifierSet]

} // end of class: PossessiveGroupQuantifierSet

} // end of namespace: java.util.regex
