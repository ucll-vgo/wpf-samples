using System;

namespace Cells
{
    internal class ManualCell<T> : ConcreteCell<T>
    {
        private readonly Func<T> reader;

        public ManualCell( Func<T> reader )
            : base( reader() )
        {
            this.reader = reader;
        }

        public override void Refresh()
        {
            base.Value = reader();
        }

        public override T Value
        {
            get
            {
                return base.Value;
            }
            set
            {
                throw new InvalidOperationException();
            }
        }
    }

}
