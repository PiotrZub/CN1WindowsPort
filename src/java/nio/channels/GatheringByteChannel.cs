// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.nio.channels {
public abstract class _iGatheringByteChannel {

} // end of abstract class: _iGatheringByteChannel

public interface GatheringByteChannel: global::java.nio.channels.WritableByteChannel {
 long write(global::org.xmlvm._nArrayAdapter<global::System.Object> n1);

 long write(global::org.xmlvm._nArrayAdapter<global::System.Object> n1, int n2, int n3);

new  void close();

new  bool isOpen();

new  int write(global::java.nio.ByteBuffer n1);

//XMLVM_BEGIN_WRAPPER[java.nio.channels.GatheringByteChannel]
//XMLVM_END_WRAPPER[java.nio.channels.GatheringByteChannel]

} // end of interface: GatheringByteChannel

} // end of namespace: java.nio.channels
