// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.math {
public class Elementary: global::java.lang.Object {
new private void @this(){
//XMLVM_BEGIN_WRAPPER[java.math.Elementary: void <init>()]
    global::System.Object _r0_o = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[java.math.Elementary: void <init>()]
}

public static int compareArrays(global::org.xmlvm._nArrayAdapter<int> n1, global::org.xmlvm._nArrayAdapter<int> n2, int n3){
//XMLVM_BEGIN_WRAPPER[java.math.Elementary: int compareArrays(int[], int[], int)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r8_o = null;
    global::System.Object _r9_o = null;
    global::org.xmlvm._nElement _r10;
    _r8_o = n1;
    _r9_o = n2;
    _r10.i = n3;
    _r6.l = 4294967295L;
    _r5.i = 1;
    _r0.i = _r10.i - _r5.i;
    label8:;
    if (_r0.i < 0) goto label16;
    _r1.i = ((global::org.xmlvm._nArrayAdapter<int>) _r8_o)[_r0.i];
    _r2.i = ((global::org.xmlvm._nArrayAdapter<int>) _r9_o)[_r0.i];
    if (_r1.i == _r2.i) goto label20;
    label16:;
    if (_r0.i >= 0) goto label23;
    _r0.i = 0;
    label19:;
    return _r0.i;
    label20:;
    _r0.i = _r0.i + -1;
    goto label8;
    label23:;
    _r1.i = ((global::org.xmlvm._nArrayAdapter<int>) _r8_o)[_r0.i];
    _r1.l = (long) _r1.i;
    _r1.l = _r1.l & _r6.l;
    _r0.i = ((global::org.xmlvm._nArrayAdapter<int>) _r9_o)[_r0.i];
    _r3.l = (long) _r0.i;
    _r3.l = _r3.l & _r6.l;
    _r0.i = _r1.l > _r3.l ? 1 : (_r1.l == _r3.l ? 0 : -1);
    if (_r0.i >= 0) goto label37;
    _r0.i = -1;
    goto label19;
    label37:;
    _r0.i = _r5.i;
    goto label19;
//XMLVM_END_WRAPPER[java.math.Elementary: int compareArrays(int[], int[], int)]
}

public static global::System.Object add(global::java.math.BigInteger n1, global::java.math.BigInteger n2){
//XMLVM_BEGIN_WRAPPER[java.math.Elementary: java.math.BigInteger add(java.math.BigInteger, java.math.BigInteger)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r8;
    global::org.xmlvm._nElement _r9;
    global::org.xmlvm._nElement _r11;
    global::System.Object _r12_o = null;
    global::System.Object _r13_o = null;
    _r12_o = n1;
    _r13_o = n2;
    _r9.l = 4294967295L;
    _r8.i = 2;
    _r7.i = 1;
    _r6.i = 0;
    _r0.i = ((global::java.math.BigInteger) _r12_o)._fsign;
    _r1.i = ((global::java.math.BigInteger) _r13_o)._fsign;
    if (_r0.i != 0) goto label16;
    _r0_o = _r13_o;
    label15:;
    return (global::java.math.BigInteger) _r0_o;
    label16:;
    if (_r1.i != 0) goto label20;
    _r0_o = _r12_o;
    goto label15;
    label20:;
    _r2.i = ((global::java.math.BigInteger) _r12_o)._fnumberLength;
    _r3.i = ((global::java.math.BigInteger) _r13_o)._fnumberLength;
    _r4.i = _r2.i + _r3.i;
    if (_r4.i != _r8.i) goto label83;
    _r2_o = ((global::java.math.BigInteger) _r12_o)._fdigits;
    _r2.i = ((global::org.xmlvm._nArrayAdapter<int>) _r2_o)[_r6.i];
    _r2.l = (long) _r2.i;
    _r2.l = _r2.l & _r9.l;
    _r4_o = ((global::java.math.BigInteger) _r13_o)._fdigits;
    _r4.i = ((global::org.xmlvm._nArrayAdapter<int>) _r4_o)[_r6.i];
    _r4.l = (long) _r4.i;
    _r4.l = _r4.l & _r9.l;
    if (_r0.i != _r1.i) goto label71;
    _r1.l = _r2.l + _r4.l;
    _r3.i = (int) _r1.l;
    _r4.i = 32;
    _r1.l = (long) (((ulong) _r1.l) >> (0x3f & (_r4.i)));
    _r1.i = (int) _r1.l;
    if (_r1.i != 0) goto label58;
    _r1_o = new global::java.math.BigInteger();
    ((global::java.math.BigInteger) _r1_o).@this((int) _r0.i, (int) _r3.i);
    _r0_o = _r1_o;
    goto label15;
    label58:;
    _r2_o = new global::java.math.BigInteger();
    _r4_o = new global::org.xmlvm._nArrayAdapter<int>(new int[_r8.i]);
    ((global::org.xmlvm._nArrayAdapter<int>) _r4_o)[_r6.i] = _r3.i;
    ((global::org.xmlvm._nArrayAdapter<int>) _r4_o)[_r7.i] = _r1.i;
    ((global::java.math.BigInteger) _r2_o).@this((int) _r0.i, (int) _r8.i, (global::org.xmlvm._nArrayAdapter<int>) _r4_o);
    _r0_o = _r2_o;
    goto label15;
    label71:;
    if (_r0.i >= 0) goto label80;
    _r0.l = _r4.l - _r2.l;
    label75:;
    _r0_o = global::java.math.BigInteger.valueOf((long) _r0.l);
    goto label15;
    label80:;
    _r0.l = _r2.l - _r4.l;
    goto label75;
    label83:;
    if (_r0.i != _r1.i) goto label115;
    if (_r2.i < _r3.i) goto label106;
    _r1_o = ((global::java.math.BigInteger) _r12_o)._fdigits;
    _r4_o = ((global::java.math.BigInteger) _r13_o)._fdigits;
    _r1_o = global::java.math.Elementary.add((global::org.xmlvm._nArrayAdapter<int>) _r1_o, (int) _r2.i, (global::org.xmlvm._nArrayAdapter<int>) _r4_o, (int) _r3.i);
    label95:;
    _r2_o = new global::java.math.BigInteger();
    _r3.i = ((global::org.xmlvm._nIArray) _r1_o).Length;
    ((global::java.math.BigInteger) _r2_o).@this((int) _r0.i, (int) _r3.i, (global::org.xmlvm._nArrayAdapter<int>) _r1_o);
    ((global::java.math.BigInteger) _r2_o).cutOffLeadingZeroes();
    _r0_o = _r2_o;
    goto label15;
    label106:;
    _r1_o = ((global::java.math.BigInteger) _r13_o)._fdigits;
    _r4_o = ((global::java.math.BigInteger) _r12_o)._fdigits;
    _r1_o = global::java.math.Elementary.add((global::org.xmlvm._nArrayAdapter<int>) _r1_o, (int) _r3.i, (global::org.xmlvm._nArrayAdapter<int>) _r4_o, (int) _r2.i);
    goto label95;
    label115:;
    if (_r2.i == _r3.i) goto label127;
    if (_r2.i <= _r3.i) goto label125;
    _r4.i = _r7.i;
    label120:;
    if (_r4.i != 0) goto label136;
    _r0_o = global::java.math.BigInteger._fZERO;
    goto label15;
    label125:;
    _r4.i = -1;
    goto label120;
    label127:;
    _r4_o = ((global::java.math.BigInteger) _r12_o)._fdigits;
    _r5_o = ((global::java.math.BigInteger) _r13_o)._fdigits;
    _r4.i = global::java.math.Elementary.compareArrays((global::org.xmlvm._nArrayAdapter<int>) _r4_o, (global::org.xmlvm._nArrayAdapter<int>) _r5_o, (int) _r2.i);
    goto label120;
    label136:;
    if (_r4.i != _r7.i) goto label147;
    _r1_o = ((global::java.math.BigInteger) _r12_o)._fdigits;
    _r4_o = ((global::java.math.BigInteger) _r13_o)._fdigits;
    _r1_o = global::java.math.Elementary.subtract((global::org.xmlvm._nArrayAdapter<int>) _r1_o, (int) _r2.i, (global::org.xmlvm._nArrayAdapter<int>) _r4_o, (int) _r3.i);
    goto label95;
    label147:;
    _r0_o = ((global::java.math.BigInteger) _r13_o)._fdigits;
    _r4_o = ((global::java.math.BigInteger) _r12_o)._fdigits;
    _r0_o = global::java.math.Elementary.subtract((global::org.xmlvm._nArrayAdapter<int>) _r0_o, (int) _r3.i, (global::org.xmlvm._nArrayAdapter<int>) _r4_o, (int) _r2.i);
    _r11.i = _r1.i;
    _r1_o = _r0_o;
    _r0.i = _r11.i;
    goto label95;
//XMLVM_END_WRAPPER[java.math.Elementary: java.math.BigInteger add(java.math.BigInteger, java.math.BigInteger)]
}

private static void add(global::org.xmlvm._nArrayAdapter<int> n1, global::org.xmlvm._nArrayAdapter<int> n2, int n3, global::org.xmlvm._nArrayAdapter<int> n4, int n5){
//XMLVM_BEGIN_WRAPPER[java.math.Elementary: void add(int[], int[], int, int[], int)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r9;
    global::System.Object _r10_o = null;
    global::System.Object _r11_o = null;
    global::org.xmlvm._nElement _r12;
    global::System.Object _r13_o = null;
    global::org.xmlvm._nElement _r14;
    _r10_o = n1;
    _r11_o = n2;
    _r12.i = n3;
    _r13_o = n4;
    _r14.i = n5;
    _r5.i = 1;
    _r4.i = 0;
    _r9.i = 32;
    _r7.l = 4294967295L;
    _r0.i = ((global::org.xmlvm._nArrayAdapter<int>) _r11_o)[_r4.i];
    _r0.l = (long) _r0.i;
    _r0.l = _r0.l & _r7.l;
    _r2.i = ((global::org.xmlvm._nArrayAdapter<int>) _r13_o)[_r4.i];
    _r2.l = (long) _r2.i;
    _r2.l = _r2.l & _r7.l;
    _r0.l = _r0.l + _r2.l;
    _r2.i = (int) _r0.l;
    ((global::org.xmlvm._nArrayAdapter<int>) _r10_o)[_r4.i] = _r2.i;
    _r0.l = _r0.l >> (0x3f & _r9.i);
    if (_r12.i < _r14.i) goto label68;
    _r2.i = _r5.i;
    label25:;
    if (_r2.i < _r14.i) goto label39;
    label27:;
    if (_r2.i < _r12.i) goto label56;
    label29:;
    _r3.l = 0L;
    _r3.i = _r0.l > _r3.l ? 1 : (_r0.l == _r3.l ? 0 : -1);
    if (_r3.i == 0) goto label38;
    _r0.i = (int) _r0.l;
    ((global::org.xmlvm._nArrayAdapter<int>) _r10_o)[_r2.i] = _r0.i;
    label38:;
    return;
    label39:;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<int>) _r11_o)[_r2.i];
    _r3.l = (long) _r3.i;
    _r3.l = _r3.l & _r7.l;
    _r5.i = ((global::org.xmlvm._nArrayAdapter<int>) _r13_o)[_r2.i];
    _r5.l = (long) _r5.i;
    _r5.l = _r5.l & _r7.l;
    _r3.l = _r3.l + _r5.l;
    _r0.l = _r0.l + _r3.l;
    _r3.i = (int) _r0.l;
    ((global::org.xmlvm._nArrayAdapter<int>) _r10_o)[_r2.i] = _r3.i;
    _r0.l = _r0.l >> (0x3f & _r9.i);
    _r2.i = _r2.i + 1;
    goto label25;
    label56:;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<int>) _r11_o)[_r2.i];
    _r3.l = (long) _r3.i;
    _r3.l = _r3.l & _r7.l;
    _r0.l = _r0.l + _r3.l;
    _r3.i = (int) _r0.l;
    ((global::org.xmlvm._nArrayAdapter<int>) _r10_o)[_r2.i] = _r3.i;
    _r0.l = _r0.l >> (0x3f & _r9.i);
    _r2.i = _r2.i + 1;
    goto label27;
    label68:;
    _r2.i = _r5.i;
    label69:;
    if (_r2.i < _r12.i) goto label85;
    label71:;
    if (_r2.i >= _r14.i) goto label29;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<int>) _r13_o)[_r2.i];
    _r3.l = (long) _r3.i;
    _r3.l = _r3.l & _r7.l;
    _r0.l = _r0.l + _r3.l;
    _r3.i = (int) _r0.l;
    ((global::org.xmlvm._nArrayAdapter<int>) _r10_o)[_r2.i] = _r3.i;
    _r0.l = _r0.l >> (0x3f & _r9.i);
    _r2.i = _r2.i + 1;
    goto label71;
    label85:;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<int>) _r11_o)[_r2.i];
    _r3.l = (long) _r3.i;
    _r3.l = _r3.l & _r7.l;
    _r5.i = ((global::org.xmlvm._nArrayAdapter<int>) _r13_o)[_r2.i];
    _r5.l = (long) _r5.i;
    _r5.l = _r5.l & _r7.l;
    _r3.l = _r3.l + _r5.l;
    _r0.l = _r0.l + _r3.l;
    _r3.i = (int) _r0.l;
    ((global::org.xmlvm._nArrayAdapter<int>) _r10_o)[_r2.i] = _r3.i;
    _r0.l = _r0.l >> (0x3f & _r9.i);
    _r2.i = _r2.i + 1;
    goto label69;
