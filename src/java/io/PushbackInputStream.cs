// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.io {
public class PushbackInputStream: global::java.io.FilterInputStream {
public global::org.xmlvm._nArrayAdapter<sbyte> _fbuf;

public int _fpos;

new public void @this(global::java.io.InputStream n1){
//XMLVM_BEGIN_WRAPPER[java.io.PushbackInputStream: void <init>(java.io.InputStream)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r1.i = 1;
    ((global::java.io.FilterInputStream) _r2_o).@this((global::java.io.InputStream) _r3_o);
    if (_r3_o != null) goto label12;
    _r0_o = null;
    label7:;
    ((global::java.io.PushbackInputStream) _r2_o)._fbuf = (global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o;
    ((global::java.io.PushbackInputStream) _r2_o)._fpos = _r1.i;
    return;
    label12:;
    _r0_o = new global::org.xmlvm._nArrayAdapter<sbyte>(new sbyte[_r1.i]);
    goto label7;
//XMLVM_END_WRAPPER[java.io.PushbackInputStream: void <init>(java.io.InputStream)]
}

public void @this(global::java.io.InputStream n1, int n2){
//XMLVM_BEGIN_WRAPPER[java.io.PushbackInputStream: void <init>(java.io.InputStream, int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    _r2_o = this;
    _r3_o = n1;
    _r4.i = n2;
    ((global::java.io.FilterInputStream) _r2_o).@this((global::java.io.InputStream) _r3_o);
    if (_r4.i > 0) goto label17;
    _r0_o = new global::java.lang.IllegalArgumentException();
    // Value=luni.A3
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)108)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 65)), unchecked((char) unchecked((uint) 51))}));
    _r1_o = global::org.apache.harmony.luni.@internal.nls.Messages.getString((global::java.lang.String) _r1_o);
    ((global::java.lang.IllegalArgumentException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r0_o);
    label17:;
    if (_r3_o != null) goto label25;
    _r0_o = null;
    label20:;
    ((global::java.io.PushbackInputStream) _r2_o)._fbuf = (global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o;
    ((global::java.io.PushbackInputStream) _r2_o)._fpos = _r4.i;
    return;
    label25:;
    _r0_o = new global::org.xmlvm._nArrayAdapter<sbyte>(new sbyte[_r4.i]);
    goto label20;
//XMLVM_END_WRAPPER[java.io.PushbackInputStream: void <init>(java.io.InputStream, int)]
}

public override int available(){
//XMLVM_BEGIN_WRAPPER[java.io.PushbackInputStream: int available()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = ((global::java.io.PushbackInputStream) _r2_o)._fbuf;
    if (_r0_o != null) goto label10;
    _r0_o = new global::java.io.IOException();
    ((global::java.io.IOException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.io.IOException) _r0_o);
    label10:;
    _r0_o = ((global::java.io.PushbackInputStream) _r2_o)._fbuf;
    _r0.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    _r1.i = ((global::java.io.PushbackInputStream) _r2_o)._fpos;
    _r0.i = _r0.i - _r1.i;
    _r1_o = ((global::java.io.PushbackInputStream) _r2_o)._fin;
    _r1.i = ((global::java.io.InputStream) _r1_o).available();
    _r0.i = _r0.i + _r1.i;
    return _r0.i;
//XMLVM_END_WRAPPER[java.io.PushbackInputStream: int available()]
}

public override void close(){
//XMLVM_BEGIN_WRAPPER[java.io.PushbackInputStream: void close()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r1_o = null;
    _r0_o = ((global::java.io.PushbackInputStream) _r2_o)._fin;
    if (_r0_o == null) goto label14;
    _r0_o = ((global::java.io.PushbackInputStream) _r2_o)._fin;
    ((global::java.io.InputStream) _r0_o).close();
    ((global::java.io.PushbackInputStream) _r2_o)._fin = (global::java.io.InputStream) _r1_o;
    ((global::java.io.PushbackInputStream) _r2_o)._fbuf = (global::org.xmlvm._nArrayAdapter<sbyte>) _r1_o;
    label14:;
    return;
//XMLVM_END_WRAPPER[java.io.PushbackInputStream: void close()]
}

public override bool markSupported(){
//XMLVM_BEGIN_WRAPPER[java.io.PushbackInputStream: boolean markSupported()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.io.PushbackInputStream: boolean markSupported()]
}

public override int read(){
//XMLVM_BEGIN_WRAPPER[java.io.PushbackInputStream: int read()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    _r3_o = this;
    _r0_o = ((global::java.io.PushbackInputStream) _r3_o)._fbuf;
    if (_r0_o != null) goto label10;
    _r0_o = new global::java.io.IOException();
    ((global::java.io.IOException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.io.IOException) _r0_o);
    label10:;
    _r0.i = ((global::java.io.PushbackInputStream) _r3_o)._fpos;
    _r1_o = ((global::java.io.PushbackInputStream) _r3_o)._fbuf;
    _r1.i = ((global::org.xmlvm._nIArray) _r1_o).Length;
    if (_r0.i >= _r1.i) goto label30;
    _r0_o = ((global::java.io.PushbackInputStream) _r3_o)._fbuf;
    _r1.i = ((global::java.io.PushbackInputStream) _r3_o)._fpos;
    _r2.i = _r1.i + 1;
    ((global::java.io.PushbackInputStream) _r3_o)._fpos = _r2.i;
    _r0.i = ((global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o)[_r1.i];
    _r0.i = _r0.i & 255;
    label29:;
    return _r0.i;
    label30:;
    _r0_o = ((global::java.io.PushbackInputStream) _r3_o)._fin;
    _r0.i = ((global::java.io.InputStream) _r0_o).read();
    goto label29;
//XMLVM_END_WRAPPER[java.io.PushbackInputStream: int read()]
}

public override int read(global::org.xmlvm._nArrayAdapter<sbyte> n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[java.io.PushbackInputStream: int read(byte[], int, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r8;
    _r5_o = this;
    _r6_o = n1;
    _r7.i = n2;
    _r8.i = n3;
    _r3.i = 0;
    _r0_o = ((global::java.io.PushbackInputStream) _r5_o)._fbuf;
    if (_r0_o != null) goto label17;
    _r0_o = new global::java.io.IOException();
    // Value=luni.24
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)108)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 50)), unchecked((char) unchecked((uint) 52))}));
    _r1_o = global::org.apache.harmony.luni.@internal.nls.Messages.getString((global::java.lang.String) _r1_o);
    ((global::java.io.IOException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.io.IOException) _r0_o);
    label17:;
    _r0.i = ((global::org.xmlvm._nIArray) _r6_o).Length;
    if (_r7.i > _r0.i) goto label22;
    if (_r7.i >= 0) goto label34;
    label22:;
    _r0_o = new global::java.lang.ArrayIndexOutOfBoundsException();
    // Value=luni.12
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)108)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 49)), unchecked((char) unchecked((uint) 50))}));
    _r1_o = global::org.apache.harmony.luni.@internal.nls.Messages.getString((global::java.lang.String) _r1_o, (int) _r7.i);
    ((global::java.lang.ArrayIndexOutOfBoundsException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.ArrayIndexOutOfBoundsException) _r0_o);
    label34:;
    if (_r8.i < 0) goto label40;
    _r0.i = ((global::org.xmlvm._nIArray) _r6_o).Length;
    _r0.i = _r0.i - _r7.i;
    if (_r8.i <= _r0.i) goto label52;
    label40:;
    _r0_o = new global::java.lang.ArrayIndexOutOfBoundsException();
    // Value=luni.18
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)108)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 49)), unchecked((char) unchecked((uint) 56))}));
    _r1_o = global::org.apache.harmony.luni.@internal.nls.Messages.getString((global::java.lang.String) _r1_o, (int) _r8.i);
    ((global::java.lang.ArrayIndexOutOfBoundsException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.ArrayIndexOutOfBoundsException) _r0_o);
    label52:;
    _r0.i = ((global::java.io.PushbackInputStream) _r5_o)._fpos;
    _r1_o = ((global::java.io.PushbackInputStream) _r5_o)._fbuf;
    _r1.i = ((global::org.xmlvm._nIArray) _r1_o).Length;
    if (_r0.i >= _r1.i) goto label114;
    _r0_o = ((global::java.io.PushbackInputStream) _r5_o)._fbuf;
    _r0.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    _r1.i = ((global::java.io.PushbackInputStream) _r5_o)._fpos;
    _r0.i = _r0.i - _r1.i;
    if (_r0.i < _r8.i) goto label91;
    _r0.i = _r8.i;
    label68:;
    _r1_o = ((global::java.io.PushbackInputStream) _r5_o)._fbuf;
    _r2.i = ((global::java.io.PushbackInputStream) _r5_o)._fpos;
    global::java.lang.System.arraycopy((global::java.lang.Object) _r1_o, (int) _r2.i, (global::java.lang.Object) _r6_o, (int) _r7.i, (int) _r0.i);
    _r1.i = _r7.i + _r0.i;
    _r2.i = _r3.i + _r0.i;
    _r3.i = ((global::java.io.PushbackInputStream) _r5_o)._fpos;
    _r3.i = _r3.i + _r0.i;
    ((global::java.io.PushbackInputStream) _r5_o)._fpos = _r3.i;
    _r4.i = _r1.i;
    _r1.i = _r0.i;
    _r0.i = _r4.i;
    label87:;
    if (_r1.i != _r8.i) goto label98;
    _r0.i = _r8.i;
    label90:;
    return _r0.i;
    label91:;
    _r0_o = ((global::java.io.PushbackInputStream) _r5_o)._fbuf;
    _r0.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    _r1.i = ((global::java.io.PushbackInputStream) _r5_o)._fpos;
    _r0.i = _r0.i - _r1.i;
    goto label68;
    label98:;
    _r1_o = ((global::java.io.PushbackInputStream) _r5_o)._fin;
    _r3.i = _r8.i - _r2.i;
    _r0.i = ((global::java.io.InputStream) _r1_o).read((global::org.xmlvm._nArrayAdapter<sbyte>) _r6_o, (int) _r0.i, (int) _r3.i);
    if (_r0.i <= 0) goto label110;
    _r0.i = _r0.i + _r2.i;
    goto label90;
    label110:;
    if (_r2.i == 0) goto label90;
    _r0.i = _r2.i;
    goto label90;
    label114:;
    _r0.i = _r7.i;
    _r1.i = _r3.i;
    _r2.i = _r3.i;
    goto label87;
