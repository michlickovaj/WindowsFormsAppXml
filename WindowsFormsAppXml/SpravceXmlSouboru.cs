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
    public void UlozitXmlSoubor(XDocument xmlDocument, TreeNode korenovyUzel, string filePath)
    {
        if (xmlDocument != null)
        {

            AktualizujXML(korenovyUzel, xmlDocument.Root);
            xmlDocument.Save(filePath);
            // Uložení změněného XML dokumentu do souboru

        }
        

    }
    public void AktualizujXML(TreeNode korenovyUzel, XElement korenovyElement)
    {
        if (korenovyElement.Name != korenovyUzel.Text)
        {
            korenovyElement.Name = korenovyUzel.Text;
        }

        foreach (TreeNode node in korenovyUzel.Nodes)
        {
            if (node.Tag == null)
            {
                continue; // Pokračujeme k dalšímu uzlu, pokud není nastaven Tag
            }
            string puvodniNazev = node.Tag.ToString();
            XElement odpovidajiciElement = korenovyElement.Element(puvodniNazev);
            if (odpovidajiciElement != null && odpovidajiciElement.Name != node.Text)
            { odpovidajiciElement.Name = node.Text; }
            if (node.Nodes.Count > 0)
            {
                AktualizujXML(node, odpovidajiciElement);
            }
        }
    }


    //Metoda pro vyběr elmentu
    public XElement HledejElementPodleNazvuNode(XElement rootElement, string nodeName)
    {
        if (rootElement.Name.LocalName == nodeName)
        {
            return rootElement;
        }
        else
        {
            foreach (XElement childElement in rootElement.Elements())
            {
                XElement hledanyElement= HledejElementPodleNazvuNode(childElement, nodeName);
                if (hledanyElement != null)
                {
                    return hledanyElement;
                }
            }
        }
        return null;
    }
   
    
        
 




}