//XMLVM_END_WRAPPER[java.math.Elementary: void add(int[], int[], int, int[], int)]
}

public static global::System.Object subtract(global::java.math.BigInteger n1, global::java.math.BigInteger n2){
//XMLVM_BEGIN_WRAPPER[java.math.Elementary: java.math.BigInteger subtract(java.math.BigInteger, java.math.BigInteger)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r8;
    global::System.Object _r10_o = null;
    global::System.Object _r11_o = null;
    global::System.Object _r12_o = null;
    _r11_o = n1;
    _r12_o = n2;
    _r8.l = 4294967295L;
    _r7.i = 0;
    _r6.i = -1;
    _r0.i = ((global::java.math.BigInteger) _r11_o)._fsign;
    _r1.i = ((global::java.math.BigInteger) _r12_o)._fsign;
    if (_r1.i != 0) goto label15;
    _r0_o = _r11_o;
    label14:;
    return (global::java.math.BigInteger) _r0_o;
    label15:;
    if (_r0.i != 0) goto label22;
    _r0_o = ((global::java.math.BigInteger) _r12_o).negate();
    goto label14;
    label22:;
    _r2.i = ((global::java.math.BigInteger) _r11_o)._fnumberLength;
    _r3.i = ((global::java.math.BigInteger) _r12_o)._fnumberLength;
    _r4.i = _r2.i + _r3.i;
    _r5.i = 2;
    if (_r4.i != _r5.i) goto label56;
    _r2_o = ((global::java.math.BigInteger) _r11_o)._fdigits;
    _r2.i = ((global::org.xmlvm._nArrayAdapter<int>) _r2_o)[_r7.i];
    _r2.l = (long) _r2.i;
    _r2.l = _r2.l & _r8.l;
    _r4_o = ((global::java.math.BigInteger) _r12_o)._fdigits;
    _r4.i = ((global::org.xmlvm._nArrayAdapter<int>) _r4_o)[_r7.i];
    _r4.l = (long) _r4.i;
    _r4.l = _r4.l & _r8.l;
    if (_r0.i >= 0) goto label46;
    _r2.l = -_r2.l;
    label46:;
    if (_r1.i >= 0) goto label137;
    _r0.l = -_r4.l;
    label49:;
    _r0.l = _r2.l - _r0.l;
    _r0_o = global::java.math.BigInteger.valueOf((long) _r0.l);
    goto label14;
    label56:;
    if (_r2.i == _r3.i) goto label88;
    if (_r2.i <= _r3.i) goto label86;
    _r4.i = 1;
    label61:;
    if (_r4.i != _r6.i) goto label106;
    _r4.i = -_r1.i;
    if (_r0.i != _r1.i) goto label97;
    _r0_o = ((global::java.math.BigInteger) _r12_o)._fdigits;
    _r1_o = ((global::java.math.BigInteger) _r11_o)._fdigits;
    _r0_o = global::java.math.Elementary.subtract((global::org.xmlvm._nArrayAdapter<int>) _r0_o, (int) _r3.i, (global::org.xmlvm._nArrayAdapter<int>) _r1_o, (int) _r2.i);
    label74:;
    _r1.i = _r4.i;
    label75:;
    _r2_o = new global::java.math.BigInteger();
    _r3.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    ((global::java.math.BigInteger) _r2_o).@this((int) _r1.i, (int) _r3.i, (global::org.xmlvm._nArrayAdapter<int>) _r0_o);
    ((global::java.math.BigInteger) _r2_o).cutOffLeadingZeroes();
    _r0_o = _r2_o;
    goto label14;
    label86:;
    _r4.i = _r6.i;
    goto label61;
    label88:;
    _r4_o = ((global::java.math.BigInteger) _r11_o)._fdigits;
    _r5_o = ((global::java.math.BigInteger) _r12_o)._fdigits;
    _r4.i = global::java.math.Elementary.compareArrays((global::org.xmlvm._nArrayAdapter<int>) _r4_o, (global::org.xmlvm._nArrayAdapter<int>) _r5_o, (int) _r2.i);
    goto label61;
    label97:;
    _r0_o = ((global::java.math.BigInteger) _r12_o)._fdigits;
    _r1_o = ((global::java.math.BigInteger) _r11_o)._fdigits;
    _r0_o = global::java.math.Elementary.add((global::org.xmlvm._nArrayAdapter<int>) _r0_o, (int) _r3.i, (global::org.xmlvm._nArrayAdapter<int>) _r1_o, (int) _r2.i);
    goto label74;
    label106:;
    if (_r0.i != _r1.i) goto label125;
    if (_r4.i != 0) goto label113;
    _r0_o = global::java.math.BigInteger._fZERO;
    goto label14;
    label113:;
    _r1_o = ((global::java.math.BigInteger) _r11_o)._fdigits;
    _r4_o = ((global::java.math.BigInteger) _r12_o)._fdigits;
    _r1_o = global::java.math.Elementary.subtract((global::org.xmlvm._nArrayAdapter<int>) _r1_o, (int) _r2.i, (global::org.xmlvm._nArrayAdapter<int>) _r4_o, (int) _r3.i);
    _r10_o = _r1_o;
    _r1.i = _r0.i;
    _r0_o = _r10_o;
    goto label75;
    label125:;
    _r1_o = ((global::java.math.BigInteger) _r11_o)._fdigits;
    _r4_o = ((global::java.math.BigInteger) _r12_o)._fdigits;
    _r1_o = global::java.math.Elementary.add((global::org.xmlvm._nArrayAdapter<int>) _r1_o, (int) _r2.i, (global::org.xmlvm._nArrayAdapter<int>) _r4_o, (int) _r3.i);
    _r10_o = _r1_o;
    _r1.i = _r0.i;
    _r0_o = _r10_o;
    goto label75;
    label137:;
    _r0.l = _r4.l;
    goto label49;
//XMLVM_END_WRAPPER[java.math.Elementary: java.math.BigInteger subtract(java.math.BigInteger, java.math.BigInteger)]
}

