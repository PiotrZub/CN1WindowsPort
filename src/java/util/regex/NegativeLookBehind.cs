// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util.regex {
public class NegativeLookBehind: global::java.util.regex.AtomicJointSet {
new public void @this(global::java.util.ArrayList n1, global::java.util.regex.FSet n2){
//XMLVM_BEGIN_WRAPPER[java.util.regex.NegativeLookBehind: void <init>(java.util.ArrayList, java.util.regex.FSet)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    ((global::java.util.regex.AtomicJointSet) _r0_o).@this((global::java.util.ArrayList) _r1_o, (global::java.util.regex.FSet) _r2_o);
    return;
//XMLVM_END_WRAPPER[java.util.regex.NegativeLookBehind: void <init>(java.util.ArrayList, java.util.regex.FSet)]
}

public override int matches(int n1, global::java.lang.CharSequence n2, global::java.util.regex.MatchResultImpl n3){
//XMLVM_BEGIN_WRAPPER[java.util.regex.NegativeLookBehind: int matches(int, java.lang.CharSequence, java.util.regex.MatchResultImpl)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    _r4_o = this;
    _r5.i = n1;
    _r6_o = n2;
    _r7_o = n3;
    _r3.i = 0;
    _r0_o = ((global::java.util.regex.NegativeLookBehind) _r4_o)._fchildren;
    _r1.i = ((global::java.util.ArrayList) _r0_o).size();
    _r0.i = ((global::java.util.regex.NegativeLookBehind) _r4_o)._fgroupIndex;
    ((global::java.util.regex.MatchResultImpl) _r7_o).setConsumed((int) _r0.i, (int) _r5.i);
    _r2.i = _r3.i;
    label13:;
    if (_r2.i < _r1.i) goto label22;
    _r0_o = ((global::java.util.regex.NegativeLookBehind) _r4_o)._fnext;
    _r0.i = ((global::java.util.regex.AbstractSet) _r0_o).matches((int) _r5.i, (global::java.lang.CharSequence) _r6_o, (global::java.util.regex.MatchResultImpl) _r7_o);
    label21:;
    return _r0.i;
    label22:;
    _r0_o = ((global::java.util.regex.NegativeLookBehind) _r4_o)._fchildren;
    _r0_o = ((global::java.util.ArrayList) _r0_o).get((int) _r2.i);
    _r0.i = ((global::java.util.regex.AbstractSet) _r0_o).findBack((int) _r3.i, (int) _r5.i, (global::java.lang.CharSequence) _r6_o, (global::java.util.regex.MatchResultImpl) _r7_o);
    if (_r0.i < 0) goto label38;
    _r0.i = -1;
    goto label21;
    label38:;
    _r0.i = _r2.i + 1;
    _r2.i = _r0.i;
    goto label13;
//XMLVM_END_WRAPPER[java.util.regex.NegativeLookBehind: int matches(int, java.lang.CharSequence, java.util.regex.MatchResultImpl)]
}

public override bool hasConsumed(global::java.util.regex.MatchResultImpl n1){
//XMLVM_BEGIN_WRAPPER[java.util.regex.NegativeLookBehind: boolean hasConsumed(java.util.regex.MatchResultImpl)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0.i = 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.util.regex.NegativeLookBehind: boolean hasConsumed(java.util.regex.MatchResultImpl)]
}

public override global::System.Object getName(){
//XMLVM_BEGIN_WRAPPER[java.util.regex.NegativeLookBehind: java.lang.String getName()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    // Value=NegBehindJointSet
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)78)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 66)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 74)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 83)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 116))}));
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[java.util.regex.NegativeLookBehind: java.lang.String getName()]
}

//XMLVM_BEGIN_WRAPPER[java.util.regex.NegativeLookBehind]
//XMLVM_END_WRAPPER[java.util.regex.NegativeLookBehind]

} // end of class: NegativeLookBehind

} // end of namespace: java.util.regex
