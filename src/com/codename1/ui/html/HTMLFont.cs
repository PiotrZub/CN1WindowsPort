// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.html {
public class HTMLFont: global::java.lang.Object {

static HTMLFont() {
    @static();
}

public bool _fsystemFont;

public global::com.codename1.ui.Font _ffont;

public global::java.lang.String _ffamily;

public int _fsize;

public int _fstyle;

public bool _fbold;

public bool _fitalic;

public global::java.lang.String _ftagFont;

public static int _fBOLD = 0;

public static int _fITALIC = 1;

public static int _fBIG = 2;

public static int _fSMALL = 3;

private global::org.xmlvm._nArrayAdapter<global::System.Object> _fcounterpartFonts;

private static global::org.xmlvm._nArrayAdapter<int> _fSPECIAL_1FONT_1TAGS_1ID;


public static global::java.util.Vector _fSPECIAL_1FONT_1TAGS;

public void @this(global::java.lang.String n1, global::com.codename1.ui.Font n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLFont: void <init>(java.lang.String, com.codename1.ui.Font)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::System.Object _r7_o = null;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nElement _r9;
    global::org.xmlvm._nElement _r10;
    global::System.Object _r11_o = null;
    global::System.Object _r12_o = null;
    global::System.Object _r13_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r11_o = this;
    _r12_o = n1;
    _r13_o = n2;
    _r7.i = 46;
    _r10.i = 0;
    _r9.i = 1;
    ((global::java.lang.Object) _r11_o).@this();
    _r6.i = 4;
    _r6_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r6.i]);
    ((global::com.codename1.ui.html.HTMLFont) _r11_o)._fcounterpartFonts = (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r6_o;
    ((global::com.codename1.ui.html.HTMLFont) _r11_o)._ffont = (global::com.codename1.ui.Font) _r13_o;
    _r6_o = ((global::com.codename1.ui.Font) _r13_o).getCharset();
    if (_r6_o != null) goto label113;
    _r6.i = _r9.i;
    label21:;
    ((global::com.codename1.ui.html.HTMLFont) _r11_o)._fsystemFont = 0!=_r6.i;
    _r6.i = ((global::com.codename1.ui.html.HTMLFont) _r11_o).isSystemFont() ? 1 : 0;
    if (_r6.i == 0) goto label145;
    _r6.i = ((global::com.codename1.ui.Font) _r13_o).getStyle();
    _r6.i = _r6.i & 1;
    if (_r6.i == 0) goto label115;
    _r6.i = _r9.i;
    label38:;
    ((global::com.codename1.ui.html.HTMLFont) _r11_o)._fbold = 0!=_r6.i;
    _r6.i = ((global::com.codename1.ui.Font) _r13_o).getStyle();
    _r6.i = _r6.i & 2;
    if (_r6.i == 0) goto label117;
    _r6.i = _r9.i;
    label49:;
    ((global::com.codename1.ui.html.HTMLFont) _r11_o)._fitalic = 0!=_r6.i;
    _r6.i = ((global::com.codename1.ui.Font) _r13_o).getSize();
    ((global::com.codename1.ui.html.HTMLFont) _r11_o)._fsize = _r6.i;
    _r6.i = ((global::com.codename1.ui.Font) _r13_o).getFace();
    if (_r6.i != 0) goto label119;
    // Value=system
    _r6_o = new global::java.lang.String();
    ((global::java.lang.String)_r6_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)115)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 109))}));
    ((global::com.codename1.ui.html.HTMLFont) _r11_o)._ffamily = (global::java.lang.String) _r6_o;
    label67:;
    _r6.i = ((global::com.codename1.ui.html.HTMLFont) _r11_o)._fbold ? 1 : 0;
    if (_r6.i == 0) goto label81;
    _r6.i = ((global::com.codename1.ui.html.HTMLFont) _r11_o)._fstyle;
    _r6.i = _r6.i + 1;
    ((global::com.codename1.ui.html.HTMLFont) _r11_o)._fstyle = _r6.i;
    _r6_o = ((global::com.codename1.ui.html.HTMLFont) _r11_o)._fcounterpartFonts;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r6_o)[_r10.i] = _r11_o;
    label81:;
    _r6.i = ((global::com.codename1.ui.html.HTMLFont) _r11_o)._fitalic ? 1 : 0;
    if (_r6.i == 0) goto label95;
    _r6.i = ((global::com.codename1.ui.html.HTMLFont) _r11_o)._fstyle;
    _r6.i = _r6.i + 2;
    ((global::com.codename1.ui.html.HTMLFont) _r11_o)._fstyle = _r6.i;
    _r6_o = ((global::com.codename1.ui.html.HTMLFont) _r11_o)._fcounterpartFonts;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r6_o)[_r9.i] = _r11_o;
    label95:;
    _r6.i = ((global::com.codename1.ui.html.HTMLFont) _r11_o).isSystemFont() ? 1 : 0;
    if (_r6.i == 0) goto label112;
    _r6.i = ((global::com.codename1.ui.html.HTMLFont) _r11_o)._fsize;
    _r7.i = 16;
    if (_r6.i != _r7.i) goto label287;
    _r6_o = ((global::com.codename1.ui.html.HTMLFont) _r11_o)._fcounterpartFonts;
    _r7.i = 2;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r6_o)[_r7.i] = _r11_o;
    label112:;
    return;
    label113:;
    _r6.i = _r10.i;
    goto label21;
    label115:;
    _r6.i = _r10.i;
    goto label38;
    label117:;
    _r6.i = _r10.i;
    goto label49;
    label119:;
    _r6.i = ((global::com.codename1.ui.Font) _r13_o).getFace();
    _r7.i = 32;
    if (_r6.i != _r7.i) goto label132;
    // Value=monospace
    _r6_o = new global::java.lang.String();
    ((global::java.lang.String)_r6_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)109)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 101))}));
    ((global::com.codename1.ui.html.HTMLFont) _r11_o)._ffamily = (global::java.lang.String) _r6_o;
    goto label67;
    label132:;
    _r6.i = ((global::com.codename1.ui.Font) _r13_o).getFace();
    _r7.i = 64;
    if (_r6.i != _r7.i) goto label67;
    // Value=proportional
    _r6_o = new global::java.lang.String();
    ((global::java.lang.String)_r6_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)112)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108))}));
    ((global::com.codename1.ui.html.HTMLFont) _r11_o)._ffamily = (global::java.lang.String) _r6_o;
    goto label67;
    label145:;
    if (_r12_o == null) goto label67;
    _r5.i = 0;
    _r1.i = 0;
    // Value=.
    _r6_o = new global::java.lang.String();
    ((global::java.lang.String)_r6_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)46))}));
    _r6.i = ((global::java.lang.String) _r12_o).endsWith((global::java.lang.String) _r6_o) ? 1 : 0;
    if (_r6.i != 0) goto label174;
    _r6_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r6_o).@this();
    _r6_o = ((global::java.lang.StringBuilder) _r6_o).append((global::java.lang.String) _r12_o);
    _r6_o = ((global::java.lang.StringBuilder) _r6_o).append((char) _r7.i);
    _r12_o = ((global::java.lang.StringBuilder) _r6_o).toString();
    label174:;
    _r0.i = ((global::java.lang.String) _r12_o).indexOf((int) _r7.i);
    label178:;
    _r6.i = -1;
    if (_r0.i == _r6.i) goto label253;
    _r4_o = ((global::java.lang.String) _r12_o).substring((int) _r1.i, (int) _r0.i);
    try {
    _r3.i = global::java.lang.Integer.parseInt((global::java.lang.String) _r4_o);
    ((global::com.codename1.ui.html.HTMLFont) _r11_o)._fsize = _r3.i;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.NumberFormatException) {
            _ex = ex;
            goto label198;
        }
        throw ex;
    } // end catch
    label191:;
    _r1.i = _r0.i + 1;
    _r0.i = ((global::java.lang.String) _r12_o).indexOf((int) _r7.i, (int) _r1.i);
    goto label178;
    label198:;
    _r6_o = _ex.getJavaException();
    _ex = null;
    _r2_o = _r6_o;
    // Value=bold
    _r6_o = new global::java.lang.String();
    ((global::java.lang.String)_r6_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)98)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 100))}));
    _r6.i = ((global::java.lang.String) _r4_o).equalsIgnoreCase((global::java.lang.String) _r6_o) ? 1 : 0;
    if (_r6.i == 0) goto label211;
    ((global::com.codename1.ui.html.HTMLFont) _r11_o)._fbold = 0!=_r9.i;
    goto label191;
    label211:;
    // Value=italic
    _r6_o = new global::java.lang.String();
    ((global::java.lang.String)_r6_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)105)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 99))}));
    _r6.i = ((global::java.lang.String) _r4_o).equalsIgnoreCase((global::java.lang.String) _r6_o) ? 1 : 0;
    if (_r6.i == 0) goto label222;
    ((global::com.codename1.ui.html.HTMLFont) _r11_o)._fitalic = 0!=_r9.i;
    goto label191;
    label222:;
    // Value=plain
    _r6_o = new global::java.lang.String();
    ((global::java.lang.String)_r6_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)112)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110))}));
    _r6.i = ((global::java.lang.String) _r4_o).equalsIgnoreCase((global::java.lang.String) _r6_o) ? 1 : 0;
    if (_r6.i != 0) goto label191;
    _r6_o = global::com.codename1.ui.html.HTMLFont._fSPECIAL_1FONT_1TAGS;
    _r6.i = ((global::java.util.Vector) _r6_o).contains((global::java.lang.Object) _r4_o) ? 1 : 0;
    if (_r6.i == 0) goto label245;
    _r6_o = global::com.codename1.ui.html.HTMLComponent._ffonts;
    ((global::java.util.Hashtable) _r6_o).put((global::java.lang.Object) _r4_o, (global::java.lang.Object) _r11_o);
    _r5.i = 1;
    goto label191;
    label245:;
    _r6_o = ((global::java.lang.String) _r4_o).toLowerCase();
    ((global::com.codename1.ui.html.HTMLFont) _r11_o)._ffamily = (global::java.lang.String) _r6_o;
    _r5.i = 1;
    goto label191;
    label253:;
    if (_r5.i != 0) goto label67;
    _r6_o = global::java.lang.System._fout;
    _r7_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r7_o).@this();
    // Value=WARNING: Font was added with key '
    _r8_o = new global::java.lang.String();
    ((global::java.lang.String)_r8_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)87)), unchecked((char) unchecked((uint) 65)), unchecked((char) unchecked((uint) 82)), unchecked((char) unchecked((uint) 78)), unchecked((char) unchecked((uint) 73)), unchecked((char) unchecked((uint) 78)), unchecked((char) unchecked((uint) 71)), unchecked((char) unchecked((uint) 58)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 70)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 107)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 39))}));
    _r7_o = ((global::java.lang.StringBuilder) _r7_o).append((global::java.lang.String) _r8_o);
    _r7_o = ((global::java.lang.StringBuilder) _r7_o).append((global::java.lang.String) _r12_o);
    // Value=' which doesn't contain info on the font's family or attributes it to a special tag. The font will probably be unusable by the font engine.
    _r8_o = new global::java.lang.String();
    ((global::java.lang.String)_r8_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)39)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 39)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 39)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 46))}));
    _r7_o = ((global::java.lang.StringBuilder) _r7_o).append((global::java.lang.String) _r8_o);
    _r7_o = ((global::java.lang.StringBuilder) _r7_o).toString();
    ((global::java.io.PrintStream) _r6_o).println((global::java.lang.String) _r7_o);
    goto label67;
    label287:;
    _r6.i = ((global::com.codename1.ui.html.HTMLFont) _r11_o)._fsize;
    _r7.i = 8;
    if (_r6.i != _r7.i) goto label112;
    _r6_o = ((global::com.codename1.ui.html.HTMLFont) _r11_o)._fcounterpartFonts;
    _r7.i = 3;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r6_o)[_r7.i] = _r11_o;
    goto label112;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLFont: void <init>(java.lang.String, com.codename1.ui.Font)]
}

