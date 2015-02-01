using System;
using System.Windows.Forms;

namespace Chapter18 {
    public class NewTreeView : TreeView {
        public NewTreeView() : base() {}

        protected override void WndProc(ref Message m) {
            // Suppress WM_LBUTTONDBLCLK
            if (m.Msg == 0x203) {
                m.Result = IntPtr.Zero;
            }
            else {
                base.WndProc(ref m);
            }
        }
    }

    partial class FrmFileCopier {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tvwTargetDir = new System.Windows.Forms.TreeView();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblSource = new System.Windows.Forms.Label();
            this.lblTarget = new System.Windows.Forms.Label();
            this.txtTargetDir = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.chkOverwrite = new System.Windows.Forms.CheckBox();
            this.tvwSource = new Chapter18.NewTreeView();
            this.SuspendLayout();
            // 
            // tvwTargetDir
            // 
            this.tvwTargetDir.Location = new System.Drawing.Point(210, 55);
            this.tvwTargetDir.Name = "tvwTargetDir";
            this.tvwTargetDir.Size = new System.Drawing.Size(196, 249);
            this.tvwTargetDir.TabIndex = 1;
            this.tvwTargetDir.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwTargetDir_AfterSelect);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(331, 310);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(331, 339);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(331, 368);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(73, 310);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(12, 10);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(65, 13);
            this.lblSource.TabIndex = 6;
            this.lblSource.Text = "Source Files";
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(207, 10);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(62, 13);
            this.lblTarget.TabIndex = 7;
            this.lblTarget.Text = "Target Files";
            // 
            // txtTargetDir
            // 
            this.txtTargetDir.Location = new System.Drawing.Point(210, 29);
            this.txtTargetDir.Name = "txtTargetDir";
            this.txtTargetDir.Size = new System.Drawing.Size(196, 20);
            this.txtTargetDir.TabIndex = 8;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(15, 339);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(55, 13);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "something";
            // 
            // chkOverwrite
            // 
            this.chkOverwrite.AutoSize = true;
            this.chkOverwrite.Location = new System.Drawing.Point(210, 316);
            this.chkOverwrite.Name = "chkOverwrite";
            this.chkOverwrite.Size = new System.Drawing.Size(108, 17);
            this.chkOverwrite.TabIndex = 11;
            this.chkOverwrite.Text = "Overwrite if exists";
            this.chkOverwrite.UseVisualStyleBackColor = true;
            // 
            // tvwSource
            // 
            this.tvwSource.CheckBoxes = true;
            this.tvwSource.Location = new System.Drawing.Point(15, 29);
            this.tvwSource.Name = "tvwSource";
            this.tvwSource.Size = new System.Drawing.Size(179, 275);
            this.tvwSource.TabIndex = 0;
            this.tvwSource.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvwSource_AfterCheck);
            this.tvwSource.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvwSource_BeforeExpand);
            // 
            // FrmFileCopier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 406);
            this.Controls.Add(this.chkOverwrite);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtTargetDir);
            this.Controls.Add(this.lblTarget);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.tvwTargetDir);
            this.Controls.Add(this.tvwSource);
            this.Name = "FrmFileCopier";
            this.Text = "File Copier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NewTreeView tvwSource;
        private System.Windows.Forms.TreeView tvwTargetDir;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtTargetDir;
        private System.Windows.Forms.CheckBox chkOverwrite;

    }
}

