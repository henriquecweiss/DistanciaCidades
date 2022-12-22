using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeCS
{
    internal class ReadFiles
    {
        public void SaveMatriz()
        {
            var caminhoDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var nomeArquivo = "matriz.txt";

            var caminhoArquivo = Path.Combine(caminhoDesktop, nomeArquivo);

            var conteudo = this.ToString();

            File.WriteAllText(caminhoArquivo, conteudo);
        }

        public void SaveCaminho()
        {
            var caminhoDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var nomeArquivo = "caminho.txt";

            var caminhoArquivo = Path.Combine(caminhoDesktop, nomeArquivo);

            var conteudo = this.ToString();

            File.WriteAllText(caminhoArquivo, conteudo);
        }
    }
}
