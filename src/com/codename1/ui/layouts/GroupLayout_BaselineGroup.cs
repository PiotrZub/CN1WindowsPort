// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.layouts {
public class GroupLayout_2BaselineGroup: global::com.codename1.ui.layouts.GroupLayout_2ParallelGroup {
private bool _fallSpringsHaveBaseline;

private int _fprefAscent;

private int _fprefDescent;

private bool _fbaselineAnchorSet;

private bool _fbaselineAnchoredToTop;

private bool _fcalcedBaseline;

public global::com.codename1.ui.layouts.GroupLayout _fthis_20;

public void @this(global::com.codename1.ui.layouts.GroupLayout n1, bool n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$BaselineGroup: void <init>(com.codename1.ui.layouts.GroupLayout, boolean)]
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
    _r2_o = n1;
    _r3.i = n2 ? 1 : 0;
    ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r1_o)._fthis_20 = (global::com.codename1.ui.layouts.GroupLayout) _r2_o;
    _r0.i = 1;
    ((global::com.codename1.ui.layouts.GroupLayout_2ParallelGroup) _r1_o).@this((global::com.codename1.ui.layouts.GroupLayout) _r2_o, (int) _r0.i, 0!=_r3.i);
    _r0.i = -1;
    ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r1_o)._fprefDescent = _r0.i;
    ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r1_o)._fprefAscent = _r0.i;
    _r0.i = 0;
    ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r1_o)._fcalcedBaseline = 0!=_r0.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$BaselineGroup: void <init>(com.codename1.ui.layouts.GroupLayout, boolean)]
}

public void @this(global::com.codename1.ui.layouts.GroupLayout n1, bool n2, bool n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$BaselineGroup: void <init>(com.codename1.ui.layouts.GroupLayout, boolean, boolean)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r3.i = n2 ? 1 : 0;
    _r4.i = n3 ? 1 : 0;
    ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r1_o).@this((global::com.codename1.ui.layouts.GroupLayout) _r2_o, 0!=_r3.i);
    ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r1_o)._fbaselineAnchoredToTop = 0!=_r4.i;
    _r0.i = 1;
    ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r1_o)._fbaselineAnchorSet = 0!=_r0.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$BaselineGroup: void <init>(com.codename1.ui.layouts.GroupLayout, boolean, boolean)]
}

public override void unset(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$BaselineGroup: void unset()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    base.unset();
    _r0.i = -1;
    ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r1_o)._fprefDescent = _r0.i;
    ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r1_o)._fprefAscent = _r0.i;
    _r0.i = 0;
    ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r1_o)._fcalcedBaseline = 0!=_r0.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$BaselineGroup: void unset()]
}

public override void setValidSize(int n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$BaselineGroup: void setValidSize(int, int, int)]
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
    global::System.Object _r5_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r3.i = n1;
    _r4.i = n2;
    _r5.i = n3;
    ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r2_o).checkAxis((int) _r3.i);
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r2_o)._fprefAscent;
    _r1.i = -1;
    if (_r0.i != _r1.i) goto label12;
    base.setValidSize((int) _r3.i, (int) _r4.i, (int) _r5.i);
    label11:;
    return;
    label12:;
    ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r2_o).baselineLayout((int) _r4.i, (int) _r5.i);
    goto label11;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$BaselineGroup: void setValidSize(int, int, int)]
}

public override int calculateSize(int n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$BaselineGroup: int calculateSize(int, int)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r3.i = n1;
    _r4.i = n2;
    ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r2_o).checkAxis((int) _r3.i);
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r2_o)._fcalcedBaseline ? 1 : 0;
    if (_r0.i != 0) goto label10;
    ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r2_o).calculateBaselineAndResizeBehavior();
    label10:;
    if (_r4.i != 0) goto label17;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r2_o).calculateMinSize();
    label16:;
    return _r0.i;
    label17:;
    _r0.i = 2;
    if (_r4.i != _r0.i) goto label25;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r2_o).calculateMaxSize();
    goto label16;
    label25:;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r2_o)._fallSpringsHaveBaseline ? 1 : 0;
    if (_r0.i == 0) goto label35;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r2_o)._fprefAscent;
    _r1.i = ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r2_o)._fprefDescent;
    _r0.i = _r0.i + _r1.i;
    goto label16;
    label35:;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r2_o)._fprefAscent;
    _r1.i = ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r2_o)._fprefDescent;
    _r0.i = _r0.i + _r1.i;
    _r1.i = base.calculateSize((int) _r3.i, (int) _r4.i);
    _r0.i = global::java.lang.Math.max((int) _r0.i, (int) _r1.i);
    goto label16;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$BaselineGroup: int calculateSize(int, int)]
}

