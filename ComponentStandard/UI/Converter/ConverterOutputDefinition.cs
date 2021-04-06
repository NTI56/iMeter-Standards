using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTI.iMeter.ComponentStandard.UI.Converter
{
    /// <summary>
    /// Converter Output
    /// </summary>
    public class ConverterOutputDefinition
    {
        /// <summary>
        /// Output id. Should be unique and constant for each output.
        /// </summary>
        public Guid Id { get; }
        /// <summary>
        /// Output name
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Output description
        /// </summary>
        public string Description { get; }
        /// <summary>
        /// Data type
        /// </summary>
        public DataType DataType { get; }
        /// <summary>
        /// Strong customized type id
        /// </summary>
        public Guid? StrongCustomizedTypeTypeId { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id">Output id</param>
        /// <param name="name">Output name</param>
        /// <param name="description">Output description</param>
        /// <param name="dataType">Data type</param>
        /// <param name="strongCustomizedTypeTypeId">Strong customized type id</param>
        public ConverterOutputDefinition(Guid id, string name, string description, DataType dataType, Guid? strongCustomizedTypeTypeId)
        {
            Id = id;
            Name = name;
            Description = description;
            DataType = dataType;
            StrongCustomizedTypeTypeId = strongCustomizedTypeTypeId;
        }
    }
}
