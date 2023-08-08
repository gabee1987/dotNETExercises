namespace Generic_exercise
{
    internal interface IPrinter
    {
        void Print( string message );
        void PrintLine( string message );
        void PrintCollection<T>( IEnumerable<T> collection );
        void PrintResult<T>( IEnumerable<T> collection, int id, string description );
    }
}
