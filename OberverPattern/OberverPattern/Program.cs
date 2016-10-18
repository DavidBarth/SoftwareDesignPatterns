/* GoF Observer Pattern - Behavioural pattern
 * Stuctural code for demonstrating the Observer pattern,
 * in wich registered objects are notified of and updated with a state change.
 * 
 * One-to-many dependecny.
 * 
 * Real world application: registered investors get notified when stock changes value.
 * 
 * http://www.dofactory.com/net/observer-design-pattern
 * 
 * */

using System;
using System.Collections.Generic;

namespace OberverPattern
{
	class MainClass
	{

		//Entry point
		public static void Main(string[] args)
		{
			//configure observer pattern
			ConcreteSubject subject = new ConcreteSubject();

			subject.Attach(new ConcreteObserver(subject, "X"));
			subject.Attach(new ConcreteObserver(subject, "Y"));
			subject.Attach(new ConcreteObserver(subject, "Z"));

			subject.SubjectState = "New state";
			subject.Notify();


		}

	}


	/// <summary>
	/// Subject abstract class
	/// </summary>
	abstract class Subject
	{
		private List<Observer> _observers = new List<Observer>();

		public void Attach(Observer observer)
		{
			_observers.Add(observer);
		}

		public void Remove(Observer observer)
		{
			_observers.Remove(observer);
		}

		public void Notify()
		{
			foreach (Observer o in _observers)
			{
				o.Update();
			}
		}
	}

	/// <summary>
	/// Concrete subject class
	/// </summary>
	class ConcreteSubject : Subject
	{
		private string _subjectState;

		// Gets or sets subject state
		public string SubjectState
		{
			get { return _subjectState; }
			set { _subjectState = value; }
		}
	}

	abstract class Observer
	{
		public abstract void Update();
	}

	class ConcreteObserver : Observer
	{
		private string _name;
		private string _observerState;
		private ConcreteSubject _subject;

		// Constructor
		public ConcreteObserver(
		  ConcreteSubject subject, string name)
		{
			this._subject = subject;
			this._name = name;
		}

		public override void Update()
		{
			_observerState = _subject.SubjectState;
			Console.WriteLine("Observer {0}'s new state is {1}",
			  _name, _observerState);
		}

		// Gets or sets subject
		public ConcreteSubject Subject
		{
			get { return _subject; }
			set { _subject = value; }
		}



	}
}

