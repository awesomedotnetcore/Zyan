﻿using System;
using System.Collections.Generic;
using Zyan.Communication.Delegates;

namespace Zyan.Communication
{
	/// <summary>
	/// Arguments for the InvokeCanceled event.
	/// </summary>
	public class InvokeCanceledEventArgs : EventArgs
	{
		/// <summary>
		/// Gets or sets a unique ID for call tracking.
		/// </summary>
		public Guid TrackingID { get; set; }

		/// <summary>
		/// Gets or sets the exception in case of cancellation.
		/// </summary>
		public Exception CancelException { get; set; }

		/// <summary>
		/// Gets or sets the interface name of the remote component.
		/// </summary>
		public string InterfaceName { get; set; }

		/// <summary>
		/// Gets or sets the correlation set for wiring remote delegates.
		/// </summary>
		public List<DelegateCorrelationInfo> DelegateCorrelationSet { get; set; }

		/// <summary>
		/// Gets or sets the name of the remote method to be invoked.
		/// </summary>
		public string MethodName { get; set; }

		/// <summary>
		/// Gets or sets method arguments (parameters).
		/// </summary>
		public object[] Arguments { get; set; }

		/// <summary>
		/// Returns a string representation of this event arguments.
		/// </summary>
		/// <returns>String representation of data</returns>
		public override string ToString()
		{
			var argsAsString = new List<string>();

			if (Arguments != null)
			{
				foreach (object arg in Arguments)
				{
					if (arg == null)
						argsAsString.Add("null");
					else
						argsAsString.Add(arg.ToString());
				}
			}

			string argChain = string.Join(", ", argsAsString.ToArray());

			return string.Format("{0}.{1}({2})", InterfaceName, MethodName, argChain);
		}
	}
}