public virtual bool isSystemFont(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLFont: boolean isSystemFont()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.ui.html.HTMLFont) _r1_o)._fsystemFont ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLFont: boolean isSystemFont()]
}

public virtual bool isBold(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLFont: boolean isBold()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.ui.html.HTMLFont) _r1_o)._fbold ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLFont: boolean isBold()]
}

public virtual bool isItalic(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLFont: boolean isItalic()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.ui.html.HTMLFont) _r1_o)._fitalic ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLFont: boolean isItalic()]
}

public virtual bool isCounterpart(int n1, global::com.codename1.ui.html.HTMLFont n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLFont: boolean isCounterpart(int, com.codename1.ui.html.HTMLFont)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    _r1_o = this;
    _r2.i = n1;
    _r3_o = n2;
    switch (_r2.i) {
    case 0: goto label5;
    case 1: goto label10;
    case 2: goto label15;
    case 3: goto label20;
    }
    _r0.i = 0;
    label4:;
    return _r0.i!=0;
    label5:;
    _r0.i = ((global::com.codename1.ui.html.HTMLFont) _r1_o).isBoldCounterpart((global::com.codename1.ui.html.HTMLFont) _r3_o) ? 1 : 0;
    goto label4;
    label10:;
    _r0.i = ((global::com.codename1.ui.html.HTMLFont) _r1_o).isItalicCounterpart((global::com.codename1.ui.html.HTMLFont) _r3_o) ? 1 : 0;
    goto label4;
    label15:;
    _r0.i = ((global::com.codename1.ui.html.HTMLFont) _r1_o).isBigCounterpart((global::com.codename1.ui.html.HTMLFont) _r3_o) ? 1 : 0;
    goto label4;
    label20:;
    _r0.i = ((global::com.codename1.ui.html.HTMLFont) _r1_o).isSmallCounterpart((global::com.codename1.ui.html.HTMLFont) _r3_o) ? 1 : 0;
    goto label4;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLFont: boolean isCounterpart(int, com.codename1.ui.html.HTMLFont)]
}

