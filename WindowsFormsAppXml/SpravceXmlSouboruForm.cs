using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using System;
using System.Linq;
using System.Windows.Forms.VisualStyles;

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
            xmlTreeView.Nodes.Clear();// Vyčištění TreeView

            // Zobrazení OpenFileDialog pro výběr XML souboru
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Vyberte soubor";
                openFileDialog.Filter = "XML soubory (*.xml)|*.xml";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        xmlDocument = XDocument.Load(openFileDialog.FileName); // Inicializace proměnné pro XML dokument
     
                        // Vytvoření kořenového uzlu
                        string rootElementName = xmlDocument.Root.Name.LocalName;
                        var root = new TreeNode(rootElementName);
                        xmlTreeView.Nodes.Add(root);

                        spravceXmlSouboru.AddNodes(xmlDocument.Root, root); // Přidání uzlů do stromu

                        xmlTreeView.ExpandAll(); // Rozbalení všech uzlů

                        ShowFileInfo(xmlDocument,openFileDialog); // Načtení informací o souboru

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


            // Název souboru bez cesty
            
            nazevSouboruLabel.Text = System.IO.Path.GetFileName(openFileDialog.FileName);

            // Hloubka nejzanorenějšího elementu
            hloubkaLabel.Text = document.Root.Descendants().Max(e => e.Ancestors().Count()).ToString();

            // Maximální počet přímých potomků, které nějaký element obsahuje
            maxPotomkuLabel.Text = document.Root.Descendants().Max(e => e.Elements().Count()).ToString();

            // Minimální počet atributů, které nějaký element obsahuje
            minAtributuLabel.Text = document.Root.Descendants().Min(e => e.Attributes().Count()).ToString();

            // Maximální počet atributů, které nějaký element obsahuje
            maxAtributuLabel.Text = document.Root.Descendants().Max(e => e.Attributes().Count()).ToString();
        }

        // Obsluha události kliknutí na tlačítko "Uložit"
        private void ulozitToolStripButton_Click(object sender, EventArgs e)

        {
            if (xmlDocument != null)
                // Zobrazení SaveFileDialog pro uložení XML souboru
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "XML files (*.xml)|*.xml";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            // Uložení změněného XML dokumentu do souboru
                            spravceXmlSouboru.UlozitXmlSoubor(xmlDocument, xmlTreeView.Nodes[0],saveFileDialog.FileName);

                            MessageBox.Show("Soubor byl úspěšně uložen.", "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Chyba při ukládání souboru: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            else
                MessageBox.Show("Není vybrán žádný soubor");
        }

            // Obsluha události kliknutí na tlačítko "Zavřít"
            private void zavritToolStripButton_Click(object sender, EventArgs e)
        {
            // Vyprázdnění TreeView a Labelů
            xmlTreeView.Nodes.Clear();
            nazevSouboruLabel.Text = hloubkaLabel.Text = maxPotomkuLabel.Text = minAtributuLabel.Text = maxAtributuLabel.Text = hloubkaElementuLabel.Text = poradiLabel.Text = atributyLabel.Text = textLabel.Text = string.Empty;
        }

        private void xmlTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            {
                TreeNode selectedNode = e.Node; // Získání vybraného uzlu

                // Získání odpovídajícího XElementu
                XElement element = spravceXmlSouboru.FindElementByNode(xmlDocument.Root, selectedNode.Text);

                // Zobrazit informace o vybraném elementu

                if (element != null)
                {

                    // Hloubka zanoření
                    hloubkaElementuLabel.Text = element.Ancestors().Count().ToString();

                    // Pořadí mezi sourozenci
                    poradiLabel.Text = (element.ElementsBeforeSelf().Count()+1).ToString();

                    // Názvy a hodnoty atributů
                    string attributesInfo = "";
                    foreach (XAttribute attribute in element.Attributes())
                    {
                        attributesInfo += $"{attribute.Name}: {attribute.Value}\n";
                    }
                    atributyLabel.Text = attributesInfo;

                    // Text koncového elementu
                    if (!element.HasElements)
                    {
                        textLabel.Text = element.Value;
                    }

                    else
                    {
                        // Vyprázdnit všechny informace, pokud element není vybrán
                        hloubkaElementuLabel.Text = poradiLabel.Text = atributyLabel.Text = textLabel.Text = string.Empty;
                    }


                }
            }

        }
    }
}