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


        }
    }
}