private static void subtract(global::org.xmlvm._nArrayAdapter<int> n1, global::org.xmlvm._nArrayAdapter<int> n2, int n3, global::org.xmlvm._nArrayAdapter<int> n4, int n5){
//XMLVM_BEGIN_WRAPPER[java.math.Elementary: void subtract(int[], int[], int, int[], int)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r9;
    global::System.Object _r10_o = null;
    global::System.Object _r11_o = null;
    global::org.xmlvm._nElement _r12;
    global::System.Object _r13_o = null;
    global::org.xmlvm._nElement _r14;
    _r10_o = n1;
    _r11_o = n2;
    _r12.i = n3;
    _r13_o = n4;
    _r14.i = n5;
    _r9.i = 32;
    _r7.l = 4294967295L;
    _r0.l = 0L;
    _r2.i = 0;
    label10:;
    if (_r2.i < _r14.i) goto label15;
    label12:;
    if (_r2.i < _r12.i) goto label32;
    return;
    label15:;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<int>) _r11_o)[_r2.i];
    _r3.l = (long) _r3.i;
    _r3.l = _r3.l & _r7.l;
    _r5.i = ((global::org.xmlvm._nArrayAdapter<int>) _r13_o)[_r2.i];
    _r5.l = (long) _r5.i;
    _r5.l = _r5.l & _r7.l;
    _r3.l = _r3.l - _r5.l;
    _r0.l = _r0.l + _r3.l;
    _r3.i = (int) _r0.l;
    ((global::org.xmlvm._nArrayAdapter<int>) _r10_o)[_r2.i] = _r3.i;
    _r0.l = _r0.l >> (0x3f & _r9.i);
    _r2.i = _r2.i + 1;
    goto label10;
    label32:;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<int>) _r11_o)[_r2.i];
    _r3.l = (long) _r3.i;
    _r3.l = _r3.l & _r7.l;
    _r0.l = _r0.l + _r3.l;
    _r3.i = (int) _r0.l;
    ((global::org.xmlvm._nArrayAdapter<int>) _r10_o)[_r2.i] = _r3.i;
    _r0.l = _r0.l >> (0x3f & _r9.i);
    _r2.i = _r2.i + 1;
    goto label12;
