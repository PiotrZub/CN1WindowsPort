// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.maps.layers {
public class LinesLayer: global::com.codename1.maps.layers.AbstractLayer {
private global::java.util.Vector _f_1lineSegments;

public int _f_1lineColor;

new public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.maps.layers.LinesLayer: void <init>()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = new global::com.codename1.maps.Mercator();
    ((global::com.codename1.maps.Mercator) _r0_o).@this();
    // Value=
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    ((global::com.codename1.maps.layers.LinesLayer) _r2_o).@this((global::com.codename1.maps.Projection) _r0_o, (global::java.lang.String) _r1_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.maps.layers.LinesLayer: void <init>()]
}

public void @this(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.maps.layers.LinesLayer: void <init>(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = new global::com.codename1.maps.Mercator();
    ((global::com.codename1.maps.Mercator) _r0_o).@this();
    ((global::com.codename1.maps.layers.LinesLayer) _r1_o).@this((global::com.codename1.maps.Projection) _r0_o, (global::java.lang.String) _r2_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.maps.layers.LinesLayer: void <init>(java.lang.String)]
}

new public void @this(global::com.codename1.maps.Projection n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.maps.layers.LinesLayer: void <init>(com.codename1.maps.Projection, java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    ((global::com.codename1.maps.layers.AbstractLayer) _r1_o).@this((global::com.codename1.maps.Projection) _r2_o, (global::java.lang.String) _r3_o);
    _r0_o = new global::java.util.Vector();
    ((global::java.util.Vector) _r0_o).@this();
    ((global::com.codename1.maps.layers.LinesLayer) _r1_o)._f_1lineSegments = (global::java.util.Vector) _r0_o;
    _r0.i = 0;
    ((global::com.codename1.maps.layers.LinesLayer) _r1_o)._f_1lineColor = _r0.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.maps.layers.LinesLayer: void <init>(com.codename1.maps.Projection, java.lang.String)]
}

public override void paint(global::com.codename1.ui.Graphics n1, global::com.codename1.maps.Tile n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.maps.layers.LinesLayer: void paint(com.codename1.ui.Graphics, com.codename1.maps.Tile)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    _r3_o = this;
    _r4_o = n1;
    _r5_o = n2;
    _r2.i = ((global::com.codename1.maps.layers.LinesLayer) _r3_o)._f_1lineColor;
    ((global::com.codename1.ui.Graphics) _r4_o).setColor((int) _r2.i);
    _r2.i = 1;
    ((global::com.codename1.ui.Graphics) _r4_o).setAntiAliased(0!=_r2.i);
    _r2_o = ((global::com.codename1.maps.layers.LinesLayer) _r3_o)._f_1lineSegments;
    _r1.i = ((global::java.util.Vector) _r2_o).size();
    _r0.i = 0;
    label16:;
    if (_r0.i >= _r1.i) goto label34;
    _r2_o = ((global::com.codename1.maps.layers.LinesLayer) _r3_o)._f_1lineSegments;
    _r2_o = ((global::java.util.Vector) _r2_o).elementAt((int) _r0.i);
    ((global::com.codename1.maps.layers.LinesLayer) _r3_o).paintSegment((global::com.codename1.ui.Graphics) _r4_o, (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o, (global::com.codename1.maps.Tile) _r5_o);
    _r0.i = _r0.i + 1;
    goto label16;
    label34:;
    return;
//XMLVM_END_WRAPPER[com.codename1.maps.layers.LinesLayer: void paint(com.codename1.ui.Graphics, com.codename1.maps.Tile)]
}

public virtual void paintSegment(global::com.codename1.ui.Graphics n1, global::org.xmlvm._nArrayAdapter<global::System.Object> n2, global::com.codename1.maps.Tile n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.maps.layers.LinesLayer: void paintSegment(com.codename1.ui.Graphics, com.codename1.maps.Coord[], com.codename1.maps.Tile)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r8;
    global::org.xmlvm._nElement _r9;
    global::org.xmlvm._nElement _r10;
    global::System.Object _r11_o = null;
    global::System.Object _r12_o = null;
    global::System.Object _r13_o = null;
    global::System.Object _r14_o = null;
    _r11_o = this;
    _r12_o = n1;
    _r13_o = n2;
    _r14_o = n3;
    _r10.i = 1;
    _r3.i = ((global::org.xmlvm._nIArray) _r13_o).Length;
    _r2.i = 1;
    label3:;
    if (_r2.i >= _r3.i) goto label129;
    _r6.i = _r2.i - _r10.i;
    _r5_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r13_o)[_r6.i];
    _r1_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r13_o)[_r2.i];
    _r4_o = ((global::com.codename1.maps.Tile) _r14_o).pointPosition((global::com.codename1.maps.Coord) _r5_o);
    _r0_o = ((global::com.codename1.maps.Tile) _r14_o).pointPosition((global::com.codename1.maps.Coord) _r1_o);
    _r6.i = ((global::com.codename1.ui.geom.Point) _r4_o).getX();
    _r7.i = ((global::com.codename1.ui.geom.Point) _r4_o).getY();
    _r8.i = ((global::com.codename1.ui.geom.Point) _r0_o).getX();
    _r9.i = ((global::com.codename1.ui.geom.Point) _r0_o).getY();
    ((global::com.codename1.ui.Graphics) _r12_o).drawLine((int) _r6.i, (int) _r7.i, (int) _r8.i, (int) _r9.i);
    _r6.i = ((global::com.codename1.ui.geom.Point) _r4_o).getX();
    _r6.i = _r6.i - _r10.i;
    _r7.i = ((global::com.codename1.ui.geom.Point) _r4_o).getY();
    _r8.i = ((global::com.codename1.ui.geom.Point) _r0_o).getX();
    _r8.i = _r8.i - _r10.i;
    _r9.i = ((global::com.codename1.ui.geom.Point) _r0_o).getY();
    ((global::com.codename1.ui.Graphics) _r12_o).drawLine((int) _r6.i, (int) _r7.i, (int) _r8.i, (int) _r9.i);
    _r6.i = ((global::com.codename1.ui.geom.Point) _r4_o).getX();
    _r6.i = _r6.i + 1;
    _r7.i = ((global::com.codename1.ui.geom.Point) _r4_o).getY();
    _r8.i = ((global::com.codename1.ui.geom.Point) _r0_o).getX();
    _r8.i = _r8.i + 1;
    _r9.i = ((global::com.codename1.ui.geom.Point) _r0_o).getY();
    ((global::com.codename1.ui.Graphics) _r12_o).drawLine((int) _r6.i, (int) _r7.i, (int) _r8.i, (int) _r9.i);
    _r6.i = ((global::com.codename1.ui.geom.Point) _r4_o).getX();
    _r7.i = ((global::com.codename1.ui.geom.Point) _r4_o).getY();
    _r7.i = _r7.i - _r10.i;
    _r8.i = ((global::com.codename1.ui.geom.Point) _r0_o).getX();
    _r9.i = ((global::com.codename1.ui.geom.Point) _r0_o).getY();
    _r9.i = _r9.i - _r10.i;
    ((global::com.codename1.ui.Graphics) _r12_o).drawLine((int) _r6.i, (int) _r7.i, (int) _r8.i, (int) _r9.i);
    _r6.i = ((global::com.codename1.ui.geom.Point) _r4_o).getX();
    _r7.i = ((global::com.codename1.ui.geom.Point) _r4_o).getY();
    _r7.i = _r7.i + 1;
    _r8.i = ((global::com.codename1.ui.geom.Point) _r0_o).getX();
    _r9.i = ((global::com.codename1.ui.geom.Point) _r0_o).getY();
    _r9.i = _r9.i + 1;
    ((global::com.codename1.ui.Graphics) _r12_o).drawLine((int) _r6.i, (int) _r7.i, (int) _r8.i, (int) _r9.i);
    _r2.i = _r2.i + 1;
    goto label3;
    label129:;
    return;
//XMLVM_END_WRAPPER[com.codename1.maps.layers.LinesLayer: void paintSegment(com.codename1.ui.Graphics, com.codename1.maps.Coord[], com.codename1.maps.Tile)]
}

