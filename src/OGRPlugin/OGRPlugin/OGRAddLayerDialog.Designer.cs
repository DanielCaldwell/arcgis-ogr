﻿// Copyright 2010 ESRI
// 
// All rights reserved under the copyright laws of the United States
// and applicable international laws, treaties, and conventions.
// 
// You may freely redistribute and use this sample code, with or
// without modification, provided you include the original copyright
// notice and use restrictions.
// 
// See the use restrictions at http://help.arcgis.com/en/sdk/10.0/usageRestrictions.htm
// 

namespace GDAL.OGRPlugin
{
    partial class OGRAddLayerDialog
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnOpenDataSource = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDatasets = new System.Windows.Forms.Label();
            this.lstFeatureClasses = new System.Windows.Forms.ListBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(195, 276);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(37, 276);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnOpenDataSource
            // 
            this.btnOpenDataSource.Location = new System.Drawing.Point(249, 17);
            this.btnOpenDataSource.Name = "btnOpenDataSource";
            this.btnOpenDataSource.Size = new System.Drawing.Size(23, 23);
            this.btnOpenDataSource.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnOpenDataSource, "Open Simple Point data");
            this.btnOpenDataSource.UseVisualStyleBackColor = true;
            this.btnOpenDataSource.Click += new System.EventHandler(this.btnOpenDataSource_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDatasets);
            this.groupBox1.Controls.Add(this.lstFeatureClasses);
            this.groupBox1.Controls.Add(this.txtPath);
            this.groupBox1.Controls.Add(this.btnOpenDataSource);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 249);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // lblDatasets
            // 
            this.lblDatasets.AutoSize = true;
            this.lblDatasets.Location = new System.Drawing.Point(6, 50);
            this.lblDatasets.Name = "lblDatasets";
            this.lblDatasets.Size = new System.Drawing.Size(52, 13);
            this.lblDatasets.TabIndex = 5;
            this.lblDatasets.Text = "Datasets:";
            // 
            // lstFeatureClasses
            // 
            this.lstFeatureClasses.FormattingEnabled = true;
            this.lstFeatureClasses.Location = new System.Drawing.Point(6, 80);
            this.lstFeatureClasses.Name = "lstFeatureClasses";
            this.lstFeatureClasses.Size = new System.Drawing.Size(266, 160);
            this.lstFeatureClasses.TabIndex = 4;
            this.lstFeatureClasses.DoubleClick += new System.EventHandler(this.lstDeatureClasses_DoubleClick);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(6, 19);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(237, 20);
            this.txtPath.TabIndex = 3;
            // 
            // OGRAddLayerDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 312);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OGRAddLayerDialog";
            this.ShowInTaskbar = false;
            this.Text = "Add OGR Layer";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnOpenDataSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.ListBox lstFeatureClasses;
        private System.Windows.Forms.Label lblDatasets;
    }
}