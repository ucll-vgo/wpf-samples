using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cells
{
    public static class CellExtensions
    {
        public static ICell<TResult> Derive<T, TResult>( this ICell<T> cell, Func<T, TResult> func )
        {
            return Cell.Derived( cell, func );
        }

        public static ICell<bool> Negate( this ICell<bool> cell )
        {
            return cell.Derive( x => !x );
        }

        public static void Update<T>(this ICell<T> cell, Func<T, T> updater)
        {
            cell.Value = updater(cell.Value);
        }
    }
}
