using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTI.iMeter.ComponentStandard.UI
{
    public interface ICreateControlWithTypeSpecified
    {
        ICoeditorUIControl CreateControl(DataType selectedDataType);
        ICoeditorUIControl CreateControl(Guid selectedStrongCustomizedTypeTypeId);
    }
}