//XMLVM_END_WRAPPER[java.math.Elementary: void subtract(int[], int[], int, int[], int)]
}

private static global::System.Object add(global::org.xmlvm._nArrayAdapter<int> n1, int n2, global::org.xmlvm._nArrayAdapter<int> n3, int n4){
//XMLVM_BEGIN_WRAPPER[java.math.Elementary: int[] add(int[], int, int[], int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    _r1_o = n1;
    _r2.i = n2;
    _r3_o = n3;
    _r4.i = n4;
    _r0.i = _r2.i + 1;
    _r0_o = new global::org.xmlvm._nArrayAdapter<int>(new int[_r0.i]);
    global::java.math.Elementary.add((global::org.xmlvm._nArrayAdapter<int>) _r0_o, (global::org.xmlvm._nArrayAdapter<int>) _r1_o, (int) _r2.i, (global::org.xmlvm._nArrayAdapter<int>) _r3_o, (int) _r4.i);
    return (global::org.xmlvm._nArrayAdapter<int>) _r0_o;
//XMLVM_END_WRAPPER[java.math.Elementary: int[] add(int[], int, int[], int)]
}

public static void inplaceAdd(global::java.math.BigInteger n1, global::java.math.BigInteger n2){
//XMLVM_BEGIN_WRAPPER[java.math.Elementary: void inplaceAdd(java.math.BigInteger, java.math.BigInteger)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    _r5_o = n1;
    _r6_o = n2;
    _r0_o = ((global::java.math.BigInteger) _r5_o)._fdigits;
    _r1_o = ((global::java.math.BigInteger) _r5_o)._fdigits;
    _r2.i = ((global::java.math.BigInteger) _r5_o)._fnumberLength;
    _r3_o = ((global::java.math.BigInteger) _r6_o)._fdigits;
    _r4.i = ((global::java.math.BigInteger) _r6_o)._fnumberLength;
    global::java.math.Elementary.add((global::org.xmlvm._nArrayAdapter<int>) _r0_o, (global::org.xmlvm._nArrayAdapter<int>) _r1_o, (int) _r2.i, (global::org.xmlvm._nArrayAdapter<int>) _r3_o, (int) _r4.i);
    _r0.i = ((global::java.math.BigInteger) _r5_o)._fnumberLength;
    _r1.i = ((global::java.math.BigInteger) _r6_o)._fnumberLength;
    _r0.i = global::java.lang.Math.max((int) _r0.i, (int) _r1.i);
    _r0.i = _r0.i + 1;
    _r1_o = ((global::java.math.BigInteger) _r5_o)._fdigits;
    _r1.i = ((global::org.xmlvm._nIArray) _r1_o).Length;
    _r0.i = global::java.lang.Math.min((int) _r0.i, (int) _r1.i);
    ((global::java.math.BigInteger) _r5_o)._fnumberLength = _r0.i;
    ((global::java.math.BigInteger) _r5_o).cutOffLeadingZeroes();
    ((global::java.math.BigInteger) _r5_o).unCache();
    return;
//XMLVM_END_WRAPPER[java.math.Elementary: void inplaceAdd(java.math.BigInteger, java.math.BigInteger)]
}

