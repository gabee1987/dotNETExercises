using Generic_exercise.MergeAndSortCollections;

namespace TestProject
{
    internal class MergeWithSorting_Solution_4_Tests
    {
        private int[] firstIntArray;
        private int[] secondIntArray;
        private string[] firstStringArray;
        private string[] secondStringArray;


        [SetUp]
        public void Setup()
        {
            firstIntArray     = new int[] { 5, 3, 2 };
            secondIntArray    = new int[] { 4, 1, 6 };
            firstStringArray  = new string[] { "apple", "orange", "banana" };
            secondStringArray = new string[] { "grape", "peach", "pineapple" };

        }

        [Test]
        public void MergeWithSorting_AllElementsPresentInResult()
        {
            // Arrange        

            // Act
            var result = firstIntArray.MergeWithSorting_Solution_4( secondIntArray, SortingUtilities.CustomIntSortAscending );

            // Assert
            result.Should().Contain( firstIntArray );
            result.Should().Contain( secondIntArray );
        }

        [Test]
        public void MergeWithSorting_IntsAscendingOrder_ReturnsSortedCollection()
        {
            // Arrange
            var expected = new List<int> { 1, 2, 3, 4, 5, 6 };

            // Act
            var result = firstIntArray.MergeWithSorting_Solution_4( secondIntArray, SortingUtilities.CustomIntSortAscending );

            // Assert
            result.Should().BeEquivalentTo( expected );
        }

        [Test]
        public void MergeWithSorting_IntsDescendingOrder_ReturnsSortedCollection()
        {
            // Arrange
            var expected = new List<int> { 6, 5, 4, 3, 2, 1 };

            // Act
            var result = firstIntArray.MergeWithSorting_Solution_4( secondIntArray, SortingUtilities.CustomIntSortDescending );

            // Assert
            result.Should().BeEquivalentTo( expected );
        }

        [Test]
        public void MergeWithSorting_StringsAscendingOrder_ReturnsSortedCollection()
        {
            // Arrange
            var expected = new List<string> { "apple", "banana", "grape", "orange", "peach", "pineapple" };

            // Act
            var result = firstStringArray.MergeWithSorting_Solution_4( secondStringArray, SortingUtilities.CustomStringSortAscending );

            // Assert
            result.Should().BeEquivalentTo( expected );
        }

        [Test]
        public void MergeWithSorting_StringsDescendingOrder_ReturnsSortedCollection()
        {
            // Arrange
            var expected = new List<string> { "pineapple", "peach", "orange", "grape", "banana", "apple" };

            // Act
            var result = firstStringArray.MergeWithSorting_Solution_4( secondStringArray, SortingUtilities.CustomStringSortDescending );

            // Assert
            result.Should().BeEquivalentTo( expected );
        }

        [Test]
        public void MergeWithSorting_EmptyFirsCollection_Returns_SecondCollectionSorted()
        {
            // Arrange
            var firstArr = new int[] { };
            var expected = new int[] { 1, 4, 6 };

            // Act
            var result = firstArr.MergeWithSorting_Solution_4( secondIntArray, SortingUtilities.CustomIntSortAscending );

            // Assert
            result.Should().BeEquivalentTo( expected );
        }

        [Test]
        public void MergeWithSorting_EmptyCollections_Returns_EmptyCollection()
        {
            // Arrange
            var firstArr  = new int[] { };
            var secondArr = new int[] { };
            var expected  = new int[] { };

            // Act
            var result = firstArr.MergeWithSorting_Solution_4( secondArr, SortingUtilities.CustomIntSortAscending );

            // Assert
            result.Should().BeEquivalentTo( expected );
        }

        [Test]
        public void MergeWithSorting_DifferentCollectionTypes_ReturnsSortedCollection()
        {
            //Arrange
            List<int> firstIntList = new List<int>() { 5, 3, 2 };
            var expected           = new List<int> { 1, 2, 3, 4, 5, 6 };

            //Act
            var result = firstIntList.MergeWithSorting_Solution_4( secondIntArray, SortingUtilities.CustomIntSortAscending );

            // Assert
            result.Should().BeEquivalentTo( expected );
        }

        [Test]
        public void MergeWithSorting_FirstCollectionIsNull_ThrowsException()
        {
            //Arrange
            List<int> firstIntList = null;

            //Act
            Action act = () => firstIntList.MergeWithSorting_Solution_4( secondIntArray, SortingUtilities.CustomIntSortAscending );

            // Assert
            act.Should().Throw<ArgumentNullException>();
        }

        [Test]
        public void MergeWithSorting_SecondCollectionIsNull_ThrowsException()
        {
            //Arrange
            List<int> secondIntList = null;

            //Act
            Action act = () => firstIntArray.MergeWithSorting_Solution_4( secondIntList, SortingUtilities.CustomIntSortAscending );

            // Assert
            act.Should().Throw<ArgumentNullException>();
        }
    }
}
