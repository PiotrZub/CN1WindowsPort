// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace org.w3c.dom.events {
public abstract class _iMutationEvent {
public static short _fMODIFICATION = 1;

public static short _fADDITION = 2;

public static short _fREMOVAL = 3;


} // end of abstract class: _iMutationEvent

public interface MutationEvent: global::org.w3c.dom.events.Event {
 global::System.Object getRelatedNode();

 global::System.Object getPrevValue();

 global::System.Object getNewValue();

 global::System.Object getAttrName();

 short getAttrChange();

 void initMutationEvent(global::java.lang.String n1, bool n2, bool n3, global::org.w3c.dom.Node n4, global::java.lang.String n5, global::java.lang.String n6, global::java.lang.String n7, short n8);

new  bool getBubbles();

new  bool getCancelable();

new  global::System.Object getCurrentTarget();

new  short getEventPhase();

new  global::System.Object getTarget();

new  long getTimeStamp();

new  global::System.Object getType();

new  void initEvent(global::java.lang.String n1, bool n2, bool n3);

new  void preventDefault();

new  void stopPropagation();

//XMLVM_BEGIN_WRAPPER[org.w3c.dom.events.MutationEvent]
//XMLVM_END_WRAPPER[org.w3c.dom.events.MutationEvent]

} // end of interface: MutationEvent

} // end of namespace: org.w3c.dom.events
