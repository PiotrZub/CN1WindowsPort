// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.charts.models {
public class XYMultipleSeriesDataset: global::java.lang.Object {
private global::java.util.List _fmSeries;

new public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.models.XYMultipleSeriesDataset: void <init>()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    ((global::java.lang.Object) _r1_o).@this();
    _r0_o = new global::java.util.ArrayList();
    ((global::java.util.ArrayList) _r0_o).@this();
    ((global::com.codename1.charts.models.XYMultipleSeriesDataset) _r1_o)._fmSeries = (global::java.util.List) _r0_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.models.XYMultipleSeriesDataset: void <init>()]
}

public virtual void addSeries(global::com.codename1.charts.models.XYSeries n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.models.XYMultipleSeriesDataset: void addSeries(com.codename1.charts.models.XYSeries)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    global::System.Threading.Monitor.Enter(_r1_o);
    try {
    _r0_o = ((global::com.codename1.charts.models.XYMultipleSeriesDataset) _r1_o)._fmSeries;
    ((global::java.util.List) _r0_o).add((global::java.lang.Object) _r2_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label8;
        }
        throw ex;
    } // end catch
    global::System.Threading.Monitor.Exit(_r1_o);
    return;
    label8:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    global::System.Threading.Monitor.Exit(_r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.Throwable) _r0_o);
//XMLVM_END_WRAPPER[com.codename1.charts.models.XYMultipleSeriesDataset: void addSeries(com.codename1.charts.models.XYSeries)]
}

public virtual void addSeries(int n1, global::com.codename1.charts.models.XYSeries n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.models.XYMultipleSeriesDataset: void addSeries(int, com.codename1.charts.models.XYSeries)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2.i = n1;
    _r3_o = n2;
    global::System.Threading.Monitor.Enter(_r1_o);
    try {
    _r0_o = ((global::com.codename1.charts.models.XYMultipleSeriesDataset) _r1_o)._fmSeries;
    ((global::java.util.List) _r0_o).add((int) _r2.i, (global::java.lang.Object) _r3_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label8;
        }
        throw ex;
    } // end catch
    global::System.Threading.Monitor.Exit(_r1_o);
    return;
    label8:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    global::System.Threading.Monitor.Exit(_r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.Throwable) _r0_o);
//XMLVM_END_WRAPPER[com.codename1.charts.models.XYMultipleSeriesDataset: void addSeries(int, com.codename1.charts.models.XYSeries)]
}

public virtual void addAllSeries(global::java.util.List n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.models.XYMultipleSeriesDataset: void addAllSeries(java.util.List)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    global::System.Threading.Monitor.Enter(_r1_o);
    try {
    _r0_o = ((global::com.codename1.charts.models.XYMultipleSeriesDataset) _r1_o)._fmSeries;
    ((global::java.util.List) _r0_o).addAll((global::java.util.Collection) _r2_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label8;
        }
        throw ex;
    } // end catch
    global::System.Threading.Monitor.Exit(_r1_o);
    return;
    label8:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    global::System.Threading.Monitor.Exit(_r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.Throwable) _r0_o);
//XMLVM_END_WRAPPER[com.codename1.charts.models.XYMultipleSeriesDataset: void addAllSeries(java.util.List)]
}

public virtual void removeSeries(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.models.XYMultipleSeriesDataset: void removeSeries(int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2.i = n1;
    global::System.Threading.Monitor.Enter(_r1_o);
    try {
    _r0_o = ((global::com.codename1.charts.models.XYMultipleSeriesDataset) _r1_o)._fmSeries;
    ((global::java.util.List) _r0_o).remove((int) _r2.i);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label8;
        }
        throw ex;
    } // end catch
    global::System.Threading.Monitor.Exit(_r1_o);
    return;
    label8:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    global::System.Threading.Monitor.Exit(_r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.Throwable) _r0_o);
//XMLVM_END_WRAPPER[com.codename1.charts.models.XYMultipleSeriesDataset: void removeSeries(int)]
}

