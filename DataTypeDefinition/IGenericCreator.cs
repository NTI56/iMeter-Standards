using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTI.iMeter
{
    /// <summary>
    /// Used to create any instance based on the data type specified.
    /// </summary>
    public interface IGenericCreator
    {
        object CreateGenericInstance<TDataType>();
    }
}
