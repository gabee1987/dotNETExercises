using Generic_exercise;
using Generic_exercise.Entities;
using Generic_exercise.MergeAndSortCollections;

#region Init
var printer = new ConsolePrinter();

#region MergeAndSortCollections
var examples_1 = new SolutionExamples_1();
var examples_2 = new SolutionExamples_2();
var examples_3 = new SolutionExamples_3();
var examples_4 = new SolutionExamples_4();
var examples_5 = new SolutionExamples_5();

int[] intArray1 =  { 5, 3, 2 };
int[] intArray2 =  { 4, 1, 6 };
string[] stringArray1 = { "apple", "orange", "banana" };
string[] stringArray2 = { "grape", "peach", "pineapple" };
List<IGameCharacter> characterList1 = new List<IGameCharacter>()
{ 
    new Mage { Name = "Fredrick", Level = 50 },
    new Mage { Name = "Xirandor", Level = 20 },
    new Mage { Name = "Ashva", Level = 60 },

};
List<IGameCharacter> characterList2 = new List<IGameCharacter>()
    {
    new Rogue { Name = "Briol", Level = 10 },
    new Rogue { Name = "Cruentuss", Level = 30 },
    new Mage { Name = "Garret", Level = 40 },

};

string description1 = "Merged and sorted int collection";
string description2 = "Merged and sorted int collection in reverse";
string description3 = "Merged and sorted string collection";
string description4 = "Merged and sorted string collection in reverse";
string description5 = "Merged and sorted Entity collection by its Name property in ascending order";
string description6 = "Merged and sorted Entity collection by its Name property in descending order";
string description7 = "Merged and sorted Entity collection by its Level property in ascending order";
string description8 = "Merged and sorted Entity collection by its Level property in descending order";

// MergeAndSortCollections Title
printer.PrintLine( "Solutions to merge and sort two collections with a generic extension method and custom sorting function passed as parameter" );

printer.Print( "First original int collection: " );
printer.PrintCollection( intArray1 );
printer.Print( "Second original int collection: " );
printer.PrintCollection( intArray2 );

printer.Print( "First original string collection: " );
printer.PrintCollection( stringArray1 );
printer.Print( "Second original string collection: " );
printer.PrintCollection( characterList1 );

printer.Print( "First original Entity collection: " );
printer.PrintCollection( stringArray1 );
printer.Print( "Second original Entity collection: " );
printer.PrintCollection( characterList2 );
#endregion
#endregion



#region MergeAndSortCollections Solution #1
printer.PrintTitle( "Solution 1" );

// Example 1
var result1_1 = examples_1.MergeWithSorting_Int_Default(intArray1, intArray2 );
printer.PrintResult( result1_1, 1, description1 );

// Example 2
var result1_2 = examples_1.MergeWithSorting_Int_Reverse( intArray1, intArray2 );
printer.PrintResult( result1_2, 1, description2 );

// Example 3
var result1_3 = examples_1.MergeWithSorting_String_Default( stringArray1, stringArray2 );
printer.PrintResult( result1_3, 1, description3 );

// Example 4
var result1_4 = examples_1.MergeWithSorting_String_Reverse( stringArray1, stringArray2 );
printer.PrintResult( result1_4, 1, description4 );
#endregion


#region MergeAndSortCollections Solution #2
printer.PrintTitle( "Solution 2" );

// Example 1
var result2_1 = examples_2.MergeWithSorting_Int_Default( intArray1, intArray2 );
printer.PrintResult( result2_1, 2, description1 );

// Example 2
var result2_2 = examples_2.MergeWithSorting_Int_Reverse( intArray1, intArray2 );
printer.PrintResult( result2_2, 2, description2 );

// Example 3
var result2_3 = examples_2.MergeWithSorting_String_Default( stringArray1, stringArray2 );
printer.PrintResult( result2_3, 2, description3 );

// Example 4
var result2_4 = examples_2.MergeWithSorting_String_Reverse( stringArray1, stringArray2 );
printer.PrintResult( result2_4, 2, description4 );
#endregion


#region MergeAndSortCollections Solution #3
printer.PrintTitle( "Solution 3" );

// Example 1
var result3_1 = examples_3.MergeWithSorting_Int_Default( intArray1, intArray2 );
printer.PrintResult( result3_1, 3, description1 );

// Example 2
var result3_2 = examples_3.MergeWithSorting_Int_Reverse( intArray1, intArray2 );
printer.PrintResult( result3_2, 3, description2 );

// Example 3
var result3_3 = examples_3.MergeWithSorting_String_Default( stringArray1, stringArray2 );
printer.PrintResult( result3_3, 3, description3 );

// Example 4
var result3_4 = examples_3.MergeWithSorting_String_Reverse( stringArray1, stringArray2 );
printer.PrintResult( result3_4, 3, description4 );
#endregion


#region MergeAndSortCollections Solution #4
printer.PrintTitle( "Solution 4" );

// Example 1
var result4_1 = examples_4.MergeWithSorting_Int_Default( intArray1, intArray2 );
printer.PrintResult( result4_1, 4, description1 );

// Example 2
var result4_2 = examples_4.MergeWithSorting_Int_Reverse( intArray1, intArray2 );
printer.PrintResult( result4_2, 4, description2 );

// Example 3
var result4_3 = examples_4.MergeWithSorting_String_Default( stringArray1, stringArray2 );
printer.PrintResult( result4_3, 4, description3 );

// Example 4
var result4_4 = examples_4.MergeWithSorting_String_Reverse( stringArray1, stringArray2 );
printer.PrintResult( result4_4, 4, description4 );

// Example 5
var result1_5 = examples_4.MergeWithSorting_Entity_SortedByName_Ascending( characterList1, characterList2 );
printer.PrintResult( result1_5, 4, description5 );

// Example 6
var result1_6 = examples_4.MergeWithSorting_Entity_SortedByName_Descending( characterList1, characterList2 );
printer.PrintResult( result1_6, 4, description6 );

// Example 7
var result1_7 = examples_4.MergeWithSorting_Entity_SortedByHealth_Ascending( characterList1, characterList2 );
printer.PrintResult( result1_7, 4, description7 );

// Example 8
var result1_8 = examples_4.MergeWithSorting_Entity_SortedByHealth_Descending( characterList1, characterList2 );
printer.PrintResult( result1_8, 4, description8 );
#endregion

#region MergeAndSortCollections Solution #5
printer.PrintTitle( "Solution 5" );

// Example 1
var result5_1 = examples_5.MergeWithSorting_Entity_SortedByName_Ascending( characterList1, characterList2 );
printer.PrintResult( result5_1, 5, description5 );

// Example 2
var result5_2 = examples_4.MergeWithSorting_Entity_SortedByName_Descending( characterList1, characterList2 );
printer.PrintResult( result5_2, 5, description6 );

// Example 3
var result5_3 = examples_4.MergeWithSorting_Entity_SortedByHealth_Ascending( characterList1, characterList2 );
printer.PrintResult( result5_3, 5, description7 );

// Example 4
var result5_4 = examples_4.MergeWithSorting_Entity_SortedByHealth_Descending( characterList1, characterList2 );
printer.PrintResult( result5_4, 5, description8 );
#endregion

Console.ReadLine();

