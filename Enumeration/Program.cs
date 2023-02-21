namespace Enums
{
    internal class Program {
        enum Rating
        {
            Best,
            Average,
            Worst
        }

        enum animals
        {
            Cat,
            Dog,
            Duck,
            Leopard
        }

        static void Main(string[] args)
        {
            // simply prints the string
            Console.WriteLine(Rating.Worst);
            // storing type must be changed for storing in variables
            string worst = Rating.Worst.ToString();
            Console.WriteLine("Name : " + worst);
            // just cast the value for integer
            int worstNum = (int)Rating.Worst;
            Console.WriteLine("Value : " + worstNum);

            // CompareTo Method
            Rating rating1 = Rating.Best;
            Rating rating2 = Rating.Average;
            Rating rating3 = Rating.Worst;
            // rating1 is less than rating2, so it gives -1
            Console.WriteLine("Rating1 vs Rating2 : " + rating1.CompareTo(rating2));
            // rating3 is equal to rating3, so it gives 0
            Console.WriteLine("Rating3 vs Rating3 : " + rating3.CompareTo(rating3));
            //----------------------------------------------------------------

            // EqualTo Method
            animals a1 = animals.Cat;
            animals a2 = animals.Dog;
            // animals a3 = animals.Duck;
            Console.WriteLine(a1.Equals(a2) ? "Yes" : "No");

        }
    }
}