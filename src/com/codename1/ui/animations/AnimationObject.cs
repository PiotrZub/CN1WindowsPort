// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.animations {
public class AnimationObject: global::java.lang.Object {
public static int _fMOTION_1TYPE_1SPLINE = 2;

public static int _fMOTION_1TYPE_1LINEAR = 1;

public global::java.lang.String _fimageName;

public global::com.codename1.ui.util.Resources _fres;

public global::com.codename1.ui.Image _fimg;

public global::org.xmlvm._nArrayAdapter<global::System.Object> _fframes;

public global::com.codename1.ui.animations.Motion _fmotionX;

public global::com.codename1.ui.animations.Motion _fmotionY;

public global::com.codename1.ui.animations.Motion _forientation;

public global::com.codename1.ui.animations.Motion _fwidth;

public global::com.codename1.ui.animations.Motion _fheight;

public global::com.codename1.ui.animations.Motion _fopacity;

public int _fframeWidth;

public int _fframeHeight;

public int _fframeDelay;

private bool _fframesInitialized;

private int _fstartTime;

private int _fendTime;

new private void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.AnimationObject: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r1.i = -1;
    ((global::java.lang.Object) _r2_o).@this();
    ((global::com.codename1.ui.animations.AnimationObject) _r2_o)._fframeDelay = _r1.i;
    _r0.i = 1;
    ((global::com.codename1.ui.animations.AnimationObject) _r2_o)._fframesInitialized = 0!=_r0.i;
    ((global::com.codename1.ui.animations.AnimationObject) _r2_o)._fstartTime = _r1.i;
    ((global::com.codename1.ui.animations.AnimationObject) _r2_o)._fendTime = _r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.AnimationObject: void <init>()]
}

public virtual global::System.Object copy(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.AnimationObject: com.codename1.ui.animations.AnimationObject copy()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = new global::com.codename1.ui.animations.AnimationObject();
    ((global::com.codename1.ui.animations.AnimationObject) _r0_o).@this();
    _r1_o = ((global::com.codename1.ui.animations.AnimationObject) _r2_o)._fimageName;
    ((global::com.codename1.ui.animations.AnimationObject) _r0_o)._fimageName = (global::java.lang.String) _r1_o;
    _r1_o = ((global::com.codename1.ui.animations.AnimationObject) _r2_o)._fres;
    ((global::com.codename1.ui.animations.AnimationObject) _r0_o)._fres = (global::com.codename1.ui.util.Resources) _r1_o;
    _r1_o = ((global::com.codename1.ui.animations.AnimationObject) _r2_o)._fimg;
    ((global::com.codename1.ui.animations.AnimationObject) _r0_o)._fimg = (global::com.codename1.ui.Image) _r1_o;
    _r1_o = ((global::com.codename1.ui.animations.AnimationObject) _r2_o)._fframes;
    ((global::com.codename1.ui.animations.AnimationObject) _r0_o)._fframes = (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o;
    _r1_o = ((global::com.codename1.ui.animations.AnimationObject) _r2_o)._fmotionX;
    ((global::com.codename1.ui.animations.AnimationObject) _r0_o)._fmotionX = (global::com.codename1.ui.animations.Motion) _r1_o;
    _r1_o = ((global::com.codename1.ui.animations.AnimationObject) _r2_o)._fmotionY;
    ((global::com.codename1.ui.animations.AnimationObject) _r0_o)._fmotionY = (global::com.codename1.ui.animations.Motion) _r1_o;
    _r1_o = ((global::com.codename1.ui.animations.AnimationObject) _r2_o)._forientation;
    ((global::com.codename1.ui.animations.AnimationObject) _r0_o)._forientation = (global::com.codename1.ui.animations.Motion) _r1_o;
    _r1_o = ((global::com.codename1.ui.animations.AnimationObject) _r2_o)._fwidth;
    ((global::com.codename1.ui.animations.AnimationObject) _r0_o)._fwidth = (global::com.codename1.ui.animations.Motion) _r1_o;
    _r1_o = ((global::com.codename1.ui.animations.AnimationObject) _r2_o)._fheight;
    ((global::com.codename1.ui.animations.AnimationObject) _r0_o)._fheight = (global::com.codename1.ui.animations.Motion) _r1_o;
    _r1_o = ((global::com.codename1.ui.animations.AnimationObject) _r2_o)._fopacity;
    ((global::com.codename1.ui.animations.AnimationObject) _r0_o)._fopacity = (global::com.codename1.ui.animations.Motion) _r1_o;
    _r1.i = ((global::com.codename1.ui.animations.AnimationObject) _r2_o)._fframeWidth;
    ((global::com.codename1.ui.animations.AnimationObject) _r0_o)._fframeWidth = _r1.i;
    _r1.i = ((global::com.codename1.ui.animations.AnimationObject) _r2_o)._fframeHeight;
    ((global::com.codename1.ui.animations.AnimationObject) _r0_o)._fframeHeight = _r1.i;
    _r1.i = ((global::com.codename1.ui.animations.AnimationObject) _r2_o)._fframeDelay;
    ((global::com.codename1.ui.animations.AnimationObject) _r0_o)._fframeDelay = _r1.i;
    _r1.i = ((global::com.codename1.ui.animations.AnimationObject) _r2_o)._fframesInitialized ? 1 : 0;
    ((global::com.codename1.ui.animations.AnimationObject) _r0_o)._fframesInitialized = 0!=_r1.i;
    _r1.i = ((global::com.codename1.ui.animations.AnimationObject) _r2_o)._fstartTime;
    ((global::com.codename1.ui.animations.AnimationObject) _r0_o)._fstartTime = _r1.i;
    _r1.i = ((global::com.codename1.ui.animations.AnimationObject) _r2_o)._fendTime;
    ((global::com.codename1.ui.animations.AnimationObject) _r0_o)._fendTime = _r1.i;
    return (global::com.codename1.ui.animations.AnimationObject) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.AnimationObject: com.codename1.ui.animations.AnimationObject copy()]
}

