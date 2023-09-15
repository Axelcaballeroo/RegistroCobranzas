using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistroCobranzas
{

    
    public partial class Consultar : System.Web.UI.Page
    {
        public class Cobro
        {
            public string nombre;
            public string apellido;
            public string fecha;
            public int monto;

            public Cobro(string nombre, string apellido, string fecha, int monto)
            {
                this.nombre = nombre;
                this.apellido = apellido;
                this.fecha = fecha;
                this.monto = monto;

            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {

            
            if (File.Exists(Server.MapPath(".")+"/archivo.txt")) 
            {
                StreamReader streamReader = new StreamReader(Server.MapPath(".") + "/archivo.txt");
                string[] lines = (streamReader.ReadToEnd()).Split('\n');
                streamReader.Close();
                Label1.Text = "<hr>";
                int lineCount = 0;
                List<Cobro> listCobro = new List<Cobro>();


                foreach(string line in lines)
                {
                    lineCount++;
                    if (lineCount%4 == 0 )
                    {
                        //Label1.Text += $"{line} <br/>";
                        //Label1.Text += "<hr>";
                        string nombre = lines[lineCount - 4].ToString().TrimEnd('\r');
                        string apellido = lines[lineCount - 3].ToString().TrimEnd('\r'); 
                        string fecha = lines[lineCount - 2].ToString().TrimEnd('\r'); 
                        int monto = int.Parse(lines[lineCount - 1].ToString().TrimEnd('\r')); 
                        Cobro cobro = new Cobro(nombre, apellido, fecha, monto);
                        listCobro.Add(cobro);

                    }
                    


                }
                    listCobro.Sort((a, b) => b.monto.CompareTo(a.monto));
                    foreach (Cobro cobro in listCobro)
                    {
                        
                        Label1.Text += $"{cobro.nombre.ToString()}"+"<br>";
                        Label1.Text += $"{cobro.apellido.ToString()}"+"<br>";
                        Label1.Text += $"{cobro.fecha.ToString()}"+"<br>";
                        Label1.Text += $"{cobro.monto.ToString()}"+"<br>";
                        Label1.Text += "<hr>";
                    }




                }
            else
            {
                Label1.Text = "No se encontraron datos.";
            }

           

        }
        }
    }
}