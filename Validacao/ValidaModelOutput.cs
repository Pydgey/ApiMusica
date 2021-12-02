namespace ProjectStipofy.Validacao
{
    public class ValidaModelOutput
    {
        public IEnumerable<string> Erros { get; set; }

        public ValidaModelOutput(IEnumerable<string> erros)
        {
            Erros = erros;
        }
    }
}