public virtual void @lock(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.AnimationObject: void lock()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ui.animations.AnimationObject) _r1_o)._fimg;
    if (_r0_o == null) goto label9;
    _r0_o = ((global::com.codename1.ui.animations.AnimationObject) _r1_o)._fimg;
    ((global::com.codename1.ui.Image) _r0_o).@lock();
    label9:;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.AnimationObject: void lock()]
}

public virtual void unlock(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.AnimationObject: void unlock()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ui.animations.AnimationObject) _r1_o)._fimg;
    if (_r0_o == null) goto label9;
    _r0_o = ((global::com.codename1.ui.animations.AnimationObject) _r1_o)._fimg;
    ((global::com.codename1.ui.Image) _r0_o).unlock();
    label9:;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.AnimationObject: void unlock()]
}

public static global::System.Object createAnimationImage(global::com.codename1.ui.Image n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.AnimationObject: com.codename1.ui.animations.AnimationObject createAnimationImage(com.codename1.ui.Image, int, int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r7;
    _r5_o = n1;
    _r6.i = n2;
    _r7.i = n3;
    _r3.l = 9223372036854775807L;
    _r2.i = 1;
    _r0_o = new global::com.codename1.ui.animations.AnimationObject();
    ((global::com.codename1.ui.animations.AnimationObject) _r0_o).@this();
    ((global::com.codename1.ui.animations.AnimationObject) _r0_o)._fimg = (global::com.codename1.ui.Image) _r5_o;
    _r1_o = global::com.codename1.ui.animations.Motion.createLinearMotion((int) _r6.i, (int) _r6.i, (int) _r2.i);
    ((global::com.codename1.ui.animations.AnimationObject) _r0_o)._fmotionX = (global::com.codename1.ui.animations.Motion) _r1_o;
    _r1_o = ((global::com.codename1.ui.animations.AnimationObject) _r0_o)._fmotionX;
    ((global::com.codename1.ui.animations.Motion) _r1_o).setStartTime((long) _r3.l);
    _r1_o = global::com.codename1.ui.animations.Motion.createLinearMotion((int) _r7.i, (int) _r7.i, (int) _r2.i);
    ((global::com.codename1.ui.animations.AnimationObject) _r0_o)._fmotionY = (global::com.codename1.ui.animations.Motion) _r1_o;
    _r1_o = ((global::com.codename1.ui.animations.AnimationObject) _r0_o)._fmotionY;
    ((global::com.codename1.ui.animations.Motion) _r1_o).setStartTime((long) _r3.l);
    return (global::com.codename1.ui.animations.AnimationObject) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.AnimationObject: com.codename1.ui.animations.AnimationObject createAnimationImage(com.codename1.ui.Image, int, int)]
}

