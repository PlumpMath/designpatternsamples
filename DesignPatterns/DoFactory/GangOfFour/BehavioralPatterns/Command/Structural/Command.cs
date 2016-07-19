using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.DoFactory.GangOfFour.BehavioralPatterns.Command.RealWorld;

namespace DesignPatterns.DoFactory.GangOfFour.BehavioralPatterns.Command.Structural
{
    abstract class Command
    {
        protected Receiver receiver;

        public Command(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public abstract void Execute();
    }

    class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver receiver) : base(receiver)
        {
            this.receiver = receiver;
        }

        public override void Execute()
        {
            receiver.Action();
        }
    }

    internal class Receiver
    {
        public void Action()
        {
            Console.WriteLine("Called Receiver.Action()");
        }

    }

    class Invoker
    {
        private Command _command;

        public void SetCommand(Command command)
        {
            this._command = command;
        }

        public void ExecuteCommand()
        {
            _command.Execute();
        }

    }
}
