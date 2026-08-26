namespace SCSMEnumValues
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblServer = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.lstEnums = new System.Windows.Forms.ListBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblQuery = new System.Windows.Forms.Label();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.rbSimpleList = new System.Windows.Forms.RadioButton();
            this.rbRecursiveList = new System.Windows.Forms.RadioButton();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(13, 13);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(38, 13);
            this.lblServer.TabIndex = 1;
            this.lblServer.Text = "Server";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(57, 10);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(129, 20);
            this.txtServer.TabIndex = 2;
            this.txtServer.Text = "DTFSSQLDEV004";
            // 
            // lstEnums
            // 
            this.lstEnums.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstEnums.FormattingEnabled = true;
            this.lstEnums.Location = new System.Drawing.Point(12, 117);
            this.lstEnums.Name = "lstEnums";
            this.lstEnums.ScrollAlwaysVisible = true;
            this.lstEnums.Size = new System.Drawing.Size(248, 225);
            this.lstEnums.TabIndex = 3;
            this.lstEnums.SelectedIndexChanged += new System.EventHandler(this.lstEnums_SelectedIndexChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(192, 10);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblQuery
            // 
            this.lblQuery.AutoSize = true;
            this.lblQuery.Location = new System.Drawing.Point(13, 62);
            this.lblQuery.Name = "lblQuery";
            this.lblQuery.Size = new System.Drawing.Size(35, 13);
            this.lblQuery.TabIndex = 5;
            this.lblQuery.Text = "Query";
            // 
            // txtQuery
            // 
            this.txtQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuery.Location = new System.Drawing.Point(58, 59);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.ReadOnly = true;
            this.txtQuery.Size = new System.Drawing.Size(883, 49);
            this.txtQuery.TabIndex = 6;
            this.txtQuery.Text = resources.GetString("txtQuery.Text");
            // 
            // rbSimpleList
            // 
            this.rbSimpleList.AutoSize = true;
            this.rbSimpleList.Checked = true;
            this.rbSimpleList.Location = new System.Drawing.Point(16, 36);
            this.rbSimpleList.Name = "rbSimpleList";
            this.rbSimpleList.Size = new System.Drawing.Size(75, 17);
            this.rbSimpleList.TabIndex = 7;
            this.rbSimpleList.TabStop = true;
            this.rbSimpleList.Text = "Simple List";
            this.rbSimpleList.UseVisualStyleBackColor = true;
            this.rbSimpleList.CheckedChanged += new System.EventHandler(this.rbSimpleList_CheckedChanged);
            // 
            // rbRecursiveList
            // 
            this.rbRecursiveList.AutoSize = true;
            this.rbRecursiveList.Location = new System.Drawing.Point(111, 36);
            this.rbRecursiveList.Name = "rbRecursiveList";
            this.rbRecursiveList.Size = new System.Drawing.Size(92, 17);
            this.rbRecursiveList.TabIndex = 8;
            this.rbRecursiveList.Text = "Recursive List";
            this.rbRecursiveList.UseVisualStyleBackColor = true;
            this.rbRecursiveList.CheckedChanged += new System.EventHandler(this.rbRecursiveList_CheckedChanged);
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvResults.Location = new System.Drawing.Point(273, 117);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.Size = new System.Drawing.Size(668, 218);
            this.dgvResults.TabIndex = 9;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 362);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.rbRecursiveList);
            this.Controls.Add(this.rbSimpleList);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.lblQuery);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lstEnums);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.lblServer);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "frmMain";
            this.Text = "SCSM Enum Values";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.ListBox lstEnums;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblQuery;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.RadioButton rbSimpleList;
        private System.Windows.Forms.RadioButton rbRecursiveList;
        private System.Windows.Forms.DataGridView dgvResults;
    }
}

