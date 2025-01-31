namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.field1 = new System.Windows.Forms.Button();
            this.field2 = new System.Windows.Forms.Button();
            this.field3 = new System.Windows.Forms.Button();
            this.field6 = new System.Windows.Forms.Button();
            this.field5 = new System.Windows.Forms.Button();
            this.field4 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schließenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spielenAlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pn1Text = new System.Windows.Forms.ToolStripTextBox();
            this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pn2Name = new System.Windows.Forms.ToolStripTextBox();
            this.zurücksetzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.field9 = new System.Windows.Forms.Button();
            this.field8 = new System.Windows.Forms.Button();
            this.field7 = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.winnerLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // field1
            // 
            this.field1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.field1.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.field1.Location = new System.Drawing.Point(13, 35);
            this.field1.Name = "field1";
            this.field1.Size = new System.Drawing.Size(100, 96);
            this.field1.TabIndex = 0;
            this.field1.TabStop = false;
            this.field1.Click += new System.EventHandler(this.boxClickEvent);
            // 
            // field2
            // 
            this.field2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.field2.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.field2.Location = new System.Drawing.Point(119, 35);
            this.field2.Name = "field2";
            this.field2.Size = new System.Drawing.Size(100, 96);
            this.field2.TabIndex = 1;
            this.field2.TabStop = false;
            this.field2.Click += new System.EventHandler(this.boxClickEvent);
            // 
            // field3
            // 
            this.field3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.field3.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.field3.Location = new System.Drawing.Point(225, 34);
            this.field3.Name = "field3";
            this.field3.Size = new System.Drawing.Size(100, 96);
            this.field3.TabIndex = 2;
            this.field3.TabStop = false;
            this.field3.Click += new System.EventHandler(this.boxClickEvent);
            // 
            // field6
            // 
            this.field6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.field6.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.field6.Location = new System.Drawing.Point(225, 136);
            this.field6.Name = "field6";
            this.field6.Size = new System.Drawing.Size(100, 96);
            this.field6.TabIndex = 5;
            this.field6.TabStop = false;
            this.field6.Click += new System.EventHandler(this.boxClickEvent);
            // 
            // field5
            // 
            this.field5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.field5.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.field5.Location = new System.Drawing.Point(119, 137);
            this.field5.Name = "field5";
            this.field5.Size = new System.Drawing.Size(100, 96);
            this.field5.TabIndex = 4;
            this.field5.TabStop = false;
            this.field5.Click += new System.EventHandler(this.boxClickEvent);
            // 
            // field4
            // 
            this.field4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.field4.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.field4.Location = new System.Drawing.Point(13, 137);
            this.field4.Name = "field4";
            this.field4.Size = new System.Drawing.Size(100, 96);
            this.field4.TabIndex = 3;
            this.field4.TabStop = false;
            this.field4.Click += new System.EventHandler(this.boxClickEvent);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.einstellungenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(340, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schließenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // schließenToolStripMenuItem
            // 
            this.schließenToolStripMenuItem.Name = "schließenToolStripMenuItem";
            this.schließenToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.schließenToolStripMenuItem.Text = "Schließen";
            this.schließenToolStripMenuItem.Click += new System.EventHandler(this.schließenToolStripMenuItem_Click);
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spielenAlsToolStripMenuItem,
            this.zurücksetzenToolStripMenuItem});
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.einstellungenToolStripMenuItem.Text = "Einstellungen";
            // 
            // spielenAlsToolStripMenuItem
            // 
            this.spielenAlsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oToolStripMenuItem,
            this.xToolStripMenuItem});
            this.spielenAlsToolStripMenuItem.Name = "spielenAlsToolStripMenuItem";
            this.spielenAlsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.spielenAlsToolStripMenuItem.Text = "Spielernamen";
            // 
            // oToolStripMenuItem
            // 
            this.oToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pn1Text});
            this.oToolStripMenuItem.Name = "oToolStripMenuItem";
            this.oToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oToolStripMenuItem.Text = "O";
            // 
            // pn1Text
            // 
            this.pn1Text.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pn1Text.Name = "pn1Text";
            this.pn1Text.Size = new System.Drawing.Size(100, 23);
            this.pn1Text.Text = "Spieler 1";
            this.pn1Text.TextChanged += new System.EventHandler(this.pn1Text_Click);
            // 
            // xToolStripMenuItem
            // 
            this.xToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pn2Name});
            this.xToolStripMenuItem.Name = "xToolStripMenuItem";
            this.xToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.xToolStripMenuItem.Text = "X";
            // 
            // pn2Name
            // 
            this.pn2Name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pn2Name.Name = "pn2Name";
            this.pn2Name.Size = new System.Drawing.Size(100, 23);
            this.pn2Name.Text = "Spieler 2";
            this.pn2Name.TextChanged += new System.EventHandler(this.pn2Name_Click);
            // 
            // zurücksetzenToolStripMenuItem
            // 
            this.zurücksetzenToolStripMenuItem.Name = "zurücksetzenToolStripMenuItem";
            this.zurücksetzenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zurücksetzenToolStripMenuItem.Text = "Zurücksetzen";
            this.zurücksetzenToolStripMenuItem.Click += new System.EventHandler(this.zurücksetzenToolStripMenuItem_Click);
            // 
            // field9
            // 
            this.field9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.field9.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.field9.Location = new System.Drawing.Point(225, 238);
            this.field9.Name = "field9";
            this.field9.Size = new System.Drawing.Size(100, 96);
            this.field9.TabIndex = 13;
            this.field9.TabStop = false;
            this.field9.Click += new System.EventHandler(this.boxClickEvent);
            // 
            // field8
            // 
            this.field8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.field8.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.field8.Location = new System.Drawing.Point(119, 239);
            this.field8.Name = "field8";
            this.field8.Size = new System.Drawing.Size(100, 96);
            this.field8.TabIndex = 12;
            this.field8.TabStop = false;
            this.field8.Click += new System.EventHandler(this.boxClickEvent);
            // 
            // field7
            // 
            this.field7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.field7.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.field7.Location = new System.Drawing.Point(13, 239);
            this.field7.Name = "field7";
            this.field7.Size = new System.Drawing.Size(100, 96);
            this.field7.TabIndex = 11;
            this.field7.TabStop = false;
            this.field7.Click += new System.EventHandler(this.boxClickEvent);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(10, 349);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(124, 13);
            this.infoLabel.TabIndex = 14;
            this.infoLabel.Text = "Das Spiel hat begonnen!";
            // 
            // winnerLabel
            // 
            this.winnerLabel.AutoSize = true;
            this.winnerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnerLabel.Location = new System.Drawing.Point(10, 350);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(112, 13);
            this.winnerLabel.TabIndex = 15;
            this.winnerLabel.Text = "hhhhhhhhhhhhhhh";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 372);
            this.Controls.Add(this.winnerLabel);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.field9);
            this.Controls.Add(this.field8);
            this.Controls.Add(this.field7);
            this.Controls.Add(this.field6);
            this.Controls.Add(this.field5);
            this.Controls.Add(this.field4);
            this.Controls.Add(this.field3);
            this.Controls.Add(this.field2);
            this.Controls.Add(this.field1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button field1;
        private System.Windows.Forms.Button field2;
        private System.Windows.Forms.Button field3;
        private System.Windows.Forms.Button field6;
        private System.Windows.Forms.Button field5;
        private System.Windows.Forms.Button field4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schließenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spielenAlsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oToolStripMenuItem;
        private System.Windows.Forms.Button field9;
        private System.Windows.Forms.Button field8;
        private System.Windows.Forms.Button field7;
        private System.Windows.Forms.ToolStripTextBox pn1Text;
        private System.Windows.Forms.ToolStripTextBox pn2Name;
        private System.Windows.Forms.ToolStripMenuItem zurücksetzenToolStripMenuItem;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label winnerLabel;
    }
}