//XMLVM_END_WRAPPER[java.io.PushbackInputStream: int read(byte[], int, int)]
}

public override long skip(long n1){
//XMLVM_BEGIN_WRAPPER[java.io.PushbackInputStream: long skip(long)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    _r6_o = this;
    _r7.l = n1;
    _r1.l = 0L;
    _r0_o = ((global::java.io.PushbackInputStream) _r6_o)._fin;
    if (_r0_o != null) goto label18;
    _r0_o = new global::java.io.IOException();
    // Value=luni.24
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)108)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 50)), unchecked((char) unchecked((uint) 52))}));
    _r1_o = global::org.apache.harmony.luni.@internal.nls.Messages.getString((global::java.lang.String) _r1_o);
    ((global::java.io.IOException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.io.IOException) _r0_o);
    label18:;
    _r0.i = _r7.l > _r1.l ? 1 : (_r7.l == _r1.l ? 0 : -1);
    if (_r0.i > 0) goto label24;
    _r0.l = _r1.l;
    label23:;
    return _r0.l;
    label24:;
    _r0.i = 0;
    _r1.i = ((global::java.io.PushbackInputStream) _r6_o)._fpos;
    _r2_o = ((global::java.io.PushbackInputStream) _r6_o)._fbuf;
    _r2.i = ((global::org.xmlvm._nIArray) _r2_o).Length;
    if (_r1.i >= _r2.i) goto label52;
    _r0.l = (long) _r0.i;
    _r2_o = ((global::java.io.PushbackInputStream) _r6_o)._fbuf;
    _r2.i = ((global::org.xmlvm._nIArray) _r2_o).Length;
    _r3.i = ((global::java.io.PushbackInputStream) _r6_o)._fpos;
    _r2.i = _r2.i - _r3.i;
    _r2.l = (long) _r2.i;
    _r2.i = _r7.l > _r2.l ? 1 : (_r7.l == _r2.l ? 0 : -1);
    if (_r2.i >= 0) goto label72;
    _r2.l = _r7.l;
    label45:;
    _r0.l = _r0.l + _r2.l;
    _r0.i = (int) _r0.l;
    _r1.i = ((global::java.io.PushbackInputStream) _r6_o)._fpos;
    _r1.i = _r1.i + _r0.i;
    ((global::java.io.PushbackInputStream) _r6_o)._fpos = _r1.i;
    label52:;
    _r1.l = (long) _r0.i;
    _r1.i = _r1.l > _r7.l ? 1 : (_r1.l == _r7.l ? 0 : -1);
    if (_r1.i >= 0) goto label70;
    _r1.l = (long) _r0.i;
    _r3_o = ((global::java.io.PushbackInputStream) _r6_o)._fin;
    _r4.l = (long) _r0.i;
    _r4.l = _r7.l - _r4.l;
    _r3.l = ((global::java.io.InputStream) _r3_o).skip((long) _r4.l);
    _r0.l = _r1.l + _r3.l;
    _r0.i = (int) _r0.l;
    label70:;
    _r0.l = (long) _r0.i;
    goto label23;
    label72:;
    _r2_o = ((global::java.io.PushbackInputStream) _r6_o)._fbuf;
    _r2.i = ((global::org.xmlvm._nIArray) _r2_o).Length;
    _r3.i = ((global::java.io.PushbackInputStream) _r6_o)._fpos;
    _r2.i = _r2.i - _r3.i;
    _r2.l = (long) _r2.i;
    goto label45;
