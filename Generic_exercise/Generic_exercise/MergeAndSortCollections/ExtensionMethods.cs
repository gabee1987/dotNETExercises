namespace Generic_exercise.MergeAndSortCollections
{
    public static class ExtensionMethods
    {
        // Solution #1
        public static IEnumerable<T> MergeWithSorting_Solution_1<T>(this IEnumerable<T> first, IEnumerable<T> second, Func<T, T, int> sortingFunc)
        {
            var mergedList = first.Concat(second).ToList();
            mergedList.Sort(new Comparison<T>(sortingFunc));
            return mergedList;
        }


        // Solution #2
        public static IEnumerable<T> MergeWithSorting_Solution_2<T>(this IEnumerable<T> first, IEnumerable<T> second, IComparer<T> comparer)
        {
            var merged = first.Concat(second);
            return merged.OrderBy(x => x, comparer);
        }


        // Solution #3
        public static IEnumerable<T> MergeWithSorting_Solution_3<T>(this IEnumerable<T> first, IEnumerable<T> second, Func<T, T, int> comparison)
        {
            return first.Concat(second).OrderBy(x => x, Comparer<T>.Create((a, b) => comparison(a, b)));
        }


        // Solution 4
        public static IEnumerable<T> MergeWithSorting_Solution_4<T>(this IEnumerable<T> first, IEnumerable<T> second, Func<T, T, bool> sortingFunc)
        {
            var mergedCollection = first.Concat(second);

            return mergedCollection.OrderBy(item => item, Comparer<T>.Create((x, y) => sortingFunc(x, y) ? -1 : 1));
        }


        // Solution 5
        public static IEnumerable<T> MergeWithSorting_Solution_5<T, Tkey>( this IEnumerable<T> first, IEnumerable<T> second, Func<T, Tkey> keySelector, bool descending = false )
        {
            return descending ? first.Concat( second ).OrderByDescending( keySelector ) : first.Concat( second ).OrderBy( keySelector );
        }



        #region Scrapped Solutions

        // Remove casting, make it simple
        //public static IEnumerable<object> MergeWith_1<T, U>(this IEnumerable<T> first, IEnumerable<U> second)
        //{
        //    return first.Cast<object>().Concat(second.Cast<object>());
        //}

        //public static IEnumerable<IEntity> MergeWith_2<T, U>( this IEnumerable<T> first, IEnumerable<U> second )
        //    where T : IEntity
        //    where U : IEntity
        //{
        //    return first.Cast<IEntity>().Concat( second.Cast<IEntity>() );
        //}
        //public static IEnumerable<T> CustomMerge<T>( this IEnumerable<T> first, IEnumerable<T> second )
        //{
        //    return first.Concat( second );
        //}



        //public static IEnumerable<T> MergeWithSorting<T>( this IEnumerable<T> first, IEnumerable<T> second, Func<IEnumerable<T>, T> sortingFunc )
        //{
        //    var mergedArr = first.Concat( second );
        //    return sortingFunc( mergedArr ) as IEnumerable<T>;
        //}

        //public static IEnumerable<T> MergeWithSorting<T>( this IEnumerable<T> first, IEnumerable<T> second ) where T : IComparable<T>
        //{
        //    return first.Concat( second ).OrderBy( item => item );
        //}

        //public static IEnumerable<T> MergeWithSorting<T>( this IEnumerable<T> first, IEnumerable<T> second, Comparison<T> comparison )
        //{
        //    var list = first.Concat( second ).ToList();
        //    list.Sort( comparison );
        //    return list;
        //}

        //public static IEnumerable<T> MergeWithSorting<T, TKey>( this IEnumerable<T> first, IEnumerable<T> second, Func<T, TKey> sortingFunc )
        //    where TKey : IComparable<TKey>
        //{
        //    return first.Concat( second ).OrderBy( sortingFunc );
        //}

        //public static IEnumerable<int> MergeWithSorting( this IEnumerable<int> first, IEnumerable<int> second, Func<int, int> sortingFunc )
        //{
        //    return first.Concat( second ).OrderBy( sortingFunc );
        //}

        //public static IEnumerable<T> MergeWithSorting<T>( this IEnumerable<T> first, IEnumerable<T> second, IComparer<T> comparer )
        //{
        //    return first.Concat(second).OrderBy(o => o, comparer);
        //}

        //public static IEnumerable<T> MergeWithSorting<T>( this IEnumerable<T> first, IEnumerable<T> second, Func<T, T, int> comparison )
        //{
        //    var mergedList = first.Concat( second ).ToList();
        //    mergedList.Sort();
        //    return mergedList;
        //}

        //public static IEnumerable<T> MergeWithSorting_Solution_4<T>( this IEnumerable<T> first, IEnumerable<T> second, Func<T, T, bool> sortingFunc )
        //{
        //    var mergedArray = first.Concat( second ).ToArray();

        // Bubble sort
        //for ( var i = 0; i < mergedArray.Length - 1; i++ )
        //{
        //    for ( var j = 0; j < mergedArray.Length - i - 1; j++ )
        //    {
        //        if ( sortingFunc( mergedArray[j], mergedArray[j + 1] ) )
        //        {
        //            var temp = mergedArray[j];
        //            mergedArray[j] = mergedArray[j + 1];
        //            mergedArray[j + 1] = temp;
        //        }
        //    }
        //}

        //return mergedArray;

        //    return mergedArray.OrderBy( item => item, Comparer<T>.Create( ( x, y ) => sortingFunc( x, y ) ? -1 : 1 ) );
        //}
        #endregion
    }
}
