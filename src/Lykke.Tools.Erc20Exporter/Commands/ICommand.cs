using System.Threading.Tasks;

namespace Lykke.Tools.Erc20Exporter.Commands
{
    public interface ICommand
    {
        Task<int> ExecuteAsync();
    }
}
