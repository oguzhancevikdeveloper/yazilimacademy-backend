using YazilimAcademy.Domain.Common;
using YazilimAcademy.Domain.Enums;

namespace YazilimAcademy.Domain.Entities;

public sealed class Course : EntityBase
{
    public string Title { get; private set; }
    public string? SubTitle { get; private set; }
    public string? Description { get; private set; }
    public CourseLevel Level { get; private set; }
    public string? ThumbnailPath { get; private set; }
    public TimeSpan Duration { get; private set; }
    public decimal Price { get; private set; }
    public int ReviewCount { get; private set; }
    public double Rating { get; private set; }
    public int StudentCount { get; private set; }
    public ICollection<CourseCategory> CourseCategories { get; private set; } = [];
}
