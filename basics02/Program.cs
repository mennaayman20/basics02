using System.Text;

namespace basics02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print both title and upperTitle to show that title did not change.
            string title = "clean code";
            string upperTitle = title.ToUpper();
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Upper title: {upperTitle}");
            #endregion

            #region Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals() to check if they point to the same object in memory.
            string string1 = "Clean Code";
            string string2 = "Clean Code";
            bool sameRef = object.ReferenceEquals(string1, string2);
            Console.WriteLine($"Are the strings the same reference? {sameRef}");
            #endregion


            #region Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same  object.Print the final result.
            StringBuilder sb = new StringBuilder();
            sb.Append("Book List");
            sb.Append(" - Updated");
            Console.WriteLine($"Final result: {sb}");
            #endregion


            #region Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library". Print the result.
            sb.Replace("Book List", "Library");
            Console.WriteLine($"After Replace: {sb}");
            #endregion


            #region Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code, Pages: 464" using the + operator.
            string title2 = "Clean Code";
            int pages = 464;
            string res = "Book:" + title2 + " has " + pages + " pages.";
            Console.WriteLine(res);
            #endregion


            #region Build the same sentence as above, but using string interpolation ($"..."). 
            string res2 = $"Book: {title2}, Pages: {pages}";
            Console.WriteLine(res2);
            #endregion


            #region Build the same sentence again, but using string.Format().
            string result3 = string.Format("Book: {0}, Pages: {1}", title, pages);
            Console.WriteLine(result3);
            #endregion


            #region Given int pages = 464;, write an if / else statement that prints "Long Book" if pages is greater than 300, otherwise prints "Short Book".
            int pagess = 464;

            if (pagess > 300)
            {
                Console.WriteLine("Long Book");
            }
            else
            {
                Console.WriteLine("Short Book");
            }
            #endregion



            #region Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages is greater than 300 and isAvailable is true.Use the && operator.
            bool isAvailable = true;
            if (pagess > 300 && isAvailable)
            {
                Console.WriteLine("You can borrow this book");
            }
            #endregion





        }
    }
}