public virtual void defineFrames(int n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.AnimationObject: void defineFrames(int, int, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    _r1_o = this;
    _r2.i = n1;
    _r3.i = n2;
    _r4.i = n3;
    ((global::com.codename1.ui.animations.AnimationObject) _r1_o)._fframeWidth = _r2.i;
    ((global::com.codename1.ui.animations.AnimationObject) _r1_o)._fframeHeight = _r3.i;
    ((global::com.codename1.ui.animations.AnimationObject) _r1_o)._fframeDelay = _r4.i;
    _r0.i = 0;
    ((global::com.codename1.ui.animations.AnimationObject) _r1_o)._fframesInitialized = 0!=_r0.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.AnimationObject: void defineFrames(int, int, int)]
}

public static global::System.Object createAnimationImage(global::java.lang.String n1, global::com.codename1.ui.util.Resources n2, int n3, int n4){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.AnimationObject: com.codename1.ui.animations.AnimationObject createAnimationImage(java.lang.String, com.codename1.ui.util.Resources, int, int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r8;
    _r5_o = n1;
    _r6_o = n2;
    _r7.i = n3;
    _r8.i = n4;
    _r3.l = 9223372036854775807L;
    _r2.i = 1;
    _r0_o = new global::com.codename1.ui.animations.AnimationObject();
    ((global::com.codename1.ui.animations.AnimationObject) _r0_o).@this();
    ((global::com.codename1.ui.animations.AnimationObject) _r0_o)._fimageName = (global::java.lang.String) _r5_o;
    ((global::com.codename1.ui.animations.AnimationObject) _r0_o)._fres = (global::com.codename1.ui.util.Resources) _r6_o;
    _r1_o = global::com.codename1.ui.animations.Motion.createLinearMotion((int) _r7.i, (int) _r7.i, (int) _r2.i);
    ((global::com.codename1.ui.animations.AnimationObject) _r0_o)._fmotionX = (global::com.codename1.ui.animations.Motion) _r1_o;
    _r1_o = ((global::com.codename1.ui.animations.AnimationObject) _r0_o)._fmotionX;
    ((global::com.codename1.ui.animations.Motion) _r1_o).setStartTime((long) _r3.l);
    _r1_o = global::com.codename1.ui.animations.Motion.createLinearMotion((int) _r8.i, (int) _r8.i, (int) _r2.i);
    ((global::com.codename1.ui.animations.AnimationObject) _r0_o)._fmotionY = (global::com.codename1.ui.animations.Motion) _r1_o;
    _r1_o = ((global::com.codename1.ui.animations.AnimationObject) _r0_o)._fmotionY;
    ((global::com.codename1.ui.animations.Motion) _r1_o).setStartTime((long) _r3.l);
    return (global::com.codename1.ui.animations.AnimationObject) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.AnimationObject: com.codename1.ui.animations.AnimationObject createAnimationImage(java.lang.String, com.codename1.ui.util.Resources, int, int)]
}