public static int inplaceAdd(global::org.xmlvm._nArrayAdapter<int> n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[java.math.Elementary: int inplaceAdd(int[], int, int)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r8;
    global::System.Object _r10_o = null;
    global::org.xmlvm._nElement _r11;
    global::org.xmlvm._nElement _r12;
    _r10_o = n1;
    _r11.i = n2;
    _r12.i = n3;
    _r5.l = 4294967295L;
    _r0.l = (long) _r12.i;
    _r0.l = _r0.l & _r5.l;
    _r2.i = 0;
    _r7.i = _r2.i;
    _r8.l = _r0.l;
    _r1.l = _r8.l;
    _r0.i = _r7.i;
    label12:;
    _r3.l = 0L;
    _r3.i = _r1.l > _r3.l ? 1 : (_r1.l == _r3.l ? 0 : -1);
    if (_r3.i == 0) goto label20;
    if (_r0.i < _r11.i) goto label22;
    label20:;
    _r0.i = (int) _r1.l;
    return _r0.i;
    label22:;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<int>) _r10_o)[_r0.i];
    _r3.l = (long) _r3.i;
    _r3.l = _r3.l & _r5.l;
    _r1.l = _r1.l + _r3.l;
    _r3.i = (int) _r1.l;
    ((global::org.xmlvm._nArrayAdapter<int>) _r10_o)[_r0.i] = _r3.i;
    _r3.i = 32;
    _r1.l = _r1.l >> (0x3f & _r3.i);
    _r0.i = _r0.i + 1;
    goto label12;
//XMLVM_END_WRAPPER[java.math.Elementary: int inplaceAdd(int[], int, int)]
}

public static void inplaceAdd(global::java.math.BigInteger n1, int n2){
//XMLVM_BEGIN_WRAPPER[java.math.Elementary: void inplaceAdd(java.math.BigInteger, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    _r3_o = n1;
    _r4.i = n2;
    _r2.i = 1;
    _r0_o = ((global::java.math.BigInteger) _r3_o)._fdigits;
    _r1.i = ((global::java.math.BigInteger) _r3_o)._fnumberLength;
    _r0.i = global::java.math.Elementary.inplaceAdd((global::org.xmlvm._nArrayAdapter<int>) _r0_o, (int) _r1.i, (int) _r4.i);
    if (_r0.i != _r2.i) goto label23;
    _r0_o = ((global::java.math.BigInteger) _r3_o)._fdigits;
    _r1.i = ((global::java.math.BigInteger) _r3_o)._fnumberLength;
    ((global::org.xmlvm._nArrayAdapter<int>) _r0_o)[_r1.i] = _r2.i;
    _r0.i = ((global::java.math.BigInteger) _r3_o)._fnumberLength;
    _r0.i = _r0.i + 1;
    ((global::java.math.BigInteger) _r3_o)._fnumberLength = _r0.i;
    label23:;
    ((global::java.math.BigInteger) _r3_o).unCache();
    return;
//XMLVM_END_WRAPPER[java.math.Elementary: void inplaceAdd(java.math.BigInteger, int)]
}

public static void inplaceSubtract(global::java.math.BigInteger n1, global::java.math.BigInteger n2){
//XMLVM_BEGIN_WRAPPER[java.math.Elementary: void inplaceSubtract(java.math.BigInteger, java.math.BigInteger)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    _r5_o = n1;
    _r6_o = n2;
    _r0_o = ((global::java.math.BigInteger) _r5_o)._fdigits;
    _r1_o = ((global::java.math.BigInteger) _r5_o)._fdigits;
    _r2.i = ((global::java.math.BigInteger) _r5_o)._fnumberLength;
    _r3_o = ((global::java.math.BigInteger) _r6_o)._fdigits;
    _r4.i = ((global::java.math.BigInteger) _r6_o)._fnumberLength;
    global::java.math.Elementary.subtract((global::org.xmlvm._nArrayAdapter<int>) _r0_o, (global::org.xmlvm._nArrayAdapter<int>) _r1_o, (int) _r2.i, (global::org.xmlvm._nArrayAdapter<int>) _r3_o, (int) _r4.i);
    ((global::java.math.BigInteger) _r5_o).cutOffLeadingZeroes();
    ((global::java.math.BigInteger) _r5_o).unCache();
    return;
//XMLVM_END_WRAPPER[java.math.Elementary: void inplaceSubtract(java.math.BigInteger, java.math.BigInteger)]
}

