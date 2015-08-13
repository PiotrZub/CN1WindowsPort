// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public class WeakHashMap: global::java.util.AbstractMap,global::java.util.Map {

private global::java.lang.@ref.ReferenceQueue _freferenceQueue;

public int _felementCount;

public global::org.xmlvm._nArrayAdapter<global::System.Object> _felementData;

private int _floadFactor;

private int _fthreshold;

public int _fmodCount;

private static global::System.Object newEntryArray(int n1){
//XMLVM_BEGIN_WRAPPER[java.util.WeakHashMap: java.util.WeakHashMap$Entry[] newEntryArray(int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r1.i = n1;
    _r0_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r1.i]);
    return (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o;
//XMLVM_END_WRAPPER[java.util.WeakHashMap: java.util.WeakHashMap$Entry[] newEntryArray(int)]
}

new public void @this(){
//XMLVM_BEGIN_WRAPPER[java.util.WeakHashMap: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = 16;
    ((global::java.util.WeakHashMap) _r1_o).@this((int) _r0.i);
    return;
//XMLVM_END_WRAPPER[java.util.WeakHashMap: void <init>()]
}

public void @this(int n1){
//XMLVM_BEGIN_WRAPPER[java.util.WeakHashMap: void <init>(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r1_o = this;
    _r2.i = n1;
    ((global::java.util.AbstractMap) _r1_o).@this();
    if (_r2.i < 0) goto label34;
    _r0.i = 0;
    ((global::java.util.WeakHashMap) _r1_o)._felementCount = _r0.i;
    if (_r2.i != 0) goto label32;
    _r0.i = 1;
    label11:;
    _r0_o = global::java.util.WeakHashMap.newEntryArray((int) _r0.i);
    ((global::java.util.WeakHashMap) _r1_o)._felementData = (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o;
    _r0.i = 7500;
    ((global::java.util.WeakHashMap) _r1_o)._floadFactor = _r0.i;
    ((global::java.util.WeakHashMap) _r1_o).computeMaxSize();
    _r0_o = new global::java.lang.@ref.ReferenceQueue();
    ((global::java.lang.@ref.ReferenceQueue) _r0_o).@this();
    ((global::java.util.WeakHashMap) _r1_o)._freferenceQueue = (global::java.lang.@ref.ReferenceQueue) _r0_o;
    return;
    label32:;
    _r0.i = _r2.i;
    goto label11;
    label34:;
    _r0_o = new global::java.lang.IllegalArgumentException();
    ((global::java.lang.IllegalArgumentException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r0_o);
//XMLVM_END_WRAPPER[java.util.WeakHashMap: void <init>(int)]
}

public void @this(int n1, float n2){
//XMLVM_BEGIN_WRAPPER[java.util.WeakHashMap: void <init>(int, float)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    _r1_o = this;
    _r2.i = n1;
    _r3.f = n2;
    ((global::java.util.AbstractMap) _r1_o).@this();
    if (_r2.i < 0) goto label42;
    _r0.f = (float)0.0D;
    _r0.i = _r3.f > _r0.f ? 1 : (_r3.f == _r0.f ? 0 : -1);
    if (_r0.i <= 0) goto label42;
    _r0.i = 0;
    ((global::java.util.WeakHashMap) _r1_o)._felementCount = _r0.i;
    if (_r2.i != 0) goto label40;
    _r0.i = 1;
    label16:;
    _r0_o = global::java.util.WeakHashMap.newEntryArray((int) _r0.i);
    ((global::java.util.WeakHashMap) _r1_o)._felementData = (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o;
    _r0.f = (float)10000.0D;
    _r0.f = _r0.f * _r3.f;
    _r0.i = (int) _r0.f;
    ((global::java.util.WeakHashMap) _r1_o)._floadFactor = _r0.i;
    ((global::java.util.WeakHashMap) _r1_o).computeMaxSize();
    _r0_o = new global::java.lang.@ref.ReferenceQueue();
    ((global::java.lang.@ref.ReferenceQueue) _r0_o).@this();
    ((global::java.util.WeakHashMap) _r1_o)._freferenceQueue = (global::java.lang.@ref.ReferenceQueue) _r0_o;
    return;
    label40:;
    _r0.i = _r2.i;
    goto label16;
    label42:;
    _r0_o = new global::java.lang.IllegalArgumentException();
    ((global::java.lang.IllegalArgumentException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r0_o);
//XMLVM_END_WRAPPER[java.util.WeakHashMap: void <init>(int, float)]
}

public void @this(global::java.util.Map n1){
//XMLVM_BEGIN_WRAPPER[java.util.WeakHashMap: void <init>(java.util.Map)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r0.i = ((global::java.util.Map) _r3_o).size();
    _r1.i = 6;
    if (_r0.i >= _r1.i) goto label16;
    _r0.i = 11;
    label9:;
    ((global::java.util.WeakHashMap) _r2_o).@this((int) _r0.i);
    ((global::java.util.WeakHashMap) _r2_o).putAllImpl((global::java.util.Map) _r3_o);
    return;
    label16:;
    _r0.i = ((global::java.util.Map) _r3_o).size();
    _r0.i = _r0.i * 2;
    goto label9;
//XMLVM_END_WRAPPER[java.util.WeakHashMap: void <init>(java.util.Map)]
}

public override void clear(){
//XMLVM_BEGIN_WRAPPER[java.util.WeakHashMap: void clear()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0.i = ((global::java.util.WeakHashMap) _r2_o)._felementCount;
    if (_r0.i <= 0) goto label27;
    _r0.i = 0;
    ((global::java.util.WeakHashMap) _r2_o)._felementCount = _r0.i;
    _r0_o = ((global::java.util.WeakHashMap) _r2_o)._felementData;
    _r1_o = null;
    global::java.util.Arrays.fill((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o, (global::java.lang.Object) _r1_o);
    _r0.i = ((global::java.util.WeakHashMap) _r2_o)._fmodCount;
    _r0.i = _r0.i + 1;
    ((global::java.util.WeakHashMap) _r2_o)._fmodCount = _r0.i;
    label19:;
    _r0_o = ((global::java.util.WeakHashMap) _r2_o)._freferenceQueue;
    _r0_o = ((global::java.lang.@ref.ReferenceQueue) _r0_o).poll();
    if (_r0_o != null) goto label19;
    label27:;
    return;
//XMLVM_END_WRAPPER[java.util.WeakHashMap: void clear()]
}

private void computeMaxSize(){
//XMLVM_BEGIN_WRAPPER[java.util.WeakHashMap: void computeMaxSize()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r4_o = null;
    _r4_o = this;
    _r0_o = ((global::java.util.WeakHashMap) _r4_o)._felementData;
    _r0.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    _r0.l = (long) _r0.i;
    _r2.i = ((global::java.util.WeakHashMap) _r4_o)._floadFactor;
    _r2.l = (long) _r2.i;
    _r0.l = _r0.l * _r2.l;
    _r2.l = 10000L;
    _r0.l = _r0.l / _r2.l;
    _r0.i = (int) _r0.l;
    ((global::java.util.WeakHashMap) _r4_o)._fthreshold = _r0.i;
    return;
//XMLVM_END_WRAPPER[java.util.WeakHashMap: void computeMaxSize()]
}

public override bool containsKey(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.WeakHashMap: boolean containsKey(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::java.util.WeakHashMap) _r1_o).getEntry((global::java.lang.Object) _r2_o);
    if (_r0_o == null) goto label8;
    _r0.i = 1;
    label7:;
    return _r0.i!=0;
    label8:;
    _r0.i = 0;
    goto label7;
//XMLVM_END_WRAPPER[java.util.WeakHashMap: boolean containsKey(java.lang.Object)]
}

public override global::System.Object entrySet(){
//XMLVM_BEGIN_WRAPPER[java.util.WeakHashMap: java.util.Set entrySet()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    ((global::java.util.WeakHashMap) _r1_o).poll();
    _r0_o = new global::java.util.WeakHashMap_21();
    ((global::java.util.WeakHashMap_21) _r0_o).@this((global::java.util.WeakHashMap) _r1_o);
    return (global::java.util.Set) _r0_o;
//XMLVM_END_WRAPPER[java.util.WeakHashMap: java.util.Set entrySet()]
}

public override global::System.Object keySet(){
//XMLVM_BEGIN_WRAPPER[java.util.WeakHashMap: java.util.Set keySet()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    ((global::java.util.WeakHashMap) _r1_o).poll();
    _r0_o = ((global::java.util.WeakHashMap) _r1_o)._fkeySet;
    if (_r0_o != null) goto label14;
    _r0_o = new global::java.util.WeakHashMap_22();
    ((global::java.util.WeakHashMap_22) _r0_o).@this((global::java.util.WeakHashMap) _r1_o);
    ((global::java.util.WeakHashMap) _r1_o)._fkeySet = (global::java.util.Set) _r0_o;
    label14:;
    _r0_o = ((global::java.util.WeakHashMap) _r1_o)._fkeySet;
    return (global::java.util.Set) _r0_o;
//XMLVM_END_WRAPPER[java.util.WeakHashMap: java.util.Set keySet()]
}

public override global::System.Object values(){
//XMLVM_BEGIN_WRAPPER[java.util.WeakHashMap: java.util.Collection values()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    ((global::java.util.WeakHashMap) _r1_o).poll();
    _r0_o = ((global::java.util.WeakHashMap) _r1_o)._fvaluesCollection;
    if (_r0_o != null) goto label14;
    _r0_o = new global::java.util.WeakHashMap_23();
    ((global::java.util.WeakHashMap_23) _r0_o).@this((global::java.util.WeakHashMap) _r1_o);
    ((global::java.util.WeakHashMap) _r1_o)._fvaluesCollection = (global::java.util.Collection) _r0_o;
    label14:;
    _r0_o = ((global::java.util.WeakHashMap) _r1_o)._fvaluesCollection;
    return (global::java.util.Collection) _r0_o;
//XMLVM_END_WRAPPER[java.util.WeakHashMap: java.util.Collection values()]
}

public override global::System.Object get(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.WeakHashMap: java.lang.Object get(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r3_o = this;
    _r4_o = n1;
    _r2_o = null;
    ((global::java.util.WeakHashMap) _r3_o).poll();
    if (_r4_o == null) goto label42;
    _r0.i = ((global::java.lang.Object) _r4_o).hashCode();
    _r1.i = 2147483647;
    _r0.i = _r0.i & _r1.i;
    _r1_o = ((global::java.util.WeakHashMap) _r3_o)._felementData;
    _r1.i = ((global::org.xmlvm._nIArray) _r1_o).Length;
    _r0.i = _r0.i % _r1.i;
    _r1_o = ((global::java.util.WeakHashMap) _r3_o)._felementData;
    _r0_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o)[_r0.i];
    label22:;
    if (_r0_o != null) goto label26;
    _r0_o = _r2_o;
    label25:;
    return (global::java.lang.Object) _r0_o;
    label26:;
    _r1_o = ((global::java.util.WeakHashMap_2Entry) _r0_o).get();
    _r1.i = ((global::java.lang.Object) _r4_o).equals((global::java.lang.Object) _r1_o) ? 1 : 0;
    if (_r1.i == 0) goto label39;
    _r0_o = ((global::java.util.WeakHashMap_2Entry) _r0_o)._fvalue;
    goto label25;
    label39:;
    _r0_o = ((global::java.util.WeakHashMap_2Entry) _r0_o)._fnext;
    goto label22;
    label42:;
    _r0_o = ((global::java.util.WeakHashMap) _r3_o)._felementData;
    _r1.i = 0;
    _r0_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i];
    label47:;
    if (_r0_o != null) goto label51;
    _r0_o = _r2_o;
    goto label25;
    label51:;
    _r1.i = ((global::java.util.WeakHashMap_2Entry) _r0_o)._fisNull ? 1 : 0;
    if (_r1.i == 0) goto label58;
    _r0_o = ((global::java.util.WeakHashMap_2Entry) _r0_o)._fvalue;
    goto label25;
    label58:;
    _r0_o = ((global::java.util.WeakHashMap_2Entry) _r0_o)._fnext;
    goto label47;
//XMLVM_END_WRAPPER[java.util.WeakHashMap: java.lang.Object get(java.lang.Object)]
}

public virtual global::System.Object getEntry(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.WeakHashMap: java.util.WeakHashMap$Entry getEntry(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r3_o = this;
    _r4_o = n1;
    _r2_o = null;
    ((global::java.util.WeakHashMap) _r3_o).poll();
    if (_r4_o == null) goto label39;
    _r0.i = ((global::java.lang.Object) _r4_o).hashCode();
    _r1.i = 2147483647;
    _r0.i = _r0.i & _r1.i;
    _r1_o = ((global::java.util.WeakHashMap) _r3_o)._felementData;
    _r1.i = ((global::org.xmlvm._nIArray) _r1_o).Length;
    _r0.i = _r0.i % _r1.i;
    _r1_o = ((global::java.util.WeakHashMap) _r3_o)._felementData;
    _r0_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o)[_r0.i];
    label22:;
    if (_r0_o != null) goto label26;
    _r0_o = _r2_o;
    label25:;
    return (global::java.util.WeakHashMap_2Entry) _r0_o;
    label26:;
    _r1_o = ((global::java.util.WeakHashMap_2Entry) _r0_o).get();
    _r1.i = ((global::java.lang.Object) _r4_o).equals((global::java.lang.Object) _r1_o) ? 1 : 0;
    if (_r1.i != 0) goto label25;
    _r0_o = ((global::java.util.WeakHashMap_2Entry) _r0_o)._fnext;
    goto label22;
    label39:;
    _r0_o = ((global::java.util.WeakHashMap) _r3_o)._felementData;
    _r1.i = 0;
    _r0_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i];
    label44:;
    if (_r0_o != null) goto label48;
    _r0_o = _r2_o;
    goto label25;
    label48:;
    _r1.i = ((global::java.util.WeakHashMap_2Entry) _r0_o)._fisNull ? 1 : 0;
    if (_r1.i != 0) goto label25;
    _r0_o = ((global::java.util.WeakHashMap_2Entry) _r0_o)._fnext;
    goto label44;
//XMLVM_END_WRAPPER[java.util.WeakHashMap: java.util.WeakHashMap$Entry getEntry(java.lang.Object)]
}

public override bool containsValue(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.WeakHashMap: boolean containsValue(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    _r4_o = this;
    _r5_o = n1;
    _r3.i = 1;
    ((global::java.util.WeakHashMap) _r4_o).poll();
    if (_r5_o == null) goto label44;
    _r0_o = ((global::java.util.WeakHashMap) _r4_o)._felementData;
    _r0.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    label9:;
    _r0.i = _r0.i + -1;
    if (_r0.i >= 0) goto label15;
    label13:;
    _r0.i = 0;
    label14:;
    return _r0.i!=0;
    label15:;
    _r1_o = ((global::java.util.WeakHashMap) _r4_o)._felementData;
    _r1_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o)[_r0.i];
    label19:;
    if (_r1_o == null) goto label9;
    _r2_o = ((global::java.util.WeakHashMap_2Entry) _r1_o).get();
    if (_r2_o != null) goto label31;
    _r2.i = ((global::java.util.WeakHashMap_2Entry) _r1_o)._fisNull ? 1 : 0;
    if (_r2.i == 0) goto label41;
    label31:;
    _r2_o = ((global::java.util.WeakHashMap_2Entry) _r1_o)._fvalue;
    _r2.i = ((global::java.lang.Object) _r5_o).equals((global::java.lang.Object) _r2_o) ? 1 : 0;
    if (_r2.i == 0) goto label41;
    _r0.i = _r3.i;
    goto label14;
    label41:;
    _r1_o = ((global::java.util.WeakHashMap_2Entry) _r1_o)._fnext;
    goto label19;
    label44:;
    _r0_o = ((global::java.util.WeakHashMap) _r4_o)._felementData;
    _r0.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    label47:;
    _r0.i = _r0.i + -1;
    if (_r0.i < 0) goto label13;
    _r1_o = ((global::java.util.WeakHashMap) _r4_o)._felementData;
    _r1_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o)[_r0.i];
    label55:;
    if (_r1_o == null) goto label47;
    _r2_o = ((global::java.util.WeakHashMap_2Entry) _r1_o).get();
    if (_r2_o != null) goto label67;
    _r2.i = ((global::java.util.WeakHashMap_2Entry) _r1_o)._fisNull ? 1 : 0;
    if (_r2.i == 0) goto label73;
    label67:;
    _r2_o = ((global::java.util.WeakHashMap_2Entry) _r1_o)._fvalue;
    if (_r2_o != null) goto label73;
    _r0.i = _r3.i;
    goto label14;
    label73:;
    _r1_o = ((global::java.util.WeakHashMap_2Entry) _r1_o)._fnext;
    goto label55;
//XMLVM_END_WRAPPER[java.util.WeakHashMap: boolean containsValue(java.lang.Object)]
}

public override bool isEmpty(){
//XMLVM_BEGIN_WRAPPER[java.util.WeakHashMap: boolean isEmpty()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::java.util.WeakHashMap) _r1_o).size();
    if (_r0.i != 0) goto label8;
    _r0.i = 1;
    label7:;
    return _r0.i!=0;
    label8:;
    _r0.i = 0;
    goto label7;
//XMLVM_END_WRAPPER[java.util.WeakHashMap: boolean isEmpty()]
}

public virtual void poll(){
//XMLVM_BEGIN_WRAPPER[java.util.WeakHashMap: void poll()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    label0:;
    _r0_o = ((global::java.util.WeakHashMap) _r1_o)._freferenceQueue;
    _r0_o = ((global::java.lang.@ref.ReferenceQueue) _r0_o).poll();
    if (_r0_o != null) goto label11;
    return;
    label11:;
    ((global::java.util.WeakHashMap) _r1_o).removeEntry((global::java.util.WeakHashMap_2Entry) _r0_o);
    goto label0;
//XMLVM_END_WRAPPER[java.util.WeakHashMap: void poll()]
}

public virtual void removeEntry(global::java.util.WeakHashMap_2Entry n1){
//XMLVM_BEGIN_WRAPPER[java.util.WeakHashMap: void removeEntry(java.util.WeakHashMap$Entry)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    _r5_o = this;
    _r6_o = n1;
    _r0_o = null;
    _r1.i = ((global::java.util.WeakHashMap_2Entry) _r6_o)._fhash;
    _r2.i = 2147483647;
    _r1.i = _r1.i & _r2.i;
    _r2_o = ((global::java.util.WeakHashMap) _r5_o)._felementData;
    _r2.i = ((global::org.xmlvm._nIArray) _r2_o).Length;
    _r1.i = _r1.i % _r2.i;
    _r2_o = ((global::java.util.WeakHashMap) _r5_o)._felementData;
    _r2_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o)[_r1.i];
    label15:;
    if (_r2_o != null) goto label18;
    label17:;
    return;
    label18:;
    if (_r6_o != _r2_o) goto label46;
    _r3.i = ((global::java.util.WeakHashMap) _r5_o)._fmodCount;
    _r3.i = _r3.i + 1;
    ((global::java.util.WeakHashMap) _r5_o)._fmodCount = _r3.i;
    if (_r0_o != null) goto label41;
    _r0_o = ((global::java.util.WeakHashMap) _r5_o)._felementData;
    _r2_o = ((global::java.util.WeakHashMap_2Entry) _r2_o)._fnext;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r2_o;
    label34:;
    _r0.i = ((global::java.util.WeakHashMap) _r5_o)._felementCount;
    _r1.i = 1;
    _r0.i = _r0.i - _r1.i;
    ((global::java.util.WeakHashMap) _r5_o)._felementCount = _r0.i;
    goto label17;
    label41:;
    _r1_o = ((global::java.util.WeakHashMap_2Entry) _r2_o)._fnext;
    ((global::java.util.WeakHashMap_2Entry) _r0_o)._fnext = (global::java.util.WeakHashMap_2Entry) _r1_o;
    goto label34;
    label46:;
    _r0_o = ((global::java.util.WeakHashMap_2Entry) _r2_o)._fnext;
    _r4_o = _r2_o;
    _r2_o = _r0_o;
    _r0_o = _r4_o;
    goto label15;
//XMLVM_END_WRAPPER[java.util.WeakHashMap: void removeEntry(java.util.WeakHashMap$Entry)]
}