public virtual void removeSeries(global::com.codename1.charts.models.XYSeries n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.models.XYMultipleSeriesDataset: void removeSeries(com.codename1.charts.models.XYSeries)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    global::System.Threading.Monitor.Enter(_r1_o);
    try {
    _r0_o = ((global::com.codename1.charts.models.XYMultipleSeriesDataset) _r1_o)._fmSeries;
    ((global::java.util.List) _r0_o).remove((global::java.lang.Object) _r2_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label8;
        }
        throw ex;
    } // end catch
    global::System.Threading.Monitor.Exit(_r1_o);
    return;
    label8:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    global::System.Threading.Monitor.Exit(_r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.Throwable) _r0_o);
//XMLVM_END_WRAPPER[com.codename1.charts.models.XYMultipleSeriesDataset: void removeSeries(com.codename1.charts.models.XYSeries)]
}

public virtual void clear(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.models.XYMultipleSeriesDataset: void clear()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    global::System.Threading.Monitor.Enter(_r1_o);
    try {
    _r0_o = ((global::com.codename1.charts.models.XYMultipleSeriesDataset) _r1_o)._fmSeries;
    ((global::java.util.List) _r0_o).clear();
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label8;
        }
        throw ex;
    } // end catch
    global::System.Threading.Monitor.Exit(_r1_o);
    return;
    label8:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    global::System.Threading.Monitor.Exit(_r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.Throwable) _r0_o);
//XMLVM_END_WRAPPER[com.codename1.charts.models.XYMultipleSeriesDataset: void clear()]
}

public virtual global::System.Object getSeriesAt(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.models.XYMultipleSeriesDataset: com.codename1.charts.models.XYSeries getSeriesAt(int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2.i = n1;
    global::System.Threading.Monitor.Enter(_r1_o);
    try {
    _r0_o = ((global::com.codename1.charts.models.XYMultipleSeriesDataset) _r1_o)._fmSeries;
    _r0_o = ((global::java.util.List) _r0_o).get((int) _r2.i);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label11;
        }
        throw ex;
    } // end catch
    global::System.Threading.Monitor.Exit(_r1_o);
    return (global::com.codename1.charts.models.XYSeries) _r0_o;
    label11:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    global::System.Threading.Monitor.Exit(_r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.Throwable) _r0_o);
//XMLVM_END_WRAPPER[com.codename1.charts.models.XYMultipleSeriesDataset: com.codename1.charts.models.XYSeries getSeriesAt(int)]
}

public virtual int getSeriesCount(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.models.XYMultipleSeriesDataset: int getSeriesCount()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    global::System.Threading.Monitor.Enter(_r1_o);
    try {
    _r0_o = ((global::com.codename1.charts.models.XYMultipleSeriesDataset) _r1_o)._fmSeries;
    _r0.i = ((global::java.util.List) _r0_o).size();
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label9;
        }
        throw ex;
    } // end catch
    global::System.Threading.Monitor.Exit(_r1_o);
    return _r0.i;
    label9:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    global::System.Threading.Monitor.Exit(_r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.Throwable) _r0_o);
//XMLVM_END_WRAPPER[com.codename1.charts.models.XYMultipleSeriesDataset: int getSeriesCount()]
}

public virtual global::System.Object getSeries(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.models.XYMultipleSeriesDataset: com.codename1.charts.models.XYSeries[] getSeries()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    global::System.Threading.Monitor.Enter(_r2_o);
    try {
    _r1_o = ((global::com.codename1.charts.models.XYMultipleSeriesDataset) _r2_o)._fmSeries;
    _r1.i = ((global::java.util.List) _r1_o).size();
    _r0_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r1.i]);
    _r1_o = ((global::com.codename1.charts.models.XYMultipleSeriesDataset) _r2_o)._fmSeries;
    _r1_o = ((global::java.util.List) _r1_o).toArray((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label19;
        }
        throw ex;
    } // end catch
    global::System.Threading.Monitor.Exit(_r2_o);
    return (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o;
    label19:;
    _r1_o = _ex.getJavaException();
    _ex = null;
    global::System.Threading.Monitor.Exit(_r2_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.Throwable) _r1_o);
//XMLVM_END_WRAPPER[com.codename1.charts.models.XYMultipleSeriesDataset: com.codename1.charts.models.XYSeries[] getSeries()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.charts.models.XYMultipleSeriesDataset]
//XMLVM_END_WRAPPER[com.codename1.charts.models.XYMultipleSeriesDataset]

} // end of class: XYMultipleSeriesDataset

} // end of namespace: com.codename1.charts.models
