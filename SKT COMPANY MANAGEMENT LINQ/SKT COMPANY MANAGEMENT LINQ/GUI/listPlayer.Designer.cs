namespace SKT_COMPANY_MANAGEMENT_LINQ.GUI
{
    partial class listPlayer
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
            this.components = new System.ComponentModel.Container();
            this.PlayerGridView = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.loginDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infomationtableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infomationtableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerGridView
            // 
            this.PlayerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlayerGridView.Location = new System.Drawing.Point(0, 27);
            this.PlayerGridView.Margin = new System.Windows.Forms.Padding(4);
            this.PlayerGridView.Name = "PlayerGridView";
            this.PlayerGridView.RowHeadersWidth = 82;
            this.PlayerGridView.Size = new System.Drawing.Size(1023, 364);
            this.PlayerGridView.TabIndex = 4;
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.RefreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBtn.Location = new System.Drawing.Point(363, 435);
            this.RefreshBtn.Margin = new System.Windows.Forms.Padding(4);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(272, 44);
            this.RefreshBtn.TabIndex = 5;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = false;
            // 
            // infomationtableBindingSource
            // 
            this.infomationtableBindingSource.DataMember = "infomation_table";
            // 
            // listPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 508);
            this.Controls.Add(this.PlayerGridView);
            this.Controls.Add(this.RefreshBtn);
            this.Name = "listPlayer";
            this.Text = "listPlayer";
            ((System.ComponentModel.ISupportInitialize)(this.PlayerGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infomationtableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PlayerGridView;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.BindingSource loginDataSetBindingSource;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.BindingSource infomationtableBindingSource;
    }
}