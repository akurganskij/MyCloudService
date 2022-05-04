namespace BlazorApp5.Data
{
    public class SaveModel
    {
        public string Name { get; set; }

        public string Subject { get; set; }

        public string Topic { get; set; }

        public string Grade { get; set; }

        public string Complexity { get; set; }

        public bool Randomise { get; set; }

        public bool EnableTimer { get; set; }

        public int TimerDuration { get; set; }
    }
}
