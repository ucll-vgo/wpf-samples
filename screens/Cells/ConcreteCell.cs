
using System.Collections.Generic;

namespace Cells
{
    internal class ConcreteCell<T> : Cell<T>
    {
        private T value;

        public ConcreteCell( T initialValue )
        {
            this.value = initialValue;
        }

        public override T Value
        {
            get
            {
                return this.value;
            }
            set
            {
                if ( !EqualityComparer<T>.Default.Equals(this.value, value) )
                {
                    this.value = value;
                    NotifyObservers();
                }
            }
        }

        public override void Refresh()
        {
            // NOP
        }
    }
}
