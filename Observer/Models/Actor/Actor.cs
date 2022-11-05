using Strategy.Models.Actor.Enums;

namespace Observer.Models.Actor
{
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public ProfesionEnum Profesion { get; set; }
    }
}