public virtual bool isSameFamily(global::com.codename1.ui.html.HTMLFont n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLFont: boolean isSameFamily(com.codename1.ui.html.HTMLFont)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r0_o = ((global::com.codename1.ui.html.HTMLFont) _r2_o)._ffamily;
    if (_r0_o == null) goto label24;
    _r0_o = ((global::com.codename1.ui.html.HTMLFont) _r3_o).getFamily();
    if (_r0_o == null) goto label24;
    _r0_o = ((global::com.codename1.ui.html.HTMLFont) _r2_o)._ffamily;
    _r1_o = ((global::com.codename1.ui.html.HTMLFont) _r3_o).getFamily();
    _r0.i = ((global::java.lang.String) _r0_o).equals((global::java.lang.Object) _r1_o) ? 1 : 0;
    if (_r0.i == 0) goto label24;
    _r0.i = 1;
    label23:;
    return _r0.i!=0;
    label24:;
    _r0.i = 0;
    goto label23;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLFont: boolean isSameFamily(com.codename1.ui.html.HTMLFont)]
}

private bool isBigCounterpart(global::com.codename1.ui.html.HTMLFont n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLFont: boolean isBigCounterpart(com.codename1.ui.html.HTMLFont)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r3_o = this;
    _r4_o = n1;
    _r2.i = 0;
    _r0.i = ((global::com.codename1.ui.html.HTMLFont) _r3_o)._fsize;
    _r1.i = ((global::com.codename1.ui.html.HTMLFont) _r4_o).getSize();
    if (_r0.i > _r1.i) goto label11;
    _r0.i = _r2.i;
    label10:;
    return _r0.i!=0;
    label11:;
    _r0.i = ((global::com.codename1.ui.html.HTMLFont) _r3_o).isSameFamily((global::com.codename1.ui.html.HTMLFont) _r4_o) ? 1 : 0;
    if (_r0.i == 0) goto label27;
    _r0.i = ((global::com.codename1.ui.html.HTMLFont) _r3_o)._fstyle;
    _r1.i = ((global::com.codename1.ui.html.HTMLFont) _r4_o).getStyle();
    if (_r0.i != _r1.i) goto label27;
    _r0.i = 1;
    goto label10;
    label27:;
    _r0.i = _r2.i;
    goto label10;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLFont: boolean isBigCounterpart(com.codename1.ui.html.HTMLFont)]
}

