namespace Estately.Core.Entities
{
    [Table("LkpUserType")]
    public class LkpUserType
    {
        [Key]
        public int UserTypeID { get; set; }

        [Required]
        [StringLength(255)]
        public string UserTypeName { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }
    }
}
#nullable restore