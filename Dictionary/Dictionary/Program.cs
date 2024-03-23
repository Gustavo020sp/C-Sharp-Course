namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> cookies = new Dictionary<string, int>();
            // string[] Candidates;
            //cookies["Candidate"] = ""
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
                File.ReadAllLines(filepath);
                while(!sr.EndOfStream)
                {
                    string[] Candidates = sr.ReadLine().Split(",");
                    string name = Candidates[0];
                    int votes  = int.Parse(Candidates[1]);

                    if(cookies.ContainsKey(name))
                    {
                        cookies[name] += votes;
                    }
                    else
                    {
                        cookies[name] = votes;
                    }                    
                }
                foreach (var item in cookies)
                {
                    Console.WriteLine(item.Key + "=" + item.Value);
                }
            }

            Console.ReadLine();
            
        }
    }
}
