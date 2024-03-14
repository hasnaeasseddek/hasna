namespace Param.Domain.DTOs;

public record CityGetDTO(int Id, string Name);
public record CityPostDTO(string Name);
public record CityPutDTO(int Id, string Name);