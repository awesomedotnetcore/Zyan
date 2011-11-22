﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zyan.Communication.Delegates
{
	/// <summary>
	/// Interface for filtered event handlers.
	/// </summary>
	public interface IFilteredEventHandler
	{
		/// <summary>
		/// Gets the event handler.
		/// </summary>
		Delegate EventHandler { get; }

		/// <summary>
		/// Gets the event filter.
		/// </summary>
		IEventFilter EventFilter { get; }
	}
}