private bool isSmallCounterpart(global::com.codename1.ui.html.HTMLFont n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLFont: boolean isSmallCounterpart(com.codename1.ui.html.HTMLFont)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r3_o = this;
    _r4_o = n1;
    _r2.i = 0;
    _r0.i = ((global::com.codename1.ui.html.HTMLFont) _r3_o)._fsize;
    _r1.i = ((global::com.codename1.ui.html.HTMLFont) _r4_o).getSize();
    if (_r0.i < _r1.i) goto label11;
    _r0.i = _r2.i;
    label10:;
    return _r0.i!=0;
    label11:;
    _r0.i = ((global::com.codename1.ui.html.HTMLFont) _r3_o).isSameFamily((global::com.codename1.ui.html.HTMLFont) _r4_o) ? 1 : 0;
    if (_r0.i == 0) goto label27;
    _r0.i = ((global::com.codename1.ui.html.HTMLFont) _r3_o)._fstyle;
    _r1.i = ((global::com.codename1.ui.html.HTMLFont) _r4_o).getStyle();
    if (_r0.i != _r1.i) goto label27;
    _r0.i = 1;
    goto label10;
    label27:;
    _r0.i = _r2.i;
    goto label10;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLFont: boolean isSmallCounterpart(com.codename1.ui.html.HTMLFont)]
}

