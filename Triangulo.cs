
namespace CursoUdemmy2// name space da classe
{
  class Triangulo// nome da classe
    {
        //atributos da classe
        public double A;
        public double B;
        public double C;


        //public indica que atributo ou metodo pode ser usado em outros arquivos
        public double Area() { //nome do metodo,lista de parametros do metodo, tipo de daodo que o metodo retorna
            double p = (A + B + C) / 2.0;
            return  Math.Sqrt(p * (p-A) * (p-B) * (p-C));//formula de heron, corpo do metodo
            
        }
    }
}
