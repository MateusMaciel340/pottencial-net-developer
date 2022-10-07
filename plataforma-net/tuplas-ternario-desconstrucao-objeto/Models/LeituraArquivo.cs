using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tuplas_ternario_desconstrucao_objeto.Models
{
    public class LeituraArquivo
    {
        // [1.4]: Tupla em métodos
        public (bool Sucesso, string[] Linhas, int QuantidadeLinhas) LerArquivo(string caminho)
        {
            try
            {
                string[] linhas = File.ReadAllLines(caminho);

                return (true, linhas, linhas.Count());
            }
            catch(Exception)
            {
                return (false, new string[0], 0);
            }

        }
    }
}