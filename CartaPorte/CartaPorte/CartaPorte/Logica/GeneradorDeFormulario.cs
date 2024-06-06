using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace CartaPorte.Logica
{
    public static class GeneradorDeFormulario
    {
        public static int y = 0;
        public static int x = 0;
        public static void Generar(Panel PanelPrincipal, string Xml, int xVal, int yVal)
        {
            PanelPrincipal.Controls.Clear();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(Xml);
            x = xVal;
            y = yVal;
            RecursiveGenerator(xmlDoc.DocumentElement, PanelPrincipal);
        }

        public static void RecursiveGenerator(XmlNode node, Control parentControl)
        {
            parentControl.Controls.Add(Title(FormatText(node.Name)));
            y += 50;
            if (node.NodeType == XmlNodeType.Element)
            {
                XmlAttributeCollection attributes = node.Attributes;
                foreach (XmlAttribute attribute in attributes)
                {
                    parentControl.Controls.Add(Section(attribute.Name, attribute.InnerText));
                    y += 50;
                }
            }
            if (node.HasChildNodes)
            {
                XmlNodeList children = node.ChildNodes;
                foreach (XmlNode child in children)
                {
                    y += 50;
                    RecursiveGenerator(child, parentControl);
                }
            }
        }
        public static Panel Section(string name, string value) {
            Panel Section = new Panel();
            Section.Name = name;
            Section.Left = x;
            Section.Top = y;
            Label label = NewLabel(name);
            Section.Controls.Add(label);
            Section.Controls.Add(NewTextBox(name, value));
            Section.Height = 40;
            Section.Width = 1000;
            return Section;
        }

        public static Label Title(string text)
        {
            Label title = new Label();
            title.Text = text.Split(':')[1];
            title.Font = new Font(title.Font.FontFamily, 16, FontStyle.Bold);
            title.AutoSize = true;
            title.Left = x;
            title.Top = y;
            return title;
        }

        public static Label NewLabel(string text)
        {
            Label label = new Label();
            string formatted_text = FormatText(text);
            label.Text = formatted_text;
            label.Left = 10;
            label.Top = 5;
            
            // Obtener el tamaño del texto
            Size textSize = TextRenderer.MeasureText(formatted_text, label.Font);
            label.Width = textSize.Width;
            
            return label;
        }

        public static TextBox NewTextBox(string name, string value) { 
            TextBox textBox = new TextBox();
            textBox.Name = name;
            textBox.Text = value;
            textBox.Left = 250;
            textBox.Width = 300;
            textBox.Top = 0;
            return textBox;
        }

        public static string FormatText(string text)
        {
            string formatted_text = Regex.Replace(text, @"(\B[A-Z])", " $1");
            formatted_text = char.ToUpper(formatted_text[0]) + formatted_text.Substring(1);
            return formatted_text;
        }

    }
}
