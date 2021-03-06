﻿using System.ComponentModel.DataAnnotations;

namespace Dental.ViewModels
{
    public class CreateRoleViewModel
    {
        [Required(ErrorMessage = "Proszę podać rolę")]
        [Display(Name = "Rola")]
        public string RoleName { get; set; }
    }
}
