using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace NTI.iMeter.ProjectSetting
{
    [XmlInclude(typeof(AlerterComponentPointer))]
    [Serializable]
    public class ExternalComponentPointer// : IXmlSerializable
    {
        [DataMember]
        public Guid UILibraryId { get; set; }
        [DataMember]
        public Guid UIComponentId { get; set; }
        [DataMember]
        public Guid RuntimeLibraryId { get; set; }
        [DataMember]
        public Guid RuntimeComponentId { get; set; }
        [DataMember]
        public Guid? SettingVersion { get; set; }

        [DataMember]
        public SettingDocument SettingDocument { get; set; }

        [XmlIgnore]
        public XmlDocument Setting
        {
            get
            {
                return SettingDocument?.Setting;
            }
            set
            {
                SettingDocument = new SettingDocument() { Setting = value };
            }
        }

        //public XmlSchema GetSchema()
        //{
        //    return null;
        //}

        //public virtual void ReadXml(XmlReader reader)
        //{
        //    //if (reader.NodeType == XmlNodeType.EndElement)
        //    //    return;
        //    while (reader.NodeType != XmlNodeType.EndElement)
        //    {
        //        reader.Read();
        //        //if (reader.NodeType == XmlNodeType.EndElement)
        //        //    return;
        //        switch (reader.Name)
        //        {
        //            case "UI":
        //                UILibraryId = new Guid(reader.GetAttribute("LibraryId"));
        //                UIComponentId = new Guid(reader.GetAttribute("ComponentId"));
        //                var settingVersion = reader.GetAttribute("SettingVersion");
        //                if (settingVersion != null)
        //                    SettingVersion = new Guid(settingVersion);
        //                break;
        //            case "Runtime":
        //                RuntimeLibraryId = new Guid(reader.GetAttribute("LibraryId"));
        //                RuntimeComponentId = new Guid(reader.GetAttribute("ComponentId"));
        //                break;
        //            case "Setting":
        //                Setting = new XmlDocument();
        //                var xml = reader.ReadInnerXml();
        //                if (!string.IsNullOrEmpty(xml))
        //                    Setting.LoadXml(xml);
        //                break;
        //        }
        //        reader.MoveToContent();
        //    }
        //}

        //public virtual void WriteXml(XmlWriter writer)
        //{
        //    writer.WriteStartElement("UI");
        //    writer.WriteAttributeString("LibraryId", UILibraryId.ToString("N"));
        //    writer.WriteAttributeString("ComponentId", UIComponentId.ToString("N"));
        //    if (SettingVersion.HasValue)
        //        writer.WriteAttributeString("SettingVersion", SettingVersion.Value.ToString("N"));
        //    writer.WriteEndElement();
        //    writer.WriteStartElement("Runtime");
        //    writer.WriteAttributeString("LibraryId", RuntimeLibraryId.ToString("N"));
        //    writer.WriteAttributeString("ComponentId", RuntimeComponentId.ToString("N"));
        //    writer.WriteEndElement();
        //    if (Setting != null)
        //    {
        //        //var firstNode = Setting.FirstChild;
        //        //firstNode.Attributes.RemoveNamedItem("xmlns:xsi");
        //        //firstNode.Attributes.RemoveNamedItem("xmlns:xsd");
        //        writer.WriteStartElement("Setting");
        //        writer.WriteNode(Setting.CreateNavigator(), false);
        //        writer.WriteEndElement();
        //    }
        //}
    }
}