private void calculateBaselineAndResizeBehavior(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$BaselineGroup: void calculateBaselineAndResizeBehavior()]
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
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nElement _r8;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nElement _r9;
    global::System.Object _r9_o = null;
    global::org.xmlvm._nElement _r10;
    global::System.Object _r10_o = null;
    global::org.xmlvm._nElement _r11;
    global::System.Object _r11_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r11_o = this;
    _r10.i = 2;
    _r9.i = 1;
    _r8.i = 0;
    ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r11_o)._fprefAscent = _r8.i;
    ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r11_o)._fprefDescent = _r8.i;
    _r1.i = 0;
    _r4.i = 0;
    _r6_o = ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r11_o)._fsprings;
    _r6.i = ((global::java.util.ArrayList) _r6_o).size();
    _r3.i = _r6.i - _r9.i;
    label17:;
    if (_r3.i < 0) goto label85;
    _r5_o = ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r11_o).getSpring((int) _r3.i);
    _r6.i = ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r5_o).getAlignment();
    if (_r6.i == 0) goto label36;
    _r6.i = ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r5_o).getAlignment();
    _r7.i = 3;
    if (_r6.i != _r7.i) goto label78;
    label36:;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r5_o).getBaseline();
    if (_r0.i < 0) goto label78;
    _r6.i = ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r5_o).isResizable((int) _r10.i) ? 1 : 0;
    if (_r6.i == 0) goto label55;
    _r2.i = ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r5_o).getBaselineResizeBehavior();
    if (_r4.i != 0) goto label81;
    _r4.i = _r2.i;
    label55:;
    _r6.i = ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r11_o)._fprefAscent;
    _r6.i = global::java.lang.Math.max((int) _r6.i, (int) _r0.i);
    ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r11_o)._fprefAscent = _r6.i;
    _r6.i = ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r11_o)._fprefDescent;
    _r7.i = ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r5_o).getPreferredSize((int) _r10.i);
    _r7.i = _r7.i - _r0.i;
    _r6.i = global::java.lang.Math.max((int) _r6.i, (int) _r7.i);
    ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r11_o)._fprefDescent = _r6.i;
    _r1.i = _r1.i + 1;
    label78:;
    _r3.i = _r3.i + -1;
    goto label17;
    label81:;
    if (_r2.i == _r4.i) goto label55;
    _r4.i = 1;
    goto label55;
    label85:;
    _r6.i = ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r11_o)._fbaselineAnchorSet ? 1 : 0;
    if (_r6.i != 0) goto label93;
    if (_r4.i != _r10.i) goto label107;
    ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r11_o)._fbaselineAnchoredToTop = 0!=_r8.i;
    label93:;
    _r6_o = ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r11_o)._fsprings;
    _r6.i = ((global::java.util.ArrayList) _r6_o).size();
    if (_r1.i != _r6.i) goto label110;
    _r6.i = _r9.i;
    label102:;
    ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r11_o)._fallSpringsHaveBaseline = 0!=_r6.i;
    ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r11_o)._fcalcedBaseline = 0!=_r9.i;
    return;
    label107:;
    ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r11_o)._fbaselineAnchoredToTop = 0!=_r9.i;
    goto label93;
    label110:;
    _r6.i = _r8.i;
    goto label102;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$BaselineGroup: void calculateBaselineAndResizeBehavior()]
}

