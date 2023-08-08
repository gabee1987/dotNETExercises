﻿using Generic_exercise;
using Generic_exercise.MergeAndSortCollections;

#region Init
var printer = new ConsolePrinter();

#region MergeAndSortCollections
var examples_1 = new SolutionExamples_1();
var examples_2 = new SolutionExamples_2();
var examples_3 = new SolutionExamples_3();

int[] intArray1 =  { 5, 3, 2 };
int[] intArray2 =  { 4, 1, 6 };
string[] stringArray1 = { "apple", "orange", "banana" };
string[] stringArray2 = { "grape", "peach", "pineapple" };

string description1 = "Merged and sorted int collection";
string description2 = "Merged and sorted int collection in reverse";
string description3 = "Merged and sorted string collection";
string description4 = "Merged and sorted string collection in reverse";

// MergeAndSortCollections Title
printer.PrintLine( "Solutions to merge and sort two collections with a generic extension method and custom sorting function passed as parameter" );

printer.Print( "First original int collection: " );
printer.PrintCollection( intArray1 );
printer.Print( "Second original int collection: " );
printer.PrintCollection( intArray2 );

printer.Print( "First original string collection: " );
printer.PrintCollection( stringArray1 );
printer.Print( "Second original string collection: " );
printer.PrintCollection( stringArray2 );
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
printer.PrintResult( result2_1, 1, description1 );

// Example 2
var result2_2 = examples_2.MergeWithSorting_Int_Reverse( intArray1, intArray2 );
printer.PrintResult( result2_2, 1, description2 );

// Example 3
var result2_3 = examples_2.MergeWithSorting_String_Default( stringArray1, stringArray2 );
printer.PrintResult( result2_3, 1, description3 );

// Example 4
var result2_4 = examples_2.MergeWithSorting_String_Reverse( stringArray1, stringArray2 );
printer.PrintResult( result2_4, 1, description4 );
#endregion


#region MergeAndSortCollections Solution #3
printer.PrintTitle( "Solution 3" );

// Example 1
var result3_1 = examples_2.MergeWithSorting_Int_Default( intArray1, intArray2 );
printer.PrintResult( result3_1, 1, description1 );

// Example 2
var result3_2 = examples_2.MergeWithSorting_Int_Reverse( intArray1, intArray2 );
printer.PrintResult( result3_2, 1, description2 );

// Example 3
var result3_3 = examples_2.MergeWithSorting_String_Default( stringArray1, stringArray2 );
printer.PrintResult( result3_3, 1, description3 );

// Example 4
var result3_4 = examples_2.MergeWithSorting_String_Reverse( stringArray1, stringArray2 );
printer.PrintResult( result3_4, 1, description4 );
#endregion


#region MergeAndSortCollections Solution #4
printer.PrintTitle( "Solution 4" );

// Example 1
var result4_1 = examples_2.MergeWithSorting_Int_Default( intArray1, intArray2 );
printer.PrintResult( result4_1, 1, description1 );

// Example 2
var result4_2 = examples_2.MergeWithSorting_Int_Reverse( intArray1, intArray2 );
printer.PrintResult( result4_2, 1, description2 );

// Example 3
var result4_3 = examples_2.MergeWithSorting_String_Default( stringArray1, stringArray2 );
printer.PrintResult( result4_3, 1, description3 );

// Example 4
var result4_4 = examples_2.MergeWithSorting_String_Reverse( stringArray1, stringArray2 );
printer.PrintResult( result4_4, 1, description4 );
#endregion

Console.ReadLine();

