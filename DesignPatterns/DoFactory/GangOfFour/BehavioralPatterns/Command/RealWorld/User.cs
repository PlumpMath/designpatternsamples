﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.DoFactory.GangOfFour.BehavioralPatterns.Command.Structural;

namespace DesignPatterns.DoFactory.GangOfFour.BehavioralPatterns.Command.RealWorld
{
    abstract class Command
    {
        public abstract void Execute();
        public abstract void UnExecute();

        public static implicit operator Command(ConcreteCommand v)
        {
            throw new NotImplementedException();
        }
    }

    class CalculatorCommand : Command
    {
        private char _operator;
        private int _operand;
        private Calculator _calculator;

        public CalculatorCommand(Calculator calculator, char @operator, int operand)
        {
            _calculator = calculator;
            _operator = @operator;
            _operand = operand;

        }

        public char Operator
        {
            set
            {
                _operator = value;
            }
        }

        public int Operand
        {

            set
            {
                _operand = value;
            }
        }

        public override void Execute()
        {
            _calculator.Operation(_operator, _operand);
        }

        public override void UnExecute()
        {
            _calculator.Operation(_operator, _operand);
        }
    }

    internal class Calculator
    {
        private int _curr = 0;
        public void Operation(char @operator, int operand)
        {
            switch (@operator)
            {
                case '+': _curr += operand; break;
                case '-': _curr -= operand; break;
                case '*': _curr *= operand; break;
                case '/': _curr /= operand; break;
            }
            Console.WriteLine("Curremt value = {0,3} (following {1} {2})", _curr, @operator, operand);
        }
    }

    class User
    {
        private Calculator _calculator = new Calculator();
        private List<Command> _commands = new List<Command>();
        private int _current = 0;

        public void Redo(int levels)
        {
            Console.WriteLine("\n---- Redo {0} levels ", levels);
            for (int i = 0; i < levels; i++)
            {
                if (_current <_commands.Count - 1)
                {
                    Command command = _commands[_current++];
                    command.Execute();
                }
            }
        }

        public void Undo(int levels)
        {
            Console.WriteLine("\n---- Undo {0} levels ", levels);
            for (int i = 0; i < levels; i++)
            {
                if(_current > 0)
                {
                    Command command = _commands[--_current] as Command;
                    command.UnExecute();
                }
            }
        }

        public void Compute(char @operator, int operand)
        {
            Command command = new CalculatorCommand(_calculator, @operator, operand);
            _commands.Add(command);
            _current++;
        }
    }
}
