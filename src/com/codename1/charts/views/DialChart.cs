// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.charts.views {
public class DialChart: global::com.codename1.charts.views.RoundChart {

new private global::com.codename1.charts.renderers.DialRenderer _fmRenderer;

public void @this(global::com.codename1.charts.models.CategorySeries n1, global::com.codename1.charts.renderers.DialRenderer n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.DialChart: void <init>(com.codename1.charts.models.CategorySeries, com.codename1.charts.renderers.DialRenderer)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    ((global::com.codename1.charts.views.RoundChart) _r0_o).@this((global::com.codename1.charts.models.CategorySeries) _r1_o, (global::com.codename1.charts.renderers.DefaultRenderer) _r2_o);
    ((global::com.codename1.charts.views.DialChart) _r0_o)._fmRenderer = (global::com.codename1.charts.renderers.DialRenderer) _r2_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.views.DialChart: void <init>(com.codename1.charts.models.CategorySeries, com.codename1.charts.renderers.DialRenderer)]
}

public override void draw(global::com.codename1.charts.compat.Canvas n1, int n2, int n3, int n4, int n5, global::com.codename1.charts.compat.Paint n6){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.DialChart: void draw(com.codename1.charts.compat.Canvas, int, int, int, int, com.codename1.charts.compat.Paint)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nElement _r8;
    global::org.xmlvm._nElement _r9;
    global::org.xmlvm._nElement _r10;
    global::org.xmlvm._nElement _r11;
    global::org.xmlvm._nElement _r12;
    global::org.xmlvm._nElement _r13;
    global::System.Object _r14_o = null;
    global::org.xmlvm._nElement _r15;
    global::System.Object _r15_o = null;
    global::org.xmlvm._nElement _r16;
    global::System.Object _r16_o = null;
    global::org.xmlvm._nElement _r17;
    global::org.xmlvm._nElement _r18;
    global::org.xmlvm._nElement _r19;
    global::org.xmlvm._nElement _r20;
    global::System.Object _r21_o = null;
    global::org.xmlvm._nElement _r22;
    global::org.xmlvm._nElement _r23;
    global::org.xmlvm._nElement _r24;
    global::System.Object _r24_o = null;
    global::org.xmlvm._nElement _r25;
    global::System.Object _r25_o = null;
    global::org.xmlvm._nElement _r26;
    global::org.xmlvm._nElement _r27;
    global::org.xmlvm._nElement _r28;
    global::System.Object _r29_o = null;
    global::org.xmlvm._nElement _r30;
    global::System.Object _r32_o = null;
    global::org.xmlvm._nElement _r33;
    global::System.Object _r33_o = null;
    global::org.xmlvm._nElement _r34;
    global::org.xmlvm._nElement _r35;
    global::org.xmlvm._nElement _r36;
    global::org.xmlvm._nElement _r37;
    global::org.xmlvm._nElement _r38;
    global::org.xmlvm._nElement _r39;
    global::org.xmlvm._nElement _r40;
    global::org.xmlvm._nElement _r41;
    global::System.Object _r41_o = null;
    global::org.xmlvm._nElement _r42;
    global::org.xmlvm._nElement _r43;
    global::org.xmlvm._nElement _r44;
    global::org.xmlvm._nElement _r46;
    global::org.xmlvm._nElement _r48;
    global::System.Object _r50_o = null;
    global::org.xmlvm._nElement _r51;
    global::org.xmlvm._nElement _r52;
    global::org.xmlvm._nElement _r53;
    global::org.xmlvm._nElement _r54;
    global::org.xmlvm._nElement _r55;
    global::org.xmlvm._nElement _r56;
    global::org.xmlvm._nElement _r57;
    global::org.xmlvm._nElement _r58;
    global::org.xmlvm._nElement _r59;
    global::org.xmlvm._nElement _r60;
    global::org.xmlvm._nElement _r61;
    global::System.Object _r63_o = null;
    global::System.Object _r64_o = null;
    global::org.xmlvm._nElement _r65;
    global::org.xmlvm._nElement _r66;
    global::org.xmlvm._nElement _r67;
    global::org.xmlvm._nElement _r68;
    global::System.Object _r69_o = null;
    _r63_o = this;
    _r64_o = n1;
    _r65.i = n2;
    _r66.i = n3;
    _r67.i = n4;
    _r68.i = n5;
    _r69_o = n6;
    _r0_o = _r63_o;
    _r0_o = ((global::com.codename1.charts.views.DialChart) _r0_o)._fmRenderer;
    _r4_o = _r0_o;
    _r4.i = ((global::com.codename1.charts.renderers.DialRenderer) _r4_o).isAntialiasing() ? 1 : 0;
    _r0_o = _r69_o;
    _r1.i = _r4.i;
    ((global::com.codename1.charts.compat.Paint) _r0_o).setAntiAlias(0!=_r1.i);
    _r4_o = global::com.codename1.charts.compat.Paint_2Style._fFILL;
    _r0_o = _r69_o;
    _r1_o = _r4_o;
    ((global::com.codename1.charts.compat.Paint) _r0_o).setStyle((global::com.codename1.charts.compat.Paint_2Style) _r1_o);
    _r0_o = _r63_o;
    _r0_o = ((global::com.codename1.charts.views.DialChart) _r0_o)._fmRenderer;
    _r4_o = _r0_o;
    _r4.f = ((global::com.codename1.charts.renderers.DialRenderer) _r4_o).getLabelsTextSize();
    _r0_o = _r69_o;
    _r1.f = _r4.f;
    ((global::com.codename1.charts.compat.Paint) _r0_o).setTextSize((float) _r1.f);
    _r0_o = _r63_o;
    _r0_o = ((global::com.codename1.charts.views.DialChart) _r0_o)._fmRenderer;
    _r4_o = _r0_o;
    _r5.i = _r68.i / 5;
    _r6.f = (float)0.0D;
    _r0_o = _r63_o;
    _r1_o = _r4_o;
    _r2.i = _r5.i;
    _r3.f = _r6.f;
    _r13.i = ((global::com.codename1.charts.views.DialChart) _r0_o).getLegendSize((global::com.codename1.charts.renderers.DefaultRenderer) _r1_o, (int) _r2.i, (float) _r3.f);
    _r8.i = _r65.i;
    _r60.i = _r66.i;
    _r9.i = _r65.i + _r67.i;
    _r0_o = _r63_o;
    _r0_o = ((global::com.codename1.charts.views.DialChart) _r0_o)._fmDataset;
    _r4_o = _r0_o;
    _r58.i = ((global::com.codename1.charts.models.CategorySeries) _r4_o).getItemCount();
    _r0.i = _r58.i;
    _r0_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r0.i]);
    _r7_o = _r0_o;
    _r54.i = 0;
    label77:;
    _r0.i = _r54.i;
    _r1.i = _r58.i;
    if (_r0.i >= _r1.i) goto label100;
    _r0_o = _r63_o;
    _r0_o = ((global::com.codename1.charts.views.DialChart) _r0_o)._fmDataset;
    _r4_o = _r0_o;
    _r0_o = _r4_o;
    _r1.i = _r54.i;
    _r4_o = ((global::com.codename1.charts.models.CategorySeries) _r0_o).getCategory((int) _r1.i);
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r7_o)[_r54.i] = _r4_o;
    _r54.i = _r54.i + 1;
    goto label77;
    label100:;
    _r0_o = _r63_o;
    _r0_o = ((global::com.codename1.charts.views.DialChart) _r0_o)._fmRenderer;
    _r4_o = _r0_o;
    _r4.i = ((global::com.codename1.charts.renderers.DialRenderer) _r4_o).isFitLegend() ? 1 : 0;
    if (_r4.i == 0) goto label133;
    _r0_o = _r63_o;
    _r0_o = ((global::com.codename1.charts.views.DialChart) _r0_o)._fmRenderer;
    _r6_o = _r0_o;
    _r15.i = 1;
    _r4_o = _r63_o;
    _r5_o = _r64_o;
    _r10.i = _r66.i;
    _r11.i = _r67.i;
    _r12.i = _r68.i;
    _r14_o = _r69_o;
    _r13.i = ((global::com.codename1.charts.views.DialChart) _r4_o).drawLegend((global::com.codename1.charts.compat.Canvas) _r5_o, (global::com.codename1.charts.renderers.DefaultRenderer) _r6_o, (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r7_o, (int) _r8.i, (int) _r9.i, (int) _r10.i, (int) _r11.i, (int) _r12.i, (int) _r13.i, (global::com.codename1.charts.compat.Paint) _r14_o, 0!=_r15.i);
    label133:;
    _r4.i = _r66.i + _r68.i;
    _r52.i = _r4.i - _r13.i;
    _r0_o = _r63_o;
    _r0_o = ((global::com.codename1.charts.views.DialChart) _r0_o)._fmRenderer;
    _r15_o = _r0_o;
    _r22.i = 0;
    _r23.i = 0;
    _r14_o = _r63_o;
    _r16_o = _r64_o;
    _r17.i = _r65.i;
    _r18.i = _r66.i;
    _r19.i = _r67.i;
    _r20.i = _r68.i;
    _r21_o = _r69_o;
    ((global::com.codename1.charts.views.DialChart) _r14_o).drawBackground((global::com.codename1.charts.renderers.DefaultRenderer) _r15_o, (global::com.codename1.charts.compat.Canvas) _r16_o, (int) _r17.i, (int) _r18.i, (int) _r19.i, (int) _r20.i, (global::com.codename1.charts.compat.Paint) _r21_o, 0!=_r22.i, (int) _r23.i);
    _r4.i = _r9.i - _r8.i;
    _r4.i = global::java.lang.Math.abs((int) _r4.i);
    _r5.i = _r52.i - _r60.i;
    _r5.i = global::java.lang.Math.abs((int) _r5.i);
    _r56.i = global::java.lang.Math.min((int) _r4.i, (int) _r5.i);
    _r0.i = _r56.i;
    _r0.d = (double) _r0.i;
    _r4.d = _r0.d;
    _r10.d = 0.35D;
    _r4.d = _r4.d * _r10.d;
    _r0_o = _r63_o;
    _r0_o = ((global::com.codename1.charts.views.DialChart) _r0_o)._fmRenderer;
    _r6_o = _r0_o;
    _r6.f = ((global::com.codename1.charts.renderers.DialRenderer) _r6_o).getScale();
    _r10.d = (double) _r6.f;
    _r4.d = _r4.d * _r10.d;
    _r0.d = _r4.d;
    _r0.i = (int) _r0.d;
    _r57.i = _r0.i;
    _r0_o = _r63_o;
    _r0.i = ((global::com.codename1.charts.views.DialChart) _r0_o)._fautoCalculateCenter ? 1 : 0;
    _r4.i = _r0.i;
    if (_r4.i != 0) goto label221;
    _r0_o = _r63_o;
    _r0.i = ((global::com.codename1.charts.views.DialChart) _r0_o)._fmCenterX;
    _r4.i = _r0.i;
    _r5.i = 2147483647;
    if (_r4.i != _r5.i) goto label230;
    label221:;
    _r4.i = _r8.i + _r9.i;
    _r4.i = _r4.i / 2;
    _r0.i = _r4.i;
    _r1_o = _r63_o;
    ((global::com.codename1.charts.views.DialChart) _r1_o)._fmCenterX = _r0.i;
    label230:;
    _r0_o = _r63_o;
    _r0.i = ((global::com.codename1.charts.views.DialChart) _r0_o)._fautoCalculateCenter ? 1 : 0;
    _r4.i = _r0.i;
    if (_r4.i != 0) goto label247;
    _r0_o = _r63_o;
    _r0.i = ((global::com.codename1.charts.views.DialChart) _r0_o)._fmCenterY;
    _r4.i = _r0.i;
    _r5.i = 2147483647;
    if (_r4.i != _r5.i) goto label256;
    label247:;
    _r4.i = _r52.i + _r60.i;
    _r4.i = _r4.i / 2;
    _r0.i = _r4.i;
    _r1_o = _r63_o;
    ((global::com.codename1.charts.views.DialChart) _r1_o)._fmCenterY = _r0.i;
    label256:;
    _r0.i = _r57.i;
    _r0.f = (float) _r0.i;
    _r4.f = _r0.f;
    _r5.f = (float)0.9D;
    _r59.f = _r4.f * _r5.f;
    _r0.i = _r57.i;
    _r0.f = (float) _r0.i;
    _r4.f = _r0.f;
    _r5.f = (float)1.1D;
    _r55.f = _r4.f * _r5.f;
    _r0_o = _r63_o;
    _r0_o = ((global::com.codename1.charts.views.DialChart) _r0_o)._fmRenderer;
    _r4_o = _r0_o;
    _r16.d = ((global::com.codename1.charts.renderers.DialRenderer) _r4_o).getMinValue();
    _r0_o = _r63_o;
    _r0_o = ((global::com.codename1.charts.views.DialChart) _r0_o)._fmRenderer;
    _r4_o = _r0_o;
    _r18.d = ((global::com.codename1.charts.renderers.DialRenderer) _r4_o).getMaxValue();
    _r0_o = _r63_o;
    _r0_o = ((global::com.codename1.charts.views.DialChart) _r0_o)._fmRenderer;
    _r4_o = _r0_o;
    _r20.d = ((global::com.codename1.charts.renderers.DialRenderer) _r4_o).getAngleMin();
    _r0_o = _r63_o;
    _r0_o = ((global::com.codename1.charts.views.DialChart) _r0_o)._fmRenderer;
    _r4_o = _r0_o;
    _r22.d = ((global::com.codename1.charts.renderers.DialRenderer) _r4_o).getAngleMax();
    _r0_o = _r63_o;
    _r0_o = ((global::com.codename1.charts.views.DialChart) _r0_o)._fmRenderer;
    _r4_o = _r0_o;
    _r4.i = ((global::com.codename1.charts.renderers.DialRenderer) _r4_o).isMinValueSet() ? 1 : 0;
    if (_r4.i == 0) goto label332;
    _r0_o = _r63_o;
    _r0_o = ((global::com.codename1.charts.views.DialChart) _r0_o)._fmRenderer;
    _r4_o = _r0_o;
    _r4.i = ((global::com.codename1.charts.renderers.DialRenderer) _r4_o).isMaxValueSet() ? 1 : 0;
    if (_r4.i != 0) goto label402;
    label332:;
    _r0_o = _r63_o;
    _r0_o = ((global::com.codename1.charts.views.DialChart) _r0_o)._fmRenderer;
    _r4_o = _r0_o;
    _r53.i = ((global::com.codename1.charts.renderers.DialRenderer) _r4_o).getSeriesRendererCount();
    _r54.i = 0;
    label343:;
    _r0.i = _r54.i;
    _r1.i = _r53.i;
    if (_r0.i >= _r1.i) goto label402;
    _r0_o = _r63_o;
    _r0_o = ((global::com.codename1.charts.views.DialChart) _r0_o)._fmDataset;
    _r4_o = _r0_o;
    _r0_o = _r4_o;
    _r1.i = _r54.i;
    _r61.d = ((global::com.codename1.charts.models.CategorySeries) _r0_o).getValue((int) _r1.i);
    _r0_o = _r63_o;
    _r0_o = ((global::com.codename1.charts.views.DialChart) _r0_o)._fmRenderer;
    _r4_o = _r0_o;
    _r4.i = ((global::com.codename1.charts.renderers.DialRenderer) _r4_o).isMinValueSet() ? 1 : 0;
    if (_r4.i != 0) goto label380;
    _r0.d = _r16.d;
    _r2.d = _r61.d;
    _r16.d = global::java.lang.Math.min((double) _r0.d, (double) _r2.d);
    label380:;
    _r0_o = _r63_o;
    _r0_o = ((global::com.codename1.charts.views.DialChart) _r0_o)._fmRenderer;
    _r4_o = _r0_o;
    _r4.i = ((global::com.codename1.charts.renderers.DialRenderer) _r4_o).isMaxValueSet() ? 1 : 0;
    if (_r4.i != 0) goto label399;
    _r0.d = _r18.d;
    _r2.d = _r61.d;
    _r18.d = global::java.lang.Math.max((double) _r0.d, (double) _r2.d);
    label399:;
    _r54.i = _r54.i + 1;
    goto label343;
    label402:;
    _r4.i = _r16.d > _r18.d ? 1 : (_r16.d == _r18.d ? 0 : -1);
    if (_r4.i != 0) goto label414;
    _r4.d = 0.5D;
    _r16.d = _r16.d * _r4.d;
    _r4.d = 1.5D;
    _r18.d = _r18.d * _r4.d;
    label414:;
    _r0_o = _r63_o;
    _r0_o = ((global::com.codename1.charts.views.DialChart) _r0_o)._fmRenderer;
    _r4_o = _r0_o;
    _r4.i = ((global::com.codename1.charts.renderers.DialRenderer) _r4_o).getLabelsColor();
    _r0_o = _r69_o;
    _r1.i = _r4.i;
    ((global::com.codename1.charts.compat.Paint) _r0_o).setColor((int) _r1.i);
    _r0_o = _r63_o;
    _r0_o = ((global::com.codename1.charts.views.DialChart) _r0_o)._fmRenderer;
    _r4_o = _r0_o;
    _r30.d = ((global::com.codename1.charts.renderers.DialRenderer) _r4_o).getMinorTicksSpacing();
    _r0_o = _r63_o;
    _r0_o = ((global::com.codename1.charts.views.DialChart) _r0_o)._fmRenderer;
    _r4_o = _r0_o;
    _r48.d = ((global::com.codename1.charts.renderers.DialRenderer) _r4_o).getMajorTicksSpacing();
    _r4.d = 0.0D;
    _r4.i = _r30.d > _r4.d ? 1 : (_r30.d == _r4.d ? 0 : -1);
    if (_r4.i != 0) goto label459;
    _r4.d = _r18.d - _r16.d;
    _r10.d = 30.0D;
    _r30.d = _r4.d / _r10.d;
    label459:;
    _r4.d = 0.0D;
    _r4.i = _r48.d > _r4.d ? 1 : (_r48.d == _r4.d ? 0 : -1);
    if (_r4.i != 0) goto label471;
    _r4.d = _r18.d - _r16.d;
    _r10.d = 10.0D;
    _r48.d = _r4.d / _r10.d;
    label471:;
    _r0_o = _r63_o;
    _r0.i = ((global::com.codename1.charts.views.DialChart) _r0_o)._fmCenterX;
    _r24.i = _r0.i;
    _r0_o = _r63_o;
    _r0.i = ((global::com.codename1.charts.views.DialChart) _r0_o)._fmCenterY;
    _r25.i = _r0.i;
    _r0.f = _r55.f;
    _r0.d = (double) _r0.f;
    _r26.d = _r0.d;
    _r0.i = _r57.i;
    _r0.d = (double) _r0.i;
    _r28.d = _r0.d;
    _r33.i = 0;
    _r14_o = _r63_o;
    _r15_o = _r64_o;
    _r32_o = _r69_o;
    ((global::com.codename1.charts.views.DialChart) _r14_o).drawTicks((global::com.codename1.charts.compat.Canvas) _r15_o, (double) _r16.d, (double) _r18.d, (double) _r20.d, (double) _r22.d, (int) _r24.i, (int) _r25.i, (double) _r26.d, (double) _r28.d, (double) _r30.d, (global::com.codename1.charts.compat.Paint) _r32_o, 0!=_r33.i);
    _r0_o = _r63_o;
    _r0.i = ((global::com.codename1.charts.views.DialChart) _r0_o)._fmCenterX;
    _r42.i = _r0.i;
    _r0_o = _r63_o;
    _r0.i = ((global::com.codename1.charts.views.DialChart) _r0_o)._fmCenterY;
    _r43.i = _r0.i;
    _r0.f = _r55.f;
    _r0.d = (double) _r0.f;
    _r44.d = _r0.d;
    _r0.f = _r59.f;
    _r0.d = (double) _r0.f;
    _r46.d = _r0.d;
    _r51.i = 1;
    _r32_o = _r63_o;
    _r33_o = _r64_o;
    _r34.d = _r16.d;
    _r36.d = _r18.d;
    _r38.d = _r20.d;
    _r40.d = _r22.d;
    _r50_o = _r69_o;
    ((global::com.codename1.charts.views.DialChart) _r32_o).drawTicks((global::com.codename1.charts.compat.Canvas) _r33_o, (double) _r34.d, (double) _r36.d, (double) _r38.d, (double) _r40.d, (int) _r42.i, (int) _r43.i, (double) _r44.d, (double) _r46.d, (double) _r48.d, (global::com.codename1.charts.compat.Paint) _r50_o, 0!=_r51.i);
    _r0_o = _r63_o;
    _r0_o = ((global::com.codename1.charts.views.DialChart) _r0_o)._fmRenderer;
    _r4_o = _r0_o;
    _r53.i = ((global::com.codename1.charts.renderers.DialRenderer) _r4_o).getSeriesRendererCount();
    _r54.i = 0;
    label556:;
    _r0.i = _r54.i;
    _r1.i = _r53.i;
    if (_r0.i >= _r1.i) goto label662;
    _r0_o = _r63_o;
    _r0_o = ((global::com.codename1.charts.views.DialChart) _r0_o)._fmDataset;
    _r4_o = _r0_o;
    _r0_o = _r4_o;
    _r1.i = _r54.i;
    _r33.d = ((global::com.codename1.charts.models.CategorySeries) _r0_o).getValue((int) _r1.i);
    _r32_o = _r63_o;
    _r35.d = _r20.d;
    _r37.d = _r22.d;
    _r39.d = _r16.d;
    _r41.d = _r18.d;
    _r34.d = ((global::com.codename1.charts.views.DialChart) _r32_o).getAngleForValue((double) _r33.d, (double) _r35.d, (double) _r37.d, (double) _r39.d, (double) _r41.d);
    _r0_o = _r63_o;
    _r0_o = ((global::com.codename1.charts.views.DialChart) _r0_o)._fmRenderer;
    _r4_o = _r0_o;
    _r0_o = _r4_o;
    _r1.i = _r54.i;
    _r4_o = ((global::com.codename1.charts.renderers.DialRenderer) _r0_o).getSeriesRendererAt((int) _r1.i);
    _r4.i = ((global::com.codename1.charts.renderers.SimpleSeriesRenderer) _r4_o).getColor();
    _r0_o = _r69_o;
    _r1.i = _r4.i;
    ((global::com.codename1.charts.compat.Paint) _r0_o).setColor((int) _r1.i);
    _r0_o = _r63_o;
    _r0_o = ((global::com.codename1.charts.views.DialChart) _r0_o)._fmRenderer;
    _r4_o = _r0_o;
    _r0_o = _r4_o;
    _r1.i = _r54.i;
    _r4_o = ((global::com.codename1.charts.renderers.DialRenderer) _r0_o).getVisualTypeForIndex((int) _r1.i);
    _r5_o = global::com.codename1.charts.renderers.DialRenderer_2Type._fARROW;
    if (_r4_o != _r5_o) goto label658;
    _r4.i = 1;
    _r40.i = _r4.i;
    label629:;
    _r0_o = _r63_o;
    _r0.i = ((global::com.codename1.charts.views.DialChart) _r0_o)._fmCenterX;
    _r36.i = _r0.i;
    _r0_o = _r63_o;
    _r0.i = ((global::com.codename1.charts.views.DialChart) _r0_o)._fmCenterY;
    _r37.i = _r0.i;
    _r0.f = _r59.f;
    _r0.d = (double) _r0.f;
    _r38.d = _r0.d;
    _r32_o = _r63_o;
    _r33_o = _r64_o;
    _r41_o = _r69_o;
    ((global::com.codename1.charts.views.DialChart) _r32_o).drawNeedle((global::com.codename1.charts.compat.Canvas) _r33_o, (double) _r34.d, (int) _r36.i, (int) _r37.i, (double) _r38.d, 0!=_r40.i, (global::com.codename1.charts.compat.Paint) _r41_o);
    _r54.i = _r54.i + 1;
    goto label556;
    label658:;
    _r4.i = 0;
    _r40.i = _r4.i;
    goto label629;
    label662:;
    _r0_o = _r63_o;
    _r0_o = ((global::com.codename1.charts.views.DialChart) _r0_o)._fmRenderer;
    _r6_o = _r0_o;
    _r15.i = 0;
    _r4_o = _r63_o;
    _r5_o = _r64_o;
    _r10.i = _r66.i;
    _r11.i = _r67.i;
    _r12.i = _r68.i;
    _r14_o = _r69_o;
    ((global::com.codename1.charts.views.DialChart) _r4_o).drawLegend((global::com.codename1.charts.compat.Canvas) _r5_o, (global::com.codename1.charts.renderers.DefaultRenderer) _r6_o, (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r7_o, (int) _r8.i, (int) _r9.i, (int) _r10.i, (int) _r11.i, (int) _r12.i, (int) _r13.i, (global::com.codename1.charts.compat.Paint) _r14_o, 0!=_r15.i);
    _r24_o = _r63_o;
    _r25_o = _r64_o;
    _r26.i = _r65.i;
    _r27.i = _r66.i;
    _r28.i = _r67.i;
    _r29_o = _r69_o;
    ((global::com.codename1.charts.views.DialChart) _r24_o).drawTitle((global::com.codename1.charts.compat.Canvas) _r25_o, (int) _r26.i, (int) _r27.i, (int) _r28.i, (global::com.codename1.charts.compat.Paint) _r29_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.views.DialChart: void draw(com.codename1.charts.compat.Canvas, int, int, int, int, com.codename1.charts.compat.Paint)]
}

private double getAngleForValue(double n1, double n2, double n3, double n4, double n5){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.DialChart: double getAngleForValue(double, double, double, double, double)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r9;
    global::org.xmlvm._nElement _r11;
    global::org.xmlvm._nElement _r13;
    global::org.xmlvm._nElement _r15;
    _r6_o = this;
    _r7.d = n1;
    _r9.d = n2;
    _r11.d = n3;
    _r13.d = n4;
    _r15.d = n5;
    _r0.d = _r11.d - _r9.d;
    _r2.d = _r15.d - _r13.d;
    _r4.d = _r7.d - _r13.d;
    _r4.d = _r4.d * _r0.d;
    _r4.d = _r4.d / _r2.d;
    _r4.d = _r4.d + _r9.d;
    _r4.d = global::java.lang.Math.toRadians((double) _r4.d);
    return _r4.d;
//XMLVM_END_WRAPPER[com.codename1.charts.views.DialChart: double getAngleForValue(double, double, double, double, double)]
}

private void drawTicks(global::com.codename1.charts.compat.Canvas n1, double n2, double n3, double n4, double n5, int n6, int n7, double n8, double n9, double n10, global::com.codename1.charts.compat.Paint n11, bool n12){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.DialChart: void drawTicks(com.codename1.charts.compat.Canvas, double, double, double, double, int, int, double, double, double, com.codename1.charts.compat.Paint, boolean)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r8;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nElement _r9;
    global::org.xmlvm._nElement _r10;
    global::org.xmlvm._nElement _r11;
    global::org.xmlvm._nElement _r12;
    global::System.Object _r13_o = null;
    global::org.xmlvm._nElement _r14;
    global::org.xmlvm._nElement _r16;
    global::org.xmlvm._nElement _r18;
    global::org.xmlvm._nElement _r20;
    global::System.Object _r22_o = null;
    global::org.xmlvm._nElement _r23;
    global::org.xmlvm._nElement _r24;
    global::org.xmlvm._nElement _r25;
    global::org.xmlvm._nElement _r26;
    global::System.Object _r27_o = null;
    global::System.Object _r28_o = null;
    global::org.xmlvm._nElement _r29;
    global::org.xmlvm._nElement _r31;
    global::org.xmlvm._nElement _r33;
    global::org.xmlvm._nElement _r35;
    global::org.xmlvm._nElement _r37;
    global::org.xmlvm._nElement _r38;
    global::org.xmlvm._nElement _r39;
    global::org.xmlvm._nElement _r41;
    global::org.xmlvm._nElement _r43;
    global::System.Object _r45_o = null;
    global::org.xmlvm._nElement _r46;
    _r27_o = this;
    _r28_o = n1;
    _r29.d = n2;
    _r31.d = n3;
    _r33.d = n4;
    _r35.d = n5;
    _r37.i = n6;
    _r38.i = n7;
    _r39.d = n8;
    _r41.d = n9;
    _r43.d = n10;
    _r45_o = n11;
    _r46.i = n12 ? 1 : 0;
    _r6.d = _r29.d;
    label2:;
    _r5.i = _r6.d > _r31.d ? 1 : (_r6.d == _r31.d ? 0 : -1);
    if (_r5.i > 0) goto label192;
    _r5_o = _r27_o;
    _r8.d = _r33.d;
    _r10.d = _r35.d;
    _r12.d = _r29.d;
    _r14.d = _r31.d;
    _r16.d = ((global::com.codename1.charts.views.DialChart) _r5_o).getAngleForValue((double) _r6.d, (double) _r8.d, (double) _r10.d, (double) _r12.d, (double) _r14.d);
    _r20.d = global::java.lang.Math.sin((double) _r16.d);
    _r18.d = global::java.lang.Math.cos((double) _r16.d);
    _r0.i = _r37.i;
    _r0.f = (float) _r0.i;
    _r5.f = _r0.f;
    _r8.d = _r41.d * _r20.d;
    _r8.f = (float) _r8.d;
    _r5.f = _r5.f + _r8.f;
    _r23.i = global::java.lang.Math.round((float) _r5.f);
    _r0.i = _r38.i;
    _r0.f = (float) _r0.i;
    _r5.f = _r0.f;
    _r8.d = _r41.d * _r18.d;
    _r8.f = (float) _r8.d;
    _r5.f = _r5.f + _r8.f;
    _r25.i = global::java.lang.Math.round((float) _r5.f);
    _r0.i = _r37.i;
    _r0.f = (float) _r0.i;
    _r5.f = _r0.f;
    _r8.d = _r39.d * _r20.d;
    _r8.f = (float) _r8.d;
    _r5.f = _r5.f + _r8.f;
    _r24.i = global::java.lang.Math.round((float) _r5.f);
    _r0.i = _r38.i;
    _r0.f = (float) _r0.i;
    _r5.f = _r0.f;
    _r8.d = _r39.d * _r18.d;
    _r8.f = (float) _r8.d;
    _r5.f = _r5.f + _r8.f;
    _r26.i = global::java.lang.Math.round((float) _r5.f);
    _r0.i = _r23.i;
    _r0.f = (float) _r0.i;
    _r9.f = _r0.f;
    _r0.i = _r25.i;
    _r0.f = (float) _r0.i;
    _r10.f = _r0.f;
    _r0.i = _r24.i;
    _r0.f = (float) _r0.i;
    _r11.f = _r0.f;
    _r0.i = _r26.i;
    _r0.f = (float) _r0.i;
    _r12.f = _r0.f;
    _r8_o = _r28_o;
    _r13_o = _r45_o;
    ((global::com.codename1.charts.compat.Canvas) _r8_o).drawLine((float) _r9.f, (float) _r10.f, (float) _r11.f, (float) _r12.f, (global::com.codename1.charts.compat.Paint) _r13_o);
    if (_r46.i == 0) goto label188;
    _r5.i = 1;
    _r0_o = _r45_o;
    _r1.i = _r5.i;
    ((global::com.codename1.charts.compat.Paint) _r0_o).setTextAlign((int) _r1.i);
    _r0.i = _r23.i;
    _r1.i = _r24.i;
    if (_r0.i > _r1.i) goto label121;
    _r5.i = 3;
    _r0_o = _r45_o;
    _r1.i = _r5.i;
    ((global::com.codename1.charts.compat.Paint) _r0_o).setTextAlign((int) _r1.i);
    label121:;
    _r5_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r5_o).@this();
    _r5_o = ((global::java.lang.StringBuilder) _r5_o).append((double) _r6.d);
    // Value=
    _r8_o = new global::java.lang.String();
    ((global::java.lang.String)_r8_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    _r5_o = ((global::java.lang.StringBuilder) _r5_o).append((global::java.lang.String) _r8_o);
    _r22_o = ((global::java.lang.StringBuilder) _r5_o).toString();
    _r8.l = global::java.lang.Math.round((double) _r6.d);
    _r10.l = (long) _r6.d;
    _r5.i = _r8.l > _r10.l ? 1 : (_r8.l == _r10.l ? 0 : -1);
    if (_r5.i != 0) goto label169;
    _r5_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r5_o).@this();
    _r8.l = (long) _r6.d;
    _r5_o = ((global::java.lang.StringBuilder) _r5_o).append((long) _r8.l);
    // Value=
    _r8_o = new global::java.lang.String();
    ((global::java.lang.String)_r8_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    _r5_o = ((global::java.lang.StringBuilder) _r5_o).append((global::java.lang.String) _r8_o);
    _r22_o = ((global::java.lang.StringBuilder) _r5_o).toString();
    label169:;
    _r0.i = _r23.i;
    _r0.f = (float) _r0.i;
    _r5.f = _r0.f;
    _r0.i = _r25.i;
    _r0.f = (float) _r0.i;
    _r8.f = _r0.f;
    _r0_o = _r28_o;
    _r1_o = _r22_o;
    _r2.f = _r5.f;
    _r3.f = _r8.f;
    _r4_o = _r45_o;
    ((global::com.codename1.charts.compat.Canvas) _r0_o).drawText((global::java.lang.String) _r1_o, (float) _r2.f, (float) _r3.f, (global::com.codename1.charts.compat.Paint) _r4_o);
    label188:;
    _r6.d = _r6.d + _r43.d;
    goto label2;
    label192:;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.views.DialChart: void drawTicks(com.codename1.charts.compat.Canvas, double, double, double, double, int, int, double, double, double, com.codename1.charts.compat.Paint, boolean)]
}

