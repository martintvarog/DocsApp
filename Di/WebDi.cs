using Core.Infrastructure;
using Infrastructure.Repository;
using Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Di;

public static class WebDi
{
    public static void ConfigureServices(IServiceCollection services, IConfiguration config)
    {
        services.AddScoped<IDocumentRepository, DocumentRepository>();
        services.AddScoped<IDocumentService, DocumentService>();
    }
}