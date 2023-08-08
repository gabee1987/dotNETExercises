namespace Generic_exercise.MergeAndSortCollections
{
    internal class SolutionExamples_2
    {
        public IEnumerable<T> MergeWithSorting_Int_Default<T>(IEnumerable<T> firstCollection, IEnumerable<T> secondCollection) where T : IComparable<T>
        {
            var result = firstCollection.MergeWithSorting_Solution_2(secondCollection, Comparer<T>.Default);
            return result;
        }

        public IEnumerable<T> MergeWithSorting_Int_Reverse<T>(IEnumerable<T> firstCollection, IEnumerable<T> secondCollection) where T : IComparable<T>
        {

            var result = firstCollection.MergeWithSorting_Solution_2(secondCollection, Comparer<T>.Create((x, y) => y.CompareTo(x)));
            return result;
        }

        public IEnumerable<T> MergeWithSorting_String_Default<T>(IEnumerable<T> firstCollection, IEnumerable<T> secondCollection) where T : IComparable<T>
        {

            var result = firstCollection.MergeWithSorting_Solution_2(secondCollection, Comparer<T>.Default);
            return result;
        }

        public IEnumerable<T> MergeWithSorting_String_Reverse<T>(IEnumerable<T> firstCollection, IEnumerable<T> secondCollection) where T : IComparable<T>
        {

            var result = firstCollection.MergeWithSorting_Solution_2(secondCollection, Comparer<T>.Create((x, y) => y.CompareTo(x)));
            return result;
        }
    }
}
