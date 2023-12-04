namespace HabitAqui.Models
{
    public class HABITACAO
    {
        public int Id_habi { get; set; }
        public string Tipo_habi { get; set; }    
        public string Loc { get; set; }
        public decimal Custo { get; set; }
        public string Aval_loc { get; set; }
        public UTILIZADOR Id_uti {  get; set; }
    }
}
