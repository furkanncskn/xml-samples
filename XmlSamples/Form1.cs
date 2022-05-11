using System;
using System.IO;
using System.Text;
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
                    path: Helper.Operations.CreateFileWithDialog(),
                    contents: Helper.Operations.FromXmlToString(uri: Helper.Operations.SelectWithOpenFileDialog())
                );
        }

        private void BtnPrettierWriteToFile_Click(object sender, System.EventArgs e)
        {
            File.WriteAllText(
                    path: Helper.Operations.CreateFileWithDialog(),
                    contents: Helper.Operations.PrettierFromXmlToString(uri: Helper.Operations.SelectWithOpenFileDialog())
                );
        }

        private void BtnFillGrid_Click(object sender, System.EventArgs e)
        {
            var data = Helper.Operations.FromXmlToDataSet(uri: Helper.Operations.SelectWithOpenFileDialog());

            TestDataGrid.DataSource = data.Tables[0];
        }

        private void BtnWriteToXml_Click(object sender, System.EventArgs e)
        {
            Helper.Operations.FromSqlToXml(fileName: Helper.Operations.CreateFileWithDialog());
        }

        private void BtnGetFirstElement_Click(object sender, System.EventArgs e)
        {
            var user = DataAccess.DAL<Entity.User>
                .FirstElementFromXmlToInstance(
                        uri: Helper.Operations.SelectWithOpenFileDialog()
                    );

            if (user == null) return;

            string str = Helper.Convert.FromObjectToString<Entity.User>(user);

            File.WriteAllText(
                    path: Helper.Operations.CreateFileWithDialog(),
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
                        uri: Helper.Operations.SelectWithOpenFileDialog(),
                        id: id
                    );

                if (user == null) return;

                string str = Helper.Convert.FromObjectToString<Entity.User>(user);

                File.WriteAllText(
                    path: Helper.Operations.CreateFileWithDialog(),
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

        private void BtmObjectToList_Click(object sender, EventArgs e)
        {
            var listUsers = Helper.Convert.FromArrayToList<Entity.User>(
                    param: Entity.DummyData.UserDummyData.users
                );

            StringBuilder str = new();

            listUsers.ForEach(item => str.Append(
                value: Helper.Convert.FromObjectToString<Entity.User>(item))
            );

            MessageBox.Show(str.ToString());
        }

        private void BtnListToTable_Click(object sender, EventArgs e)
        {
            TestDataGrid.DataSource = Helper.Convert.FromListToDataTable<Entity.User>(
                    list: Entity.DummyData.UserDummyData.listUsers
                );
        }

        private void BtnXmlSerialize_Click(object sender, EventArgs e)
        {
            Helper.Operations.XmlSerialize(
                    instance: Entity.DummyData.UserDummyData.users[0],
                    fileName: Helper.Operations.CreateFileWithDialog()
                );
        }

        private void BtnXmlDesrialize_Click(object sender, EventArgs e)
        {
            try
            {
                var user = Helper.Operations.XmlDeSerialize<Entity.User>(
                fileName: Helper.Operations.SelectWithOpenFileDialog());

                if (user == null) { throw new NullReferenceException(); }

                string str = Helper.Convert.FromObjectToString<Entity.User>(user);

                MessageBox.Show(str);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                throw;
            }
        }
    }
}