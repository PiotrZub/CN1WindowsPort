// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.util.regex {
public class StringCharacterIterator: global::java.lang.Object,global::com.codename1.util.regex.CharacterIterator {
private global::java.lang.String _fsrc;

public void @this(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.regex.StringCharacterIterator: void <init>(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.lang.Object) _r0_o).@this();
    ((global::com.codename1.util.regex.StringCharacterIterator) _r0_o)._fsrc = (global::java.lang.String) _r1_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.util.regex.StringCharacterIterator: void <init>(java.lang.String)]
}

public virtual global::System.Object substring(int n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.regex.StringCharacterIterator: java.lang.String substring(int, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2.i = n1;
    _r3.i = n2;
    _r0_o = ((global::com.codename1.util.regex.StringCharacterIterator) _r1_o)._fsrc;
    _r0_o = ((global::java.lang.String) _r0_o).substring((int) _r2.i, (int) _r3.i);
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.util.regex.StringCharacterIterator: java.lang.String substring(int, int)]
}

public virtual global::System.Object substring(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.regex.StringCharacterIterator: java.lang.String substring(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2.i = n1;
    _r0_o = ((global::com.codename1.util.regex.StringCharacterIterator) _r1_o)._fsrc;
    _r0_o = ((global::java.lang.String) _r0_o).substring((int) _r2.i);
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.util.regex.StringCharacterIterator: java.lang.String substring(int)]
}

public virtual char charAt(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.regex.StringCharacterIterator: char charAt(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2.i = n1;
    _r0_o = ((global::com.codename1.util.regex.StringCharacterIterator) _r1_o)._fsrc;
    _r0.i = ((global::java.lang.String) _r0_o).charAt((int) _r2.i);
    return (char) _r0.i;
//XMLVM_END_WRAPPER[com.codename1.util.regex.StringCharacterIterator: char charAt(int)]
}

public virtual bool isEnd(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.regex.StringCharacterIterator: boolean isEnd(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2.i = n1;
    _r0_o = ((global::com.codename1.util.regex.StringCharacterIterator) _r1_o)._fsrc;
    _r0.i = ((global::java.lang.String) _r0_o).length();
    if (_r2.i < _r0.i) goto label10;
    _r0.i = 1;
    label9:;
    return _r0.i!=0;
    label10:;
    _r0.i = 0;
    goto label9;
//XMLVM_END_WRAPPER[com.codename1.util.regex.StringCharacterIterator: boolean isEnd(int)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.util.regex.StringCharacterIterator]
//XMLVM_END_WRAPPER[com.codename1.util.regex.StringCharacterIterator]

} // end of class: StringCharacterIterator

} // end of namespace: com.codename1.util.regex
