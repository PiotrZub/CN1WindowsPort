// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace org.xml.sax.helpers {
public class AttributesImpl: global::java.lang.Object,global::org.xml.sax.Attributes {
public int _flength;

public global::org.xmlvm._nArrayAdapter<global::System.Object> _fdata;

new public void @this(){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.AttributesImpl: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    ((global::java.lang.Object) _r1_o).@this();
    _r0.i = 0;
    ((global::org.xml.sax.helpers.AttributesImpl) _r1_o)._flength = _r0.i;
    _r0_o = null;
    ((global::org.xml.sax.helpers.AttributesImpl) _r1_o)._fdata = (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o;
    return;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.AttributesImpl: void <init>()]
}

public void @this(global::org.xml.sax.Attributes n1){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.AttributesImpl: void <init>(org.xml.sax.Attributes)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.lang.Object) _r0_o).@this();
    ((global::org.xml.sax.helpers.AttributesImpl) _r0_o).setAttributes((global::org.xml.sax.Attributes) _r1_o);
    return;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.AttributesImpl: void <init>(org.xml.sax.Attributes)]
}

public virtual int getLength(){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.AttributesImpl: int getLength()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::org.xml.sax.helpers.AttributesImpl) _r1_o)._flength;
    return _r0.i;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.AttributesImpl: int getLength()]
}

public virtual global::System.Object getURI(int n1){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.AttributesImpl: java.lang.String getURI(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    _r2_o = this;
    _r3.i = n1;
    if (_r3.i < 0) goto label13;
    _r0.i = ((global::org.xml.sax.helpers.AttributesImpl) _r2_o)._flength;
    if (_r3.i >= _r0.i) goto label13;
    _r0_o = ((global::org.xml.sax.helpers.AttributesImpl) _r2_o)._fdata;
    _r1.i = _r3.i * 5;
    _r0_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i];
    label12:;
    return (global::java.lang.String) _r0_o;
    label13:;
    _r0_o = null;
    goto label12;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.AttributesImpl: java.lang.String getURI(int)]
}

public virtual global::System.Object getLocalName(int n1){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.AttributesImpl: java.lang.String getLocalName(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    _r2_o = this;
    _r3.i = n1;
    if (_r3.i < 0) goto label15;
    _r0.i = ((global::org.xml.sax.helpers.AttributesImpl) _r2_o)._flength;
    if (_r3.i >= _r0.i) goto label15;
    _r0_o = ((global::org.xml.sax.helpers.AttributesImpl) _r2_o)._fdata;
    _r1.i = _r3.i * 5;
    _r1.i = _r1.i + 1;
    _r0_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i];
    label14:;
    return (global::java.lang.String) _r0_o;
    label15:;
    _r0_o = null;
    goto label14;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.AttributesImpl: java.lang.String getLocalName(int)]
}

public virtual global::System.Object getQName(int n1){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.AttributesImpl: java.lang.String getQName(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    _r2_o = this;
    _r3.i = n1;
    if (_r3.i < 0) goto label15;
    _r0.i = ((global::org.xml.sax.helpers.AttributesImpl) _r2_o)._flength;
    if (_r3.i >= _r0.i) goto label15;
    _r0_o = ((global::org.xml.sax.helpers.AttributesImpl) _r2_o)._fdata;
    _r1.i = _r3.i * 5;
    _r1.i = _r1.i + 2;
    _r0_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i];
    label14:;
    return (global::java.lang.String) _r0_o;
    label15:;
    _r0_o = null;
    goto label14;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.AttributesImpl: java.lang.String getQName(int)]
}

public virtual global::System.Object getType(int n1){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.AttributesImpl: java.lang.String getType(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    _r2_o = this;
    _r3.i = n1;
    if (_r3.i < 0) goto label15;
    _r0.i = ((global::org.xml.sax.helpers.AttributesImpl) _r2_o)._flength;
    if (_r3.i >= _r0.i) goto label15;
    _r0_o = ((global::org.xml.sax.helpers.AttributesImpl) _r2_o)._fdata;
    _r1.i = _r3.i * 5;
    _r1.i = _r1.i + 3;
    _r0_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i];
    label14:;
    return (global::java.lang.String) _r0_o;
    label15:;
    _r0_o = null;
    goto label14;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.AttributesImpl: java.lang.String getType(int)]
}