public virtual global::System.Object getImage(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.AnimationObject: com.codename1.ui.Image getImage()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r8;
    global::org.xmlvm._nElement _r9;
    global::org.xmlvm._nElement _r11;
    global::System.Object _r11_o = null;
    global::System.Object _r12_o = null;
    global::System.Object _r13_o = null;
    _r13_o = this;
    _r12_o = null;
    _r5.i = 1;
    _r0_o = ((global::com.codename1.ui.animations.AnimationObject) _r13_o)._fimg;
    if (_r0_o != null) goto label28;
    _r0_o = ((global::com.codename1.ui.animations.AnimationObject) _r13_o)._fres;
    if (_r0_o == null) goto label28;
    _r0_o = ((global::com.codename1.ui.animations.AnimationObject) _r13_o)._fres;
    _r3_o = ((global::com.codename1.ui.animations.AnimationObject) _r13_o)._fimageName;
    _r0_o = ((global::com.codename1.ui.util.Resources) _r0_o).getImage((global::java.lang.String) _r3_o);
    ((global::com.codename1.ui.animations.AnimationObject) _r13_o)._fimg = (global::com.codename1.ui.Image) _r0_o;
    _r0_o = ((global::com.codename1.ui.animations.AnimationObject) _r13_o)._fimg;
    if (_r0_o != null) goto label26;
    _r0_o = _r12_o;
    label25:;
    return (global::com.codename1.ui.Image) _r0_o;
    label26:;
    ((global::com.codename1.ui.animations.AnimationObject) _r13_o)._fres = (global::com.codename1.ui.util.Resources) _r12_o;
    label28:;
    _r0.i = ((global::com.codename1.ui.animations.AnimationObject) _r13_o)._fframeDelay;
    _r3.i = -1;
    if (_r0.i <= _r3.i) goto label154;
    _r0.i = ((global::com.codename1.ui.animations.AnimationObject) _r13_o)._fframesInitialized ? 1 : 0;
    if (_r0.i != 0) goto label113;
    _r0_o = ((global::com.codename1.ui.animations.AnimationObject) _r13_o)._fimg;
    _r0.i = ((global::com.codename1.ui.Image) _r0_o).getWidth();
    _r3.i = ((global::com.codename1.ui.animations.AnimationObject) _r13_o)._fframeWidth;
    _r0.i = _r0.i / _r3.i;
    _r3_o = ((global::com.codename1.ui.animations.AnimationObject) _r13_o)._fimg;
    _r3.i = ((global::com.codename1.ui.Image) _r3_o).getHeight();
    _r0.i = _r0.i * _r3.i;
    _r3.i = ((global::com.codename1.ui.animations.AnimationObject) _r13_o)._fframeHeight;
    _r0.i = _r0.i / _r3.i;
    _r0_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r0.i]);
    ((global::com.codename1.ui.animations.AnimationObject) _r13_o)._fframes = (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o;
    _r1.i = 0;
    _r2.i = 0;
    _r8.i = 0;
    label63:;
    _r0_o = ((global::com.codename1.ui.animations.AnimationObject) _r13_o)._fframes;
    _r0.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    if (_r8.i >= _r0.i) goto label103;
    _r11_o = ((global::com.codename1.ui.animations.AnimationObject) _r13_o)._fframes;
    _r0_o = ((global::com.codename1.ui.animations.AnimationObject) _r13_o)._fimg;
    _r3.i = ((global::com.codename1.ui.animations.AnimationObject) _r13_o)._fframeWidth;
    _r4.i = ((global::com.codename1.ui.animations.AnimationObject) _r13_o)._fframeHeight;
    _r0_o = ((global::com.codename1.ui.Image) _r0_o).subImage((int) _r1.i, (int) _r2.i, (int) _r3.i, (int) _r4.i, 0!=_r5.i);
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r11_o)[_r8.i] = _r0_o;
    _r0.i = ((global::com.codename1.ui.animations.AnimationObject) _r13_o)._fframeWidth;
    _r1.i = _r1.i + _r0.i;
    _r0.i = ((global::com.codename1.ui.animations.AnimationObject) _r13_o)._fframeWidth;
    _r0.i = _r0.i + _r1.i;
    _r3_o = ((global::com.codename1.ui.animations.AnimationObject) _r13_o)._fimg;
    _r3.i = ((global::com.codename1.ui.Image) _r3_o).getWidth();
    if (_r0.i <= _r3.i) goto label100;
    _r1.i = 0;
    _r0.i = ((global::com.codename1.ui.animations.AnimationObject) _r13_o)._fframeHeight;
    _r2.i = _r2.i + _r0.i;
    label100:;
    _r8.i = _r8.i + 1;
    goto label63;
    label103:;
    // Value=microedition.platform
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)109)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 109))}));
    _r0_o = global::java.lang.System.getProperty((global::java.lang.String) _r0_o);
    if (_r0_o == null) goto label113;
    ((global::com.codename1.ui.animations.AnimationObject) _r13_o)._fimg = (global::com.codename1.ui.Image) _r12_o;
    label113:;
    _r0_o = ((global::com.codename1.ui.animations.AnimationObject) _r13_o)._fmotionX;
    _r9.l = ((global::com.codename1.ui.animations.Motion) _r0_o).getCurrentMotionTime();
    _r0_o = ((global::com.codename1.ui.animations.AnimationObject) _r13_o)._fframes;
    _r0.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    _r7.i = global::java.lang.Math.max((int) _r5.i, (int) _r0.i);
    _r0.i = 0;
    _r3.i = ((global::com.codename1.ui.animations.AnimationObject) _r13_o)._fframeDelay;
    _r3.i = global::java.lang.Math.max((int) _r5.i, (int) _r3.i);
    _r3.l = (long) _r3.i;
    _r3.l = _r9.l / _r3.l;
    _r11.l = (long) _r7.i;
    _r3.l = _r3.l % _r11.l;
    _r3.i = (int) _r3.l;
    _r0.i = global::java.lang.Math.max((int) _r0.i, (int) _r3.i);
    _r3.i = _r7.i - _r5.i;
    _r6.i = global::java.lang.Math.min((int) _r0.i, (int) _r3.i);
    _r0_o = ((global::com.codename1.ui.animations.AnimationObject) _r13_o)._fframes;
    _r0_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r6.i];
    goto label25;
    label154:;
    _r0_o = ((global::com.codename1.ui.animations.AnimationObject) _r13_o)._fimg;
    goto label25;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.AnimationObject: com.codename1.ui.Image getImage()]
}

