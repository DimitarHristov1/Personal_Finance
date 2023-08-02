namespace Personal_Finance
{
    partial class Incomes_Form
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
            this.listView_incomes = new System.Windows.Forms.ListView();
            this.escape_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView_incomes
            // 
            this.listView_incomes.Location = new System.Drawing.Point(12, 12);
            this.listView_incomes.Name = "listView_incomes";
            this.listView_incomes.Size = new System.Drawing.Size(331, 139);
            this.listView_incomes.TabIndex = 0;
            this.listView_incomes.UseCompatibleStateImageBehavior = false;
            this.listView_incomes.View = System.Windows.Forms.View.Details;
            // 
            // escape_button
            // 
            this.escape_button.Location = new System.Drawing.Point(140, 157);
            this.escape_button.Name = "escape_button";
            this.escape_button.Size = new System.Drawing.Size(92, 25);
            this.escape_button.TabIndex = 70;
            this.escape_button.Text = "Изход";
            this.escape_button.UseVisualStyleBackColor = true;
            this.escape_button.Click += new System.EventHandler(this.escape_button_Click);
            // 
            // Incomes_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 191);
            this.ControlBox = false;
            this.Controls.Add(this.escape_button);
            this.Controls.Add(this.listView_incomes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Incomes_Form";
            this.Text = "Видове приходи";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_incomes;
        private System.Windows.Forms.Button escape_button;
    }
}