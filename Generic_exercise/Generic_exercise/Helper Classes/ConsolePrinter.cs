using Generic_exercise.Entities;

namespace Generic_exercise
{
    internal class ConsolePrinter : IPrinter
    {
        public void Print( string message )
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write( $"{message}" );
            Console.ResetColor();
        }

        public void PrintLine( string message )
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine( $"\n{message}\n" );
            Console.ResetColor();
        }

        public void PrintCollection<T>( IEnumerable<T> collection )
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            foreach ( var item in collection )
            {
                Console.Write( $"{item.ToString()} " );
            }
            Console.WriteLine();
        }

        public void PrintResult<T>( IEnumerable<T> collection, int id, string description )
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine( $"Solution #{id}: {description}" );

            Console.Write( "Result: " );
            Console.ForegroundColor = ConsoleColor.Green;

            foreach ( var item in collection )
            {
                if ( item is IGameCharacter character )
                {
                    Console.Write( $"{character.Name}({character.Health}) " );
                }
                else
                {
                    Console.Write( $"{item.ToString()} " );
                }
            }

            Console.WriteLine( "\n" );
            Console.ResetColor();
        }

        public void PrintTitle( string title )
        {
            int padding = 10;
            int totalLength = title.Length + padding * 2;

            // The PadLeft and PadRight functions will take care of adding extra spaces
            string paddedTitle = title.PadLeft( title.Length + padding ).PadRight( totalLength );

            string horizontalLine = new string( '═', totalLength );

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine( $"╔{horizontalLine}╗" );
            Console.WriteLine( $"║{paddedTitle}║" );
            Console.WriteLine( $"╚{horizontalLine}╝" );
            Console.ResetColor();
        }
    }
}
