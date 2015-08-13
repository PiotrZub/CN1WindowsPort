// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace org.w3c.dom {
public abstract class _iDocument {

} // end of abstract class: _iDocument

public interface Document: global::org.w3c.dom.Node {
 global::System.Object getDoctype();

 global::System.Object getImplementation();

 global::System.Object getDocumentElement();

 global::System.Object createElement(global::java.lang.String n1);

 global::System.Object createDocumentFragment();

 global::System.Object createTextNode(global::java.lang.String n1);

 global::System.Object createComment(global::java.lang.String n1);

 global::System.Object createCDATASection(global::java.lang.String n1);

 global::System.Object createProcessingInstruction(global::java.lang.String n1, global::java.lang.String n2);

 global::System.Object createAttribute(global::java.lang.String n1);

 global::System.Object createEntityReference(global::java.lang.String n1);

 global::System.Object getElementsByTagName(global::java.lang.String n1);

 global::System.Object importNode(global::org.w3c.dom.Node n1, bool n2);

 global::System.Object createElementNS(global::java.lang.String n1, global::java.lang.String n2);

 global::System.Object createAttributeNS(global::java.lang.String n1, global::java.lang.String n2);

 global::System.Object getElementsByTagNameNS(global::java.lang.String n1, global::java.lang.String n2);

 global::System.Object getElementById(global::java.lang.String n1);

 global::System.Object getInputEncoding();

 global::System.Object getXmlEncoding();

 bool getXmlStandalone();

 void setXmlStandalone(bool n1);

 global::System.Object getXmlVersion();

 void setXmlVersion(global::java.lang.String n1);

 bool getStrictErrorChecking();

 void setStrictErrorChecking(bool n1);

 global::System.Object getDocumentURI();

 void setDocumentURI(global::java.lang.String n1);

 global::System.Object adoptNode(global::org.w3c.dom.Node n1);

 global::System.Object getDomConfig();

 void normalizeDocument();

 global::System.Object renameNode(global::org.w3c.dom.Node n1, global::java.lang.String n2, global::java.lang.String n3);

new  global::System.Object appendChild(global::org.w3c.dom.Node n1);

new  global::System.Object cloneNode(bool n1);

new  short compareDocumentPosition(global::org.w3c.dom.Node n1);

new  global::System.Object getAttributes();

new  global::System.Object getBaseURI();

new  global::System.Object getChildNodes();

new  global::System.Object getFeature(global::java.lang.String n1, global::java.lang.String n2);

new  global::System.Object getFirstChild();

new  global::System.Object getLastChild();

new  global::System.Object getLocalName();

new  global::System.Object getNamespaceURI();

new  global::System.Object getNextSibling();

new  global::System.Object getNodeName();

new  short getNodeType();

new  global::System.Object getNodeValue();

new  global::System.Object getOwnerDocument();

new  global::System.Object getParentNode();

new  global::System.Object getPrefix();

new  global::System.Object getPreviousSibling();

new  global::System.Object getTextContent();

new  global::System.Object getUserData(global::java.lang.String n1);

new  bool hasAttributes();

new  bool hasChildNodes();

new  global::System.Object insertBefore(global::org.w3c.dom.Node n1, global::org.w3c.dom.Node n2);

new  bool isDefaultNamespace(global::java.lang.String n1);

new  bool isEqualNode(global::org.w3c.dom.Node n1);

new  bool isSameNode(global::org.w3c.dom.Node n1);

new  bool isSupported(global::java.lang.String n1, global::java.lang.String n2);

new  global::System.Object lookupNamespaceURI(global::java.lang.String n1);

new  global::System.Object lookupPrefix(global::java.lang.String n1);

new  void normalize();

new  global::System.Object removeChild(global::org.w3c.dom.Node n1);

new  global::System.Object replaceChild(global::org.w3c.dom.Node n1, global::org.w3c.dom.Node n2);

new  void setNodeValue(global::java.lang.String n1);

new  void setPrefix(global::java.lang.String n1);

new  void setTextContent(global::java.lang.String n1);

new  global::System.Object setUserData(global::java.lang.String n1, global::java.lang.Object n2, global::org.w3c.dom.UserDataHandler n3);

//XMLVM_BEGIN_WRAPPER[org.w3c.dom.Document]
//XMLVM_END_WRAPPER[org.w3c.dom.Document]

} // end of interface: Document

} // end of namespace: org.w3c.dom
