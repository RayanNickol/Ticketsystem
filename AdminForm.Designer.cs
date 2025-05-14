namespace Event_Ticketing_System
{
    partial class AdminForm
    {
        
        private System.ComponentModel.IContainer components = null;

        
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.eventTab = new System.Windows.Forms.TabPage();
            this.eventGrid = new System.Windows.Forms.DataGridView();
            this.ticketTab = new System.Windows.Forms.TabPage();
            this.ticketGrid = new System.Windows.Forms.DataGridView();
            this.purchaseTab = new System.Windows.Forms.TabPage();
            this.purchaseGrid = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.loadButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.eventTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventGrid)).BeginInit();
            this.ticketTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketGrid)).BeginInit();
            this.purchaseTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.eventTab);
            this.tabControl.Controls.Add(this.ticketTab);
            this.tabControl.Controls.Add(this.purchaseTab);
            this.tabControl.Location = new System.Drawing.Point(17, 57);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(630, 237);
            this.tabControl.TabIndex = 0;
            // 
            // eventTab
            // 
            this.eventTab.Controls.Add(this.eventGrid);
            this.eventTab.Location = new System.Drawing.Point(4, 22);
            this.eventTab.Name = "eventTab";
            this.eventTab.Padding = new System.Windows.Forms.Padding(3);
            this.eventTab.Size = new System.Drawing.Size(622, 211);
            this.eventTab.TabIndex = 1;
            this.eventTab.Text = "Events";
            this.eventTab.UseVisualStyleBackColor = true;
            // 
            // eventGrid
            // 
            this.eventGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventGrid.Location = new System.Drawing.Point(0, 3);
            this.eventGrid.Name = "eventGrid";
            this.eventGrid.Size = new System.Drawing.Size(619, 199);
            this.eventGrid.TabIndex = 0;
            this.eventGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eventGrid_CellContentClick);
            // 
            // ticketTab
            // 
            this.ticketTab.Controls.Add(this.ticketGrid);
            this.ticketTab.Location = new System.Drawing.Point(4, 22);
            this.ticketTab.Name = "ticketTab";
            this.ticketTab.Padding = new System.Windows.Forms.Padding(3);
            this.ticketTab.Size = new System.Drawing.Size(622, 211);
            this.ticketTab.TabIndex = 2;
            this.ticketTab.Text = "Tickets";
            this.ticketTab.UseVisualStyleBackColor = true;
            // 
            // ticketGrid
            // 
            this.ticketGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketGrid.Location = new System.Drawing.Point(4, 4);
            this.ticketGrid.Name = "ticketGrid";
            this.ticketGrid.Size = new System.Drawing.Size(615, 203);
            this.ticketGrid.TabIndex = 0;
            // 
            // purchaseTab
            // 
            this.purchaseTab.Controls.Add(this.purchaseGrid);
            this.purchaseTab.Location = new System.Drawing.Point(4, 22);
            this.purchaseTab.Name = "purchaseTab";
            this.purchaseTab.Size = new System.Drawing.Size(622, 211);
            this.purchaseTab.TabIndex = 3;
            this.purchaseTab.Text = "Purchases";
            this.purchaseTab.UseVisualStyleBackColor = true;
            // 
            // purchaseGrid
            // 
            this.purchaseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchaseGrid.Location = new System.Drawing.Point(4, 4);
            this.purchaseGrid.Name = "purchaseGrid";
            this.purchaseGrid.Size = new System.Drawing.Size(615, 193);
            this.purchaseGrid.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(509, 325);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(99, 29);
            this.loadButton.TabIndex = 7;
            this.loadButton.Text = "Load Data";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Admin Form";
            // 
            // Exit_btn
            // 
            this.Exit_btn.Location = new System.Drawing.Point(439, 325);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(64, 29);
            this.Exit_btn.TabIndex = 9;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(671, 365);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.tabControl);
            this.Name = "AdminForm";
            this.Text = "adminform";
            this.tabControl.ResumeLayout(false);
            this.eventTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eventGrid)).EndInit();
            this.ticketTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ticketGrid)).EndInit();
            this.purchaseTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.purchaseGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage eventTab;
        private System.Windows.Forms.TabPage ticketTab;
        private System.Windows.Forms.TabPage purchaseTab;
        private System.Windows.Forms.DataGridView eventGrid;
        private System.Windows.Forms.DataGridView ticketGrid;
        private System.Windows.Forms.DataGridView purchaseGrid;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit_btn;
    }
}