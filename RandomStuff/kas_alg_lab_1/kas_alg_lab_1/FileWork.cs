using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace kas_alg_lab_1
{
    public class FileWork
    {
        public static List<MyDict> listMyDict;
        public static void ReadFile(ref MyDict[] myDict, string filename)
        {
            try
            {
                int i = 0;
                StreamReader file = new StreamReader(filename);
                string line;
                char[] separators = { ';', ':' };
                string[] buf;
                while ((line = file.ReadLine()) != null)
                {
                    buf = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    try
                    {
                        if (buf.Length != 2)
                            throw new Exception("Error, in line more or less than 2 separators");
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                    i++;
                    Array.Resize<MyDict>(ref myDict, i);
                    myDict[i - 1] = new MyDict(buf[0], buf[1]);
                }
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show(e.Message + "Check correctness name file");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
        
        
   

