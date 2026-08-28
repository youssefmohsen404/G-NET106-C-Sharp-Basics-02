namespace G_NET106_C_Basics_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1
            //Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a variable of type object. Print it.


            /*Book book = new Book();
            object obj = book;
            Console.WriteLine(obj);*/
            #endregion
            #region Question2
            //Using the Book class above, print the result of calling ToString(), Equals() (compare book with itself), GetHashCode(), and GetType() on book.

            /*Book book = new Book();
            Console.WriteLine(book.ToString());
            Console.WriteLine(book.Equals(book));
            Console.WriteLine(book.GetHashCode());
            Console.WriteLine(book.GetType());*/

            #endregion
            #region Question3
            //Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it.
            //int pages = "464"; ---------------->compile-time error

            /*int pages = 464;
            string pages = "464";*/

            #endregion
            #region Question4
            //Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by zero", and then prints "Done" in a finally block.
            /*int firstNumber = 10;
            int secondNumber = 0;
            try
            {
                double result = firstNumber / secondNumber;
                Console.WriteLine(result);
            }catch(DivideByZeroException ex)
            {
                //Console.WriteLine(ex.Message);
                Console.WriteLine("cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("Done");
            }*/
            #endregion
            #region Question5
            //Declare an int pages = 300; then store it in a double variable without using a cast.
            /*int pages = 300;
            //implicit casting
            double doublePages = pages;
*/
            #endregion
        }
    }
}
