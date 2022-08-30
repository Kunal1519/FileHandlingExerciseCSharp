using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingExercise
{
    public class EnumWithFileHandling
    {
        public void FileCreator()
        {
            StreamWriter sw;
            string? language;
            int count = Enum.GetValues(typeof(Languages)).Length;
            for (int i = 0; i < count; i++)
            {
                language = Enum.GetValues(typeof(Languages)).GetValue(i).ToString();
                Console.WriteLine(language);
                Directory.CreateDirectory(@"C:\Users\HP\OneDrive\Documents\Kunal(Projects)\Languages");
                Directory.CreateDirectory(@"C:\Users\HP\OneDrive\Documents\Kunal(Projects\Languages\" + language);
                sw = new StreamWriter(@"C:\Users\HP\OneDrive\Documents\Kunal(Projects)\Languages\" + language + @"\log.txt");
                sw.WriteLine("File no " + i + " Created on " + DateTime.Now);
                sw.Close();
            }
        }
    }
    enum Languages
    {
        Hindi,
        English,
        Punjabi,
        Chanies,
        Urdu,
        Bangali
    }
}
