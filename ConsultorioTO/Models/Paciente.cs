namespace ConsultorioTO.Models
{
    public class Paciente : Entidades
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string DataNascimento { get; set; }
        public string Dua { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Uf { get; set; }
        public int ResponsavelId { get; set; }
    }
}
