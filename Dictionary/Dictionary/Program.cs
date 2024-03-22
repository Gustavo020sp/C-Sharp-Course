namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> cookies = new Dictionary<string, int>();
            //cookies["user"] = "maria";
            //cookies["password"] = "1234";
            //cookies["email"] = "maria@";
            //cookies["email"] = "maria2@";
            //Console.WriteLine(cookies["email"]);
            //D:\Projects\C-Sharp-Course\Dictionary\Candidates\candidates.txt

            Console.WriteLine("Enter file path: ");
            string filepath = Console.ReadLine();

            using(StreamReader sr = new StreamReader(filepath)) 
            {
                File.ReadAllLines(File.ReadAllText(filepath));
                while(!sr.EndOfStream)
                {
                    
                }
            }

            Console.ReadLine();
            
        }
    }
}
