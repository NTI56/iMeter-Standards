using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NTI.iMeter.ProjectSetting.Sequencer
{
    [Serializable]
    [DataContract]
    public class SequencerDefinition : Entity
    {
	    private Guid _deviceId;
	    private Guid _channelId;
	    private ObservableCollection<Guid> _variableIds = new ObservableCollection<Guid>();
	    private string _customizedTimeSourceIdPath;
	    private bool _isStrongCustomizedTypeTimeSource;

        [DataMember]
        public long FetchingIntervalMilliseconds { get; set; }

        [XmlIgnore]
	    public TimeSpan FetchingInterval
	    {
		    get { return TimeSpan.FromMilliseconds(FetchingIntervalMilliseconds); }
		    set
		    {
                long ms = (long)value.TotalMilliseconds;
			    if (ms.Equals(FetchingIntervalMilliseconds)) return;
				BeforePropertySet();
                FetchingIntervalMilliseconds = ms;
			    AfterPropertySet();
		    }
	    }

	    [DataMember]
	    public Guid DeviceId
	    {
		    get { return _deviceId; }
		    set
		    {
			    if (value.Equals(_deviceId)) return;
				BeforePropertySet();
			    _deviceId = value;
				AfterPropertySet();
		    }
	    }

	    [DataMember]
	    public Guid ChannelId
	    {
		    get { return _channelId; }
		    set
		    {
			    if (value.Equals(_channelId)) return;
				BeforePropertySet();
			    _channelId = value;
				AfterPropertySet();
		    }
	    }

	    [DataMember]
	    public ObservableCollection<Guid> VariableIds
	    {
		    get { return _variableIds; }
		    set
		    {
			    if (Equals(value, _variableIds)) return;
				BeforePropertySet();
			    _variableIds = value;
				AfterPropertySet();
		    }
	    }

	    [DataMember]
	    public string CustomizedTimeSourceIdPath
	    {
		    get { return _customizedTimeSourceIdPath; }
		    set
		    {
			    if (value == _customizedTimeSourceIdPath) return;
				BeforePropertySet();
			    _customizedTimeSourceIdPath = value;
				AfterPropertySet();
		    }
	    }

	    //VariableId[index].TypeId[index].TypeId.TypeId[index]...TypeId  Must be DateTime or ISequencerTimeSource. Set to null to use Crawler time.
	    [DataMember]
	    public bool IsStrongCustomizedTypeTimeSource
	    {
		    get { return _isStrongCustomizedTypeTimeSource; }
		    set
		    {
			    if (value == _isStrongCustomizedTypeTimeSource) return;
				BeforePropertySet();
			    _isStrongCustomizedTypeTimeSource = value;
				AfterPropertySet();
		    }
	    }
    }
}
