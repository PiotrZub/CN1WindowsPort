// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public class Collections_2EmptySet: global::java.util.AbstractSet,global::java.io.Serializable {

new private void @this(){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$EmptySet: void <init>()]
    global::System.Object _r0_o = null;
    _r0_o = this;
    ((global::java.util.AbstractSet) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[java.util.Collections$EmptySet: void <init>()]
}

public override bool contains(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$EmptySet: boolean contains(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0.i = 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.util.Collections$EmptySet: boolean contains(java.lang.Object)]
}

public override int size(){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$EmptySet: int size()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = 0;
    return _r0.i;
//XMLVM_END_WRAPPER[java.util.Collections$EmptySet: int size()]
}

public override global::System.Object iterator(){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$EmptySet: java.util.Iterator iterator()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = new global::java.util.Collections_2EmptySet_21();
    ((global::java.util.Collections_2EmptySet_21) _r0_o).@this((global::java.util.Collections_2EmptySet) _r1_o);
    return (global::java.util.Iterator) _r0_o;
//XMLVM_END_WRAPPER[java.util.Collections$EmptySet: java.util.Iterator iterator()]
}

private global::System.Object readResolve(){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$EmptySet: java.lang.Object readResolve()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = global::java.util.Collections._fEMPTY_1SET;
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[java.util.Collections$EmptySet: java.lang.Object readResolve()]
}

public void @this(global::java.util.Collections_2EmptySet n1){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$EmptySet: void <init>(java.util.Collections$EmptySet)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.util.Collections_2EmptySet) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[java.util.Collections$EmptySet: void <init>(java.util.Collections$EmptySet)]
}

//XMLVM_BEGIN_WRAPPER[java.util.Collections$EmptySet]
//XMLVM_END_WRAPPER[java.util.Collections$EmptySet]

} // end of class: Collections_2EmptySet

} // end of namespace: java.util
