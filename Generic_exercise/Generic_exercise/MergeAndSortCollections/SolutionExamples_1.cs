namespace Generic_exercise.MergeAndSortCollections
{
    internal class SolutionExamples_1
    {
        public IEnumerable<T> MergeWithSorting_Int_Default<T>(IEnumerable<T> firstCollection, IEnumerable<T> secondCollection) where T : IComparable<T>
        {
            var result = firstCollection.MergeWithSorting_Solution_1(secondCollection, (x, y) => x.CompareTo(y));
            return result;
        }

        public IEnumerable<T> MergeWithSorting_Int_Reverse<T>(IEnumerable<T> firstCollection, IEnumerable<T> secondCollection) where T : IComparable<T>
        {

            var result = firstCollection.MergeWithSorting_Solution_1(secondCollection, (x, y) => y.CompareTo(x));
            return result;
        }

        public IEnumerable<T> MergeWithSorting_String_Default<T>(IEnumerable<T> firstCollection, IEnumerable<T> secondCollection) where T : IComparable<T>
        {

            var result = firstCollection.MergeWithSorting_Solution_1(secondCollection, (x, y) => x.CompareTo(y));
            return result;
        }

        public IEnumerable<T> MergeWithSorting_String_Reverse<T>(IEnumerable<T> firstCollection, IEnumerable<T> secondCollection) where T : IComparable<T>
        {

            var result = firstCollection.MergeWithSorting_Solution_1(secondCollection, (x, y) => y.CompareTo(x));
            return result;
        }
    }
}
