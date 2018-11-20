using System;

namespace Lykke.Tools.Erc20Exporter.CommandsRegistration
{
    [AttributeUsage(AttributeTargets.Class)]
    public class CommandRegistrationAttribute : Attribute
    {
        public CommandRegistrationAttribute(string commandName)
        {
            CommandName = commandName;
        }

        public string CommandName { get; }
    }
}