private static void inverseSubtract(global::org.xmlvm._nArrayAdapter<int> n1, global::org.xmlvm._nArrayAdapter<int> n2, int n3, global::org.xmlvm._nArrayAdapter<int> n4, int n5){
//XMLVM_BEGIN_WRAPPER[java.math.Elementary: void inverseSubtract(int[], int[], int, int[], int)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r9;
    global::System.Object _r10_o = null;
    global::System.Object _r11_o = null;
    global::org.xmlvm._nElement _r12;
    global::System.Object _r13_o = null;
    global::org.xmlvm._nElement _r14;
    _r10_o = n1;
    _r11_o = n2;
    _r12.i = n3;
    _r13_o = n4;
    _r14.i = n5;
    _r2.i = 0;
    _r9.i = 32;
    _r7.l = 4294967295L;
    _r0.l = 0L;
    if (_r12.i >= _r14.i) goto label62;
    label12:;
    if (_r2.i < _r12.i) goto label17;
    label14:;
    if (_r2.i < _r14.i) goto label34;
    label16:;
    return;
    label17:;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<int>) _r13_o)[_r2.i];
    _r3.l = (long) _r3.i;
    _r3.l = _r3.l & _r7.l;
    _r5.i = ((global::org.xmlvm._nArrayAdapter<int>) _r11_o)[_r2.i];
    _r5.l = (long) _r5.i;
    _r5.l = _r5.l & _r7.l;
    _r3.l = _r3.l - _r5.l;
    _r0.l = _r0.l + _r3.l;
    _r3.i = (int) _r0.l;
    ((global::org.xmlvm._nArrayAdapter<int>) _r10_o)[_r2.i] = _r3.i;
    _r0.l = _r0.l >> (0x3f & _r9.i);
    _r2.i = _r2.i + 1;
    goto label12;
    label34:;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<int>) _r13_o)[_r2.i];
    _r3.l = (long) _r3.i;
    _r3.l = _r3.l & _r7.l;
    _r0.l = _r0.l + _r3.l;
    _r3.i = (int) _r0.l;
    ((global::org.xmlvm._nArrayAdapter<int>) _r10_o)[_r2.i] = _r3.i;
    _r0.l = _r0.l >> (0x3f & _r9.i);
    _r2.i = _r2.i + 1;
    goto label14;
    label46:;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<int>) _r13_o)[_r2.i];
    _r3.l = (long) _r3.i;
    _r3.l = _r3.l & _r7.l;
    _r5.i = ((global::org.xmlvm._nArrayAdapter<int>) _r11_o)[_r2.i];
    _r5.l = (long) _r5.i;
    _r5.l = _r5.l & _r7.l;
    _r3.l = _r3.l - _r5.l;
    _r0.l = _r0.l + _r3.l;
    _r3.i = (int) _r0.l;
    ((global::org.xmlvm._nArrayAdapter<int>) _r10_o)[_r2.i] = _r3.i;
    _r0.l = _r0.l >> (0x3f & _r9.i);
    _r2.i = _r2.i + 1;
    label62:;
    if (_r2.i < _r14.i) goto label46;
    label64:;
    if (_r2.i >= _r12.i) goto label16;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<int>) _r11_o)[_r2.i];
    _r3.l = (long) _r3.i;
    _r3.l = _r3.l & _r7.l;
    _r0.l = _r0.l - _r3.l;
    _r3.i = (int) _r0.l;
    ((global::org.xmlvm._nArrayAdapter<int>) _r10_o)[_r2.i] = _r3.i;
    _r0.l = _r0.l >> (0x3f & _r9.i);
    _r2.i = _r2.i + 1;
    goto label64;
//XMLVM_END_WRAPPER[java.math.Elementary: void inverseSubtract(int[], int[], int, int[], int)]
}

private static global::System.Object subtract(global::org.xmlvm._nArrayAdapter<int> n1, int n2, global::org.xmlvm._nArrayAdapter<int> n3, int n4){
//XMLVM_BEGIN_WRAPPER[java.math.Elementary: int[] subtract(int[], int, int[], int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    _r1_o = n1;
    _r2.i = n2;
    _r3_o = n3;
    _r4.i = n4;
    _r0_o = new global::org.xmlvm._nArrayAdapter<int>(new int[_r2.i]);
    global::java.math.Elementary.subtract((global::org.xmlvm._nArrayAdapter<int>) _r0_o, (global::org.xmlvm._nArrayAdapter<int>) _r1_o, (int) _r2.i, (global::org.xmlvm._nArrayAdapter<int>) _r3_o, (int) _r4.i);
    return (global::org.xmlvm._nArrayAdapter<int>) _r0_o;
//XMLVM_END_WRAPPER[java.math.Elementary: int[] subtract(int[], int, int[], int)]
}

