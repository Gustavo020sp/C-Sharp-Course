using Set1_Resolution.Entities;

namespace Set1_Resolution.Services
{
    public class ReadFile
    {
        //como se fosse uma lista (para entender melhor Hashset//
        HashSet<LogRecord> set = new HashSet<LogRecord>();
        public string path {  get; set; }
        public ReadFile(string path)
        {
            this.path = path;
        }
        public void GetTotalUsers()
        {
            List<string> list = new List<string>();
            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(' ');
                    string name = line[0];
                    DateTime instant = DateTime.Parse(line[1]);
                    set.Add(new LogRecord { userName = name, instant = instant});;
                }
                Console.WriteLine("Total users: " + set.Count);
            }
        }
    }
}