public virtual global::System.Object getValue(int n1){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.AttributesImpl: java.lang.String getValue(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    _r2_o = this;
    _r3.i = n1;
    if (_r3.i < 0) goto label15;
    _r0.i = ((global::org.xml.sax.helpers.AttributesImpl) _r2_o)._flength;
    if (_r3.i >= _r0.i) goto label15;
    _r0_o = ((global::org.xml.sax.helpers.AttributesImpl) _r2_o)._fdata;
    _r1.i = _r3.i * 5;
    _r1.i = _r1.i + 4;
    _r0_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i];
    label14:;
    return (global::java.lang.String) _r0_o;
    label15:;
    _r0_o = null;
    goto label14;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.AttributesImpl: java.lang.String getValue(int)]
}

public virtual int getIndex(global::java.lang.String n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.AttributesImpl: int getIndex(java.lang.String, java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    _r4_o = this;
    _r5_o = n1;
    _r6_o = n2;
    _r0.i = ((global::org.xml.sax.helpers.AttributesImpl) _r4_o)._flength;
    _r0.i = _r0.i * 5;
    _r1.i = 0;
    label5:;
    if (_r1.i < _r0.i) goto label9;
    _r0.i = -1;
    label8:;
    return _r0.i;
    label9:;
    _r2_o = ((global::org.xml.sax.helpers.AttributesImpl) _r4_o)._fdata;
    _r2_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o)[_r1.i];
    _r2.i = ((global::java.lang.String) _r2_o).equals((global::java.lang.Object) _r5_o) ? 1 : 0;
    if (_r2.i == 0) goto label34;
    _r2_o = ((global::org.xml.sax.helpers.AttributesImpl) _r4_o)._fdata;
    _r3.i = _r1.i + 1;
    _r2_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o)[_r3.i];
    _r2.i = ((global::java.lang.String) _r2_o).equals((global::java.lang.Object) _r6_o) ? 1 : 0;
    if (_r2.i == 0) goto label34;
    _r0.i = _r1.i / 5;
    goto label8;
    label34:;
    _r1.i = _r1.i + 5;
    goto label5;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.AttributesImpl: int getIndex(java.lang.String, java.lang.String)]
}

public virtual int getIndex(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.AttributesImpl: int getIndex(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    _r4_o = this;
    _r5_o = n1;
    _r0.i = ((global::org.xml.sax.helpers.AttributesImpl) _r4_o)._flength;
    _r0.i = _r0.i * 5;
    _r1.i = 0;
    label5:;
    if (_r1.i < _r0.i) goto label9;
    _r0.i = -1;
    label8:;
    return _r0.i;
    label9:;
    _r2_o = ((global::org.xml.sax.helpers.AttributesImpl) _r4_o)._fdata;
    _r3.i = _r1.i + 2;
    _r2_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o)[_r3.i];
    _r2.i = ((global::java.lang.String) _r2_o).equals((global::java.lang.Object) _r5_o) ? 1 : 0;
    if (_r2.i == 0) goto label24;
    _r0.i = _r1.i / 5;
    goto label8;
    label24:;
    _r1.i = _r1.i + 5;
    goto label5;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.AttributesImpl: int getIndex(java.lang.String)]
}

