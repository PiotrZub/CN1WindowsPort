// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.net {
public class Proxy_2Type: global::java.lang.Enum {

static Proxy_2Type() {
    @static();
}

public static global::java.net.Proxy_2Type _fDIRECT;

public static global::java.net.Proxy_2Type _fHTTP;

public static global::java.net.Proxy_2Type _fSOCKS;

private static global::org.xmlvm._nArrayAdapter<global::System.Object> _fENUM_2VALUES;

new public static void @static(){
//XMLVM_BEGIN_WRAPPER[java.net.Proxy$Type: void <clinit>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    _r4.i = 2;
    _r3.i = 1;
    _r2.i = 0;
    _r0_o = new global::java.net.Proxy_2Type();
    // Value=DIRECT
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)68)), unchecked((char) unchecked((uint) 73)), unchecked((char) unchecked((uint) 82)), unchecked((char) unchecked((uint) 69)), unchecked((char) unchecked((uint) 67)), unchecked((char) unchecked((uint) 84))}));
    ((global::java.net.Proxy_2Type) _r0_o).@this((global::java.lang.String) _r1_o, (int) _r2.i);
    global::java.net.Proxy_2Type._fDIRECT = (global::java.net.Proxy_2Type) _r0_o;
    _r0_o = new global::java.net.Proxy_2Type();
    // Value=HTTP
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)72)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 80))}));
    ((global::java.net.Proxy_2Type) _r0_o).@this((global::java.lang.String) _r1_o, (int) _r3.i);
    global::java.net.Proxy_2Type._fHTTP = (global::java.net.Proxy_2Type) _r0_o;
    _r0_o = new global::java.net.Proxy_2Type();
    // Value=SOCKS
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)83)), unchecked((char) unchecked((uint) 79)), unchecked((char) unchecked((uint) 67)), unchecked((char) unchecked((uint) 75)), unchecked((char) unchecked((uint) 83))}));
    ((global::java.net.Proxy_2Type) _r0_o).@this((global::java.lang.String) _r1_o, (int) _r4.i);
    global::java.net.Proxy_2Type._fSOCKS = (global::java.net.Proxy_2Type) _r0_o;
    _r0.i = 3;
    _r0_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r0.i]);
    _r1_o = global::java.net.Proxy_2Type._fDIRECT;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r2.i] = _r1_o;
    _r1_o = global::java.net.Proxy_2Type._fHTTP;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r3.i] = _r1_o;
    _r1_o = global::java.net.Proxy_2Type._fSOCKS;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r4.i] = _r1_o;
    global::java.net.Proxy_2Type._fENUM_2VALUES = (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o;
    return;
//XMLVM_END_WRAPPER[java.net.Proxy$Type: void <clinit>()]
}

new private void @this(global::java.lang.String n1, int n2){
//XMLVM_BEGIN_WRAPPER[java.net.Proxy$Type: void <init>(java.lang.String, int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r0_o = this;
    _r1_o = n1;
    _r2.i = n2;
    ((global::java.lang.Enum) _r0_o).@this((global::java.lang.String) _r1_o, (int) _r2.i);
    return;
//XMLVM_END_WRAPPER[java.net.Proxy$Type: void <init>(java.lang.String, int)]
}

public static global::System.Object values(){
//XMLVM_BEGIN_WRAPPER[java.net.Proxy$Type: java.net.Proxy$Type[] values()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    _r3.i = 0;
    _r0_o = global::java.net.Proxy_2Type._fENUM_2VALUES;
    _r1.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    _r2_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r1.i]);
    global::java.lang.System.arraycopy((global::java.lang.Object) _r0_o, (int) _r3.i, (global::java.lang.Object) _r2_o, (int) _r3.i, (int) _r1.i);
    return (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o;
//XMLVM_END_WRAPPER[java.net.Proxy$Type: java.net.Proxy$Type[] values()]
}

public static global::System.Object valueOf(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[java.net.Proxy$Type: java.net.Proxy$Type valueOf(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = n1;
    _r0_o = global::org.xmlvm._nTIB.getClass(typeof(global::java.net.Proxy_2Type));
    _r1_o = global::java.lang.Enum.valueOf((global::java.lang.Class) _r0_o, (global::java.lang.String) _r1_o);
    return (global::java.net.Proxy_2Type) _r1_o;
//XMLVM_END_WRAPPER[java.net.Proxy$Type: java.net.Proxy$Type valueOf(java.lang.String)]
}

//XMLVM_BEGIN_WRAPPER[java.net.Proxy$Type]
//XMLVM_END_WRAPPER[java.net.Proxy$Type]

} // end of class: Proxy_2Type

} // end of namespace: java.net