private bool isBoldCounterpart(global::com.codename1.ui.html.HTMLFont n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLFont: boolean isBoldCounterpart(com.codename1.ui.html.HTMLFont)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r3_o = this;
    _r4_o = n1;
    _r2.i = 0;
    _r0.i = ((global::com.codename1.ui.html.HTMLFont) _r3_o)._fbold ? 1 : 0;
    if (_r0.i != 0) goto label7;
    _r0.i = _r2.i;
    label6:;
    return _r0.i!=0;
    label7:;
    _r0.i = ((global::com.codename1.ui.html.HTMLFont) _r3_o)._fsize;
    _r1.i = ((global::com.codename1.ui.html.HTMLFont) _r4_o).getSize();
    if (_r0.i != _r1.i) goto label31;
    _r0.i = ((global::com.codename1.ui.html.HTMLFont) _r3_o).isSameFamily((global::com.codename1.ui.html.HTMLFont) _r4_o) ? 1 : 0;
    if (_r0.i == 0) goto label31;
    _r0.i = ((global::com.codename1.ui.html.HTMLFont) _r3_o)._fitalic ? 1 : 0;
    _r1.i = ((global::com.codename1.ui.html.HTMLFont) _r4_o).isItalic() ? 1 : 0;
    if (_r0.i != _r1.i) goto label31;
    _r0.i = 1;
    goto label6;
    label31:;
    _r0.i = _r2.i;
    goto label6;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLFont: boolean isBoldCounterpart(com.codename1.ui.html.HTMLFont)]
}

