namespace Core.Entities;

public sealed record Document(string Id, List<string> Tags, dynamic Data);