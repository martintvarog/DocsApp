using Core.Entities;
using Core.Infrastructure.DTOs;

namespace Infrastructure.Extensions;

public static class DataMapper
{
    public static Data MapToData(this DataDto dataDto)
        => new Data();

    public static DataDto MapToData(this Data data)
        => new DataDto();
}