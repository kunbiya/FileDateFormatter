using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FileDateFormat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenFileBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, DateTime> FileInfo;
            OpenFileDialog ofd = new OpenFileDialog();

            try
            {
                if (ofd.ShowDialog() == DialogResult.OK) FilePath.Text = ofd.FileName;
                FileDateFormatter fdf = new FileDateFormatter();

                FileInfo = fdf.GetFileInfo(ofd.FileName);

                CreationTime.Value = FileInfo["CreationTime"];
                LastWriteTime.Value = FileInfo["LastWriteTime"];
                LastAccessTime.Value = FileInfo["LastAccessTime"];


                beforeCreationTime.Text = FileInfo["CreationTime"].ToString();
                beforeLastWriteTime.Text = FileInfo["LastWriteTime"].ToString();
                beforeLastAccessTime.Text = FileInfo["LastAccessTime"].ToString();

            }
            catch (Exception ee)
            {
                
            }
        }
        private void ChangeCollectiveBtn_Click(object sender, EventArgs e)
        {
            CreationTime.Value = ChangeCollectiveTime.Value;
            LastWriteTime.Value = ChangeCollectiveTime.Value;
            LastAccessTime.Value = ChangeCollectiveTime.Value;
        }

        private void ModifyDateBtn_Click(object sender, EventArgs e)
        {
            bool setDateOk;
            FileDateFormatter fdf = new FileDateFormatter();
            Dictionary<string, DateTime> getSetDate = new Dictionary<string, DateTime>();

            try
            {
                getSetDate.Add("CreationTime", CreationTime.Value);
                getSetDate.Add("LastWriteTime", LastWriteTime.Value);
                getSetDate.Add("LastAccessTime", LastAccessTime.Value);
                setDateOk = fdf.SetFileDate(FilePath.Text, getSetDate);

            }
            catch (Exception e2)
            {
                MessageBox.Show("날짜 변경에 실패함. \n에러코드: " + e2, "날짜 변경 실패");
                setDateOk = false;
            }
            if (setDateOk) MessageBox.Show("날짜 변경에 성공함", "날짜 변경 성공");
        }
    }
}