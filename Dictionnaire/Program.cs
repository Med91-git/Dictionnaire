namespace Dictionnaire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, List<string>> dictionnaire = new Dictionary<char, List<string>>();

            dictionnaire['a'] = new List<string> { "Anaïs", "Année", "Agir" };
            dictionnaire['b'] = new List<string> { "Béatrice", "Bulle", "Boire" };
            dictionnaire['c'] = new List<string> { "Charles", "Chemise", "Chercher" };

            Console.WriteLine("Dictionnaire avant modifications");
            Console.WriteLine();
            foreach (var item in dictionnaire)
            {
                Console.WriteLine(item.Key);
            }

            dictionnaire.Remove('c');

            Console.WriteLine();
            Console.WriteLine("Dictionnaire après modifications");
            Console.WriteLine();
            foreach (var item in dictionnaire)
            {
                Console.WriteLine(item.Key);  
            }
        }
    }
}
