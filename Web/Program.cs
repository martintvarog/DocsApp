using Core.Migrations.Context;
using Di;
using Infrastructure;
using MessagePack;
using MessagePack.AspNetCoreMvcFormatter;
using MessagePack.Resolvers;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DocsDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.
WebDi.ConfigureServices(builder.Services, builder.Configuration);
builder.Services.AddControllers().AddXmlDataContractSerializerFormatters().AddMvcOptions(options =>
{
    options.OutputFormatters.Add(
        new MessagePackOutputFormatter(
            MessagePackSerializerOptions.Standard.WithResolver(ContractlessStandardResolver.Instance)));
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();