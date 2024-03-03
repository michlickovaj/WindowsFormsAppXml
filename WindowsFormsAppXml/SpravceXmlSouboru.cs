using System;
using System.Linq;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Xml;

internal class SpravceXmlSouboru
{
    // Přidání uzlů do stromu
    public void AddNodes(XElement element, TreeNode node)
    {
        var childNodes = element.Elements().Select(child => new TreeNode(child.Name.LocalName)).ToArray();
        node.Nodes.AddRange(childNodes);

        foreach (var pair in element.Elements().Zip(childNodes, (el, nd) => (el, nd)))
        {
            if (pair.el.HasElements)
            {
                pair.nd.ImageKey = "vetviciUzel";
                pair.nd.SelectedImageKey = "vetviciUzel";
                AddNodes(pair.el, pair.nd); // Rekurzivně přidáme potomky
            }
            else
            {
                pair.nd.ImageKey = "koncovyUzel";
                pair.nd.SelectedImageKey = "koncovyUzel";
            }
        }
    }

    // Změna názvů uzlů   
    public void ChangeNodeNames(XElement element, TreeNode node)
    {
        element.Name = node.Text; // Změna názvu aktuálního elementu

        // Procházení všech potomků aktuálního elementu
        foreach (var childElement in element.Elements())
        {
            // Hledání odpovídajícího uzlu v TreeView podle názvu
            var correspondingNode = node.Nodes.Cast<TreeNode>().FirstOrDefault(n => n.Text == childElement.Name.LocalName);
            if (correspondingNode != null)
            {
                // Rekurzivní volání ChangeNodeNames pro každého potomka
                ChangeNodeNames(childElement, correspondingNode);
            }
        }
    }
    //  Metoda pro uložení souboru
    public void UlozitXmlSoubor(XDocument xmlDocument, TreeNode rootNode, string filePath)
    {
        if (xmlDocument != null)
        {
            
            
            // Úprava názvů elementů pomocí metody ChangeNodeNames
            ChangeNodeNames(xmlDocument.Root, rootNode);

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





