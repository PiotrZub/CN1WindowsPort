// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.charts {
public class ChartUtil: global::java.lang.Object {
private global::com.codename1.charts.compat.Canvas _fc;

new public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.ChartUtil: void <init>()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    ((global::java.lang.Object) _r1_o).@this();
    _r0_o = new global::com.codename1.charts.compat.Canvas();
    ((global::com.codename1.charts.compat.Canvas) _r0_o).@this();
    ((global::com.codename1.charts.ChartUtil) _r1_o)._fc = (global::com.codename1.charts.compat.Canvas) _r0_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.ChartUtil: void <init>()]
}

public virtual void paintChart(global::com.codename1.ui.Graphics n1, global::com.codename1.charts.views.AbstractChart n2, global::com.codename1.ui.geom.Rectangle n3, int n4, int n5){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.ChartUtil: void paintChart(com.codename1.ui.Graphics, com.codename1.charts.views.AbstractChart, com.codename1.ui.geom.Rectangle, int, int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    global::System.Object _r8_o = null;
    global::System.Object _r9_o = null;
    global::System.Object _r10_o = null;
    global::org.xmlvm._nElement _r11;
    global::org.xmlvm._nElement _r12;
    _r7_o = this;
    _r8_o = n1;
    _r9_o = n2;
    _r10_o = n3;
    _r11.i = n4;
    _r12.i = n5;
    _r0_o = ((global::com.codename1.charts.ChartUtil) _r7_o)._fc;
    ((global::com.codename1.charts.compat.Canvas) _r0_o)._fg = (global::com.codename1.ui.Graphics) _r8_o;
    _r0_o = ((global::com.codename1.charts.ChartUtil) _r7_o)._fc;
    ((global::com.codename1.charts.compat.Canvas) _r0_o)._fbounds = (global::com.codename1.ui.geom.Rectangle) _r10_o;
    _r0_o = ((global::com.codename1.charts.ChartUtil) _r7_o)._fc;
    ((global::com.codename1.charts.compat.Canvas) _r0_o)._fabsoluteX = _r11.i;
    _r0_o = ((global::com.codename1.charts.ChartUtil) _r7_o)._fc;
    ((global::com.codename1.charts.compat.Canvas) _r0_o)._fabsoluteY = _r12.i;
    _r1_o = ((global::com.codename1.charts.ChartUtil) _r7_o)._fc;
    _r2.i = ((global::com.codename1.ui.geom.Rectangle) _r10_o).getX();
    _r3.i = ((global::com.codename1.ui.geom.Rectangle) _r10_o).getY();
    _r4.i = ((global::com.codename1.ui.geom.Rectangle) _r10_o).getWidth();
    _r5.i = ((global::com.codename1.ui.geom.Rectangle) _r10_o).getHeight();
    _r6_o = new global::com.codename1.charts.compat.Paint();
    ((global::com.codename1.charts.compat.Paint) _r6_o).@this();
    _r0_o = _r9_o;
    ((global::com.codename1.charts.views.AbstractChart) _r0_o).draw((global::com.codename1.charts.compat.Canvas) _r1_o, (int) _r2.i, (int) _r3.i, (int) _r4.i, (int) _r5.i, (global::com.codename1.charts.compat.Paint) _r6_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.ChartUtil: void paintChart(com.codename1.ui.Graphics, com.codename1.charts.views.AbstractChart, com.codename1.ui.geom.Rectangle, int, int)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.charts.ChartUtil]
//XMLVM_END_WRAPPER[com.codename1.charts.ChartUtil]

} // end of class: ChartUtil

} // end of namespace: com.codename1.charts
