using Observer.Models;
using Observer.Models.Actions;
using Strategy.Models.Actor.Enums;

namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            Actors act = new();

            act.CreateObservable(new CreateAction());
            act.CreateObservable(new SendInfoAction(),Actors.ACTOR_CREATE);
            act.CreateObservable(new ExceptionAction(),Actors.EXCEPTION);

            act.CreateActor(1, "Jan", "Nowak", ProfesionEnum.Robber);
            act.CreateActor(2, "Katarzyna", "Nowak", ProfesionEnum.Policeman);
            act.CreateActor(3, "Tom", "Harry", ProfesionEnum.Villager);
            act.CreateActor(4, "Cichy", "Jerry", ProfesionEnum.Citizen);

            act.DeleteActor(4);
            act.DeleteActor(5);
            act.DeleteActor(6);

            Console.ReadKey();
        }
    }
}