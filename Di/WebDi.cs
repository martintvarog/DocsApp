using Core.Infrastructure;
using Infrastructure.DocumentService;
using Infrastructure.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Di;

public static class WebDi
{
    public static void ConfigureServices(IServiceCollection services, IConfiguration config)
    {
        services.AddSingleton<IDocumentRepository, DocumentRepository>();
        services.AddScoped<IDocumentService, DocumentService>();
    }
}