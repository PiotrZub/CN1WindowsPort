// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace gnu.xml.dom.html2 {
public class DomHTMLButtonElement: global::gnu.xml.dom.html2.DomHTMLElement,global::org.w3c.dom.html2.HTMLButtonElement {
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

new public void @this(global::gnu.xml.dom.html2.DomHTMLDocument n1, global::java.lang.String n2, global::java.lang.String n3){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLButtonElement: void <init>(gnu.xml.dom.html2.DomHTMLDocument, java.lang.String, java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    _r3_o = n3;
    ((global::gnu.xml.dom.html2.DomHTMLElement) _r0_o).@this((global::gnu.xml.dom.html2.DomHTMLDocument) _r1_o, (global::java.lang.String) _r2_o, (global::java.lang.String) _r3_o);
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLButtonElement: void <init>(gnu.xml.dom.html2.DomHTMLDocument, java.lang.String, java.lang.String)]
}

public virtual global::System.Object getForm(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLButtonElement: org.w3c.dom.html2.HTMLFormElement getForm()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    // Value=form
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)102)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 109))}));
    _r1_o = ((global::gnu.xml.dom.html2.DomHTMLButtonElement) _r1_o).getParentElement((global::java.lang.String) _r0_o);
    return (global::org.w3c.dom.html2.HTMLFormElement) _r1_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLButtonElement: org.w3c.dom.html2.HTMLFormElement getForm()]
}

public virtual global::System.Object getAccessKey(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLButtonElement: java.lang.String getAccessKey()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    // Value=accesskey
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)97)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 107)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 121))}));
    _r0_o = ((global::gnu.xml.dom.html2.DomHTMLButtonElement) _r1_o).getHTMLAttribute((global::java.lang.String) _r0_o);
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLButtonElement: java.lang.String getAccessKey()]
}

public virtual void setAccessKey(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLButtonElement: void setAccessKey(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    // Value=accesskey
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)97)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 107)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 121))}));
    ((global::gnu.xml.dom.html2.DomHTMLButtonElement) _r1_o).setHTMLAttribute((global::java.lang.String) _r0_o, (global::java.lang.String) _r2_o);
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLButtonElement: void setAccessKey(java.lang.String)]
}

public virtual bool getDisabled(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLButtonElement: boolean getDisabled()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    // Value=disabled
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)100)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100))}));
    _r0.i = ((global::gnu.xml.dom.html2.DomHTMLButtonElement) _r1_o).getBooleanHTMLAttribute((global::java.lang.String) _r0_o) ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLButtonElement: boolean getDisabled()]
}

public virtual void setDisabled(bool n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLButtonElement: void setDisabled(boolean)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r1_o = this;
    _r2.i = n1 ? 1 : 0;
    // Value=disabled
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)100)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100))}));
    ((global::gnu.xml.dom.html2.DomHTMLButtonElement) _r1_o).setBooleanHTMLAttribute((global::java.lang.String) _r0_o, 0!=_r2.i);
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLButtonElement: void setDisabled(boolean)]
}

public virtual global::System.Object getName(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLButtonElement: java.lang.String getName()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    // Value=name
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)110)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101))}));
    _r0_o = ((global::gnu.xml.dom.html2.DomHTMLButtonElement) _r1_o).getHTMLAttribute((global::java.lang.String) _r0_o);
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLButtonElement: java.lang.String getName()]
}

public virtual void setName(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLButtonElement: void setName(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    // Value=name
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)110)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101))}));
    ((global::gnu.xml.dom.html2.DomHTMLButtonElement) _r1_o).setHTMLAttribute((global::java.lang.String) _r0_o, (global::java.lang.String) _r2_o);
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLButtonElement: void setName(java.lang.String)]
}

public virtual int getTabIndex(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLButtonElement: int getTabIndex()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    // Value=tabindex
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)116)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 120))}));
    _r0.i = ((global::gnu.xml.dom.html2.DomHTMLButtonElement) _r1_o).getIntHTMLAttribute((global::java.lang.String) _r0_o);
    return _r0.i;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLButtonElement: int getTabIndex()]
}

public virtual void setTabIndex(int n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLButtonElement: void setTabIndex(int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r1_o = this;
    _r2.i = n1;
    // Value=tabindex
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)116)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 120))}));
    ((global::gnu.xml.dom.html2.DomHTMLButtonElement) _r1_o).setIntHTMLAttribute((global::java.lang.String) _r0_o, (int) _r2.i);
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLButtonElement: void setTabIndex(int)]
}

public virtual global::System.Object getType(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLButtonElement: java.lang.String getType()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    // Value=type
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)116)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 101))}));
    _r0_o = ((global::gnu.xml.dom.html2.DomHTMLButtonElement) _r1_o).getHTMLAttribute((global::java.lang.String) _r0_o);
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLButtonElement: java.lang.String getType()]
}

public virtual global::System.Object getValue(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLButtonElement: java.lang.String getValue()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    // Value=value
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)118)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 101))}));
    _r0_o = ((global::gnu.xml.dom.html2.DomHTMLButtonElement) _r1_o).getHTMLAttribute((global::java.lang.String) _r0_o);
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLButtonElement: java.lang.String getValue()]
}

public virtual void setValue(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLButtonElement: void setValue(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    // Value=value
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)118)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 101))}));
    ((global::gnu.xml.dom.html2.DomHTMLButtonElement) _r1_o).setHTMLAttribute((global::java.lang.String) _r0_o, (global::java.lang.String) _r2_o);
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLButtonElement: void setValue(java.lang.String)]
}

//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.html2.DomHTMLButtonElement]
//XMLVM_END_WRAPPER[gnu.xml.dom.html2.DomHTMLButtonElement]

} // end of class: DomHTMLButtonElement

} // end of namespace: gnu.xml.dom.html2
