// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.lang {
public class ThreadLocal: global::java.lang.Object {
new public void @this(){
//XMLVM_BEGIN_WRAPPER[java.lang.ThreadLocal: void <init>()]
    global::System.Object _r0_o = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[java.lang.ThreadLocal: void <init>()]
}

public virtual global::System.Object get(){
//XMLVM_BEGIN_WRAPPER[java.lang.ThreadLocal: java.lang.Object get()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = global::java.lang.Thread.currentThread();
    _r0_o = ((global::java.lang.Thread) _r0_o).getThreadLocal((global::java.lang.ThreadLocal) _r1_o);
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[java.lang.ThreadLocal: java.lang.Object get()]
}

public virtual global::System.Object initialValue(){
//XMLVM_BEGIN_WRAPPER[java.lang.ThreadLocal: java.lang.Object initialValue()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = null;
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[java.lang.ThreadLocal: java.lang.Object initialValue()]
}

public virtual void set(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.lang.ThreadLocal: void set(java.lang.Object)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = global::java.lang.Thread.currentThread();
    ((global::java.lang.Thread) _r0_o).setThreadLocal((global::java.lang.ThreadLocal) _r1_o, (global::java.lang.Object) _r2_o);
    return;
//XMLVM_END_WRAPPER[java.lang.ThreadLocal: void set(java.lang.Object)]
}

public virtual void remove(){
//XMLVM_BEGIN_WRAPPER[java.lang.ThreadLocal: void remove()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = global::java.lang.Thread.currentThread();
    _r1_o = ((global::java.lang.ThreadLocal) _r2_o).initialValue();
    ((global::java.lang.Thread) _r0_o).setThreadLocal((global::java.lang.ThreadLocal) _r2_o, (global::java.lang.Object) _r1_o);
    return;
//XMLVM_END_WRAPPER[java.lang.ThreadLocal: void remove()]
}

//XMLVM_BEGIN_WRAPPER[java.lang.ThreadLocal]
//XMLVM_END_WRAPPER[java.lang.ThreadLocal]

} // end of class: ThreadLocal

} // end of namespace: java.lang
