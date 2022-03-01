using Serviced;

namespace RoverCore.Abstractions.Seeder;

public interface ISeeder : IScoped
{
    Task SeedAsync();
}

public interface ISeeder<T> : ISeeder
{
}
