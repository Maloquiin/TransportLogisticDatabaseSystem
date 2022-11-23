
namespace Diploma
{
    partial class MainD
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainD));
            this.closeLabel = new System.Windows.Forms.Label();
            this.ReloadButton = new Guna.UI2.WinForms.Guna2Button();
            this.buttonChange = new Guna.UI2.WinForms.Guna2Button();
            this.FullScreen = new System.Windows.Forms.Label();
            this.buttonDelete = new Guna.UI2.WinForms.Guna2Button();
            this.KlientsGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.Header2Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.ButtonKM = new Guna.UI2.WinForms.Guna2Button();
            this.ExitButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.buttonClients = new Guna.UI2.WinForms.Guna2Button();
            this.OwnButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.SearchText = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.AddButton = new Guna.UI2.WinForms.Guna2Button();
            this.Header = new Guna.UI2.WinForms.Guna2Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.KlientsGrid)).BeginInit();
            this.Header2Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.Header.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeLabel
            // 
            this.closeLabel.AutoSize = true;
            this.closeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeLabel.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeLabel.ForeColor = System.Drawing.Color.Black;
            this.closeLabel.Location = new System.Drawing.Point(719, 0);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(22, 23);
            this.closeLabel.TabIndex = 2;
            this.closeLabel.Text = "×";
            this.closeLabel.Click += new System.EventHandler(this.closeLabel_Click);
            this.closeLabel.MouseEnter += new System.EventHandler(this.closeLabel_MouseEnter);
            this.closeLabel.MouseLeave += new System.EventHandler(this.closeLabel_MouseLeave);
            // 
            // ReloadButton
            // 
            this.ReloadButton.Animated = true;
            this.ReloadButton.BorderRadius = 4;
            this.ReloadButton.CheckedState.Parent = this.ReloadButton;
            this.ReloadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReloadButton.CustomImages.Parent = this.ReloadButton;
            this.ReloadButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(196)))));
            this.ReloadButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ReloadButton.ForeColor = System.Drawing.Color.White;
            this.ReloadButton.HoverState.Parent = this.ReloadButton;
            this.ReloadButton.IndicateFocus = true;
            this.ReloadButton.Location = new System.Drawing.Point(105, 16);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.ShadowDecoration.Parent = this.ReloadButton;
            this.ReloadButton.Size = new System.Drawing.Size(90, 28);
            this.ReloadButton.TabIndex = 12;
            this.ReloadButton.Text = "Обновить";
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Animated = true;
            this.buttonChange.BorderRadius = 4;
            this.buttonChange.CheckedState.Parent = this.buttonChange;
            this.buttonChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChange.CustomImages.Parent = this.buttonChange;
            this.buttonChange.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(52)))), ((int)(((byte)(12)))));
            this.buttonChange.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonChange.ForeColor = System.Drawing.Color.White;
            this.buttonChange.HoverState.Parent = this.buttonChange;
            this.buttonChange.IndicateFocus = true;
            this.buttonChange.Location = new System.Drawing.Point(201, 16);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.ShadowDecoration.Parent = this.buttonChange;
            this.buttonChange.Size = new System.Drawing.Size(90, 28);
            this.buttonChange.TabIndex = 11;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // FullScreen
            // 
            this.FullScreen.AutoSize = true;
            this.FullScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FullScreen.Dock = System.Windows.Forms.DockStyle.Right;
            this.FullScreen.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullScreen.ForeColor = System.Drawing.Color.Black;
            this.FullScreen.Location = new System.Drawing.Point(696, 0);
            this.FullScreen.Name = "FullScreen";
            this.FullScreen.Size = new System.Drawing.Size(23, 23);
            this.FullScreen.TabIndex = 3;
            this.FullScreen.Text = " ⋄";
            this.FullScreen.Click += new System.EventHandler(this.FullScreen_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Animated = true;
            this.buttonDelete.BorderRadius = 4;
            this.buttonDelete.CheckedState.Parent = this.buttonDelete;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.CustomImages.Parent = this.buttonDelete;
            this.buttonDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(52)))), ((int)(((byte)(12)))));
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.HoverState.Parent = this.buttonDelete;
            this.buttonDelete.IndicateFocus = true;
            this.buttonDelete.Location = new System.Drawing.Point(297, 16);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.ShadowDecoration.Parent = this.buttonDelete;
            this.buttonDelete.Size = new System.Drawing.Size(90, 28);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // KlientsGrid
            // 
            this.KlientsGrid.AllowUserToAddRows = false;
            this.KlientsGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.KlientsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.KlientsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KlientsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.KlientsGrid.BackgroundColor = System.Drawing.Color.White;
            this.KlientsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KlientsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.KlientsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.KlientsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.KlientsGrid.ColumnHeadersHeight = 21;
            this.KlientsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.NameD});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.KlientsGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.KlientsGrid.EnableHeadersVisualStyles = false;
            this.KlientsGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.KlientsGrid.Location = new System.Drawing.Point(9, 57);
            this.KlientsGrid.Name = "KlientsGrid";
            this.KlientsGrid.ReadOnly = true;
            this.KlientsGrid.RowHeadersVisible = false;
            this.KlientsGrid.RowHeadersWidth = 51;
            this.KlientsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.KlientsGrid.Size = new System.Drawing.Size(698, 399);
            this.KlientsGrid.TabIndex = 0;
            this.KlientsGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.KlientsGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.KlientsGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.KlientsGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.KlientsGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.KlientsGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.KlientsGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.KlientsGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.KlientsGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(196)))));
            this.KlientsGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.KlientsGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.KlientsGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.KlientsGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.KlientsGrid.ThemeStyle.HeaderStyle.Height = 21;
            this.KlientsGrid.ThemeStyle.ReadOnly = true;
            this.KlientsGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.KlientsGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.KlientsGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.KlientsGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.KlientsGrid.ThemeStyle.RowsStyle.Height = 22;
            this.KlientsGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.KlientsGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.KlientsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KlientsGrid_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // NameD
            // 
            this.NameD.DataPropertyName = "NameD";
            this.NameD.HeaderText = "Имя";
            this.NameD.MinimumWidth = 6;
            this.NameD.Name = "NameD";
            this.NameD.ReadOnly = true;
            // 
            // guna2Button2
            // 
            this.guna2Button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button2.Animated = true;
            this.guna2Button2.BorderRadius = 4;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(52)))), ((int)(((byte)(12)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.IndicateFocus = true;
            this.guna2Button2.Location = new System.Drawing.Point(446, 37);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(116, 25);
            this.guna2Button2.TabIndex = 13;
            this.guna2Button2.Text = "Водители";
            // 
            // Header2Panel
            // 
            this.Header2Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(196)))));
            this.Header2Panel.Controls.Add(this.guna2Button2);
            this.Header2Panel.Controls.Add(this.ButtonKM);
            this.Header2Panel.Controls.Add(this.ExitButton);
            this.Header2Panel.Controls.Add(this.guna2Button3);
            this.Header2Panel.Controls.Add(this.buttonClients);
            this.Header2Panel.Controls.Add(this.OwnButton);
            this.Header2Panel.Controls.Add(this.guna2PictureBox1);
            this.Header2Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header2Panel.Location = new System.Drawing.Point(0, 24);
            this.Header2Panel.Name = "Header2Panel";
            this.Header2Panel.ShadowDecoration.Parent = this.Header2Panel;
            this.Header2Panel.Size = new System.Drawing.Size(741, 75);
            this.Header2Panel.TabIndex = 10;
            // 
            // ButtonKM
            // 
            this.ButtonKM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonKM.Animated = true;
            this.ButtonKM.BorderRadius = 4;
            this.ButtonKM.CheckedState.Parent = this.ButtonKM;
            this.ButtonKM.CustomImages.Parent = this.ButtonKM;
            this.ButtonKM.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(38)))));
            this.ButtonKM.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonKM.ForeColor = System.Drawing.Color.White;
            this.ButtonKM.HoverState.Parent = this.ButtonKM;
            this.ButtonKM.IndicateFocus = true;
            this.ButtonKM.Location = new System.Drawing.Point(446, 6);
            this.ButtonKM.Name = "ButtonKM";
            this.ButtonKM.ShadowDecoration.Parent = this.ButtonKM;
            this.ButtonKM.Size = new System.Drawing.Size(116, 25);
            this.ButtonKM.TabIndex = 10;
            this.ButtonKM.Text = "Настройка КМ";
            this.ButtonKM.Click += new System.EventHandler(this.ButtonKM_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.Animated = true;
            this.ExitButton.BorderRadius = 4;
            this.ExitButton.CheckedState.Parent = this.ExitButton;
            this.ExitButton.CustomImages.Parent = this.ExitButton;
            this.ExitButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(38)))));
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.HoverState.Parent = this.ExitButton;
            this.ExitButton.IndicateFocus = true;
            this.ExitButton.Location = new System.Drawing.Point(569, 37);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.ShadowDecoration.Parent = this.ExitButton;
            this.ExitButton.Size = new System.Drawing.Size(150, 25);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "Сменить аккаунт";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button3.Animated = true;
            this.guna2Button3.BorderRadius = 4;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(38)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.IndicateFocus = true;
            this.guna2Button3.Location = new System.Drawing.Point(569, 6);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(150, 25);
            this.guna2Button3.TabIndex = 8;
            this.guna2Button3.Text = "Зарплата водителей";
            // 
            // buttonClients
            // 
            this.buttonClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClients.Animated = true;
            this.buttonClients.BorderRadius = 4;
            this.buttonClients.CheckedState.Parent = this.buttonClients;
            this.buttonClients.CustomImages.Parent = this.buttonClients;
            this.buttonClients.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(38)))));
            this.buttonClients.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonClients.ForeColor = System.Drawing.Color.White;
            this.buttonClients.HoverState.Parent = this.buttonClients;
            this.buttonClients.IndicateFocus = true;
            this.buttonClients.Location = new System.Drawing.Point(324, 37);
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.ShadowDecoration.Parent = this.buttonClients;
            this.buttonClients.Size = new System.Drawing.Size(116, 25);
            this.buttonClients.TabIndex = 7;
            this.buttonClients.Text = "Клиенты";
            this.buttonClients.Click += new System.EventHandler(this.buttonClients_Click);
            // 
            // OwnButton
            // 
            this.OwnButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OwnButton.Animated = true;
            this.OwnButton.BorderRadius = 4;
            this.OwnButton.CheckedState.Parent = this.OwnButton;
            this.OwnButton.CustomImages.Parent = this.OwnButton;
            this.OwnButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(38)))));
            this.OwnButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.OwnButton.ForeColor = System.Drawing.Color.White;
            this.OwnButton.HoverState.Parent = this.OwnButton;
            this.OwnButton.IndicateFocus = true;
            this.OwnButton.Location = new System.Drawing.Point(324, 6);
            this.OwnButton.Name = "OwnButton";
            this.OwnButton.ShadowDecoration.Parent = this.OwnButton;
            this.OwnButton.Size = new System.Drawing.Size(116, 25);
            this.OwnButton.TabIndex = 6;
            this.OwnButton.Text = "Главный экран";
            this.OwnButton.Click += new System.EventHandler(this.OwnButton_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(318, 75);
            this.guna2PictureBox1.TabIndex = 5;
            this.guna2PictureBox1.TabStop = false;
            // 
            // SearchText
            // 
            this.SearchText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchText.Animated = true;
            this.SearchText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(196)))));
            this.SearchText.BorderRadius = 4;
            this.SearchText.BorderThickness = 2;
            this.SearchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchText.DefaultText = "";
            this.SearchText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchText.DisabledState.Parent = this.SearchText;
            this.SearchText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(38)))));
            this.SearchText.FocusedState.Parent = this.SearchText;
            this.SearchText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(38)))));
            this.SearchText.HoverState.Parent = this.SearchText;
            this.SearchText.Location = new System.Drawing.Point(435, 16);
            this.SearchText.Name = "SearchText";
            this.SearchText.PasswordChar = '\0';
            this.SearchText.PlaceholderText = "Поиск...";
            this.SearchText.SelectedText = "";
            this.SearchText.ShadowDecoration.Parent = this.SearchText;
            this.SearchText.Size = new System.Drawing.Size(238, 28);
            this.SearchText.TabIndex = 1;
            this.SearchText.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.Location = new System.Drawing.Point(679, 16);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(28, 28);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 2;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // AddButton
            // 
            this.AddButton.Animated = true;
            this.AddButton.BorderRadius = 4;
            this.AddButton.CheckedState.Parent = this.AddButton;
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.CustomImages.Parent = this.AddButton;
            this.AddButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(196)))));
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.HoverState.Parent = this.AddButton;
            this.AddButton.IndicateFocus = true;
            this.AddButton.Location = new System.Drawing.Point(9, 16);
            this.AddButton.Name = "AddButton";
            this.AddButton.ShadowDecoration.Parent = this.AddButton;
            this.AddButton.Size = new System.Drawing.Size(90, 28);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Добавить";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Header
            // 
            this.Header.Controls.Add(this.FullScreen);
            this.Header.Controls.Add(this.closeLabel);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.ShadowDecoration.Parent = this.Header;
            this.Header.Size = new System.Drawing.Size(741, 24);
            this.Header.TabIndex = 9;
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            this.Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Header_MouseMove);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.ReloadButton);
            this.panel1.Controls.Add(this.buttonChange);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.KlientsGrid);
            this.panel1.Controls.Add(this.SearchText);
            this.panel1.Controls.Add(this.guna2PictureBox2);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Location = new System.Drawing.Point(12, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 482);
            this.panel1.TabIndex = 8;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 16;
            this.guna2BorderlessForm1.ContainerControl = this;
            // 
            // MainD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 599);
            this.Controls.Add(this.Header2Panel);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainD";
            this.Shown += new System.EventHandler(this.MainD_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.KlientsGrid)).EndInit();
            this.Header2Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label closeLabel;
        private Guna.UI2.WinForms.Guna2Button ReloadButton;
        private Guna.UI2.WinForms.Guna2Button buttonChange;
        private System.Windows.Forms.Label FullScreen;
        private Guna.UI2.WinForms.Guna2Button buttonDelete;
        private Guna.UI2.WinForms.Guna2DataGridView KlientsGrid;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Panel Header2Panel;
        private Guna.UI2.WinForms.Guna2Button ButtonKM;
        private Guna.UI2.WinForms.Guna2Button ExitButton;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button buttonClients;
        private Guna.UI2.WinForms.Guna2Button OwnButton;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox SearchText;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2Button AddButton;
        private Guna.UI2.WinForms.Guna2Panel Header;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameD;
    }
}