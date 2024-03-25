namespace WindowsFormsAppXml
{
    partial class xmlForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xmlForm));
            this.menuToolStrip = new System.Windows.Forms.ToolStrip();
            this.otevritToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ulozitToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.zavritToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.xmlTreeView = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.nazevSouboruLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hloubkaLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maxPotomkuLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.minAtributuLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.maxAtributuLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.hloubkaElementuLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.poradiLabel = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.atributyLabel = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textLabel = new System.Windows.Forms.Label();
            this.menuToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuToolStrip
            // 
            this.menuToolStrip.BackColor = System.Drawing.SystemColors.Control;
            this.menuToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuToolStrip.GripMargin = new System.Windows.Forms.Padding(10);
            this.menuToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.menuToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otevritToolStripButton,
            this.ulozitToolStripButton,
            this.zavritToolStripButton});
            this.menuToolStrip.Location = new System.Drawing.Point(0, 0);
            this.menuToolStrip.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.menuToolStrip.Name = "menuToolStrip";
            this.menuToolStrip.Size = new System.Drawing.Size(251, 34);
            this.menuToolStrip.TabIndex = 0;
            this.menuToolStrip.Text = "toolStrip1";
            // 
            // otevritToolStripButton
            // 
            this.otevritToolStripButton.AutoSize = false;
            this.otevritToolStripButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.otevritToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.otevritToolStripButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.otevritToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("otevritToolStripButton.Image")));
            this.otevritToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.otevritToolStripButton.Name = "otevritToolStripButton";
            this.otevritToolStripButton.Size = new System.Drawing.Size(76, 29);
            this.otevritToolStripButton.Text = "Otevřít";
            this.otevritToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.otevritToolStripButton.Click += new System.EventHandler(this.otevritToolStripButton_Click);
            // 
            // ulozitToolStripButton
            // 
            this.ulozitToolStripButton.AutoSize = false;
            this.ulozitToolStripButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.ulozitToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ulozitToolStripButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ulozitToolStripButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ulozitToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ulozitToolStripButton.Image")));
            this.ulozitToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ulozitToolStripButton.Margin = new System.Windows.Forms.Padding(10, 2, 0, 3);
            this.ulozitToolStripButton.Name = "ulozitToolStripButton";
            this.ulozitToolStripButton.Padding = new System.Windows.Forms.Padding(5);
            this.ulozitToolStripButton.Size = new System.Drawing.Size(76, 29);
            this.ulozitToolStripButton.Text = "Uložit";
            this.ulozitToolStripButton.Click += new System.EventHandler(this.ulozitToolStripButton_Click);
            // 
            // zavritToolStripButton
            // 
            this.zavritToolStripButton.AutoSize = false;
            this.zavritToolStripButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.zavritToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.zavritToolStripButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zavritToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("zavritToolStripButton.Image")));
            this.zavritToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zavritToolStripButton.Margin = new System.Windows.Forms.Padding(10, 2, 0, 3);
            this.zavritToolStripButton.Name = "zavritToolStripButton";
            this.zavritToolStripButton.Padding = new System.Windows.Forms.Padding(5);
            this.zavritToolStripButton.Size = new System.Drawing.Size(76, 29);
            this.zavritToolStripButton.Text = "Zavřít";
            this.zavritToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.zavritToolStripButton.Click += new System.EventHandler(this.zavritToolStripButton_Click);
            // 
            // xmlTreeView
            // 
            this.xmlTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xmlTreeView.ImageIndex = 0;
            this.xmlTreeView.ImageList = this.imageList1;
            this.xmlTreeView.LabelEdit = true;
            this.xmlTreeView.Location = new System.Drawing.Point(8, 39);
            this.xmlTreeView.Margin = new System.Windows.Forms.Padding(2);
            this.xmlTreeView.Name = "xmlTreeView";
            this.xmlTreeView.SelectedImageIndex = 0;
            this.xmlTreeView.Size = new System.Drawing.Size(241, 251);
            this.xmlTreeView.TabIndex = 1;
            this.xmlTreeView.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.xmlTreeView_AfterLabelEdit);
            this.xmlTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.xmlTreeView_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "vetviciUzel");
            this.imageList1.Images.SetKeyName(1, "koncovyUzel");
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Název souboru:";
            // 
            // nazevSouboruLabel
            // 
            this.nazevSouboruLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nazevSouboruLabel.AutoSize = true;
            this.nazevSouboruLabel.Location = new System.Drawing.Point(419, 39);
            this.nazevSouboruLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nazevSouboruLabel.Name = "nazevSouboruLabel";
            this.nazevSouboruLabel.Size = new System.Drawing.Size(0, 13);
            this.nazevSouboruLabel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hloubka nejzanoř.elemetu:";
            // 
            // hloubkaLabel
            // 
            this.hloubkaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hloubkaLabel.AutoSize = true;
            this.hloubkaLabel.Location = new System.Drawing.Point(419, 58);
            this.hloubkaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hloubkaLabel.Name = "hloubkaLabel";
            this.hloubkaLabel.Size = new System.Drawing.Size(0, 13);
            this.hloubkaLabel.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Maximální počet potomků:";
            // 
            // maxPotomkuLabel
            // 
            this.maxPotomkuLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maxPotomkuLabel.AutoSize = true;
            this.maxPotomkuLabel.Location = new System.Drawing.Point(419, 78);
            this.maxPotomkuLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxPotomkuLabel.Name = "maxPotomkuLabel";
            this.maxPotomkuLabel.Size = new System.Drawing.Size(0, 13);
            this.maxPotomkuLabel.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(260, 99);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Minimální počet atributů:";
            // 
            // minAtributuLabel
            // 
            this.minAtributuLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.minAtributuLabel.AutoSize = true;
            this.minAtributuLabel.Location = new System.Drawing.Point(419, 99);
            this.minAtributuLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minAtributuLabel.Name = "minAtributuLabel";
            this.minAtributuLabel.Size = new System.Drawing.Size(0, 13);
            this.minAtributuLabel.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(260, 122);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Maximální počet atributů:";
            // 
            // maxAtributuLabel
            // 
            this.maxAtributuLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maxAtributuLabel.AutoSize = true;
            this.maxAtributuLabel.Location = new System.Drawing.Point(419, 122);
            this.maxAtributuLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxAtributuLabel.Name = "maxAtributuLabel";
            this.maxAtributuLabel.Size = new System.Drawing.Size(0, 13);
            this.maxAtributuLabel.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(299, 8);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(162, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "Informace o souboru:";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(302, 150);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(169, 17);
            this.label12.TabIndex = 13;
            this.label12.Text = "Informace o elementu:";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(260, 173);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Hloubka zanoření:";
            // 
            // hloubkaElementuLabel
            // 
            this.hloubkaElementuLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hloubkaElementuLabel.Location = new System.Drawing.Point(419, 173);
            this.hloubkaElementuLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hloubkaElementuLabel.Name = "hloubkaElementuLabel";
            this.hloubkaElementuLabel.Size = new System.Drawing.Size(20, 29);
            this.hloubkaElementuLabel.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(260, 192);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "Pořadí mezi sourozenci:";
            // 
            // poradiLabel
            // 
            this.poradiLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.poradiLabel.AutoSize = true;
            this.poradiLabel.Location = new System.Drawing.Point(419, 192);
            this.poradiLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.poradiLabel.Name = "poradiLabel";
            this.poradiLabel.Size = new System.Drawing.Size(0, 13);
            this.poradiLabel.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(260, 214);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(128, 13);
            this.label17.TabIndex = 18;
            this.label17.Text = "Názvy a hodnoty atributů:";
            // 
            // atributyLabel
            // 
            this.atributyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.atributyLabel.AutoSize = true;
            this.atributyLabel.Location = new System.Drawing.Point(419, 214);
            this.atributyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.atributyLabel.Name = "atributyLabel";
            this.atributyLabel.Size = new System.Drawing.Size(0, 13);
            this.atributyLabel.TabIndex = 19;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoEllipsis = true;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(260, 261);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(31, 13);
            this.label19.TabIndex = 20;
            this.label19.Text = "Text:";
            // 
            // textLabel
            // 
            this.textLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textLabel.AutoEllipsis = true;
            this.textLabel.Location = new System.Drawing.Point(295, 261);
            this.textLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(196, 29);
            this.textLabel.TabIndex = 21;
            // 
            // xmlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 330);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.atributyLabel);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.poradiLabel);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.hloubkaElementuLabel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.maxAtributuLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.minAtributuLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.maxPotomkuLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hloubkaLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nazevSouboruLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xmlTreeView);
            this.Controls.Add(this.menuToolStrip);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "xmlForm";
            this.Text = "Správce XML souborů";
            this.menuToolStrip.ResumeLayout(false);
            this.menuToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip menuToolStrip;
        private System.Windows.Forms.ToolStripButton otevritToolStripButton;
        private System.Windows.Forms.ToolStripButton ulozitToolStripButton;
        private System.Windows.Forms.ToolStripButton zavritToolStripButton;
        private System.Windows.Forms.TreeView xmlTreeView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nazevSouboruLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label hloubkaLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label maxPotomkuLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label minAtributuLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label maxAtributuLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label hloubkaElementuLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label poradiLabel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Label atributyLabel;
        private System.Windows.Forms.ImageList imageList1;
    }
}

