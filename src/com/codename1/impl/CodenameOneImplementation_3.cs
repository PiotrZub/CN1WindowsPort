// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.impl {
public class CodenameOneImplementation_23: global::com.codename1.io.ConnectionRequest {
new public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.impl.CodenameOneImplementation$3: void <init>()]
    global::System.Object _r0_o = null;
    _r0_o = this;
    ((global::com.codename1.io.ConnectionRequest) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.impl.CodenameOneImplementation$3: void <init>()]
}

public override void readResponse(global::java.io.InputStream n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.impl.CodenameOneImplementation$3: void readResponse(java.io.InputStream)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    _r5_o = this;
    _r6_o = n1;
    _r0_o = new global::java.io.DataInputStream();
    ((global::java.io.DataInputStream) _r0_o).@this((global::java.io.InputStream) _r6_o);
    _r1.l = ((global::java.io.DataInputStream) _r0_o).readLong();
    // Value=push_id
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)112)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 95)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 100))}));
    global::com.codename1.io.Preferences.set((global::java.lang.String) _r3_o, (long) _r1.l);
    _r3_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r3_o).@this();
    // Value=registerPushOnServer push id received from server: 
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)114)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 80)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 79)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 83)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 58)), unchecked((char) unchecked((uint) 32))}));
    _r3_o = ((global::java.lang.StringBuilder) _r3_o).append((global::java.lang.String) _r4_o);
    _r3_o = ((global::java.lang.StringBuilder) _r3_o).append((long) _r1.l);
    _r3_o = ((global::java.lang.StringBuilder) _r3_o).toString();
    global::com.codename1.io.Log.p((global::java.lang.String) _r3_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.impl.CodenameOneImplementation$3: void readResponse(java.io.InputStream)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.impl.CodenameOneImplementation$3]
//XMLVM_END_WRAPPER[com.codename1.impl.CodenameOneImplementation$3]

} // end of class: CodenameOneImplementation_23

} // end of namespace: com.codename1.impl
