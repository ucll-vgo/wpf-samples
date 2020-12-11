using System;
using System.Collections.Generic;
using System.Text;

namespace Cells
{
    public interface ICell<T> : IVar<T>, IEquatable<ICell<T>>
    {
        public event Action ValueChanged;

        public void Refresh();        
    }
}
