namespace Estately.Core.Entities
{
    public partial class ApplicationUser : IdentityUser
    {
        public DateTime? CreatedAt { get; set; } = DateTime.UtcNow;
    }
}