public static void completeInPlaceSubtract(global::java.math.BigInteger n1, global::java.math.BigInteger n2){
//XMLVM_BEGIN_WRAPPER[java.math.Elementary: void completeInPlaceSubtract(java.math.BigInteger, java.math.BigInteger)]
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
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    _r6_o = n1;
    _r7_o = n2;
    _r3.i = 0;
    _r0.i = ((global::java.math.BigInteger) _r6_o).compareTo((global::java.math.BigInteger) _r7_o);
    _r1.i = ((global::java.math.BigInteger) _r6_o)._fsign;
    if (_r1.i != 0) goto label42;
    _r0_o = ((global::java.math.BigInteger) _r7_o)._fdigits;
    _r1_o = ((global::java.math.BigInteger) _r6_o)._fdigits;
    _r2.i = ((global::java.math.BigInteger) _r7_o)._fnumberLength;
    global::java.lang.System.arraycopy((global::java.lang.Object) _r0_o, (int) _r3.i, (global::java.lang.Object) _r1_o, (int) _r3.i, (int) _r2.i);
    _r0.i = ((global::java.math.BigInteger) _r7_o)._fsign;
    _r0.i = -_r0.i;
    ((global::java.math.BigInteger) _r6_o)._fsign = _r0.i;
    label23:;
    _r0.i = ((global::java.math.BigInteger) _r6_o)._fnumberLength;
    _r1.i = ((global::java.math.BigInteger) _r7_o)._fnumberLength;
    _r0.i = global::java.lang.Math.max((int) _r0.i, (int) _r1.i);
    _r0.i = _r0.i + 1;
    ((global::java.math.BigInteger) _r6_o)._fnumberLength = _r0.i;
    ((global::java.math.BigInteger) _r6_o).cutOffLeadingZeroes();
    ((global::java.math.BigInteger) _r6_o).unCache();
    return;
    label42:;
    _r1.i = ((global::java.math.BigInteger) _r6_o)._fsign;
    _r2.i = ((global::java.math.BigInteger) _r7_o)._fsign;
    if (_r1.i == _r2.i) goto label64;
    _r1_o = ((global::java.math.BigInteger) _r6_o)._fdigits;
    _r2_o = ((global::java.math.BigInteger) _r6_o)._fdigits;
    _r3.i = ((global::java.math.BigInteger) _r6_o)._fnumberLength;
    _r4_o = ((global::java.math.BigInteger) _r7_o)._fdigits;
    _r5.i = ((global::java.math.BigInteger) _r7_o)._fnumberLength;
    global::java.math.Elementary.add((global::org.xmlvm._nArrayAdapter<int>) _r1_o, (global::org.xmlvm._nArrayAdapter<int>) _r2_o, (int) _r3.i, (global::org.xmlvm._nArrayAdapter<int>) _r4_o, (int) _r5.i);
    ((global::java.math.BigInteger) _r6_o)._fsign = _r0.i;
    goto label23;
    label64:;
    _r0_o = ((global::java.math.BigInteger) _r6_o)._fdigits;
    _r1_o = ((global::java.math.BigInteger) _r7_o)._fdigits;
    _r2.i = ((global::java.math.BigInteger) _r6_o)._fnumberLength;
    _r3.i = ((global::java.math.BigInteger) _r7_o)._fnumberLength;
    _r0.i = global::java.math.Elementary.unsignedArraysCompare((global::org.xmlvm._nArrayAdapter<int>) _r0_o, (global::org.xmlvm._nArrayAdapter<int>) _r1_o, (int) _r2.i, (int) _r3.i);
    if (_r0.i <= 0) goto label92;
    _r0_o = ((global::java.math.BigInteger) _r6_o)._fdigits;
    _r1_o = ((global::java.math.BigInteger) _r6_o)._fdigits;
    _r2.i = ((global::java.math.BigInteger) _r6_o)._fnumberLength;
    _r3_o = ((global::java.math.BigInteger) _r7_o)._fdigits;
    _r4.i = ((global::java.math.BigInteger) _r7_o)._fnumberLength;
    global::java.math.Elementary.subtract((global::org.xmlvm._nArrayAdapter<int>) _r0_o, (global::org.xmlvm._nArrayAdapter<int>) _r1_o, (int) _r2.i, (global::org.xmlvm._nArrayAdapter<int>) _r3_o, (int) _r4.i);
    goto label23;
    label92:;
    _r0_o = ((global::java.math.BigInteger) _r6_o)._fdigits;
    _r1_o = ((global::java.math.BigInteger) _r6_o)._fdigits;
    _r2.i = ((global::java.math.BigInteger) _r6_o)._fnumberLength;
    _r3_o = ((global::java.math.BigInteger) _r7_o)._fdigits;
    _r4.i = ((global::java.math.BigInteger) _r7_o)._fnumberLength;
    global::java.math.Elementary.inverseSubtract((global::org.xmlvm._nArrayAdapter<int>) _r0_o, (global::org.xmlvm._nArrayAdapter<int>) _r1_o, (int) _r2.i, (global::org.xmlvm._nArrayAdapter<int>) _r3_o, (int) _r4.i);
    _r0.i = ((global::java.math.BigInteger) _r6_o)._fsign;
    _r0.i = -_r0.i;
    ((global::java.math.BigInteger) _r6_o)._fsign = _r0.i;
    goto label23;
//XMLVM_END_WRAPPER[java.math.Elementary: void completeInPlaceSubtract(java.math.BigInteger, java.math.BigInteger)]
}

