// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.components {
public class SpanLabel: global::com.codename1.ui.Container {
private global::com.codename1.ui.Label _ficon;

private global::com.codename1.ui.TextArea _ftext;

new public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.SpanLabel: void <init>()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    // Value=
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    ((global::com.codename1.components.SpanLabel) _r1_o).@this((global::java.lang.String) _r0_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.components.SpanLabel: void <init>()]
}

public void @this(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.SpanLabel: void <init>(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r3_o = this;
    _r4_o = n1;
    _r2.i = 0;
    ((global::com.codename1.ui.Container) _r3_o).@this();
    // Value=Container
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)67)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114))}));
    ((global::com.codename1.components.SpanLabel) _r3_o).setUIID((global::java.lang.String) _r0_o);
    _r0_o = new global::com.codename1.ui.layouts.BorderLayout();
    ((global::com.codename1.ui.layouts.BorderLayout) _r0_o).@this();
    ((global::com.codename1.components.SpanLabel) _r3_o).setLayout((global::com.codename1.ui.layouts.Layout) _r0_o);
    _r0_o = new global::com.codename1.ui.TextArea();
    _r1_o = ((global::com.codename1.components.SpanLabel) _r3_o).getUIManager();
    _r1_o = ((global::com.codename1.ui.plaf.UIManager) _r1_o).localize((global::java.lang.String) _r4_o, (global::java.lang.String) _r4_o);
    ((global::com.codename1.ui.TextArea) _r0_o).@this((global::java.lang.String) _r1_o);
    ((global::com.codename1.components.SpanLabel) _r3_o)._ftext = (global::com.codename1.ui.TextArea) _r0_o;
    _r0_o = ((global::com.codename1.components.SpanLabel) _r3_o)._ftext;
    // Value=Label
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)76)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 108))}));
    ((global::com.codename1.ui.TextArea) _r0_o).setUIID((global::java.lang.String) _r1_o);
    _r0_o = ((global::com.codename1.components.SpanLabel) _r3_o)._ftext;
    ((global::com.codename1.ui.TextArea) _r0_o).setEditable(0!=_r2.i);
    _r0_o = ((global::com.codename1.components.SpanLabel) _r3_o)._ftext;
    ((global::com.codename1.ui.TextArea) _r0_o).setFocusable(0!=_r2.i);
    _r0_o = new global::com.codename1.ui.Label();
    ((global::com.codename1.ui.Label) _r0_o).@this();
    ((global::com.codename1.components.SpanLabel) _r3_o)._ficon = (global::com.codename1.ui.Label) _r0_o;
    _r0_o = ((global::com.codename1.components.SpanLabel) _r3_o)._ficon;
    // Value=icon
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)105)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110))}));
    ((global::com.codename1.ui.Label) _r0_o).setUIID((global::java.lang.String) _r1_o);
    // Value=West
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)87)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 116))}));
    _r1_o = ((global::com.codename1.components.SpanLabel) _r3_o)._ficon;
    ((global::com.codename1.components.SpanLabel) _r3_o).addComponent((global::java.lang.Object) _r0_o, (global::com.codename1.ui.Component) _r1_o);
    // Value=Center
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)67)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114))}));
    _r1_o = ((global::com.codename1.components.SpanLabel) _r3_o)._ftext;
    ((global::com.codename1.components.SpanLabel) _r3_o).addComponent((global::java.lang.Object) _r0_o, (global::com.codename1.ui.Component) _r1_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.components.SpanLabel: void <init>(java.lang.String)]
}

public virtual void setTextUIID(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.SpanLabel: void setTextUIID(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::com.codename1.components.SpanLabel) _r1_o)._ftext;
    ((global::com.codename1.ui.TextArea) _r0_o).setUIID((global::java.lang.String) _r2_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.components.SpanLabel: void setTextUIID(java.lang.String)]
}

public virtual global::System.Object getTextUIID(){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.SpanLabel: java.lang.String getTextUIID()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.components.SpanLabel) _r1_o)._ftext;
    _r0_o = ((global::com.codename1.ui.TextArea) _r0_o).getUIID();
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.components.SpanLabel: java.lang.String getTextUIID()]
}

