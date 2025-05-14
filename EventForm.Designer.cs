namespace Event_Ticketing_System
{
    partial class EventForm
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
            this.eventGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.eventIdTextBox = new System.Windows.Forms.TextBox();
            this.eventLocationTextBox = new System.Windows.Forms.TextBox();
            this.eventNameTextBox = new System.Windows.Forms.TextBox();
            this.eventDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.eventDatePicker = new System.Windows.Forms.DateTimePicker();
            this.addEventButton = new System.Windows.Forms.Button();
            this.updateEventButton = new System.Windows.Forms.Button();
            this.deleteEventButton = new System.Windows.Forms.Button();
            this.openTicketFormButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eventGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // eventGrid
            // 
            this.eventGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventGrid.Location = new System.Drawing.Point(51, 79);
            this.eventGrid.Name = "eventGrid";
            this.eventGrid.Size = new System.Drawing.Size(687, 198);
            this.eventGrid.TabIndex = 0;
            this.eventGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eventGrid_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Date";
            // 
            // eventIdTextBox
            // 
            this.eventIdTextBox.Location = new System.Drawing.Point(126, 310);
            this.eventIdTextBox.Name = "eventIdTextBox";
            this.eventIdTextBox.ReadOnly = true;
            this.eventIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.eventIdTextBox.TabIndex = 6;
            // 
            // eventLocationTextBox
            // 
            this.eventLocationTextBox.Location = new System.Drawing.Point(126, 344);
            this.eventLocationTextBox.Name = "eventLocationTextBox";
            this.eventLocationTextBox.Size = new System.Drawing.Size(200, 20);
            this.eventLocationTextBox.TabIndex = 7;
            // 
            // eventNameTextBox
            // 
            this.eventNameTextBox.Location = new System.Drawing.Point(453, 310);
            this.eventNameTextBox.Name = "eventNameTextBox";
            this.eventNameTextBox.Size = new System.Drawing.Size(285, 20);
            this.eventNameTextBox.TabIndex = 8;
            // 
            // eventDescriptionTextBox
            // 
            this.eventDescriptionTextBox.Location = new System.Drawing.Point(453, 344);
            this.eventDescriptionTextBox.Multiline = true;
            this.eventDescriptionTextBox.Name = "eventDescriptionTextBox";
            this.eventDescriptionTextBox.Size = new System.Drawing.Size(285, 51);
            this.eventDescriptionTextBox.TabIndex = 9;
            // 
            // eventDatePicker
            // 
            this.eventDatePicker.Location = new System.Drawing.Point(126, 377);
            this.eventDatePicker.Name = "eventDatePicker";
            this.eventDatePicker.Size = new System.Drawing.Size(200, 20);
            this.eventDatePicker.TabIndex = 10;
            // 
            // addEventButton
            // 
            this.addEventButton.Location = new System.Drawing.Point(571, 451);
            this.addEventButton.Name = "addEventButton";
            this.addEventButton.Size = new System.Drawing.Size(75, 29);
            this.addEventButton.TabIndex = 11;
            this.addEventButton.Text = "Add Event";
            this.addEventButton.UseVisualStyleBackColor = true;
            this.addEventButton.Click += new System.EventHandler(this.addEventButton_Click);
            // 
            // updateEventButton
            // 
            this.updateEventButton.Location = new System.Drawing.Point(652, 451);
            this.updateEventButton.Name = "updateEventButton";
            this.updateEventButton.Size = new System.Drawing.Size(86, 29);
            this.updateEventButton.TabIndex = 12;
            this.updateEventButton.Text = "Update Event";
            this.updateEventButton.UseVisualStyleBackColor = true;
            this.updateEventButton.Click += new System.EventHandler(this.updateEventButton_Click);
            // 
            // deleteEventButton
            // 
            this.deleteEventButton.Location = new System.Drawing.Point(59, 425);
            this.deleteEventButton.Name = "deleteEventButton";
            this.deleteEventButton.Size = new System.Drawing.Size(86, 29);
            this.deleteEventButton.TabIndex = 13;
            this.deleteEventButton.Text = "Delete Event";
            this.deleteEventButton.UseVisualStyleBackColor = true;
            this.deleteEventButton.Click += new System.EventHandler(this.deleteEventButton_Click);
            // 
            // openTicketFormButton
            // 
            this.openTicketFormButton.Location = new System.Drawing.Point(438, 451);
            this.openTicketFormButton.Name = "openTicketFormButton";
            this.openTicketFormButton.Size = new System.Drawing.Size(127, 29);
            this.openTicketFormButton.TabIndex = 14;
            this.openTicketFormButton.Text = "Tickets Management";
            this.openTicketFormButton.UseVisualStyleBackColor = true;
            this.openTicketFormButton.Click += new System.EventHandler(this.openTicketFormButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(151, 425);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(86, 29);
            this.loadButton.TabIndex = 15;
            this.loadButton.Text = "Load Data";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(298, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Event Management";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 29);
            this.button1.TabIndex = 17;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.openTicketFormButton);
            this.Controls.Add(this.deleteEventButton);
            this.Controls.Add(this.updateEventButton);
            this.Controls.Add(this.addEventButton);
            this.Controls.Add(this.eventDatePicker);
            this.Controls.Add(this.eventDescriptionTextBox);
            this.Controls.Add(this.eventNameTextBox);
            this.Controls.Add(this.eventLocationTextBox);
            this.Controls.Add(this.eventIdTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eventGrid);
            this.Name = "EventForm";
            this.Text = "EventForm";
            ((System.ComponentModel.ISupportInitialize)(this.eventGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.DataGridView eventGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox eventIdTextBox;
        private System.Windows.Forms.TextBox eventLocationTextBox;
        private System.Windows.Forms.TextBox eventNameTextBox;
        private System.Windows.Forms.TextBox eventDescriptionTextBox;
        private System.Windows.Forms.DateTimePicker eventDatePicker;
        private System.Windows.Forms.Button addEventButton;
        private System.Windows.Forms.Button updateEventButton;
        private System.Windows.Forms.Button deleteEventButton;
        private System.Windows.Forms.Button openTicketFormButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}