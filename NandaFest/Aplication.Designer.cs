
namespace NandaFest
{
    partial class Aplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aplication));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnAgend = new FontAwesome.Sharp.IconButton();
            this.btnDec = new FontAwesome.Sharp.IconButton();
            this.btnTemas = new FontAwesome.Sharp.IconButton();
            this.btnfunc = new FontAwesome.Sharp.IconButton();
            this.btnClientes = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.minizebtn = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelDestop = new System.Windows.Forms.Panel();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDestop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnAgend);
            this.panelMenu.Controls.Add(this.btnDec);
            this.panelMenu.Controls.Add(this.btnTemas);
            this.panelMenu.Controls.Add(this.btnfunc);
            this.panelMenu.Controls.Add(this.btnClientes);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 631);
            this.panelMenu.TabIndex = 1;
            // 
            // btnAgend
            // 
            this.btnAgend.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgend.FlatAppearance.BorderSize = 0;
            this.btnAgend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgend.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAgend.IconChar = FontAwesome.Sharp.IconChar.CalendarDay;
            this.btnAgend.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAgend.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgend.IconSize = 32;
            this.btnAgend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgend.Location = new System.Drawing.Point(0, 380);
            this.btnAgend.Name = "btnAgend";
            this.btnAgend.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAgend.Size = new System.Drawing.Size(220, 60);
            this.btnAgend.TabIndex = 5;
            this.btnAgend.Text = "Agendamentos";
            this.btnAgend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgend.UseVisualStyleBackColor = true;
            this.btnAgend.Click += new System.EventHandler(this.btnAgend_Click);
            // 
            // btnDec
            // 
            this.btnDec.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDec.FlatAppearance.BorderSize = 0;
            this.btnDec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDec.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDec.IconChar = FontAwesome.Sharp.IconChar.HollyBerry;
            this.btnDec.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDec.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDec.IconSize = 32;
            this.btnDec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDec.Location = new System.Drawing.Point(0, 320);
            this.btnDec.Name = "btnDec";
            this.btnDec.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDec.Size = new System.Drawing.Size(220, 60);
            this.btnDec.TabIndex = 4;
            this.btnDec.Text = "Decorações";
            this.btnDec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDec.UseVisualStyleBackColor = true;
            this.btnDec.Click += new System.EventHandler(this.btnDec_Click);
            // 
            // btnTemas
            // 
            this.btnTemas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTemas.FlatAppearance.BorderSize = 0;
            this.btnTemas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTemas.IconChar = FontAwesome.Sharp.IconChar.PaintBrush;
            this.btnTemas.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTemas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTemas.IconSize = 32;
            this.btnTemas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTemas.Location = new System.Drawing.Point(0, 260);
            this.btnTemas.Name = "btnTemas";
            this.btnTemas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTemas.Size = new System.Drawing.Size(220, 60);
            this.btnTemas.TabIndex = 3;
            this.btnTemas.Text = "Temas";
            this.btnTemas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTemas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTemas.UseVisualStyleBackColor = true;
            this.btnTemas.Click += new System.EventHandler(this.btnTemas_Click);
            // 
            // btnfunc
            // 
            this.btnfunc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnfunc.FlatAppearance.BorderSize = 0;
            this.btnfunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfunc.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnfunc.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.btnfunc.IconColor = System.Drawing.Color.Gainsboro;
            this.btnfunc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnfunc.IconSize = 32;
            this.btnfunc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfunc.Location = new System.Drawing.Point(0, 200);
            this.btnfunc.Name = "btnfunc";
            this.btnfunc.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnfunc.Size = new System.Drawing.Size(220, 60);
            this.btnfunc.TabIndex = 2;
            this.btnfunc.Text = "Funcionarios";
            this.btnfunc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfunc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnfunc.UseVisualStyleBackColor = true;
            this.btnfunc.Click += new System.EventHandler(this.btnfunc_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClientes.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnClientes.IconColor = System.Drawing.Color.Gainsboro;
            this.btnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClientes.IconSize = 32;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 140);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnClientes.Size = new System.Drawing.Size(220, 60);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = global::NandaFest.Properties.Resources.logo;
            this.btnHome.Location = new System.Drawing.Point(3, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(214, 134);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.minizebtn);
            this.panelTitleBar.Controls.Add(this.btnclose);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(964, 80);
            this.panelTitleBar.TabIndex = 2;
            this.panelTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitleBar_Paint);
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // minizebtn
            // 
            this.minizebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.minizebtn.FlatAppearance.BorderSize = 0;
            this.minizebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minizebtn.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minizebtn.ForeColor = System.Drawing.Color.MediumPurple;
            this.minizebtn.Location = new System.Drawing.Point(882, 0);
            this.minizebtn.Name = "minizebtn";
            this.minizebtn.Size = new System.Drawing.Size(38, 35);
            this.minizebtn.TabIndex = 3;
            this.minizebtn.Text = "-";
            this.minizebtn.UseVisualStyleBackColor = true;
            this.minizebtn.Click += new System.EventHandler(this.minizebtn_Click);
            // 
            // btnclose
            // 
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnclose.Location = new System.Drawing.Point(926, 5);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(38, 35);
            this.btnclose.TabIndex = 2;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(55, 37);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(35, 13);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(17, 27);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelDestop
            // 
            this.panelDestop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDestop.Controls.Add(this.panelShadow);
            this.panelDestop.Location = new System.Drawing.Point(220, 80);
            this.panelDestop.Name = "panelDestop";
            this.panelDestop.Size = new System.Drawing.Size(964, 551);
            this.panelDestop.TabIndex = 3;
            this.panelDestop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDestop_Paint);
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(0, 0);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(964, 9);
            this.panelShadow.TabIndex = 0;
            this.panelShadow.Paint += new System.Windows.Forms.PaintEventHandler(this.panelShadow_Paint);
            // 
            // Aplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 631);
            this.Controls.Add(this.panelDestop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Aplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplication";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDestop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnAgend;
        private FontAwesome.Sharp.IconButton btnDec;
        private FontAwesome.Sharp.IconButton btnTemas;
        private FontAwesome.Sharp.IconButton btnfunc;
        private FontAwesome.Sharp.IconButton btnClientes;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelDestop;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button minizebtn;
    }
}