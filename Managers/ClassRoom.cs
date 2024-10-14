using DependencyInjectionPatikaBootcamp.Services;

namespace DependencyInjectionPatikaBootcamp.Managers
{
    public class ClassRoom
    {
        private readonly ITeacher _teacher;

        // ▼ Ctor injection ▼
        public ClassRoom(ITeacher teacher)
        {
            _teacher = teacher;
        }
        public string GetTeacherInfo()
        {
            return _teacher.GetInfo();
        }
    }
}
