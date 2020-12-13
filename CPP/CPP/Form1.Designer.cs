namespace CPP
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
            this.btnParse = new System.Windows.Forms.Button();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.btnPlot = new System.Windows.Forms.Button();
            this.btnTextFile = new System.Windows.Forms.Button();
            this.TreeMainFun = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClearPlot = new System.Windows.Forms.Button();
            this.rbMcLaurinSerie = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUpperBound = new System.Windows.Forms.TextBox();
            this.tbLowerBound = new System.Windows.Forms.TextBox();
            this.rbIntegral = new System.Windows.Forms.RadioButton();
            this.rbDerivativeNewton = new System.Windows.Forms.RadioButton();
            this.rbDerAnalytically = new System.Windows.Forms.RadioButton();
            this.rbMainFunction = new System.Windows.Forms.RadioButton();
            this.TreeOtherOper = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.TreeMainFun)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TreeOtherOper)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnParse
            // 
            this.btnParse.Location = new System.Drawing.Point(16, 25);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(90, 42);
            this.btnParse.TabIndex = 0;
            this.btnParse.Text = "Parse";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(38, 25);
            this.tbInput.Multiline = true;
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(1468, 33);
            this.tbInput.TabIndex = 1;
            this.tbInput.TextChanged += new System.EventHandler(this.tbInput_TextChanged);
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(122, 25);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(318, 37);
            this.tbResult.TabIndex = 2;
            // 
            // btnPlot
            // 
            this.btnPlot.Location = new System.Drawing.Point(16, 81);
            this.btnPlot.Name = "btnPlot";
            this.btnPlot.Size = new System.Drawing.Size(110, 42);
            this.btnPlot.TabIndex = 3;
            this.btnPlot.Text = "Plot";
            this.btnPlot.UseVisualStyleBackColor = true;
            this.btnPlot.Click += new System.EventHandler(this.btnPlot_Click);
            // 
            // btnTextFile
            // 
            this.btnTextFile.Location = new System.Drawing.Point(157, 81);
            this.btnTextFile.Name = "btnTextFile";
            this.btnTextFile.Size = new System.Drawing.Size(133, 42);
            this.btnTextFile.TabIndex = 4;
            this.btnTextFile.Text = "Draw a tree";
            this.btnTextFile.UseVisualStyleBackColor = true;
            this.btnTextFile.Click += new System.EventHandler(this.btnTextFile_Click);
            // 
            // TreeMainFun
            // 
            this.TreeMainFun.Location = new System.Drawing.Point(36, 487);
            this.TreeMainFun.Name = "TreeMainFun";
            this.TreeMainFun.Size = new System.Drawing.Size(256, 445);
            this.TreeMainFun.TabIndex = 5;
            this.TreeMainFun.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClearPlot);
            this.groupBox1.Controls.Add(this.rbMcLaurinSerie);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbUpperBound);
            this.groupBox1.Controls.Add(this.tbLowerBound);
            this.groupBox1.Controls.Add(this.rbIntegral);
            this.groupBox1.Controls.Add(this.btnTextFile);
            this.groupBox1.Controls.Add(this.btnParse);
            this.groupBox1.Controls.Add(this.btnPlot);
            this.groupBox1.Controls.Add(this.rbDerivativeNewton);
            this.groupBox1.Controls.Add(this.tbResult);
            this.groupBox1.Controls.Add(this.rbDerAnalytically);
            this.groupBox1.Controls.Add(this.rbMainFunction);
            this.groupBox1.Location = new System.Drawing.Point(36, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 390);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operations";
            // 
            // btnClearPlot
            // 
            this.btnClearPlot.Location = new System.Drawing.Point(367, 329);
            this.btnClearPlot.Name = "btnClearPlot";
            this.btnClearPlot.Size = new System.Drawing.Size(110, 39);
            this.btnClearPlot.TabIndex = 21;
            this.btnClearPlot.Text = "Clear plot";
            this.btnClearPlot.UseVisualStyleBackColor = true;
            this.btnClearPlot.Click += new System.EventHandler(this.btnClearPlot_Click);
            // 
            // rbMcLaurinSerie
            // 
            this.rbMcLaurinSerie.AutoSize = true;
            this.rbMcLaurinSerie.Location = new System.Drawing.Point(6, 309);
            this.rbMcLaurinSerie.Name = "rbMcLaurinSerie";
            this.rbMcLaurinSerie.Size = new System.Drawing.Size(137, 24);
            this.rbMcLaurinSerie.TabIndex = 20;
            this.rbMcLaurinSerie.TabStop = true;
            this.rbMcLaurinSerie.Text = "McLaurin serie";
            this.rbMcLaurinSerie.UseVisualStyleBackColor = true;
            this.rbMcLaurinSerie.CheckedChanged += new System.EventHandler(this.rbMcLaurinSerie_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "X2 value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1161, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "X1 value";
            // 
            // tbUpperBound
            // 
            this.tbUpperBound.Location = new System.Drawing.Point(203, 273);
            this.tbUpperBound.Multiline = true;
            this.tbUpperBound.Name = "tbUpperBound";
            this.tbUpperBound.Size = new System.Drawing.Size(70, 33);
            this.tbUpperBound.TabIndex = 16;
            // 
            // tbLowerBound
            // 
            this.tbLowerBound.Location = new System.Drawing.Point(203, 227);
            this.tbLowerBound.Multiline = true;
            this.tbLowerBound.Name = "tbLowerBound";
            this.tbLowerBound.Size = new System.Drawing.Size(70, 33);
            this.tbLowerBound.TabIndex = 15;
            // 
            // rbIntegral
            // 
            this.rbIntegral.AutoSize = true;
            this.rbIntegral.Location = new System.Drawing.Point(6, 228);
            this.rbIntegral.Name = "rbIntegral";
            this.rbIntegral.Size = new System.Drawing.Size(88, 24);
            this.rbIntegral.TabIndex = 14;
            this.rbIntegral.TabStop = true;
            this.rbIntegral.Text = "Integral";
            this.rbIntegral.UseVisualStyleBackColor = true;
            // 
            // rbDerivativeNewton
            // 
            this.rbDerivativeNewton.AutoSize = true;
            this.rbDerivativeNewton.Location = new System.Drawing.Point(6, 189);
            this.rbDerivativeNewton.Name = "rbDerivativeNewton";
            this.rbDerivativeNewton.Size = new System.Drawing.Size(161, 24);
            this.rbDerivativeNewton.TabIndex = 13;
            this.rbDerivativeNewton.TabStop = true;
            this.rbDerivativeNewton.Text = "Derivative Newton";
            this.rbDerivativeNewton.UseVisualStyleBackColor = true;
            // 
            // rbDerAnalytically
            // 
            this.rbDerAnalytically.AutoSize = true;
            this.rbDerAnalytically.Location = new System.Drawing.Point(6, 159);
            this.rbDerAnalytically.Name = "rbDerAnalytically";
            this.rbDerAnalytically.Size = new System.Drawing.Size(182, 24);
            this.rbDerAnalytically.TabIndex = 10;
            this.rbDerAnalytically.TabStop = true;
            this.rbDerAnalytically.Text = "Derivative analytically";
            this.rbDerAnalytically.UseVisualStyleBackColor = true;
            // 
            // rbMainFunction
            // 
            this.rbMainFunction.AutoSize = true;
            this.rbMainFunction.Location = new System.Drawing.Point(6, 129);
            this.rbMainFunction.Name = "rbMainFunction";
            this.rbMainFunction.Size = new System.Drawing.Size(134, 24);
            this.rbMainFunction.TabIndex = 9;
            this.rbMainFunction.TabStop = true;
            this.rbMainFunction.Text = "Main Function";
            this.rbMainFunction.UseVisualStyleBackColor = true;
            // 
            // TreeOtherOper
            // 
            this.TreeOtherOper.Location = new System.Drawing.Point(298, 487);
            this.TreeOtherOper.Name = "TreeOtherOper";
            this.TreeOtherOper.Size = new System.Drawing.Size(274, 445);
            this.TreeOtherOper.TabIndex = 12;
            this.TreeOtherOper.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbInput);
            this.groupBox2.Location = new System.Drawing.Point(36, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1695, 73);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1743, 944);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TreeOtherOper);
            this.Controls.Add(this.TreeMainFun);
            this.Name = "Form1";
            this.Text = "Calculus";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.TreeMainFun)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TreeOtherOper)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button btnPlot;
        private System.Windows.Forms.Button btnTextFile;
        private System.Windows.Forms.PictureBox TreeMainFun;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMainFunction;
        private System.Windows.Forms.RadioButton rbDerAnalytically;
        private System.Windows.Forms.PictureBox TreeOtherOper;
        private System.Windows.Forms.RadioButton rbDerivativeNewton;
        private System.Windows.Forms.RadioButton rbIntegral;
        private System.Windows.Forms.TextBox tbUpperBound;
        private System.Windows.Forms.TextBox tbLowerBound;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbMcLaurinSerie;
        private System.Windows.Forms.Button btnClearPlot;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

