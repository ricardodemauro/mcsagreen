using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;

namespace Green.AlbumCopa.Data
{
    public static class AlbumDataHelper
    {
        internal static IEnumerable<Dictionary<string, string>> GetJogadores()
        {
            string pathCsv = ConfigurationManager.AppSettings["pathCSV"];

            List<Dictionary<string, string>> jogadoresCollection = new List<Dictionary<string, string>>();
            if (!File.Exists(pathCsv))
                return jogadoresCollection;

            using (FileStream fs = new FileStream(pathCsv, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (StreamReader reader = new StreamReader(fs))
                {
                    reader.BaseStream.Seek(0, SeekOrigin.Begin);
                    while (reader.Peek() > -1)
                    {
                        string line = reader.ReadLine();
                        string[] args = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        if (args.Length == 9)
                        {
                            Dictionary<string, string> jogador = new Dictionary<string, string>();
                            jogador.Add("SELECAO", args[0]);
                            jogador.Add("NUMERO", args[1]);
                            jogador.Add("POSICAO", args[2]);
                            jogador.Add("FIFA NAME", args[3]);
                            jogador.Add("DATA NASC", args[4]);
                            jogador.Add("NOME CAMISA", args[5]);
                            jogador.Add("CLUB", args[6]);
                            jogador.Add("ALTURA", args[7]);
                            jogador.Add("PESO", args[8]);
                            jogadoresCollection.Add(jogador);
                        }
                    }
                }
            }
            return jogadoresCollection;
        }
    }
}