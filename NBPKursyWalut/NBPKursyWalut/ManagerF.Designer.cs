namespace NBPKursyWalut
{
    partial class ManagerF
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kursyWalutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pobierzTabelęToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PobierzTabelaA_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PobierzTabelaB_Button = new System.Windows.Forms.Button();
            this.PobierzTabelaC_Button = new System.Windows.Forms.Button();
            this.StatusTabA_TextBox = new System.Windows.Forms.TextBox();
            this.StatusTabB_TextBox = new System.Windows.Forms.TextBox();
            this.StatusTabC_TextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.kursyWalutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(330, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zamknijToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // kursyWalutToolStripMenuItem
            // 
            this.kursyWalutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pobierzTabelęToolStripMenuItem});
            this.kursyWalutToolStripMenuItem.Name = "kursyWalutToolStripMenuItem";
            this.kursyWalutToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.kursyWalutToolStripMenuItem.Text = "Kursy walut";
            // 
            // pobierzTabelęToolStripMenuItem
            // 
            this.pobierzTabelęToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.bToolStripMenuItem,
            this.cToolStripMenuItem});
            this.pobierzTabelęToolStripMenuItem.Name = "pobierzTabelęToolStripMenuItem";
            this.pobierzTabelęToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.pobierzTabelęToolStripMenuItem.Text = "Pobierz tabelę";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
            this.aToolStripMenuItem.Text = "A";
            this.aToolStripMenuItem.Click += new System.EventHandler(this.PobierzTabelaA_Button_Click);
            // 
            // bToolStripMenuItem
            // 
            this.bToolStripMenuItem.Name = "bToolStripMenuItem";
            this.bToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
            this.bToolStripMenuItem.Text = "B";
            this.bToolStripMenuItem.Click += new System.EventHandler(this.PobierzTabelaB_Button_Click);
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
            this.cToolStripMenuItem.Text = "C";
            this.cToolStripMenuItem.Click += new System.EventHandler(this.PobierzTabelaC_Button_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.PobierzTabelaA_Button, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PobierzTabelaB_Button, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.PobierzTabelaC_Button, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.StatusTabA_TextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.StatusTabB_TextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.StatusTabC_TextBox, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(330, 111);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // PobierzTabelaA_Button
            // 
            this.PobierzTabelaA_Button.AutoSize = true;
            this.PobierzTabelaA_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PobierzTabelaA_Button.Location = new System.Drawing.Point(3, 25);
            this.PobierzTabelaA_Button.Name = "PobierzTabelaA_Button";
            this.PobierzTabelaA_Button.Size = new System.Drawing.Size(94, 23);
            this.PobierzTabelaA_Button.TabIndex = 0;
            this.PobierzTabelaA_Button.Text = "Pobierz tabelę A";
            this.PobierzTabelaA_Button.UseVisualStyleBackColor = true;
            this.PobierzTabelaA_Button.Click += new System.EventHandler(this.PobierzTabelaA_Button_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kursy walut";
            // 
            // PobierzTabelaB_Button
            // 
            this.PobierzTabelaB_Button.AutoSize = true;
            this.PobierzTabelaB_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PobierzTabelaB_Button.Location = new System.Drawing.Point(3, 54);
            this.PobierzTabelaB_Button.Name = "PobierzTabelaB_Button";
            this.PobierzTabelaB_Button.Size = new System.Drawing.Size(94, 23);
            this.PobierzTabelaB_Button.TabIndex = 2;
            this.PobierzTabelaB_Button.Text = "Pobierz tabelę B";
            this.PobierzTabelaB_Button.UseVisualStyleBackColor = true;
            this.PobierzTabelaB_Button.Click += new System.EventHandler(this.PobierzTabelaB_Button_Click);
            // 
            // PobierzTabelaC_Button
            // 
            this.PobierzTabelaC_Button.AutoSize = true;
            this.PobierzTabelaC_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PobierzTabelaC_Button.Location = new System.Drawing.Point(3, 83);
            this.PobierzTabelaC_Button.Name = "PobierzTabelaC_Button";
            this.PobierzTabelaC_Button.Size = new System.Drawing.Size(94, 23);
            this.PobierzTabelaC_Button.TabIndex = 3;
            this.PobierzTabelaC_Button.Text = "Pobierz tabelę C";
            this.PobierzTabelaC_Button.UseVisualStyleBackColor = true;
            this.PobierzTabelaC_Button.Click += new System.EventHandler(this.PobierzTabelaC_Button_Click);
            // 
            // StatusTabA_TextBox
            // 
            this.StatusTabA_TextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.StatusTabA_TextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.StatusTabA_TextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.StatusTabA_TextBox.Location = new System.Drawing.Point(124, 26);
            this.StatusTabA_TextBox.Name = "StatusTabA_TextBox";
            this.StatusTabA_TextBox.ReadOnly = true;
            this.StatusTabA_TextBox.Size = new System.Drawing.Size(200, 20);
            this.StatusTabA_TextBox.TabIndex = 4;
            // 
            // StatusTabB_TextBox
            // 
            this.StatusTabB_TextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.StatusTabB_TextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.StatusTabB_TextBox.Location = new System.Drawing.Point(124, 55);
            this.StatusTabB_TextBox.Name = "StatusTabB_TextBox";
            this.StatusTabB_TextBox.ReadOnly = true;
            this.StatusTabB_TextBox.Size = new System.Drawing.Size(200, 20);
            this.StatusTabB_TextBox.TabIndex = 5;
            // 
            // StatusTabC_TextBox
            // 
            this.StatusTabC_TextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.StatusTabC_TextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.StatusTabC_TextBox.Location = new System.Drawing.Point(124, 84);
            this.StatusTabC_TextBox.Name = "StatusTabC_TextBox";
            this.StatusTabC_TextBox.ReadOnly = true;
            this.StatusTabC_TextBox.Size = new System.Drawing.Size(200, 20);
            this.StatusTabC_TextBox.TabIndex = 6;
            // 
            // ManagerF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(330, 135);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ManagerF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NBP Kursy walut";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button PobierzTabelaA_Button;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kursyWalutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pobierzTabelęToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PobierzTabelaB_Button;
        private System.Windows.Forms.Button PobierzTabelaC_Button;
        private System.Windows.Forms.TextBox StatusTabA_TextBox;
        private System.Windows.Forms.TextBox StatusTabB_TextBox;
        private System.Windows.Forms.TextBox StatusTabC_TextBox;
    }
}