public virtual global::System.Object getType(global::java.lang.String n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.AttributesImpl: java.lang.String getType(java.lang.String, java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    _r4_o = this;
    _r5_o = n1;
    _r6_o = n2;
    _r0.i = ((global::org.xml.sax.helpers.AttributesImpl) _r4_o)._flength;
    _r0.i = _r0.i * 5;
    _r1.i = 0;
    label5:;
    if (_r1.i < _r0.i) goto label9;
    _r0_o = null;
    label8:;
    return (global::java.lang.String) _r0_o;
    label9:;
    _r2_o = ((global::org.xml.sax.helpers.AttributesImpl) _r4_o)._fdata;
    _r2_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o)[_r1.i];
    _r2.i = ((global::java.lang.String) _r2_o).equals((global::java.lang.Object) _r5_o) ? 1 : 0;
    if (_r2.i == 0) goto label38;
    _r2_o = ((global::org.xml.sax.helpers.AttributesImpl) _r4_o)._fdata;
    _r3.i = _r1.i + 1;
    _r2_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o)[_r3.i];
    _r2.i = ((global::java.lang.String) _r2_o).equals((global::java.lang.Object) _r6_o) ? 1 : 0;
    if (_r2.i == 0) goto label38;
    _r0_o = ((global::org.xml.sax.helpers.AttributesImpl) _r4_o)._fdata;
    _r1.i = _r1.i + 3;
    _r0_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i];
    goto label8;
    label38:;
    _r1.i = _r1.i + 5;
    goto label5;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.AttributesImpl: java.lang.String getType(java.lang.String, java.lang.String)]
}

public virtual global::System.Object getType(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.AttributesImpl: java.lang.String getType(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    _r4_o = this;
    _r5_o = n1;
    _r0.i = ((global::org.xml.sax.helpers.AttributesImpl) _r4_o)._flength;
    _r0.i = _r0.i * 5;
    _r1.i = 0;
    label5:;
    if (_r1.i < _r0.i) goto label9;
    _r0_o = null;
    label8:;
    return (global::java.lang.String) _r0_o;
    label9:;
    _r2_o = ((global::org.xml.sax.helpers.AttributesImpl) _r4_o)._fdata;
    _r3.i = _r1.i + 2;
    _r2_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o)[_r3.i];
    _r2.i = ((global::java.lang.String) _r2_o).equals((global::java.lang.Object) _r5_o) ? 1 : 0;
    if (_r2.i == 0) goto label28;
    _r0_o = ((global::org.xml.sax.helpers.AttributesImpl) _r4_o)._fdata;
    _r1.i = _r1.i + 3;
    _r0_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i];
    goto label8;
    label28:;
    _r1.i = _r1.i + 5;
    goto label5;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.AttributesImpl: java.lang.String getType(java.lang.String)]
}

public virtual global::System.Object getValue(global::java.lang.String n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.AttributesImpl: java.lang.String getValue(java.lang.String, java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    _r4_o = this;
    _r5_o = n1;
    _r6_o = n2;
    _r0.i = ((global::org.xml.sax.helpers.AttributesImpl) _r4_o)._flength;
    _r0.i = _r0.i * 5;
    _r1.i = 0;
    label5:;
    if (_r1.i < _r0.i) goto label9;
    _r0_o = null;
    label8:;
    return (global::java.lang.String) _r0_o;
    label9:;
    _r2_o = ((global::org.xml.sax.helpers.AttributesImpl) _r4_o)._fdata;
    _r2_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o)[_r1.i];
    _r2.i = ((global::java.lang.String) _r2_o).equals((global::java.lang.Object) _r5_o) ? 1 : 0;
    if (_r2.i == 0) goto label38;
    _r2_o = ((global::org.xml.sax.helpers.AttributesImpl) _r4_o)._fdata;
    _r3.i = _r1.i + 1;
    _r2_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o)[_r3.i];
    _r2.i = ((global::java.lang.String) _r2_o).equals((global::java.lang.Object) _r6_o) ? 1 : 0;
    if (_r2.i == 0) goto label38;
    _r0_o = ((global::org.xml.sax.helpers.AttributesImpl) _r4_o)._fdata;
    _r1.i = _r1.i + 4;
    _r0_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i];
    goto label8;
    label38:;
    _r1.i = _r1.i + 5;
    goto label5;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.AttributesImpl: java.lang.String getValue(java.lang.String, java.lang.String)]
}

