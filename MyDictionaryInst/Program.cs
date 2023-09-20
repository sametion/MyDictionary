namespace MyDictionaryInst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string> myDictionary= new MyDictionary<int,string>();

            myDictionary.Add(33, "mersin");
            myDictionary.Add(06, "ankara");
            myDictionary.Add(34, "istanbul");
            myDictionary.Add(35, "izmir");
            myDictionary.Add(43, "kütahya");

            foreach (var item in myDictionary.Keys)
            {
                Console.WriteLine(item);
            }

            foreach (var item in myDictionary.Values)
            { 
                Console.WriteLine(item); 
            }
        }
    }
}