public override global::System.Object put(global::java.lang.Object n1, global::java.lang.Object n2){
//XMLVM_BEGIN_WRAPPER[java.util.WeakHashMap: java.lang.Object put(java.lang.Object, java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    global::System.Object _r8_o = null;
    _r6_o = this;
    _r7_o = n1;
    _r8_o = n2;
    _r4.i = 2147483647;
    _r3.i = 0;
    ((global::java.util.WeakHashMap) _r6_o).poll();
    if (_r7_o == null) goto label83;
    _r0.i = ((global::java.lang.Object) _r7_o).hashCode();
    _r0.i = _r0.i & _r4.i;
    _r1_o = ((global::java.util.WeakHashMap) _r6_o)._felementData;
    _r1.i = ((global::org.xmlvm._nIArray) _r1_o).Length;
    _r0.i = _r0.i % _r1.i;
    _r1_o = ((global::java.util.WeakHashMap) _r6_o)._felementData;
    _r1_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o)[_r0.i];
    label22:;
    if (_r1_o == null) goto label116;
    _r2_o = ((global::java.util.WeakHashMap_2Entry) _r1_o).get();
    _r2.i = ((global::java.lang.Object) _r7_o).equals((global::java.lang.Object) _r2_o) ? 1 : 0;
    if (_r2.i == 0) goto label80;
    _r5_o = _r1_o;
    _r1.i = _r0.i;
    _r0_o = _r5_o;
    label37:;
    if (_r0_o != null) goto label108;
    _r0.i = ((global::java.util.WeakHashMap) _r6_o)._fmodCount;
    _r0.i = _r0.i + 1;
    ((global::java.util.WeakHashMap) _r6_o)._fmodCount = _r0.i;
    _r0.i = ((global::java.util.WeakHashMap) _r6_o)._felementCount;
    _r0.i = _r0.i + 1;
    ((global::java.util.WeakHashMap) _r6_o)._felementCount = _r0.i;
    _r2.i = ((global::java.util.WeakHashMap) _r6_o)._fthreshold;
    if (_r0.i <= _r2.i) goto label114;
    ((global::java.util.WeakHashMap) _r6_o).rehash();
    if (_r7_o != null) goto label98;
    _r0.i = _r3.i;
    label61:;
    _r1_o = new global::java.util.WeakHashMap_2Entry();
    _r2_o = ((global::java.util.WeakHashMap) _r6_o)._freferenceQueue;
    ((global::java.util.WeakHashMap_2Entry) _r1_o).@this((global::java.lang.Object) _r7_o, (global::java.lang.Object) _r8_o, (global::java.lang.@ref.ReferenceQueue) _r2_o);
    _r2_o = ((global::java.util.WeakHashMap) _r6_o)._felementData;
    _r2_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o)[_r0.i];
    ((global::java.util.WeakHashMap_2Entry) _r1_o)._fnext = (global::java.util.WeakHashMap_2Entry) _r2_o;
    _r2_o = ((global::java.util.WeakHashMap) _r6_o)._felementData;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o)[_r0.i] = _r1_o;
    _r0_o = null;
    label79:;
    return (global::java.lang.Object) _r0_o;
    label80:;
    _r1_o = ((global::java.util.WeakHashMap_2Entry) _r1_o)._fnext;
    goto label22;
    label83:;
    _r0_o = ((global::java.util.WeakHashMap) _r6_o)._felementData;
    _r0_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r3.i];
    label87:;
    if (_r0_o == null) goto label93;
    _r1.i = ((global::java.util.WeakHashMap_2Entry) _r0_o)._fisNull ? 1 : 0;
    if (_r1.i == 0) goto label95;
    label93:;
    _r1.i = _r3.i;
    goto label37;
    label95:;
    _r0_o = ((global::java.util.WeakHashMap_2Entry) _r0_o)._fnext;
    goto label87;
    label98:;
    _r0.i = ((global::java.lang.Object) _r7_o).hashCode();
    _r0.i = _r0.i & _r4.i;
    _r1_o = ((global::java.util.WeakHashMap) _r6_o)._felementData;
    _r1.i = ((global::org.xmlvm._nIArray) _r1_o).Length;
    _r0.i = _r0.i % _r1.i;
    goto label61;
    label108:;
    _r1_o = ((global::java.util.WeakHashMap_2Entry) _r0_o)._fvalue;
    ((global::java.util.WeakHashMap_2Entry) _r0_o)._fvalue = (global::java.lang.Object) _r8_o;
    _r0_o = _r1_o;
    goto label79;
    label114:;
    _r0.i = _r1.i;
    goto label61;
    label116:;
    _r5_o = _r1_o;
    _r1.i = _r0.i;
    _r0_o = _r5_o;
    goto label37;
