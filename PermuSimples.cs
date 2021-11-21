namespace Calculo_CPE{
    public class PermuSimples{
        public int PermutacaoSimples(int numElements){
            int saida = 1;

            for(int i = 1; i <= numElements; i++)
            {
                saida *= i;
            }

            return saida;
        }
    }
}