/****************************** Desafio 6 ******************************
 Desafio 6  : XML de Carros
 Autor    : Álex Prado
 Data     : 28 de outubro de 2017
 Versão   : 1.0
**********************************************************************/
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
        ElementoRaiz elementoRaiz;

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

        /// <summary>
        /// Deserializa o xml selecionado e adiciona os
        /// dados no ListView e nos ComboBoxes
        /// </summary>
        private void Deserializa()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ElementoRaiz));
            StreamReader reader = new StreamReader(txbCaminho.Text);
            object carsObject = serializer.Deserialize(reader);

            elementoRaiz = (ElementoRaiz)carsObject;

            /** Limpa o ListView e os ComboBoxes */
            lsvCarros.Items.Clear();
            cmbMarca.Items.Clear();
            cmbModelo.Items.Clear();
            cmbAno.Items.Clear();
            cmbPreco.Items.Clear();

            /** Adiciona valores sem filtro nos ComboBoxes */
            cmbMarca.Items.Add("-Todas as Marcas-");
            cmbModelo.Items.Add("-Todos os Modelos-");
            cmbAno.Items.Add("-Todos os Anos-");
            cmbPreco.Items.Add("-Todos os Preços-");

            /** percorre todos os carros e adiciona-os no ListView e nos ComboBoxes */
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

            /** Seleciona os valores sem filtros dos ComboBoxes */
            cmbMarca.SelectedIndex = 0;
            cmbModelo.SelectedIndex = 0;
            cmbAno.SelectedIndex = 0;
            cmbPreco.SelectedIndex = 0;
        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void cmbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void cmbAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void cmbPreco_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter();
        }

        /// <summary>
        /// Filtra os dados do ListView conforme seleções dos ComboBoxes
        /// </summary>
        private void filter()
        {
            /** Se algum dos comboboxes ainda não contém valor não faz nada */
            if (cmbMarca.SelectedItem == null
                || cmbModelo.SelectedItem == null
                || cmbAno.SelectedItem == null
                || cmbPreco.SelectedItem == null)
                return;

            lsvCarros.Items.Clear();
            List<Carro> listaFiltrada = cmbMarca.SelectedItem.Equals("-Todas as Marcas-")
                ? elementoRaiz.Carros.Carro : elementoRaiz.Carros.Carro.Where(x => x.Marca.Equals(cmbMarca.SelectedItem)).ToList();

            listaFiltrada = cmbModelo.SelectedItem.Equals("-Todos os Modelos-")
                ? listaFiltrada : listaFiltrada.Where(x => x.Modelo.Equals(cmbModelo.SelectedItem)).ToList();

            listaFiltrada = cmbAno.SelectedItem.Equals("-Todos os Anos-")
                ? listaFiltrada : listaFiltrada.Where(x => x.Ano.Equals(cmbAno.SelectedItem)).ToList();

            listaFiltrada = cmbPreco.SelectedItem.Equals("-Todos os Preços-")
                ? listaFiltrada : listaFiltrada.Where(x => x.Preco.Equals(cmbPreco.SelectedItem)).ToList();

            lsvCarros.Items.AddRange(listaFiltrada.Select(i => new ListViewItem(new string[] { i.Codigo, i.Marca, i.Modelo, i.Ano, string.Format("{0:C}", double.Parse(i.Preco.ToString())) })).ToArray());
        }
    }
}
