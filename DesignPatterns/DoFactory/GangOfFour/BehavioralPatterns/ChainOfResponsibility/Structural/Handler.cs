using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DoFactory.GangOfFour.BehavioralPatterns.ChainOfResponsibility.Structural
{
    abstract class Handler
    {
        protected Handler _successor;

        public void SetSuccessor(Handler successor)
        {
            _successor = successor;
        }

        public abstract void HandleRequest(int request);
    }

    class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 0 && request < 10)
                Console.WriteLine("{0} handled request {1}",
                    GetType().Name, request);
            else if (_successor != null)
                _successor.HandleRequest(request);
        }
    }

    class ConcreteHandler2 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 10 && request < 20)
                Console.WriteLine("{0} handled request {1}",
                    GetType().Name, request);
            else if (_successor != null)
                _successor.HandleRequest(request);
        }
    }

    class ConcreteHandler3 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 20 && request < 30)
                Console.WriteLine("{0} handled request {1}",
                    GetType().Name, request);
            else if (_successor != null)
                _successor.HandleRequest(request);
        }
    }
}