private int calculateMaxSize(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$BaselineGroup: int calculateMaxSize()]
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
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nElement _r8;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nElement _r9;
    global::System.Object _r9_o = null;
    global::org.xmlvm._nElement _r10;
    global::System.Object _r10_o = null;
    global::org.xmlvm._nElement _r11;
    global::System.Object _r11_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r11_o = this;
    _r10.i = 2;
    _r2.i = ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r11_o)._fprefAscent;
    _r3.i = ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r11_o)._fprefDescent;
    _r4.i = 0;
    _r8_o = ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r11_o)._fsprings;
    _r8.i = ((global::java.util.ArrayList) _r8_o).size();
    _r9.i = 1;
    _r1.i = _r8.i - _r9.i;
    label15:;
    if (_r1.i < 0) goto label88;
    _r5_o = ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r11_o).getSpring((int) _r1.i);
    _r6.i = ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r5_o).getMaximumSize((int) _r10.i);
    _r8.i = ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r5_o).getAlignment();
    if (_r8.i == 0) goto label38;
    _r8.i = ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r5_o).getAlignment();
    _r9.i = 3;
    if (_r8.i != _r9.i) goto label83;
    label38:;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r5_o).getBaseline();
    if (_r0.i < 0) goto label83;
    _r7.i = ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r5_o).getPreferredSize((int) _r10.i);
    if (_r7.i == _r6.i) goto label57;
    _r8.i = ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r5_o).getBaselineResizeBehavior();
    switch (_r8.i) {
    case 1: goto label60;
    case 2: goto label71;
    }
    label57:;
    _r1.i = _r1.i + -1;
    goto label15;
    label60:;
    _r8.i = ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r11_o)._fbaselineAnchoredToTop ? 1 : 0;
    if (_r8.i == 0) goto label57;
    _r8.i = _r6.i - _r0.i;
    _r3.i = global::java.lang.Math.max((int) _r3.i, (int) _r8.i);
    goto label57;
    label71:;
    _r8.i = ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r11_o)._fbaselineAnchoredToTop ? 1 : 0;
    if (_r8.i != 0) goto label57;
    _r8.i = _r6.i - _r7.i;
    _r8.i = _r8.i + _r0.i;
    _r2.i = global::java.lang.Math.max((int) _r2.i, (int) _r8.i);
    goto label57;
    label83:;
    _r4.i = global::java.lang.Math.max((int) _r4.i, (int) _r6.i);
    goto label57;
    label88:;
    _r8.i = _r2.i + _r3.i;
    _r8.i = global::java.lang.Math.max((int) _r4.i, (int) _r8.i);
    return _r8.i;
    label96:;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$BaselineGroup: int calculateMaxSize()]
}

