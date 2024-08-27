namespace SecureCalculator
{
    partial class CalculationCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2CustomGradientPanel3 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            lb_calcu = new Label();
            guna2CustomGradientPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // guna2CustomGradientPanel3
            // 
            guna2CustomGradientPanel3.Controls.Add(lb_calcu);
            guna2CustomGradientPanel3.CustomizableEdges = customizableEdges1;
            guna2CustomGradientPanel3.Dock = DockStyle.Fill;
            guna2CustomGradientPanel3.FillColor = Color.FromArgb(0, 68, 249);
            guna2CustomGradientPanel3.FillColor2 = Color.Cyan;
            guna2CustomGradientPanel3.FillColor3 = Color.FromArgb(6, 236, 255);
            guna2CustomGradientPanel3.FillColor4 = Color.FromArgb(0, 159, 238);
            guna2CustomGradientPanel3.Location = new Point(0, 0);
            guna2CustomGradientPanel3.Name = "guna2CustomGradientPanel3";
            guna2CustomGradientPanel3.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2CustomGradientPanel3.Size = new Size(276, 78);
            guna2CustomGradientPanel3.TabIndex = 22;
            // 
            // lb_calcu
            // 
            lb_calcu.Anchor = AnchorStyles.Right;
            lb_calcu.BackColor = Color.Transparent;
            lb_calcu.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_calcu.ForeColor = Color.White;
            lb_calcu.Location = new Point(27, 16);
            lb_calcu.Name = "lb_calcu";
            lb_calcu.Size = new Size(223, 46);
            lb_calcu.TabIndex = 3;
            lb_calcu.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CalculationCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2CustomGradientPanel3);
            Name = "CalculationCard";
            Size = new Size(276, 78);
            guna2CustomGradientPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel3;
        public Label lb_calcu;
    }
}
