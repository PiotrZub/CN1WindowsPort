// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.io.gzip {
public class DeflaterOutputStream: global::com.codename1.io.gzip.FilterOutputStream {
public global::com.codename1.io.gzip.Deflater _fdeflater;

public global::org.xmlvm._nArrayAdapter<sbyte> _fbuffer;

private bool _fclosed;

private bool _fsyncFlush;

private global::org.xmlvm._nArrayAdapter<sbyte> _fbuf1;

public bool _fmydeflater;

private bool _fclose_1out;

public static int _fDEFAULT_1BUFSIZE = 512;

new public void @this(global::java.io.OutputStream n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.DeflaterOutputStream: void <init>(java.io.OutputStream)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r3_o = this;
    _r4_o = n1;
    _r2.i = 1;
    _r0_o = new global::com.codename1.io.gzip.Deflater();
    _r1.i = -1;
    ((global::com.codename1.io.gzip.Deflater) _r0_o).@this((int) _r1.i);
    _r1.i = 512;
    ((global::com.codename1.io.gzip.DeflaterOutputStream) _r3_o).@this((global::java.io.OutputStream) _r4_o, (global::com.codename1.io.gzip.Deflater) _r0_o, (int) _r1.i, 0!=_r2.i);
    ((global::com.codename1.io.gzip.DeflaterOutputStream) _r3_o)._fmydeflater = 0!=_r2.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.DeflaterOutputStream: void <init>(java.io.OutputStream)]
}

public void @this(global::java.io.OutputStream n1, global::com.codename1.io.gzip.Deflater n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.DeflaterOutputStream: void <init>(java.io.OutputStream, com.codename1.io.gzip.Deflater)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r4_o = n2;
    _r0.i = 512;
    _r1.i = 1;
    ((global::com.codename1.io.gzip.DeflaterOutputStream) _r2_o).@this((global::java.io.OutputStream) _r3_o, (global::com.codename1.io.gzip.Deflater) _r4_o, (int) _r0.i, 0!=_r1.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.DeflaterOutputStream: void <init>(java.io.OutputStream, com.codename1.io.gzip.Deflater)]
}

public void @this(global::java.io.OutputStream n1, global::com.codename1.io.gzip.Deflater n2, int n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.DeflaterOutputStream: void <init>(java.io.OutputStream, com.codename1.io.gzip.Deflater, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r4.i = n3;
    _r0.i = 1;
    ((global::com.codename1.io.gzip.DeflaterOutputStream) _r1_o).@this((global::java.io.OutputStream) _r2_o, (global::com.codename1.io.gzip.Deflater) _r3_o, (int) _r4.i, 0!=_r0.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.DeflaterOutputStream: void <init>(java.io.OutputStream, com.codename1.io.gzip.Deflater, int)]
}

public void @this(global::java.io.OutputStream n1, global::com.codename1.io.gzip.Deflater n2, int n3, bool n4){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.DeflaterOutputStream: void <init>(java.io.OutputStream, com.codename1.io.gzip.Deflater, int, boolean)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r7;
    _r3_o = this;
    _r4_o = n1;
    _r5_o = n2;
    _r6.i = n3;
    _r7.i = n4 ? 1 : 0;
    _r2.i = 1;
    _r1.i = 0;
    ((global::com.codename1.io.gzip.FilterOutputStream) _r3_o).@this((global::java.io.OutputStream) _r4_o);
    ((global::com.codename1.io.gzip.DeflaterOutputStream) _r3_o)._fclosed = 0!=_r1.i;
    ((global::com.codename1.io.gzip.DeflaterOutputStream) _r3_o)._fsyncFlush = 0!=_r1.i;
    _r0_o = new global::org.xmlvm._nArrayAdapter<sbyte>(new sbyte[_r2.i]);
    ((global::com.codename1.io.gzip.DeflaterOutputStream) _r3_o)._fbuf1 = (global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o;
    ((global::com.codename1.io.gzip.DeflaterOutputStream) _r3_o)._fmydeflater = 0!=_r1.i;
    ((global::com.codename1.io.gzip.DeflaterOutputStream) _r3_o)._fclose_1out = 0!=_r2.i;
    if (_r4_o == null) goto label21;
    if (_r5_o != null) goto label27;
    label21:;
    _r0_o = new global::java.lang.NullPointerException();
    ((global::java.lang.NullPointerException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.NullPointerException) _r0_o);
    label27:;
    if (_r6.i > 0) goto label37;
    _r0_o = new global::java.lang.IllegalArgumentException();
    // Value=buffer size must be greater than 0
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)98)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 122)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 48))}));
    ((global::java.lang.IllegalArgumentException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r0_o);
    label37:;
    ((global::com.codename1.io.gzip.DeflaterOutputStream) _r3_o)._fdeflater = (global::com.codename1.io.gzip.Deflater) _r5_o;
    _r0_o = new global::org.xmlvm._nArrayAdapter<sbyte>(new sbyte[_r6.i]);
    ((global::com.codename1.io.gzip.DeflaterOutputStream) _r3_o)._fbuffer = (global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o;
    ((global::com.codename1.io.gzip.DeflaterOutputStream) _r3_o)._fclose_1out = 0!=_r7.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.DeflaterOutputStream: void <init>(java.io.OutputStream, com.codename1.io.gzip.Deflater, int, boolean)]
}

