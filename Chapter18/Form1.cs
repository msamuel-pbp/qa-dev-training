using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Chapter18 {
    public partial class FrmFileCopier : Form {
        private const int MaxLevel = 2;

        public FrmFileCopier() {
            InitializeComponent();
            FillDirectoryTree(tvwSource, true);
            FillDirectoryTree(tvwTargetDir, false);
        }

        public class FileComparer : IComparer<FileInfo> {
            public int Compare(FileInfo file1, FileInfo file2) {
                if (file1.Length > file2.Length) {
                    return -1;
                } 
                if (file1.Length < file2.Length) {
                    return 1;
                }
                return 0;
            }
        }

        private void GetFiles(TreeNode parentNode, DirectoryInfo dir) {
            try {
                var files = dir.GetFiles();

                foreach (var file in files) {
                    if (((file.Attributes & FileAttributes.System) != 0) ||
                        ((file.Attributes & FileAttributes.Hidden) != 0)) {
                        continue;
                    }

                    var fileNode = new TreeNode(file.Name);
                    parentNode.Nodes.Add(fileNode);
                }
            }
            catch (DirectoryNotFoundException) {
                Application.DoEvents();                
            }
        }

        private void GetSubDirectoryNodes(TreeNode parentNode, string fullName, bool getFileNames, int level) {
            try {
                var dir = new DirectoryInfo(fullName);
                var dirSubs = dir.GetDirectories();

                foreach (var dirSub in dirSubs) {
                    if (((dirSub.Attributes & FileAttributes.System) != 0) ||
                        ((dirSub.Attributes & FileAttributes.Hidden) != 0)) {
                        continue;
                    }

                    var subNode = new TreeNode(dirSub.Name);
                    parentNode.Nodes.Add(subNode);

                    if (level < MaxLevel) {
                        GetSubDirectoryNodes(subNode, dirSub.FullName, getFileNames, level + 1);
                    }
                    if (getFileNames) {
                        GetFiles(subNode, dirSub);
                    }
                }

                if (getFileNames) {
                    GetFiles(parentNode, dir);
                }
            }
            catch (UnauthorizedAccessException) {
                Application.DoEvents();
            }
        }

        private void FillDirectoryTree(TreeView tvw, bool isSource) {
            var strDrives = Environment.GetLogicalDrives();

            tvw.Nodes.Clear();

            foreach (var rootDirectoryName in strDrives) {
                try {
                    var dir = new DirectoryInfo(rootDirectoryName);
                    var ndRoot = new TreeNode(rootDirectoryName);
                    tvw.Nodes.Add(ndRoot);

                    GetSubDirectoryNodes(ndRoot, ndRoot.Text, isSource, 1);
                    if (isSource) {
                        GetFiles(ndRoot, dir);                        
                    }
                } 
                catch (UnauthorizedAccessException) {
                    Application.DoEvents();
                }
            }
        }

        private void SetCheck(TreeNode parentNode, bool check) {
            foreach (TreeNode subNode in parentNode.Nodes) {
                subNode.Checked = check;
                if (subNode.Nodes.Count != 0) {
                    SetCheck(subNode, check);                    
                }
            }
        }

        private void tvwExpand(object sender, TreeNode node) {
            var tvw = (TreeView) sender;
            var isSource = (tvw == tvwSource);
            var fullName = node.FullPath;

            node.Nodes.Clear();
            GetSubDirectoryNodes(node, fullName, isSource, 1);
            SetCheck(node, node.Checked);
        }

        private void getCheckedFiles(TreeNode parentNode, List<string> checkedFiles) {
            if (parentNode.Nodes.Count != 0) {
                foreach (TreeNode subnode in parentNode.Nodes) {
                    getCheckedFiles(subnode, checkedFiles);
                }
            }

            if (parentNode.Checked) {
                checkedFiles.Add(parentNode.FullPath);
            }
        }

        private List<FileInfo> getCheckedFileList() {
            List<string> fileNames = new List<string>();
            List<FileInfo> fileList = new List<FileInfo>();

            foreach (TreeNode node in tvwSource.Nodes) {
                getCheckedFiles(node, fileNames);
            }

            foreach (var fileName in fileNames) {
                try {
                    var file = new FileInfo(fileName);
                    if (file.Exists) {
                        fileList.Add(file);
                    }
                }
                catch (UnauthorizedAccessException) {
                    Application.DoEvents();
                }
            }

            var comparer = new FileComparer();
            fileList.Sort(comparer);

            return fileList;
        }

        private void tvwSource_AfterCheck(object sender, TreeViewEventArgs e) {
            if (e.Action != TreeViewAction.Unknown) {
                if (e.Node.Nodes.Count != 0) {
                    SetCheck(e.Node, e.Node.Checked);
                }
            }
        }

        private void tvwSource_BeforeExpand(object sender, TreeViewCancelEventArgs e) {
            tvwExpand(sender, e.Node);
        }

        private void tvwTargetDir_AfterSelect(object sender, TreeViewEventArgs e) {
            var path = e.Node.FullPath;

            if (path.EndsWith("\\\\")) {
                path = path.Substring(0, path.Length - 1);
            }
            txtTargetDir.Text = path.Replace("\\\\","\\");
        }

        private void btnClear_Click(object sender, EventArgs e) {
            foreach (TreeNode node in tvwSource.Nodes) {
                node.Checked = false;
                SetCheck(node, node.Checked);
            }
        }

        private void btnCopy_Click(object sender, EventArgs e) {
            var checkedFileList = getCheckedFileList();

            foreach (var file in checkedFileList) {
                try {
                    lblStatus.Text = String.Format("Copying to {0}\\{1}", txtTargetDir.Text, file.Name);
                    Application.DoEvents();
                    file.CopyTo(String.Format("{0}\\{1}", txtTargetDir.Text, file.Name), chkOverwrite.Checked);
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }

            lblStatus.Text = "Done.";
            Application.DoEvents();
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            var result = MessageBox.Show(
               "Are you sure?",                  // msg
               "Delete Files",                   // caption
               MessageBoxButtons.OKCancel,       // buttons
               MessageBoxIcon.Exclamation,       // icons
               MessageBoxDefaultButton.Button2); // default button

            if (result == DialogResult.OK) {
                var checkedFileList = getCheckedFileList();
                foreach (var file in checkedFileList) {
                    try {
                        lblStatus.Text = String.Format("Deleting {0}...", file.FullName);
                        Application.DoEvents();
                        file.Delete();
                    }
                    catch ( Exception ex ) {
                        MessageBox.Show(ex.Message);
                    }
                }

                lblStatus.Text = "Done.";
                Application.DoEvents();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}