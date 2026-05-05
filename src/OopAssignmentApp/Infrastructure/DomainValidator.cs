namespace OopAssignmentApp.Infrastructure;

public static class DomainValidator
{
    public static string RequireNonEmpty(string? value, string parameterName)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("Value cannot be empty", parameterName);
        }

        return value.Trim();
    }
}