public override void write(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.DeflaterOutputStream: void write(int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    _r3_o = this;
    _r4.i = n1;
    _r2.i = 0;
    _r0_o = ((global::com.codename1.io.gzip.DeflaterOutputStream) _r3_o)._fbuf1;
    _r1.i = _r4.i & 255;
    _r1.i = (_r1.i << 24) >> 24;
    ((global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o)[_r2.i] = (sbyte)_r1.i;
    _r0_o = ((global::com.codename1.io.gzip.DeflaterOutputStream) _r3_o)._fbuf1;
    _r1.i = 1;
    ((global::com.codename1.io.gzip.DeflaterOutputStream) _r3_o).write((global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o, (int) _r2.i, (int) _r1.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.DeflaterOutputStream: void write(int)]
}

public override void write(global::org.xmlvm._nArrayAdapter<sbyte> n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.DeflaterOutputStream: void write(byte[], int, int)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r7_o = null;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nElement _r9;
    global::org.xmlvm._nElement _r10;
    _r7_o = this;
    _r8_o = n1;
    _r9.i = n2;
    _r10.i = n3;
    _r6.i = 0;
    _r5.i = 1;
    _r2_o = ((global::com.codename1.io.gzip.DeflaterOutputStream) _r7_o)._fdeflater;
    _r2.i = ((global::com.codename1.io.gzip.Deflater) _r2_o).finished() ? 1 : 0;
    if (_r2.i == 0) goto label18;
    _r2_o = new global::java.io.IOException();
    // Value=finished
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)102)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100))}));
    ((global::java.io.IOException) _r2_o).@this((global::java.lang.String) _r3_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.io.IOException) _r2_o);
    label18:;
    if (_r9.i >= 0) goto label40;
    _r2.i = _r5.i;
    label21:;
    if (_r10.i >= 0) goto label42;
    _r3.i = _r5.i;
    label24:;
    _r2.i = _r2.i | _r3.i;
    _r3.i = _r9.i + _r10.i;
    _r4.i = ((global::org.xmlvm._nIArray) _r8_o).Length;
    if (_r3.i <= _r4.i) goto label44;
    _r3.i = _r5.i;
    label31:;
    _r2.i = _r2.i | _r3.i;
    if (_r2.i == 0) goto label46;
    _r2_o = new global::java.lang.IndexOutOfBoundsException();
    ((global::java.lang.IndexOutOfBoundsException) _r2_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IndexOutOfBoundsException) _r2_o);
    label40:;
    _r2.i = _r6.i;
    goto label21;
    label42:;
    _r3.i = _r6.i;
    goto label24;
    label44:;
    _r3.i = _r6.i;
    goto label31;
    label46:;
    if (_r10.i != 0) goto label49;
    label48:;
    return;
    label49:;
    _r2.i = ((global::com.codename1.io.gzip.DeflaterOutputStream) _r7_o)._fsyncFlush ? 1 : 0;
    if (_r2.i == 0) goto label73;
    _r2.i = 2;
    _r1.i = _r2.i;
    label55:;
    _r2_o = ((global::com.codename1.io.gzip.DeflaterOutputStream) _r7_o)._fdeflater;
    ((global::com.codename1.io.gzip.Deflater) _r2_o).setInput((global::org.xmlvm._nArrayAdapter<sbyte>) _r8_o, (int) _r9.i, (int) _r10.i, 0!=_r5.i);
    label60:;
    _r2_o = ((global::com.codename1.io.gzip.DeflaterOutputStream) _r7_o)._fdeflater;
    _r2.i = ((global::com.codename1.io.gzip.Deflater) _r2_o)._favail_1in;
    if (_r2.i <= 0) goto label48;
    _r0.i = ((global::com.codename1.io.gzip.DeflaterOutputStream) _r7_o).deflate((int) _r1.i);
    if (_r0.i != _r5.i) goto label60;
    goto label48;
    label73:;
    _r1.i = _r6.i;
    goto label55;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.DeflaterOutputStream: void write(byte[], int, int)]
}

