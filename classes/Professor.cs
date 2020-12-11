using System;
namespace AulaPOO_PolimosrfismoSobreposicao.classes
{
    public class Professor : Taxas
    {
        public string turma;

        public override void ValeRefeicao(){

            Console.WriteLine($"A taxa do professor é de 10%"); 
        }
    }
}