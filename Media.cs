namespace SWE201_235060006
{
    public class Media
    {
        private string title;
        private string type;        // Film or Series
        private int releaseYear;

        // Properties
        public string Title
        {
            get => title;
            set => title = value;
        }

        public string Type
        {
            get => type;
            set => type = value;
        }

        public int ReleaseYear
        {
            get => releaseYear;
            set => releaseYear = value;
        }

        // Empty constructor
        public Media() { }

        // Parameterized constructor
        public Media(string title, string type, int releaseYear)
        {
            this.title = title;
            this.type = type;
            this.releaseYear = releaseYear;
        }

        // Member function
        public string GetDetails()
        {
            return $"{Title} ({ReleaseYear}) - Tür: {Type}";
        }

        // ToString override
        public override string ToString()
        {
            return $"[Media] {Title} - {Type}, {ReleaseYear}";
        }
    }
}