public virtual global::System.Object getTextUnselectedStyle(){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.SpanLabel: com.codename1.ui.plaf.Style getTextUnselectedStyle()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.components.SpanLabel) _r1_o)._ftext;
    _r0_o = ((global::com.codename1.ui.TextArea) _r0_o).getUnselectedStyle();
    return (global::com.codename1.ui.plaf.Style) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.components.SpanLabel: com.codename1.ui.plaf.Style getTextUnselectedStyle()]
}

public virtual void setTextUnselectedStyle(global::com.codename1.ui.plaf.Style n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.SpanLabel: void setTextUnselectedStyle(com.codename1.ui.plaf.Style)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::com.codename1.components.SpanLabel) _r1_o)._ftext;
    ((global::com.codename1.ui.TextArea) _r0_o).setUnselectedStyle((global::com.codename1.ui.plaf.Style) _r2_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.components.SpanLabel: void setTextUnselectedStyle(com.codename1.ui.plaf.Style)]
}

public virtual global::System.Object getTextSelectedStyle(){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.SpanLabel: com.codename1.ui.plaf.Style getTextSelectedStyle()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.components.SpanLabel) _r1_o)._ftext;
    _r0_o = ((global::com.codename1.ui.TextArea) _r0_o).getSelectedStyle();
    return (global::com.codename1.ui.plaf.Style) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.components.SpanLabel: com.codename1.ui.plaf.Style getTextSelectedStyle()]
}

public virtual void setTextSelectedStyle(global::com.codename1.ui.plaf.Style n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.SpanLabel: void setTextSelectedStyle(com.codename1.ui.plaf.Style)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::com.codename1.components.SpanLabel) _r1_o)._ftext;
    ((global::com.codename1.ui.TextArea) _r0_o).setSelectedStyle((global::com.codename1.ui.plaf.Style) _r2_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.components.SpanLabel: void setTextSelectedStyle(com.codename1.ui.plaf.Style)]
}

public virtual void setIconUIID(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.SpanLabel: void setIconUIID(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::com.codename1.components.SpanLabel) _r1_o)._ficon;
    ((global::com.codename1.ui.Label) _r0_o).setUIID((global::java.lang.String) _r2_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.components.SpanLabel: void setIconUIID(java.lang.String)]
}

public virtual global::System.Object getIconUIID(){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.SpanLabel: java.lang.String getIconUIID()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.components.SpanLabel) _r1_o)._ficon;
    _r0_o = ((global::com.codename1.ui.Label) _r0_o).getUIID();
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.components.SpanLabel: java.lang.String getIconUIID()]
}

public virtual void setText(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.SpanLabel: void setText(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r0_o = ((global::com.codename1.components.SpanLabel) _r2_o)._ftext;
    _r1_o = ((global::com.codename1.components.SpanLabel) _r2_o).getUIManager();
    _r1_o = ((global::com.codename1.ui.plaf.UIManager) _r1_o).localize((global::java.lang.String) _r3_o, (global::java.lang.String) _r3_o);
    ((global::com.codename1.ui.TextArea) _r0_o).setText((global::java.lang.String) _r1_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.components.SpanLabel: void setText(java.lang.String)]
}

public virtual void setIcon(global::com.codename1.ui.Image n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.SpanLabel: void setIcon(com.codename1.ui.Image)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::com.codename1.components.SpanLabel) _r1_o)._ficon;
    ((global::com.codename1.ui.Label) _r0_o).setIcon((global::com.codename1.ui.Image) _r2_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.components.SpanLabel: void setIcon(com.codename1.ui.Image)]
}

public virtual global::System.Object getText(){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.SpanLabel: java.lang.String getText()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.components.SpanLabel) _r1_o)._ftext;
    _r0_o = ((global::com.codename1.ui.TextArea) _r0_o).getText();
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.components.SpanLabel: java.lang.String getText()]
}

