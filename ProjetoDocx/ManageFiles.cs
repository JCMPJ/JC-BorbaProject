using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDocx
{
    internal class ManageFiles
    {
        public static string homepag = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        public static string appPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);


        public static bool FileExists(string filename)
        {
            try
            {

                if (File.Exists(filename))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
            
        
        public static string CreateDirectories(string dirname)
        {
            string pasta = dirname;
            try
            {
                
                if (!Directory.Exists(pasta))
                {
                    //try to create directory            
                    DirectoryInfo pastacriada = Directory.CreateDirectory(pasta);
                    Console.WriteLine("Pasta criada :..." + pastacriada.FullName);

                    return pastacriada.FullName;
                }
                else
                {
                    return pasta;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Não foi possível criar o diretório: {0}\n", e.Message);
                return null;
            }
        }

        public static string DeleteDirectories(string folder)
        {
            string pasta = folder;
            if (!Directory.Exists(homepag + "\\Documents\\laudos\\" + pasta))
            {
                try
                {
                    //Delete the directory.
                    DirectoryInfo dir = new DirectoryInfo(homepag + "\\Documents\\laudos\\" + pasta);
                    dir.Delete();
                    Console.WriteLine("The directory was deleted successfully.");
                    return pasta;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
            }
            return null;
        }
    }
}