public virtual void addLineSegment(global::org.xmlvm._nArrayAdapter<global::System.Object> n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.maps.layers.LinesLayer: void addLineSegment(com.codename1.maps.Coord[])]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    if (_r3_o == null) goto label6;
    _r0.i = ((global::org.xmlvm._nIArray) _r3_o).Length;
    _r1.i = 1;
    if (_r0.i > _r1.i) goto label7;
    label6:;
    return;
    label7:;
    _r0.i = 0;
    _r0_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r3_o)[_r0.i];
    _r0.i = ((global::com.codename1.maps.Coord) _r0_o).isProjected() ? 1 : 0;
    if (_r0.i != 0) goto label24;
    _r0_o = ((global::com.codename1.maps.layers.LinesLayer) _r2_o).getProjection();
    _r3_o = ((global::com.codename1.maps.Projection) _r0_o).fromWGS84((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r3_o);
    label24:;
    _r0_o = ((global::com.codename1.maps.layers.LinesLayer) _r2_o)._f_1lineSegments;
    ((global::java.util.Vector) _r0_o).addElement((global::java.lang.Object) _r3_o);
    goto label6;
//XMLVM_END_WRAPPER[com.codename1.maps.layers.LinesLayer: void addLineSegment(com.codename1.maps.Coord[])]
}

public virtual void lineColor(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.maps.layers.LinesLayer: void lineColor(int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.i = n1;
    ((global::com.codename1.maps.layers.LinesLayer) _r0_o)._f_1lineColor = _r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.maps.layers.LinesLayer: void lineColor(int)]
}

public override global::System.Object boundingBox(){
//XMLVM_BEGIN_WRAPPER[com.codename1.maps.layers.LinesLayer: com.codename1.maps.BoundingBox boundingBox()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    _r6_o = this;
    _r1_o = null;
    _r4.i = 0;
    label2:;
    _r5_o = ((global::com.codename1.maps.layers.LinesLayer) _r6_o)._f_1lineSegments;
    _r5.i = ((global::java.util.Vector) _r5_o).size();
    if (_r4.i >= _r5.i) goto label37;
    _r5_o = ((global::com.codename1.maps.layers.LinesLayer) _r6_o)._f_1lineSegments;
    _r5_o = ((global::java.util.Vector) _r5_o).elementAt((int) _r4.i);
    _r0_o = _r5_o;
    _r3_o = _r0_o;
    _r2_o = global::com.codename1.maps.BoundingBox.create((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r3_o);
    if (_r1_o != null) goto label32;
    _r1_o = _r2_o;
    label29:;
    _r4.i = _r4.i + 1;
    goto label2;
    label32:;
    _r1_o = ((global::com.codename1.maps.BoundingBox) _r1_o).extend((global::com.codename1.maps.BoundingBox) _r2_o);
    goto label29;
    label37:;
    return (global::com.codename1.maps.BoundingBox) _r1_o;
//XMLVM_END_WRAPPER[com.codename1.maps.layers.LinesLayer: com.codename1.maps.BoundingBox boundingBox()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.maps.layers.LinesLayer]
//XMLVM_END_WRAPPER[com.codename1.maps.layers.LinesLayer]

} // end of class: LinesLayer

} // end of namespace: com.codename1.maps.layers
