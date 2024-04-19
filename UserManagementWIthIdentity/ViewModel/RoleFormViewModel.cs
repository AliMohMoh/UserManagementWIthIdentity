using System.ComponentModel.DataAnnotations;

namespace UserManagementWIthIdentity.ViewModel;

public class RoleFormViewModel
{
    [Required, StringLength(256)]
    public string Name { get; set; }
}
