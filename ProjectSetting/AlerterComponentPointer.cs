using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace NTI.iMeter.ProjectSetting
{
    public class AlerterComponentPointer : ExternalComponentPointer
    {
        [DataMember]
        public string Text { get; set; }

        //public override void ReadXml(XmlReader reader)
        //{
        //    while (reader.NodeType != XmlNodeType.EndElement)
        //    {
        //        reader.Read();
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
        //            case "Text":
        //                Text = reader.GetAttribute("AlertText");
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

        //public override void WriteXml(XmlWriter writer)
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
        //    if (Text != null)
        //    {
        //        writer.WriteStartElement("Text");
        //        writer.WriteAttributeString("AlertText", Text);
        //        writer.WriteEndElement();
        //    }
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