//XMLVM_END_WRAPPER[java.io.PushbackInputStream: long skip(long)]
}

public virtual void unread(global::org.xmlvm._nArrayAdapter<sbyte> n1){
//XMLVM_BEGIN_WRAPPER[java.io.PushbackInputStream: void unread(byte[])]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r0.i = 0;
    _r1.i = ((global::org.xmlvm._nIArray) _r3_o).Length;
    ((global::java.io.PushbackInputStream) _r2_o).unread((global::org.xmlvm._nArrayAdapter<sbyte>) _r3_o, (int) _r0.i, (int) _r1.i);
    return;
//XMLVM_END_WRAPPER[java.io.PushbackInputStream: void unread(byte[])]
}

public virtual void unread(global::org.xmlvm._nArrayAdapter<sbyte> n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[java.io.PushbackInputStream: void unread(byte[], int, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    _r2_o = this;
    _r3_o = n1;
    _r4.i = n2;
    _r5.i = n3;
    _r0.i = ((global::java.io.PushbackInputStream) _r2_o)._fpos;
    if (_r5.i <= _r0.i) goto label16;
    _r0_o = new global::java.io.IOException();
    // Value=luni.D3
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)108)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 68)), unchecked((char) unchecked((uint) 51))}));
    _r1_o = global::org.apache.harmony.luni.@internal.nls.Messages.getString((global::java.lang.String) _r1_o);
    ((global::java.io.IOException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.io.IOException) _r0_o);
    label16:;
    _r0.i = ((global::org.xmlvm._nIArray) _r3_o).Length;
    if (_r4.i > _r0.i) goto label21;
    if (_r4.i >= 0) goto label33;
    label21:;
    _r0_o = new global::java.lang.ArrayIndexOutOfBoundsException();
    // Value=luni.12
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)108)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 49)), unchecked((char) unchecked((uint) 50))}));
    _r1_o = global::org.apache.harmony.luni.@internal.nls.Messages.getString((global::java.lang.String) _r1_o, (int) _r4.i);
    ((global::java.lang.ArrayIndexOutOfBoundsException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.ArrayIndexOutOfBoundsException) _r0_o);
    label33:;
    if (_r5.i < 0) goto label39;
    _r0.i = ((global::org.xmlvm._nIArray) _r3_o).Length;
    _r0.i = _r0.i - _r4.i;
    if (_r5.i <= _r0.i) goto label51;
    label39:;
    _r0_o = new global::java.lang.ArrayIndexOutOfBoundsException();
    // Value=luni.18
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)108)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 49)), unchecked((char) unchecked((uint) 56))}));
    _r1_o = global::org.apache.harmony.luni.@internal.nls.Messages.getString((global::java.lang.String) _r1_o, (int) _r5.i);
    ((global::java.lang.ArrayIndexOutOfBoundsException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.ArrayIndexOutOfBoundsException) _r0_o);
    label51:;
    _r0_o = ((global::java.io.PushbackInputStream) _r2_o)._fbuf;
    if (_r0_o != null) goto label67;
    _r0_o = new global::java.io.IOException();
    // Value=luni.24
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)108)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 50)), unchecked((char) unchecked((uint) 52))}));
    _r1_o = global::org.apache.harmony.luni.@internal.nls.Messages.getString((global::java.lang.String) _r1_o);
    ((global::java.io.IOException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.io.IOException) _r0_o);
    label67:;
    _r0_o = ((global::java.io.PushbackInputStream) _r2_o)._fbuf;
    _r1.i = ((global::java.io.PushbackInputStream) _r2_o)._fpos;
    _r1.i = _r1.i - _r5.i;
    global::java.lang.System.arraycopy((global::java.lang.Object) _r3_o, (int) _r4.i, (global::java.lang.Object) _r0_o, (int) _r1.i, (int) _r5.i);
    _r0.i = ((global::java.io.PushbackInputStream) _r2_o)._fpos;
    _r0.i = _r0.i - _r5.i;
    ((global::java.io.PushbackInputStream) _r2_o)._fpos = _r0.i;
    return;
