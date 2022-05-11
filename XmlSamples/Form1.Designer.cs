namespace XmlSamples
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
            this.BtnWriteToFile = new System.Windows.Forms.Button();
            this.BtnPrettierWriteToFile = new System.Windows.Forms.Button();
            this.TestDataGrid = new System.Windows.Forms.DataGridView();
            this.BtnFillGrid = new System.Windows.Forms.Button();
            this.BtnWriteToXml = new System.Windows.Forms.Button();
            this.BtnGetFirstElement = new System.Windows.Forms.Button();
            this.BtnGetUserById = new System.Windows.Forms.Button();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.BtmObjectToList = new System.Windows.Forms.Button();
            this.BtnListToTable = new System.Windows.Forms.Button();
            this.BtnXmlSerialize = new System.Windows.Forms.Button();
            this.BtnXmlDesrialize = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TestDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnWriteToFile
            // 
            this.BtnWriteToFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnWriteToFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnWriteToFile.Location = new System.Drawing.Point(12, 12);
            this.BtnWriteToFile.Name = "BtnWriteToFile";
            this.BtnWriteToFile.Size = new System.Drawing.Size(251, 41);
            this.BtnWriteToFile.TabIndex = 0;
            this.BtnWriteToFile.Text = "NORMAL WRITE TO FILE";
            this.BtnWriteToFile.UseVisualStyleBackColor = true;
            this.BtnWriteToFile.Click += new System.EventHandler(this.BtnWriteToFile_Click);
            // 
            // BtnPrettierWriteToFile
            // 
            this.BtnPrettierWriteToFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrettierWriteToFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnPrettierWriteToFile.Location = new System.Drawing.Point(12, 59);
            this.BtnPrettierWriteToFile.Name = "BtnPrettierWriteToFile";
            this.BtnPrettierWriteToFile.Size = new System.Drawing.Size(251, 41);
            this.BtnPrettierWriteToFile.TabIndex = 1;
            this.BtnPrettierWriteToFile.Text = "PRETTIER WRITE TO FILE";
            this.BtnPrettierWriteToFile.UseVisualStyleBackColor = true;
            this.BtnPrettierWriteToFile.Click += new System.EventHandler(this.BtnPrettierWriteToFile_Click);
            // 
            // TestDataGrid
            // 
            this.TestDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TestDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TestDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TestDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TestDataGrid.Location = new System.Drawing.Point(269, 12);
            this.TestDataGrid.Name = "TestDataGrid";
            this.TestDataGrid.RowHeadersWidth = 51;
            this.TestDataGrid.RowTemplate.Height = 29;
            this.TestDataGrid.Size = new System.Drawing.Size(640, 512);
            this.TestDataGrid.TabIndex = 2;
            // 
            // BtnFillGrid
            // 
            this.BtnFillGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFillGrid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnFillGrid.Location = new System.Drawing.Point(12, 106);
            this.BtnFillGrid.Name = "BtnFillGrid";
            this.BtnFillGrid.Size = new System.Drawing.Size(251, 41);
            this.BtnFillGrid.TabIndex = 3;
            this.BtnFillGrid.Text = "FILL TO GRID";
            this.BtnFillGrid.UseVisualStyleBackColor = true;
            this.BtnFillGrid.Click += new System.EventHandler(this.BtnFillGrid_Click);
            // 
            // BtnWriteToXml
            // 
            this.BtnWriteToXml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnWriteToXml.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnWriteToXml.Location = new System.Drawing.Point(12, 153);
            this.BtnWriteToXml.Name = "BtnWriteToXml";
            this.BtnWriteToXml.Size = new System.Drawing.Size(251, 41);
            this.BtnWriteToXml.TabIndex = 4;
            this.BtnWriteToXml.Text = "WRITE TO XML";
            this.BtnWriteToXml.UseVisualStyleBackColor = true;
            this.BtnWriteToXml.Click += new System.EventHandler(this.BtnWriteToXml_Click);
            // 
            // BtnGetFirstElement
            // 
            this.BtnGetFirstElement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGetFirstElement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnGetFirstElement.Location = new System.Drawing.Point(12, 200);
            this.BtnGetFirstElement.Name = "BtnGetFirstElement";
            this.BtnGetFirstElement.Size = new System.Drawing.Size(251, 41);
            this.BtnGetFirstElement.TabIndex = 5;
            this.BtnGetFirstElement.Text = "GET FIRST ELEMENT";
            this.BtnGetFirstElement.UseVisualStyleBackColor = true;
            this.BtnGetFirstElement.Click += new System.EventHandler(this.BtnGetFirstElement_Click);
            // 
            // BtnGetUserById
            // 
            this.BtnGetUserById.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGetUserById.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnGetUserById.Location = new System.Drawing.Point(12, 247);
            this.BtnGetUserById.Name = "BtnGetUserById";
            this.BtnGetUserById.Size = new System.Drawing.Size(251, 41);
            this.BtnGetUserById.TabIndex = 6;
            this.BtnGetUserById.Text = "GET USER BY ID";
            this.BtnGetUserById.UseVisualStyleBackColor = true;
            this.BtnGetUserById.Click += new System.EventHandler(this.BtnGetUserById_Click);
            // 
            // TxtId
            // 
            this.TxtId.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtId.Location = new System.Drawing.Point(12, 294);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(251, 38);
            this.TxtId.TabIndex = 7;
            this.TxtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtmObjectToList
            // 
            this.BtmObjectToList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtmObjectToList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtmObjectToList.Location = new System.Drawing.Point(12, 338);
            this.BtmObjectToList.Name = "BtmObjectToList";
            this.BtmObjectToList.Size = new System.Drawing.Size(251, 41);
            this.BtmObjectToList.TabIndex = 8;
            this.BtmObjectToList.Text = "FROM OBJECT TO LIST";
            this.BtmObjectToList.UseVisualStyleBackColor = true;
            this.BtmObjectToList.Click += new System.EventHandler(this.BtmObjectToList_Click);
            // 
            // BtnListToTable
            // 
            this.BtnListToTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListToTable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnListToTable.Location = new System.Drawing.Point(12, 385);
            this.BtnListToTable.Name = "BtnListToTable";
            this.BtnListToTable.Size = new System.Drawing.Size(251, 41);
            this.BtnListToTable.TabIndex = 9;
            this.BtnListToTable.Text = "FROM LIST TO TABLE";
            this.BtnListToTable.UseVisualStyleBackColor = true;
            this.BtnListToTable.Click += new System.EventHandler(this.BtnListToTable_Click);
            // 
            // BtnXmlSerialize
            // 
            this.BtnXmlSerialize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnXmlSerialize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnXmlSerialize.Location = new System.Drawing.Point(12, 432);
            this.BtnXmlSerialize.Name = "BtnXmlSerialize";
            this.BtnXmlSerialize.Size = new System.Drawing.Size(251, 41);
            this.BtnXmlSerialize.TabIndex = 10;
            this.BtnXmlSerialize.Text = "XML SERIALIZE";
            this.BtnXmlSerialize.UseVisualStyleBackColor = true;
            this.BtnXmlSerialize.Click += new System.EventHandler(this.BtnXmlSerialize_Click);
            // 
            // BtnXmlDesrialize
            // 
            this.BtnXmlDesrialize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnXmlDesrialize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnXmlDesrialize.Location = new System.Drawing.Point(12, 479);
            this.BtnXmlDesrialize.Name = "BtnXmlDesrialize";
            this.BtnXmlDesrialize.Size = new System.Drawing.Size(251, 41);
            this.BtnXmlDesrialize.TabIndex = 11;
            this.BtnXmlDesrialize.Text = "XML DESERIALIZE";
            this.BtnXmlDesrialize.UseVisualStyleBackColor = true;
            this.BtnXmlDesrialize.Click += new System.EventHandler(this.BtnXmlDesrialize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 536);
            this.Controls.Add(this.BtnXmlDesrialize);
            this.Controls.Add(this.BtnXmlSerialize);
            this.Controls.Add(this.BtnListToTable);
            this.Controls.Add(this.BtmObjectToList);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.BtnGetUserById);
            this.Controls.Add(this.BtnGetFirstElement);
            this.Controls.Add(this.BtnWriteToXml);
            this.Controls.Add(this.BtnFillGrid);
            this.Controls.Add(this.TestDataGrid);
            this.Controls.Add(this.BtnPrettierWriteToFile);
            this.Controls.Add(this.BtnWriteToFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TestDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnWriteToFile;
        private System.Windows.Forms.Button BtnPrettierWriteToFile;
        private System.Windows.Forms.DataGridView TestDataGrid;
        private System.Windows.Forms.Button BtnFillGrid;
        private System.Windows.Forms.Button BtnWriteToXml;
        private System.Windows.Forms.Button BtnGetFirstElement;
        private System.Windows.Forms.Button BtnGetUserById;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Button BtmObjectToList;
        private System.Windows.Forms.Button BtnListToTable;
        private System.Windows.Forms.Button BtnXmlSerialize;
        private System.Windows.Forms.Button BtnXmlDesrialize;
    }
}
