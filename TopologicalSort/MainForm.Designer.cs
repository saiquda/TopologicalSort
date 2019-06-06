using TopologicalSort;

namespace TopologicalSort
{
    partial class TopologicalSort
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
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.AboutButt = new System.Windows.Forms.Button();
            this.ExitButt = new System.Windows.Forms.Button();
            this.AlgoButton = new System.Windows.Forms.Button();
            this.BeginButton = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.beginPanel1 = new UserPanel.BeginPanel();
            this.webPanel1 = new UserPanel.WebPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.LeftPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.LeftPanel.Controls.Add(this.AboutButt);
            this.LeftPanel.Controls.Add(this.ExitButt);
            this.LeftPanel.Controls.Add(this.AlgoButton);
            this.LeftPanel.Controls.Add(this.BeginButton);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(20, 60);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(230, 720);
            this.LeftPanel.TabIndex = 0;
            // 
            // AboutButt
            // 
            this.AboutButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.AboutButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutButt.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.AboutButt.ForeColor = System.Drawing.Color.White;
            this.AboutButt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AboutButt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AboutButt.Location = new System.Drawing.Point(3, 218);
            this.AboutButt.Name = "AboutButt";
            this.AboutButt.Size = new System.Drawing.Size(207, 60);
            this.AboutButt.TabIndex = 11;
            this.AboutButt.Text = "Своиства";
            this.AboutButt.UseVisualStyleBackColor = false;
            this.AboutButt.Click += new System.EventHandler(this.AboutButt_Click);
            // 
            // ExitButt
            // 
            this.ExitButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.ExitButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButt.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.ExitButt.ForeColor = System.Drawing.Color.White;
            this.ExitButt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ExitButt.Location = new System.Drawing.Point(3, 284);
            this.ExitButt.Name = "ExitButt";
            this.ExitButt.Size = new System.Drawing.Size(207, 60);
            this.ExitButt.TabIndex = 10;
            this.ExitButt.Text = "Выход";
            this.ExitButt.UseVisualStyleBackColor = false;
            this.ExitButt.Click += new System.EventHandler(this.ExitButt_Click);
            // 
            // AlgoButton
            // 
            this.AlgoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.AlgoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AlgoButton.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.AlgoButton.ForeColor = System.Drawing.Color.White;
            this.AlgoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AlgoButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AlgoButton.Location = new System.Drawing.Point(3, 152);
            this.AlgoButton.Name = "AlgoButton";
            this.AlgoButton.Size = new System.Drawing.Size(207, 60);
            this.AlgoButton.TabIndex = 9;
            this.AlgoButton.Text = "Алгоритм";
            this.AlgoButton.UseVisualStyleBackColor = false;
            this.AlgoButton.Click += new System.EventHandler(this.AlgoButton_Click);
            // 
            // BeginButton
            // 
            this.BeginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.BeginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BeginButton.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.BeginButton.ForeColor = System.Drawing.Color.White;
            this.BeginButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BeginButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BeginButton.Location = new System.Drawing.Point(3, 86);
            this.BeginButton.Name = "BeginButton";
            this.BeginButton.Size = new System.Drawing.Size(207, 60);
            this.BeginButton.TabIndex = 7;
            this.BeginButton.Text = "Сортировка";
            this.BeginButton.UseVisualStyleBackColor = false;
            this.BeginButton.Click += new System.EventHandler(this.BeginButton_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.beginPanel1);
            this.MainPanel.Controls.Add(this.webPanel1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(250, 60);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1130, 720);
            this.MainPanel.TabIndex = 1;
            // 
            // beginPanel1
            // 
            this.beginPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.beginPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.beginPanel1.Location = new System.Drawing.Point(0, 0);
            this.beginPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.beginPanel1.Name = "beginPanel1";
            this.beginPanel1.Size = new System.Drawing.Size(1130, 720);
            this.beginPanel1.TabIndex = 1;
            this.beginPanel1.Load += new System.EventHandler(this.beginPanel1_Load);
            // 
            // webPanel1
            // 
            this.webPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webPanel1.Location = new System.Drawing.Point(0, 0);
            this.webPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.webPanel1.Name = "webPanel1";
            this.webPanel1.Size = new System.Drawing.Size(1130, 720);
            this.webPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "TopologicalSort";
            // 
            // TopologicalSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.LeftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TopologicalSort";
            this.Padding = new System.Windows.Forms.Padding(20, 60, 20, 20);
            this.Text = "Topological Sort";
            this.LeftPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button AlgoButton;
        private System.Windows.Forms.Button BeginButton;
        private UserPanel.WebPanel webPanel1;
        private UserPanel.BeginPanel beginPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitButt;
        private System.Windows.Forms.Button AboutButt;
    }
}

