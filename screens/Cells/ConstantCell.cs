using System;
using System.Collections.Generic;
using System.Text;

namespace Cells
{
    internal class ConstantCell<T> : Cell<T>
    {
        private readonly T value;

        public ConstantCell(T value)
        {
            this.value = value;
        }

        public override T Value
        {
            get => value;
            set
            {
                throw new InvalidOperationException("Cannot set value of constant cell");
            }
        }

        public override void Refresh()
        {
            // NOP
        }
    }
}