private void setTimeNotNull(global::com.codename1.ui.animations.Motion n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.AnimationObject: void setTimeNotNull(com.codename1.ui.animations.Motion, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    _r2_o = this;
    _r3_o = n1;
    _r4.i = n2;
    if (_r3_o == null) goto label6;
    _r0.l = (long) _r4.i;
    ((global::com.codename1.ui.animations.Motion) _r3_o).setCurrentMotionTime((long) _r0.l);
    label6:;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.AnimationObject: void setTimeNotNull(com.codename1.ui.animations.Motion, int)]
}

public virtual void setTime(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.AnimationObject: void setTime(int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    _r3_o = this;
    _r4.i = n1;
    _r0_o = ((global::com.codename1.ui.animations.AnimationObject) _r3_o)._fmotionX;
    _r1.l = (long) _r4.i;
    ((global::com.codename1.ui.animations.Motion) _r0_o).setCurrentMotionTime((long) _r1.l);
    _r0_o = ((global::com.codename1.ui.animations.AnimationObject) _r3_o)._fmotionY;
    _r1.l = (long) _r4.i;
    ((global::com.codename1.ui.animations.Motion) _r0_o).setCurrentMotionTime((long) _r1.l);
    _r0_o = ((global::com.codename1.ui.animations.AnimationObject) _r3_o)._forientation;
    ((global::com.codename1.ui.animations.AnimationObject) _r3_o).setTimeNotNull((global::com.codename1.ui.animations.Motion) _r0_o, (int) _r4.i);
    _r0_o = ((global::com.codename1.ui.animations.AnimationObject) _r3_o)._fwidth;
    ((global::com.codename1.ui.animations.AnimationObject) _r3_o).setTimeNotNull((global::com.codename1.ui.animations.Motion) _r0_o, (int) _r4.i);
    _r0_o = ((global::com.codename1.ui.animations.AnimationObject) _r3_o)._fheight;
    ((global::com.codename1.ui.animations.AnimationObject) _r3_o).setTimeNotNull((global::com.codename1.ui.animations.Motion) _r0_o, (int) _r4.i);
    _r0_o = ((global::com.codename1.ui.animations.AnimationObject) _r3_o)._fopacity;
    ((global::com.codename1.ui.animations.AnimationObject) _r3_o).setTimeNotNull((global::com.codename1.ui.animations.Motion) _r0_o, (int) _r4.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.AnimationObject: void setTime(int)]
}

public virtual void defineMotionX(int n1, int n2, int n3, int n4, int n5){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.AnimationObject: void defineMotionX(int, int, int, int, int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    _r1_o = this;
    _r2.i = n1;
    _r3.i = n2;
    _r4.i = n3;
    _r5.i = n4;
    _r6.i = n5;
    _r0_o = ((global::com.codename1.ui.animations.AnimationObject) _r1_o).createMotion((int) _r2.i, (int) _r3.i, (int) _r4.i, (int) _r5.i, (int) _r6.i);
    ((global::com.codename1.ui.animations.AnimationObject) _r1_o)._fmotionX = (global::com.codename1.ui.animations.Motion) _r0_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.AnimationObject: void defineMotionX(int, int, int, int, int)]
}

public virtual void defineMotionY(int n1, int n2, int n3, int n4, int n5){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.AnimationObject: void defineMotionY(int, int, int, int, int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    _r1_o = this;
    _r2.i = n1;
    _r3.i = n2;
    _r4.i = n3;
    _r5.i = n4;
    _r6.i = n5;
    _r0_o = ((global::com.codename1.ui.animations.AnimationObject) _r1_o).createMotion((int) _r2.i, (int) _r3.i, (int) _r4.i, (int) _r5.i, (int) _r6.i);
    ((global::com.codename1.ui.animations.AnimationObject) _r1_o)._fmotionY = (global::com.codename1.ui.animations.Motion) _r0_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.AnimationObject: void defineMotionY(int, int, int, int, int)]
}

public virtual void defineOrientation(int n1, int n2, int n3, int n4, int n5){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.AnimationObject: void defineOrientation(int, int, int, int, int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    _r1_o = this;
    _r2.i = n1;
    _r3.i = n2;
    _r4.i = n3;
    _r5.i = n4;
    _r6.i = n5;
    _r0_o = ((global::com.codename1.ui.animations.AnimationObject) _r1_o).createMotion((int) _r2.i, (int) _r3.i, (int) _r4.i, (int) _r5.i, (int) _r6.i);
    ((global::com.codename1.ui.animations.AnimationObject) _r1_o)._forientation = (global::com.codename1.ui.animations.Motion) _r0_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.AnimationObject: void defineOrientation(int, int, int, int, int)]
}

public virtual void defineOpacity(int n1, int n2, int n3, int n4, int n5){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.AnimationObject: void defineOpacity(int, int, int, int, int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    _r1_o = this;
    _r2.i = n1;
    _r3.i = n2;
    _r4.i = n3;
    _r5.i = n4;
    _r6.i = n5;
    _r0_o = ((global::com.codename1.ui.animations.AnimationObject) _r1_o).createMotion((int) _r2.i, (int) _r3.i, (int) _r4.i, (int) _r5.i, (int) _r6.i);
    ((global::com.codename1.ui.animations.AnimationObject) _r1_o)._fopacity = (global::com.codename1.ui.animations.Motion) _r0_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.AnimationObject: void defineOpacity(int, int, int, int, int)]
}

public virtual void defineWidth(int n1, int n2, int n3, int n4, int n5){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.AnimationObject: void defineWidth(int, int, int, int, int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    _r1_o = this;
    _r2.i = n1;
    _r3.i = n2;
    _r4.i = n3;
    _r5.i = n4;
    _r6.i = n5;
    _r0_o = ((global::com.codename1.ui.animations.AnimationObject) _r1_o).createMotion((int) _r2.i, (int) _r3.i, (int) _r4.i, (int) _r5.i, (int) _r6.i);
    ((global::com.codename1.ui.animations.AnimationObject) _r1_o)._fwidth = (global::com.codename1.ui.animations.Motion) _r0_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.AnimationObject: void defineWidth(int, int, int, int, int)]
}

public virtual void defineHeight(int n1, int n2, int n3, int n4, int n5){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.AnimationObject: void defineHeight(int, int, int, int, int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    _r1_o = this;
    _r2.i = n1;
    _r3.i = n2;
    _r4.i = n3;
    _r5.i = n4;
    _r6.i = n5;
    _r0_o = ((global::com.codename1.ui.animations.AnimationObject) _r1_o).createMotion((int) _r2.i, (int) _r3.i, (int) _r4.i, (int) _r5.i, (int) _r6.i);
    ((global::com.codename1.ui.animations.AnimationObject) _r1_o)._fheight = (global::com.codename1.ui.animations.Motion) _r0_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.AnimationObject: void defineHeight(int, int, int, int, int)]
}

private global::System.Object createMotion(int n1, int n2, int n3, int n4, int n5){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.AnimationObject: com.codename1.ui.animations.Motion createMotion(int, int, int, int, int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r8;
    global::org.xmlvm._nElement _r9;
    _r4_o = this;
    _r5.i = n1;
    _r6.i = n2;
    _r7.i = n3;
    _r8.i = n4;
    _r9.i = n5;
    switch (_r5.i) {
    case 1: goto label28;
    case 2: goto label39;
    }
    _r1_o = new global::java.lang.IllegalArgumentException();
    _r2_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r2_o).@this();
    // Value=Motion type: 
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)77)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 58)), unchecked((char) unchecked((uint) 32))}));
    _r2_o = ((global::java.lang.StringBuilder) _r2_o).append((global::java.lang.String) _r3_o);
    _r2_o = ((global::java.lang.StringBuilder) _r2_o).append((int) _r5.i);
    _r2_o = ((global::java.lang.StringBuilder) _r2_o).toString();
    ((global::java.lang.IllegalArgumentException) _r1_o).@this((global::java.lang.String) _r2_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r1_o);
    label28:;
    _r1.i = _r6.i + _r7.i;
    _r0_o = global::com.codename1.ui.animations.Motion.createLinearMotion((int) _r8.i, (int) _r9.i, (int) _r1.i);
    label34:;
    _r1.l = (long) _r6.i;
    ((global::com.codename1.ui.animations.Motion) _r0_o).setStartTime((long) _r1.l);
    return (global::com.codename1.ui.animations.Motion) _r0_o;
    label39:;
    _r1.i = _r6.i + _r7.i;
    _r0_o = global::com.codename1.ui.animations.Motion.createSplineMotion((int) _r8.i, (int) _r9.i, (int) _r1.i);
    goto label34;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.AnimationObject: com.codename1.ui.animations.Motion createMotion(int, int, int, int, int)]
}

