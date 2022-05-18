using Entidades;

namespace Vista
{
    partial class FrmLlamador
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
            this.txtNroDestino = new System.Windows.Forms.TextBox();
            this.gboPanel = new System.Windows.Forms.GroupBox();
            this.btnAsterisco = new System.Windows.Forms.Button();
            this.brn0 = new System.Windows.Forms.Button();
            this.btnSharp = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnLlamar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtNroOrigen = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cmbFranja = new System.Windows.Forms.ComboBox();
            this.gboPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNroDestino
            // 
            this.txtNroDestino.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNroDestino.Location = new System.Drawing.Point(12, 12);
            this.txtNroDestino.Name = "txtNroDestino";
            this.txtNroDestino.ReadOnly = true;
            this.txtNroDestino.Size = new System.Drawing.Size(247, 36);
            this.txtNroDestino.TabIndex = 0;
            this.txtNroDestino.TabStop = false;
            // 
            // gboPanel
            // 
            this.gboPanel.Controls.Add(this.btnAsterisco);
            this.gboPanel.Controls.Add(this.brn0);
            this.gboPanel.Controls.Add(this.btnSharp);
            this.gboPanel.Controls.Add(this.btn7);
            this.gboPanel.Controls.Add(this.btn8);
            this.gboPanel.Controls.Add(this.btn9);
            this.gboPanel.Controls.Add(this.btn4);
            this.gboPanel.Controls.Add(this.btn5);
            this.gboPanel.Controls.Add(this.btn6);
            this.gboPanel.Controls.Add(this.btn2);
            this.gboPanel.Controls.Add(this.btn3);
            this.gboPanel.Controls.Add(this.btn1);
            this.gboPanel.Location = new System.Drawing.Point(12, 54);
            this.gboPanel.Name = "gboPanel";
            this.gboPanel.Size = new System.Drawing.Size(116, 167);
            this.gboPanel.TabIndex = 1;
            this.gboPanel.TabStop = false;
            this.gboPanel.Text = "Panel";
            // 
            // btnAsterisco
            // 
            this.btnAsterisco.Location = new System.Drawing.Point(6, 130);
            this.btnAsterisco.Name = "btnAsterisco";
            this.btnAsterisco.Size = new System.Drawing.Size(30, 30);
            this.btnAsterisco.TabIndex = 11;
            this.btnAsterisco.Text = "*";
            this.btnAsterisco.UseVisualStyleBackColor = true;
            // 
            // brn0
            // 
            this.brn0.Location = new System.Drawing.Point(42, 130);
            this.brn0.Name = "brn0";
            this.brn0.Size = new System.Drawing.Size(30, 30);
            this.brn0.TabIndex = 10;
            this.brn0.Text = "0";
            this.brn0.UseVisualStyleBackColor = true;
            this.brn0.Click += new System.EventHandler(this.brn0_Click);
            // 
            // btnSharp
            // 
            this.btnSharp.Location = new System.Drawing.Point(78, 130);
            this.btnSharp.Name = "btnSharp";
            this.btnSharp.Size = new System.Drawing.Size(30, 30);
            this.btnSharp.TabIndex = 9;
            this.btnSharp.Text = "#";
            this.btnSharp.UseVisualStyleBackColor = true;
            this.btnSharp.Click += new System.EventHandler(this.btnSharp_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(6, 94);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(30, 30);
            this.btn7.TabIndex = 8;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(42, 94);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(30, 30);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(78, 94);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(30, 30);
            this.btn9.TabIndex = 6;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(6, 58);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(30, 30);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(42, 58);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(30, 30);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(78, 58);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(30, 30);
            this.btn6.TabIndex = 3;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(42, 22);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(30, 30);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(78, 22);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(30, 30);
            this.btn3.TabIndex = 1;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(6, 22);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(30, 30);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnLlamar
            // 
            this.btnLlamar.Location = new System.Drawing.Point(134, 76);
            this.btnLlamar.Name = "btnLlamar";
            this.btnLlamar.Size = new System.Drawing.Size(124, 30);
            this.btnLlamar.TabIndex = 2;
            this.btnLlamar.Text = "Llamar";
            this.btnLlamar.UseVisualStyleBackColor = true;
            this.btnLlamar.Click += new System.EventHandler(this.btnLlamar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(134, 112);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(124, 30);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtNroOrigen
            // 
            this.txtNroOrigen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNroOrigen.Location = new System.Drawing.Point(134, 153);
            this.txtNroOrigen.Name = "txtNroOrigen";
            this.txtNroOrigen.ReadOnly = true;
            this.txtNroOrigen.Size = new System.Drawing.Size(124, 23);
            this.txtNroOrigen.TabIndex = 4;
            this.txtNroOrigen.Text = "Nro Origen";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(134, 184);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(124, 30);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cmbFranja
            // 
            this.cmbFranja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFranja.FormattingEnabled = true;
            this.cmbFranja.Location = new System.Drawing.Point(12, 227);
            this.cmbFranja.Name = "cmbFranja";
            this.cmbFranja.Size = new System.Drawing.Size(246, 23);
            this.cmbFranja.TabIndex = 6;
            // 
            // FrmLlamador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 260);
            this.Controls.Add(this.cmbFranja);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtNroOrigen);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnLlamar);
            this.Controls.Add(this.gboPanel);
            this.Controls.Add(this.txtNroDestino);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLlamador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Llamador";
            this.Load += new System.EventHandler(this.FrmLlamador_Load);
            this.gboPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNroDestino;
        private System.Windows.Forms.GroupBox gboPanel;
        private System.Windows.Forms.Button btnAsterisco;
        private System.Windows.Forms.Button brn0;
        private System.Windows.Forms.Button btnSharp;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnLlamar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtNroOrigen;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cmbFranja;
    }
}