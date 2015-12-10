namespace PgStat
{
    partial class PgStatMainForm
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
            this.ConnectGroupBox = new System.Windows.Forms.GroupBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.PortLabel = new System.Windows.Forms.Label();
            this.ServerTextBox = new System.Windows.Forms.TextBox();
            this.ServerLabel = new System.Windows.Forms.Label();
            this.ResultsGroupBox = new System.Windows.Forms.GroupBox();
            this.ResultDataGridView = new System.Windows.Forms.DataGridView();
            this.GetResultButton = new System.Windows.Forms.Button();
            this.QueriesComboBox = new System.Windows.Forms.ComboBox();
            this.QueriesDataSet = new System.Data.DataSet();
            this.ConnectGroupBox.SuspendLayout();
            this.ResultsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueriesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ConnectGroupBox
            // 
            this.ConnectGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConnectGroupBox.Controls.Add(this.ConnectButton);
            this.ConnectGroupBox.Controls.Add(this.PasswordTextBox);
            this.ConnectGroupBox.Controls.Add(this.PasswordLabel);
            this.ConnectGroupBox.Controls.Add(this.UsernameTextBox);
            this.ConnectGroupBox.Controls.Add(this.UsernameLabel);
            this.ConnectGroupBox.Controls.Add(this.PortTextBox);
            this.ConnectGroupBox.Controls.Add(this.PortLabel);
            this.ConnectGroupBox.Controls.Add(this.ServerTextBox);
            this.ConnectGroupBox.Controls.Add(this.ServerLabel);
            this.ConnectGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ConnectGroupBox.Name = "ConnectGroupBox";
            this.ConnectGroupBox.Size = new System.Drawing.Size(760, 88);
            this.ConnectGroupBox.TabIndex = 0;
            this.ConnectGroupBox.TabStop = false;
            this.ConnectGroupBox.Text = "Подключение";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ConnectButton.Location = new System.Drawing.Point(640, 24);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(114, 23);
            this.ConnectButton.TabIndex = 8;
            this.ConnectButton.Text = "Подключить";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(284, 50);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.PasswordTextBox.TabIndex = 7;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(195, 53);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(48, 13);
            this.PasswordLabel.TabIndex = 6;
            this.PasswordLabel.Text = "Пароль:";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(284, 26);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.UsernameTextBox.TabIndex = 5;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(195, 29);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(83, 13);
            this.UsernameLabel.TabIndex = 4;
            this.UsernameLabel.Text = "Пользователь:";
            // 
            // PortTextBox
            // 
            this.PortTextBox.Location = new System.Drawing.Point(59, 50);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(100, 20);
            this.PortTextBox.TabIndex = 3;
            this.PortTextBox.Text = "5432";
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Location = new System.Drawing.Point(6, 53);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(35, 13);
            this.PortLabel.TabIndex = 2;
            this.PortLabel.Text = "Порт:";
            // 
            // ServerTextBox
            // 
            this.ServerTextBox.Location = new System.Drawing.Point(59, 26);
            this.ServerTextBox.Name = "ServerTextBox";
            this.ServerTextBox.Size = new System.Drawing.Size(100, 20);
            this.ServerTextBox.TabIndex = 1;
            // 
            // ServerLabel
            // 
            this.ServerLabel.AutoSize = true;
            this.ServerLabel.Location = new System.Drawing.Point(6, 29);
            this.ServerLabel.Name = "ServerLabel";
            this.ServerLabel.Size = new System.Drawing.Size(47, 13);
            this.ServerLabel.TabIndex = 0;
            this.ServerLabel.Text = "Сервер:";
            // 
            // ResultsGroupBox
            // 
            this.ResultsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultsGroupBox.Controls.Add(this.ResultDataGridView);
            this.ResultsGroupBox.Controls.Add(this.GetResultButton);
            this.ResultsGroupBox.Controls.Add(this.QueriesComboBox);
            this.ResultsGroupBox.Enabled = false;
            this.ResultsGroupBox.Location = new System.Drawing.Point(12, 106);
            this.ResultsGroupBox.Name = "ResultsGroupBox";
            this.ResultsGroupBox.Size = new System.Drawing.Size(760, 344);
            this.ResultsGroupBox.TabIndex = 1;
            this.ResultsGroupBox.TabStop = false;
            this.ResultsGroupBox.Text = "Результаты";
            // 
            // ResultDataGridView
            // 
            this.ResultDataGridView.AllowUserToAddRows = false;
            this.ResultDataGridView.AllowUserToDeleteRows = false;
            this.ResultDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultDataGridView.Location = new System.Drawing.Point(9, 46);
            this.ResultDataGridView.Name = "ResultDataGridView";
            this.ResultDataGridView.ReadOnly = true;
            this.ResultDataGridView.RowHeadersVisible = false;
            this.ResultDataGridView.Size = new System.Drawing.Size(745, 292);
            this.ResultDataGridView.TabIndex = 2;
            // 
            // GetResultButton
            // 
            this.GetResultButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GetResultButton.Location = new System.Drawing.Point(640, 17);
            this.GetResultButton.Name = "GetResultButton";
            this.GetResultButton.Size = new System.Drawing.Size(114, 23);
            this.GetResultButton.TabIndex = 1;
            this.GetResultButton.Text = "Выполнить";
            this.GetResultButton.UseVisualStyleBackColor = true;
            this.GetResultButton.Click += new System.EventHandler(this.GetResultButton_Click);
            // 
            // QueriesComboBox
            // 
            this.QueriesComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QueriesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QueriesComboBox.FormattingEnabled = true;
            this.QueriesComboBox.Location = new System.Drawing.Point(9, 19);
            this.QueriesComboBox.Name = "QueriesComboBox";
            this.QueriesComboBox.Size = new System.Drawing.Size(625, 21);
            this.QueriesComboBox.TabIndex = 0;
            // 
            // QueriesDataSet
            // 
            this.QueriesDataSet.DataSetName = "QueriesDataSet";
            // 
            // PgStatMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.ResultsGroupBox);
            this.Controls.Add(this.ConnectGroupBox);
            this.Name = "PgStatMainForm";
            this.Text = "PgStat";
            this.ConnectGroupBox.ResumeLayout(false);
            this.ConnectGroupBox.PerformLayout();
            this.ResultsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ResultDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueriesDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ConnectGroupBox;
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.TextBox ServerTextBox;
        private System.Windows.Forms.Label ServerLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.GroupBox ResultsGroupBox;
        private System.Windows.Forms.DataGridView ResultDataGridView;
        private System.Windows.Forms.Button GetResultButton;
        private System.Windows.Forms.ComboBox QueriesComboBox;
        private System.Data.DataSet QueriesDataSet;
    }
}

