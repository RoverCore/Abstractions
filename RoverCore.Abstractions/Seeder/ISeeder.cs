using Serviced;

namespace RoverCore.Abstractions.Seeder;

public interface ISeeder : IScoped
{
    /// <summary>
    /// Priority for determining seeding order (higher numbers have first priority to seed)
    /// </summary>
    int Priority { get; }

    /// <summary>
    /// Method that performs the seeding
    /// </summary>
    /// <returns></returns>
    Task SeedAsync();
}

public interface ISeeder<T> : ISeeder
{
}