private bool isItalicCounterpart(global::com.codename1.ui.html.HTMLFont n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLFont: boolean isItalicCounterpart(com.codename1.ui.html.HTMLFont)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r3_o = this;
    _r4_o = n1;
    _r2.i = 0;
    _r0.i = ((global::com.codename1.ui.html.HTMLFont) _r3_o)._fitalic ? 1 : 0;
    if (_r0.i != 0) goto label7;
    _r0.i = _r2.i;
    label6:;
    return _r0.i!=0;
    label7:;
    _r0.i = ((global::com.codename1.ui.html.HTMLFont) _r3_o)._fsize;
    _r1.i = ((global::com.codename1.ui.html.HTMLFont) _r4_o).getSize();
    if (_r0.i != _r1.i) goto label31;
    _r0.i = ((global::com.codename1.ui.html.HTMLFont) _r3_o).isSameFamily((global::com.codename1.ui.html.HTMLFont) _r4_o) ? 1 : 0;
    if (_r0.i == 0) goto label31;
    _r0.i = ((global::com.codename1.ui.html.HTMLFont) _r3_o)._fbold ? 1 : 0;
    _r1.i = ((global::com.codename1.ui.html.HTMLFont) _r4_o).isBold() ? 1 : 0;
    if (_r0.i != _r1.i) goto label31;
    _r0.i = 1;
    goto label6;
    label31:;
    _r0.i = _r2.i;
    goto label6;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLFont: boolean isItalicCounterpart(com.codename1.ui.html.HTMLFont)]
}

public virtual global::System.Object getFamily(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLFont: java.lang.String getFamily()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ui.html.HTMLFont) _r1_o)._ffamily;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLFont: java.lang.String getFamily()]
}

public virtual global::System.Object getFont(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLFont: com.codename1.ui.Font getFont()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ui.html.HTMLFont) _r1_o)._ffont;
    return (global::com.codename1.ui.Font) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLFont: com.codename1.ui.Font getFont()]
}

