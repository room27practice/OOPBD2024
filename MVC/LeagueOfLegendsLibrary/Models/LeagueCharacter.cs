using System.ComponentModel.DataAnnotations;

namespace LeagueOfLegendsLibrary.Models
{
    public class LeagueCharacter : BaseEntity<int>
    {
      
        public LeagueCharacter()
        {

        }

        public LeagueCharacter(string name, bool gender, Fraction fraction, string description, string mainIMageURL):this()
        {
            Name = name;
            Gender = gender;
            Fraction = fraction;
            Description = description;
            MainIMageURL = mainIMageURL;
        }

        public Region Region { get; set; }
        [MaxLength(16)]
        [MinLength(2)]
        public string Name { get; set; }
        public bool Gender { get; set; }
        public Fraction Fraction { get; set; }
        public string Description { get; set; }
        public string MainIMageURL { get; set; }
        public string PicturesURLS { get; set; }//"||url1|url2|url3|"
        public string[] PicturesCollection => PicturesURLS.Split("|", StringSplitOptions.RemoveEmptyEntries).ToArray();
        [Range(1, 99)]
        public double Dammage { get; set; }
    }
}