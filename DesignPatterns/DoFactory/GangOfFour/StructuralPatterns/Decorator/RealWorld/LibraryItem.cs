using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DoFactory.GangOfFour.StructuralPatterns.Decorator.RealWorld
{
    public abstract class LibraryItem
    {
        protected int _numCopies;

        public int NumCopies
        {
            get { return _numCopies; }
            set { _numCopies = value; }
        }

        public abstract void Display();
    }

    public class Book : LibraryItem
    {
        private string _author;
        private string _title;

        public Book(string author, string title, int numOfCopies)
        {
            _author = author;
            _title = title;
            _numCopies = numOfCopies;
        }

        public override void Display()
        {
            Console.WriteLine("\nBook ------ ");
            Console.WriteLine(" Author: {0}", _author);
            Console.WriteLine(" Title: {0}", _title);
            Console.WriteLine(" # Copies: {0}", NumCopies);
        }
    }

    public class Video : LibraryItem
    {
        private string _director;
        private string _title;
        private int _playTime;

        public Video(string director, string title, int playTime, int numOfCopies)
        {
            _director = director;
            _title = title;
            _playTime = playTime;
            _numCopies = numOfCopies;
        }

        public override void Display()
        {
            Console.WriteLine("\nVideo ----- ");
            Console.WriteLine(" Director: {0}", _director);
            Console.WriteLine(" Title: {0}", _title);
            Console.WriteLine(" # Copies: {0}", NumCopies);
            Console.WriteLine(" Playtime: {0}\n", _playTime);
        }
    }

    public abstract class Decorator : LibraryItem
    {
        protected LibraryItem _libraryItem;

        public Decorator(LibraryItem libraryItem)
        {
            _libraryItem = libraryItem;
        }

        public override void Display()
        {
            _libraryItem.Display();
        }
    }

    public class Borrowable : Decorator
    {
        protected List<string> _borrowers = new List<string>();
        
        public Borrowable(LibraryItem libraryItem) : base(libraryItem)
        {
        }

        public void BorrowItem(string name)
        {
            _borrowers.Add(name);
            _libraryItem.NumCopies++;
        }

        public override void Display()
        {
            base.Display();

            foreach (string borrower in _borrowers)
                Console.WriteLine(" borrower: " + borrower);
        }
    }
}
