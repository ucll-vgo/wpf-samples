using System;

namespace Cells
{
    internal class ReadonlyWrapper<T> : Cell<T>
    {
        private readonly Cell<T> wrappedCell;

        public ReadonlyWrapper(Cell<T> wrappedCell)
        {
            this.wrappedCell = wrappedCell;
            wrappedCell.ValueChanged += NotifyObservers;
        }

        public override T Value
        {
            get => wrappedCell.Value;
            set
            {
                throw new InvalidOperationException("Cannot modify value of readonly view of cell");
            }
        }

        public override void Refresh()
        {
            // NOP
        }
    }
}
