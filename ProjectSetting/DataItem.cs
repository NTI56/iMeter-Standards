using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;


namespace NTI.iMeter.ProjectSetting
{
	/// <summary>
	/// Provide base feature for all data items.
	/// </summary>
	[DataContract]
	public abstract class DataItem : INotifyPropertyChanging, INotifyPropertyChanged, INotifyDataErrorInfo, IDataErrorInfo
	{

		/// <summary>
		/// Get the collection used to store entity errors.
		/// </summary>
		[XmlIgnore]
		[IgnoreDataMember]
		protected IDictionary<string, ICollection<string>> Errors { get; private set; } =
			new Dictionary<string, ICollection<string>>();

		bool INotifyDataErrorInfo.HasErrors => Errors.Any(i => i.Value.Count != 0);
		string IDataErrorInfo.Error => Errors[string.Empty].FirstOrDefault();

		/// <summary>
		/// Add an error for this object.
		/// </summary>
		/// <param name="propertyName">The name of the property which error occurs, using <see cref="string.Empty"/> or <c>null</c> to indicate the new error is an entity-level error.</param>
		/// <param name="error">The error message.</param>
		protected void AddError(string propertyName, string error)
		{
			// convert null to empty string
			propertyName = propertyName ?? string.Empty;

			// If dictionary not exists, create a new one
			var dic = Errors[propertyName] ?? (Errors[propertyName] = new Collection<string>());

			// Add error
			dic.Add(error);
		}

		/// <summary>
		/// Get all errors of a specified property.
		/// </summary>
		/// <param name="propertyName">The name of the property. Use <see cref="string.Empty"/> or <c>null</c> for entity-level errors.</param>
		/// <param name="errors">The error dictionary which can be used to add or remove speicified error key and message.</param>
		protected virtual void GetErrors(string propertyName, IDictionary<string, string> errors)
		{
		}

		/// <summary>
		/// Clear all entity-level or specified property related errors.
		/// </summary>
		/// <param name="propertyName">The name of the property whose errors should be cleaned, using <see cref="string.Empty"/> or <c>null</c> to incidate all entity-level errors</param>
		protected void ClearErrors(string propertyName)
		{
			// convert null to empty string
			propertyName = propertyName ?? string.Empty;

			// Remove errors
			Errors.Remove(propertyName);

		}

		/// <summary>
		/// Clear all errors.
		/// </summary>
		protected void ClearErrors()
		{
			Errors.Clear();
		}

		public virtual event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

		/// <summary>
		/// Raise the <see cref="INotifyDataErrorInfo.ErrorsChanged"/> event.
		/// </summary>
		/// <param name="propertyName">The property name.</param>
		protected virtual void OnErrorsChanged(string propertyName)
		{
			ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
		}

		IEnumerable INotifyDataErrorInfo.GetErrors(string propertyName) => Errors[propertyName];
		string IDataErrorInfo.this[string columnName] => Errors[columnName ?? string.Empty].FirstOrDefault();
		public virtual event PropertyChangingEventHandler PropertyChanging;
		public virtual event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
		/// Raise the <see cref="INotifyDataErrorInfo.ErrorsChanged"/> event.
		/// </summary>
		/// <param name="propertyName">The property name.</param>
		//[NotifyPropertyChangedInvocator]
		protected virtual void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		/// <summary>
		/// Raise the <see cref="INotifyDataErrorInfo.ErrorsChanged"/> event.
		/// </summary>
		/// <param name="propertyName">The property name.</param>
		protected virtual void OnPropertyChanging(string propertyName)
		{
			PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(propertyName));
		}

		/// <summary>
		/// Core method called when property is changing.
		/// </summary>
		/// <param name="propertyName">The name of the property.</param>
		protected virtual void BeforePropertySet([CallerMemberName] string propertyName = null)
		{
			OnPropertyChanging(propertyName);
		}

		/// <summary>
		/// Core method called when property is changed.
		/// </summary>
		/// <param name="propertyName">The name of the property.</param>
		protected virtual void AfterPropertySet([CallerMemberName] string propertyName = null)
		{
			OnPropertyChanged(propertyName);
			ResetErrors(propertyName);

			// Reset entity-level errors
			ResetErrors(string.Empty);
		}

		protected virtual void ResetErrors(string propertyName)
		{
			var errors = new Dictionary<string, string>();
			GetErrors(propertyName, errors);
			Errors[propertyName] = new Collection<string>(errors.Values.ToArray());

			OnErrorsChanged(propertyName);
		}

		[OnDeserializing]
		private void OnDeserializing(StreamingContext context)
		{
			Errors = new Dictionary<string, ICollection<string>>();
		}
	}
}