public virtual global::System.Object getValue(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.AttributesImpl: java.lang.String getValue(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    _r4_o = this;
    _r5_o = n1;
    _r0.i = ((global::org.xml.sax.helpers.AttributesImpl) _r4_o)._flength;
    _r0.i = _r0.i * 5;
    _r1.i = 0;
    label5:;
    if (_r1.i < _r0.i) goto label9;
    _r0_o = null;
    label8:;
    return (global::java.lang.String) _r0_o;
    label9:;
    _r2_o = ((global::org.xml.sax.helpers.AttributesImpl) _r4_o)._fdata;
    _r3.i = _r1.i + 2;
    _r2_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o)[_r3.i];
    _r2.i = ((global::java.lang.String) _r2_o).equals((global::java.lang.Object) _r5_o) ? 1 : 0;
    if (_r2.i == 0) goto label28;
    _r0_o = ((global::org.xml.sax.helpers.AttributesImpl) _r4_o)._fdata;
    _r1.i = _r1.i + 4;
    _r0_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i];
    goto label8;
    label28:;
    _r1.i = _r1.i + 5;
    goto label5;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.AttributesImpl: java.lang.String getValue(java.lang.String)]
}

public virtual void clear(){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.AttributesImpl: void clear()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    _r4_o = this;
    _r3.i = 0;
    _r0_o = ((global::org.xml.sax.helpers.AttributesImpl) _r4_o)._fdata;
    if (_r0_o == null) goto label12;
    _r0.i = _r3.i;
    label6:;
    _r1.i = ((global::org.xml.sax.helpers.AttributesImpl) _r4_o)._flength;
    _r1.i = _r1.i * 5;
    if (_r0.i < _r1.i) goto label15;
    label12:;
    ((global::org.xml.sax.helpers.AttributesImpl) _r4_o)._flength = _r3.i;
    return;
    label15:;
    _r1_o = ((global::org.xml.sax.helpers.AttributesImpl) _r4_o)._fdata;
    _r2_o = null;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o)[_r0.i] = _r2_o;
    _r0.i = _r0.i + 1;
    goto label6;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.AttributesImpl: void clear()]
}

public virtual void setAttributes(global::org.xml.sax.Attributes n1){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.AttributesImpl: void setAttributes(org.xml.sax.Attributes)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    _r4_o = this;
    _r5_o = n1;
    ((global::org.xml.sax.helpers.AttributesImpl) _r4_o).clear();
    _r0.i = ((global::org.xml.sax.Attributes) _r5_o).getLength();
    ((global::org.xml.sax.helpers.AttributesImpl) _r4_o)._flength = _r0.i;
    _r0.i = ((global::org.xml.sax.helpers.AttributesImpl) _r4_o)._flength;
    if (_r0.i <= 0) goto label26;
    _r0.i = ((global::org.xml.sax.helpers.AttributesImpl) _r4_o)._flength;
    _r0.i = _r0.i * 5;
    _r0_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r0.i]);
    ((global::org.xml.sax.helpers.AttributesImpl) _r4_o)._fdata = (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o;
    _r0.i = 0;
    label22:;
    _r1.i = ((global::org.xml.sax.helpers.AttributesImpl) _r4_o)._flength;
    if (_r0.i < _r1.i) goto label27;
    label26:;
    return;
    label27:;
    _r1_o = ((global::org.xml.sax.helpers.AttributesImpl) _r4_o)._fdata;
    _r2.i = _r0.i * 5;
    _r3_o = ((global::org.xml.sax.Attributes) _r5_o).getURI((int) _r0.i);
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o)[_r2.i] = _r3_o;
    _r1_o = ((global::org.xml.sax.helpers.AttributesImpl) _r4_o)._fdata;
    _r2.i = _r0.i * 5;
    _r2.i = _r2.i + 1;
    _r3_o = ((global::org.xml.sax.Attributes) _r5_o).getLocalName((int) _r0.i);
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o)[_r2.i] = _r3_o;
    _r1_o = ((global::org.xml.sax.helpers.AttributesImpl) _r4_o)._fdata;
    _r2.i = _r0.i * 5;
    _r2.i = _r2.i + 2;
    _r3_o = ((global::org.xml.sax.Attributes) _r5_o).getQName((int) _r0.i);
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o)[_r2.i] = _r3_o;
    _r1_o = ((global::org.xml.sax.helpers.AttributesImpl) _r4_o)._fdata;
    _r2.i = _r0.i * 5;
    _r2.i = _r2.i + 3;
    _r3_o = ((global::org.xml.sax.Attributes) _r5_o).getType((int) _r0.i);
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o)[_r2.i] = _r3_o;
    _r1_o = ((global::org.xml.sax.helpers.AttributesImpl) _r4_o)._fdata;
    _r2.i = _r0.i * 5;
    _r2.i = _r2.i + 4;
    _r3_o = ((global::org.xml.sax.Attributes) _r5_o).getValue((int) _r0.i);
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o)[_r2.i] = _r3_o;
    _r0.i = _r0.i + 1;
    goto label22;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.AttributesImpl: void setAttributes(org.xml.sax.Attributes)]
}

