// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.l10n {
public class L10NManager: global::java.lang.Object {
private global::java.lang.String _flanguage;

private global::java.lang.String _flocale;

public void @this(global::java.lang.String n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.l10n.L10NManager: void <init>(java.lang.String, java.lang.String)]
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
    ((global::com.codename1.l10n.L10NManager) _r0_o)._flanguage = (global::java.lang.String) _r1_o;
    ((global::com.codename1.l10n.L10NManager) _r0_o)._flocale = (global::java.lang.String) _r2_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.l10n.L10NManager: void <init>(java.lang.String, java.lang.String)]
}

public virtual global::System.Object getLanguage(){
//XMLVM_BEGIN_WRAPPER[com.codename1.l10n.L10NManager: java.lang.String getLanguage()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.l10n.L10NManager) _r1_o)._flanguage;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.l10n.L10NManager: java.lang.String getLanguage()]
}

public virtual void setLocale(global::java.lang.String n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.l10n.L10NManager: void setLocale(java.lang.String, java.lang.String)]
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
    ((global::com.codename1.l10n.L10NManager) _r0_o)._flanguage = (global::java.lang.String) _r2_o;
    ((global::com.codename1.l10n.L10NManager) _r0_o)._flocale = (global::java.lang.String) _r1_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.l10n.L10NManager: void setLocale(java.lang.String, java.lang.String)]
}

public virtual global::System.Object format(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.l10n.L10NManager: java.lang.String format(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r3.i = n1;
    _r0_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r0_o).@this();
    // Value=
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((int) _r3.i);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.l10n.L10NManager: java.lang.String format(int)]
}

public virtual global::System.Object format(double n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.l10n.L10NManager: java.lang.String format(double)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r3.d = n1;
    _r0_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r0_o).@this();
    // Value=
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((double) _r3.d);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.l10n.L10NManager: java.lang.String format(double)]
}

public virtual global::System.Object formatCurrency(double n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.l10n.L10NManager: java.lang.String formatCurrency(double)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r3.d = n1;
    _r0_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r0_o).@this();
    // Value=
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((double) _r3.d);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.l10n.L10NManager: java.lang.String formatCurrency(double)]
}

public virtual global::System.Object getCurrencySymbol(){
//XMLVM_BEGIN_WRAPPER[com.codename1.l10n.L10NManager: java.lang.String getCurrencySymbol()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    // Value=$
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)36))}));
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.l10n.L10NManager: java.lang.String getCurrencySymbol()]
}

public virtual global::System.Object formatDateLongStyle(global::java.util.Date n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.l10n.L10NManager: java.lang.String formatDateLongStyle(java.util.Date)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::java.util.Date) _r2_o).toString();
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.l10n.L10NManager: java.lang.String formatDateLongStyle(java.util.Date)]
}

public virtual global::System.Object formatDateShortStyle(global::java.util.Date n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.l10n.L10NManager: java.lang.String formatDateShortStyle(java.util.Date)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::java.util.Date) _r2_o).toString();
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.l10n.L10NManager: java.lang.String formatDateShortStyle(java.util.Date)]
}

public virtual global::System.Object formatDateTime(global::java.util.Date n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.l10n.L10NManager: java.lang.String formatDateTime(java.util.Date)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::java.util.Date) _r2_o).toString();
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.l10n.L10NManager: java.lang.String formatDateTime(java.util.Date)]
}

public virtual global::System.Object formatDateTimeMedium(global::java.util.Date n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.l10n.L10NManager: java.lang.String formatDateTimeMedium(java.util.Date)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::java.util.Date) _r2_o).toString();
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.l10n.L10NManager: java.lang.String formatDateTimeMedium(java.util.Date)]
}

public virtual global::System.Object formatDateTimeShort(global::java.util.Date n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.l10n.L10NManager: java.lang.String formatDateTimeShort(java.util.Date)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::java.util.Date) _r2_o).toString();
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.l10n.L10NManager: java.lang.String formatDateTimeShort(java.util.Date)]
}

