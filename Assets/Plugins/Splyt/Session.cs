using System.Collections;
using System.Collections.Generic;

namespace Splyt.Plugins
{
	/// <summary>
	/// A light wrapper around Splyt.Transaction to provide some built-in characteristics for Session transactions
	/// </summary>
	public class SessionTransaction : TransactionBase<SessionTransaction>
	{
		public const double DEFAULT_TIMEOUT = 10.0 * 86400.0; // 10 days

		internal SessionTransaction() : base("Session", null) {}
		public new void begin(double timeout = DEFAULT_TIMEOUT, Transaction.TimeoutMode mode = Transaction.TimeoutMode.Any) { base.begin(timeout, mode); }
	}

	/// <summary>
	/// This Splyt plugin provides a simple interface for instrumenting purchase flows in an application.
	/// </summary>
	public class Session
	{
		/// <summary>
		/// Factory method for invoking SplytPlugins.SessionTransaction methods
		/// </summary>
		public static SessionTransaction Transaction()
		{
			return new SessionTransaction();
		}
	}
}

