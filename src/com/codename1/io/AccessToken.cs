// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.io {
public class AccessToken: global::java.lang.Object,global::com.codename1.io.Externalizable {
private global::java.lang.String _ftoken;

private global::java.lang.String _fexpires;

public void @this(global::java.lang.String n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.AccessToken: void <init>(java.lang.String, java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    ((global::java.lang.Object) _r0_o).@this();
    ((global::com.codename1.io.AccessToken) _r0_o)._ftoken = (global::java.lang.String) _r1_o;
    ((global::com.codename1.io.AccessToken) _r0_o)._fexpires = (global::java.lang.String) _r2_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.io.AccessToken: void <init>(java.lang.String, java.lang.String)]
}

public virtual global::System.Object getToken(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.AccessToken: java.lang.String getToken()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.io.AccessToken) _r1_o)._ftoken;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.io.AccessToken: java.lang.String getToken()]
}

public virtual global::System.Object getExpires(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.AccessToken: java.lang.String getExpires()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.io.AccessToken) _r1_o)._fexpires;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.io.AccessToken: java.lang.String getExpires()]
}

public virtual int getVersion(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.AccessToken: int getVersion()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = 1;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.io.AccessToken: int getVersion()]
}

public virtual void externalize(global::java.io.DataOutputStream n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.AccessToken: void externalize(java.io.DataOutputStream)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::com.codename1.io.AccessToken) _r1_o)._ftoken;
    global::com.codename1.io.Util.writeUTF((global::java.lang.String) _r0_o, (global::java.io.DataOutputStream) _r2_o);
    _r0_o = ((global::com.codename1.io.AccessToken) _r1_o)._fexpires;
    global::com.codename1.io.Util.writeUTF((global::java.lang.String) _r0_o, (global::java.io.DataOutputStream) _r2_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.io.AccessToken: void externalize(java.io.DataOutputStream)]
}

public virtual void internalize(int n1, global::java.io.DataInputStream n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.AccessToken: void internalize(int, java.io.DataInputStream)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2.i = n1;
    _r3_o = n2;
    _r0_o = global::com.codename1.io.Util.readUTF((global::java.io.DataInputStream) _r3_o);
    ((global::com.codename1.io.AccessToken) _r1_o)._ftoken = (global::java.lang.String) _r0_o;
    _r0_o = global::com.codename1.io.Util.readUTF((global::java.io.DataInputStream) _r3_o);
    ((global::com.codename1.io.AccessToken) _r1_o)._fexpires = (global::java.lang.String) _r0_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.io.AccessToken: void internalize(int, java.io.DataInputStream)]
}

public virtual global::System.Object getObjectId(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.AccessToken: java.lang.String getObjectId()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    // Value=AccessToken
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)65)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 107)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110))}));
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.io.AccessToken: java.lang.String getObjectId()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.io.AccessToken]
//XMLVM_END_WRAPPER[com.codename1.io.AccessToken]

} // end of class: AccessToken

} // end of namespace: com.codename1.io