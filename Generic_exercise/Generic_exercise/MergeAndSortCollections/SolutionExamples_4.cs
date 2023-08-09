using Generic_exercise.Entities;

namespace Generic_exercise.MergeAndSortCollections
{
    internal class SolutionExamples_4
    {
        public IEnumerable<int> MergeWithSorting_Int_Default(IEnumerable<int> firstCollection, IEnumerable<int> secondCollection)
        {
            var result = firstCollection.MergeWithSorting_Solution_4(secondCollection, SortingUtilities.CustomIntSortAscending);
            return result;
        }

        public IEnumerable<int> MergeWithSorting_Int_Reverse(IEnumerable<int> firstCollection, IEnumerable<int> secondCollection)
        {

            var result = firstCollection.MergeWithSorting_Solution_4(secondCollection, SortingUtilities.CustomIntSortDescending);
            return result;
        }

        public IEnumerable<string> MergeWithSorting_String_Default(IEnumerable<string> firstCollection, IEnumerable<string> secondCollection)
        {

            var result = firstCollection.MergeWithSorting_Solution_4(secondCollection, SortingUtilities.CustomStringSortAscending);
            return result;
        }

        public IEnumerable<string> MergeWithSorting_String_Reverse(IEnumerable<string> firstCollection, IEnumerable<string> secondCollection)
        {

            var result = firstCollection.MergeWithSorting_Solution_4(secondCollection, SortingUtilities.CustomStringSortDescending);
            return result;
        }

        public IEnumerable<IGameCharacter> MergeWithSorting_Entity_SortedByName_Ascending( IEnumerable<IGameCharacter> firstCollection, IEnumerable<IGameCharacter> secondCollection )
        {

            var result = firstCollection.MergeWithSorting_Solution_4( secondCollection, SortingUtilities.GameCharacterSortByNameAscending );
            return result;
        }

        public IEnumerable<IGameCharacter> MergeWithSorting_Entity_SortedByName_Descending( IEnumerable<IGameCharacter> firstCollection, IEnumerable<IGameCharacter> secondCollection )
        {

            var result = firstCollection.MergeWithSorting_Solution_4( secondCollection, SortingUtilities.GameCharacterSortByNameDescending );
            return result;
        }

        public IEnumerable<IGameCharacter> MergeWithSorting_Entity_SortedByHealth_Ascending( IEnumerable<IGameCharacter> firstCollection, IEnumerable<IGameCharacter> secondCollection )
        {

            var result = firstCollection.MergeWithSorting_Solution_4( secondCollection, SortingUtilities.GameCharacterSortByHealthAscending );
            return result;
        }

        public IEnumerable<IGameCharacter> MergeWithSorting_Entity_SortedByHealth_Descending( IEnumerable<IGameCharacter> firstCollection, IEnumerable<IGameCharacter> secondCollection )
        {

            var result = firstCollection.MergeWithSorting_Solution_4( secondCollection, SortingUtilities.GameCharacterSortByHealthDescending );
            return result;
        }
    }

    public class SortingUtilities
    {
        public static bool CustomIntSortAscending( int x, int y )
        {
            return x < y;
        }

        public static bool CustomIntSortDescending( int x, int y )
        {
            return x > y;
        }

        public static bool CustomStringSortAscending( string x, string y )
        {
            return string.Compare(x, y, StringComparison.Ordinal) > 0;
        }

        public static bool CustomStringSortDescending( string x, string y )
        {
            return string.Compare(x, y, StringComparison.Ordinal) < 0;
        }

        public static bool GameCharacterSortByNameAscending( IGameCharacter x, IGameCharacter y )
        {
            return string.Compare(x.Name, y.Name, StringComparison.Ordinal) < 0;
        }

        public static bool GameCharacterSortByNameDescending( IGameCharacter x, IGameCharacter y )
        {
            return string.Compare( x.Name, y.Name, StringComparison.Ordinal ) > 0;
        }

        public static bool GameCharacterSortByHealthAscending( IGameCharacter x, IGameCharacter y )
        {
            return x.Level < y.Level;
        }

        public static bool GameCharacterSortByHealthDescending( IGameCharacter x, IGameCharacter y )
        {
            return x.Level > y.Level;
        }
    }
}