public virtual global::System.Object getCounterpartFont(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLFont: com.codename1.ui.html.HTMLFont getCounterpartFont(int)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nElement _r8;
    _r7_o = this;
    _r8.i = n1;
    _r4.i = 16;
    _r3.i = 8;
    _r2.i = 0;
    _r6_o = null;
    _r1.i = ((global::com.codename1.ui.html.HTMLFont) _r7_o)._fsystemFont ? 1 : 0;
    if (_r1.i == 0) goto label19;
    _r1_o = ((global::com.codename1.ui.html.HTMLFont) _r7_o)._fcounterpartFonts;
    _r1_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o)[_r8.i];
    if (_r1_o != null) goto label19;
    switch (_r8.i) {
    case 0: goto label24;
    case 1: goto label50;
    case 2: goto label76;
    case 3: goto label105;
    }
    label19:;
    _r1_o = ((global::com.codename1.ui.html.HTMLFont) _r7_o)._fcounterpartFonts;
    _r1_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o)[_r8.i];
    return (global::com.codename1.ui.html.HTMLFont) _r1_o;
    label24:;
    _r1_o = ((global::com.codename1.ui.html.HTMLFont) _r7_o)._fcounterpartFonts;
    _r2_o = new global::com.codename1.ui.html.HTMLFont();
    _r3_o = ((global::com.codename1.ui.html.HTMLFont) _r7_o)._ffont;
    _r3.i = ((global::com.codename1.ui.Font) _r3_o).getFace();
    _r4.i = ((global::com.codename1.ui.html.HTMLFont) _r7_o)._fstyle;
    _r4.i = _r4.i + 1;
    _r5.i = ((global::com.codename1.ui.html.HTMLFont) _r7_o)._fsize;
    _r3_o = global::com.codename1.ui.Font.createSystemFont((int) _r3.i, (int) _r4.i, (int) _r5.i);
    ((global::com.codename1.ui.html.HTMLFont) _r2_o).@this((global::java.lang.String) _r6_o, (global::com.codename1.ui.Font) _r3_o);
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o)[_r8.i] = _r2_o;
    goto label19;
    label50:;
    _r1_o = ((global::com.codename1.ui.html.HTMLFont) _r7_o)._fcounterpartFonts;
    _r2_o = new global::com.codename1.ui.html.HTMLFont();
    _r3_o = ((global::com.codename1.ui.html.HTMLFont) _r7_o)._ffont;
    _r3.i = ((global::com.codename1.ui.Font) _r3_o).getFace();
    _r4.i = ((global::com.codename1.ui.html.HTMLFont) _r7_o)._fstyle;
    _r4.i = _r4.i + 2;
    _r5.i = ((global::com.codename1.ui.html.HTMLFont) _r7_o)._fsize;
    _r3_o = global::com.codename1.ui.Font.createSystemFont((int) _r3.i, (int) _r4.i, (int) _r5.i);
    ((global::com.codename1.ui.html.HTMLFont) _r2_o).@this((global::java.lang.String) _r6_o, (global::com.codename1.ui.Font) _r3_o);
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o)[_r8.i] = _r2_o;
    goto label19;
    label76:;
    _r1.i = ((global::com.codename1.ui.html.HTMLFont) _r7_o)._fsize;
    if (_r1.i != _r3.i) goto label103;
    _r0.i = _r2.i;
    label81:;
    _r1_o = ((global::com.codename1.ui.html.HTMLFont) _r7_o)._fcounterpartFonts;
    _r2_o = new global::com.codename1.ui.html.HTMLFont();
    _r3_o = ((global::com.codename1.ui.html.HTMLFont) _r7_o)._ffont;
    _r3.i = ((global::com.codename1.ui.Font) _r3_o).getFace();
    _r4.i = ((global::com.codename1.ui.html.HTMLFont) _r7_o)._fstyle;
    _r3_o = global::com.codename1.ui.Font.createSystemFont((int) _r3.i, (int) _r4.i, (int) _r0.i);
    ((global::com.codename1.ui.html.HTMLFont) _r2_o).@this((global::java.lang.String) _r6_o, (global::com.codename1.ui.Font) _r3_o);
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o)[_r8.i] = _r2_o;
    goto label19;
    label103:;
    _r0.i = _r4.i;
    goto label81;
    label105:;
    _r1.i = ((global::com.codename1.ui.html.HTMLFont) _r7_o)._fsize;
    if (_r1.i != _r4.i) goto label132;
    _r0.i = _r2.i;
    label110:;
    _r1_o = ((global::com.codename1.ui.html.HTMLFont) _r7_o)._fcounterpartFonts;
    _r2_o = new global::com.codename1.ui.html.HTMLFont();
    _r3_o = ((global::com.codename1.ui.html.HTMLFont) _r7_o)._ffont;
    _r3.i = ((global::com.codename1.ui.Font) _r3_o).getFace();
    _r4.i = ((global::com.codename1.ui.html.HTMLFont) _r7_o)._fstyle;
    _r3_o = global::com.codename1.ui.Font.createSystemFont((int) _r3.i, (int) _r4.i, (int) _r0.i);
    ((global::com.codename1.ui.html.HTMLFont) _r2_o).@this((global::java.lang.String) _r6_o, (global::com.codename1.ui.Font) _r3_o);
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o)[_r8.i] = _r2_o;
    goto label19;
    label132:;
    _r0.i = _r3.i;
    goto label110;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLFont: com.codename1.ui.html.HTMLFont getCounterpartFont(int)]
}

public virtual void setCounterpartFont(int n1, global::com.codename1.ui.html.HTMLFont n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLFont: void setCounterpartFont(int, com.codename1.ui.html.HTMLFont)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    _r1_o = this;
    _r2.i = n1;
    _r3_o = n2;
    _r0_o = ((global::com.codename1.ui.html.HTMLFont) _r1_o)._fcounterpartFonts;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r2.i] = _r3_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLFont: void setCounterpartFont(int, com.codename1.ui.html.HTMLFont)]
}

