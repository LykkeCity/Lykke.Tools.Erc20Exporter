using Microsoft.Extensions.CommandLineUtils;

namespace Lykke.Tools.Erc20Exporter.CommandsRegistration
{
    public interface ICommandRegistration
    {
        void StartExecution(CommandLineApplication lineApplication);
    }
}
