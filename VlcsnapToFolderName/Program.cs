using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrdnerDatei;

namespace VlcsnapToFolderName
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1) return;

            Ordner ordner = new Ordner(args[0], true);
            Datei[] dateien = ordner.GetDateien();

            if (dateien.Length == 0) return;

            foreach(Datei datei in dateien)
            {
                string newPath = datei.GetDirectoryName() + "\\" + datei.GetFileName().Replace("vlcsnap-", ordner.Name + " ");
                datei.MoveTo(newPath);
            }
        }
    }
}