public static void completeInPlaceAdd(global::java.math.BigInteger n1, global::java.math.BigInteger n2){
//XMLVM_BEGIN_WRAPPER[java.math.Elementary: void completeInPlaceAdd(java.math.BigInteger, java.math.BigInteger)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    _r5_o = n1;
    _r6_o = n2;
    _r3.i = 0;
    _r0.i = ((global::java.math.BigInteger) _r5_o)._fsign;
    if (_r0.i != 0) goto label33;
    _r0_o = ((global::java.math.BigInteger) _r6_o)._fdigits;
    _r1_o = ((global::java.math.BigInteger) _r5_o)._fdigits;
    _r2.i = ((global::java.math.BigInteger) _r6_o)._fnumberLength;
    global::java.lang.System.arraycopy((global::java.lang.Object) _r0_o, (int) _r3.i, (global::java.lang.Object) _r1_o, (int) _r3.i, (int) _r2.i);
    label14:;
    _r0.i = ((global::java.math.BigInteger) _r5_o)._fnumberLength;
    _r1.i = ((global::java.math.BigInteger) _r6_o)._fnumberLength;
    _r0.i = global::java.lang.Math.max((int) _r0.i, (int) _r1.i);
    _r0.i = _r0.i + 1;
    ((global::java.math.BigInteger) _r5_o)._fnumberLength = _r0.i;
    ((global::java.math.BigInteger) _r5_o).cutOffLeadingZeroes();
    ((global::java.math.BigInteger) _r5_o).unCache();
    label32:;
    return;
    label33:;
    _r0.i = ((global::java.math.BigInteger) _r6_o)._fsign;
    if (_r0.i == 0) goto label32;
    _r0.i = ((global::java.math.BigInteger) _r5_o)._fsign;
    _r1.i = ((global::java.math.BigInteger) _r6_o)._fsign;
    if (_r0.i != _r1.i) goto label57;
    _r0_o = ((global::java.math.BigInteger) _r5_o)._fdigits;
    _r1_o = ((global::java.math.BigInteger) _r5_o)._fdigits;
    _r2.i = ((global::java.math.BigInteger) _r5_o)._fnumberLength;
    _r3_o = ((global::java.math.BigInteger) _r6_o)._fdigits;
    _r4.i = ((global::java.math.BigInteger) _r6_o)._fnumberLength;
    global::java.math.Elementary.add((global::org.xmlvm._nArrayAdapter<int>) _r0_o, (global::org.xmlvm._nArrayAdapter<int>) _r1_o, (int) _r2.i, (global::org.xmlvm._nArrayAdapter<int>) _r3_o, (int) _r4.i);
    goto label14;
    label57:;
    _r0_o = ((global::java.math.BigInteger) _r5_o)._fdigits;
    _r1_o = ((global::java.math.BigInteger) _r6_o)._fdigits;
    _r2.i = ((global::java.math.BigInteger) _r5_o)._fnumberLength;
    _r3.i = ((global::java.math.BigInteger) _r6_o)._fnumberLength;
    _r0.i = global::java.math.Elementary.unsignedArraysCompare((global::org.xmlvm._nArrayAdapter<int>) _r0_o, (global::org.xmlvm._nArrayAdapter<int>) _r1_o, (int) _r2.i, (int) _r3.i);
    if (_r0.i <= 0) goto label85;
    _r0_o = ((global::java.math.BigInteger) _r5_o)._fdigits;
    _r1_o = ((global::java.math.BigInteger) _r5_o)._fdigits;
    _r2.i = ((global::java.math.BigInteger) _r5_o)._fnumberLength;
    _r3_o = ((global::java.math.BigInteger) _r6_o)._fdigits;
    _r4.i = ((global::java.math.BigInteger) _r6_o)._fnumberLength;
    global::java.math.Elementary.subtract((global::org.xmlvm._nArrayAdapter<int>) _r0_o, (global::org.xmlvm._nArrayAdapter<int>) _r1_o, (int) _r2.i, (global::org.xmlvm._nArrayAdapter<int>) _r3_o, (int) _r4.i);
    goto label14;
    label85:;
    _r0_o = ((global::java.math.BigInteger) _r5_o)._fdigits;
    _r1_o = ((global::java.math.BigInteger) _r5_o)._fdigits;
    _r2.i = ((global::java.math.BigInteger) _r5_o)._fnumberLength;
    _r3_o = ((global::java.math.BigInteger) _r6_o)._fdigits;
    _r4.i = ((global::java.math.BigInteger) _r6_o)._fnumberLength;
    global::java.math.Elementary.inverseSubtract((global::org.xmlvm._nArrayAdapter<int>) _r0_o, (global::org.xmlvm._nArrayAdapter<int>) _r1_o, (int) _r2.i, (global::org.xmlvm._nArrayAdapter<int>) _r3_o, (int) _r4.i);
    _r0.i = ((global::java.math.BigInteger) _r5_o)._fsign;
    _r0.i = -_r0.i;
    ((global::java.math.BigInteger) _r5_o)._fsign = _r0.i;
    goto label14;
//XMLVM_END_WRAPPER[java.math.Elementary: void completeInPlaceAdd(java.math.BigInteger, java.math.BigInteger)]
}

private static int unsignedArraysCompare(global::org.xmlvm._nArrayAdapter<int> n1, global::org.xmlvm._nArrayAdapter<int> n2, int n3, int n4){
//XMLVM_BEGIN_WRAPPER[java.math.Elementary: int unsignedArraysCompare(int[], int[], int, int)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r7;
    global::System.Object _r9_o = null;
    global::System.Object _r10_o = null;
    global::org.xmlvm._nElement _r11;
    global::org.xmlvm._nElement _r12;
    _r9_o = n1;
    _r10_o = n2;
    _r11.i = n3;
    _r12.i = n4;
    _r7.l = 4294967295L;
    _r6.i = -1;
    _r5.i = 1;
    if (_r11.i <= _r12.i) goto label11;
    _r0.i = _r5.i;
    label10:;
    return _r0.i;
    label11:;
    if (_r11.i >= _r12.i) goto label15;
    _r0.i = _r6.i;
    goto label10;
    label15:;
    _r0.i = _r11.i - _r5.i;
    label17:;
    if (_r0.i < 0) goto label25;
    _r1.i = ((global::org.xmlvm._nArrayAdapter<int>) _r9_o)[_r0.i];
    _r2.i = ((global::org.xmlvm._nArrayAdapter<int>) _r10_o)[_r0.i];
    if (_r1.i == _r2.i) goto label29;
    label25:;
    if (_r0.i >= 0) goto label32;
    _r0.i = 0;
    goto label10;
    label29:;
    _r0.i = _r0.i + -1;
    goto label17;
    label32:;
    _r1.i = ((global::org.xmlvm._nArrayAdapter<int>) _r9_o)[_r0.i];
    _r1.l = (long) _r1.i;
    _r1.l = _r1.l & _r7.l;
    _r0.i = ((global::org.xmlvm._nArrayAdapter<int>) _r10_o)[_r0.i];
    _r3.l = (long) _r0.i;
    _r3.l = _r3.l & _r7.l;
    _r0.i = _r1.l > _r3.l ? 1 : (_r1.l == _r3.l ? 0 : -1);
    if (_r0.i >= 0) goto label46;
    _r0.i = _r6.i;
    goto label10;
    label46:;
    _r0.i = _r5.i;
    goto label10;
//XMLVM_END_WRAPPER[java.math.Elementary: int unsignedArraysCompare(int[], int[], int, int)]
}

//XMLVM_BEGIN_WRAPPER[java.math.Elementary]
//XMLVM_END_WRAPPER[java.math.Elementary]

} // end of class: Elementary

} // end of namespace: java.math
