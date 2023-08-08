﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_exercise
{
    internal class SolutionExamples_3
    {
        public IEnumerable<T> MergeWithSorting_Int_Default<T>( IEnumerable<T> firstCollection, IEnumerable<T> secondCollection ) where T : IComparable<T>
        {
            var result = firstCollection.MergeWithSorting_Solution_3( secondCollection, ( x, y ) => x.CompareTo( y ) );
            return result;
        }

        public IEnumerable<T> MergeWithSorting_Int_Reverse<T>( IEnumerable<T> firstCollection, IEnumerable<T> secondCollection ) where T : IComparable<T>
        {

            var result = firstCollection.MergeWithSorting_Solution_3( secondCollection, ( x, y ) => y.CompareTo( x ) );
            return result;
        }

        public IEnumerable<T> MergeWithSorting_String_Default<T>( IEnumerable<T> firstCollection, IEnumerable<T> secondCollection ) where T : IComparable<T>
        {

            var result = firstCollection.MergeWithSorting_Solution_3( secondCollection, ( x, y ) => x.CompareTo( y ) );
            return result;
        }

        public IEnumerable<T> MergeWithSorting_String_Reverse<T>( IEnumerable<T> firstCollection, IEnumerable<T> secondCollection ) where T : IComparable<T>
        {

            var result = firstCollection.MergeWithSorting_Solution_3( secondCollection, ( x, y ) => y.CompareTo( x ) );
            return result;
        }
    }
}
