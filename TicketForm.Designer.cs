namespace Event_Ticketing_System
{
    partial class TicketForm
    {
        
        private System.ComponentModel.IContainer components = null;

        
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
            this.ticketGrid = new System.Windows.Forms.DataGridView();
            this.ticketIdTextBox = new System.Windows.Forms.TextBox();
            this.ticketTypeTextBox = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ticketPriceTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ticketAvailabilityTextBox = new System.Windows.Forms.TextBox();
            this.addTicketButton = new System.Windows.Forms.Button();
            this.updateTicketButton = new System.Windows.Forms.Button();
            this.deleteTicketButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ticketGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ticketGrid
            // 
            this.ticketGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketGrid.Location = new System.Drawing.Point(77, 72);
            this.ticketGrid.Name = "ticketGrid";
            this.ticketGrid.Size = new System.Drawing.Size(624, 211);
            this.ticketGrid.TabIndex = 0;
            // 
            // ticketIdTextBox
            // 
            this.ticketIdTextBox.Location = new System.Drawing.Point(244, 314);
            this.ticketIdTextBox.Name = "ticketIdTextBox";
            this.ticketIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.ticketIdTextBox.TabIndex = 1;
            // 
            // ticketTypeTextBox
            // 
            this.ticketTypeTextBox.Location = new System.Drawing.Point(472, 314);
            this.ticketTypeTextBox.Name = "ticketTypeTextBox";
            this.ticketTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.ticketTypeTextBox.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(220, 317);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 3;
            this.ID.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(402, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ticket Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ticket Price";
            // 
            // ticketPriceTextBox
            // 
            this.ticketPriceTextBox.Location = new System.Drawing.Point(472, 363);
            this.ticketPriceTextBox.Name = "ticketPriceTextBox";
            this.ticketPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.ticketPriceTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ticket Availability";
            // 
            // ticketAvailabilityTextBox
            // 
            this.ticketAvailabilityTextBox.Location = new System.Drawing.Point(244, 359);
            this.ticketAvailabilityTextBox.Name = "ticketAvailabilityTextBox";
            this.ticketAvailabilityTextBox.Size = new System.Drawing.Size(100, 20);
            this.ticketAvailabilityTextBox.TabIndex = 8;
            // 
            // addTicketButton
            // 
            this.addTicketButton.Location = new System.Drawing.Point(655, 422);
            this.addTicketButton.Name = "addTicketButton";
            this.addTicketButton.Size = new System.Drawing.Size(85, 36);
            this.addTicketButton.TabIndex = 9;
            this.addTicketButton.Text = "Add Ticket";
            this.addTicketButton.UseVisualStyleBackColor = true;
            this.addTicketButton.Click += new System.EventHandler(this.addTicketButton_Click);
            // 
            // updateTicketButton
            // 
            this.updateTicketButton.Location = new System.Drawing.Point(558, 422);
            this.updateTicketButton.Name = "updateTicketButton";
            this.updateTicketButton.Size = new System.Drawing.Size(91, 36);
            this.updateTicketButton.TabIndex = 10;
            this.updateTicketButton.Text = "Update Ticket";
            this.updateTicketButton.UseVisualStyleBackColor = true;
            this.updateTicketButton.Click += new System.EventHandler(this.updateTicketButton_Click);
            // 
            // deleteTicketButton
            // 
            this.deleteTicketButton.Location = new System.Drawing.Point(102, 400);
            this.deleteTicketButton.Name = "deleteTicketButton";
            this.deleteTicketButton.Size = new System.Drawing.Size(91, 36);
            this.deleteTicketButton.TabIndex = 11;
            this.deleteTicketButton.Text = "Delete Ticket";
            this.deleteTicketButton.UseVisualStyleBackColor = true;
            this.deleteTicketButton.Click += new System.EventHandler(this.deleteTicketButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(199, 400);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(86, 36);
            this.loadButton.TabIndex = 16;
            this.loadButton.Text = "Load Data";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(301, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tickets Management";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(487, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 36);
            this.button1.TabIndex = 18;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(416, 422);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 36);
            this.button2.TabIndex = 19;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.deleteTicketButton);
            this.Controls.Add(this.updateTicketButton);
            this.Controls.Add(this.addTicketButton);
            this.Controls.Add(this.ticketAvailabilityTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ticketPriceTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.ticketTypeTextBox);
            this.Controls.Add(this.ticketIdTextBox);
            this.Controls.Add(this.ticketGrid);
            this.Name = "TicketForm";
            this.Text = "TicketForm";
            ((System.ComponentModel.ISupportInitialize)(this.ticketGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ticketGrid;
        private System.Windows.Forms.TextBox ticketIdTextBox;
        private System.Windows.Forms.TextBox ticketTypeTextBox;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ticketPriceTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ticketAvailabilityTextBox;
        private System.Windows.Forms.Button addTicketButton;
        private System.Windows.Forms.Button updateTicketButton;
        private System.Windows.Forms.Button deleteTicketButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}