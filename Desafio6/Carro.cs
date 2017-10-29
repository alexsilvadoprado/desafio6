/****************************** Desafio 6 ******************************
 Desafio 6  : XML de Carros
 Autor    : Álex Prado
 Data     : 28 de outubro de 2017
 Versão   : 1.0
**********************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Desafio6
{
    [XmlRoot(ElementName = "Carro")]
    public class Carro
    {
        [XmlElement(ElementName = "Codigo")]
        public string Codigo { get; set; }
        [XmlElement(ElementName = "Marca")]
        public string Marca { get; set; }
        [XmlElement(ElementName = "Modelo")]
        public string Modelo { get; set; }
        [XmlElement(ElementName = "Ano")]
        public string Ano { get; set; }
        [XmlElement(ElementName = "Preco")]
        public string Preco { get; set; }
    }

    [XmlRoot(ElementName = "Carros")]
    public class Carros
    {
        [XmlElement(ElementName = "Carro")]
        public List<Carro> Carro { get; set; }
    }

    [XmlRoot(ElementName = "ElementoRaiz")]
    public class ElementoRaiz
    {
        [XmlElement(ElementName = "DataCriacao")]
        public string DataCriacao { get; set; }
        [XmlElement(ElementName = "Carros")]
        public Carros Carros { get; set; }
    }
}
