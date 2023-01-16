public class Resume
    {
        public string _name = "";
        public List<Job> _jobs;
        public void _display()
        {
            Console.WriteLine($"{_name}");
        }
    }