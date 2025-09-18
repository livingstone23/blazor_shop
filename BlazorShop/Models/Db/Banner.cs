using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace BlazorShop.Models.Db;



[Table("Banner")]
public partial class Banner
{

    // Llave primaria Identity(1,1)
    [Key]
    [Column("ID")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [StringLength(200)]
    public string? Title { get; set; }

    [StringLength(1000)]
    public string? SubTitle { get; set; }

    [StringLength(50)]
    public string? ImageName { get; set; }

    public short? Priority { get; set; } // SMALLINT NULL

    [StringLength(100)]
    public string? Link { get; set; }

    [StringLength(50)]
    public string? Position { get; set; }

}