using DependencyInjectionPatikaBootcamp.Services;

namespace DependencyInjectionPatikaBootcamp.Managers
{
    public class Teacher : ITeacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetInfo()
        {
            return FirstName + " " + LastName;
        }
    }

}
