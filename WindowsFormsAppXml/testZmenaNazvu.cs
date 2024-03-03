using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsAppXml
{
    internal class testZmenaNazvu
    {
        private readonly SpravceXmlSouboru spravceXmlSouboru = new SpravceXmlSouboru(); // Předpokládáme, že vaše třída SpravceXmlSouboru je dostupná

        public void RunTest()
        {
            // Testovací XML soubor
            XDocument testDocument = XDocument.Parse("<Root><Child1><Grandchild1></Grandchild1></Child1></Root>");

            // Kořenový uzel testovacího XML souboru
            TreeNode rootNode = new TreeNode("NewRoot");

            // Změna názvů elementů
            spravceXmlSouboru.ChangeNodeNames(testDocument.Root, rootNode);

            // Kontrola změn
            Console.WriteLine(testDocument);
        }
    }
}

