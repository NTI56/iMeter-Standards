using System;
using System.Collections.Generic;
using NTI.iMeter.ComponentStandard.Runtime;
using NTI.iMeter.ComponentStandard.UI;

namespace NTI.iMeter.ComponentStandard
{
	/// <summary>
	/// Interface of Component Libaray.
	/// </summary>
	public interface IComponentLibrary
	{
		/// <summary>
		/// Library description
		/// </summary>
		string Description { get; }
		/// <summary>
		/// Source of this assembly.
		/// </summary>
		ExternalComponentSourceType ExternalComponentSourceType { get; }
		/// <summary>
		/// Library id. Should be unique and constant for each assembly.
		/// </summary>
		Guid Id { get; }
		/// <summary>
		/// Library name
		/// </summary>
		string Name { get; }
        /// <summary>
        /// Get one runtime component factory
        /// </summary>
        /// <param name="componentId">Component id of runtime component factory</param>
        /// <returns>runtime component factory</returns>
        RuntimeComponentFactoryBase GetRuntimeComponentFactory(Guid componentId);

        /// <summary>
        /// Get all runtime component factories
        /// </summary>
        /// <returns>runtime component factories</returns>
        IReadOnlyDictionary<Guid, UIComponentFactoryBase> GetUIComponentFactories();
	}
}