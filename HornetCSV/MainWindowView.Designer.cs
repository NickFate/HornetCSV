
namespace HornetCSV
{
    partial class MainAppView
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainAppView));
            this.SplitOnView = new System.Windows.Forms.SplitContainer();
            this.AppTable = new System.Windows.Forms.DataGridView();
            this.NewTableButton = new System.Windows.Forms.Button();
            this.AddRowButton = new System.Windows.Forms.Button();
            this.RemoveRowButton = new System.Windows.Forms.Button();
            this.RemoveColumnButton = new System.Windows.Forms.Button();
            this.AddColumnButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SplitOnView)).BeginInit();
            this.SplitOnView.Panel1.SuspendLayout();
            this.SplitOnView.Panel2.SuspendLayout();
            this.SplitOnView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppTable)).BeginInit();
            this.SuspendLayout();
            // 
            // SplitOnView
            // 
            this.SplitOnView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitOnView.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.SplitOnView.IsSplitterFixed = true;
            this.SplitOnView.Location = new System.Drawing.Point(0, 0);
            this.SplitOnView.Name = "SplitOnView";
            // 
            // SplitOnView.Panel1
            // 
            this.SplitOnView.Panel1.Controls.Add(this.AppTable);
            // 
            // SplitOnView.Panel2
            // 
            this.SplitOnView.Panel2.Controls.Add(this.NewTableButton);
            this.SplitOnView.Panel2.Controls.Add(this.AddRowButton);
            this.SplitOnView.Panel2.Controls.Add(this.RemoveRowButton);
            this.SplitOnView.Panel2.Controls.Add(this.RemoveColumnButton);
            this.SplitOnView.Panel2.Controls.Add(this.AddColumnButton);
            this.SplitOnView.Panel2.Controls.Add(this.SaveButton);
            this.SplitOnView.Panel2.Controls.Add(this.OpenButton);
            this.SplitOnView.Size = new System.Drawing.Size(1264, 681);
            this.SplitOnView.SplitterDistance = 1000;
            this.SplitOnView.TabIndex = 0;
            // 
            // AppTable
            // 
            this.AppTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppTable.Location = new System.Drawing.Point(0, 0);
            this.AppTable.Name = "AppTable";
            this.AppTable.Size = new System.Drawing.Size(1000, 681);
            this.AppTable.TabIndex = 0;
            // 
            // NewTableButton
            // 
            this.NewTableButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NewTableButton.Location = new System.Drawing.Point(3, 588);
            this.NewTableButton.Name = "NewTableButton";
            this.NewTableButton.Size = new System.Drawing.Size(254, 23);
            this.NewTableButton.TabIndex = 6;
            this.NewTableButton.Text = "New Table";
            this.NewTableButton.UseVisualStyleBackColor = true;
            this.NewTableButton.Click += new System.EventHandler(this.NewTableButton_Click);
            // 
            // AddRowButton
            // 
            this.AddRowButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddRowButton.Location = new System.Drawing.Point(3, 501);
            this.AddRowButton.Name = "AddRowButton";
            this.AddRowButton.Size = new System.Drawing.Size(254, 23);
            this.AddRowButton.TabIndex = 5;
            this.AddRowButton.Text = "Add row";
            this.AddRowButton.UseVisualStyleBackColor = true;
            this.AddRowButton.Click += new System.EventHandler(this.AddRowButton_Click);
            // 
            // RemoveRowButton
            // 
            this.RemoveRowButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveRowButton.Location = new System.Drawing.Point(3, 472);
            this.RemoveRowButton.Name = "RemoveRowButton";
            this.RemoveRowButton.Size = new System.Drawing.Size(254, 23);
            this.RemoveRowButton.TabIndex = 4;
            this.RemoveRowButton.Text = "Remove row";
            this.RemoveRowButton.UseVisualStyleBackColor = true;
            this.RemoveRowButton.Click += new System.EventHandler(this.RemoveRowButton_Click);
            // 
            // RemoveColumnButton
            // 
            this.RemoveColumnButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveColumnButton.Location = new System.Drawing.Point(2, 530);
            this.RemoveColumnButton.Name = "RemoveColumnButton";
            this.RemoveColumnButton.Size = new System.Drawing.Size(254, 23);
            this.RemoveColumnButton.TabIndex = 3;
            this.RemoveColumnButton.Text = "Remove column";
            this.RemoveColumnButton.UseVisualStyleBackColor = true;
            this.RemoveColumnButton.Click += new System.EventHandler(this.RemoveColumnButton_Click);
            // 
            // AddColumnButton
            // 
            this.AddColumnButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddColumnButton.Location = new System.Drawing.Point(2, 559);
            this.AddColumnButton.Name = "AddColumnButton";
            this.AddColumnButton.Size = new System.Drawing.Size(254, 23);
            this.AddColumnButton.TabIndex = 2;
            this.AddColumnButton.Text = "Add column";
            this.AddColumnButton.UseVisualStyleBackColor = true;
            this.AddColumnButton.Click += new System.EventHandler(this.AddColumnButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(3, 617);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(254, 23);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenButton.Location = new System.Drawing.Point(3, 646);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(254, 23);
            this.OpenButton.TabIndex = 0;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // MainAppView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.SplitOnView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainAppView";
            this.Text = "Hornet CSV";
            this.SplitOnView.Panel1.ResumeLayout(false);
            this.SplitOnView.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitOnView)).EndInit();
            this.SplitOnView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AppTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SplitOnView;
        private System.Windows.Forms.DataGridView AppTable;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button AddColumnButton;
        private System.Windows.Forms.Button RemoveColumnButton;
        private System.Windows.Forms.Button AddRowButton;
        private System.Windows.Forms.Button RemoveRowButton;
        private System.Windows.Forms.Button NewTableButton;
    }
}

