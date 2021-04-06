using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace NTI.iMeter.ProjectSetting
{
    [Serializable]
    [DataContract]
    public class SettingDocument
    {
        [IgnoreDataMember]
        [XmlAnyElement]
        public XmlDocument Setting { get; set; }

        [XmlIgnore]
        [DataMember]
        public string XmlSetting
        {
            get
            {
                if (Setting == null) return null;

                StringBuilder sb = new StringBuilder();
                using (StringWriter sw = new StringWriter(sb))
                {
                    Setting.Save(sw);
                }
                return sb.ToString();
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Setting = null;
                    return;
                }

                Setting = new XmlDocument();
                Setting.LoadXml(value);
            }
        }
    }
}
