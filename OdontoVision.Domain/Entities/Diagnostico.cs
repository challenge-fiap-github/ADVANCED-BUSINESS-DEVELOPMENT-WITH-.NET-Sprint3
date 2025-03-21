using System;  // Adicionado para DateTime

namespace OdontoVision.Domain.Entities
{
    public class Diagnostico
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }  // DateTime agora é reconhecido
        public int PacienteId { get; set; }
        public int DentistaId { get; set; }
    }
}