//XMLVM_END_WRAPPER[java.util.WeakHashMap: java.lang.Object put(java.lang.Object, java.lang.Object)]
}

private void rehash(){
//XMLVM_BEGIN_WRAPPER[java.util.WeakHashMap: void rehash()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::System.Object _r8_o = null;
    _r8_o = this;
    _r7.i = 0;
    _r0_o = ((global::java.util.WeakHashMap) _r8_o)._felementData;
    _r0.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    _r0.i = _r0.i << (0x1f & 1);
    if (_r0.i != 0) goto label9;
    _r0.i = 1;
    label9:;
    _r1_o = global::java.util.WeakHashMap.newEntryArray((int) _r0.i);
    _r2.i = _r7.i;
    label14:;
    _r3_o = ((global::java.util.WeakHashMap) _r8_o)._felementData;
    _r3.i = ((global::org.xmlvm._nIArray) _r3_o).Length;
    if (_r2.i < _r3.i) goto label25;
    ((global::java.util.WeakHashMap) _r8_o)._felementData = (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o;
    ((global::java.util.WeakHashMap) _r8_o).computeMaxSize();
    return;
    label25:;
    _r3_o = ((global::java.util.WeakHashMap) _r8_o)._felementData;
    _r3_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r3_o)[_r2.i];
    label29:;
    if (_r3_o != null) goto label34;
    _r2.i = _r2.i + 1;
    goto label14;
    label34:;
    _r4.i = ((global::java.util.WeakHashMap_2Entry) _r3_o)._fisNull ? 1 : 0;
    if (_r4.i == 0) goto label49;
    _r4.i = _r7.i;
    label39:;
    _r5_o = ((global::java.util.WeakHashMap_2Entry) _r3_o)._fnext;
    _r6_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o)[_r4.i];
    ((global::java.util.WeakHashMap_2Entry) _r3_o)._fnext = (global::java.util.WeakHashMap_2Entry) _r6_o;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o)[_r4.i] = _r3_o;
    _r3_o = _r5_o;
    goto label29;
    label49:;
    _r4.i = ((global::java.util.WeakHashMap_2Entry) _r3_o)._fhash;
    _r5.i = 2147483647;
    _r4.i = _r4.i & _r5.i;
    _r4.i = _r4.i % _r0.i;
    goto label39;
