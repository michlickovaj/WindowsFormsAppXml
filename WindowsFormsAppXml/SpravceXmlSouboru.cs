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

    
    //  Metoda pro uložení souboru
    public void UlozitXmlSoubor(XDocument xmlDocument, TreeNode korenovyUzel, XElement korenovyElement, string filePath)
    {
        if (xmlDocument != null)
        {
            // Úprava názvů elementů pomocí metody ChangeNodeNames
            foreach (XElement childElement in korenovyElement.Elements())
                foreach (TreeNode uzel in korenovyUzel.Nodes)

                    childElement.Name = uzel.Text;

            // Uložení změněného XML dokumentu do souboru
            xmlDocument.Save(filePath);

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





