namespace RoverCore.Abstractions.Templates;

public interface ITemplate
{
    int Id { get; set; }
    string Slug { get; set; }
    string Name { get; set; }
    string Description { get; set; }
    string PreHeader { get; set; }
    string Body { get; set; }
    DateTime Created { get; set; }
    DateTime Updated { get; set; }
}