public virtual void addAttribute(global::java.lang.String n1, global::java.lang.String n2, global::java.lang.String n3, global::java.lang.String n4, global::java.lang.String n5){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.AttributesImpl: void addAttribute(java.lang.String, java.lang.String, java.lang.String, java.lang.String, java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r4_o = n2;
    _r5_o = n3;
    _r6_o = n4;
    _r7_o = n5;
    _r0.i = ((global::org.xml.sax.helpers.AttributesImpl) _r2_o)._flength;
    _r0.i = _r0.i + 1;
    ((global::org.xml.sax.helpers.AttributesImpl) _r2_o).ensureCapacity((int) _r0.i);
    _r0_o = ((global::org.xml.sax.helpers.AttributesImpl) _r2_o)._fdata;
    _r1.i = ((global::org.xml.sax.helpers.AttributesImpl) _r2_o)._flength;
    _r1.i = _r1.i * 5;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r3_o;
    _r0_o = ((global::org.xml.sax.helpers.AttributesImpl) _r2_o)._fdata;
    _r1.i = ((global::org.xml.sax.helpers.AttributesImpl) _r2_o)._flength;
    _r1.i = _r1.i * 5;
    _r1.i = _r1.i + 1;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r4_o;
    _r0_o = ((global::org.xml.sax.helpers.AttributesImpl) _r2_o)._fdata;
    _r1.i = ((global::org.xml.sax.helpers.AttributesImpl) _r2_o)._flength;
    _r1.i = _r1.i * 5;
    _r1.i = _r1.i + 2;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r5_o;
    _r0_o = ((global::org.xml.sax.helpers.AttributesImpl) _r2_o)._fdata;
    _r1.i = ((global::org.xml.sax.helpers.AttributesImpl) _r2_o)._flength;
    _r1.i = _r1.i * 5;
    _r1.i = _r1.i + 3;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r6_o;
    _r0_o = ((global::org.xml.sax.helpers.AttributesImpl) _r2_o)._fdata;
    _r1.i = ((global::org.xml.sax.helpers.AttributesImpl) _r2_o)._flength;
    _r1.i = _r1.i * 5;
    _r1.i = _r1.i + 4;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r7_o;
    _r0.i = ((global::org.xml.sax.helpers.AttributesImpl) _r2_o)._flength;
    _r0.i = _r0.i + 1;
    ((global::org.xml.sax.helpers.AttributesImpl) _r2_o)._flength = _r0.i;
    return;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.AttributesImpl: void addAttribute(java.lang.String, java.lang.String, java.lang.String, java.lang.String, java.lang.String)]
}

