using Core.Entities;
using Infrastructure.EntityFrameworkCore.Entities;

namespace Infrastructure.Extensions;

public static class DataMapper
{
    public static Data MapData(this DataEntity dataEntity)
        => new();
    
    public static DataEntity MapData(this Data data)
        => new();
}