﻿using System.ComponentModel.DataAnnotations;

namespace Api.Request
{
    public class RegisterRequest
    {
        [Required(ErrorMessage = "Campo requerido")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [RegularExpression(@"\A[\w|.|-]+@[\w|.|-]+\Z", ErrorMessage = "El formato no corresponde al de una dirección de correo")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "La contraseña debe contener al menos {2} caracteres", MinimumLength = 6)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Las contraseñas no coinciden")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public string Idioma { get; set; }
    }
}