//XMLVM_END_WRAPPER[java.util.WeakHashMap: void rehash()]
}

public override void putAll(global::java.util.Map n1){
//XMLVM_BEGIN_WRAPPER[java.util.WeakHashMap: void putAll(java.util.Map)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.util.WeakHashMap) _r0_o).putAllImpl((global::java.util.Map) _r1_o);
    return;
//XMLVM_END_WRAPPER[java.util.WeakHashMap: void putAll(java.util.Map)]
}

public override global::System.Object remove(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.WeakHashMap: java.lang.Object remove(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    _r6_o = this;
    _r7_o = n1;
    _r4_o = null;
    _r3.i = 0;
    ((global::java.util.WeakHashMap) _r6_o).poll();
    if (_r7_o == null) goto label72;
    _r0.i = ((global::java.lang.Object) _r7_o).hashCode();
    _r1.i = 2147483647;
    _r0.i = _r0.i & _r1.i;
    _r1_o = ((global::java.util.WeakHashMap) _r6_o)._felementData;
    _r1.i = ((global::org.xmlvm._nIArray) _r1_o).Length;
    _r0.i = _r0.i % _r1.i;
    _r1_o = ((global::java.util.WeakHashMap) _r6_o)._felementData;
    _r1_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o)[_r0.i];
    _r2_o = _r1_o;
    _r1_o = _r4_o;
    label25:;
    if (_r2_o == null) goto label99;
    _r3_o = ((global::java.util.WeakHashMap_2Entry) _r2_o).get();
    _r3.i = ((global::java.lang.Object) _r7_o).equals((global::java.lang.Object) _r3_o) ? 1 : 0;
    if (_r3.i == 0) goto label66;
    _r5_o = _r1_o;
    _r1_o = _r2_o;
    _r2.i = _r0.i;
    _r0_o = _r5_o;
    label41:;
    if (_r1_o == null) goto label97;
    _r3.i = ((global::java.util.WeakHashMap) _r6_o)._fmodCount;
    _r3.i = _r3.i + 1;
    ((global::java.util.WeakHashMap) _r6_o)._fmodCount = _r3.i;
    if (_r0_o != null) goto label92;
    _r0_o = ((global::java.util.WeakHashMap) _r6_o)._felementData;
    _r3_o = ((global::java.util.WeakHashMap_2Entry) _r1_o)._fnext;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r2.i] = _r3_o;
    label57:;
    _r0.i = ((global::java.util.WeakHashMap) _r6_o)._felementCount;
    _r2.i = 1;
    _r0.i = _r0.i - _r2.i;
    ((global::java.util.WeakHashMap) _r6_o)._felementCount = _r0.i;
    _r0_o = ((global::java.util.WeakHashMap_2Entry) _r1_o)._fvalue;
    label65:;
    return (global::java.lang.Object) _r0_o;
    label66:;
    _r1_o = ((global::java.util.WeakHashMap_2Entry) _r2_o)._fnext;
    _r5_o = _r2_o;
    _r2_o = _r1_o;
    _r1_o = _r5_o;
    goto label25;
    label72:;
    _r0_o = ((global::java.util.WeakHashMap) _r6_o)._felementData;
    _r0_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r3.i];
    _r1_o = _r0_o;
    _r0_o = _r4_o;
    label78:;
    if (_r1_o == null) goto label84;
    _r2.i = ((global::java.util.WeakHashMap_2Entry) _r1_o)._fisNull ? 1 : 0;
    if (_r2.i == 0) goto label86;
    label84:;
    _r2.i = _r3.i;
    goto label41;
    label86:;
    _r0_o = ((global::java.util.WeakHashMap_2Entry) _r1_o)._fnext;
    _r5_o = _r1_o;
    _r1_o = _r0_o;
    _r0_o = _r5_o;
    goto label78;
    label92:;
    _r2_o = ((global::java.util.WeakHashMap_2Entry) _r1_o)._fnext;
    ((global::java.util.WeakHashMap_2Entry) _r0_o)._fnext = (global::java.util.WeakHashMap_2Entry) _r2_o;
    goto label57;
    label97:;
    _r0_o = _r4_o;
    goto label65;
    label99:;
    _r5_o = _r1_o;
    _r1_o = _r2_o;
    _r2.i = _r0.i;
    _r0_o = _r5_o;
    goto label41;
//XMLVM_END_WRAPPER[java.util.WeakHashMap: java.lang.Object remove(java.lang.Object)]
}

public override int size(){
//XMLVM_BEGIN_WRAPPER[java.util.WeakHashMap: int size()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    ((global::java.util.WeakHashMap) _r1_o).poll();
    _r0.i = ((global::java.util.WeakHashMap) _r1_o)._felementCount;
    return _r0.i;
//XMLVM_END_WRAPPER[java.util.WeakHashMap: int size()]
}

private void putAllImpl(global::java.util.Map n1){
//XMLVM_BEGIN_WRAPPER[java.util.WeakHashMap: void putAllImpl(java.util.Map)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::java.util.Map) _r2_o).entrySet();
    if (_r0_o == null) goto label9;
    base.putAll((global::java.util.Map) _r2_o);
    label9:;
    return;
//XMLVM_END_WRAPPER[java.util.WeakHashMap: void putAllImpl(java.util.Map)]
}

//XMLVM_BEGIN_WRAPPER[java.util.WeakHashMap]
//XMLVM_END_WRAPPER[java.util.WeakHashMap]

} // end of class: WeakHashMap

} // end of namespace: java.util
