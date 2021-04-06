using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using NTI.iMeter.ProjectSetting.Crawler;
using NTI.iMeter.ProjectSetting.Device;
using NTI.iMeter.ProjectSetting.Optimized;
using NTI.iMeter.ProjectSetting.Output;
using NTI.iMeter.ProjectSetting.Processor;
using NTI.iMeter.ProjectSetting.Sequencer;
using NTI.iMeter.ProjectSetting.Type;
using NTI.iMeter.ProjectSetting.Variable;

namespace NTI.iMeter.ProjectSetting
{
    [XmlInclude(typeof(Override.OverrideBase))]
    [XmlInclude(typeof(Override.NameOverride))]
    [XmlInclude(typeof(Override.DescriptionOverride))]
    [XmlInclude(typeof(Override.FilterOverride))]
    [XmlInclude(typeof(Override.AlerterOverride))]
    [XmlInclude(typeof(TypeDefinitionBase))]
    [XmlInclude(typeof(BasicTypeDefinition))]
    [XmlInclude(typeof(StructureTypeDefinition))]
    [XmlInclude(typeof(StrongCustomizedTypeDefinition))]
    [XmlInclude(typeof(AlerterComponentPointer))]

    [Serializable]
    [DataContract]
    public class ProjectDefinition : IEntity, INotifyPropertyChanged
    {
        private string _description;
        private Guid _id;
        private string _name;
        private ObservableCollection<DeviceDefinition> _devices = new ObservableCollection<DeviceDefinition>();
        private ObservableCollection<TypeDefinitionBase> _types = new ObservableCollection<TypeDefinitionBase>();
        private ObservableCollection<VariableDefinition> _variables = new ObservableCollection<VariableDefinition>();
        private ObservableCollection<SequencerDefinition> _sequencers = new ObservableCollection<SequencerDefinition>();
        private ObservableCollection<ProcessorWaveDefinition> _processorWaves = new ObservableCollection<ProcessorWaveDefinition>();
        private ObservableCollection<OutputDefinition> _outputs = new ObservableCollection<OutputDefinition>();
        private ObservableCollection<CrawlerDefinition> _crawlers = new ObservableCollection<CrawlerDefinition>();
        private OptimizedDefinition _optimized = new OptimizedDefinition();
        private ObservableCollection<RuntimeFileSetting> _runtimeFileSettings = new ObservableCollection<RuntimeFileSetting>();
        private bool _simpleModeDevice;
        private bool _simpleModeType;
        private bool _simpleModeVariable;
        private bool _simpleModeSequencer;
        private bool _simpleModeProcessor;
        private LogLevel _logLevel;

        [DataMember]
        public string Description
        {
            get { return _description; }
            set
            {
                if (value == _description) return;
                _description = value;
                OnPropertyChanged();
            }
        }

        [DataMember]
        public Guid Id
        {
            get { return _id; }
            set
            {
                if (value.Equals(_id)) return;
                _id = value;
                OnPropertyChanged();
            }
        }

        [DataMember]
        public string Name
        {
            get { return _name; }
            set
            {
                if (value == _name) return;
                _name = value;
                OnPropertyChanged();
            }
        }

        [DataMember]
        public ObservableCollection<DeviceDefinition> Devices
        {
            get { return _devices; }
            set
            {
                if (Equals(value, _devices)) return;
                _devices = value;
                OnPropertyChanged();
            }
        }

        [DataMember]
        public ObservableCollection<TypeDefinitionBase> Types
        {
            get { return _types; }
            set
            {
                if (Equals(value, _types)) return;
                _types = value;
                OnPropertyChanged();
            }
        }

        [DataMember]
        public ObservableCollection<VariableDefinition> Variables
        {
            get { return _variables; }
            set
            {
                if (Equals(value, _variables)) return;
                _variables = value;
                OnPropertyChanged();
            }
        }

        [DataMember]
        public ObservableCollection<SequencerDefinition> Sequencers
        {
            get { return _sequencers; }
            set
            {
                if (Equals(value, _sequencers)) return;
                _sequencers = value;
                OnPropertyChanged();
            }
        }

        [DataMember]
        public ObservableCollection<ProcessorWaveDefinition> ProcessorWaves
        {
            get { return _processorWaves; }
            set
            {
                if (Equals(value, _processorWaves)) return;
                _processorWaves = value;
                OnPropertyChanged();
            }
        }

        [DataMember]
        public ObservableCollection<OutputDefinition> Outputs
        {
            get { return _outputs; }
            set
            {
                if (Equals(value, _outputs)) return;
                _outputs = value;
                OnPropertyChanged();
            }
        }

        [DataMember]
        public ObservableCollection<CrawlerDefinition> Crawlers
        {
            get { return _crawlers; }
            set
            {
                if (Equals(value, _crawlers)) return;
                _crawlers = value;
                OnPropertyChanged();
            }
        }

        [DataMember]
        public OptimizedDefinition Optimized
        {
            get { return _optimized; }
            set
            {
                if (Equals(value, _optimized)) return;
                _optimized = value;
                OnPropertyChanged();
            }
        }

        [DataMember]
        public bool SimpleModeDevice
        {
            get { return _simpleModeDevice; }
            set
            {
                if (value == _simpleModeDevice) return;
                _simpleModeDevice = value;
                OnPropertyChanged();
            }
        }

        [DataMember]
        public bool SimpleModeType
        {
            get { return _simpleModeType; }
            set
            {
                if (value == _simpleModeType) return;
                _simpleModeType = value;
                OnPropertyChanged();
            }
        }

        [DataMember]
        public bool SimpleModeVariable
        {
            get { return _simpleModeVariable; }
            set
            {
                if (value == _simpleModeVariable) return;
                _simpleModeVariable = value;
                OnPropertyChanged();
            }
        }

        [DataMember]
        public bool SimpleModeSequencer
        {
            get { return _simpleModeSequencer; }
            set
            {
                if (value == _simpleModeSequencer) return;
                _simpleModeSequencer = value;
                OnPropertyChanged();
            }
        }

        [DataMember]
        public bool SimpleModeProcessor
        {
            get { return _simpleModeProcessor; }
            set
            {
                if (value == _simpleModeProcessor) return;
                _simpleModeProcessor = value;
                OnPropertyChanged();
            }
        }

        [XmlIgnore]
        public TimeSpan TimePeriod
        {
            get { return TimeSpan.FromMilliseconds(TimePeriodMilliseconds); }
            set
            {
                long ms = (long)value.TotalMilliseconds;
                if (ms.Equals(TimePeriodMilliseconds)) return;
                TimePeriodMilliseconds = ms;
                OnPropertyChanged();
            }
        }

        [DataMember]
        public long TimePeriodMilliseconds { get; set; }


        [DataMember]
        public LogLevel LogLevel
        {
            get { return _logLevel; }
            set
            {
                if (value == _logLevel) return;
                _logLevel = value;
                OnPropertyChanged();
            }
        }

        [DataMember]
        public ObservableCollection<RuntimeFileSetting> RuntimeFileSettings
        {
            get { return _runtimeFileSettings; }
            set
            {
                if (value == _runtimeFileSettings) return;
                _runtimeFileSettings = value;
                OnPropertyChanged();
            }
        }

        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;

        //[NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}