public virtual int getHeight(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLFont: int getHeight()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ui.html.HTMLFont) _r1_o)._ffont;
    _r0.i = ((global::com.codename1.ui.Font) _r0_o).getHeight();
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLFont: int getHeight()]
}

public virtual int stringWidth(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLFont: int stringWidth(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::com.codename1.ui.html.HTMLFont) _r1_o)._ffont;
    _r0.i = ((global::com.codename1.ui.Font) _r0_o).stringWidth((global::java.lang.String) _r2_o);
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLFont: int stringWidth(java.lang.String)]
}

public virtual int getFace(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLFont: int getFace()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ui.html.HTMLFont) _r1_o)._ffont;
    _r0.i = ((global::com.codename1.ui.Font) _r0_o).getFace();
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLFont: int getFace()]
}

public virtual int getStyle(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLFont: int getStyle()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.ui.html.HTMLFont) _r1_o)._fstyle;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLFont: int getStyle()]
}

public virtual int getSize(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLFont: int getSize()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.ui.html.HTMLFont) _r1_o)._fsize;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLFont: int getSize()]
}

public virtual int getSizeInPixels(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLFont: int getSizeInPixels()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0.i = ((global::com.codename1.ui.html.HTMLFont) _r2_o)._fsystemFont ? 1 : 0;
    if (_r0.i == 0) goto label13;
    _r0_o = ((global::com.codename1.ui.html.HTMLFont) _r2_o)._ffont;
    _r0.i = ((global::com.codename1.ui.Font) _r0_o).getHeight();
    _r1.i = 2;
    _r0.i = _r0.i - _r1.i;
    label12:;
    return _r0.i;
    label13:;
    _r0.i = ((global::com.codename1.ui.html.HTMLFont) _r2_o)._fsize;
    goto label12;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLFont: int getSizeInPixels()]
}

new public static void @static(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLFont: void <clinit>()]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    _r1.i = 15;
    _r1_o = new global::org.xmlvm._nArrayAdapter<int>(new int[_r1.i]);
    _r1_o = new global::org.xmlvm._nArrayAdapter<int>(new int[]{13, 26, 11, 10, 24, 20, 27, 9, 14, 15, 16, 17, 18, 19, 64});
    global::com.codename1.ui.html.HTMLFont._fSPECIAL_1FONT_1TAGS_1ID = (global::org.xmlvm._nArrayAdapter<int>) _r1_o;
    _r1_o = new global::java.util.Vector();
    ((global::java.util.Vector) _r1_o).@this();
    global::com.codename1.ui.html.HTMLFont._fSPECIAL_1FONT_1TAGS = (global::java.util.Vector) _r1_o;
    _r0.i = 0;
    label17:;
    _r1_o = global::com.codename1.ui.html.HTMLFont._fSPECIAL_1FONT_1TAGS_1ID;
    _r1.i = ((global::org.xmlvm._nIArray) _r1_o).Length;
    if (_r0.i >= _r1.i) goto label38;
    _r1_o = global::com.codename1.ui.html.HTMLFont._fSPECIAL_1FONT_1TAGS;
    _r2_o = global::com.codename1.ui.html.HTMLElement._fTAG_1NAMES;
    _r3_o = global::com.codename1.ui.html.HTMLFont._fSPECIAL_1FONT_1TAGS_1ID;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<int>) _r3_o)[_r0.i];
    _r2_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o)[_r3.i];
    ((global::java.util.Vector) _r1_o).addElement((global::java.lang.Object) _r2_o);
    _r0.i = _r0.i + 1;
    goto label17;
    label38:;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLFont: void <clinit>()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLFont]
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLFont]

} // end of class: HTMLFont

} // end of namespace: com.codename1.ui.html
