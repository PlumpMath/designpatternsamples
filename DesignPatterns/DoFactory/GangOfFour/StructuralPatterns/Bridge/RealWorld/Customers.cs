using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DoFactory.GangOfFour.StructuralPatterns.Bridge.RealWorld
{
    public class CustomersBase
    {
        private DataObject _dataObject;
        protected string _group;


        public CustomersBase(string group)
        {
            this._group = group;
        }

        public DataObject DataObject
        {
            get
            {
                return _dataObject;
            }

            set
            {
                _dataObject = value;
            }
        }

        public virtual void Next()
        {
            _dataObject.NextRecord();
        }

        public virtual void Prior()
        {
            _dataObject.PriorRecord();
        }

        public virtual void Add(string customer)
        {
            _dataObject.AddRecord(customer);
        }

        public virtual void Delete(string customer)
        {
            _dataObject.DeleteRecord(customer);
        }

        public virtual void Show()
        {
            _dataObject.ShowRecord();
        }

        public virtual void ShowAll()
        {
            _dataObject.ShowAllRecords();
        }
    }

    public class Customers : CustomersBase
    {
        public Customers(string group) : base(group)
        {
        }

        public override void ShowAll()
        {
            Console.WriteLine();
            Console.WriteLine("------------------------");
            base.ShowAll();
            Console.WriteLine("------------------------");
        }
    }

    public abstract class DataObject
    {
        public abstract void NextRecord();
        public abstract void PriorRecord();
        public abstract void ShowAllRecords();
        public abstract void ShowRecord();
        public abstract void AddRecord(string customer);
        public abstract void DeleteRecord(string customer);
    }

    public class CustomersData : DataObject
    {
        public List<string> _customers = new List<string>();
        private int _current = 0;

        public CustomersData()
        {
            _customers.Add("Jim Jones");
            _customers.Add("Samual Jackson");
            _customers.Add("Allen Good");
            _customers.Add("Ann Stills");
            _customers.Add("Lisa Giolani");
        }

        public override void NextRecord()
        {
            if (_current <= _customers.Count - 1)
                _current++;
        }

        public override void PriorRecord()
        {
            if (_current > 0)
                _current--;
        }

        public override void AddRecord(string customer)
        {
            _customers.Add(customer);
        }

        public override void DeleteRecord(string customer)
        {
            _customers.Remove(customer);
        }


        public override void ShowRecord()
        {
            Console.WriteLine(_customers[_current]);
        }


        public override void ShowAllRecords()
        {
            foreach (string customer in _customers)
                Console.WriteLine(" " + customer);
        }
    }
}
