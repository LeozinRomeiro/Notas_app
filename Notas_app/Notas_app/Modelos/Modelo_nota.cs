using SQLite;
using System;

namespace Notas_app.Modelos
{
    [Table("Anotacoes")]
    public class Modelo_nota
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }=0;
        [NotNull] public string Titulo { get; set; } = string.Empty;
        [NotNull] public string Corpo { get; set; } = string.Empty;
        [NotNull] public Boolean Favorito { get; set; } = false;

        public Modelo_nota()
        {
        }
    }
}