public virtual int getX(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.AnimationObject: int getX()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ui.animations.AnimationObject) _r1_o)._fmotionX;
    _r0.i = ((global::com.codename1.ui.animations.Motion) _r0_o).getValue();
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.AnimationObject: int getX()]
}

public virtual int getY(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.AnimationObject: int getY()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ui.animations.AnimationObject) _r1_o)._fmotionY;
    _r0.i = ((global::com.codename1.ui.animations.Motion) _r0_o).getValue();
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.AnimationObject: int getY()]
}

public virtual int getOrientation(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.AnimationObject: int getOrientation()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ui.animations.AnimationObject) _r1_o)._forientation;
    if (_r0_o != null) goto label6;
    _r0.i = 0;
    label5:;
    return _r0.i;
    label6:;
    _r0_o = ((global::com.codename1.ui.animations.AnimationObject) _r1_o)._forientation;
    _r0.i = ((global::com.codename1.ui.animations.Motion) _r0_o).getValue();
    goto label5;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.AnimationObject: int getOrientation()]
}

public virtual int getWidth(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.AnimationObject: int getWidth()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ui.animations.AnimationObject) _r1_o)._fwidth;
    if (_r0_o != null) goto label22;
    _r0_o = ((global::com.codename1.ui.animations.AnimationObject) _r1_o).getImage();
    if (_r0_o == null) goto label19;
    _r0_o = ((global::com.codename1.ui.animations.AnimationObject) _r1_o).getImage();
    _r0.i = ((global::com.codename1.ui.Image) _r0_o).getWidth();
    label18:;
    return _r0.i;
    label19:;
    _r0.i = 20;
    goto label18;
    label22:;
    _r0_o = ((global::com.codename1.ui.animations.AnimationObject) _r1_o)._fwidth;
    _r0.i = ((global::com.codename1.ui.animations.Motion) _r0_o).getValue();
    goto label18;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.AnimationObject: int getWidth()]
}