public virtual void finish(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.DeflaterOutputStream: void finish()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    label0:;
    _r0_o = ((global::com.codename1.io.gzip.DeflaterOutputStream) _r1_o)._fdeflater;
    _r0.i = ((global::com.codename1.io.gzip.Deflater) _r0_o).finished() ? 1 : 0;
    if (_r0.i != 0) goto label13;
    _r0.i = 4;
    ((global::com.codename1.io.gzip.DeflaterOutputStream) _r1_o).deflate((int) _r0.i);
    goto label0;
    label13:;
    return;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.DeflaterOutputStream: void finish()]
}

public override void close(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.DeflaterOutputStream: void close()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.io.gzip.DeflaterOutputStream) _r1_o)._fclosed ? 1 : 0;
    if (_r0.i != 0) goto label28;
    ((global::com.codename1.io.gzip.DeflaterOutputStream) _r1_o).finish();
    _r0.i = ((global::com.codename1.io.gzip.DeflaterOutputStream) _r1_o)._fmydeflater ? 1 : 0;
    if (_r0.i == 0) goto label16;
    _r0_o = ((global::com.codename1.io.gzip.DeflaterOutputStream) _r1_o)._fdeflater;
    ((global::com.codename1.io.gzip.Deflater) _r0_o).end();
    label16:;
    _r0.i = ((global::com.codename1.io.gzip.DeflaterOutputStream) _r1_o)._fclose_1out ? 1 : 0;
    if (_r0.i == 0) goto label25;
    _r0_o = ((global::com.codename1.io.gzip.DeflaterOutputStream) _r1_o)._fout;
    ((global::java.io.OutputStream) _r0_o).close();
    label25:;
    _r0.i = 1;
    ((global::com.codename1.io.gzip.DeflaterOutputStream) _r1_o)._fclosed = 0!=_r0.i;
    label28:;
    return;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.DeflaterOutputStream: void close()]
}

public virtual int deflate(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.DeflaterOutputStream: int deflate(int)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    _r6_o = this;
    _r7.i = n1;
    _r5.i = 0;
    _r2_o = ((global::com.codename1.io.gzip.DeflaterOutputStream) _r6_o)._fdeflater;
    _r3_o = ((global::com.codename1.io.gzip.DeflaterOutputStream) _r6_o)._fbuffer;
    _r4_o = ((global::com.codename1.io.gzip.DeflaterOutputStream) _r6_o)._fbuffer;
    _r4.i = ((global::org.xmlvm._nIArray) _r4_o).Length;
    ((global::com.codename1.io.gzip.Deflater) _r2_o).setOutput((global::org.xmlvm._nArrayAdapter<sbyte>) _r3_o, (int) _r5.i, (int) _r4.i);
    _r2_o = ((global::com.codename1.io.gzip.DeflaterOutputStream) _r6_o)._fdeflater;
    _r0.i = ((global::com.codename1.io.gzip.Deflater) _r2_o).deflate((int) _r7.i);
    switch (_r0.i) {
    case -5: goto label28;
    case 0: goto label37;
    case 1: goto label37;
    }
    label20:;
    _r2_o = new global::java.io.IOException();
    // Value=failed to deflate
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)102)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101))}));
    ((global::java.io.IOException) _r2_o).@this((global::java.lang.String) _r3_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.io.IOException) _r2_o);
    label28:;
    _r2_o = ((global::com.codename1.io.gzip.DeflaterOutputStream) _r6_o)._fdeflater;
    _r2.i = ((global::com.codename1.io.gzip.Deflater) _r2_o)._favail_1in;
    if (_r2.i > 0) goto label20;
    _r2.i = 4;
    if (_r7.i == _r2.i) goto label20;
    label37:;
    _r2_o = ((global::com.codename1.io.gzip.DeflaterOutputStream) _r6_o)._fdeflater;
    _r1.i = ((global::com.codename1.io.gzip.Deflater) _r2_o)._fnext_1out_1index;
    if (_r1.i <= 0) goto label50;
    _r2_o = ((global::com.codename1.io.gzip.DeflaterOutputStream) _r6_o)._fout;
    _r3_o = ((global::com.codename1.io.gzip.DeflaterOutputStream) _r6_o)._fbuffer;
    ((global::java.io.OutputStream) _r2_o).write((global::org.xmlvm._nArrayAdapter<sbyte>) _r3_o, (int) _r5.i, (int) _r1.i);
    label50:;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.DeflaterOutputStream: int deflate(int)]
}