private int calculateMinSize(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$BaselineGroup: int calculateMinSize()]
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
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nElement _r8;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nElement _r9;
    global::System.Object _r9_o = null;
    global::org.xmlvm._nElement _r10;
    global::System.Object _r10_o = null;
    global::org.xmlvm._nElement _r11;
    global::System.Object _r11_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r11_o = this;
    _r10.i = 2;
    _r2.i = 0;
    _r3.i = 0;
    _r4.i = 0;
    _r8.i = ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r11_o)._fbaselineAnchoredToTop ? 1 : 0;
    if (_r8.i == 0) goto label72;
    _r2.i = ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r11_o)._fprefAscent;
    label10:;
    _r8_o = ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r11_o)._fsprings;
    _r8.i = ((global::java.util.ArrayList) _r8_o).size();
    _r9.i = 1;
    _r1.i = _r8.i - _r9.i;
    label19:;
    if (_r1.i < 0) goto label116;
    _r5_o = ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r11_o).getSpring((int) _r1.i);
    _r6.i = ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r5_o).getMinimumSize((int) _r10.i);
    _r8.i = ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r5_o).getAlignment();
    if (_r8.i == 0) goto label42;
    _r8.i = ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r5_o).getAlignment();
    _r9.i = 3;
    if (_r8.i != _r9.i) goto label111;
    label42:;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r5_o).getBaseline();
    if (_r0.i < 0) goto label111;
    _r7.i = ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r5_o).getPreferredSize((int) _r10.i);
    _r8.i = ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r5_o).getBaselineResizeBehavior();
    switch (_r8.i) {
    case 1: goto label75;
    case 2: goto label91;
    }
    _r2.i = global::java.lang.Math.max((int) _r0.i, (int) _r2.i);
    _r8.i = _r7.i - _r0.i;
    _r3.i = global::java.lang.Math.max((int) _r8.i, (int) _r3.i);
    label69:;
    _r1.i = _r1.i + -1;
    goto label19;
    label72:;
    _r3.i = ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r11_o)._fprefDescent;
    goto label10;
    label75:;
    _r8.i = ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r11_o)._fbaselineAnchoredToTop ? 1 : 0;
    if (_r8.i == 0) goto label86;
    _r8.i = _r6.i - _r0.i;
    _r3.i = global::java.lang.Math.max((int) _r8.i, (int) _r3.i);
    goto label69;
    label86:;
    _r2.i = global::java.lang.Math.max((int) _r0.i, (int) _r2.i);
    goto label69;
    label91:;
    _r8.i = ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r11_o)._fbaselineAnchoredToTop ? 1 : 0;
    if (_r8.i != 0) goto label104;
    _r8.i = _r7.i - _r6.i;
    _r8.i = _r0.i - _r8.i;
    _r2.i = global::java.lang.Math.max((int) _r8.i, (int) _r2.i);
    goto label69;
    label104:;
    _r8.i = _r7.i - _r0.i;
    _r3.i = global::java.lang.Math.max((int) _r8.i, (int) _r3.i);
    goto label69;
    label111:;
    _r4.i = global::java.lang.Math.max((int) _r4.i, (int) _r6.i);
    goto label69;
    label116:;
    _r8.i = _r2.i + _r3.i;
    _r8.i = global::java.lang.Math.max((int) _r4.i, (int) _r8.i);
    return _r8.i;
    label124:;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$BaselineGroup: int calculateMinSize()]
}

private void baselineLayout(int n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$BaselineGroup: void baselineLayout(int, int)]
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
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nElement _r8;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nElement _r9;
    global::System.Object _r9_o = null;
    global::org.xmlvm._nElement _r10;
    global::System.Object _r10_o = null;
    global::org.xmlvm._nElement _r11;
    global::System.Object _r11_o = null;
    global::org.xmlvm._nElement _r12;
    global::System.Object _r12_o = null;
    global::org.xmlvm._nElement _r13;
    global::System.Object _r13_o = null;
    global::org.xmlvm._nElement _r14;
    global::System.Object _r14_o = null;
    global::org.xmlvm._nElement _r15;
    global::System.Object _r15_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r13_o = this;
    _r14.i = n1;
    _r15.i = n2;
    _r12.i = 2;
    _r10.i = ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r13_o)._fbaselineAnchoredToTop ? 1 : 0;
    if (_r10.i == 0) goto label65;
    _r1.i = ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r13_o)._fprefAscent;
    _r4.i = _r15.i - _r1.i;
    label9:;
    _r10_o = ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r13_o)._fsprings;
    _r10.i = ((global::java.util.ArrayList) _r10_o).size();
    _r11.i = 1;
    _r3.i = _r10.i - _r11.i;
    label18:;
    if (_r3.i < 0) goto label112;
    _r6_o = ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r13_o).getSpring((int) _r3.i);
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r6_o).getAlignment();
    if (_r0.i == 0) goto label33;
    _r10.i = 3;
    if (_r0.i != _r10.i) goto label108;
    label33:;
    _r2.i = ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r6_o).getBaseline();
    if (_r2.i < 0) goto label104;
    _r7.i = ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r6_o).getMaximumSize((int) _r12.i);
    _r8.i = ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r6_o).getPreferredSize((int) _r12.i);
    _r5.i = _r8.i;
    _r10.i = ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r6_o).getBaselineResizeBehavior();
    switch (_r10.i) {
    case 1: goto label72;
    case 2: goto label85;
    }
    _r10.i = _r14.i + _r1.i;
    _r9.i = _r10.i - _r2.i;
    label59:;
    ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r6_o).setSize((int) _r12.i, (int) _r9.i, (int) _r5.i);
    label62:;
    _r3.i = _r3.i + -1;
    goto label18;
    label65:;
    _r10.i = ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r13_o)._fprefDescent;
    _r1.i = _r15.i - _r10.i;
    _r4.i = ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r13_o)._fprefDescent;
    goto label9;
    label72:;
    _r10.i = _r14.i + _r1.i;
    _r9.i = _r10.i - _r2.i;
    _r10.i = _r7.i - _r2.i;
    _r10.i = global::java.lang.Math.min((int) _r4.i, (int) _r10.i);
    _r5.i = _r10.i + _r2.i;
    goto label59;
    label85:;
    _r10.i = _r7.i - _r8.i;
    _r10.i = _r10.i + _r2.i;
    _r10.i = global::java.lang.Math.min((int) _r1.i, (int) _r10.i);
    _r11.i = _r8.i - _r2.i;
    _r5.i = _r10.i + _r11.i;
    _r10.i = _r14.i + _r1.i;
    _r11.i = _r8.i - _r2.i;
    _r10.i = _r10.i + _r11.i;
    _r9.i = _r10.i - _r5.i;
    goto label59;
    label104:;
    ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r13_o).setChildSize((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r6_o, (int) _r12.i, (int) _r14.i, (int) _r15.i);
    goto label62;
    label108:;
    ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r13_o).setChildSize((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r6_o, (int) _r12.i, (int) _r14.i, (int) _r15.i);
    goto label62;
    label112:;
    return;
    label114:;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$BaselineGroup: void baselineLayout(int, int)]
}

