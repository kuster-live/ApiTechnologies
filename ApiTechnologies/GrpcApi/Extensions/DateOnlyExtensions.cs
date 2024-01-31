namespace GrpcService1.Extensions;

public static  class DateOnlyExtensions
{
    public static Date ToDate(this DateOnly dateOnly) => new()
    {
        Year = dateOnly.Year,
        Month = dateOnly.Month,
        Day = dateOnly.Day
    };

    public static Date ToDate(this DateOnly? date) => date.HasValue ? date.Value.ToDate() : new();
}
