// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.io.services {
public class CachedData: global::java.lang.Object,global::com.codename1.io.Externalizable {
private global::org.xmlvm._nArrayAdapter<sbyte> _fdata;

private global::java.lang.String _furl;

private global::java.lang.String _fetag;

private global::java.lang.String _fmodified;

private bool _ffetching;

new public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.services.CachedData: void <init>()]
    global::System.Object _r0_o = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.io.services.CachedData: void <init>()]
}

public virtual int getVersion(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.services.CachedData: int getVersion()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = 1;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.io.services.CachedData: int getVersion()]
}

public virtual void externalize(global::java.io.DataOutputStream n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.services.CachedData: void externalize(java.io.DataOutputStream)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::com.codename1.io.services.CachedData) _r1_o)._furl;
    global::com.codename1.io.Util.writeUTF((global::java.lang.String) _r0_o, (global::java.io.DataOutputStream) _r2_o);
    _r0_o = ((global::com.codename1.io.services.CachedData) _r1_o)._fetag;
    global::com.codename1.io.Util.writeUTF((global::java.lang.String) _r0_o, (global::java.io.DataOutputStream) _r2_o);
    _r0_o = ((global::com.codename1.io.services.CachedData) _r1_o)._fmodified;
    global::com.codename1.io.Util.writeUTF((global::java.lang.String) _r0_o, (global::java.io.DataOutputStream) _r2_o);
    _r0_o = ((global::com.codename1.io.services.CachedData) _r1_o)._fdata;
    _r0.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    ((global::java.io.DataOutputStream) _r2_o).writeInt((int) _r0.i);
    _r0_o = ((global::com.codename1.io.services.CachedData) _r1_o)._fdata;
    ((global::java.io.DataOutputStream) _r2_o).write((global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.io.services.CachedData: void externalize(java.io.DataOutputStream)]
}

public virtual void internalize(int n1, global::java.io.DataInputStream n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.services.CachedData: void internalize(int, java.io.DataInputStream)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    _r1_o = this;
    _r2.i = n1;
    _r3_o = n2;
    _r0_o = global::com.codename1.io.Util.readUTF((global::java.io.DataInputStream) _r3_o);
    ((global::com.codename1.io.services.CachedData) _r1_o)._furl = (global::java.lang.String) _r0_o;
    _r0_o = global::com.codename1.io.Util.readUTF((global::java.io.DataInputStream) _r3_o);
    ((global::com.codename1.io.services.CachedData) _r1_o)._fetag = (global::java.lang.String) _r0_o;
    _r0_o = global::com.codename1.io.Util.readUTF((global::java.io.DataInputStream) _r3_o);
    ((global::com.codename1.io.services.CachedData) _r1_o)._fmodified = (global::java.lang.String) _r0_o;
    _r0.i = ((global::java.io.DataInputStream) _r3_o).readInt();
    _r0_o = new global::org.xmlvm._nArrayAdapter<sbyte>(new sbyte[_r0.i]);
    ((global::com.codename1.io.services.CachedData) _r1_o)._fdata = (global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o;
    _r0_o = ((global::com.codename1.io.services.CachedData) _r1_o)._fdata;
    ((global::java.io.DataInputStream) _r3_o).readFully((global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.io.services.CachedData: void internalize(int, java.io.DataInputStream)]
}

public virtual global::System.Object getObjectId(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.services.CachedData: java.lang.String getObjectId()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    // Value=CachedData
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)67)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 68)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 97))}));
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.io.services.CachedData: java.lang.String getObjectId()]
}

public virtual global::System.Object getData(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.services.CachedData: byte[] getData()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.io.services.CachedData) _r1_o)._fdata;
    return (global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.io.services.CachedData: byte[] getData()]
}

public virtual void setData(global::org.xmlvm._nArrayAdapter<sbyte> n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.services.CachedData: void setData(byte[])]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.io.services.CachedData) _r0_o)._fdata = (global::org.xmlvm._nArrayAdapter<sbyte>) _r1_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.io.services.CachedData: void setData(byte[])]
}

public virtual global::System.Object getUrl(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.services.CachedData: java.lang.String getUrl()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.io.services.CachedData) _r1_o)._furl;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.io.services.CachedData: java.lang.String getUrl()]
}

public virtual void setUrl(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.services.CachedData: void setUrl(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.io.services.CachedData) _r0_o)._furl = (global::java.lang.String) _r1_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.io.services.CachedData: void setUrl(java.lang.String)]
}

public virtual global::System.Object getEtag(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.services.CachedData: java.lang.String getEtag()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.io.services.CachedData) _r1_o)._fetag;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.io.services.CachedData: java.lang.String getEtag()]
}

public virtual void setEtag(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.services.CachedData: void setEtag(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.io.services.CachedData) _r0_o)._fetag = (global::java.lang.String) _r1_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.io.services.CachedData: void setEtag(java.lang.String)]
}

public virtual global::System.Object getModified(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.services.CachedData: java.lang.String getModified()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.io.services.CachedData) _r1_o)._fmodified;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.io.services.CachedData: java.lang.String getModified()]
}

public virtual void setModified(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.services.CachedData: void setModified(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.io.services.CachedData) _r0_o)._fmodified = (global::java.lang.String) _r1_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.io.services.CachedData: void setModified(java.lang.String)]
}

public virtual bool isFetching(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.services.CachedData: boolean isFetching()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.io.services.CachedData) _r1_o)._ffetching ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.io.services.CachedData: boolean isFetching()]
}

public virtual void setFetching(bool n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.services.CachedData: void setFetching(boolean)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.i = n1 ? 1 : 0;
    ((global::com.codename1.io.services.CachedData) _r0_o)._ffetching = 0!=_r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.io.services.CachedData: void setFetching(boolean)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.io.services.CachedData]
//XMLVM_END_WRAPPER[com.codename1.io.services.CachedData]

} // end of class: CachedData

} // end of namespace: com.codename1.io.services
