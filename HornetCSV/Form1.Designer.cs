
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
            this.SplitOnView = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.OpenButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SplitOnView)).BeginInit();
            this.SplitOnView.Panel1.SuspendLayout();
            this.SplitOnView.Panel2.SuspendLayout();
            this.SplitOnView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.SplitOnView.Panel1.Controls.Add(this.dataGridView1);
            // 
            // SplitOnView.Panel2
            // 
            this.SplitOnView.Panel2.Controls.Add(this.SaveButton);
            this.SplitOnView.Panel2.Controls.Add(this.OpenButton);
            this.SplitOnView.Size = new System.Drawing.Size(1264, 681);
            this.SplitOnView.SplitterDistance = 1000;
            this.SplitOnView.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1000, 681);
            this.dataGridView1.TabIndex = 0;
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(3, 646);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(254, 23);
            this.OpenButton.TabIndex = 0;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(3, 617);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(254, 23);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // MainAppView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.SplitOnView);
            this.Name = "MainAppView";
            this.Text = "Hornet CSV";
            this.SplitOnView.Panel1.ResumeLayout(false);
            this.SplitOnView.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitOnView)).EndInit();
            this.SplitOnView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SplitOnView;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button SaveButton;
    }
}

