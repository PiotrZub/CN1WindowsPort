// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace gnu.xml.dom {
public class DomCDATASection: global::gnu.xml.dom.DomText,global::org.w3c.dom.CDATASection {
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

new public void @this(global::gnu.xml.dom.DomDocument n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomCDATASection: void <init>(gnu.xml.dom.DomDocument, java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r0.i = 4;
    ((global::gnu.xml.dom.DomText) _r1_o).@this((short) _r0.i, (global::gnu.xml.dom.DomDocument) _r2_o, (global::java.lang.String) _r3_o);
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomCDATASection: void <init>(gnu.xml.dom.DomDocument, java.lang.String)]
}

new public void @this(global::gnu.xml.dom.DomDocument n1, global::org.xmlvm._nArrayAdapter<char> n2, int n3, int n4){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomCDATASection: void <init>(gnu.xml.dom.DomDocument, char[], int, int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nElement _r9;
    global::org.xmlvm._nElement _r10;
    _r6_o = this;
    _r7_o = n1;
    _r8_o = n2;
    _r9.i = n3;
    _r10.i = n4;
    _r1.i = 4;
    _r0_o = _r6_o;
    _r2_o = _r7_o;
    _r3_o = _r8_o;
    _r4.i = _r9.i;
    _r5.i = _r10.i;
    ((global::gnu.xml.dom.DomText) _r0_o).@this((short) _r1.i, (global::gnu.xml.dom.DomDocument) _r2_o, (global::org.xmlvm._nArrayAdapter<char>) _r3_o, (int) _r4.i, (int) _r5.i);
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomCDATASection: void <init>(gnu.xml.dom.DomDocument, char[], int, int)]
}

public override global::System.Object getNodeName(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomCDATASection: java.lang.String getNodeName()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    // Value=#cdata-section
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)35)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110))}));
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomCDATASection: java.lang.String getNodeName()]
}

//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomCDATASection]
//XMLVM_END_WRAPPER[gnu.xml.dom.DomCDATASection]

} // end of class: DomCDATASection

} // end of namespace: gnu.xml.dom