public override void flush(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.DeflaterOutputStream: void flush()]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r3_o = this;
    _r1.i = ((global::com.codename1.io.gzip.DeflaterOutputStream) _r3_o)._fsyncFlush ? 1 : 0;
    if (_r1.i == 0) goto label26;
    _r1_o = ((global::com.codename1.io.gzip.DeflaterOutputStream) _r3_o)._fdeflater;
    _r1.i = ((global::com.codename1.io.gzip.Deflater) _r1_o).finished() ? 1 : 0;
    if (_r1.i != 0) goto label26;
    label12:;
    _r1.i = 2;
    _r0.i = ((global::com.codename1.io.gzip.DeflaterOutputStream) _r3_o).deflate((int) _r1.i);
    _r1_o = ((global::com.codename1.io.gzip.DeflaterOutputStream) _r3_o)._fdeflater;
    _r1.i = ((global::com.codename1.io.gzip.Deflater) _r1_o)._fnext_1out_1index;
    _r2_o = ((global::com.codename1.io.gzip.DeflaterOutputStream) _r3_o)._fbuffer;
    _r2.i = ((global::org.xmlvm._nIArray) _r2_o).Length;
    if (_r1.i >= _r2.i) goto label32;
    label26:;
    _r1_o = ((global::com.codename1.io.gzip.DeflaterOutputStream) _r3_o)._fout;
    ((global::java.io.OutputStream) _r1_o).flush();
    return;
    label32:;
    _r1.i = 1;
    if (_r0.i != _r1.i) goto label12;
    goto label26;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.DeflaterOutputStream: void flush()]
}

public virtual long getTotalIn(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.DeflaterOutputStream: long getTotalIn()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = ((global::com.codename1.io.gzip.DeflaterOutputStream) _r2_o)._fdeflater;
    _r0.l = ((global::com.codename1.io.gzip.Deflater) _r0_o).getTotalIn();
    return _r0.l;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.DeflaterOutputStream: long getTotalIn()]
}

public virtual long getTotalOut(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.DeflaterOutputStream: long getTotalOut()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = ((global::com.codename1.io.gzip.DeflaterOutputStream) _r2_o)._fdeflater;
    _r0.l = ((global::com.codename1.io.gzip.Deflater) _r0_o).getTotalOut();
    return _r0.l;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.DeflaterOutputStream: long getTotalOut()]
}

public virtual void setSyncFlush(bool n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.DeflaterOutputStream: void setSyncFlush(boolean)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.i = n1 ? 1 : 0;
    ((global::com.codename1.io.gzip.DeflaterOutputStream) _r0_o)._fsyncFlush = 0!=_r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.DeflaterOutputStream: void setSyncFlush(boolean)]
}

public virtual bool getSyncFlush(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.DeflaterOutputStream: boolean getSyncFlush()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.io.gzip.DeflaterOutputStream) _r1_o)._fsyncFlush ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.DeflaterOutputStream: boolean getSyncFlush()]
}

public virtual global::System.Object getDeflater(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.DeflaterOutputStream: com.codename1.io.gzip.Deflater getDeflater()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.io.gzip.DeflaterOutputStream) _r1_o)._fdeflater;
    return (global::com.codename1.io.gzip.Deflater) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.DeflaterOutputStream: com.codename1.io.gzip.Deflater getDeflater()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.DeflaterOutputStream]
//XMLVM_END_WRAPPER[com.codename1.io.gzip.DeflaterOutputStream]

} // end of class: DeflaterOutputStream

} // end of namespace: com.codename1.io.gzip
