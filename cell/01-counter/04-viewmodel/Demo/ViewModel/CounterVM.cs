using Cells;
using Model;
using System;
using System.Windows.Input;

namespace ViewModel
{
    // The Counter ViewModel wraps a Counter and makes adapts it to the View
    public class CounterVM
    {
        // Wrapped counter
        private readonly Counter counter;

        public CounterVM(Counter counter)
        {
            this.counter = counter;
            this.Increase = new ActionCommand(() => this.counter.Increase());
        }

        // This command wraps the Increase() method from Counter
        public ICommand Increase { get; }

        // We make the Counter's current value available
        public Cell<int> Current
        {
            get
            {
                return counter.Current;
            }
        }
        // can be written shorter as
        //   public Cell<int> Current => counter.Current
    }
}
