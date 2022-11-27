namespace UB.Data.Domain
{
    public class Grade : Entity
    {
        public string Name { get; set; }

        public string Recomendation { get; set; }

        public string RecomendationUrl { get; set; }

        public int Order { get; set;  }
    }
}
