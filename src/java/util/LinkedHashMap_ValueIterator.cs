// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public class LinkedHashMap_2ValueIterator: global::java.util.LinkedHashMap_2AbstractMapIterator,global::java.util.Iterator {
new public void @this(global::java.util.LinkedHashMap n1){
//XMLVM_BEGIN_WRAPPER[java.util.LinkedHashMap$ValueIterator: void <init>(java.util.LinkedHashMap)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.util.LinkedHashMap_2AbstractMapIterator) _r0_o).@this((global::java.util.LinkedHashMap) _r1_o);
    return;
//XMLVM_END_WRAPPER[java.util.LinkedHashMap$ValueIterator: void <init>(java.util.LinkedHashMap)]
}

public virtual global::System.Object next(){
//XMLVM_BEGIN_WRAPPER[java.util.LinkedHashMap$ValueIterator: java.lang.Object next()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    ((global::java.util.LinkedHashMap_2ValueIterator) _r1_o).makeNext();
    _r0_o = ((global::java.util.LinkedHashMap_2ValueIterator) _r1_o)._fcurrentEntry;
    _r0_o = ((global::java.util.LinkedHashMap_2LinkedHashMapEntry) _r0_o)._fvalue;
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[java.util.LinkedHashMap$ValueIterator: java.lang.Object next()]
}

//XMLVM_BEGIN_WRAPPER[java.util.LinkedHashMap$ValueIterator]
//XMLVM_END_WRAPPER[java.util.LinkedHashMap$ValueIterator]

} // end of class: LinkedHashMap_2ValueIterator

} // end of namespace: java.util
