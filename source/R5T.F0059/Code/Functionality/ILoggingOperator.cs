using System;
using System.Threading.Tasks;

using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

using R5T.T0132;


namespace R5T.F0059
{
	[FunctionalityMarker]
	public partial interface ILoggingOperator : IFunctionalityMarker
	{
		/// <summary>
		/// Returns the <see cref="NullLogger.Instance"/> singleton.
		/// </summary>
		public ILogger Get_NullLogger()
        {
			var logger = NullLogger.Instance;
			return logger;
		}

		/// <inheritdoc cref="Documentation.ActionInLogContext"/>
		public void InLogContext(
			ILogger logger,
			string initialInformationMessage,
			string finalDebugMessage,
			Action action)
        {
			logger.LogInformation(initialInformationMessage);

			action();

			logger.LogDebug(finalDebugMessage);
        }

		/// <inheritdoc cref="Documentation.ActionInLogContext"/>
		public async Task InLogContext(
			ILogger logger,
			string initialInformationMessage,
			string finalDebugMessage,
			Func<Task> action)
		{
			logger.LogInformation(initialInformationMessage);

			await action();

			logger.LogDebug(finalDebugMessage);
		}

		/// <inheritdoc cref="Documentation.FunctionInLogContext"/>
		public TOutput InLogContext<TOutput>(
			ILogger logger,
			string initialInformationMessage,
			string finalDebugMessage,
			Func<TOutput> function)
		{
			logger.LogInformation(initialInformationMessage);

			var output = function();

			logger.LogDebug(finalDebugMessage);

			return output;
		}

		/// <inheritdoc cref="Documentation.FunctionInLogContext"/>
		public async Task<TOutput> InLogContext<TOutput>(
			ILogger logger,
			string initialInformationMessage,
			string finalDebugMessage,
			Func<Task<TOutput>> function)
		{
			logger.LogInformation(initialInformationMessage);

			var output = await function();

			logger.LogDebug(finalDebugMessage);

			return output;
		}

		/// <inheritdoc cref="Documentation.ActionInSuccessFailureLogContext"/>
		public void InSuccessFailureLogContext(
			ILogger logger,
			string initialInformationMessage,
			string finalSuccessDebugMessage,
			LogLevel failureLogLevel,
			string finalFailureMessage,
			Func<bool> action)
		{
			logger.LogInformation(initialInformationMessage);

			var success = action();

			if(success)
            {
				logger.LogDebug(finalSuccessDebugMessage);
            }
            else
            {
				logger.Log(failureLogLevel, finalFailureMessage);
            }
		}

		/// <inheritdoc cref="Documentation.ActionInSuccessFailureLogContext"/>
		public async Task InSuccessFailureLogContext(
			ILogger logger,
			string initialInformationMessage,
			string finalSuccessDebugMessage,
			LogLevel failureLogLevel,
			string finalFailureMessage,
			Func<Task<bool>> action)
		{
			logger.LogInformation(initialInformationMessage);

			var success = await action();

			if (success)
			{
				logger.LogDebug(finalSuccessDebugMessage);
			}
			else
			{
				logger.Log(failureLogLevel, finalFailureMessage);
			}
		}

		/// <inheritdoc cref="InSuccessFailureLogContext(ILogger, string, string, LogLevel, string, Func{bool})"/>
		public void InSuccessFailureLogContext_Error(
			ILogger logger,
			string initialInformationMessage,
			string finalSuccessDebugMessage,
			string finalFailureErrorMessage,
			Func<bool> action)
		{
			this.InSuccessFailureLogContext(
				logger,
				initialInformationMessage,
				finalSuccessDebugMessage,
				LogLevel.Error,
				finalFailureErrorMessage,
				action);
		}

		/// <inheritdoc cref="InSuccessFailureLogContext(ILogger, string, string, LogLevel, string, Func{Task{bool}})"/>
		public Task InSuccessFailureLogContext_Error(
			ILogger logger,
			string initialInformationMessage,
			string finalSuccessDebugMessage,
			string finalFailureErrorMessage,
			Func<Task<bool>> action)
		{
			return this.InSuccessFailureLogContext(
				logger,
				initialInformationMessage,
				finalSuccessDebugMessage,
				LogLevel.Error,
				finalFailureErrorMessage,
				action);
		}

		/// <inheritdoc cref="InSuccessFailureLogContext(ILogger, string, string, LogLevel, string, Func{bool})"/>
		public void InSuccessFailureLogContext_Information(
			ILogger logger,
			string initialInformationMessage,
			string finalSuccessDebugMessage,
			string finalFailureInformationMessage,
			Func<bool> action)
		{
			this.InSuccessFailureLogContext(
				logger,
				initialInformationMessage,
				finalSuccessDebugMessage,
				LogLevel.Information,
				finalFailureInformationMessage,
				action);
		}

		/// <inheritdoc cref="InSuccessFailureLogContext(ILogger, string, string, LogLevel, string, Func{bool})"/>
		public Task InSuccessFailureLogContext_Information(
			ILogger logger,
			string initialInformationMessage,
			string finalSuccessDebugMessage,
			string finalFailureInformationMessage,
			Func<Task<bool>> action)
		{
			return this.InSuccessFailureLogContext(
				logger,
				initialInformationMessage,
				finalSuccessDebugMessage,
				LogLevel.Information,
				finalFailureInformationMessage,
				action);
		}

		/// <summary>
		/// <para>Chooses <see cref="InSuccessFailureLogContext_Information(ILogger, string, string, string, Func{bool})"/> as the default.</para>
		/// <inheritdoc cref="InSuccessFailureLogContext_Information(ILogger, string, string, string, Func{bool})"/>
		/// </summary>
		public void InSuccessFailureLogContext(
			ILogger logger,
			string initialInformationMessage,
			string finalSuccessDebugMessage,
			string finalFailureInformationMessage,
			Func<bool> action)
		{
			this.InSuccessFailureLogContext_Information(
				logger,
				initialInformationMessage,
				finalSuccessDebugMessage,
				finalFailureInformationMessage,
				action);
		}

		/// <summary>
		/// <para>Chooses <see cref="InSuccessFailureLogContext_Information(ILogger, string, string, string, Func{bool})"/> as the default.</para>
		/// <inheritdoc cref="InSuccessFailureLogContext_Information(ILogger, string, string, string, Func{bool})"/>
		/// </summary>
		public Task InSuccessFailureLogContext(
			ILogger logger,
			string initialInformationMessage,
			string finalSuccessDebugMessage,
			string finalFailureInformationMessage,
			Func<Task<bool>> action)
		{
			return this.InSuccessFailureLogContext_Information(
				logger,
				initialInformationMessage,
				finalSuccessDebugMessage,
				finalFailureInformationMessage,
				action);
		}
	}
}