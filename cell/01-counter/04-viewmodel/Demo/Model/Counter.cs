using Cells;
using System;

namespace Model
{
    // The Counter belongs in the Model
    public class Counter
    {
        public Counter()
        {
            this.Current = Cell.Create(0);
        }

        public Cell<int> Current { get; }

        public void Increase()
        {
            this.Current.Value++;
        }
    }
}
