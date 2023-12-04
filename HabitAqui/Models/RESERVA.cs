namespace HabitAqui.Models
{
    public class RESERVA
    {
        public int Id_res { get; set; }
        public UTILIZADOR Id_uti { get; set; }
        public HABITACAO Id_habi { get; set; }
        public DateTime In_cont { get; set; }
        public DateTime Fim_cont { get; set;}
        public Boolean Est_res { get; set; }
        public int Class {  get; set; }
        public String Review { get; set; }
    }
}
