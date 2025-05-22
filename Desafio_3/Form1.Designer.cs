namespace Desafio_3
{
    partial class SimuladorRed
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
            label1 = new Label();
            label2 = new Label();
            cmbTipoDispositivo = new ComboBox();
            btnAgregarDispositivo = new Button();
            lstDispositivos = new ListBox();
            btnEditarIP = new Button();
            btnEliminarDispositivo = new Button();
            panelDibujo = new Panel();
            btnConectar = new Button();
            btnPing = new Button();
            btnGuardar = new Button();
            btnCargar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(242, 18);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(245, 33);
            label1.TabIndex = 0;
            label1.Text = "Simulador de Red";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(23, 70);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 1;
            label2.Text = "Tipo Dispositivo:";
            // 
            // cmbTipoDispositivo
            // 
            cmbTipoDispositivo.Font = new Font("Segoe UI", 9F);
            cmbTipoDispositivo.FormattingEnabled = true;
            cmbTipoDispositivo.Location = new Point(170, 68);
            cmbTipoDispositivo.Margin = new Padding(3, 4, 3, 4);
            cmbTipoDispositivo.Name = "cmbTipoDispositivo";
            cmbTipoDispositivo.Size = new Size(121, 23);
            cmbTipoDispositivo.TabIndex = 2;
            // 
            // btnAgregarDispositivo
            // 
            btnAgregarDispositivo.Font = new Font("Segoe UI", 9F);
            btnAgregarDispositivo.Location = new Point(23, 127);
            btnAgregarDispositivo.Margin = new Padding(3, 4, 3, 4);
            btnAgregarDispositivo.Name = "btnAgregarDispositivo";
            btnAgregarDispositivo.Size = new Size(162, 48);
            btnAgregarDispositivo.TabIndex = 3;
            btnAgregarDispositivo.Text = "Agregar Dispositivo";
            btnAgregarDispositivo.UseVisualStyleBackColor = true;
            btnAgregarDispositivo.Click += btnAgregarDispositivo_Click;
            // 
            // lstDispositivos
            // 
            lstDispositivos.Font = new Font("Segoe UI", 9F);
            lstDispositivos.FormattingEnabled = true;
            lstDispositivos.ItemHeight = 15;
            lstDispositivos.Location = new Point(23, 256);
            lstDispositivos.Name = "lstDispositivos";
            lstDispositivos.Size = new Size(341, 124);
            lstDispositivos.TabIndex = 4;
            // 
            // btnEditarIP
            // 
            btnEditarIP.Font = new Font("Segoe UI", 9F);
            btnEditarIP.Location = new Point(23, 201);
            btnEditarIP.Margin = new Padding(3, 4, 3, 4);
            btnEditarIP.Name = "btnEditarIP";
            btnEditarIP.Size = new Size(162, 48);
            btnEditarIP.TabIndex = 5;
            btnEditarIP.Text = "Editar IP";
            btnEditarIP.UseVisualStyleBackColor = true;
            btnEditarIP.Click += btnEditarIP_Click;
            // 
            // btnEliminarDispositivo
            // 
            btnEliminarDispositivo.Font = new Font("Segoe UI", 9F);
            btnEliminarDispositivo.Location = new Point(202, 201);
            btnEliminarDispositivo.Margin = new Padding(3, 4, 3, 4);
            btnEliminarDispositivo.Name = "btnEliminarDispositivo";
            btnEliminarDispositivo.Size = new Size(162, 48);
            btnEliminarDispositivo.TabIndex = 6;
            btnEliminarDispositivo.Text = "Eliminar";
            btnEliminarDispositivo.UseVisualStyleBackColor = true;
            btnEliminarDispositivo.Click += btnEliminarDispositivo_Click;
            // 
            // panelDibujo
            // 
            panelDibujo.Location = new Point(371, 67);
            panelDibujo.Name = "panelDibujo";
            panelDibujo.Size = new Size(547, 551);
            panelDibujo.TabIndex = 7;
            panelDibujo.Paint += panelDibujo_Paint;
            panelDibujo.MouseClick += panelDibujo_MouseClick;
            // 
            // btnConectar
            // 
            btnConectar.Font = new Font("Segoe UI", 9F);
            btnConectar.Location = new Point(23, 404);
            btnConectar.Margin = new Padding(3, 4, 3, 4);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(162, 48);
            btnConectar.TabIndex = 8;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // btnPing
            // 
            btnPing.Font = new Font("Segoe UI", 9F);
            btnPing.Location = new Point(202, 404);
            btnPing.Margin = new Padding(3, 4, 3, 4);
            btnPing.Name = "btnPing";
            btnPing.Size = new Size(162, 48);
            btnPing.TabIndex = 9;
            btnPing.Text = "Ping";
            btnPing.UseVisualStyleBackColor = true;
            btnPing.Click += btnPing_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 9F);
            btnGuardar.Location = new Point(23, 460);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(162, 48);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCargar
            // 
            btnCargar.Font = new Font("Segoe UI", 9F);
            btnCargar.Location = new Point(203, 460);
            btnCargar.Margin = new Padding(3, 4, 3, 4);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(162, 48);
            btnCargar.TabIndex = 11;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // SimuladorRed
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 630);
            Controls.Add(btnCargar);
            Controls.Add(btnGuardar);
            Controls.Add(btnPing);
            Controls.Add(btnConectar);
            Controls.Add(panelDibujo);
            Controls.Add(btnEliminarDispositivo);
            Controls.Add(btnEditarIP);
            Controls.Add(lstDispositivos);
            Controls.Add(btnAgregarDispositivo);
            Controls.Add(cmbTipoDispositivo);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "SimuladorRed";
            Text = "SimuladorRed";
            Load += SimuladorRed_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbTipoDispositivo;
        private Button btnAgregarDispositivo;
        private ListBox lstDispositivos;
        private Button btnEditarIP;
        private Button btnEliminarDispositivo;
        private Panel panelDibujo;
        private Button btnConectar;
        private Button btnPing;
        private Button btnGuardar;
        private Button btnCargar;
    }
}