//XMLVM_END_WRAPPER[java.io.PushbackInputStream: void unread(byte[], int, int)]
}

public virtual void unread(int n1){
//XMLVM_BEGIN_WRAPPER[java.io.PushbackInputStream: void unread(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    _r3_o = this;
    _r4.i = n1;
    _r0_o = ((global::java.io.PushbackInputStream) _r3_o)._fbuf;
    if (_r0_o != null) goto label10;
    _r0_o = new global::java.io.IOException();
    ((global::java.io.IOException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.io.IOException) _r0_o);
    label10:;
    _r0.i = ((global::java.io.PushbackInputStream) _r3_o)._fpos;
    if (_r0.i != 0) goto label26;
    _r0_o = new global::java.io.IOException();
    // Value=luni.D3
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)108)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 68)), unchecked((char) unchecked((uint) 51))}));
    _r1_o = global::org.apache.harmony.luni.@internal.nls.Messages.getString((global::java.lang.String) _r1_o);
    ((global::java.io.IOException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.io.IOException) _r0_o);
    label26:;
    _r0_o = ((global::java.io.PushbackInputStream) _r3_o)._fbuf;
    _r1.i = ((global::java.io.PushbackInputStream) _r3_o)._fpos;
    _r2.i = 1;
    _r1.i = _r1.i - _r2.i;
    ((global::java.io.PushbackInputStream) _r3_o)._fpos = _r1.i;
    _r2.i = (_r4.i << 24) >> 24;
    ((global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o)[_r1.i] = (sbyte)_r2.i;
    return;
//XMLVM_END_WRAPPER[java.io.PushbackInputStream: void unread(int)]
}

public override void mark(int n1){
//XMLVM_BEGIN_WRAPPER[java.io.PushbackInputStream: void mark(int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.i = n1;
    return;
//XMLVM_END_WRAPPER[java.io.PushbackInputStream: void mark(int)]
}

public override void reset(){
//XMLVM_BEGIN_WRAPPER[java.io.PushbackInputStream: void reset()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = new global::java.io.IOException();
    ((global::java.io.IOException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.io.IOException) _r0_o);
//XMLVM_END_WRAPPER[java.io.PushbackInputStream: void reset()]
}

//XMLVM_BEGIN_WRAPPER[java.io.PushbackInputStream]
//XMLVM_END_WRAPPER[java.io.PushbackInputStream]

} // end of class: PushbackInputStream

} // end of namespace: java.io
