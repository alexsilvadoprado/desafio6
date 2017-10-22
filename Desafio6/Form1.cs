using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Desafio6
{
    public partial class frmDesafio6 : Form
    {
        public frmDesafio6()
        {
            InitializeComponent();
        }

        private void btnPickXml_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.ShowDialog();

            if (File.Exists(fd.FileName))
            {
                txbCaminho.Text = fd.FileName;
                Deserializa();
            }
            else
            {
                MessageBox.Show("Arquivo não existe");
            }
        }

        private void Deserializa()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ElementoRaiz));
            StreamReader reader = new StreamReader(txbCaminho.Text);
            object carsObject = serializer.Deserialize(reader);

            ElementoRaiz elementoRaiz = (ElementoRaiz)carsObject;

            lsvCarros.Items.Clear();
            cmbMarca.Items.Clear();
            cmbModelo.Items.Clear();
            cmbAno.Items.Clear();
            cmbPreco.Items.Clear();

            foreach (var carro in elementoRaiz.Carros.Carro)
            {
                ListViewItem item = new ListViewItem(new string[] { carro.Codigo, carro.Marca, carro.Modelo, carro.Ano, string.Format("{0:C}", double.Parse(carro.Preco.ToString())) });
                lsvCarros.Items.Add(item);

                if (!cmbMarca.Items.Contains(carro.Marca))
                    cmbMarca.Items.Add(carro.Marca);

                if (!cmbModelo.Items.Contains(carro.Modelo))
                    cmbModelo.Items.Add(carro.Modelo);

                if (!cmbAno.Items.Contains(carro.Ano))
                    cmbAno.Items.Add(carro.Ano);

                if (!cmbPreco.Items.Contains(carro.Preco))
                    cmbPreco.Items.Add(carro.Preco);
            }
        }
    }
}