public virtual void setTextBlockAlign(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.SpanLabel: void setTextBlockAlign(int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    _r2_o = this;
    _r3.i = n1;
    switch (_r3.i) {
    case 1: goto label37;
    case 3: goto label37;
    case 4: goto label37;
    }
    _r0_o = ((global::com.codename1.components.SpanLabel) _r2_o)._ftext;
    _r0_o = ((global::com.codename1.ui.TextArea) _r0_o).getParent();
    if (_r0_o == _r2_o) goto label36;
    _r0_o = ((global::com.codename1.components.SpanLabel) _r2_o)._ftext;
    _r0_o = ((global::com.codename1.ui.TextArea) _r0_o).getParent();
    ((global::com.codename1.components.SpanLabel) _r2_o).removeComponent((global::com.codename1.ui.Component) _r0_o);
    _r0_o = ((global::com.codename1.components.SpanLabel) _r2_o)._ftext;
    _r0_o = ((global::com.codename1.ui.TextArea) _r0_o).getParent();
    ((global::com.codename1.ui.Container) _r0_o).removeAll();
    // Value=Center
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)67)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114))}));
    _r1_o = ((global::com.codename1.components.SpanLabel) _r2_o)._ftext;
    ((global::com.codename1.components.SpanLabel) _r2_o).addComponent((global::java.lang.Object) _r0_o, (global::com.codename1.ui.Component) _r1_o);
    label36:;
    return;
    label37:;
    ((global::com.codename1.components.SpanLabel) _r2_o).wrapText((int) _r3.i);
    goto label36;
//XMLVM_END_WRAPPER[com.codename1.components.SpanLabel: void setTextBlockAlign(int)]
}

public virtual int getTextBlockAlign(){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.SpanLabel: int getTextBlockAlign()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.components.SpanLabel) _r1_o)._ftext;
    _r0_o = ((global::com.codename1.ui.TextArea) _r0_o).getParent();
    if (_r0_o != _r1_o) goto label10;
    _r0.i = -1;
    label9:;
    return _r0.i;
    label10:;
    _r0_o = ((global::com.codename1.components.SpanLabel) _r1_o)._ftext;
    _r0_o = ((global::com.codename1.ui.TextArea) _r0_o).getParent();
    _r1_o = ((global::com.codename1.ui.Container) _r0_o).getLayout();
    _r0.i = ((global::com.codename1.ui.layouts.FlowLayout) _r1_o).getAlign();
    goto label9;
//XMLVM_END_WRAPPER[com.codename1.components.SpanLabel: int getTextBlockAlign()]
}

private void wrapText(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.SpanLabel: void wrapText(int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    _r2_o = this;
    _r3.i = n1;
    _r1_o = ((global::com.codename1.components.SpanLabel) _r2_o)._ftext;
    _r0_o = ((global::com.codename1.ui.TextArea) _r1_o).getParent();
    if (_r0_o != _r2_o) goto label34;
    _r1_o = ((global::com.codename1.components.SpanLabel) _r2_o)._ftext;
    ((global::com.codename1.ui.Container) _r0_o).removeComponent((global::com.codename1.ui.Component) _r1_o);
    _r0_o = new global::com.codename1.ui.Container();
    _r1_o = new global::com.codename1.ui.layouts.FlowLayout();
    ((global::com.codename1.ui.layouts.FlowLayout) _r1_o).@this((int) _r3.i);
    ((global::com.codename1.ui.Container) _r0_o).@this((global::com.codename1.ui.layouts.Layout) _r1_o);
    _r1_o = ((global::com.codename1.components.SpanLabel) _r2_o)._ftext;
    ((global::com.codename1.ui.Container) _r0_o).addComponent((global::com.codename1.ui.Component) _r1_o);
    // Value=Center
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)67)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114))}));
    ((global::com.codename1.components.SpanLabel) _r2_o).addComponent((global::java.lang.Object) _r1_o, (global::com.codename1.ui.Component) _r0_o);
    label33:;
    return;
    label34:;
    _r2_o = ((global::com.codename1.ui.Container) _r0_o).getLayout();
    ((global::com.codename1.ui.layouts.FlowLayout) _r2_o).setAlign((int) _r3.i);
    goto label33;
//XMLVM_END_WRAPPER[com.codename1.components.SpanLabel: void wrapText(int)]
}

public virtual global::System.Object getIcon(){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.SpanLabel: com.codename1.ui.Image getIcon()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.components.SpanLabel) _r1_o)._ficon;
    _r0_o = ((global::com.codename1.ui.Label) _r0_o).getIcon();
    return (global::com.codename1.ui.Image) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.components.SpanLabel: com.codename1.ui.Image getIcon()]
}

