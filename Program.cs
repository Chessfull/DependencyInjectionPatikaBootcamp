using DependencyInjectionPatikaBootcamp.Managers;
using DependencyInjectionPatikaBootcamp.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ITeacher, Teacher>(); // -> Defining Dependency Injection life cycle

var app = builder.Build();



ClassRoom classRoom =new ClassRoom(new Teacher { FirstName="Sertan", LastName="Bozkus"});
 
app.MapGet("/", () => classRoom.GetTeacherInfo());

app.Run();
