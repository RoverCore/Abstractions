namespace RoverCore.Abstractions.Templates;

public interface ITemplateService
{
    IQueryable<ITemplate> GetTemplateQueryable();
    Task<ITemplate?> FindTemplateById(int id);
    Task<ITemplate?> FindTemplateBySlug(string slug);
    Task<ITemplate?> CreateTemplate(ITemplate template);
    Task<ITemplate?> UpdateTemplate(ITemplate template);
    Task DeleteTemplate(int id);
    bool TemplateExists(int id);
    bool TemplateExists(string slug);
    void LoadTemplates();
}