namespace MyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> myDictionary = new MyDictionary<string>();
            Console.WriteLine(myDictionary.Count);
            myDictionary.Add("Kütahya");
            myDictionary.Add("Bursa");
            myDictionary.Add("Eskişehir");
            myDictionary.Add("İstanbul");
            myDictionary.Add("İzmir");
            Console.WriteLine(myDictionary.Count);
            myDictionary.Sort();
            myDictionary.RemoveLastIndex();
            Console.WriteLine(myDictionary.Count);
            myDictionary.Cw();
        }
    }
}