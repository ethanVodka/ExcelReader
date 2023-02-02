namespace PortTextReader
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ReadPiniButton = new System.Windows.Forms.Button();
            this.ReadPortTextButton = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.MainDgv = new System.Windows.Forms.DataGridView();
            this.OkButton = new System.Windows.Forms.Button();
            this.pinNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mergedNetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InOutType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.signalType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainDgv)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.ReadPiniButton);
            this.splitContainer1.Panel1.Controls.Add(this.ReadPortTextButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(961, 519);
            this.splitContainer1.SplitterDistance = 31;
            this.splitContainer1.TabIndex = 0;
            // 
            // ReadPiniButton
            // 
            this.ReadPiniButton.Location = new System.Drawing.Point(90, 3);
            this.ReadPiniButton.Name = "ReadPiniButton";
            this.ReadPiniButton.Size = new System.Drawing.Size(75, 25);
            this.ReadPiniButton.TabIndex = 1;
            this.ReadPiniButton.Text = "PiniFile";
            this.ReadPiniButton.UseVisualStyleBackColor = true;
            this.ReadPiniButton.Click += new System.EventHandler(this.ReadPiniButton_Click);
            // 
            // ReadPortTextButton
            // 
            this.ReadPortTextButton.Location = new System.Drawing.Point(9, 3);
            this.ReadPortTextButton.Name = "ReadPortTextButton";
            this.ReadPortTextButton.Size = new System.Drawing.Size(75, 25);
            this.ReadPortTextButton.TabIndex = 0;
            this.ReadPortTextButton.Text = "PortText";
            this.ReadPortTextButton.UseVisualStyleBackColor = true;
            this.ReadPortTextButton.Click += new System.EventHandler(this.ReadPortTextButton_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.MainDgv);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.OkButton);
            this.splitContainer2.Size = new System.Drawing.Size(961, 484);
            this.splitContainer2.SplitterDistance = 451;
            this.splitContainer2.TabIndex = 0;
            // 
            // MainDgv
            // 
            this.MainDgv.AllowUserToAddRows = false;
            this.MainDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pinNumber,
            this.netColor,
            this.netName,
            this.mergedNetName,
            this.InOutType,
            this.signalType});
            this.MainDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainDgv.Location = new System.Drawing.Point(0, 0);
            this.MainDgv.Name = "MainDgv";
            this.MainDgv.RowHeadersVisible = false;
            this.MainDgv.RowTemplate.Height = 21;
            this.MainDgv.Size = new System.Drawing.Size(961, 451);
            this.MainDgv.TabIndex = 0;
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.Location = new System.Drawing.Point(874, 3);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 25);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // pinNumber
            // 
            this.pinNumber.HeaderText = "ピン番号";
            this.pinNumber.Name = "pinNumber";
            // 
            // netColor
            // 
            this.netColor.HeaderText = "ネット色";
            this.netColor.Name = "netColor";
            // 
            // netName
            // 
            this.netName.HeaderText = "ネット名";
            this.netName.Name = "netName";
            // 
            // mergedNetName
            // 
            this.mergedNetName.HeaderText = "ネット名(マージ)";
            this.mergedNetName.Name = "mergedNetName";
            // 
            // InOutType
            // 
            this.InOutType.HeaderText = "I / O";
            this.InOutType.Name = "InOutType";
            // 
            // signalType
            // 
            this.signalType.HeaderText = "A / D";
            this.signalType.Name = "signalType";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 519);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "PortText";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView MainDgv;
        private System.Windows.Forms.Button ReadPiniButton;
        private System.Windows.Forms.Button ReadPortTextButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn pinNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn netColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn netName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mergedNetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn InOutType;
        private System.Windows.Forms.DataGridViewTextBoxColumn signalType;
    }
}

