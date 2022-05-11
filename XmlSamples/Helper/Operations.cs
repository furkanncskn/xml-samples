using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace XmlSamples.Helper
{
    public class Operations
    {
        private static readonly string connectionString = @"
                Data Source=DESKTOP-E6P74F1\FCOSKUN; 
                Initial Catalog=spacesurgeondb; 
                Integrated Security=True
            ";

        public static void FromSqlToXml(string fileName)
        {
            try
            {
                using (DbConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = connectionString;
                    using (DbCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "sp_get_users";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Connection = connection;

                        using (DbDataAdapter adapter = new SqlDataAdapter())
                        {
                            adapter.SelectCommand = command;

                            DataSet ds = new("Users");

                            adapter.Fill(ds);

                            if (!(ds.Tables.Count > 0))
                                throw new ArgumentNullException("Invalid DataSet Object");

                            ds.WriteXml(fileName, XmlWriteMode.WriteSchema);
                        };
                    };
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static DataSet FromXmlToDataSet(string uri)
        {
            try
            {
                DataSet dataSet = new();

                XmlReader reader = XmlReader.Create(uri);

                dataSet.ReadXml(reader, XmlReadMode.InferSchema);

                return dataSet;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return new DataSet();
            }
        }

        public static string FromXmlToString(string uri)
        {
            try
            {
                XmlDocument doc = new XmlDocument();

                using (StringWriter sw = new StringWriter())
                {
                    doc.Load(uri);

                    doc.Save(sw);

                    return sw.ToString();
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return string.Empty;
            }
        }

        public static string PrettierFromXmlToString(string uri)
        {
            try
            {
                XmlReaderSettings settings = new XmlReaderSettings()
                {
                    Async = true,
                    IgnoreComments = true,
                    IgnoreWhitespace = true,
                };

                XmlReader reader = XmlReader.Create(
                                            inputUri: uri,
                                            settings: settings
                                            );

                int rootCnt = 0, NodeCnt = 0, ElementCnt = 0;

                StringBuilder str = new();
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        if (reader.Depth == 0)
                        {
                            str.AppendLine("[" + ++rootCnt + ".Root]: " + reader.Name);
                            str.AppendLine("====================================");

                            NodeCnt = 0;
                            ElementCnt = 0;
                        }
                        else if (reader.Depth == 1)
                        {
                            str.AppendLine("\n[" + ++NodeCnt + ".Node]: " + reader.Name.ToString());
                            str.AppendLine("-----------------------");

                            ElementCnt = 0;
                        }
                        else if (reader.Depth == 2)
                        {
                            str.Append("[" + ++ElementCnt + ".Element] Name: " + reader.Name.ToString());
                        }
                    }

                    if (reader.HasValue == false)
                        continue;

                    if (reader.NodeType == XmlNodeType.Text)
                    {
                        str.AppendLine(
                                        " || Value: " + reader.Value.ToString()
                                    );
                    }

                    reader.MoveToElement();
                }

                return str.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return string.Empty;
            }
        }

        public static string CreateFileWithDialog()
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "txt files (*.txt)|*.txt|xml files (*.xml)|*.xml|All files (*.*)|*.*";

                    if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        throw new NullReferenceException("Invalid Selection");
                    }

                    return saveFileDialog.FileName;
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return string.Empty;
            }

        }

        public static string SelectWithOpenFileDialog()
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    if (ofd.ShowDialog() != DialogResult.OK) { throw new Exception("Invalid Selection"); }

                    string filePath = ofd.FileName;

                    return filePath;
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return string.Empty;
            }
        }

        public static void XmlSerialize<T>(T instance, string fileName) where T : class, new()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));

                using (XmlWriter writer = XmlWriter.Create(fileName))
                {
                    serializer.Serialize(writer, instance);
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static T? XmlDeSerialize<T>(string fileName) where T : class, new()
        {
            try
            {
                using (XmlReader reader = XmlReader.Create(fileName))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));

                    if (serializer == null) throw new NullReferenceException();

                    return (T?)serializer.Deserialize(reader);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }
        }
    }
}