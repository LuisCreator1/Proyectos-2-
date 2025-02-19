namespace SimonDice
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            p_3 = new PictureBox();
            p_1 = new PictureBox();
            p_0 = new PictureBox();
            p_2 = new PictureBox();
            btn_iniciar = new Button();
            lbl_puntaje = new Label();
            ((System.ComponentModel.ISupportInitialize)p_3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)p_1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)p_0).BeginInit();
            ((System.ComponentModel.ISupportInitialize)p_2).BeginInit();
            SuspendLayout();
            // 
            // p_3
            // 
            p_3.Image = (Image)resources.GetObject("p_3.Image");
            p_3.Location = new Point(278, 328);
            p_3.Margin = new Padding(4);
            p_3.Name = "p_3";
            p_3.Size = new Size(259, 282);
            p_3.TabIndex = 0;
            p_3.TabStop = false;
            // 
            // p_1
            // 
            p_1.Image = (Image)resources.GetObject("p_1.Image");
            p_1.Location = new Point(310, 16);
            p_1.Margin = new Padding(4);
            p_1.Name = "p_1";
            p_1.Size = new Size(190, 281);
            p_1.TabIndex = 1;
            p_1.TabStop = false;
            // 
            // p_0
            // 
            p_0.Image = (Image)resources.GetObject("p_0.Image");
            p_0.Location = new Point(41, 16);
            p_0.Margin = new Padding(4);
            p_0.Name = "p_0";
            p_0.Size = new Size(207, 279);
            p_0.TabIndex = 2;
            p_0.TabStop = false;
            // 
            // p_2
            // 
            p_2.Image = (Image)resources.GetObject("p_2.Image");
            p_2.Location = new Point(30, 334);
            p_2.Margin = new Padding(4);
            p_2.Name = "p_2";
            p_2.Size = new Size(218, 276);
            p_2.TabIndex = 3;
            p_2.TabStop = false;
            // 
            // btn_iniciar
            // 
            btn_iniciar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_iniciar.Location = new Point(570, 249);
            btn_iniciar.Margin = new Padding(4);
            btn_iniciar.Name = "btn_iniciar";
            btn_iniciar.Size = new Size(249, 116);
            btn_iniciar.TabIndex = 4;
            btn_iniciar.Text = "Iniciar Juego";
            btn_iniciar.UseVisualStyleBackColor = true;
            btn_iniciar.Click += btn_iniciar_Click;
            // 
            // lbl_puntaje
            // 
            lbl_puntaje.AutoSize = true;
            lbl_puntaje.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_puntaje.Location = new Point(665, 158);
            lbl_puntaje.Margin = new Padding(4, 0, 4, 0);
            lbl_puntaje.Name = "lbl_puntaje";
            lbl_puntaje.Size = new Size(55, 54);
            lbl_puntaje.TabIndex = 5;
            lbl_puntaje.Text = "--";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 623);
            Controls.Add(lbl_puntaje);
            Controls.Add(btn_iniciar);
            Controls.Add(p_2);
            Controls.Add(p_0);
            Controls.Add(p_1);
            Controls.Add(p_3);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)p_3).EndInit();
            ((System.ComponentModel.ISupportInitialize)p_1).EndInit();
            ((System.ComponentModel.ISupportInitialize)p_0).EndInit();
            ((System.ComponentModel.ISupportInitialize)p_2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox p_3;
        private PictureBox p_1;
        private PictureBox p_0;
        private PictureBox p_2;
        private Button btn_iniciar;
        private Label lbl_puntaje;
    }
}
