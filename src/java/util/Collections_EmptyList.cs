// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public class Collections_2EmptyList: global::java.util.AbstractList,global::java.util.RandomAccess,global::java.io.Serializable {

new private void @this(){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$EmptyList: void <init>()]
    global::System.Object _r0_o = null;
    _r0_o = this;
    ((global::java.util.AbstractList) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[java.util.Collections$EmptyList: void <init>()]
}

public override bool contains(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$EmptyList: boolean contains(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0.i = 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.util.Collections$EmptyList: boolean contains(java.lang.Object)]
}

public override int size(){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$EmptyList: int size()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = 0;
    return _r0.i;
//XMLVM_END_WRAPPER[java.util.Collections$EmptyList: int size()]
}

public override global::System.Object get(int n1){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$EmptyList: java.lang.Object get(int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r1_o = this;
    _r2.i = n1;
    _r0_o = new global::java.lang.IndexOutOfBoundsException();
    ((global::java.lang.IndexOutOfBoundsException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IndexOutOfBoundsException) _r0_o);
//XMLVM_END_WRAPPER[java.util.Collections$EmptyList: java.lang.Object get(int)]
}

private global::System.Object readResolve(){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$EmptyList: java.lang.Object readResolve()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = global::java.util.Collections._fEMPTY_1LIST;
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[java.util.Collections$EmptyList: java.lang.Object readResolve()]
}

public void @this(global::java.util.Collections_2EmptyList n1){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$EmptyList: void <init>(java.util.Collections$EmptyList)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.util.Collections_2EmptyList) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[java.util.Collections$EmptyList: void <init>(java.util.Collections$EmptyList)]
}

//XMLVM_BEGIN_WRAPPER[java.util.Collections$EmptyList]
//XMLVM_END_WRAPPER[java.util.Collections$EmptyList]

} // end of class: Collections_2EmptyList

} // end of namespace: java.util
