using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BrinquedoPOO
{
    //-Adicionar: Recebe objeto como parâmetros
    //-Remover: Recebe objeto como parâmetros
    //-Listar: Retorna a lista de objetos
    public class BrinquedoExecucao
    {
        private List<Brinquedo> listaBrinquedo = 
                    new List<Brinquedo>();

        public void Adicionar(Brinquedo value)
        {
            listaBrinquedo.Add(value);
        }
        public void Remover(Brinquedo value)
        {
            listaBrinquedo.Remove(value);
        }
        public List<Brinquedo> Listar()
        {
            return listaBrinquedo;
        }
    }
}
