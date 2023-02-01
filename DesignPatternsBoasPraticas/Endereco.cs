using Newtonsoft.Json;

namespace DesignPatternsBoasPraticas
{
    internal class Endereco
    {
        public Endereco()
        {

        }

        public Endereco(string logradouro, string bairro, string cidade, string uf, string cep, string codIbge, string ddd)
        {
            this.logradouro = logradouro;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            Cep = cep;
            CodIbge = codIbge;
            Ddd = ddd;
        }
        public string logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Cep { get; set; }
        public string CodIbge { get; set; }
        public string Ddd { get; set; }

        public override string ToString()
        {
            return $"Logradouro: {logradouro} Bairro:{Bairro} Localidade:{Cidade}";
        }
    }
}
