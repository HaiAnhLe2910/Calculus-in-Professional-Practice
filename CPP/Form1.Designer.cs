namespace CPP
{
    partial class btnAddPoint
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
            this.btnViewTree = new System.Windows.Forms.Button();
            this.gbMainOper = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClearPlot = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbNrOfTerms = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUpperBound = new System.Windows.Forms.TextBox();
            this.tbLowerBound = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbMcLaurinSerie = new System.Windows.Forms.Label();
            this.gbDer = new System.Windows.Forms.GroupBox();
            this.btnSimplify = new System.Windows.Forms.Button();
            this.btnNewton = new System.Windows.Forms.Button();
            this.btnderAnalytic = new System.Windows.Forms.Button();
            this.gbInter = new System.Windows.Forms.GroupBox();
            this.tbInteValue = new System.Windows.Forms.TextBox();
            this.lbValue = new System.Windows.Forms.Label();
            this.btnIntegral = new System.Windows.Forms.Button();
            this.gbMcLaurin = new System.Windows.Forms.GroupBox();
            this.btnMcLaurinPlot = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnpointAdd = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tbYCoor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbPointNr = new System.Windows.Forms.Label();
            this.lbNrOfPoint = new System.Windows.Forms.Label();
            this.tbXCoor = new System.Windows.Forms.TextBox();
            this.btnSetpoint = new System.Windows.Forms.Button();
            this.btnPlotNpoli = new System.Windows.Forms.Button();
            this.lbNpolinomial = new System.Windows.Forms.Label();
            this.gbMainOper.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbDer.SuspendLayout();
            this.gbInter.SuspendLayout();
            this.gbMcLaurin.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnParse
            // 
            this.btnParse.Location = new System.Drawing.Point(22, 68);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(90, 42);
            this.btnParse.TabIndex = 0;
            this.btnParse.Text = "Parse";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(22, 25);
            this.tbInput.Multiline = true;
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(1533, 33);
            this.tbInput.TabIndex = 1;
            this.tbInput.TextChanged += new System.EventHandler(this.tbInput_TextChanged);
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(22, 25);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(443, 37);
            this.tbResult.TabIndex = 2;
            // 
            // btnViewTree
            // 
            this.btnViewTree.Location = new System.Drawing.Point(133, 68);
            this.btnViewTree.Name = "btnViewTree";
            this.btnViewTree.Size = new System.Drawing.Size(121, 42);
            this.btnViewTree.TabIndex = 4;
            this.btnViewTree.Text = "View Trees";
            this.btnViewTree.UseVisualStyleBackColor = true;
            this.btnViewTree.Click += new System.EventHandler(this.btnTextFile_Click);
            // 
            // gbMainOper
            // 
            this.gbMainOper.Controls.Add(this.label2);
            this.gbMainOper.Controls.Add(this.btnViewTree);
            this.gbMainOper.Controls.Add(this.btnParse);
            this.gbMainOper.Controls.Add(this.tbResult);
            this.gbMainOper.Location = new System.Drawing.Point(36, 91);
            this.gbMainOper.Name = "gbMainOper";
            this.gbMainOper.Size = new System.Drawing.Size(473, 133);
            this.gbMainOper.TabIndex = 7;
            this.gbMainOper.TabStop = false;
            this.gbMainOper.Text = "Main Operation";
            this.gbMainOper.Enter += new System.EventHandler(this.gbMainOper_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1161, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 18;
            // 
            // btnClearPlot
            // 
            this.btnClearPlot.Location = new System.Drawing.Point(1575, 19);
            this.btnClearPlot.Name = "btnClearPlot";
            this.btnClearPlot.Size = new System.Drawing.Size(104, 39);
            this.btnClearPlot.TabIndex = 21;
            this.btnClearPlot.Text = "Clear plot";
            this.btnClearPlot.UseVisualStyleBackColor = true;
            this.btnClearPlot.Click += new System.EventHandler(this.btnClearPlot_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Terms";
            // 
            // cbNrOfTerms
            // 
            this.cbNrOfTerms.FormattingEnabled = true;
            this.cbNrOfTerms.Location = new System.Drawing.Point(84, 45);
            this.cbNrOfTerms.Name = "cbNrOfTerms";
            this.cbNrOfTerms.Size = new System.Drawing.Size(347, 28);
            this.cbNrOfTerms.TabIndex = 24;
            this.cbNrOfTerms.SelectedIndexChanged += new System.EventHandler(this.cbNrOfTerms_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "X2 value";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "X1 value";
            // 
            // tbUpperBound
            // 
            this.tbUpperBound.Location = new System.Drawing.Point(240, 54);
            this.tbUpperBound.Multiline = true;
            this.tbUpperBound.Name = "tbUpperBound";
            this.tbUpperBound.Size = new System.Drawing.Size(213, 33);
            this.tbUpperBound.TabIndex = 16;
            // 
            // tbLowerBound
            // 
            this.tbLowerBound.Location = new System.Drawing.Point(10, 54);
            this.tbLowerBound.Multiline = true;
            this.tbLowerBound.Name = "tbLowerBound";
            this.tbLowerBound.Size = new System.Drawing.Size(212, 33);
            this.tbLowerBound.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClearPlot);
            this.groupBox2.Controls.Add(this.tbInput);
            this.groupBox2.Location = new System.Drawing.Point(36, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1695, 73);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lbMcLaurinSerie
            // 
            this.lbMcLaurinSerie.Location = new System.Drawing.Point(530, 824);
            this.lbMcLaurinSerie.Name = "lbMcLaurinSerie";
            this.lbMcLaurinSerie.Size = new System.Drawing.Size(1206, 71);
            this.lbMcLaurinSerie.TabIndex = 26;
            this.lbMcLaurinSerie.Text = "0";
            // 
            // gbDer
            // 
            this.gbDer.Controls.Add(this.btnSimplify);
            this.gbDer.Controls.Add(this.btnNewton);
            this.gbDer.Controls.Add(this.btnderAnalytic);
            this.gbDer.Location = new System.Drawing.Point(36, 230);
            this.gbDer.Name = "gbDer";
            this.gbDer.Size = new System.Drawing.Size(473, 142);
            this.gbDer.TabIndex = 27;
            this.gbDer.TabStop = false;
            this.gbDer.Text = "Derivative";
            // 
            // btnSimplify
            // 
            this.btnSimplify.Location = new System.Drawing.Point(240, 25);
            this.btnSimplify.Name = "btnSimplify";
            this.btnSimplify.Size = new System.Drawing.Size(213, 90);
            this.btnSimplify.TabIndex = 28;
            this.btnSimplify.Text = "Simplify";
            this.btnSimplify.UseVisualStyleBackColor = true;
            this.btnSimplify.Click += new System.EventHandler(this.btnSimplify_Click);
            // 
            // btnNewton
            // 
            this.btnNewton.Location = new System.Drawing.Point(17, 25);
            this.btnNewton.Name = "btnNewton";
            this.btnNewton.Size = new System.Drawing.Size(213, 42);
            this.btnNewton.TabIndex = 27;
            this.btnNewton.Text = "Newton";
            this.btnNewton.UseVisualStyleBackColor = true;
            this.btnNewton.Click += new System.EventHandler(this.btnNewton_Click);
            // 
            // btnderAnalytic
            // 
            this.btnderAnalytic.Location = new System.Drawing.Point(17, 73);
            this.btnderAnalytic.Name = "btnderAnalytic";
            this.btnderAnalytic.Size = new System.Drawing.Size(213, 42);
            this.btnderAnalytic.TabIndex = 26;
            this.btnderAnalytic.Text = "Analytical";
            this.btnderAnalytic.UseVisualStyleBackColor = true;
            this.btnderAnalytic.Click += new System.EventHandler(this.btnderAnalytic_Click);
            // 
            // gbInter
            // 
            this.gbInter.Controls.Add(this.tbInteValue);
            this.gbInter.Controls.Add(this.lbValue);
            this.gbInter.Controls.Add(this.btnIntegral);
            this.gbInter.Controls.Add(this.label1);
            this.gbInter.Controls.Add(this.tbLowerBound);
            this.gbInter.Controls.Add(this.label3);
            this.gbInter.Controls.Add(this.tbUpperBound);
            this.gbInter.Location = new System.Drawing.Point(36, 381);
            this.gbInter.Name = "gbInter";
            this.gbInter.Size = new System.Drawing.Size(473, 203);
            this.gbInter.TabIndex = 28;
            this.gbInter.TabStop = false;
            this.gbInter.Text = "Integral";
            // 
            // tbInteValue
            // 
            this.tbInteValue.Location = new System.Drawing.Point(70, 152);
            this.tbInteValue.Multiline = true;
            this.tbInteValue.Name = "tbInteValue";
            this.tbInteValue.Size = new System.Drawing.Size(378, 29);
            this.tbInteValue.TabIndex = 26;
            // 
            // lbValue
            // 
            this.lbValue.AutoSize = true;
            this.lbValue.Location = new System.Drawing.Point(11, 155);
            this.lbValue.Name = "lbValue";
            this.lbValue.Size = new System.Drawing.Size(50, 20);
            this.lbValue.TabIndex = 27;
            this.lbValue.Text = "Value";
            // 
            // btnIntegral
            // 
            this.btnIntegral.Location = new System.Drawing.Point(10, 93);
            this.btnIntegral.Name = "btnIntegral";
            this.btnIntegral.Size = new System.Drawing.Size(443, 39);
            this.btnIntegral.TabIndex = 26;
            this.btnIntegral.Text = "Integral";
            this.btnIntegral.UseVisualStyleBackColor = true;
            this.btnIntegral.Click += new System.EventHandler(this.btnIntegral_Click);
            // 
            // gbMcLaurin
            // 
            this.gbMcLaurin.Controls.Add(this.cbNrOfTerms);
            this.gbMcLaurin.Controls.Add(this.label4);
            this.gbMcLaurin.Controls.Add(this.btnMcLaurinPlot);
            this.gbMcLaurin.Location = new System.Drawing.Point(34, 590);
            this.gbMcLaurin.Name = "gbMcLaurin";
            this.gbMcLaurin.Size = new System.Drawing.Size(475, 165);
            this.gbMcLaurin.TabIndex = 28;
            this.gbMcLaurin.TabStop = false;
            this.gbMcLaurin.Text = "McLaurin Series";
            this.gbMcLaurin.Enter += new System.EventHandler(this.gbMcLaurin_Enter);
            // 
            // btnMcLaurinPlot
            // 
            this.btnMcLaurinPlot.Location = new System.Drawing.Point(7, 96);
            this.btnMcLaurinPlot.Name = "btnMcLaurinPlot";
            this.btnMcLaurinPlot.Size = new System.Drawing.Size(443, 42);
            this.btnMcLaurinPlot.TabIndex = 27;
            this.btnMcLaurinPlot.Text = "Plot";
            this.btnMcLaurinPlot.UseVisualStyleBackColor = true;
            this.btnMcLaurinPlot.Click += new System.EventHandler(this.btnMcLaurinPlot_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnpointAdd);
            this.groupBox3.Controls.Add(this.btnRefresh);
            this.groupBox3.Controls.Add(this.tbYCoor);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lbPointNr);
            this.groupBox3.Controls.Add(this.lbNrOfPoint);
            this.groupBox3.Controls.Add(this.tbXCoor);
            this.groupBox3.Controls.Add(this.btnSetpoint);
            this.groupBox3.Controls.Add(this.btnPlotNpoli);
            this.groupBox3.Location = new System.Drawing.Point(36, 783);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(473, 166);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "N-polinomial";
            // 
            // btnpointAdd
            // 
            this.btnpointAdd.Location = new System.Drawing.Point(338, 56);
            this.btnpointAdd.Name = "btnpointAdd";
            this.btnpointAdd.Size = new System.Drawing.Size(115, 31);
            this.btnpointAdd.TabIndex = 38;
            this.btnpointAdd.Text = "Add point";
            this.btnpointAdd.UseVisualStyleBackColor = true;
            this.btnpointAdd.Click += new System.EventHandler(this.btnpointAdd_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(244, 123);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(221, 39);
            this.btnRefresh.TabIndex = 37;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tbYCoor
            // 
            this.tbYCoor.Location = new System.Drawing.Point(82, 50);
            this.tbYCoor.Name = "tbYCoor";
            this.tbYCoor.Size = new System.Drawing.Size(250, 26);
            this.tbYCoor.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "Y value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "X value";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbPointNr
            // 
            this.lbPointNr.AutoSize = true;
            this.lbPointNr.Location = new System.Drawing.Point(143, 92);
            this.lbPointNr.Name = "lbPointNr";
            this.lbPointNr.Size = new System.Drawing.Size(18, 20);
            this.lbPointNr.TabIndex = 33;
            this.lbPointNr.Text = "0";
            // 
            // lbNrOfPoint
            // 
            this.lbNrOfPoint.AutoSize = true;
            this.lbNrOfPoint.Location = new System.Drawing.Point(6, 92);
            this.lbNrOfPoint.Name = "lbNrOfPoint";
            this.lbNrOfPoint.Size = new System.Drawing.Size(134, 20);
            this.lbNrOfPoint.TabIndex = 32;
            this.lbNrOfPoint.Text = "Number of points:";
            this.lbNrOfPoint.Click += new System.EventHandler(this.lbNrOfPoint_Click);
            // 
            // tbXCoor
            // 
            this.tbXCoor.Location = new System.Drawing.Point(82, 21);
            this.tbXCoor.Name = "tbXCoor";
            this.tbXCoor.Size = new System.Drawing.Size(250, 26);
            this.tbXCoor.TabIndex = 29;
            // 
            // btnSetpoint
            // 
            this.btnSetpoint.Location = new System.Drawing.Point(338, 19);
            this.btnSetpoint.Name = "btnSetpoint";
            this.btnSetpoint.Size = new System.Drawing.Size(115, 31);
            this.btnSetpoint.TabIndex = 28;
            this.btnSetpoint.Text = "Set point";
            this.btnSetpoint.UseVisualStyleBackColor = true;
            this.btnSetpoint.Click += new System.EventHandler(this.btnSetpoint_Click);
            // 
            // btnPlotNpoli
            // 
            this.btnPlotNpoli.Location = new System.Drawing.Point(15, 121);
            this.btnPlotNpoli.Name = "btnPlotNpoli";
            this.btnPlotNpoli.Size = new System.Drawing.Size(215, 42);
            this.btnPlotNpoli.TabIndex = 27;
            this.btnPlotNpoli.Text = "Plot";
            this.btnPlotNpoli.UseVisualStyleBackColor = true;
            this.btnPlotNpoli.Click += new System.EventHandler(this.btnPlotNpoli_Click);
            // 
            // lbNpolinomial
            // 
            this.lbNpolinomial.Location = new System.Drawing.Point(530, 895);
            this.lbNpolinomial.Name = "lbNpolinomial";
            this.lbNpolinomial.Size = new System.Drawing.Size(1201, 91);
            this.lbNpolinomial.TabIndex = 34;
            this.lbNpolinomial.Text = "0";
            this.lbNpolinomial.Click += new System.EventHandler(this.lbNpolinomial_Click);
            // 
            // btnAddPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1743, 995);
            this.Controls.Add(this.lbNpolinomial);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbMcLaurin);
            this.Controls.Add(this.gbInter);
            this.Controls.Add(this.gbDer);
            this.Controls.Add(this.lbMcLaurinSerie);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbMainOper);
            this.Name = "btnAddPoint";
            this.Text = "Calculus";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.gbMainOper.ResumeLayout(false);
            this.gbMainOper.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbDer.ResumeLayout(false);
            this.gbInter.ResumeLayout(false);
            this.gbInter.PerformLayout();
            this.gbMcLaurin.ResumeLayout(false);
            this.gbMcLaurin.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button btnViewTree;
        private System.Windows.Forms.GroupBox gbMainOper;
        private System.Windows.Forms.TextBox tbUpperBound;
        private System.Windows.Forms.TextBox tbLowerBound;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClearPlot;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbNrOfTerms;
        private System.Windows.Forms.Label lbMcLaurinSerie;
        private System.Windows.Forms.GroupBox gbDer;
        private System.Windows.Forms.Button btnNewton;
        private System.Windows.Forms.Button btnderAnalytic;
        private System.Windows.Forms.GroupBox gbInter;
        private System.Windows.Forms.TextBox tbInteValue;
        private System.Windows.Forms.Label lbValue;
        private System.Windows.Forms.Button btnIntegral;
        private System.Windows.Forms.GroupBox gbMcLaurin;
        private System.Windows.Forms.Button btnMcLaurinPlot;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbPointNr;
        private System.Windows.Forms.Label lbNrOfPoint;
        private System.Windows.Forms.TextBox tbXCoor;
        private System.Windows.Forms.Button btnSetpoint;
        private System.Windows.Forms.Button btnPlotNpoli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbYCoor;
        private System.Windows.Forms.Label lbNpolinomial;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnpointAdd;
        private System.Windows.Forms.Button btnSimplify;
    }
}

