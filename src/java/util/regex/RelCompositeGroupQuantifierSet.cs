// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util.regex {
public class RelCompositeGroupQuantifierSet: global::java.util.regex.CompositeGroupQuantifierSet {
new public void @this(global::java.util.regex.Quantifier n1, global::java.util.regex.AbstractSet n2, global::java.util.regex.AbstractSet n3, int n4, int n5){
//XMLVM_BEGIN_WRAPPER[java.util.regex.RelCompositeGroupQuantifierSet: void <init>(java.util.regex.Quantifier, java.util.regex.AbstractSet, java.util.regex.AbstractSet, int, int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    _r3_o = n3;
    _r4.i = n4;
    _r5.i = n5;
    ((global::java.util.regex.CompositeGroupQuantifierSet) _r0_o).@this((global::java.util.regex.Quantifier) _r1_o, (global::java.util.regex.AbstractSet) _r2_o, (global::java.util.regex.AbstractSet) _r3_o, (int) _r4.i, (int) _r5.i);
    return;
//XMLVM_END_WRAPPER[java.util.regex.RelCompositeGroupQuantifierSet: void <init>(java.util.regex.Quantifier, java.util.regex.AbstractSet, java.util.regex.AbstractSet, int, int)]
}

public override int matches(int n1, global::java.lang.CharSequence n2, global::java.util.regex.MatchResultImpl n3){
//XMLVM_BEGIN_WRAPPER[java.util.regex.RelCompositeGroupQuantifierSet: int matches(int, java.lang.CharSequence, java.util.regex.MatchResultImpl)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    _r3_o = this;
    _r4.i = n1;
    _r5_o = n2;
    _r6_o = n3;
    _r2.i = 0;
    _r0.i = ((global::java.util.regex.RelCompositeGroupQuantifierSet) _r3_o)._fsetCounter;
    _r0.i = ((global::java.util.regex.MatchResultImpl) _r6_o).getEnterCounter((int) _r0.i);
    _r1_o = ((global::java.util.regex.RelCompositeGroupQuantifierSet) _r3_o)._finnerSet;
    _r1.i = ((global::java.util.regex.AbstractSet) _r1_o).hasConsumed((global::java.util.regex.MatchResultImpl) _r6_o) ? 1 : 0;
    if (_r1.i != 0) goto label22;
    _r0_o = ((global::java.util.regex.RelCompositeGroupQuantifierSet) _r3_o)._fnext;
    _r0.i = ((global::java.util.regex.AbstractSet) _r0_o).matches((int) _r4.i, (global::java.lang.CharSequence) _r5_o, (global::java.util.regex.MatchResultImpl) _r6_o);
    label21:;
    return _r0.i;
    label22:;
    _r1_o = ((global::java.util.regex.RelCompositeGroupQuantifierSet) _r3_o)._fquantifier;
    _r1.i = ((global::java.util.regex.Quantifier) _r1_o).max();
    if (_r0.i < _r1.i) goto label42;
    _r0.i = ((global::java.util.regex.RelCompositeGroupQuantifierSet) _r3_o)._fsetCounter;
    ((global::java.util.regex.MatchResultImpl) _r6_o).setEnterCounter((int) _r0.i, (int) _r2.i);
    _r0_o = ((global::java.util.regex.RelCompositeGroupQuantifierSet) _r3_o)._fnext;
    _r0.i = ((global::java.util.regex.AbstractSet) _r0_o).matches((int) _r4.i, (global::java.lang.CharSequence) _r5_o, (global::java.util.regex.MatchResultImpl) _r6_o);
    goto label21;
    label42:;
    _r1_o = ((global::java.util.regex.RelCompositeGroupQuantifierSet) _r3_o)._fquantifier;
    _r1.i = ((global::java.util.regex.Quantifier) _r1_o).min();
    if (_r0.i < _r1.i) goto label79;
    _r1_o = ((global::java.util.regex.RelCompositeGroupQuantifierSet) _r3_o)._fnext;
    _r1.i = ((global::java.util.regex.AbstractSet) _r1_o).matches((int) _r4.i, (global::java.lang.CharSequence) _r5_o, (global::java.util.regex.MatchResultImpl) _r6_o);
    if (_r1.i >= 0) goto label72;
    _r1.i = ((global::java.util.regex.RelCompositeGroupQuantifierSet) _r3_o)._fsetCounter;
    _r0.i = _r0.i + 1;
    ((global::java.util.regex.MatchResultImpl) _r6_o).setEnterCounter((int) _r1.i, (int) _r0.i);
    _r0_o = ((global::java.util.regex.RelCompositeGroupQuantifierSet) _r3_o)._finnerSet;
    _r0.i = ((global::java.util.regex.AbstractSet) _r0_o).matches((int) _r4.i, (global::java.lang.CharSequence) _r5_o, (global::java.util.regex.MatchResultImpl) _r6_o);
    goto label21;
    label72:;
    _r0.i = ((global::java.util.regex.RelCompositeGroupQuantifierSet) _r3_o)._fsetCounter;
    ((global::java.util.regex.MatchResultImpl) _r6_o).setEnterCounter((int) _r0.i, (int) _r2.i);
    _r0.i = _r1.i;
    goto label21;
    label79:;
    _r1.i = ((global::java.util.regex.RelCompositeGroupQuantifierSet) _r3_o)._fsetCounter;
    _r0.i = _r0.i + 1;
    ((global::java.util.regex.MatchResultImpl) _r6_o).setEnterCounter((int) _r1.i, (int) _r0.i);
    _r0_o = ((global::java.util.regex.RelCompositeGroupQuantifierSet) _r3_o)._finnerSet;
    _r0.i = ((global::java.util.regex.AbstractSet) _r0_o).matches((int) _r4.i, (global::java.lang.CharSequence) _r5_o, (global::java.util.regex.MatchResultImpl) _r6_o);
    goto label21;
//XMLVM_END_WRAPPER[java.util.regex.RelCompositeGroupQuantifierSet: int matches(int, java.lang.CharSequence, java.util.regex.MatchResultImpl)]
}

//XMLVM_BEGIN_WRAPPER[java.util.regex.RelCompositeGroupQuantifierSet]
//XMLVM_END_WRAPPER[java.util.regex.RelCompositeGroupQuantifierSet]

} // end of class: RelCompositeGroupQuantifierSet

} // end of namespace: java.util.regex
