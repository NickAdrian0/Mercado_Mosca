﻿namespace mercado_mosca
{
    partial class Ar
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
            this.bt = new System.Windows.Forms.Button();
            this.tbp = new System.Windows.Forms.TextBox();
            this.lbp = new System.Windows.Forms.Label();
            this.tbq = new System.Windows.Forms.TextBox();
            this.lbq = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // bt
            // 
            this.bt.Location = new System.Drawing.Point(434, 363);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(128, 30);
            this.bt.TabIndex = 35;
            this.bt.Text = "Adicionar ao carrinho";
            this.bt.UseVisualStyleBackColor = true;
            this.bt.Click += new System.EventHandler(this.bt_Click_1);
            // 
            // tbp
            // 
            this.tbp.Location = new System.Drawing.Point(486, 322);
            this.tbp.Name = "tbp";
            this.tbp.ReadOnly = true;
            this.tbp.Size = new System.Drawing.Size(143, 20);
            this.tbp.TabIndex = 34;
            // 
            // lbp
            // 
            this.lbp.AutoSize = true;
            this.lbp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbp.Location = new System.Drawing.Point(384, 320);
            this.lbp.Name = "lbp";
            this.lbp.Size = new System.Drawing.Size(54, 20);
            this.lbp.TabIndex = 33;
            this.lbp.Text = "Preço:";
            this.lbp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbq
            // 
            this.tbq.Location = new System.Drawing.Point(486, 290);
            this.tbq.Name = "tbq";
            this.tbq.Size = new System.Drawing.Size(143, 20);
            this.tbq.TabIndex = 32;
            this.tbq.TextChanged += new System.EventHandler(this.tbq_TextChanged);
            // 
            // lbq
            // 
            this.lbq.AutoSize = true;
            this.lbq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbq.Location = new System.Drawing.Point(384, 290);
            this.lbq.Name = "lbq";
            this.lbq.Size = new System.Drawing.Size(96, 20);
            this.lbq.TabIndex = 31;
            this.lbq.Text = "Quantidade:";
            this.lbq.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(316, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Voltar às compras";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "<-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "Ar condicionado de plástico CIAC por R$2403,00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::mercado_mosca.Properties.Resources.teste3;
            this.pictureBox1.Location = new System.Drawing.Point(-33, -33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 520);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.BackgroundImage = global::mercado_mosca.Properties.Resources.ar_plastico;
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox10.Location = new System.Drawing.Point(347, 21);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(381, 217);
            this.pictureBox10.TabIndex = 36;
            this.pictureBox10.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(693, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 37;
            this.button2.Text = "Ir para o carrinho";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Ar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.bt);
            this.Controls.Add(this.tbp);
            this.Controls.Add(this.lbp);
            this.Controls.Add(this.tbq);
            this.Controls.Add(this.lbq);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Ar";
            this.Text = "Ar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt;
        private System.Windows.Forms.TextBox tbp;
        private System.Windows.Forms.Label lbp;
        private System.Windows.Forms.TextBox tbq;
        private System.Windows.Forms.Label lbq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Button button2;
    }
}