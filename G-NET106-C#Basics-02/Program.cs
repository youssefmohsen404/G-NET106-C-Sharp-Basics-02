using static System.Runtime.InteropServices.JavaScript.JSType;

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
            #region Question6
            //Declare a double price = 49.99; then convert it into an int using a cast.
            /*double price = 49.99;
            //explicit casting
            int intPrice = (int)price;*/
            #endregion
            #region Question7
            //Given string pagesText = "464";, convert it into an int using the Convert class.
            /*string pagesText = "464";
            int pages = Convert.ToInt32(pagesText);*/

            #endregion
            #region Question8
            //giving string yearText = "2023";, convert it using int.Parse().
            //Then given string badText = "abc";, use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.
            /* string yearText = "2023";
             int year = int.Parse(yearText);

             string badText = "abc";
             bool success =   int.TryParse(badText, out int intBadValue);
             if (success)
             {
                 Console.WriteLine($"success Converted value = {intBadValue}");
             }
             else
             {
                 Console.WriteLine("Invalid number");
             }   
 */


            #endregion
            #region Question9
            //Given int pages = 464;, convert it into a string using ToString() and print its type using GetType() to prove it's now a string.
            /*int pages = 464;
            string stringPages = pages.ToString();
            Console.WriteLine(stringPages.GetType());*/


            

            #endregion
        }
    }
}
