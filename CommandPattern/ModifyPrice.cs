using System.Collections.Generic;

namespace CommandPattern
{
    internal class ModifyPrice
    {
        private readonly ICollection<ICommand> commands;
        private ICommand _command;

        public ModifyPrice()
        {
            this.commands = new List<ICommand>();
        }

        public void SetCommand(ICommand command) => this._command = command;

        public void Invoke()
        {
            this.commands.Add(this._command);
            this._command.ExecuteAction();
        }
    }
}