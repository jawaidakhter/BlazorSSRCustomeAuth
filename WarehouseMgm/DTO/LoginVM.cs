using System.ComponentModel.DataAnnotations;

namespace WarehouseMgm.DTO;

public class LoginVM
{
    [StringLength(20)]
    [Required]
    public string? UserName { get; set; }
    [StringLength(20)]
    [Required]
    public string? Password { get; set; }
}
