using System;
using System.Threading.Tasks;

using Microsoft.Extensions.Logging;

using Instances = R5T.F0059.Instances;


public static class ILoggerExtensions
{
	/// <inheritdoc cref="R5T.F0059.ILoggingOperator.InLogContext(ILogger, string, string, Action)"/>
	public static void InLogContext(this ILogger logger,
		string initialInformationMessage,
		string finalDebugMessage,
		Action action)
	{
		Instances.LoggingOperator.InLogContext(
			logger,
			initialInformationMessage,
			finalDebugMessage,
			action);
	}

	/// <inheritdoc cref="R5T.F0059.ILoggingOperator.InLogContext(ILogger, string, string, Func{Task})"/>
	public static Task InLogContext(this ILogger logger,
		string initialInformationMessage,
		string finalDebugMessage,
		Func<Task> action)
	{
		return Instances.LoggingOperator.InLogContext(
			logger,
			initialInformationMessage,
			finalDebugMessage,
			action);
	}

	/// <inheritdoc cref="R5T.F0059.ILoggingOperator.InLogContext{TOutput}(ILogger, string, string, Func{TOutput})"/>
	public static TOutput InLogContext<TOutput>(this ILogger logger,
		string initialInformationMessage,
		string finalDebugMessage,
		Func<TOutput> function)
	{
		var output = Instances.LoggingOperator.InLogContext(
			logger,
			initialInformationMessage,
			finalDebugMessage,
			function);

		return output;
	}

	/// <inheritdoc cref="R5T.F0059.ILoggingOperator.InLogContext{TOutput}(ILogger, string, string, Func{Task{TOutput}})"/>
	public static Task<TOutput> InLogContext<TOutput>(this ILogger logger,
		string initialInformationMessage,
		string finalDebugMessage,
		Func<Task<TOutput>> function)
	{
		return Instances.LoggingOperator.InLogContext(
			logger,
			initialInformationMessage,
			finalDebugMessage,
			function);
	}

	/// <inheritdoc cref="R5T.F0059.ILoggingOperator.InSuccessFailureLogContext(ILogger, string, string, LogLevel, string, Func{bool})"/>
	public static void InSuccessFailureLogContext(this ILogger logger,
		string initialInformationMessage,
		string finalSuccessDebugMessage,
		LogLevel failureLogLevel,
		string finalFailureMessage,
		Func<bool> action)
	{
		Instances.LoggingOperator.InSuccessFailureLogContext(
			logger,
			initialInformationMessage,
			finalSuccessDebugMessage,
			failureLogLevel,
			finalFailureMessage,
			action);
	}

	/// <inheritdoc cref="R5T.F0059.ILoggingOperator.InSuccessFailureLogContext_Error(ILogger, string, string, string, Func{bool})"/>
	public static void InSuccessFailureLogContext_Error(this ILogger logger,
		string initialInformationMessage,
		string finalSuccessDebugMessage,
		string finalFailureErrorMessage,
		Func<bool> action)
	{
		Instances.LoggingOperator.InSuccessFailureLogContext_Error(
			logger,
			initialInformationMessage,
			finalSuccessDebugMessage,
			finalFailureErrorMessage,
			action);
	}

	/// <inheritdoc cref="R5T.F0059.ILoggingOperator.InSuccessFailureLogContext_Error(ILogger, string, string, string, Func{Task{bool}})"/>
	public static Task InSuccessFailureLogContext_Error(this ILogger logger,
		string initialInformationMessage,
		string finalSuccessDebugMessage,
		string finalFailureErrorMessage,
		Func<Task<bool>> action)
	{
		return Instances.LoggingOperator.InSuccessFailureLogContext_Error(
			logger,
			initialInformationMessage,
			finalSuccessDebugMessage,
			finalFailureErrorMessage,
			action);
	}

	/// <inheritdoc cref="R5T.F0059.ILoggingOperator.InSuccessFailureLogContext_Information(ILogger, string, string, string, Func{bool})"/>
	public static void InSuccessFailureLogContext_Information(this ILogger logger,
		string initialInformationMessage,
		string finalSuccessDebugMessage,
		string finalFailureInformationMessage,
		Func<bool> action)
	{
		Instances.LoggingOperator.InSuccessFailureLogContext_Information(
			logger,
			initialInformationMessage,
			finalSuccessDebugMessage,
			finalFailureInformationMessage,
			action);
	}

	/// <inheritdoc cref="R5T.F0059.ILoggingOperator.InSuccessFailureLogContext(ILogger, string, string, string, Func{bool})"/>
	public static void InSuccessFailureLogContext(this ILogger logger,
		string initialInformationMessage,
		string finalSuccessDebugMessage,
		string finalFailureInformationMessage,
		Func<bool> action)
	{
		Instances.LoggingOperator.InSuccessFailureLogContext(
			logger,
			initialInformationMessage,
			finalSuccessDebugMessage,
			finalFailureInformationMessage,
			action);
	}

	/// <inheritdoc cref="R5T.F0059.ILoggingOperator.InSuccessFailureLogContext(ILogger, string, string, string, Func{Task{bool}})"/>
	public static Task InSuccessFailureLogContext(this ILogger logger,
		string initialInformationMessage,
		string finalSuccessDebugMessage,
		string finalFailureInformationMessage,
		Func<Task<bool>> action)
	{
		return Instances.LoggingOperator.InSuccessFailureLogContext(
			logger,
			initialInformationMessage,
			finalSuccessDebugMessage,
			finalFailureInformationMessage,
			action);
	}
}
