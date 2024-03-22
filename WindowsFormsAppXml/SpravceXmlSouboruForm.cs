using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using System;
using System.Linq;
using System.Windows.Forms.VisualStyles;
using System.Collections.Generic;

namespace WindowsFormsAppXml
{
    public partial class xmlForm : Form
    {
        private readonly SpravceXmlSouboru spravceXmlSouboru = new SpravceXmlSouboru();
        private XDocument xmlDocument;
        public xmlForm()
        {

            InitializeComponent();
        }
            
    

        // Obsluha události otevření souboru
        private void otevritToolStripButton_Click(object sender, EventArgs e)
        {
            xmlTreeView.Nodes.Clear();
            nazevSouboruLabel.Text = hloubkaLabel.Text = maxPotomkuLabel.Text = minAtributuLabel.Text = maxAtributuLabel.Text = hloubkaElementuLabel.Text = poradiLabel.Text = atributyLabel.Text = textLabel.Text = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Vyberte soubor";
                openFileDialog.Filter = "XML soubory (*.xml)|*.xml";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        xmlDocument = XDocument.Load(openFileDialog.FileName); 
                        string rootElementName = xmlDocument.Root.Name.LocalName;
                        var root = new TreeNode(rootElementName);
                        xmlTreeView.Nodes.Add(root);
                        spravceXmlSouboru.AddNodes(xmlDocument.Root, root);
                        xmlTreeView.ExpandAll();
                        ShowFileInfo(xmlDocument, openFileDialog);
                       
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Chyba při otevírání souboru: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Zobrazení informací o XML souboru
        private void ShowFileInfo(XDocument document, OpenFileDialog openFileDialog)
        {
            nazevSouboruLabel.Text = System.IO.Path.GetFileName(openFileDialog.FileName);
            hloubkaLabel.Text = document.Root.Descendants().Max(e => e.Ancestors().Count()).ToString();
            maxPotomkuLabel.Text = document.Root.Descendants().Max(e => e.Elements().Count()).ToString();
            minAtributuLabel.Text = document.Root.Descendants().Min(e => e.Attributes().Count()).ToString();
            maxAtributuLabel.Text = document.Root.Descendants().Max(e => e.Attributes().Count()).ToString();
        }

        // Obsluha události kliknutí na tlačítko "Uložit"
        private void ulozitToolStripButton_Click(object sender, EventArgs e)
        {
            if (xmlDocument != null)
                
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "XML files (*.xml)|*.xml";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {   spravceXmlSouboru.UlozitXmlSoubor(xmlDocument, xmlTreeView.Nodes[0], saveFileDialog.FileName);

                            MessageBox.Show("Soubor byl úspěšně uložen.", "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Chyba při ukládání souboru: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            else
            { MessageBox.Show("Není vybrán žádný soubor"); }
        }

        // Obsluha události kliknutí na tlačítko "Zavřít"
        private void zavritToolStripButton_Click(object sender, EventArgs e)
        {
            xmlTreeView.Nodes.Clear();
            nazevSouboruLabel.Text = hloubkaLabel.Text = maxPotomkuLabel.Text = minAtributuLabel.Text = maxAtributuLabel.Text = hloubkaElementuLabel.Text = poradiLabel.Text = atributyLabel.Text = textLabel.Text = string.Empty;
            xmlDocument = null;
        }
        //Uložení původního názvu uzlu při jeho změně
        private void xmlTreeView_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            
            if (string.IsNullOrEmpty(e.Label))
            {               
                e.CancelEdit = true;
                MessageBox.Show("Název nemůže být prázdný.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    
        
        // Zbrazení informací o elementech
        private void xmlTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            {
                XElement element = spravceXmlSouboru.HledejElementPodleNazvuNode(xmlDocument.Root, e.Node.Text); 
                if (element != null)
                {
                    hloubkaElementuLabel.Text = element.AncestorsAndSelf().Count().ToString();
                    Console.WriteLine(hloubkaElementuLabel.Text);
                    poradiLabel.Text = (element.ElementsBeforeSelf().Count() + 1).ToString();
                    string attributesInfo = "";
                    foreach (XAttribute attribute in element.Attributes())
                    {
                        attributesInfo += $"{attribute.Name}: {attribute.Value}\n";
                    }
                    atributyLabel.Text = attributesInfo;
                    if (!element.HasElements)
                    {
                        textLabel.Text = element.Value;
                    }
                    else
                    { textLabel.Text = string.Empty; }
                }
                else
                {
                     hloubkaElementuLabel.Text = poradiLabel.Text = atributyLabel.Text = textLabel.Text = string.Empty;
                }
            }
        }
    }
}