public override int getBaseline(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$BaselineGroup: int getBaseline()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r1.i = 1;
    _r0_o = ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r2_o)._fsprings;
    _r0.i = ((global::java.util.ArrayList) _r0_o).size();
    if (_r0.i <= _r1.i) goto label16;
    _r0.i = 2;
    ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r2_o).getPreferredSize((int) _r0.i);
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r2_o)._fprefAscent;
    label15:;
    return _r0.i;
    label16:;
    _r0_o = ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r2_o)._fsprings;
    _r0.i = ((global::java.util.ArrayList) _r0_o).size();
    if (_r0.i != _r1.i) goto label34;
    _r0.i = 0;
    _r0_o = ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r2_o).getSpring((int) _r0.i);
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r0_o).getBaseline();
    goto label15;
    label34:;
    _r0.i = -1;
    goto label15;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$BaselineGroup: int getBaseline()]
}

public override int getBaselineResizeBehavior(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$BaselineGroup: int getBaselineResizeBehavior()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r1.i = 1;
    _r0_o = ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r2_o)._fsprings;
    _r0.i = ((global::java.util.ArrayList) _r0_o).size();
    if (_r0.i != _r1.i) goto label19;
    _r0.i = 0;
    _r0_o = ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r2_o).getSpring((int) _r0.i);
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r0_o).getBaselineResizeBehavior();
    label18:;
    return _r0.i;
    label19:;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2BaselineGroup) _r2_o)._fbaselineAnchoredToTop ? 1 : 0;
    if (_r0.i == 0) goto label25;
    _r0.i = _r1.i;
    goto label18;
    label25:;
    _r0.i = 2;
    goto label18;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$BaselineGroup: int getBaselineResizeBehavior()]
}

private void checkAxis(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$BaselineGroup: void checkAxis(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r3.i = n1;
    _r0.i = 1;
    if (_r3.i != _r0.i) goto label11;
    _r0_o = new global::java.lang.IllegalStateException();
    // Value=Baseline must be used along vertical axis
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)66)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 115))}));
    ((global::java.lang.IllegalStateException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalStateException) _r0_o);
    label11:;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$BaselineGroup: void checkAxis(int)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$BaselineGroup]
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$BaselineGroup]

} // end of class: GroupLayout_2BaselineGroup

} // end of namespace: com.codename1.ui.layouts