public virtual int getHeight(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.AnimationObject: int getHeight()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ui.animations.AnimationObject) _r1_o)._fheight;
    if (_r0_o != null) goto label22;
    _r0_o = ((global::com.codename1.ui.animations.AnimationObject) _r1_o).getImage();
    if (_r0_o == null) goto label19;
    _r0_o = ((global::com.codename1.ui.animations.AnimationObject) _r1_o).getImage();
    _r0.i = ((global::com.codename1.ui.Image) _r0_o).getHeight();
    label18:;
    return _r0.i;
    label19:;
    _r0.i = 20;
    goto label18;
    label22:;
    _r0_o = ((global::com.codename1.ui.animations.AnimationObject) _r1_o)._fheight;
    _r0.i = ((global::com.codename1.ui.animations.Motion) _r0_o).getValue();
    goto label18;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.AnimationObject: int getHeight()]
}

public virtual int getOpacity(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.AnimationObject: int getOpacity()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ui.animations.AnimationObject) _r1_o)._fopacity;
    if (_r0_o != null) goto label7;
    _r0.i = 255;
    label6:;
    return _r0.i;
    label7:;
    _r0_o = ((global::com.codename1.ui.animations.AnimationObject) _r1_o)._fopacity;
    _r0.i = ((global::com.codename1.ui.animations.Motion) _r0_o).getValue();
    goto label6;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.AnimationObject: int getOpacity()]
}

