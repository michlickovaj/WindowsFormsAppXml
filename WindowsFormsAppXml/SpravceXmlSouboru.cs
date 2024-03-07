using System;
using System.Linq;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

internal class SpravceXmlSouboru
{
    // Přidání uzlů do stromu
    public void AddNodes(XElement element, TreeNode node)
    {
        foreach (var childElement in element.Elements())
        {
            var childNode = new TreeNode(childElement.Name.LocalName);

            if (childElement.HasElements)
            {
                childNode.ImageKey = "vetviciUzel";
                childNode.SelectedImageKey = "vetviciUzel";
                AddNodes(childElement, childNode); // Rekurzivně přidáme potomky
            }
            else
            {
                childNode.ImageKey = "koncovyUzel";
                childNode.SelectedImageKey = "koncovyUzel";
            }

            node.Nodes.Add(childNode);
        }
    }
   

    // Metoda pro uložení souboru
    public void UlozitXmlSoubor(XDocument xmlDocument, TreeNode node, string filePath)
    {
        if (xmlDocument != null && node != null)
        {
            // Úprava názvů elementů pomocí metody ChangeNodeNames
            foreach (TreeNode childelement in node.Nodes)
            {
               childelement.Name = node.Text;
               
            }
            xmlDocument.Save(filePath);
            // Uložení změněného XML dokumentu do souboru

        }
        else
        {
            Console.WriteLine("xmlDocument nebo node je null.");
        }
    }

    //Metoda pro vyběr elmentu
    public XElement FindElementByNode(XElement rootElement, string nodeName)
    {
        if (rootElement.Name.LocalName == nodeName)
        {
            return rootElement;
        }
        else
        {
            foreach (XElement childElement in rootElement.Elements())
            {
                XElement result = FindElementByNode(childElement, nodeName);
                if (result != null)
                {
                    return result;
                }
            }
        }

        return null;
    }
   
    
        
 




}





