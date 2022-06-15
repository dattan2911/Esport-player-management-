namespace SKT_COMPANY_MANAGEMENT_LINQ.GUI
{
    partial class Print
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
            this.AllRadioBtn = new System.Windows.Forms.RadioButton();
            this.MaleRadioBtn = new System.Windows.Forms.RadioButton();
            this.radiobtnFemale = new System.Windows.Forms.RadioButton();
            this.btnCheck = new System.Windows.Forms.Button();
            this.functionPanel = new System.Windows.Forms.Panel();
            this.printDoc = new System.Drawing.Printing.PrintDocument();
            this.TableOfPlayer = new System.Windows.Forms.DataGridView();
            this.printDlg = new System.Windows.Forms.PrintDialog();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnFile = new System.Windows.Forms.Button();
            this.functionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableOfPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // AllRadioBtn
            // 
            this.AllRadioBtn.AutoSize = true;
            this.AllRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllRadioBtn.ForeColor = System.Drawing.Color.White;
            this.AllRadioBtn.Location = new System.Drawing.Point(13, 41);
            this.AllRadioBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AllRadioBtn.Name = "AllRadioBtn";
            this.AllRadioBtn.Size = new System.Drawing.Size(52, 24);
            this.AllRadioBtn.TabIndex = 0;
            this.AllRadioBtn.Text = "All";
            this.AllRadioBtn.UseVisualStyleBackColor = true;
            // 
            // MaleRadioBtn
            // 
            this.MaleRadioBtn.AutoSize = true;
            this.MaleRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaleRadioBtn.ForeColor = System.Drawing.Color.White;
            this.MaleRadioBtn.Location = new System.Drawing.Point(71, 41);
            this.MaleRadioBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaleRadioBtn.Name = "MaleRadioBtn";
            this.MaleRadioBtn.Size = new System.Drawing.Size(70, 24);
            this.MaleRadioBtn.TabIndex = 1;
            this.MaleRadioBtn.Text = "Male";
            this.MaleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // radiobtnFemale
            // 
            this.radiobtnFemale.AutoSize = true;
            this.radiobtnFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnFemale.ForeColor = System.Drawing.Color.White;
            this.radiobtnFemale.Location = new System.Drawing.Point(147, 41);
            this.radiobtnFemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radiobtnFemale.Name = "radiobtnFemale";
            this.radiobtnFemale.Size = new System.Drawing.Size(91, 24);
            this.radiobtnFemale.TabIndex = 2;
            this.radiobtnFemale.Text = "Female";
            this.radiobtnFemale.UseVisualStyleBackColor = true;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Red;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.Color.White;
            this.btnCheck.Location = new System.Drawing.Point(328, 34);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(95, 39);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "CHECK";
            this.btnCheck.UseVisualStyleBackColor = false;
            // 
            // functionPanel
            // 
            this.functionPanel.BackColor = System.Drawing.SystemColors.ControlText;
            this.functionPanel.Controls.Add(this.btnCheck);
            this.functionPanel.Controls.Add(this.radiobtnFemale);
            this.functionPanel.Controls.Add(this.MaleRadioBtn);
            this.functionPanel.Controls.Add(this.AllRadioBtn);
            this.functionPanel.Location = new System.Drawing.Point(296, 32);
            this.functionPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.functionPanel.Name = "functionPanel";
            this.functionPanel.Size = new System.Drawing.Size(457, 111);
            this.functionPanel.TabIndex = 4;
            // 
            // TableOfPlayer
            // 
            this.TableOfPlayer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TableOfPlayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableOfPlayer.Location = new System.Drawing.Point(1, 172);
            this.TableOfPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TableOfPlayer.Name = "TableOfPlayer";
            this.TableOfPlayer.RowHeadersWidth = 51;
            this.TableOfPlayer.RowTemplate.Height = 24;
            this.TableOfPlayer.Size = new System.Drawing.Size(1052, 407);
            this.TableOfPlayer.TabIndex = 5;
            // 
            // printDlg
            // 
            this.printDlg.UseEXDialog = true;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(559, 606);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(251, 48);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "To Printer ";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnFile
            // 
            this.btnFile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFile.Location = new System.Drawing.Point(199, 606);
            this.btnFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(251, 48);
            this.btnFile.TabIndex = 8;
            this.btnFile.Text = "To File";
            this.btnFile.UseVisualStyleBackColor = false;
            // 
            // Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 665);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.TableOfPlayer);
            this.Controls.Add(this.functionPanel);
            this.Name = "Print";
            this.Text = "Print";
            this.functionPanel.ResumeLayout(false);
            this.functionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableOfPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton AllRadioBtn;
        private System.Windows.Forms.RadioButton MaleRadioBtn;
        private System.Windows.Forms.RadioButton radiobtnFemale;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Panel functionPanel;
        private System.Drawing.Printing.PrintDocument printDoc;
        private System.Windows.Forms.DataGridView TableOfPlayer;
        private System.Windows.Forms.PrintDialog printDlg;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnFile;
    }
}