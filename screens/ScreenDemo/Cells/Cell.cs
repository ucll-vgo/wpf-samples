using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Cells
{
    internal abstract class Cell<T> : ICell<T>, INotifyPropertyChanged
    {
        public abstract T Value { get; set; }

        private PropertyChangedEventHandler? PropertyChanged;

        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
        {
            add
            {
                 PropertyChanged += value;
            }
            remove
            {
                 PropertyChanged -= value;
            }
        }

        public event Action ValueChanged
        {
            add
            {
                PropertyChanged += ( obj, args ) => value();
            }
            remove
            {
                throw new NotSupportedException();
            }
        }

        protected void NotifyObservers()
        {
            PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( "Value" ) );
        }

        public override bool Equals( object? obj )
        {
            return Equals( obj as ICell<T> );
        }

        public bool Equals( ICell<T>? that )
        {
            if ( that == null )
            {
                return false;
            }
            else if ( this.Value == null )
            {
                return that.Value == null;
            }
            else
            {
                return this.Value.Equals( that.Value );
            }
        }

        public override int GetHashCode()
        {
            return Value != null ? Value.GetHashCode() : 0;
        }

        public override string ToString()
        {
            return $"CELL<{typeof(T).Name}>[{Value}]";
        }

        public abstract void Refresh();
    }
}
