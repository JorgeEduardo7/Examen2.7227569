﻿namespace SistemasConsultas.VISTAS.MenuConsultasVISTAS
{
    partial class MenuVISTAS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuVISTAS));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 167, 19);
            button1.Location = new Point(26, 21);
            button1.Name = "button1";
            button1.Size = new Size(124, 42);
            button1.TabIndex = 0;
            button1.Text = "Nombre de Clientes";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(26, 84);
            button2.Name = "button2";
            button2.Size = new Size(124, 42);
            button2.TabIndex = 1;
            button2.Text = "Proveedor Totales";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(26, 148);
            button3.Name = "button3";
            button3.Size = new Size(124, 42);
            button3.TabIndex = 2;
            button3.Text = "Marca Mas Vendida";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(26, 221);
            button4.Name = "button4";
            button4.Size = new Size(124, 42);
            button4.TabIndex = 3;
            button4.Text = "Cantidad Total de Productos en Stock";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(26, 292);
            button5.Name = "button5";
            button5.Size = new Size(124, 42);
            button5.TabIndex = 4;
            button5.Text = "Productos Prontos a Expirar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(504, 21);
            button6.Name = "button6";
            button6.Size = new Size(124, 42);
            button6.TabIndex = 5;
            button6.Text = "Ventas de Productos por Vendedor";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(504, 84);
            button7.Name = "button7";
            button7.Size = new Size(124, 42);
            button7.TabIndex = 6;
            button7.Text = "Total de Ingresos por Clientes";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(504, 142);
            button8.Name = "button8";
            button8.Size = new Size(124, 55);
            button8.TabIndex = 7;
            button8.Text = "Proveedor que Suministro Mas Productos";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(504, 221);
            button9.Name = "button9";
            button9.Size = new Size(124, 42);
            button9.TabIndex = 8;
            button9.Text = "Productos Vendidos por TipoProd";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(194, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(286, 257);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // MenuVISTAS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 0, 25);
            ClientSize = new Size(761, 389);
            Controls.Add(pictureBox1);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MenuVISTAS";
            Text = "MenuVISTAS";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private PictureBox pictureBox1;
    }
}