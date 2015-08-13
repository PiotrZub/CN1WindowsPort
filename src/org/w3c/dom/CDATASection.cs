// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace org.w3c.dom {
public abstract class _iCDATASection {

} // end of abstract class: _iCDATASection

public interface CDATASection: global::org.w3c.dom.Text {
new  global::System.Object appendChild(global::org.w3c.dom.Node n1);

new  void appendData(global::java.lang.String n1);

new  global::System.Object cloneNode(bool n1);

new  short compareDocumentPosition(global::org.w3c.dom.Node n1);

new  void deleteData(int n1, int n2);

new  global::System.Object getAttributes();

new  global::System.Object getBaseURI();

new  global::System.Object getChildNodes();

new  global::System.Object getData();

new  global::System.Object getFeature(global::java.lang.String n1, global::java.lang.String n2);

new  global::System.Object getFirstChild();

new  global::System.Object getLastChild();

new  int getLength();

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

new  global::System.Object getWholeText();

new  bool hasAttributes();

new  bool hasChildNodes();

new  global::System.Object insertBefore(global::org.w3c.dom.Node n1, global::org.w3c.dom.Node n2);

new  void insertData(int n1, global::java.lang.String n2);

new  bool isDefaultNamespace(global::java.lang.String n1);

new  bool isElementContentWhitespace();

new  bool isEqualNode(global::org.w3c.dom.Node n1);

new  bool isSameNode(global::org.w3c.dom.Node n1);

new  bool isSupported(global::java.lang.String n1, global::java.lang.String n2);

new  global::System.Object lookupNamespaceURI(global::java.lang.String n1);

new  global::System.Object lookupPrefix(global::java.lang.String n1);

new  void normalize();

new  global::System.Object removeChild(global::org.w3c.dom.Node n1);

new  global::System.Object replaceChild(global::org.w3c.dom.Node n1, global::org.w3c.dom.Node n2);

new  void replaceData(int n1, int n2, global::java.lang.String n3);

new  global::System.Object replaceWholeText(global::java.lang.String n1);

new  void setData(global::java.lang.String n1);

new  void setNodeValue(global::java.lang.String n1);

new  void setPrefix(global::java.lang.String n1);

new  void setTextContent(global::java.lang.String n1);

new  global::System.Object setUserData(global::java.lang.String n1, global::java.lang.Object n2, global::org.w3c.dom.UserDataHandler n3);

new  global::System.Object splitText(int n1);

new  global::System.Object substringData(int n1, int n2);

//XMLVM_BEGIN_WRAPPER[org.w3c.dom.CDATASection]
//XMLVM_END_WRAPPER[org.w3c.dom.CDATASection]

} // end of interface: CDATASection

} // end of namespace: org.w3c.dom
