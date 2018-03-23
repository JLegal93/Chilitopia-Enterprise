using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Windows;
namespace Chilitopia_Enterprise
{
    class Globals
    {
        private String dbName, dbuser, dbpass, dbserver;
        public Globals()
        {
            Leer_conex_bd();
        }
        private void Leer_conex_bd()
        {

            StreamReader objReader = new StreamReader("conexion.txt");
            string sLine = "";
            ArrayList arrText = new ArrayList();
            while (sLine != null)
            {
                sLine = objReader.ReadLine();
                if (sLine != null)
                    arrText.Add(sLine);
            }
            dbserver = arrText[0].ToString();
            dbName = arrText[1].ToString();
            dbuser = arrText[2].ToString();
            dbpass = arrText[3].ToString();
            objReader.Close();
            //MessageBox.Show(arrText[0].ToString(), "Chilitopia Enterprise"); 
        }
        public string DbName { get => dbName;}
        public string Dbuser { get => dbuser;}
        public string Dbpass { get => dbpass;}
        public string Dbserver { get => dbserver;}
    }
}
