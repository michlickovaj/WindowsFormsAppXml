using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsAppXml
{
    internal class SpravceXmlSouboru
    {
        // Přidání uzlů do stromu
        public void AddNodes(XElement element, TreeNode node)
        {
            foreach (var child in element.Elements())
            {
                var childNode = node.Nodes.Add(child.Name.LocalName);

                if (child.HasElements)
                {
                    // Pokud má prvek potomky, označíme ho jako větvový uzel
                    childNode.ImageKey = "vetviciUzel";
                    childNode.SelectedImageKey = "vetviciUzel";
                    AddNodes(child, childNode); // Rekurzivně přidáme potomky
                }
                else
                {
                    // Pokud nemá prvek potomky, označíme ho jako koncový uzel
                    childNode.ImageKey = "koncovyUzel";
                    childNode.SelectedImageKey = "koncovyUzel";
                }
            }
        }

       

        // Změna názvů uzlů
        public void ChangeNodeNames(XElement element, TreeNode node)
        {
            element.Name = node.Text;

            foreach (TreeNode childNode in node.Nodes)
            {
                var childElement = element.Elements().FirstOrDefault(e => e.Name.LocalName == childNode.Text);
                if (childElement != null)
                {
                    ChangeNodeNames(childElement, childNode);
                }
            }
        }
    }
}
        
    
