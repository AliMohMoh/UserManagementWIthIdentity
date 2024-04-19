using System.ComponentModel.DataAnnotations;

namespace UserManagementWIthIdentity.ViewModel;

public class UsersVM
{
    public string? Id { get; set; }

    [Required]
    public string UserName { get; set; }
    [Required]
    public string Email { get; set; }
    [Required]
    public string Password { get; set; }
    [Compare("Password")]
    public string ConfirmPassword { get; set; }
    public IEnumerable<string>? NameRoles { get; set; }
    public List<CheckBoxViewModel>? Roles { get; set; }
}
