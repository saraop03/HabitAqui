﻿namespace HabitAqui.Models
{
    public class UTILIZADOR
    {
        public int Id_uti { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string? Empresa { get; set; }
    }
}
