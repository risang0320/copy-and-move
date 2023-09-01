using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using Tulpep.NotificationWindow;
using System.IO;

namespace copy_and_move
{
    public partial class Main_display : Form
    {
        public Main_display()
        {
            InitializeComponent();
        }

        //pop notifier globle object creation
        PopupNotifier popup = new PopupNotifier();
        DateTime cdt = DateTime.Now;
        public string findchecksum(string sourcefile)
        {
            string filepath = sourcefile;
            using (FileStream ff = File.OpenRead(filepath))
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashbyte = sha256.ComputeHash(ff);
                return BitConverter.ToString(hashbyte).Replace("_", "").ToLower();
            }
        }
        //get file size in adding for checklist box 1
        private string FormatFileSize(long fileSize)
        {
            string[] sizes = { "B", "KB", "MB", "GB" };
            int order = 0;

            while (fileSize >= 1024 && order < sizes.Length - 1)
            {
                fileSize /= 1024;
                order++;
            }

            return $"{fileSize:0.##} {sizes[order]}";
        }
        //get the folder path and set the files in checklistbox
        private void Btn_Source_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            Txt_Source.Text = folderBrowserDialog1.SelectedPath.ToString();
            if (Txt_Source.Text != string.Empty)
            {
                DirectoryInfo c = new DirectoryInfo(Txt_Source.Text);
                FileInfo[] fI = c.GetFiles();
                Clb_Source.Items.Clear();
                foreach (FileInfo f in fI)
                {
                    long fileSizeBytes = f.Length;
                    string fileSizeFormatted = FormatFileSize(fileSizeBytes);
                    string fileDisplayName = $"{f.Name} ({fileSizeFormatted})";
                    Clb_Source.Items.Add(fileDisplayName);

                }
            }
        }
        //get the target folder
        private void Btn_Target_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            Txt_Target.Text = folderBrowserDialog1.SelectedPath.ToString();
        }
        // copy a checklist box selected files and store in listbox
        private void Btn_Copy_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(Txt_Source.Text))
                {
                    if (!string.IsNullOrEmpty(Txt_Target.Text))
                    {
                        if (Clb_Source.CheckedItems.Count == 0)
                        {
                            MessageBox.Show("Pleas Select The File", "alart", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        foreach (var item in Clb_Source.CheckedItems)
                        {
                            string[] filename = item.ToString().Split('(');

                            string sourcefilepath = Path.Combine(Txt_Source.Text, filename[0]);
                            string desfilepath = Path.Combine(Txt_Target.Text, filename[0]);
                            string itemname = item.ToString();

                            if (File.Exists(sourcefilepath))
                            {
                                File.Copy(sourcefilepath, desfilepath, true);
                                MessageBox.Show("copy files successfully", "SUCESSFULL", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            //Get The Time For Copy the Creation Time 
                            DateTime orginaldate1 = File.GetLastWriteTimeUtc(sourcefilepath);
                            DateTime orginaldate = File.GetCreationTimeUtc(sourcefilepath.ToString());
                            File.SetLastWriteTimeUtc(desfilepath, orginaldate1);
                            File.SetCreationTimeUtc(desfilepath, orginaldate);
                            DirectoryInfo c = new DirectoryInfo(Txt_Target.Text);
                            FileInfo[] fI = c.GetFiles();
                            Lb_Target.Items.Clear();
                            foreach (FileInfo f in fI)
                            {
                                Lb_Target.Items.Add(f);
                            }
                            // Checksum Calculation it's Call As Global Function 
                            string sourcefilechecksum = findchecksum(sourcefilepath);
                            string destintionfilechecksum = findchecksum(desfilepath);
                            if (sourcefilechecksum == destintionfilechecksum)
                            {
                                popup.TitleText = "checksum detaile";
                                popup.ContentText = "checsum was match";
                                Console.WriteLine("File transfer successful. Checksums match. sender checksum is: " + sourcefilechecksum + "\nreciver checksum is: " + destintionfilechecksum);
                            }
                            else
                            {
                                MessageBox.Show("cheksum is not match");
                                Console.WriteLine("checksum is not match , sender checksum is:" + sourcefilechecksum + "reciver checksum is" + destintionfilechecksum);
                            }
                            //Pop Up Notifier Disgn
                            popup.TitleColor = Color.Black;
                            popup.TitleFont = new Font("Times New Roman", 10, FontStyle.Bold);
                            popup.ContentColor = Color.Brown;
                            popup.ContentFont = new Font("Times New Roman", 8, FontStyle.Bold);
                            popup.HeaderColor = Color.FromArgb(255, 128, 0);
                            popup.BodyColor = Color.Aqua;
                            popup.Popup();

                            if (Lb_Target.Items.Count == 0)
                            {

                            }
                            else
                            {
                                using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\riyas\\OneDrive\\Documents\\copy.mdf;Integrated Security=True;Connect Timeout=30"))
                                    try
                                    {


                                        connection.Open();


                                        string insertQuery = "INSERT INTO dashboard1(date, source_folder, target_folder, file_name, mode) VALUES (@Value1, @Value2, @value3, @value4, @value5)";
                                        SqlCommand cmd = new SqlCommand(insertQuery, connection);
                                        cmd.Parameters.AddWithValue("@value1", cdt);
                                        cmd.Parameters.AddWithValue("@Value2", Txt_Source.Text);
                                        cmd.Parameters.AddWithValue("@Value3", Txt_Target.Text);
                                        cmd.Parameters.AddWithValue("@value4", itemname);
                                        cmd.Parameters.AddWithValue("@value5", "COPY");

                                        cmd.ExecuteNonQuery();

                                        MessageBox.Show("Data inserted successfully.");


                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("" + ex);
                                    }
                                    finally
                                    {
                                        connection.Close();
                                    }

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("destination path didn't Selected", "alart", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Source path didn't Selected", "alart", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        // copy a checklist box selected files and store in listbox
        private void Btn_Move_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Txt_Source.Text))
            {
                if (!string.IsNullOrEmpty(Txt_Target.Text))
                {
                    if (Clb_Source.CheckedItems.Count == 0)
                    {
                        MessageBox.Show("Pleas Select The File", "alart", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    foreach (var item in Clb_Source.CheckedItems)
                    {
                        string[] filename = item.ToString().Split('(');
                        string sourcefilepath = Path.Combine(Txt_Source.Text, filename[0]);
                        string desfilepath = Path.Combine(Txt_Target.Text, filename[0]);
                        string itemname = item.ToString();
                        string sourcefilechecksum = findchecksum(sourcefilepath);
                        if (File.Exists(desfilepath))
                        {
                            DialogResult result = MessageBox.Show("The file already exists in the target folder. Do you want to replace it?", "File Exists", MessageBoxButtons.YesNo);
                            //file already exiests in target folder show a message box click replace move a file and add a daatabase in dashboard
                            if (result == DialogResult.Yes)
                            {

                                File.Copy(sourcefilepath, desfilepath, true);
                                File.Delete(sourcefilepath);
                                MessageBox.Show("Move checkedlist items", "SUCESSFUL");
                                using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\riyas\\OneDrive\\Documents\\copy.mdf;Integrated Security=True;Connect Timeout=30"))
                                    try
                                    {
                                        connection.Open();

                                        string insertQuery = "INSERT INTO dashboard1(date, source_folder, target_folder, file_name, mode) VALUES (@Value1, @Value2, @value3, @value4, @value5)";
                                        SqlCommand cmd = new SqlCommand(insertQuery, connection);
                                        cmd.Parameters.AddWithValue("@value1", cdt);
                                        cmd.Parameters.AddWithValue("@Value2", Txt_Source.Text);
                                        cmd.Parameters.AddWithValue("@Value3", Txt_Target.Text);
                                        cmd.Parameters.AddWithValue("@value4", itemname);
                                        cmd.Parameters.AddWithValue("@value5", "MOVE");

                                        cmd.ExecuteNonQuery();

                                        MessageBox.Show("Data inserted successfully.");

                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("" + ex);
                                    }
                                    finally
                                    {
                                        connection.Close();
                                    }
                            }
                            //press noo skip transfer and exit
                            else if (result == DialogResult.No)
                            {
                                MessageBox.Show("transfer skip", "alart", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        //file not found a target folder move a file and add a database in dashboard
                        else
                        {
                            File.Move(sourcefilepath, desfilepath);
                            MessageBox.Show("Move checkedlist items", "SUCESSFUL");
                            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\riyas\\OneDrive\\Documents\\copy.mdf;Integrated Security=True;Connect Timeout=30"))
                                try
                                {
                                    connection.Open();

                                    string insertQuery = "INSERT INTO dashboard1(date, source_folder, target_folder, file_name, mode) VALUES (@Value1, @Value2, @value3, @value4, @value5)";
                                    SqlCommand cmd = new SqlCommand(insertQuery, connection);
                                    cmd.Parameters.AddWithValue("@value1", cdt);
                                    cmd.Parameters.AddWithValue("@Value2", Txt_Source.Text);
                                    cmd.Parameters.AddWithValue("@Value3", Txt_Target.Text);
                                    cmd.Parameters.AddWithValue("@value4", itemname);
                                    cmd.Parameters.AddWithValue("@value5", "MOVE");

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Data inserted successfully.");

                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("" + ex);
                                }
                                finally
                                {
                                    connection.Close();
                                }
                        }
                        //Get The Time For Copy The Creation Time and set a files
                        DateTime orginaldate1 = File.GetLastWriteTimeUtc(sourcefilepath);
                        DateTime orginaldate = File.GetCreationTimeUtc(sourcefilepath.ToString());
                        File.SetLastWriteTimeUtc(desfilepath, orginaldate1);
                        File.SetCreationTimeUtc(desfilepath, orginaldate);
                        DirectoryInfo c = new DirectoryInfo(Txt_Target.Text);
                        FileInfo[] fI = c.GetFiles();
                        Lb_Target.Items.Clear();
                        //adding in listbox Lb_target is a name of listbox
                        foreach (FileInfo f in fI)
                        {

                            Lb_Target.Items.Add(f);
                        }
                        // Checksum Calculation it's Call As Global Function
                        string destintionfilechecksum = findchecksum(desfilepath);
                        if (sourcefilechecksum == destintionfilechecksum)
                        {
                            popup.TitleText = "checksum detaile";
                            popup.ContentText = "checsum was match";
                            Console.WriteLine("File transfer successful. Checksums match. sender checksum is: " + sourcefilechecksum + "\nreciver checksum is: " + destintionfilechecksum);
                        }
                        else
                        {
                            MessageBox.Show("cheksum is not match");
                            Console.WriteLine("checksum is not match , sender checksum is:" + sourcefilechecksum + "reciver checksum is" + destintionfilechecksum);
                        }
                        //pop up notifier disgn
                        popup.TitleColor = Color.Black;
                        popup.TitleFont = new Font("Times New Roman", 10, FontStyle.Bold);
                        popup.ContentColor = Color.Brown;
                        popup.ContentFont = new Font("Times New Roman", 8, FontStyle.Bold);
                        popup.HeaderColor = Color.FromArgb(255, 128, 0);
                        popup.BodyColor = Color.Aqua;
                        popup.Popup();

                    }
                }
                // this message box show in not select in a target path
                else
                {
                    MessageBox.Show("destination path didn't Selected", "alart", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // this message box show in not select in a source  path
            else
            {
                MessageBox.Show("Source path didn't Selected", "alart", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //connect to the database window
        private void Btn_Dashboard_Click(object sender, EventArgs e)
        {
            var dashboard = new dashboard1();
            dashboard.Show();
        }
    }
}