public virtual void setAttribute(int n1, global::java.lang.String n2, global::java.lang.String n3, global::java.lang.String n4, global::java.lang.String n5, global::java.lang.String n6){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.AttributesImpl: void setAttribute(int, java.lang.String, java.lang.String, java.lang.String, java.lang.String, java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    global::System.Object _r8_o = null;
    _r2_o = this;
    _r3.i = n1;
    _r4_o = n2;
    _r5_o = n3;
    _r6_o = n4;
    _r7_o = n5;
    _r8_o = n6;
    if (_r3.i < 0) goto label45;
    _r0.i = ((global::org.xml.sax.helpers.AttributesImpl) _r2_o)._flength;
    if (_r3.i >= _r0.i) goto label45;
    _r0_o = ((global::org.xml.sax.helpers.AttributesImpl) _r2_o)._fdata;
    _r1.i = _r3.i * 5;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r4_o;
    _r0_o = ((global::org.xml.sax.helpers.AttributesImpl) _r2_o)._fdata;
    _r1.i = _r3.i * 5;
    _r1.i = _r1.i + 1;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r5_o;
    _r0_o = ((global::org.xml.sax.helpers.AttributesImpl) _r2_o)._fdata;
    _r1.i = _r3.i * 5;
    _r1.i = _r1.i + 2;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r6_o;
    _r0_o = ((global::org.xml.sax.helpers.AttributesImpl) _r2_o)._fdata;
    _r1.i = _r3.i * 5;
    _r1.i = _r1.i + 3;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r7_o;
    _r0_o = ((global::org.xml.sax.helpers.AttributesImpl) _r2_o)._fdata;
    _r1.i = _r3.i * 5;
    _r1.i = _r1.i + 4;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r8_o;
    label44:;
    return;
    label45:;
    ((global::org.xml.sax.helpers.AttributesImpl) _r2_o).badIndex((int) _r3.i);
    goto label44;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.AttributesImpl: void setAttribute(int, java.lang.String, java.lang.String, java.lang.String, java.lang.String, java.lang.String)]
}

public virtual void removeAttribute(int n1){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.AttributesImpl: void removeAttribute(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nElement _r8;
    _r7_o = this;
    _r8.i = n1;
    _r6.i = 1;
    _r5_o = null;
    if (_r8.i < 0) goto label71;
    _r0.i = ((global::org.xml.sax.helpers.AttributesImpl) _r7_o)._flength;
    if (_r8.i >= _r0.i) goto label71;
    _r0.i = ((global::org.xml.sax.helpers.AttributesImpl) _r7_o)._flength;
    _r0.i = _r0.i - _r6.i;
    if (_r8.i >= _r0.i) goto label32;
    _r0_o = ((global::org.xml.sax.helpers.AttributesImpl) _r7_o)._fdata;
    _r1.i = _r8.i + 1;
    _r1.i = _r1.i * 5;
    _r2_o = ((global::org.xml.sax.helpers.AttributesImpl) _r7_o)._fdata;
    _r3.i = _r8.i * 5;
    _r4.i = ((global::org.xml.sax.helpers.AttributesImpl) _r7_o)._flength;
    _r4.i = _r4.i - _r8.i;
    _r4.i = _r4.i - _r6.i;
    _r4.i = _r4.i * 5;
    global::java.lang.System.arraycopy((global::java.lang.Object) _r0_o, (int) _r1.i, (global::java.lang.Object) _r2_o, (int) _r3.i, (int) _r4.i);
    label32:;
    _r0.i = ((global::org.xml.sax.helpers.AttributesImpl) _r7_o)._flength;
    _r0.i = _r0.i - _r6.i;
    _r0.i = _r0.i * 5;
    _r1_o = ((global::org.xml.sax.helpers.AttributesImpl) _r7_o)._fdata;
    _r2.i = _r0.i + 1;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o)[_r0.i] = _r5_o;
    _r0_o = ((global::org.xml.sax.helpers.AttributesImpl) _r7_o)._fdata;
    _r1.i = _r2.i + 1;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r2.i] = _r5_o;
    _r0_o = ((global::org.xml.sax.helpers.AttributesImpl) _r7_o)._fdata;
    _r2.i = _r1.i + 1;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r5_o;
    _r0_o = ((global::org.xml.sax.helpers.AttributesImpl) _r7_o)._fdata;
    _r1.i = _r2.i + 1;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r2.i] = _r5_o;
    _r0_o = ((global::org.xml.sax.helpers.AttributesImpl) _r7_o)._fdata;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r5_o;
    _r0.i = ((global::org.xml.sax.helpers.AttributesImpl) _r7_o)._flength;
    _r0.i = _r0.i - _r6.i;
    ((global::org.xml.sax.helpers.AttributesImpl) _r7_o)._flength = _r0.i;
    label70:;
    return;
    label71:;
    ((global::org.xml.sax.helpers.AttributesImpl) _r7_o).badIndex((int) _r8.i);
    goto label70;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.AttributesImpl: void removeAttribute(int)]
}

