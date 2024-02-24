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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace WindowsFormsAppXml
{
    public partial class xmlForm : Form
    {
        SpravceXmlSouboru spravceXmlSouboru = new SpravceXmlSouboru();

        public xmlForm()
        {
            InitializeComponent();
        }
        // Obsluha události načtení hlavního formuláře
        
    private void otevritToolStripButton_Click(object sender, EventArgs e)
        {
            // Vyčištění TreeView
            xmlTreeView.Nodes.Clear();

            // Zobrazení OpenFileDialog pro výběr XML souboru
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Vyberte soubor";
                openFileDialog.Filter = "XML soubory (*.xml)|*.xml";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Načtení XML souboru
                    try
                    {
                        var xmlDocument = XDocument.Load(openFileDialog.FileName);

                        // Vytvoření kořenového uzlu
                        string rootElementName = xmlDocument.Root.Name.LocalName;
                        var root = new TreeNode(rootElementName);
                        xmlTreeView.Nodes.Add(root);

                        // Přidání uzlů do stromu
                        spravceXmlSouboru.AddNodes(xmlDocument.Root, root);
                        //načtení informací o souboru
                        ShowFileInfo(xmlDocument);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Chyba při otevírání souboru: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

       
        // Zobrazení informací o XML souboru
        private void ShowFileInfo(XDocument document)
        {
            // Název souboru bez cesty
            nazevSouboruLabel.Text = Path.GetFileName(document.BaseUri);

            // Hloubka nejzanorenějšího elementu
            hloubkaLabel.Text = document.Root.Descendants().Max(e => e.Ancestors().Count()).ToString();

            // Maximální počet přímých potomků, které nějaký element obsahuje
            maxPotomkuLabel.Text = document.Root.Descendants().Max(e => e.Elements().Count()).ToString();

            // Minimální počet atributů, které nějaký element obsahuje
            minAtributuLabel.Text = document.Root.Descendants().Min(e => e.Attributes().Count()).ToString();

            // Maximální počet atributů, které nějaký element obsahuje
            maxAtributuLabel.Text = document.Root.Descendants().Max(e => e.Attributes().Count()).ToString();
        }
       
        // Zobrazení informací o elementu
        private void ShowElementInfo(XElement element)
        {
            // Hloubka zanoření
            hloubkaElementuLabel.Text = element.Ancestors().Count().ToString();

            // Pořadí mezi sourozenci
            poradiLabel.Text = element.ElementsBeforeSelf().Count().ToString();

            // Názvy a hodnoty atributů
            atributyLabel.Text = string.Join(Environment.NewLine, element.Attributes().Select(a => $"{a.Name} = {a.Value}"));

            // Text, pokud jde o koncový element s textem
            if (element.HasElements)
            {
                textLabel.Text = string.Empty;
            }
            else
            {
                textLabel.Text = element.Value;
            }
        }
        
        // Modifikace XML dokumentu
        private XDocument ModifyDocument(XDocument document)
        {
            // Změna názvů uzlů podle TreeView
            spravceXmlSouboru.ChangeNodeNames(document.Root, xmlTreeView.Nodes[0]);

            return document;
        }

        // Obsluha události kliknutí na tlačítko "Uložit"
        private void ulozitToolStripButton_Click(object sender, EventArgs e)
        {// Zobrazení SaveFileDialog pro uložení XML souboru
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML files (*.xml)|*.xml";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Uložení XML souboru se změněnými názvy elementů
                try
                {
                    XDocument modifiedDocument = ModifyDocument(XDocument.Load(xmlTreeView.Nodes[0].Text));
                    modifiedDocument.Save(saveFileDialog.FileName);
                    MessageBox.Show("Soubor byl úspěšně uložen.", "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Chyba při ukládání souboru: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    
        // Obsluha události kliknutí na tlačítko "Zavřít"
        private void zavritToolStripButton_Click(object sender, EventArgs e)
        {// Vyprázdnění TreeView a Labelů
            xmlTreeView.Nodes.Clear();
            nazevSouboruLabel.Text = string.Empty;
            hloubkaLabel.Text = string.Empty;
            maxPotomkuLabel.Text = string.Empty;
            minAtributuLabel.Text = string.Empty;
            maxAtributuLabel.Text = string.Empty;
            hloubkaElementuLabel.Text = string.Empty;
            poradiLabel.Text = string.Empty;
            atributyLabel.Text = string.Empty;
            textLabel.Text = string.Empty;

        }

    }
}



  

