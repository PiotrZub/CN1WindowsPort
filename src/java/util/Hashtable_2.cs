// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public class Hashtable_22: global::java.lang.Object,global::java.util.Iterator {
new public void @this(){
//XMLVM_BEGIN_WRAPPER[java.util.Hashtable$2: void <init>()]
    global::System.Object _r0_o = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[java.util.Hashtable$2: void <init>()]
}

public virtual bool hasNext(){
//XMLVM_BEGIN_WRAPPER[java.util.Hashtable$2: boolean hasNext()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.util.Hashtable$2: boolean hasNext()]
}

public virtual global::System.Object next(){
//XMLVM_BEGIN_WRAPPER[java.util.Hashtable$2: java.lang.Object next()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = new global::java.util.NoSuchElementException();
    ((global::java.util.NoSuchElementException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.util.NoSuchElementException) _r0_o);
//XMLVM_END_WRAPPER[java.util.Hashtable$2: java.lang.Object next()]
}

public virtual void remove(){
//XMLVM_BEGIN_WRAPPER[java.util.Hashtable$2: void remove()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = new global::java.lang.IllegalStateException();
    ((global::java.lang.IllegalStateException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalStateException) _r0_o);
//XMLVM_END_WRAPPER[java.util.Hashtable$2: void remove()]
}

//XMLVM_BEGIN_WRAPPER[java.util.Hashtable$2]
//XMLVM_END_WRAPPER[java.util.Hashtable$2]

} // end of class: Hashtable_22

} // end of namespace: java.util
