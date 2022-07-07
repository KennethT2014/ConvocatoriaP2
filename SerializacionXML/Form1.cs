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
using System.Xml.Serialization;

namespace SerializacionXML
{
    
    public partial class Form1 : Form
    {
        Personal miPersonal = null;
        Stream miStream = null;
        XmlSerializer formateador = null;

        int codigo;
        string nombre, direccion;
        float salario, comision;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            Converter.
            miPersonal.Codigo = codigo(txtCodigo);
        }

        private void CrearFichero_Click(object sender, EventArgs e)
        {
            miPersonal = new Personal();
            miPersonal.Codigo = codigo;
            miPersonal.Nombre = nombre;
            miPersonal.Direccion = direccion;
            miPersonal.Salario = salario;
            miPersonal.Comision = comision;

            formateador = new XmlSerializer(typeof(Personal));

            miStream = new FileStream("Personal.au", FileMode.Create, FileAccess.Write, FileShare.None);
            formateador.Serialize(miStream, miPersonal);
            miStream.Close();
        }

        private void VerPersonal_Click(object sender, EventArgs e)
        {
            formateador = new XmlSerializer(typeof(Personal));
            miStream = new FileStream("Personal.au", FileMode.Open, FileAccess.Read, FileShare.none);

            miPersonal = (Personal)formateador.Deserialize(miStream);

            miStream.Close();

            miPersonal.MuestraInformacion();
        }
    }
}
