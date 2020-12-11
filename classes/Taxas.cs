using System;
namespace AulaPOO_PolimosrfismoSobreposicao.classes
{
    public abstract class Taxas
    {
        private float valores;
        public virtual void ValeRefeicao(){
            Console.WriteLine($"A taxa ser a paga é de 5%");
            
        }
    }
}