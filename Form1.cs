using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab7
{
    public partial class Form1 : Form
    {
        List<Propiedades> priopiedades = new List<Propiedades>();
        List<Priopietario> propietario = new List<Priopietario>();
        List<Resumen> resumen = new List<Resumen>();
        public Form1()
        {
            InitializeComponent();
        }

        private void CargarPropiedades()
        {
            FileStream stream = new FileStream(@"Propiedades.txt");
            StreamReader reader = new StreamReader(stream);

            while(reader.Peek()> -1)
            {
                Propiedades propiedad = new Propiedades();
                propiedad.numcasa = reader.ReadLine();
                propiedad.dpi = reader.ReadLine();
                propiedad.cuota=decimal.Parse(reader.ReadLine());

                priopiedades.Add(propiedad);
            }

            reader.Close();
        }

        private void CargarPropietarios()
        {
            FileStream stream = new FileStream(@"Propietarios.txt");
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Priopietario propietarios = new Priopietario();
                propietarios.dpi = reader.ReadLine();
                propietarios.nombre = reader.ReadLine();
                propietarios.apellido = reader.ReadLine();

                propietario.Add(propietarios);
            }

            reader.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            CargarPropietarios();
            CargarPropiedades();

            for(int i=0; i<priopiedades.Count; i++)
            {
                for(int j=0; j< propietario.Count; j++)
                {
                    if(priopiedades[i].dpi== propietario[j].dpi)
                    {
                        Resumen datosResumen = new Resumen();
                        datosResumen.nombre=propietario[j].nombre;
                        datosResumen.apellido = propietario[j].apellido;
                        datosResumen.numcasa = priopiedades[i].numcasa;
                        datosResumen.cuota = priopiedades[i].cuota;
                    }
                }
            }
        }
    }
}
