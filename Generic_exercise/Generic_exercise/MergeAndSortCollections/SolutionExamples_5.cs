﻿using Generic_exercise.Entities;

namespace Generic_exercise.MergeAndSortCollections
{
    internal class SolutionExamples_5
    {
        public IEnumerable<IGameCharacter> MergeWithSorting_Entity_SortedByName_Ascending( IEnumerable<IGameCharacter> firstCollection, IEnumerable<IGameCharacter> secondCollection )
        {
            var result = firstCollection.MergeWithSorting_Solution_5( secondCollection, character => character.Name );
            return result;
        }

        public IEnumerable<IGameCharacter> MergeWithSorting_Entity_SortedByName_Descending( IEnumerable<IGameCharacter> firstCollection, IEnumerable<IGameCharacter> secondCollection )
        {

            var result = firstCollection.MergeWithSorting_Solution_5( secondCollection, character => character.Name, descending: true );
            return result;
        }

        public IEnumerable<IGameCharacter> MergeWithSorting_Entity_SortedByLevel_Ascending( IEnumerable<IGameCharacter> firstCollection, IEnumerable<IGameCharacter> secondCollection )
        {

            var result = firstCollection.MergeWithSorting_Solution_5( secondCollection, character => character.Level );
            return result;
        }

        public IEnumerable<IGameCharacter> MergeWithSorting_Entity_SortedByLevel_Descending( IEnumerable<IGameCharacter> firstCollection, IEnumerable<IGameCharacter> secondCollection )
        {

            var result = firstCollection.MergeWithSorting_Solution_5( secondCollection, character => character.Level, descending: true );
            return result;
        }
    }
}