public virtual void setURI(int n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.AttributesImpl: void setURI(int, java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    _r2_o = this;
    _r3.i = n1;
    _r4_o = n2;
    if (_r3.i < 0) goto label13;
    _r0.i = ((global::org.xml.sax.helpers.AttributesImpl) _r2_o)._flength;
    if (_r3.i >= _r0.i) goto label13;
    _r0_o = ((global::org.xml.sax.helpers.AttributesImpl) _r2_o)._fdata;
    _r1.i = _r3.i * 5;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r4_o;
    label12:;
    return;
    label13:;
    ((global::org.xml.sax.helpers.AttributesImpl) _r2_o).badIndex((int) _r3.i);
    goto label12;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.AttributesImpl: void setURI(int, java.lang.String)]
}

public virtual void setLocalName(int n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.AttributesImpl: void setLocalName(int, java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    _r2_o = this;
    _r3.i = n1;
    _r4_o = n2;
    if (_r3.i < 0) goto label15;
    _r0.i = ((global::org.xml.sax.helpers.AttributesImpl) _r2_o)._flength;
    if (_r3.i >= _r0.i) goto label15;
    _r0_o = ((global::org.xml.sax.helpers.AttributesImpl) _r2_o)._fdata;
    _r1.i = _r3.i * 5;
    _r1.i = _r1.i + 1;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r4_o;
    label14:;
    return;
    label15:;
    ((global::org.xml.sax.helpers.AttributesImpl) _r2_o).badIndex((int) _r3.i);
    goto label14;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.AttributesImpl: void setLocalName(int, java.lang.String)]
}

public virtual void setQName(int n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.AttributesImpl: void setQName(int, java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    _r2_o = this;
    _r3.i = n1;
    _r4_o = n2;
    if (_r3.i < 0) goto label15;
    _r0.i = ((global::org.xml.sax.helpers.AttributesImpl) _r2_o)._flength;
    if (_r3.i >= _r0.i) goto label15;
    _r0_o = ((global::org.xml.sax.helpers.AttributesImpl) _r2_o)._fdata;
    _r1.i = _r3.i * 5;
    _r1.i = _r1.i + 2;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r4_o;
    label14:;
    return;
    label15:;
    ((global::org.xml.sax.helpers.AttributesImpl) _r2_o).badIndex((int) _r3.i);
    goto label14;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.AttributesImpl: void setQName(int, java.lang.String)]
}

public virtual void setType(int n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.AttributesImpl: void setType(int, java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    _r2_o = this;
    _r3.i = n1;
    _r4_o = n2;
    if (_r3.i < 0) goto label15;
    _r0.i = ((global::org.xml.sax.helpers.AttributesImpl) _r2_o)._flength;
    if (_r3.i >= _r0.i) goto label15;
    _r0_o = ((global::org.xml.sax.helpers.AttributesImpl) _r2_o)._fdata;
    _r1.i = _r3.i * 5;
    _r1.i = _r1.i + 3;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r4_o;
    label14:;
    return;
    label15:;
    ((global::org.xml.sax.helpers.AttributesImpl) _r2_o).badIndex((int) _r3.i);
    goto label14;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.AttributesImpl: void setType(int, java.lang.String)]
}

