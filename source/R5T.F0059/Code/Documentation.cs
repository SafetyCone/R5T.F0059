using System;

using Microsoft.Extensions.Logging;


namespace R5T.F0059
{
	/// <summary>
	/// Logging functionality and extensions (LoggingOperator).
	/// </summary>
	public static class Documentation
	{
		/// <summary>
		/// <action>Performs an action in a log context.</action>
		/// <para><inheritdoc cref="LogContext" path="/summary"/></para>
		/// </summary>
		public static readonly object ActionInLogContext;

		/// <summary>
		/// <action>Performs an action in a log context.</action>
		/// <para><inheritdoc cref="SuccessFailureLogContext" path="/summary"/></para>
		/// </summary>
		public static readonly object ActionInSuccessFailureLogContext;

		/// <summary>
		/// <function>Executes a functiona in a log context.</function>
		/// <para><inheritdoc cref="LogContext" path="/summary"/></para>
		/// </summary>
		public static readonly object FunctionInLogContext;

		/// <summary>
		/// A log context is a pair of log messages bracketing a set of code operations (in the form of an initial "Doing..." message, then a final "Done." message).
		/// <initial-has-higher-level>The initial log message has a higher level than the final log message, because it's important to know what was being done when it failed (so you don't have to guess what was next starting from what already finished).</initial-has-higher-level>
		/// The initial log message has the <see cref="LogLevel.Information"/> level, and the final message has the <see cref="LogLevel.Debug"/> level.
		/// </summary>
		public static readonly object LogContext;

		/// <summary>
		/// A success/failure log context is a triple of log messages bracketing a set of code operations (in the form of an initial "Doing..." message, then one of two final messages, either a "Done (success)." message or a "Done (failed)." message.)
		/// <inheritdoc cref="LogContext" path="/summary/initial-has-higher-level"/>
		/// The initial log message has the <see cref="LogLevel.Information"/> level, and the final message has the <see cref="LogLevel.Debug"/> level if it's a success, or the <see cref="LogLevel.Error"/> level or a provided <see cref="LogLevel"/> if it's a failure.
		/// </summary>
		public static readonly object SuccessFailureLogContext;
	}
}