// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.capture {
public class Capture: global::java.lang.Object {
new public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.capture.Capture: void <init>()]
    global::System.Object _r0_o = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.capture.Capture: void <init>()]
}

public static bool hasCamera(){
//XMLVM_BEGIN_WRAPPER[com.codename1.capture.Capture: boolean hasCamera()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    _r0_o = global::com.codename1.ui.Display.getInstance();
    _r0.i = ((global::com.codename1.ui.Display) _r0_o).hasCamera() ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.capture.Capture: boolean hasCamera()]
}

public static void capturePhoto(global::com.codename1.ui.events.ActionListener n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.capture.Capture: void capturePhoto(com.codename1.ui.events.ActionListener)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = n1;
    _r0_o = global::com.codename1.ui.Display.getInstance();
    ((global::com.codename1.ui.Display) _r0_o).capturePhoto((global::com.codename1.ui.events.ActionListener) _r1_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.capture.Capture: void capturePhoto(com.codename1.ui.events.ActionListener)]
}

public static global::System.Object capturePhoto(){
//XMLVM_BEGIN_WRAPPER[com.codename1.capture.Capture: java.lang.String capturePhoto()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    _r0.i = -1;
    _r0_o = global::com.codename1.capture.Capture.capturePhoto((int) _r0.i, (int) _r0.i);
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.capture.Capture: java.lang.String capturePhoto()]
}

public static global::System.Object captureAudio(){
//XMLVM_BEGIN_WRAPPER[com.codename1.capture.Capture: java.lang.String captureAudio()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = new global::com.codename1.capture.Capture_2CallBack();
    ((global::com.codename1.capture.Capture_2CallBack) _r0_o).@this();
    global::com.codename1.capture.Capture.captureAudio((global::com.codename1.ui.events.ActionListener) _r0_o);
    _r1_o = global::com.codename1.ui.Display.getInstance();
    ((global::com.codename1.ui.Display) _r1_o).invokeAndBlock((global::java.lang.Runnable) _r0_o);
    _r1_o = ((global::com.codename1.capture.Capture_2CallBack) _r0_o)._furl;
    return (global::java.lang.String) _r1_o;
//XMLVM_END_WRAPPER[com.codename1.capture.Capture: java.lang.String captureAudio()]
}

public static global::System.Object captureVideo(){
//XMLVM_BEGIN_WRAPPER[com.codename1.capture.Capture: java.lang.String captureVideo()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = new global::com.codename1.capture.Capture_2CallBack();
    ((global::com.codename1.capture.Capture_2CallBack) _r0_o).@this();
    global::com.codename1.capture.Capture.captureVideo((global::com.codename1.ui.events.ActionListener) _r0_o);
    _r1_o = global::com.codename1.ui.Display.getInstance();
    ((global::com.codename1.ui.Display) _r1_o).invokeAndBlock((global::java.lang.Runnable) _r0_o);
    _r1_o = ((global::com.codename1.capture.Capture_2CallBack) _r0_o)._furl;
    return (global::java.lang.String) _r1_o;
//XMLVM_END_WRAPPER[com.codename1.capture.Capture: java.lang.String captureVideo()]
}

public static global::System.Object capturePhoto(int n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.capture.Capture: java.lang.String capturePhoto(int, int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    _r2.i = n1;
    _r3.i = n2;
    _r0_o = new global::com.codename1.capture.Capture_2CallBack();
    ((global::com.codename1.capture.Capture_2CallBack) _r0_o).@this();
    global::com.codename1.capture.Capture_2CallBack.access_2002((global::com.codename1.capture.Capture_2CallBack) _r0_o, (int) _r2.i);
    global::com.codename1.capture.Capture_2CallBack.access_2102((global::com.codename1.capture.Capture_2CallBack) _r0_o, (int) _r3.i);
    global::com.codename1.capture.Capture.capturePhoto((global::com.codename1.ui.events.ActionListener) _r0_o);
    _r1_o = global::com.codename1.ui.Display.getInstance();
    ((global::com.codename1.ui.Display) _r1_o).invokeAndBlock((global::java.lang.Runnable) _r0_o);
    _r1_o = ((global::com.codename1.capture.Capture_2CallBack) _r0_o)._furl;
    return (global::java.lang.String) _r1_o;
//XMLVM_END_WRAPPER[com.codename1.capture.Capture: java.lang.String capturePhoto(int, int)]
}

public static void captureAudio(global::com.codename1.ui.events.ActionListener n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.capture.Capture: void captureAudio(com.codename1.ui.events.ActionListener)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = n1;
    _r0_o = global::com.codename1.ui.Display.getInstance();
    ((global::com.codename1.ui.Display) _r0_o).captureAudio((global::com.codename1.ui.events.ActionListener) _r1_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.capture.Capture: void captureAudio(com.codename1.ui.events.ActionListener)]
}

public static void captureVideo(global::com.codename1.ui.events.ActionListener n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.capture.Capture: void captureVideo(com.codename1.ui.events.ActionListener)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = n1;
    _r0_o = global::com.codename1.ui.Display.getInstance();
    ((global::com.codename1.ui.Display) _r0_o).captureVideo((global::com.codename1.ui.events.ActionListener) _r1_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.capture.Capture: void captureVideo(com.codename1.ui.events.ActionListener)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.capture.Capture]
//XMLVM_END_WRAPPER[com.codename1.capture.Capture]

} // end of class: Capture

} // end of namespace: com.codename1.capture
