// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.processing {
public class JSONContent: global::com.codename1.processing.MapContent {
new public void @this(global::java.util.Map n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.processing.JSONContent: void <init>(java.util.Map)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.processing.MapContent) _r0_o).@this((global::java.util.Map) _r1_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.processing.JSONContent: void <init>(java.util.Map)]
}

new public void @this(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.processing.JSONContent: void <init>(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    _r4_o = this;
    _r5_o = n1;
    // Value=UTF-8
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)85)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 70)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 56))}));
    _r0_o = new global::java.io.InputStreamReader();
    _r1_o = new global::java.io.ByteArrayInputStream();
    // Value=UTF-8
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)85)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 70)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 56))}));
    _r2_o = ((global::java.lang.String) _r5_o).getBytes((global::java.lang.String) _r3_o);
    ((global::java.io.ByteArrayInputStream) _r1_o).@this((global::org.xmlvm._nArrayAdapter<sbyte>) _r2_o);
    // Value=UTF-8
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)85)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 70)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 56))}));
    ((global::java.io.InputStreamReader) _r0_o).@this((global::java.io.InputStream) _r1_o, (global::java.lang.String) _r3_o);
    ((global::com.codename1.processing.JSONContent) _r4_o).@this((global::java.io.Reader) _r0_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.processing.JSONContent: void <init>(java.lang.String)]
}

new public void @this(global::java.io.InputStream n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.processing.JSONContent: void <init>(java.io.InputStream)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r0_o = new global::com.codename1.io.JSONParser();
    ((global::com.codename1.io.JSONParser) _r0_o).@this();
    _r1_o = new global::java.io.InputStreamReader();
    ((global::java.io.InputStreamReader) _r1_o).@this((global::java.io.InputStream) _r3_o);
    _r0_o = ((global::com.codename1.io.JSONParser) _r0_o).parse((global::java.io.Reader) _r1_o);
    ((global::com.codename1.processing.JSONContent) _r2_o).@this((global::java.util.Map) _r0_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.processing.JSONContent: void <init>(java.io.InputStream)]
}

new public void @this(global::java.io.Reader n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.processing.JSONContent: void <init>(java.io.Reader)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = new global::com.codename1.io.JSONParser();
    ((global::com.codename1.io.JSONParser) _r0_o).@this();
    _r0_o = ((global::com.codename1.io.JSONParser) _r0_o).parse((global::java.io.Reader) _r2_o);
    ((global::com.codename1.processing.JSONContent) _r1_o).@this((global::java.util.Map) _r0_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.processing.JSONContent: void <init>(java.io.Reader)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.processing.JSONContent]
//XMLVM_END_WRAPPER[com.codename1.processing.JSONContent]

} // end of class: JSONContent

} // end of namespace: com.codename1.processing
