// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public class TreeMap_2UnboundedKeyIterator: global::java.util.TreeMap_2AbstractMapIterator,global::java.util.Iterator {
new public void @this(global::java.util.TreeMap n1, global::java.util.TreeMap_2Node n2, int n3){
//XMLVM_BEGIN_WRAPPER[java.util.TreeMap$UnboundedKeyIterator: void <init>(java.util.TreeMap, java.util.TreeMap$Node, int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    _r3.i = n3;
    ((global::java.util.TreeMap_2AbstractMapIterator) _r0_o).@this((global::java.util.TreeMap) _r1_o, (global::java.util.TreeMap_2Node) _r2_o, (int) _r3.i);
    return;
//XMLVM_END_WRAPPER[java.util.TreeMap$UnboundedKeyIterator: void <init>(java.util.TreeMap, java.util.TreeMap$Node, int)]
}

new public void @this(global::java.util.TreeMap n1){
//XMLVM_BEGIN_WRAPPER[java.util.TreeMap$UnboundedKeyIterator: void <init>(java.util.TreeMap)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.util.TreeMap_2AbstractMapIterator) _r0_o).@this((global::java.util.TreeMap) _r1_o);
    return;
//XMLVM_END_WRAPPER[java.util.TreeMap$UnboundedKeyIterator: void <init>(java.util.TreeMap)]
}

public virtual global::System.Object next(){
//XMLVM_BEGIN_WRAPPER[java.util.TreeMap$UnboundedKeyIterator: java.lang.Object next()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    _r2_o = this;
    ((global::java.util.TreeMap_2UnboundedKeyIterator) _r2_o).makeNext();
    _r0_o = ((global::java.util.TreeMap_2UnboundedKeyIterator) _r2_o)._flastNode;
    _r0_o = ((global::java.util.TreeMap_2Node) _r0_o)._fkeys;
    _r1.i = ((global::java.util.TreeMap_2UnboundedKeyIterator) _r2_o)._flastOffset;
    _r0_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i];
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[java.util.TreeMap$UnboundedKeyIterator: java.lang.Object next()]
}

//XMLVM_BEGIN_WRAPPER[java.util.TreeMap$UnboundedKeyIterator]
//XMLVM_END_WRAPPER[java.util.TreeMap$UnboundedKeyIterator]

} // end of class: TreeMap_2UnboundedKeyIterator

} // end of namespace: java.util
