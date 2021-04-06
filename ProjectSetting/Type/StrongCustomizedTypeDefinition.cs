using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NTI.iMeter.ProjectSetting.Type
{
    [Serializable]
    [DataContract]
    public class StrongCustomizedTypeDefinition : TypeDefinitionBase
    {
        private Guid _typeId;
        private ExternalComponentPointer _strongCustomizedType;
        private ExternalComponentPointer _converter;
        private Guid _selectedConverterOutputId;
        private ExternalComponentPointer _filter;
        private AlerterComponentPointer _alerter;

        [XmlIgnore]
        public override TypeDefinitionType Type => TypeDefinitionType.StrongCustomized;

        [DataMember]
        public Guid TypeId
        {
            get { return _typeId; }
            set
            {
                if (value.Equals(_typeId)) return;
                BeforePropertySet();
                _typeId = value;
                AfterPropertySet();
            }
        }

        [DataMember]
        public ExternalComponentPointer StrongCustomizedType
        {
            get { return _strongCustomizedType; }
            set
            {
                if (Equals(value, _strongCustomizedType)) return;
                BeforePropertySet();
                _strongCustomizedType = value;
                AfterPropertySet();
            }
        }

        [DataMember]
        public ExternalComponentPointer Converter
        {
            get { return _converter; }
            set
            {
                if (Equals(value, _converter)) return;
                BeforePropertySet();
                _converter = value;
                AfterPropertySet();
            }
        }

        [DataMember]
        public Guid SelectedConverterOutputId
        {
            get { return _selectedConverterOutputId; }
            set
            {
                if (value.Equals(_selectedConverterOutputId)) return;
                BeforePropertySet();
                _selectedConverterOutputId = value;
                AfterPropertySet();
            }
        }

        [DataMember]
        public ExternalComponentPointer Filter
        {
            get { return _filter; }
            set
            {
                if (Equals(value, _filter)) return;
                BeforePropertySet();
                _filter = value;
                AfterPropertySet();
            }
        }

        [DataMember]
        public AlerterComponentPointer Alerter
        {
            get { return _alerter; }
            set
            {
                if (Equals(value, _alerter)) return;
                BeforePropertySet();
                _alerter = value;
                AfterPropertySet();
            }
        }
    }
}