public virtual void setIconPosition(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.SpanLabel: void setIconPosition(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::com.codename1.components.SpanLabel) _r1_o)._ficon;
    ((global::com.codename1.components.SpanLabel) _r1_o).removeComponent((global::com.codename1.ui.Component) _r0_o);
    _r0_o = ((global::com.codename1.components.SpanLabel) _r1_o)._ficon;
    ((global::com.codename1.components.SpanLabel) _r1_o).addComponent((global::java.lang.Object) _r2_o, (global::com.codename1.ui.Component) _r0_o);
    ((global::com.codename1.components.SpanLabel) _r1_o).revalidate();
    return;
//XMLVM_END_WRAPPER[com.codename1.components.SpanLabel: void setIconPosition(java.lang.String)]
}

public virtual global::System.Object getIconPosition(){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.SpanLabel: java.lang.String getIconPosition()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = ((global::com.codename1.components.SpanLabel) _r2_o).getLayout();
    _r1_o = ((global::com.codename1.components.SpanLabel) _r2_o)._ficon;
    _r2_o = ((global::com.codename1.ui.layouts.Layout) _r0_o).getComponentConstraint((global::com.codename1.ui.Component) _r1_o);
    return (global::java.lang.String) _r2_o;
//XMLVM_END_WRAPPER[com.codename1.components.SpanLabel: java.lang.String getIconPosition()]
}

public override global::System.Object getPropertyNames(){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.SpanLabel: java.lang.String[] getPropertyNames()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r3_o = this;
    _r0.i = 5;
    _r0_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r0.i]);
    _r1.i = 0;
    // Value=text
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 116))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r2_o;
    _r1.i = 1;
    // Value=icon
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)105)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r2_o;
    _r1.i = 2;
    // Value=iconPosition
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)105)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 80)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r2_o;
    _r1.i = 3;
    // Value=textUiid
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 85)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 100))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r2_o;
    _r1.i = 4;
    // Value=iconUiid
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)105)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 85)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 100))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r2_o;
    return (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.components.SpanLabel: java.lang.String[] getPropertyNames()]
}

public override global::System.Object getPropertyTypes(){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.SpanLabel: java.lang.Class[] getPropertyTypes()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r4_o = this;
    _r3_o = global::org.xmlvm._nTIB.getClass(typeof(global::java.lang.String));
    _r0.i = 5;
    _r0_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r0.i]);
    _r1.i = 0;
    _r2_o = global::org.xmlvm._nTIB.getClass(typeof(global::java.lang.String));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r3_o;
    _r1.i = 1;
    _r2_o = global::org.xmlvm._nTIB.getClass(typeof(global::com.codename1.ui.Image));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r2_o;
    _r1.i = 2;
    _r2_o = global::org.xmlvm._nTIB.getClass(typeof(global::java.lang.String));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r3_o;
    _r1.i = 3;
    _r2_o = global::org.xmlvm._nTIB.getClass(typeof(global::java.lang.String));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r3_o;
    _r1.i = 4;
    _r2_o = global::org.xmlvm._nTIB.getClass(typeof(global::java.lang.String));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r3_o;
    return (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.components.SpanLabel: java.lang.Class[] getPropertyTypes()]
}

public override global::System.Object getPropertyTypeNames(){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.SpanLabel: java.lang.String[] getPropertyTypeNames()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r4_o = this;
    // Value=String
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)83)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 103))}));
    _r0.i = 5;
    _r0_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r0.i]);
    _r1.i = 0;
    // Value=String
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)83)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 103))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r3_o;
    _r1.i = 1;
    // Value=Image
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)73)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 101))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r2_o;
    _r1.i = 2;
    // Value=String
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)83)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 103))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r3_o;
    _r1.i = 3;
    // Value=String
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)83)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 103))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r3_o;
    _r1.i = 4;
    // Value=String
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)83)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 103))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r3_o;
    return (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.components.SpanLabel: java.lang.String[] getPropertyTypeNames()]
}

