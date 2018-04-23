namespace Battleships
{
    partial class GameBoard
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
            this.lbColumn = new System.Windows.Forms.ListBox();
            this.lblColumn = new System.Windows.Forms.Label();
            this.lblRow = new System.Windows.Forms.Label();
            this.lbRow = new System.Windows.Forms.ListBox();
            this.btnFire = new System.Windows.Forms.Button();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.dgridBoard = new System.Windows.Forms.DataGridView();
            this.lblMessages = new System.Windows.Forms.Label();
            this.lblMiss = new System.Windows.Forms.Label();
            this.lblHit = new System.Windows.Forms.Label();
            this.lblUnknown = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgridBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // lbColumn
            // 
            this.lbColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbColumn.FormattingEnabled = true;
            this.lbColumn.ItemHeight = 24;
            this.lbColumn.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J"});
            this.lbColumn.Location = new System.Drawing.Point(22, 131);
            this.lbColumn.Name = "lbColumn";
            this.lbColumn.Size = new System.Drawing.Size(55, 244);
            this.lbColumn.TabIndex = 0;
            // 
            // lblColumn
            // 
            this.lblColumn.AutoSize = true;
            this.lblColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumn.Location = new System.Drawing.Point(11, 94);
            this.lblColumn.Name = "lblColumn";
            this.lblColumn.Size = new System.Drawing.Size(76, 24);
            this.lblColumn.TabIndex = 1;
            this.lblColumn.Text = "Column";
            // 
            // lblRow
            // 
            this.lblRow.AutoSize = true;
            this.lblRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRow.Location = new System.Drawing.Point(99, 94);
            this.lblRow.Name = "lblRow";
            this.lblRow.Size = new System.Drawing.Size(48, 24);
            this.lblRow.TabIndex = 2;
            this.lblRow.Text = "Row";
            // 
            // lbRow
            // 
            this.lbRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRow.FormattingEnabled = true;
            this.lbRow.ItemHeight = 24;
            this.lbRow.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.lbRow.Location = new System.Drawing.Point(95, 131);
            this.lbRow.Name = "lbRow";
            this.lbRow.Size = new System.Drawing.Size(61, 244);
            this.lbRow.TabIndex = 3;
            // 
            // btnFire
            // 
            this.btnFire.Enabled = false;
            this.btnFire.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFire.Location = new System.Drawing.Point(22, 385);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(134, 58);
            this.btnFire.TabIndex = 4;
            this.btnFire.Text = "&FIRE!";
            this.btnFire.UseVisualStyleBackColor = true;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // btnStartGame
            // 
            this.btnStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.Location = new System.Drawing.Point(15, 12);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(141, 67);
            this.btnStartGame.TabIndex = 5;
            this.btnStartGame.Text = "START GAME";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // dgridBoard
            // 
            this.dgridBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridBoard.Location = new System.Drawing.Point(184, 12);
            this.dgridBoard.MultiSelect = false;
            this.dgridBoard.Name = "dgridBoard";
            this.dgridBoard.ReadOnly = true;
            this.dgridBoard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgridBoard.Size = new System.Drawing.Size(464, 431);
            this.dgridBoard.TabIndex = 6;
            // 
            // lblMessages
            // 
            this.lblMessages.AutoSize = true;
            this.lblMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessages.Location = new System.Drawing.Point(185, 445);
            this.lblMessages.MaximumSize = new System.Drawing.Size(464, 0);
            this.lblMessages.Name = "lblMessages";
            this.lblMessages.Size = new System.Drawing.Size(0, 24);
            this.lblMessages.TabIndex = 7;
            this.lblMessages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMiss
            // 
            this.lblMiss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblMiss.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMiss.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiss.ForeColor = System.Drawing.Color.Black;
            this.lblMiss.Location = new System.Drawing.Point(346, 499);
            this.lblMiss.Name = "lblMiss";
            this.lblMiss.Size = new System.Drawing.Size(140, 23);
            this.lblMiss.TabIndex = 8;
            this.lblMiss.Text = "Miss";
            this.lblMiss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHit
            // 
            this.lblHit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblHit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHit.ForeColor = System.Drawing.Color.Black;
            this.lblHit.Location = new System.Drawing.Point(180, 498);
            this.lblHit.Name = "lblHit";
            this.lblHit.Size = new System.Drawing.Size(140, 24);
            this.lblHit.TabIndex = 9;
            this.lblHit.Text = "Hit";
            this.lblHit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUnknown
            // 
            this.lblUnknown.BackColor = System.Drawing.Color.White;
            this.lblUnknown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUnknown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnknown.ForeColor = System.Drawing.Color.Black;
            this.lblUnknown.Location = new System.Drawing.Point(508, 497);
            this.lblUnknown.Name = "lblUnknown";
            this.lblUnknown.Size = new System.Drawing.Size(140, 26);
            this.lblUnknown.TabIndex = 10;
            this.lblUnknown.Text = "Unknown";
            this.lblUnknown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 497);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "SQUARE KEY:";
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 531);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUnknown);
            this.Controls.Add(this.lblHit);
            this.Controls.Add(this.lblMiss);
            this.Controls.Add(this.lblMessages);
            this.Controls.Add(this.dgridBoard);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.btnFire);
            this.Controls.Add(this.lbRow);
            this.Controls.Add(this.lblRow);
            this.Controls.Add(this.lblColumn);
            this.Controls.Add(this.lbColumn);
            this.MaximizeBox = false;
            this.Name = "GameBoard";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Let Battle Commence";
            this.Load += new System.EventHandler(this.GameBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbColumn;
        private System.Windows.Forms.Label lblColumn;
        private System.Windows.Forms.Label lblRow;
        private System.Windows.Forms.ListBox lbRow;
        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.DataGridView dgridBoard;
        private System.Windows.Forms.Label lblMessages;
        private System.Windows.Forms.Label lblMiss;
        private System.Windows.Forms.Label lblHit;
        private System.Windows.Forms.Label lblUnknown;
        private System.Windows.Forms.Label label1;
    }
}

