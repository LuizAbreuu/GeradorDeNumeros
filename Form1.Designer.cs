namespace GeradordeNumeros
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
            Btn1 = new Button();
            resultadoLabel = new Label();
            SuspendLayout();
            // 
            // Btn1
            // 
            resources.ApplyResources(Btn1, "Btn1");
            Btn1.BackColor = Color.Lime;
            Btn1.ForeColor = SystemColors.Desktop;
            Btn1.Name = "Btn1";
            Btn1.UseVisualStyleBackColor = false;
            Btn1.UseWaitCursor = true;
            Btn1.Click += Btn1_Click;
            // 
            // resultadoLabel
            // 
            resources.ApplyResources(resultadoLabel, "resultadoLabel");
            resultadoLabel.Name = "resultadoLabel";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            BackgroundImage = Properties.Resources.dados;
            Controls.Add(resultadoLabel);
            Controls.Add(Btn1);
            Cursor = Cursors.Hand;
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn1;
        private Label resultadoLabel;
    }
}