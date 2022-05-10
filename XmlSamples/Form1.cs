using System;
using System.IO;
using System.Windows.Forms;

namespace XmlSamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnWriteToFile_Click(object sender, System.EventArgs e)
        {
            File.WriteAllText(
                    path: Operations.CreateFileWithDialog(),
                    contents: Operations.FromXmlToString(uri: Operations.SelectWithOpenFileDialog())
                );
        }

        private void BtnPrettierWriteToFile_Click(object sender, System.EventArgs e)
        {
            File.WriteAllText(
                    path: Operations.CreateFileWithDialog(),
                    contents: Operations.PrettierFromXmlToString(uri: Operations.SelectWithOpenFileDialog())
                );
        }

        private void BtnFillGrid_Click(object sender, System.EventArgs e)
        {
            var data = Operations.FromXmlToDataSet(uri: Operations.SelectWithOpenFileDialog());

            TestDataGrid.DataSource = data.Tables[0];
        }

        private void BtnWriteToXml_Click(object sender, System.EventArgs e)
        {
            Operations.FromSqlToXml(fileName: Operations.CreateFileWithDialog());
        }

        private void BtnGetFirstElement_Click(object sender, System.EventArgs e)
        {
            var user = DataAccess.DAL<Entity.User>
                .FirstElementFromXmlToInstance(
                        uri: Operations.SelectWithOpenFileDialog()
                    );

            if (user == null) return;

            string str = Helper.Convert.FromObjectToString<Entity.User>(user);

            File.WriteAllText(
                    path: Operations.CreateFileWithDialog(),
                    contents: str.ToString()
                );

            MessageBox.Show(str);
        }

        private void BtnGetUserById_Click(object sender, System.EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(TxtId.Text.Trim());

                if (id <= 0) { throw new Exception("Invalid id"); };

                var user = DataAccess.DAL<Entity.User>.
                    FromXmlToInstanceById(
                        uri: Operations.SelectWithOpenFileDialog(),
                        id: id
                    );

                if (user == null) return;

                string str = Helper.Convert.FromObjectToString<Entity.User>(user);

                File.WriteAllText(
                    path: Operations.CreateFileWithDialog(),
                    contents: str.ToString()
                );

                MessageBox.Show(str);

                TxtId.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}