// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.io.services {
public class ImageDownloadService_24: global::java.lang.Object,global::java.lang.Runnable {
public global::com.codename1.ui.Label _fval_2l;

public global::com.codename1.ui.Image _fval_2i;

public void @this(global::com.codename1.ui.Label n1, global::com.codename1.ui.Image n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.services.ImageDownloadService$4: void <init>(com.codename1.ui.Label, com.codename1.ui.Image)]
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
    ((global::com.codename1.io.services.ImageDownloadService_24) _r0_o)._fval_2l = (global::com.codename1.ui.Label) _r1_o;
    ((global::com.codename1.io.services.ImageDownloadService_24) _r0_o)._fval_2i = (global::com.codename1.ui.Image) _r2_o;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.io.services.ImageDownloadService$4: void <init>(com.codename1.ui.Label, com.codename1.ui.Image)]
}

public virtual void run(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.services.ImageDownloadService$4: void run()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r3_o = this;
    _r1_o = ((global::com.codename1.io.services.ImageDownloadService_24) _r3_o)._fval_2l;
    _r2_o = ((global::com.codename1.io.services.ImageDownloadService_24) _r3_o)._fval_2i;
    ((global::com.codename1.ui.Label) _r1_o).setIcon((global::com.codename1.ui.Image) _r2_o);
    _r1_o = ((global::com.codename1.io.services.ImageDownloadService_24) _r3_o)._fval_2l;
    _r0_o = ((global::com.codename1.ui.Label) _r1_o).getComponentForm();
    if (_r0_o == null) goto label18;
    ((global::com.codename1.ui.Form) _r0_o).revalidate();
    label18:;
    return;
//XMLVM_END_WRAPPER[com.codename1.io.services.ImageDownloadService$4: void run()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.io.services.ImageDownloadService$4]
//XMLVM_END_WRAPPER[com.codename1.io.services.ImageDownloadService$4]

} // end of class: ImageDownloadService_24

} // end of namespace: com.codename1.io.services
