// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.lang {
public abstract class ClassLoader: global::java.lang.Object {

static ClassLoader() {
    @static();
}

public static global::java.lang.ClassLoader _fsystemClassLoader;

public static void initializeClassLoaders(){
//XMLVM_BEGIN_WRAPPER[java.lang.ClassLoader: void initializeClassLoaders()]
    return;
//XMLVM_END_WRAPPER[java.lang.ClassLoader: void initializeClassLoaders()]
}

public static global::System.Object getSystemClassLoader(){
//XMLVM_BEGIN_WRAPPER[java.lang.ClassLoader: java.lang.ClassLoader getSystemClassLoader()]
    global::System.Object _r0_o = null;
    _r0_o = global::java.lang.ClassLoader._fsystemClassLoader;
    return (global::java.lang.ClassLoader) _r0_o;
//XMLVM_END_WRAPPER[java.lang.ClassLoader: java.lang.ClassLoader getSystemClassLoader()]
}

public static global::System.Object getSystemResource(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[java.lang.ClassLoader: java.net.URL getSystemResource(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = n1;
    _r0_o = global::org.xmlvm._nTIB.getClass(typeof(global::java.lang.Class));
    _r0_o = ((global::java.lang.Class) _r0_o).getResource((global::java.lang.String) _r1_o);
    return (global::java.net.URL) _r0_o;
//XMLVM_END_WRAPPER[java.lang.ClassLoader: java.net.URL getSystemResource(java.lang.String)]
}

public static global::System.Object getSystemResources(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[java.lang.ClassLoader: java.util.Enumeration getSystemResources(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = n1;
    _r0_o = null;
    return (global::java.util.Enumeration) _r0_o;
//XMLVM_END_WRAPPER[java.lang.ClassLoader: java.util.Enumeration getSystemResources(java.lang.String)]
}

public static global::System.Object getSystemResourceAsStream(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[java.lang.ClassLoader: java.io.InputStream getSystemResourceAsStream(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = n1;
    _r0_o = global::org.xmlvm._nTIB.getClass(typeof(global::java.lang.Class));
    _r0_o = ((global::java.lang.Class) _r0_o).getResourceAsStream((global::java.lang.String) _r1_o);
    return (global::java.io.InputStream) _r0_o;
//XMLVM_END_WRAPPER[java.lang.ClassLoader: java.io.InputStream getSystemResourceAsStream(java.lang.String)]
}

new public void @this(){
//XMLVM_BEGIN_WRAPPER[java.lang.ClassLoader: void <init>()]
    global::System.Object _r0_o = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[java.lang.ClassLoader: void <init>()]
}

public void @this(global::java.lang.ClassLoader n1){
//XMLVM_BEGIN_WRAPPER[java.lang.ClassLoader: void <init>(java.lang.ClassLoader)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[java.lang.ClassLoader: void <init>(java.lang.ClassLoader)]
}

public virtual global::System.Object defineClass(global::org.xmlvm._nArrayAdapter<sbyte> n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[java.lang.ClassLoader: java.lang.Class defineClass(byte[], int, int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    _r1_o = this;
    _r2_o = n1;
    _r3.i = n2;
    _r4.i = n3;
    _r0_o = null;
    return (global::java.lang.Class) _r0_o;
//XMLVM_END_WRAPPER[java.lang.ClassLoader: java.lang.Class defineClass(byte[], int, int)]
}

public virtual global::System.Object defineClass(global::java.lang.String n1, global::org.xmlvm._nArrayAdapter<sbyte> n2, int n3, int n4){
//XMLVM_BEGIN_WRAPPER[java.lang.ClassLoader: java.lang.Class defineClass(java.lang.String, byte[], int, int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r4.i = n3;
    _r5.i = n4;
    _r0_o = null;
    return (global::java.lang.Class) _r0_o;
//XMLVM_END_WRAPPER[java.lang.ClassLoader: java.lang.Class defineClass(java.lang.String, byte[], int, int)]
}

public virtual global::System.Object defineClass(global::java.lang.String n1, global::org.xmlvm._nArrayAdapter<sbyte> n2, int n3, int n4, global::org.xmlvm.runtime.RedTypeMarker n5){
//XMLVM_BEGIN_WRAPPER[java.lang.ClassLoader: java.lang.Class defineClass(java.lang.String, byte[], int, int, java.security.ProtectionDomain)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r6_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r4.i = n3;
    _r5.i = n4;
    _r6_o = n5;
    _r0_o = null;
    return (global::java.lang.Class) _r0_o;
//XMLVM_END_WRAPPER[java.lang.ClassLoader: java.lang.Class defineClass(java.lang.String, byte[], int, int, java.security.ProtectionDomain)]
}

public virtual global::System.Object defineClass(global::java.lang.String n1, global::java.nio.ByteBuffer n2, global::org.xmlvm.runtime.RedTypeMarker n3){
//XMLVM_BEGIN_WRAPPER[java.lang.ClassLoader: java.lang.Class defineClass(java.lang.String, java.nio.ByteBuffer, java.security.ProtectionDomain)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    global::System.Object _r8_o = null;
    global::System.Object _r9_o = null;
    _r6_o = this;
    _r7_o = n1;
    _r8_o = n2;
    _r9_o = n3;
    _r0.i = ((global::java.nio.ByteBuffer) _r8_o).remaining();
    _r2_o = new global::org.xmlvm._nArrayAdapter<sbyte>(new sbyte[_r0.i]);
    ((global::java.nio.ByteBuffer) _r8_o).get((global::org.xmlvm._nArrayAdapter<sbyte>) _r2_o);
    _r3.i = 0;
    _r4.i = ((global::org.xmlvm._nIArray) _r2_o).Length;
    _r0_o = _r6_o;
    _r1_o = _r7_o;
    _r5_o = _r9_o;
    _r0_o = ((global::java.lang.ClassLoader) _r0_o).defineClass((global::java.lang.String) _r1_o, (global::org.xmlvm._nArrayAdapter<sbyte>) _r2_o, (int) _r3.i, (int) _r4.i, (global::org.xmlvm.runtime.RedTypeMarker) _r5_o);
    return (global::java.lang.Class) _r0_o;
//XMLVM_END_WRAPPER[java.lang.ClassLoader: java.lang.Class defineClass(java.lang.String, java.nio.ByteBuffer, java.security.ProtectionDomain)]
}

public virtual global::System.Object findClass(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[java.lang.ClassLoader: java.lang.Class findClass(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = null;
    return (global::java.lang.Class) _r0_o;
//XMLVM_END_WRAPPER[java.lang.ClassLoader: java.lang.Class findClass(java.lang.String)]
}

public virtual global::System.Object findLoadedClass(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[java.lang.ClassLoader: java.lang.Class findLoadedClass(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = null;
    return (global::java.lang.Class) _r0_o;
//XMLVM_END_WRAPPER[java.lang.ClassLoader: java.lang.Class findLoadedClass(java.lang.String)]
}

public virtual global::System.Object findSystemClass(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[java.lang.ClassLoader: java.lang.Class findSystemClass(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = null;
    return (global::java.lang.Class) _r0_o;
//XMLVM_END_WRAPPER[java.lang.ClassLoader: java.lang.Class findSystemClass(java.lang.String)]
}

public virtual global::System.Object getParent(){
//XMLVM_BEGIN_WRAPPER[java.lang.ClassLoader: java.lang.ClassLoader getParent()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = null;
    return (global::java.lang.ClassLoader) _r0_o;
//XMLVM_END_WRAPPER[java.lang.ClassLoader: java.lang.ClassLoader getParent()]
}

public virtual global::System.Object getResource(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[java.lang.ClassLoader: java.net.URL getResource(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = global::org.xmlvm._nTIB.getClass(typeof(global::java.lang.Class));
    _r0_o = ((global::java.lang.Class) _r0_o).getResource((global::java.lang.String) _r2_o);
    return (global::java.net.URL) _r0_o;
//XMLVM_END_WRAPPER[java.lang.ClassLoader: java.net.URL getResource(java.lang.String)]
}

public virtual global::System.Object getResources(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[java.lang.ClassLoader: java.util.Enumeration getResources(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = null;
    return (global::java.util.Enumeration) _r0_o;
//XMLVM_END_WRAPPER[java.lang.ClassLoader: java.util.Enumeration getResources(java.lang.String)]
}

public virtual global::System.Object getResourceAsStream(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[java.lang.ClassLoader: java.io.InputStream getResourceAsStream(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = global::org.xmlvm._nTIB.getClass(typeof(global::java.lang.Class));
    _r0_o = ((global::java.lang.Class) _r0_o).getResourceAsStream((global::java.lang.String) _r2_o);
    return (global::java.io.InputStream) _r0_o;
//XMLVM_END_WRAPPER[java.lang.ClassLoader: java.io.InputStream getResourceAsStream(java.lang.String)]
}

public virtual global::System.Object loadClass(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[java.lang.ClassLoader: java.lang.Class loadClass(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = global::java.lang.Class.forName((global::java.lang.String) _r2_o);
    return (global::java.lang.Class) _r0_o;
//XMLVM_END_WRAPPER[java.lang.ClassLoader: java.lang.Class loadClass(java.lang.String)]
}

public virtual global::System.Object loadClass(global::java.lang.String n1, bool n2){
//XMLVM_BEGIN_WRAPPER[java.lang.ClassLoader: java.lang.Class loadClass(java.lang.String, boolean)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    _r1_o = this;
    _r2_o = n1;
    _r3.i = n2 ? 1 : 0;
    _r0_o = ((global::java.lang.ClassLoader) _r1_o).loadClass((global::java.lang.String) _r2_o);
    return (global::java.lang.Class) _r0_o;
//XMLVM_END_WRAPPER[java.lang.ClassLoader: java.lang.Class loadClass(java.lang.String, boolean)]
}

public virtual void resolveClass(global::java.lang.Class n1){
//XMLVM_BEGIN_WRAPPER[java.lang.ClassLoader: void resolveClass(java.lang.Class)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    return;
//XMLVM_END_WRAPPER[java.lang.ClassLoader: void resolveClass(java.lang.Class)]
}

public virtual bool isSystemClassLoader(){
//XMLVM_BEGIN_WRAPPER[java.lang.ClassLoader: boolean isSystemClassLoader()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.lang.ClassLoader: boolean isSystemClassLoader()]
}

public virtual bool isAncestorOf(global::java.lang.ClassLoader n1){
//XMLVM_BEGIN_WRAPPER[java.lang.ClassLoader: boolean isAncestorOf(java.lang.ClassLoader)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0.i = 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.lang.ClassLoader: boolean isAncestorOf(java.lang.ClassLoader)]
}

public virtual global::System.Object findResource(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[java.lang.ClassLoader: java.net.URL findResource(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = global::org.xmlvm._nTIB.getClass(typeof(global::java.lang.Class));
    _r0_o = ((global::java.lang.Class) _r0_o).getResource((global::java.lang.String) _r2_o);
    return (global::java.net.URL) _r0_o;
//XMLVM_END_WRAPPER[java.lang.ClassLoader: java.net.URL findResource(java.lang.String)]
}

public virtual global::System.Object findResources(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[java.lang.ClassLoader: java.util.Enumeration findResources(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = null;
    return (global::java.util.Enumeration) _r0_o;
//XMLVM_END_WRAPPER[java.lang.ClassLoader: java.util.Enumeration findResources(java.lang.String)]
}

public virtual global::System.Object findLibrary(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[java.lang.ClassLoader: java.lang.String findLibrary(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = null;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[java.lang.ClassLoader: java.lang.String findLibrary(java.lang.String)]
}

public virtual global::System.Object getPackage(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[java.lang.ClassLoader: java.lang.Package getPackage(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = null;
    return (global::java.lang.Package) _r0_o;
//XMLVM_END_WRAPPER[java.lang.ClassLoader: java.lang.Package getPackage(java.lang.String)]
}

public virtual global::System.Object getPackages(){
//XMLVM_BEGIN_WRAPPER[java.lang.ClassLoader: java.lang.Package[] getPackages()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = null;
    return (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o;
//XMLVM_END_WRAPPER[java.lang.ClassLoader: java.lang.Package[] getPackages()]
}

public virtual global::System.Object definePackage(global::java.lang.String n1, global::java.lang.String n2, global::java.lang.String n3, global::java.lang.String n4, global::java.lang.String n5, global::java.lang.String n6, global::java.lang.String n7, global::java.net.URL n8){
//XMLVM_BEGIN_WRAPPER[java.lang.ClassLoader: java.lang.Package definePackage(java.lang.String, java.lang.String, java.lang.String, java.lang.String, java.lang.String, java.lang.String, java.lang.String, java.net.URL)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    global::System.Object _r8_o = null;
    global::System.Object _r9_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r4_o = n3;
    _r5_o = n4;
    _r6_o = n5;
    _r7_o = n6;
    _r8_o = n7;
    _r9_o = n8;
    _r0_o = null;
    return (global::java.lang.Package) _r0_o;
//XMLVM_END_WRAPPER[java.lang.ClassLoader: java.lang.Package definePackage(java.lang.String, java.lang.String, java.lang.String, java.lang.String, java.lang.String, java.lang.String, java.lang.String, java.net.URL)]
}

public virtual global::System.Object getSigners(global::java.lang.Class n1){
//XMLVM_BEGIN_WRAPPER[java.lang.ClassLoader: java.lang.Object[] getSigners(java.lang.Class)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = null;
    return (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o;
//XMLVM_END_WRAPPER[java.lang.ClassLoader: java.lang.Object[] getSigners(java.lang.Class)]
}

public virtual void setSigners(global::java.lang.Class n1, global::org.xmlvm._nArrayAdapter<global::System.Object> n2){
//XMLVM_BEGIN_WRAPPER[java.lang.ClassLoader: void setSigners(java.lang.Class, java.lang.Object[])]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    return;
//XMLVM_END_WRAPPER[java.lang.ClassLoader: void setSigners(java.lang.Class, java.lang.Object[])]
}

public static global::System.Object getStackClassLoader(int n1){
//XMLVM_BEGIN_WRAPPER[java.lang.ClassLoader: java.lang.ClassLoader getStackClassLoader(int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r1.i = n1;
    _r0_o = null;
    return (global::java.lang.ClassLoader) _r0_o;
//XMLVM_END_WRAPPER[java.lang.ClassLoader: java.lang.ClassLoader getStackClassLoader(int)]
}

public static global::System.Object callerClassLoader(){
//XMLVM_BEGIN_WRAPPER[java.lang.ClassLoader: java.lang.ClassLoader callerClassLoader()]
    global::System.Object _r0_o = null;
    _r0_o = null;
    return (global::java.lang.ClassLoader) _r0_o;
//XMLVM_END_WRAPPER[java.lang.ClassLoader: java.lang.ClassLoader callerClassLoader()]
}

public static void loadLibraryWithClassLoader(global::java.lang.String n1, global::java.lang.ClassLoader n2){
//XMLVM_BEGIN_WRAPPER[java.lang.ClassLoader: void loadLibraryWithClassLoader(java.lang.String, java.lang.ClassLoader)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = n1;
    _r1_o = n2;
    return;
//XMLVM_END_WRAPPER[java.lang.ClassLoader: void loadLibraryWithClassLoader(java.lang.String, java.lang.ClassLoader)]
}

public static void loadLibraryWithPath(global::java.lang.String n1, global::java.lang.ClassLoader n2, global::java.lang.String n3){
//XMLVM_BEGIN_WRAPPER[java.lang.ClassLoader: void loadLibraryWithPath(java.lang.String, java.lang.ClassLoader, java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r0_o = n1;
    _r1_o = n2;
    _r2_o = n3;
    return;
//XMLVM_END_WRAPPER[java.lang.ClassLoader: void loadLibraryWithPath(java.lang.String, java.lang.ClassLoader, java.lang.String)]
}

public virtual void setClassAssertionStatus(global::java.lang.String n1, bool n2){
//XMLVM_BEGIN_WRAPPER[java.lang.ClassLoader: void setClassAssertionStatus(java.lang.String, boolean)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r0_o = this;
    _r1_o = n1;
    _r2.i = n2 ? 1 : 0;
    return;
//XMLVM_END_WRAPPER[java.lang.ClassLoader: void setClassAssertionStatus(java.lang.String, boolean)]
}

public virtual void setPackageAssertionStatus(global::java.lang.String n1, bool n2){
//XMLVM_BEGIN_WRAPPER[java.lang.ClassLoader: void setPackageAssertionStatus(java.lang.String, boolean)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r0_o = this;
    _r1_o = n1;
    _r2.i = n2 ? 1 : 0;
    return;
//XMLVM_END_WRAPPER[java.lang.ClassLoader: void setPackageAssertionStatus(java.lang.String, boolean)]
}

public virtual void setDefaultAssertionStatus(bool n1){
//XMLVM_BEGIN_WRAPPER[java.lang.ClassLoader: void setDefaultAssertionStatus(boolean)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.i = n1 ? 1 : 0;
    return;
//XMLVM_END_WRAPPER[java.lang.ClassLoader: void setDefaultAssertionStatus(boolean)]
}

public virtual void clearAssertionStatus(){
//XMLVM_BEGIN_WRAPPER[java.lang.ClassLoader: void clearAssertionStatus()]
    global::System.Object _r0_o = null;
    _r0_o = this;
    return;
//XMLVM_END_WRAPPER[java.lang.ClassLoader: void clearAssertionStatus()]
}

public virtual bool getClassAssertionStatus(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[java.lang.ClassLoader: boolean getClassAssertionStatus(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0.i = 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.lang.ClassLoader: boolean getClassAssertionStatus(java.lang.String)]
}

public virtual bool getPackageAssertionStatus(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[java.lang.ClassLoader: boolean getPackageAssertionStatus(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0.i = 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.lang.ClassLoader: boolean getPackageAssertionStatus(java.lang.String)]
}

public virtual bool getDefaultAssertionStatus(){
//XMLVM_BEGIN_WRAPPER[java.lang.ClassLoader: boolean getDefaultAssertionStatus()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.lang.ClassLoader: boolean getDefaultAssertionStatus()]
}

new public static void @static(){
//XMLVM_BEGIN_WRAPPER[java.lang.ClassLoader: void <clinit>()]
    global::System.Object _r0_o = null;
    _r0_o = new global::org.xmlvm.runtime.XMLVMClassLoader();
    ((global::org.xmlvm.runtime.XMLVMClassLoader) _r0_o).@this();
    global::java.lang.ClassLoader._fsystemClassLoader = (global::java.lang.ClassLoader) _r0_o;
    return;
//XMLVM_END_WRAPPER[java.lang.ClassLoader: void <clinit>()]
}

//XMLVM_BEGIN_WRAPPER[java.lang.ClassLoader]
//XMLVM_END_WRAPPER[java.lang.ClassLoader]

} // end of class: ClassLoader

} // end of namespace: java.lang
