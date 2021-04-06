using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTI.iMeter.ComponentStandard.Runtime;
using NTI.iMeter.ComponentStandard.UI;

namespace NTI.iMeter.ComponentStandard
{
	/// <summary>
	/// Component Library. Each assembly should have one class inherited from this class.
	/// </summary>
	public abstract class ComponentLibrary : IComponentLibrary
	{
		/// <summary>
		/// Library id. Should be unique and constant for each assembly.
		/// </summary>
		public abstract Guid Id { get; }

		/// <summary>
		/// Library name
		/// </summary>
		public abstract string Name { get; }
		/// <summary>
		/// Library description
		/// </summary>
		public abstract string Description { get; }


		/// <summary>
		/// Get all UI component factories
		/// </summary>
		/// <returns>UI component factories</returns>
		public abstract IReadOnlyDictionary<Guid, UIComponentFactoryBase> GetUIComponentFactories();

		/// <summary>
		/// Get one runtime component factory
		/// </summary>
		/// <param name="componentId">Component id of runtime component factory</param>
		/// <returns>runtime component factory</returns>
		public abstract RuntimeComponentFactoryBase GetRuntimeComponentFactory(Guid componentId);

		/// <summary>
		/// Source of this assembly.
		/// </summary>
		public abstract ExternalComponentSourceType ExternalComponentSourceType { get; }
	}
}
