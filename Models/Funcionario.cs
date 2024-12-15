using WebApi_Video.Models.Enums;

namespace WebApi_Video.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Sobrenome { get; set; } = null!;
        public DepartamentoEnum Departamento { get; set; }
        public bool Ativo { get; set; }
        public TurnoEnum Turno { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.Now.ToLocalTime();
        public DateTime DataAlteracao { get; set; } = DateTime.Now.ToLocalTime();
    }
}
