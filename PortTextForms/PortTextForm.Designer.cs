namespace PortTextReader.PortTextForms
{
    partial class PortTextForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.OkButton = new System.Windows.Forms.Button();
            this.PortTextDgv = new System.Windows.Forms.DataGridView();
            this.SheetCombox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PortTextDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.PortTextDgv);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.SheetCombox);
            this.splitContainer1.Panel2.Controls.Add(this.OkButton);
            this.splitContainer1.Size = new System.Drawing.Size(1061, 576);
            this.splitContainer1.SplitterDistance = 544;
            this.splitContainer1.TabIndex = 0;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(974, 3);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // PortTextDgv
            // 
            this.PortTextDgv.AllowUserToAddRows = false;
            this.PortTextDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PortTextDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PortTextDgv.Location = new System.Drawing.Point(0, 0);
            this.PortTextDgv.Name = "PortTextDgv";
            this.PortTextDgv.RowTemplate.Height = 21;
            this.PortTextDgv.Size = new System.Drawing.Size(1061, 544);
            this.PortTextDgv.TabIndex = 0;
            // 
            // SheetCombox
            // 
            this.SheetCombox.FormattingEnabled = true;
            this.SheetCombox.Location = new System.Drawing.Point(4, 4);
            this.SheetCombox.Name = "SheetCombox";
            this.SheetCombox.Size = new System.Drawing.Size(121, 20);
            this.SheetCombox.TabIndex = 1;
            this.SheetCombox.TextChanged += new System.EventHandler(this.SheetCombox_TextChanged);
            // 
            // PortTextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 576);
            this.Controls.Add(this.splitContainer1);
            this.Name = "PortTextForm";
            this.Text = "PortTextForm";
            this.Load += new System.EventHandler(this.PortTextForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PortTextDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView PortTextDgv;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.ComboBox SheetCombox;
    }
}