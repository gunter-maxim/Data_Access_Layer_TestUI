namespace Spectrum.UI
{
    partial class Form1
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
            this.lbTypes = new System.Windows.Forms.ListBox();
            this.btnSelectType = new System.Windows.Forms.Button();
            this.lbMaterials = new System.Windows.Forms.ListBox();
            this.btnSelectMaterial = new System.Windows.Forms.Button();
            this.lblEmbodiedImpact = new System.Windows.Forms.Label();
            this.lblEmbodiedImpactVal = new System.Windows.Forms.Label();
            this.lblDensity = new System.Windows.Forms.Label();
            this.lblDensityVal = new System.Windows.Forms.Label();
            this.lblThickness = new System.Windows.Forms.Label();
            this.lblThicknessVal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTypes
            // 
            this.lbTypes.FormattingEnabled = true;
            this.lbTypes.Location = new System.Drawing.Point(30, 12);
            this.lbTypes.Name = "lbTypes";
            this.lbTypes.Size = new System.Drawing.Size(189, 69);
            this.lbTypes.TabIndex = 0;
            // 
            // btnSelectType
            // 
            this.btnSelectType.Location = new System.Drawing.Point(246, 12);
            this.btnSelectType.Name = "btnSelectType";
            this.btnSelectType.Size = new System.Drawing.Size(75, 23);
            this.btnSelectType.TabIndex = 1;
            this.btnSelectType.Text = "Select Type";
            this.btnSelectType.UseVisualStyleBackColor = true;
            this.btnSelectType.Click += new System.EventHandler(this.btnSelectType_Click);
            // 
            // lbMaterials
            // 
            this.lbMaterials.FormattingEnabled = true;
            this.lbMaterials.Location = new System.Drawing.Point(30, 117);
            this.lbMaterials.Name = "lbMaterials";
            this.lbMaterials.Size = new System.Drawing.Size(189, 134);
            this.lbMaterials.TabIndex = 2;
            this.lbMaterials.Visible = false;
            // 
            // btnSelectMaterial
            // 
            this.btnSelectMaterial.Location = new System.Drawing.Point(246, 117);
            this.btnSelectMaterial.Name = "btnSelectMaterial";
            this.btnSelectMaterial.Size = new System.Drawing.Size(109, 23);
            this.btnSelectMaterial.TabIndex = 3;
            this.btnSelectMaterial.Text = "Select Material";
            this.btnSelectMaterial.UseCompatibleTextRendering = true;
            this.btnSelectMaterial.UseVisualStyleBackColor = true;
            this.btnSelectMaterial.Visible = false;
            this.btnSelectMaterial.Click += new System.EventHandler(this.btnSelectMaterial_Click);
            // 
            // lblEmbodiedImpact
            // 
            this.lblEmbodiedImpact.AutoSize = true;
            this.lblEmbodiedImpact.Location = new System.Drawing.Point(414, 68);
            this.lblEmbodiedImpact.Name = "lblEmbodiedImpact";
            this.lblEmbodiedImpact.Size = new System.Drawing.Size(142, 13);
            this.lblEmbodiedImpact.TabIndex = 4;
            this.lblEmbodiedImpact.Text = "Environmental Impact Factor";
            // 
            // lblEmbodiedImpactVal
            // 
            this.lblEmbodiedImpactVal.AutoSize = true;
            this.lblEmbodiedImpactVal.Location = new System.Drawing.Point(567, 68);
            this.lblEmbodiedImpactVal.Name = "lblEmbodiedImpactVal";
            this.lblEmbodiedImpactVal.Size = new System.Drawing.Size(27, 13);
            this.lblEmbodiedImpactVal.TabIndex = 5;
            this.lblEmbodiedImpactVal.Text = "N/A";
            // 
            // lblDensity
            // 
            this.lblDensity.AutoSize = true;
            this.lblDensity.Location = new System.Drawing.Point(414, 21);
            this.lblDensity.Name = "lblDensity";
            this.lblDensity.Size = new System.Drawing.Size(42, 13);
            this.lblDensity.TabIndex = 6;
            this.lblDensity.Text = "Density";
            // 
            // lblDensityVal
            // 
            this.lblDensityVal.AutoSize = true;
            this.lblDensityVal.Location = new System.Drawing.Point(567, 21);
            this.lblDensityVal.Name = "lblDensityVal";
            this.lblDensityVal.Size = new System.Drawing.Size(27, 13);
            this.lblDensityVal.TabIndex = 7;
            this.lblDensityVal.Text = "N/A";
            // 
            // lblThickness
            // 
            this.lblThickness.AutoSize = true;
            this.lblThickness.Location = new System.Drawing.Point(414, 117);
            this.lblThickness.Name = "lblThickness";
            this.lblThickness.Size = new System.Drawing.Size(56, 13);
            this.lblThickness.TabIndex = 8;
            this.lblThickness.Text = "Thickness";
            // 
            // lblThicknessVal
            // 
            this.lblThicknessVal.AutoSize = true;
            this.lblThicknessVal.Location = new System.Drawing.Point(567, 117);
            this.lblThicknessVal.Name = "lblThicknessVal";
            this.lblThicknessVal.Size = new System.Drawing.Size(27, 13);
            this.lblThicknessVal.TabIndex = 9;
            this.lblThicknessVal.Text = "N/A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 262);
            this.Controls.Add(this.lblThicknessVal);
            this.Controls.Add(this.lblThickness);
            this.Controls.Add(this.lblDensityVal);
            this.Controls.Add(this.lblDensity);
            this.Controls.Add(this.lblEmbodiedImpactVal);
            this.Controls.Add(this.lblEmbodiedImpact);
            this.Controls.Add(this.btnSelectMaterial);
            this.Controls.Add(this.lbMaterials);
            this.Controls.Add(this.btnSelectType);
            this.Controls.Add(this.lbTypes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbTypes;
        private System.Windows.Forms.Button btnSelectType;
        private System.Windows.Forms.ListBox lbMaterials;
        private System.Windows.Forms.Button btnSelectMaterial;
        private System.Windows.Forms.Label lblEmbodiedImpact;
        private System.Windows.Forms.Label lblEmbodiedImpactVal;
        private System.Windows.Forms.Label lblDensity;
        private System.Windows.Forms.Label lblDensityVal;
        private System.Windows.Forms.Label lblThickness;
        private System.Windows.Forms.Label lblThicknessVal;
    }
}

