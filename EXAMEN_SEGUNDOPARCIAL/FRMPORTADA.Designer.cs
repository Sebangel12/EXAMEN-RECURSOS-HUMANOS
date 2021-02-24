
namespace EXAMEN_SEGUNDOPARCIAL
{
    partial class PORTADA
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNSALIR = new System.Windows.Forms.Button();
            this.BTNCLIENTE = new System.Windows.Forms.Button();
            this.BTNEMPLEADO = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::EXAMEN_SEGUNDOPARCIAL.Properties.Resources.logo_espe;
            this.pictureBox1.Location = new System.Drawing.Point(24, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(768, 103);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::EXAMEN_SEGUNDOPARCIAL.Properties.Resources.redestel2;
            this.pictureBox2.Location = new System.Drawing.Point(24, 121);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(216, 221);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(78)))), ((int)(((byte)(82)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BTNSALIR);
            this.groupBox1.Controls.Add(this.BTNCLIENTE);
            this.groupBox1.Controls.Add(this.BTNEMPLEADO);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(407, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 221);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NAVEGADOR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "EXAMEN SEGUNDO PARCIAL";
            // 
            // BTNSALIR
            // 
            this.BTNSALIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSALIR.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BTNSALIR.Location = new System.Drawing.Point(292, 174);
            this.BTNSALIR.Name = "BTNSALIR";
            this.BTNSALIR.Size = new System.Drawing.Size(65, 27);
            this.BTNSALIR.TabIndex = 2;
            this.BTNSALIR.Text = "SALIR";
            this.BTNSALIR.UseVisualStyleBackColor = true;
            this.BTNSALIR.Click += new System.EventHandler(this.BTNSALIR_Click);
            // 
            // BTNCLIENTE
            // 
            this.BTNCLIENTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCLIENTE.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTNCLIENTE.Location = new System.Drawing.Point(147, 109);
            this.BTNCLIENTE.Name = "BTNCLIENTE";
            this.BTNCLIENTE.Size = new System.Drawing.Size(107, 27);
            this.BTNCLIENTE.TabIndex = 1;
            this.BTNCLIENTE.Text = "CLIENTE";
            this.BTNCLIENTE.UseVisualStyleBackColor = true;
            this.BTNCLIENTE.Click += new System.EventHandler(this.BTNCLIENTE_Click);
            // 
            // BTNEMPLEADO
            // 
            this.BTNEMPLEADO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNEMPLEADO.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTNEMPLEADO.Location = new System.Drawing.Point(147, 68);
            this.BTNEMPLEADO.Name = "BTNEMPLEADO";
            this.BTNEMPLEADO.Size = new System.Drawing.Size(107, 35);
            this.BTNEMPLEADO.TabIndex = 0;
            this.BTNEMPLEADO.Text = "EMPLEADO";
            this.BTNEMPLEADO.UseVisualStyleBackColor = true;
            this.BTNEMPLEADO.Click += new System.EventHandler(this.BTNEMPLEADO_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 80);
            this.label2.TabIndex = 4;
            this.label2.Text = "ANGEL SILVA\r\nPROGRAMACION \r\nVISUAL\r\n4101";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PORTADA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(161)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(820, 363);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PORTADA";
            this.Text = "FRMPORTADA";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNSALIR;
        private System.Windows.Forms.Button BTNCLIENTE;
        private System.Windows.Forms.Button BTNEMPLEADO;
        private System.Windows.Forms.Label label2;
    }
}