public override global::System.Object getPropertyValue(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.SpanLabel: java.lang.Object getPropertyValue(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    // Value=text
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 116))}));
    _r0.i = ((global::java.lang.String) _r2_o).equals((global::java.lang.Object) _r0_o) ? 1 : 0;
    if (_r0.i == 0) goto label13;
    _r0_o = ((global::com.codename1.components.SpanLabel) _r1_o).getText();
    label12:;
    return (global::java.lang.Object) _r0_o;
    label13:;
    // Value=icon
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)105)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110))}));
    _r0.i = ((global::java.lang.String) _r2_o).equals((global::java.lang.Object) _r0_o) ? 1 : 0;
    if (_r0.i == 0) goto label26;
    _r0_o = ((global::com.codename1.components.SpanLabel) _r1_o).getIcon();
    goto label12;
    label26:;
    // Value=iconPosition
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)105)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 80)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110))}));
    _r0.i = ((global::java.lang.String) _r2_o).equals((global::java.lang.Object) _r0_o) ? 1 : 0;
    if (_r0.i == 0) goto label39;
    _r0_o = ((global::com.codename1.components.SpanLabel) _r1_o).getIconPosition();
    goto label12;
    label39:;
    // Value=textUiid
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 85)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 100))}));
    _r0.i = ((global::java.lang.String) _r2_o).equals((global::java.lang.Object) _r0_o) ? 1 : 0;
    if (_r0.i == 0) goto label52;
    _r0_o = ((global::com.codename1.components.SpanLabel) _r1_o).getTextUIID();
    goto label12;
    label52:;
    // Value=iconUiid
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)105)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 85)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 100))}));
    _r0.i = ((global::java.lang.String) _r2_o).equals((global::java.lang.Object) _r0_o) ? 1 : 0;
    if (_r0.i == 0) goto label65;
    _r0_o = ((global::com.codename1.components.SpanLabel) _r1_o).getIconUIID();
    goto label12;
    label65:;
    _r0_o = null;
    goto label12;
//XMLVM_END_WRAPPER[com.codename1.components.SpanLabel: java.lang.Object getPropertyValue(java.lang.String)]
}

public override global::System.Object setPropertyValue(global::java.lang.String n1, global::java.lang.Object n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.SpanLabel: java.lang.String setPropertyValue(java.lang.String, java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r4_o = n2;
    _r1_o = null;
    // Value=text
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 116))}));
    _r0.i = ((global::java.lang.String) _r3_o).equals((global::java.lang.Object) _r0_o) ? 1 : 0;
    if (_r0.i == 0) goto label16;
    ((global::com.codename1.components.SpanLabel) _r2_o).setText((global::java.lang.String) _r4_o);
    _r0_o = _r1_o;
    label15:;
    return (global::java.lang.String) _r0_o;
    label16:;
    // Value=icon
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)105)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110))}));
    _r0.i = ((global::java.lang.String) _r3_o).equals((global::java.lang.Object) _r0_o) ? 1 : 0;
    if (_r0.i == 0) goto label31;
    ((global::com.codename1.components.SpanLabel) _r2_o).setIcon((global::com.codename1.ui.Image) _r4_o);
    _r0_o = _r1_o;
    goto label15;
    label31:;
    // Value=iconPosition
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)105)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 80)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110))}));
    _r0.i = ((global::java.lang.String) _r3_o).equals((global::java.lang.Object) _r0_o) ? 1 : 0;
    if (_r0.i == 0) goto label46;
    ((global::com.codename1.components.SpanLabel) _r2_o).setIconPosition((global::java.lang.String) _r4_o);
    _r0_o = _r1_o;
    goto label15;
    label46:;
    // Value=textUiid
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 85)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 100))}));
    _r0.i = ((global::java.lang.String) _r3_o).equals((global::java.lang.Object) _r0_o) ? 1 : 0;
    if (_r0.i == 0) goto label61;
    ((global::com.codename1.components.SpanLabel) _r2_o).setTextUIID((global::java.lang.String) _r4_o);
    _r0_o = _r1_o;
    goto label15;
    label61:;
    // Value=iconUiid
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)105)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 85)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 100))}));
    _r0.i = ((global::java.lang.String) _r3_o).equals((global::java.lang.Object) _r0_o) ? 1 : 0;
    if (_r0.i == 0) goto label76;
    ((global::com.codename1.components.SpanLabel) _r2_o).setIconUIID((global::java.lang.String) _r4_o);
    _r0_o = _r1_o;
    goto label15;
    label76:;
    _r0_o = base.setPropertyValue((global::java.lang.String) _r3_o, (global::java.lang.Object) _r4_o);
    goto label15;
//XMLVM_END_WRAPPER[com.codename1.components.SpanLabel: java.lang.String setPropertyValue(java.lang.String, java.lang.Object)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.components.SpanLabel]
//XMLVM_END_WRAPPER[com.codename1.components.SpanLabel]

} // end of class: SpanLabel

} // end of namespace: com.codename1.components