public virtual bool isRTLLocale(){
//XMLVM_BEGIN_WRAPPER[com.codename1.l10n.L10NManager: boolean isRTLLocale()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    // Value=iw
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)105)), unchecked((char) unchecked((uint) 119))}));
    _r1_o = ((global::com.codename1.l10n.L10NManager) _r2_o)._flanguage;
    _r0.i = ((global::java.lang.String) _r0_o).equals((global::java.lang.Object) _r1_o) ? 1 : 0;
    if (_r0.i != 0) goto label20;
    // Value=ar
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)97)), unchecked((char) unchecked((uint) 114))}));
    _r1_o = ((global::com.codename1.l10n.L10NManager) _r2_o)._flanguage;
    _r0.i = ((global::java.lang.String) _r0_o).equals((global::java.lang.Object) _r1_o) ? 1 : 0;
    if (_r0.i == 0) goto label22;
    label20:;
    _r0.i = 1;
    label21:;
    return _r0.i!=0;
    label22:;
    _r0.i = 0;
    goto label21;
//XMLVM_END_WRAPPER[com.codename1.l10n.L10NManager: boolean isRTLLocale()]
}

public virtual global::System.Object getLocale(){
//XMLVM_BEGIN_WRAPPER[com.codename1.l10n.L10NManager: java.lang.String getLocale()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.l10n.L10NManager) _r1_o)._flocale;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.l10n.L10NManager: java.lang.String getLocale()]
}

public static global::System.Object getInstance(){
//XMLVM_BEGIN_WRAPPER[com.codename1.l10n.L10NManager: com.codename1.l10n.L10NManager getInstance()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = global::com.codename1.ui.Display.getInstance();
    _r0_o = ((global::com.codename1.ui.Display) _r0_o).getLocalizationManager();
    return (global::com.codename1.l10n.L10NManager) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.l10n.L10NManager: com.codename1.l10n.L10NManager getInstance()]
}

public virtual global::System.Object format(double n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.l10n.L10NManager: java.lang.String format(double, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2.d = n1;
    _r4.i = n2;
    _r0_o = ((global::com.codename1.l10n.L10NManager) _r1_o).format((double) _r2.d);
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.l10n.L10NManager: java.lang.String format(double, int)]
}

public virtual double parseDouble(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.l10n.L10NManager: double parseDouble(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r3_o = n1;
    _r0.d = global::java.lang.Double.parseDouble((global::java.lang.String) _r3_o);
    return _r0.d;
//XMLVM_END_WRAPPER[com.codename1.l10n.L10NManager: double parseDouble(java.lang.String)]
}

public virtual long parseLong(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.l10n.L10NManager: long parseLong(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r3_o = n1;
    _r0.l = global::java.lang.Long.parseLong((global::java.lang.String) _r3_o);
    return _r0.l;
//XMLVM_END_WRAPPER[com.codename1.l10n.L10NManager: long parseLong(java.lang.String)]
}

public virtual int parseInt(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.l10n.L10NManager: int parseInt(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r0.i = global::java.lang.Integer.parseInt((global::java.lang.String) _r2_o);
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.l10n.L10NManager: int parseInt(java.lang.String)]
}

public virtual double parseCurrency(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.l10n.L10NManager: double parseCurrency(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r6_o = this;
    _r7_o = n1;
    _r0_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r0_o).@this();
    _r3.i = ((global::java.lang.String) _r7_o).length();
    _r2.i = 0;
    label10:;
    if (_r2.i >= _r3.i) goto label40;
    _r1.i = ((global::java.lang.String) _r7_o).charAt((int) _r2.i);
    _r4.i = global::java.lang.Character.isDigit((char) _r1.i) ? 1 : 0;
    if (_r4.i != 0) goto label34;
    _r4.i = 46;
    if (_r1.i == _r4.i) goto label34;
    _r4.i = 44;
    if (_r1.i == _r4.i) goto label34;
    _r4.i = 45;
    if (_r1.i != _r4.i) goto label37;
    label34:;
    ((global::java.lang.StringBuilder) _r0_o).append((char) _r1.i);
    label37:;
    _r2.i = _r2.i + 1;
    goto label10;
    label40:;
    _r4_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    _r4.d = ((global::com.codename1.l10n.L10NManager) _r6_o).parseDouble((global::java.lang.String) _r4_o);
    return _r4.d;
//XMLVM_END_WRAPPER[com.codename1.l10n.L10NManager: double parseCurrency(java.lang.String)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.l10n.L10NManager]
//XMLVM_END_WRAPPER[com.codename1.l10n.L10NManager]

} // end of class: L10NManager

} // end of namespace: com.codename1.l10n