public virtual void draw(global::com.codename1.ui.Graphics n1, float n2, float n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.AnimationObject: void draw(com.codename1.ui.Graphics, float, float)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r7;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nElement _r8;
    global::System.Object _r9_o = null;
    global::System.Object _r10_o = null;
    global::org.xmlvm._nElement _r11;
    global::org.xmlvm._nElement _r12;
    _r9_o = this;
    _r10_o = n1;
    _r11.f = n2;
    _r12.f = n3;
    _r8.i = 1;
    _r1.i = ((global::com.codename1.ui.animations.AnimationObject) _r9_o).getOpacity();
    if (_r1.i != 0) goto label8;
    label7:;
    return;
    label8:;
    _r0_o = ((global::com.codename1.ui.animations.AnimationObject) _r9_o).getImage();
    if (_r0_o == null) goto label7;
    _r7.i = ((global::com.codename1.ui.animations.AnimationObject) _r9_o).getWidth();
    _r7.f = (float) _r7.i;
    _r7.f = _r7.f * _r11.f;
    _r4.i = (int) _r7.f;
    _r7.i = ((global::com.codename1.ui.animations.AnimationObject) _r9_o).getHeight();
    _r7.f = (float) _r7.i;
    _r7.f = _r7.f * _r12.f;
    _r3.i = (int) _r7.f;
    if (_r3.i < _r8.i) goto label7;
    if (_r4.i < _r8.i) goto label7;
    _r7_o = ((global::com.codename1.ui.animations.AnimationObject) _r9_o).getImage();
    _r0_o = ((global::com.codename1.ui.Image) _r7_o).scaled((int) _r4.i, (int) _r3.i);
    _r7.i = 255;
    if (_r1.i == _r7.i) goto label49;
    _r7.i = (_r1.i << 24) >> 24;
    _r0_o = ((global::com.codename1.ui.Image) _r0_o).modifyAlphaWithTranslucency((sbyte) _r7.i);
    label49:;
    _r2.i = ((global::com.codename1.ui.animations.AnimationObject) _r9_o).getOrientation();
    if (_r2.i == 0) goto label59;
    _r0_o = ((global::com.codename1.ui.Image) _r0_o).rotate((int) _r2.i);
    label59:;
    _r5.i = ((global::com.codename1.ui.animations.AnimationObject) _r9_o).getX();
    _r6.i = ((global::com.codename1.ui.animations.AnimationObject) _r9_o).getY();
    _r7.f = (float) _r5.i;
    _r7.f = _r7.f * _r11.f;
    _r5.i = (int) _r7.f;
    _r7.f = (float) _r6.i;
    _r7.f = _r7.f * _r12.f;
    _r6.i = (int) _r7.f;
    ((global::com.codename1.ui.Graphics) _r10_o).drawImage((global::com.codename1.ui.Image) _r0_o, (int) _r5.i, (int) _r6.i);
    goto label7;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.AnimationObject: void draw(com.codename1.ui.Graphics, float, float)]
}

public virtual int getStartTime(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.AnimationObject: int getStartTime()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.ui.animations.AnimationObject) _r1_o)._fstartTime;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.AnimationObject: int getStartTime()]
}

public virtual void setStartTime(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.AnimationObject: void setStartTime(int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.i = n1;
    ((global::com.codename1.ui.animations.AnimationObject) _r0_o)._fstartTime = _r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.AnimationObject: void setStartTime(int)]
}

public virtual int getEndTime(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.AnimationObject: int getEndTime()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.ui.animations.AnimationObject) _r1_o)._fendTime;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.AnimationObject: int getEndTime()]
}

public virtual void setEndTime(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.AnimationObject: void setEndTime(int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.i = n1;
    ((global::com.codename1.ui.animations.AnimationObject) _r0_o)._fendTime = _r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.AnimationObject: void setEndTime(int)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.AnimationObject]
//XMLVM_END_WRAPPER[com.codename1.ui.animations.AnimationObject]

} // end of class: AnimationObject

} // end of namespace: com.codename1.ui.animations
