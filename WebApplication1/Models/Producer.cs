using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        public string Bio { get; set; }

        //Relationships
        public List<Actor> Actors { get; set; }
        public List<Movie> Movies { get; set; }
        public List<Actor_Movie> Actors_Movies { get; set; }
        public List<Cinema> Cinemas { get; set; }
        public List<Producer> Producers { get; set; }

    }
}
