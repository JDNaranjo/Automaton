namespace Automaton
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.alphabetTxt = new System.Windows.Forms.TextBox();
            this.addAlphabetBtn = new System.Windows.Forms.Button();
            this.addStateBtn = new System.Windows.Forms.Button();
            this.stateTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.startingSBox = new System.Windows.Forms.ComboBox();
            this.finishSBox = new System.Windows.Forms.ComboBox();
            this.addTBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            this.charInLabel = new System.Windows.Forms.Label();
            this.stateInLabel = new System.Windows.Forms.Label();
            this.transitionInLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.outputSTxt = new System.Windows.Forms.TextBox();
            this.inputSBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.outputTxtBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Red;
            this.Title.Location = new System.Drawing.Point(236, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(344, 32);
            this.Title.TabIndex = 0;
            this.Title.Text = "AUTOMATON BROOOO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alphabet:";
            // 
            // alphabetTxt
            // 
            this.alphabetTxt.ForeColor = System.Drawing.SystemColors.InfoText;
            this.alphabetTxt.Location = new System.Drawing.Point(97, 82);
            this.alphabetTxt.Name = "alphabetTxt";
            this.alphabetTxt.Size = new System.Drawing.Size(78, 22);
            this.alphabetTxt.TabIndex = 2;
            // 
            // addAlphabetBtn
            // 
            this.addAlphabetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAlphabetBtn.Location = new System.Drawing.Point(181, 80);
            this.addAlphabetBtn.Name = "addAlphabetBtn";
            this.addAlphabetBtn.Size = new System.Drawing.Size(46, 26);
            this.addAlphabetBtn.TabIndex = 3;
            this.addAlphabetBtn.Text = "Add";
            this.addAlphabetBtn.UseVisualStyleBackColor = true;
            this.addAlphabetBtn.Click += new System.EventHandler(this.addAlphabetBtn_Click);
            // 
            // addStateBtn
            // 
            this.addStateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStateBtn.Location = new System.Drawing.Point(181, 120);
            this.addStateBtn.Name = "addStateBtn";
            this.addStateBtn.Size = new System.Drawing.Size(46, 26);
            this.addStateBtn.TabIndex = 6;
            this.addStateBtn.Text = "Add";
            this.addStateBtn.UseVisualStyleBackColor = true;
            this.addStateBtn.Click += new System.EventHandler(this.addStateBtn_Click);
            // 
            // stateTxt
            // 
            this.stateTxt.ForeColor = System.Drawing.SystemColors.InfoText;
            this.stateTxt.Location = new System.Drawing.Point(97, 122);
            this.stateTxt.Name = "stateTxt";
            this.stateTxt.Size = new System.Drawing.Size(78, 22);
            this.stateTxt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "States:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Transitions:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(59, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Starting State:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(59, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Finish State:";
            // 
            // startingSBox
            // 
            this.startingSBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.startingSBox.FormattingEnabled = true;
            this.startingSBox.Location = new System.Drawing.Point(181, 209);
            this.startingSBox.Name = "startingSBox";
            this.startingSBox.Size = new System.Drawing.Size(177, 24);
            this.startingSBox.TabIndex = 11;
            this.startingSBox.Text = "Choose the starting state";
            // 
            // finishSBox
            // 
            this.finishSBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.finishSBox.FormattingEnabled = true;
            this.finishSBox.Location = new System.Drawing.Point(181, 256);
            this.finishSBox.Name = "finishSBox";
            this.finishSBox.Size = new System.Drawing.Size(177, 24);
            this.finishSBox.TabIndex = 12;
            this.finishSBox.Text = "Choose the finish state";
            // 
            // addTBtn
            // 
            this.addTBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTBtn.Location = new System.Drawing.Point(242, 394);
            this.addTBtn.Name = "addTBtn";
            this.addTBtn.Size = new System.Drawing.Size(116, 26);
            this.addTBtn.TabIndex = 14;
            this.addTBtn.Text = "Add Transition";
            this.addTBtn.UseVisualStyleBackColor = true;
            this.addTBtn.Click += new System.EventHandler(this.addTBtn_Click);
            // 
            // createBtn
            // 
            this.createBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBtn.Location = new System.Drawing.Point(658, 394);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(130, 26);
            this.createBtn.TabIndex = 15;
            this.createBtn.Text = "Create Automaton";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // charInLabel
            // 
            this.charInLabel.AutoSize = true;
            this.charInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charInLabel.ForeColor = System.Drawing.Color.Blue;
            this.charInLabel.Location = new System.Drawing.Point(233, 84);
            this.charInLabel.Name = "charInLabel";
            this.charInLabel.Size = new System.Drawing.Size(219, 20);
            this.charInLabel.TabIndex = 16;
            this.charInLabel.Text = "Message about the alphabet";
            // 
            // stateInLabel
            // 
            this.stateInLabel.AutoSize = true;
            this.stateInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateInLabel.ForeColor = System.Drawing.Color.Blue;
            this.stateInLabel.Location = new System.Drawing.Point(233, 124);
            this.stateInLabel.Name = "stateInLabel";
            this.stateInLabel.Size = new System.Drawing.Size(202, 20);
            this.stateInLabel.TabIndex = 17;
            this.stateInLabel.Text = "Message about the states";
            // 
            // transitionInLabel
            // 
            this.transitionInLabel.AutoSize = true;
            this.transitionInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transitionInLabel.ForeColor = System.Drawing.Color.Blue;
            this.transitionInLabel.Location = new System.Drawing.Point(364, 352);
            this.transitionInLabel.Name = "transitionInLabel";
            this.transitionInLabel.Size = new System.Drawing.Size(225, 20);
            this.transitionInLabel.TabIndex = 21;
            this.transitionInLabel.Text = "Message about the transition";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(59, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Output:";
            // 
            // outputSTxt
            // 
            this.outputSTxt.ForeColor = System.Drawing.SystemColors.InfoText;
            this.outputSTxt.Location = new System.Drawing.Point(181, 350);
            this.outputSTxt.Name = "outputSTxt";
            this.outputSTxt.Size = new System.Drawing.Size(177, 22);
            this.outputSTxt.TabIndex = 24;
            // 
            // inputSBox
            // 
            this.inputSBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.inputSBox.FormattingEnabled = true;
            this.inputSBox.Location = new System.Drawing.Point(181, 303);
            this.inputSBox.Name = "inputSBox";
            this.inputSBox.Size = new System.Drawing.Size(177, 24);
            this.inputSBox.TabIndex = 23;
            this.inputSBox.Text = "Choose the finish state";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(59, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Input:";
            // 
            // outputTxtBox
            // 
            this.outputTxtBox.Location = new System.Drawing.Point(458, 82);
            this.outputTxtBox.Name = "outputTxtBox";
            this.outputTxtBox.Size = new System.Drawing.Size(330, 245);
            this.outputTxtBox.TabIndex = 26;
            this.outputTxtBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 432);
            this.Controls.Add(this.outputTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.outputSTxt);
            this.Controls.Add(this.inputSBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.transitionInLabel);
            this.Controls.Add(this.stateInLabel);
            this.Controls.Add(this.charInLabel);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.addTBtn);
            this.Controls.Add(this.finishSBox);
            this.Controls.Add(this.startingSBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addStateBtn);
            this.Controls.Add(this.stateTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addAlphabetBtn);
            this.Controls.Add(this.alphabetTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.Text = "Finite State Machine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox alphabetTxt;
        private System.Windows.Forms.Button addAlphabetBtn;
        private System.Windows.Forms.Button addStateBtn;
        private System.Windows.Forms.TextBox stateTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox startingSBox;
        private System.Windows.Forms.ComboBox finishSBox;
        private System.Windows.Forms.Button addTBtn;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Label charInLabel;
        private System.Windows.Forms.Label stateInLabel;
        private System.Windows.Forms.Label transitionInLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox outputSTxt;
        private System.Windows.Forms.ComboBox inputSBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox outputTxtBox;
    }
}