private void drawNeedle(global::com.codename1.charts.compat.Canvas n1, double n2, int n3, int n4, double n5, bool n6, global::com.codename1.charts.compat.Paint n7){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.DialChart: void drawNeedle(com.codename1.charts.compat.Canvas, double, int, int, double, boolean, com.codename1.charts.compat.Paint)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r8;
    global::org.xmlvm._nElement _r9;
    global::System.Object _r10_o = null;
    global::org.xmlvm._nElement _r11;
    global::org.xmlvm._nElement _r12;
    global::org.xmlvm._nElement _r13;
    global::org.xmlvm._nElement _r15;
    global::org.xmlvm._nElement _r16;
    global::org.xmlvm._nElement _r17;
    global::org.xmlvm._nElement _r18;
    global::org.xmlvm._nElement _r19;
    global::org.xmlvm._nElement _r20;
    global::System.Object _r21_o = null;
    global::org.xmlvm._nElement _r22;
    global::System.Object _r23_o = null;
    global::System.Object _r24_o = null;
    global::org.xmlvm._nElement _r25;
    global::org.xmlvm._nElement _r27;
    global::org.xmlvm._nElement _r28;
    global::org.xmlvm._nElement _r29;
    global::org.xmlvm._nElement _r31;
    global::System.Object _r32_o = null;
    _r23_o = this;
    _r24_o = n1;
    _r25.d = n2;
    _r27.i = n3;
    _r28.i = n4;
    _r29.d = n5;
    _r31.i = n6 ? 1 : 0;
    _r32_o = n7;
    _r5.d = 90.0D;
    _r13.d = global::java.lang.Math.toRadians((double) _r5.d);
    _r5.d = 10.0D;
    _r7.d = _r25.d - _r13.d;
    _r7.d = global::java.lang.Math.sin((double) _r7.d);
    _r5.d = _r5.d * _r7.d;
    _r0.d = _r5.d;
    _r0.i = (int) _r0.d;
    _r18.i = _r0.i;
    _r5.d = 10.0D;
    _r7.d = _r25.d - _r13.d;
    _r7.d = global::java.lang.Math.cos((double) _r7.d);
    _r5.d = _r5.d * _r7.d;
    _r0.d = _r5.d;
    _r0.i = (int) _r0.d;
    _r17.i = _r0.i;
    _r5.d = global::java.lang.Math.sin((double) _r25.d);
    _r5.d = _r5.d * _r29.d;
    _r0.d = _r5.d;
    _r0.i = (int) _r0.d;
    _r19.i = _r0.i;
    _r5.d = global::java.lang.Math.cos((double) _r25.d);
    _r5.d = _r5.d * _r29.d;
    _r0.d = _r5.d;
    _r0.i = (int) _r0.d;
    _r20.i = _r0.i;
    _r15.i = _r27.i + _r19.i;
    _r16.i = _r28.i + _r20.i;
    if (_r31.i == 0) goto label185;
    _r5.d = 0.85D;
    _r5.d = _r5.d * _r29.d;
    _r7.d = global::java.lang.Math.sin((double) _r25.d);
    _r5.d = _r5.d * _r7.d;
    _r5.i = (int) _r5.d;
    _r11.i = _r27.i + _r5.i;
    _r5.d = 0.85D;
    _r5.d = _r5.d * _r29.d;
    _r7.d = global::java.lang.Math.cos((double) _r25.d);
    _r5.d = _r5.d * _r7.d;
    _r5.i = (int) _r5.d;
    _r12.i = _r28.i + _r5.i;
    _r5.i = 6;
    _r0.i = _r5.i;
    _r0_o = new global::org.xmlvm._nArrayAdapter<float>(new float[_r0.i]);
    _r21_o = _r0_o;
    _r5.i = 0;
    _r6.i = _r11.i - _r18.i;
    _r6.f = (float) _r6.i;
    ((global::org.xmlvm._nArrayAdapter<float>) _r21_o)[_r5.i] = _r6.f;
    _r5.i = 1;
    _r6.i = _r12.i - _r17.i;
    _r6.f = (float) _r6.i;
    ((global::org.xmlvm._nArrayAdapter<float>) _r21_o)[_r5.i] = _r6.f;
    _r5.i = 2;
    _r6.f = (float) _r15.i;
    ((global::org.xmlvm._nArrayAdapter<float>) _r21_o)[_r5.i] = _r6.f;
    _r5.i = 3;
    _r0.i = _r16.i;
    _r0.f = (float) _r0.i;
    _r6.f = _r0.f;
    ((global::org.xmlvm._nArrayAdapter<float>) _r21_o)[_r5.i] = _r6.f;
    _r5.i = 4;
    _r6.i = _r11.i + _r18.i;
    _r6.f = (float) _r6.i;
    ((global::org.xmlvm._nArrayAdapter<float>) _r21_o)[_r5.i] = _r6.f;
    _r5.i = 5;
    _r6.i = _r12.i + _r17.i;
    _r6.f = (float) _r6.i;
    ((global::org.xmlvm._nArrayAdapter<float>) _r21_o)[_r5.i] = _r6.f;
    _r22.f = ((global::com.codename1.charts.compat.Paint) _r32_o).getStrokeWidth();
    _r5.f = (float)5.0D;
    _r0_o = _r32_o;
    _r1.f = _r5.f;
    ((global::com.codename1.charts.compat.Paint) _r0_o).setStrokeWidth((float) _r1.f);
    _r0.i = _r27.i;
    _r0.f = (float) _r0.i;
    _r6.f = _r0.f;
    _r0.i = _r28.i;
    _r0.f = (float) _r0.i;
    _r7.f = _r0.f;
    _r8.f = (float) _r15.i;
    _r0.i = _r16.i;
    _r0.f = (float) _r0.i;
    _r9.f = _r0.f;
    _r5_o = _r24_o;
    _r10_o = _r32_o;
    ((global::com.codename1.charts.compat.Canvas) _r5_o).drawLine((float) _r6.f, (float) _r7.f, (float) _r8.f, (float) _r9.f, (global::com.codename1.charts.compat.Paint) _r10_o);
    _r0_o = _r32_o;
    _r1.f = _r22.f;
    ((global::com.codename1.charts.compat.Paint) _r0_o).setStrokeWidth((float) _r1.f);
    label171:;
    _r5.i = 1;
    _r0_o = _r23_o;
    _r1_o = _r24_o;
    _r2_o = _r21_o;
    _r3_o = _r32_o;
    _r4.i = _r5.i;
    ((global::com.codename1.charts.views.DialChart) _r0_o).drawPath((global::com.codename1.charts.compat.Canvas) _r1_o, (global::org.xmlvm._nArrayAdapter<float>) _r2_o, (global::com.codename1.charts.compat.Paint) _r3_o, 0!=_r4.i);
    return;
    label185:;
    _r5.i = 6;
    _r0.i = _r5.i;
    _r0_o = new global::org.xmlvm._nArrayAdapter<float>(new float[_r0.i]);
    _r21_o = _r0_o;
    _r5.i = 0;
    _r6.i = _r27.i - _r18.i;
    _r6.f = (float) _r6.i;
    ((global::org.xmlvm._nArrayAdapter<float>) _r21_o)[_r5.i] = _r6.f;
    _r5.i = 1;
    _r6.i = _r28.i - _r17.i;
    _r6.f = (float) _r6.i;
    ((global::org.xmlvm._nArrayAdapter<float>) _r21_o)[_r5.i] = _r6.f;
    _r5.i = 2;
    _r6.f = (float) _r15.i;
    ((global::org.xmlvm._nArrayAdapter<float>) _r21_o)[_r5.i] = _r6.f;
    _r5.i = 3;
    _r0.i = _r16.i;
    _r0.f = (float) _r0.i;
    _r6.f = _r0.f;
    ((global::org.xmlvm._nArrayAdapter<float>) _r21_o)[_r5.i] = _r6.f;
    _r5.i = 4;
    _r6.i = _r27.i + _r18.i;
    _r6.f = (float) _r6.i;
    ((global::org.xmlvm._nArrayAdapter<float>) _r21_o)[_r5.i] = _r6.f;
    _r5.i = 5;
    _r6.i = _r28.i + _r17.i;
    _r6.f = (float) _r6.i;
    ((global::org.xmlvm._nArrayAdapter<float>) _r21_o)[_r5.i] = _r6.f;
    goto label171;
//XMLVM_END_WRAPPER[com.codename1.charts.views.DialChart: void drawNeedle(com.codename1.charts.compat.Canvas, double, int, int, double, boolean, com.codename1.charts.compat.Paint)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.DialChart]
//XMLVM_END_WRAPPER[com.codename1.charts.views.DialChart]

} // end of class: DialChart

} // end of namespace: com.codename1.charts.views
