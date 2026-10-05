using NexaShop.Dtos.Categories;

namespace NexaShop.EndPoints;

public static class CategoryEndPoint
{
    public static void MapCategory(this WebApplication app)
    {
        app.MapGet("/", (CategoryEditorDto request) 
                => Results.Ok((object?)request.Name))
            .WithName("Categories")
            .WithTags("Categories TAG");
    }
}