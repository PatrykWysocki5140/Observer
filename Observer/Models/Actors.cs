using Observer.Models.Observer;
using Strategy.Models.Actor.Enums;

namespace Observer.Models
{
    internal class Actors : Observable
    {
        public const string ACTOR_CREATE = "ACTOR_CREATE";
        public const string ACTOR_DELETE = "ACTOR_DELETE";
        public const string EXCEPTION = "EXCEPTION";

        protected Dictionary<string, Actor.Actor> _users = new();

        public void CreateActor(int id,string name, string surname, ProfesionEnum profesion)
        {
            Actor.Actor user = new Actor.Actor()
            {
               Id = id,
               Name = name,
               Surname = surname,
               Profesion = profesion
            };
            _users.Add(id.ToString(), user);
            NotifyObservable(ACTOR_CREATE, user);
        }

        public void DeleteActor(int iId)
        {
            string id = iId.ToString();

            if (_users.ContainsKey(id))
            {
                NotifyObservable(ACTOR_DELETE, _users[id]);
                _users.Remove(id);
            }
            else
            {
                NotifyObservable(EXCEPTION, "removing user failed, username not found - Id:" + id);
            }
        }
    }
}
