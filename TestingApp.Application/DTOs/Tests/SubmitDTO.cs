namespace TestingApp.Application.DTOs.Tests;

public record SubmitDTO(
   Guid testId,
   List<Guid> answersIds);