// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace gnu.xml.dom {
public class DomEntity: global::gnu.xml.dom.DomExtern,global::org.w3c.dom.Entity {
private global::java.lang.String _fnotation;

new public static short _fELEMENT_1NODE = org.w3c.dom._iNode._fELEMENT_1NODE;

new public static short _fATTRIBUTE_1NODE = org.w3c.dom._iNode._fATTRIBUTE_1NODE;

new public static short _fTEXT_1NODE = org.w3c.dom._iNode._fTEXT_1NODE;

new public static short _fCDATA_1SECTION_1NODE = org.w3c.dom._iNode._fCDATA_1SECTION_1NODE;

new public static short _fENTITY_1REFERENCE_1NODE = org.w3c.dom._iNode._fENTITY_1REFERENCE_1NODE;

new public static short _fENTITY_1NODE = org.w3c.dom._iNode._fENTITY_1NODE;

new public static short _fPROCESSING_1INSTRUCTION_1NODE = org.w3c.dom._iNode._fPROCESSING_1INSTRUCTION_1NODE;

new public static short _fCOMMENT_1NODE = org.w3c.dom._iNode._fCOMMENT_1NODE;

new public static short _fDOCUMENT_1NODE = org.w3c.dom._iNode._fDOCUMENT_1NODE;

new public static short _fDOCUMENT_1TYPE_1NODE = org.w3c.dom._iNode._fDOCUMENT_1TYPE_1NODE;

new public static short _fDOCUMENT_1FRAGMENT_1NODE = org.w3c.dom._iNode._fDOCUMENT_1FRAGMENT_1NODE;

new public static short _fNOTATION_1NODE = org.w3c.dom._iNode._fNOTATION_1NODE;

new public static short _fDOCUMENT_1POSITION_1DISCONNECTED = org.w3c.dom._iNode._fDOCUMENT_1POSITION_1DISCONNECTED;

new public static short _fDOCUMENT_1POSITION_1PRECEDING = org.w3c.dom._iNode._fDOCUMENT_1POSITION_1PRECEDING;

new public static short _fDOCUMENT_1POSITION_1FOLLOWING = org.w3c.dom._iNode._fDOCUMENT_1POSITION_1FOLLOWING;

new public static short _fDOCUMENT_1POSITION_1CONTAINS = org.w3c.dom._iNode._fDOCUMENT_1POSITION_1CONTAINS;

new public static short _fDOCUMENT_1POSITION_1CONTAINED_1BY = org.w3c.dom._iNode._fDOCUMENT_1POSITION_1CONTAINED_1BY;

new public static short _fDOCUMENT_1POSITION_1IMPLEMENTATION_1SPECIFIC = org.w3c.dom._iNode._fDOCUMENT_1POSITION_1IMPLEMENTATION_1SPECIFIC;

public void @this(global::gnu.xml.dom.DomDocument n1, global::java.lang.String n2, global::java.lang.String n3, global::java.lang.String n4, global::java.lang.String n5){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomEntity: void <init>(gnu.xml.dom.DomDocument, java.lang.String, java.lang.String, java.lang.String, java.lang.String)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    global::System.Object _r8_o = null;
    global::System.Object _r9_o = null;
    global::System.Object _r10_o = null;
    global::System.Object _r11_o = null;
    _r6_o = this;
    _r7_o = n1;
    _r8_o = n2;
    _r9_o = n3;
    _r10_o = n4;
    _r11_o = n5;
    _r1.i = 6;
    _r0_o = _r6_o;
    _r2_o = _r7_o;
    _r3_o = _r8_o;
    _r4_o = _r9_o;
    _r5_o = _r10_o;
    ((global::gnu.xml.dom.DomExtern) _r0_o).@this((short) _r1.i, (global::gnu.xml.dom.DomDocument) _r2_o, (global::java.lang.String) _r3_o, (global::java.lang.String) _r4_o, (global::java.lang.String) _r5_o);
    ((global::gnu.xml.dom.DomEntity) _r6_o)._fnotation = (global::java.lang.String) _r11_o;
    ((global::gnu.xml.dom.DomEntity) _r6_o).makeReadonly();
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomEntity: void <init>(gnu.xml.dom.DomDocument, java.lang.String, java.lang.String, java.lang.String, java.lang.String)]
}

public virtual global::System.Object getNotationName(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomEntity: java.lang.String getNotationName()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::gnu.xml.dom.DomEntity) _r1_o)._fnotation;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomEntity: java.lang.String getNotationName()]
}

public virtual global::System.Object getInputEncoding(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomEntity: java.lang.String getInputEncoding()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = null;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomEntity: java.lang.String getInputEncoding()]
}

public virtual global::System.Object getXmlEncoding(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomEntity: java.lang.String getXmlEncoding()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = null;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomEntity: java.lang.String getXmlEncoding()]
}

public virtual global::System.Object getXmlVersion(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomEntity: java.lang.String getXmlVersion()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = null;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomEntity: java.lang.String getXmlVersion()]
}

public override global::System.Object getBaseURI(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomEntity: java.lang.String getBaseURI()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::gnu.xml.dom.DomEntity) _r1_o).getSystemId();
    if (_r0_o != null) goto label12;
    _r0_o = ((global::gnu.xml.dom.DomEntity) _r1_o)._fowner;
    _r0_o = ((global::gnu.xml.dom.DomDocument) _r0_o).getBaseURI();
    label12:;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomEntity: java.lang.String getBaseURI()]
}

//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomEntity]
//XMLVM_END_WRAPPER[gnu.xml.dom.DomEntity]

} // end of class: DomEntity

} // end of namespace: gnu.xml.dom
