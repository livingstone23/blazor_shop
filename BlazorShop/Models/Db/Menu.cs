using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace BlazorShop.Models.Db;



[Keyless]
public partial class Menu
{

    //Registro la propiedad Id como llave primaria
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(50)]
    //Registro la propiedad requerida y envio un mensaje personalizado
    [Required(ErrorMessage = "El campo MenuTitle es obligatorio")]
    public string MenuTitle { get; set; } = null!;

    [StringLength(300)]
    //Registro la propiedad requerida y envio un mensaje personalizado
    [Required(ErrorMessage = "El campo Link es obligatorio")]
    public string Link { get; set; } = null!;


    [StringLength(20)]
    //Registro la propiedad requerida y envio un mensaje personalizado
    [Required(ErrorMessage = "El campo Type es obligatorio")]
    public string Type { get; set; }

}
