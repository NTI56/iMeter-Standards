﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NTI.iMeter.ProjectSetting.Optimized
{
    [Serializable]
    [DataContract]
    public class AlerterPointer : IdWithPointer
    {
        [DataMember]
        public string Text { get; set; }
    }
}
