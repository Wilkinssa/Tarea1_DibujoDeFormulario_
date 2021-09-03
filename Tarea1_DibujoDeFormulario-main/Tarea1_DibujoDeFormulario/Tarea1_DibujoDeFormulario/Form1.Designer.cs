
namespace Tarea1_DibujoDeFormulario
{
    partial class RegistrosUsuarioForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrosUsuarioForm));
            this.AliasLabel = new System.Windows.Forms.Label();
            this.ClaveLabel = new System.Windows.Forms.Label();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.ConfirmarClaveLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.CostoXHoraLabel = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.AliasTextBox = new System.Windows.Forms.TextBox();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.CostoXHoraTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.NivelLabel = new System.Windows.Forms.Label();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.ActivoCheckBox = new System.Windows.Forms.CheckBox();
            this.NivelComboBox = new System.Windows.Forms.ComboBox();
            this.ConfirmaClaveTextBox = new System.Windows.Forms.TextBox();
            this.ClaveTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AliasLabel
            // 
            this.AliasLabel.AutoSize = true;
            this.AliasLabel.Location = new System.Drawing.Point(6, 46);
            this.AliasLabel.Name = "AliasLabel";
            this.AliasLabel.Size = new System.Drawing.Size(32, 15);
            this.AliasLabel.TabIndex = 1;
            this.AliasLabel.Text = "Alias";
            this.AliasLabel.Click += new System.EventHandler(this.AliasLabel_Click);
            // 
            // ClaveLabel
            // 
            this.ClaveLabel.AutoSize = true;
            this.ClaveLabel.Location = new System.Drawing.Point(6, 121);
            this.ClaveLabel.Name = "ClaveLabel";
            this.ClaveLabel.Size = new System.Drawing.Size(36, 15);
            this.ClaveLabel.TabIndex = 6;
            this.ClaveLabel.Text = "Clave";
            this.ClaveLabel.Click += new System.EventHandler(this.ClaveLabel_Click);
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Location = new System.Drawing.Point(6, 82);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(51, 15);
            this.NombreLabel.TabIndex = 5;
            this.NombreLabel.Text = "Nombre";
            this.NombreLabel.Click += new System.EventHandler(this.NombreLabel_Click);
            // 
            // IDLabel
            // 
            this.IDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(6, 12);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(18, 15);
            this.IDLabel.TabIndex = 4;
            this.IDLabel.Text = "ID";
            this.IDLabel.Click += new System.EventHandler(this.IDLabel_Click);
            // 
            // ConfirmarClaveLabel
            // 
            this.ConfirmarClaveLabel.AutoSize = true;
            this.ConfirmarClaveLabel.Location = new System.Drawing.Point(172, 123);
            this.ConfirmarClaveLabel.Name = "ConfirmarClaveLabel";
            this.ConfirmarClaveLabel.Size = new System.Drawing.Size(93, 15);
            this.ConfirmarClaveLabel.TabIndex = 8;
            this.ConfirmarClaveLabel.Text = "Confirmar Clave";
            this.ConfirmarClaveLabel.Click += new System.EventHandler(this.ConfirmarClaveLabel_Click);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(325, 84);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(41, 15);
            this.EmailLabel.TabIndex = 9;
            this.EmailLabel.Text = "E-mail";
            // 
            // CostoXHoraLabel
            // 
            this.CostoXHoraLabel.AutoSize = true;
            this.CostoXHoraLabel.Location = new System.Drawing.Point(443, 123);
            this.CostoXHoraLabel.Name = "CostoXHoraLabel";
            this.CostoXHoraLabel.Size = new System.Drawing.Size(76, 15);
            this.CostoXHoraLabel.TabIndex = 10;
            this.CostoXHoraLabel.Text = "Costo x Hora";
            this.CostoXHoraLabel.Click += new System.EventHandler(this.CostoXHoraLabel_Click);
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(43, 9);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(90, 23);
            this.IDTextBox.TabIndex = 11;
            this.IDTextBox.TextChanged += new System.EventHandler(this.IDTextBox_TextChanged);
            // 
            // AliasTextBox
            // 
            this.AliasTextBox.Location = new System.Drawing.Point(43, 40);
            this.AliasTextBox.Name = "AliasTextBox";
            this.AliasTextBox.Size = new System.Drawing.Size(123, 23);
            this.AliasTextBox.TabIndex = 12;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(64, 82);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(250, 23);
            this.NombreTextBox.TabIndex = 13;
            // 
            // CostoXHoraTextBox
            // 
            this.CostoXHoraTextBox.Location = new System.Drawing.Point(526, 123);
            this.CostoXHoraTextBox.Name = "CostoXHoraTextBox";
            this.CostoXHoraTextBox.Size = new System.Drawing.Size(71, 23);
            this.CostoXHoraTextBox.TabIndex = 14;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(369, 82);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(228, 23);
            this.EmailTextBox.TabIndex = 15;
            // 
            // NivelLabel
            // 
            this.NivelLabel.AutoSize = true;
            this.NivelLabel.Location = new System.Drawing.Point(435, 46);
            this.NivelLabel.Name = "NivelLabel";
            this.NivelLabel.Size = new System.Drawing.Size(34, 15);
            this.NivelLabel.TabIndex = 16;
            this.NivelLabel.Text = "Nivel";
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoButton.Image")));
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoButton.Location = new System.Drawing.Point(222, 173);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(53, 56);
            this.NuevoButton.TabIndex = 19;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoButton.UseVisualStyleBackColor = true;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.Location = new System.Drawing.Point(305, 173);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(61, 58);
            this.GuardarButton.TabIndex = 20;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarButton.UseVisualStyleBackColor = true;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarButton.Location = new System.Drawing.Point(388, 175);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(60, 56);
            this.EliminarButton.TabIndex = 21;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarButton.UseVisualStyleBackColor = true;
            // 
            // ActivoCheckBox
            // 
            this.ActivoCheckBox.AutoSize = true;
            this.ActivoCheckBox.Location = new System.Drawing.Point(537, 21);
            this.ActivoCheckBox.Name = "ActivoCheckBox";
            this.ActivoCheckBox.Size = new System.Drawing.Size(60, 19);
            this.ActivoCheckBox.TabIndex = 22;
            this.ActivoCheckBox.Text = "Activo";
            this.ActivoCheckBox.UseVisualStyleBackColor = true;
            this.ActivoCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // NivelComboBox
            // 
            this.NivelComboBox.FormattingEnabled = true;
            this.NivelComboBox.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.NivelComboBox.Location = new System.Drawing.Point(476, 46);
            this.NivelComboBox.Name = "NivelComboBox";
            this.NivelComboBox.Size = new System.Drawing.Size(121, 23);
            this.NivelComboBox.TabIndex = 23;
            // 
            // ConfirmaClaveTextBox
            // 
            this.ConfirmaClaveTextBox.Location = new System.Drawing.Point(271, 120);
            this.ConfirmaClaveTextBox.Name = "ConfirmaClaveTextBox";
            this.ConfirmaClaveTextBox.Size = new System.Drawing.Size(115, 23);
            this.ConfirmaClaveTextBox.TabIndex = 24;
            this.ConfirmaClaveTextBox.UseSystemPasswordChar = true;
            // 
            // ClaveTextBox
            // 
            this.ClaveTextBox.Location = new System.Drawing.Point(48, 118);
            this.ClaveTextBox.Name = "ClaveTextBox";
            this.ClaveTextBox.Size = new System.Drawing.Size(115, 23);
            this.ClaveTextBox.TabIndex = 26;
            this.ClaveTextBox.UseSystemPasswordChar = true;
            // 
            // RegistrosUsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 249);
            this.Controls.Add(this.ClaveTextBox);
            this.Controls.Add(this.ConfirmaClaveTextBox);
            this.Controls.Add(this.NivelComboBox);
            this.Controls.Add(this.ActivoCheckBox);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.NivelLabel);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.CostoXHoraTextBox);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.AliasTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.CostoXHoraLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.ConfirmarClaveLabel);
            this.Controls.Add(this.ClaveLabel);
            this.Controls.Add(this.NombreLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.AliasLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegistrosUsuarioForm";
            this.Text = "Registro De Usuarios";
            this.Load += new System.EventHandler(this.RegistrosUsuarioForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label AliasLabel;
        private System.Windows.Forms.Label ClaveLabel;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label ConfirmarClaveLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label CostoXHoraLabel;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.TextBox AliasTextBox;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.TextBox CostoXHoraTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label NivelLabel;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.CheckBox ActivoCheckBox;
        private System.Windows.Forms.ComboBox NivelComboBox;
        private System.Windows.Forms.TextBox ConfirmaClaveTextBox;
        private System.Windows.Forms.TextBox ClaveTextBox;
    }
}