public virtual void setValue(int n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.AttributesImpl: void setValue(int, java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    _r2_o = this;
    _r3.i = n1;
    _r4_o = n2;
    if (_r3.i < 0) goto label15;
    _r0.i = ((global::org.xml.sax.helpers.AttributesImpl) _r2_o)._flength;
    if (_r3.i >= _r0.i) goto label15;
    _r0_o = ((global::org.xml.sax.helpers.AttributesImpl) _r2_o)._fdata;
    _r1.i = _r3.i * 5;
    _r1.i = _r1.i + 4;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r4_o;
    label14:;
    return;
    label15:;
    ((global::org.xml.sax.helpers.AttributesImpl) _r2_o).badIndex((int) _r3.i);
    goto label14;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.AttributesImpl: void setValue(int, java.lang.String)]
}

private void ensureCapacity(int n1){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.AttributesImpl: void ensureCapacity(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    _r4_o = this;
    _r5.i = n1;
    _r3.i = 0;
    if (_r5.i > 0) goto label4;
    label3:;
    return;
    label4:;
    _r0_o = ((global::org.xml.sax.helpers.AttributesImpl) _r4_o)._fdata;
    if (_r0_o == null) goto label13;
    _r0_o = ((global::org.xml.sax.helpers.AttributesImpl) _r4_o)._fdata;
    _r0.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    if (_r0.i != 0) goto label37;
    label13:;
    _r0.i = 25;
    label15:;
    _r1.i = _r5.i * 5;
    if (_r0.i < _r1.i) goto label48;
    _r0_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r0.i]);
    _r1.i = ((global::org.xml.sax.helpers.AttributesImpl) _r4_o)._flength;
    if (_r1.i <= 0) goto label34;
    _r1_o = ((global::org.xml.sax.helpers.AttributesImpl) _r4_o)._fdata;
    _r2.i = ((global::org.xml.sax.helpers.AttributesImpl) _r4_o)._flength;
    _r2.i = _r2.i * 5;
    global::java.lang.System.arraycopy((global::java.lang.Object) _r1_o, (int) _r3.i, (global::java.lang.Object) _r0_o, (int) _r3.i, (int) _r2.i);
    label34:;
    ((global::org.xml.sax.helpers.AttributesImpl) _r4_o)._fdata = (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o;
    goto label3;
    label37:;
    _r0_o = ((global::org.xml.sax.helpers.AttributesImpl) _r4_o)._fdata;
    _r0.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    _r1.i = _r5.i * 5;
    if (_r0.i >= _r1.i) goto label3;
    _r0_o = ((global::org.xml.sax.helpers.AttributesImpl) _r4_o)._fdata;
    _r0.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    goto label15;
    label48:;
    _r0.i = _r0.i * 2;
    goto label15;
//XMLVM_END_WRAPPER[org.xml.sax.helpers.AttributesImpl: void ensureCapacity(int)]
}

private void badIndex(int n1){
//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.AttributesImpl: void badIndex(int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    _r2_o = this;
    _r3.i = n1;
    _r0_o = new global::java.lang.StringBuilder();
    // Value=Attempt to modify attribute at illegal index: 
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)65)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 58)), unchecked((char) unchecked((uint) 32))}));
    ((global::java.lang.StringBuilder) _r0_o).@this((global::java.lang.String) _r1_o);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((int) _r3.i);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    _r1_o = new global::java.lang.ArrayIndexOutOfBoundsException();
    ((global::java.lang.ArrayIndexOutOfBoundsException) _r1_o).@this((global::java.lang.String) _r0_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.ArrayIndexOutOfBoundsException) _r1_o);
//XMLVM_END_WRAPPER[org.xml.sax.helpers.AttributesImpl: void badIndex(int)]
}

//XMLVM_BEGIN_WRAPPER[org.xml.sax.helpers.AttributesImpl]
//XMLVM_END_WRAPPER[org.xml.sax.helpers.AttributesImpl]

} // end of class: AttributesImpl

} // end of namespace: org.xml.sax.helpers
