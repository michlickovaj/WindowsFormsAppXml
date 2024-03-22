using System;
using System.Linq;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections.Generic;

internal class SpravceXmlSouboru
{
    // Metoda pro přidávání uzlů do stromu
    public void AddNodes(XElement element, TreeNode node)
    {
        foreach (var childElement in element.Elements())
        {
            var childNode = new TreeNode(childElement.Name.LocalName);
            childNode.Tag = childElement.Name;

            if (childElement.HasElements)
            {
                childNode.ImageKey = "vetviciUzel";
                childNode.SelectedImageKey = "vetviciUzel";
                AddNodes(childElement, childNode);
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





