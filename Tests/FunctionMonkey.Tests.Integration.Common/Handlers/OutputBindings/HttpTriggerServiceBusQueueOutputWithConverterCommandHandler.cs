using System.Threading.Tasks;
using AzureFromTheTrenches.Commanding.Abstractions;
using FunctionMonkey.Tests.Integration.Common.Commands.OutputBindings;
using FunctionMonkey.Tests.Integration.Common.Commands.TestInfrastructure;

namespace FunctionMonkey.Tests.Integration.Common.Handlers.OutputBindings
{
    public class HttpTriggerServiceBusQueueOutputWithConverterCommandHandler : ICommandHandler<HttpTriggerServiceBusQueueOutputWithConverterCommand, ServiceBusQueuedMarkerIdCommand>
    {
        public Task<ServiceBusQueuedMarkerIdCommand> ExecuteAsync(HttpTriggerServiceBusQueueOutputWithConverterCommand command, ServiceBusQueuedMarkerIdCommand previousResult)
        {
            return ServiceBusQueuedMarkerIdCommand.Success(command.MarkerId, command.Value);
        }
    }
}