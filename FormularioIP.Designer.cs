namespace Desafio_3
{
    partial class FormularioIP
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
            label1 = new Label();
            lblTipo = new Label();
            lblIP = new Label();
            txtDireccionIP = new TextBox();
            txtDireccionRed = new TextBox();
            lblRed = new Label();
            btnGuardarIP = new Button();
            btnCancelarIP = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(392, 33);
            label1.TabIndex = 1;
            label1.Text = "Configuración de Dispositivo";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(26, 96);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(109, 15);
            lblTipo.TabIndex = 2;
            lblTipo.Text = "Tipo de dispositivo:";
            // 
            // lblIP
            // 
            lblIP.AutoSize = true;
            lblIP.Location = new Point(26, 149);
            lblIP.Name = "lblIP";
            lblIP.Size = new Size(73, 15);
            lblIP.TabIndex = 3;
            lblIP.Text = "Dirección IP:";
            // 
            // txtDireccionIP
            // 
            txtDireccionIP.Location = new Point(151, 146);
            txtDireccionIP.Name = "txtDireccionIP";
            txtDireccionIP.Size = new Size(100, 23);
            txtDireccionIP.TabIndex = 4;
            // 
            // txtDireccionRed
            // 
            txtDireccionRed.Location = new Point(151, 196);
            txtDireccionRed.Name = "txtDireccionRed";
            txtDireccionRed.Size = new Size(100, 23);
            txtDireccionRed.TabIndex = 6;
            // 
            // lblRed
            // 
            lblRed.AutoSize = true;
            lblRed.Location = new Point(26, 199);
            lblRed.Name = "lblRed";
            lblRed.Size = new Size(109, 15);
            lblRed.TabIndex = 5;
            lblRed.Text = "Dirección IP de red:";
            // 
            // btnGuardarIP
            // 
            btnGuardarIP.Location = new Point(53, 251);
            btnGuardarIP.Name = "btnGuardarIP";
            btnGuardarIP.Size = new Size(126, 38);
            btnGuardarIP.TabIndex = 7;
            btnGuardarIP.Text = "Guardar";
            btnGuardarIP.UseVisualStyleBackColor = true;
            btnGuardarIP.Click += btnGuardarIP_Click;
            // 
            // btnCancelarIP
            // 
            btnCancelarIP.Location = new Point(223, 251);
            btnCancelarIP.Name = "btnCancelarIP";
            btnCancelarIP.Size = new Size(126, 38);
            btnCancelarIP.TabIndex = 8;
            btnCancelarIP.Text = "Cancelar";
            btnCancelarIP.UseVisualStyleBackColor = true;
            btnCancelarIP.Click += btnCancelarIP_Click;
            // 
            // FormularioIP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 326);
            Controls.Add(btnCancelarIP);
            Controls.Add(btnGuardarIP);
            Controls.Add(txtDireccionRed);
            Controls.Add(lblRed);
            Controls.Add(txtDireccionIP);
            Controls.Add(lblIP);
            Controls.Add(lblTipo);
            Controls.Add(label1);
            Name = "FormularioIP";
            Text = "FormularioIP";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblTipo;
        private Label lblIP;
        private TextBox txtDireccionIP;
        private TextBox txtDireccionRed;
        private Label lblRed;
        private Button btnGuardarIP;
        private Button btnCancelarIP;
    }
}