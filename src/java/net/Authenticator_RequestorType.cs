// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.net {
public class Authenticator_2RequestorType: global::java.lang.Enum {

static Authenticator_2RequestorType() {
    @static();
}

public static global::java.net.Authenticator_2RequestorType _fPROXY;

public static global::java.net.Authenticator_2RequestorType _fSERVER;

private static global::org.xmlvm._nArrayAdapter<global::System.Object> _fENUM_2VALUES;

new public static void @static(){
//XMLVM_BEGIN_WRAPPER[java.net.Authenticator$RequestorType: void <clinit>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    _r3.i = 1;
    _r2.i = 0;
    _r0_o = new global::java.net.Authenticator_2RequestorType();
    // Value=PROXY
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)80)), unchecked((char) unchecked((uint) 82)), unchecked((char) unchecked((uint) 79)), unchecked((char) unchecked((uint) 88)), unchecked((char) unchecked((uint) 89))}));
    ((global::java.net.Authenticator_2RequestorType) _r0_o).@this((global::java.lang.String) _r1_o, (int) _r2.i);
    global::java.net.Authenticator_2RequestorType._fPROXY = (global::java.net.Authenticator_2RequestorType) _r0_o;
    _r0_o = new global::java.net.Authenticator_2RequestorType();
    // Value=SERVER
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)83)), unchecked((char) unchecked((uint) 69)), unchecked((char) unchecked((uint) 82)), unchecked((char) unchecked((uint) 86)), unchecked((char) unchecked((uint) 69)), unchecked((char) unchecked((uint) 82))}));
    ((global::java.net.Authenticator_2RequestorType) _r0_o).@this((global::java.lang.String) _r1_o, (int) _r3.i);
    global::java.net.Authenticator_2RequestorType._fSERVER = (global::java.net.Authenticator_2RequestorType) _r0_o;
    _r0.i = 2;
    _r0_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r0.i]);
    _r1_o = global::java.net.Authenticator_2RequestorType._fPROXY;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r2.i] = _r1_o;
    _r1_o = global::java.net.Authenticator_2RequestorType._fSERVER;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r3.i] = _r1_o;
    global::java.net.Authenticator_2RequestorType._fENUM_2VALUES = (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o;
    return;
//XMLVM_END_WRAPPER[java.net.Authenticator$RequestorType: void <clinit>()]
}

new private void @this(global::java.lang.String n1, int n2){
//XMLVM_BEGIN_WRAPPER[java.net.Authenticator$RequestorType: void <init>(java.lang.String, int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r0_o = this;
    _r1_o = n1;
    _r2.i = n2;
    ((global::java.lang.Enum) _r0_o).@this((global::java.lang.String) _r1_o, (int) _r2.i);
    return;
//XMLVM_END_WRAPPER[java.net.Authenticator$RequestorType: void <init>(java.lang.String, int)]
}

public static global::System.Object values(){
//XMLVM_BEGIN_WRAPPER[java.net.Authenticator$RequestorType: java.net.Authenticator$RequestorType[] values()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    _r3.i = 0;
    _r0_o = global::java.net.Authenticator_2RequestorType._fENUM_2VALUES;
    _r1.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    _r2_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r1.i]);
    global::java.lang.System.arraycopy((global::java.lang.Object) _r0_o, (int) _r3.i, (global::java.lang.Object) _r2_o, (int) _r3.i, (int) _r1.i);
    return (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o;
//XMLVM_END_WRAPPER[java.net.Authenticator$RequestorType: java.net.Authenticator$RequestorType[] values()]
}

public static global::System.Object valueOf(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[java.net.Authenticator$RequestorType: java.net.Authenticator$RequestorType valueOf(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = n1;
    _r0_o = global::org.xmlvm._nTIB.getClass(typeof(global::java.net.Authenticator_2RequestorType));
    _r1_o = global::java.lang.Enum.valueOf((global::java.lang.Class) _r0_o, (global::java.lang.String) _r1_o);
    return (global::java.net.Authenticator_2RequestorType) _r1_o;
//XMLVM_END_WRAPPER[java.net.Authenticator$RequestorType: java.net.Authenticator$RequestorType valueOf(java.lang.String)]
}

//XMLVM_BEGIN_WRAPPER[java.net.Authenticator$RequestorType]
//XMLVM_END_WRAPPER[java.net.Authenticator$RequestorType]

} // end of class: Authenticator_2RequestorType

} // end of namespace: java.net
