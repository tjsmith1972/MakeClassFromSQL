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
using System.Data.SqlTypes;
using System.Configuration;


namespace MakeClassFromSQL
{
    public partial class Form1 : Form
    {
        string instructions = "Type any query here that will return the columns you'd like to see in your POCO.\r\nChoose a language below and click 'Generate Class' for results.";
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = ConfigurationManager.AppSettings["SQLConnectionString"];
            textBox2.ForeColor = SystemColors.GrayText;
            textBox2.Text = instructions;
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
        }
        

        private void cmdGenerateClass_Click(object sender, EventArgs e)
        {
            StringBuilder sbClass = new StringBuilder();
            StringBuilder sb = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            using (SqlConnection conn = new SqlConnection(textBox1.Text))
            {
                SqlDataAdapter da = new SqlDataAdapter(textBox2.Text, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (rbC.Checked)
                {
                    sbClass.Append("public class " + ds.Tables[0].TableName);
                    sbClass.Append("\r\n{");
                }
                else
                {    
                    sbClass.Append("Public Class " + ds.Tables[0].TableName);
                    sbClass.Append("\r\n");                
                }
                foreach (DataColumn dc in ds.Tables[0].Columns)
                {
                    if (rbC.Checked)
                    {
                        if (chkQuickProperties.Checked)
                            sb.Append("\r\npublic " + dc.DataType.ToString() + " " + dc.ColumnName + "{ get; set; }");
                        else
                        {
                            sb2.Append("\r\nprivate " + dc.DataType.ToString() + " _" + dc.ColumnName + ";");
                            sb.Append("\r\npublic " + dc.DataType.ToString() + " " + dc.ColumnName + "\r\n{ \r\nget { return _" + dc.ColumnName + "; }\r\nset { " + dc.ColumnName + " = value; }\r\n}");
                        }
                    }
                    else
                    {
                        //vb code
                        sb2.Append("\r\nPrivate _" + dc.ColumnName + " As " + dc.DataType.ToString());
                        sb.Append("\r\nPublic Property " + dc.ColumnName + "() As " + dc.DataType.ToString() + 
                            "\r\nGet\r\nReturn _" + dc.ColumnName + 
                            "\r\nEnd Get\r\nSet(ByVal value As " + dc.DataType.ToString() + ")" +
                            "\r\n_" + dc.ColumnName + " = value\r\nEnd Set\r\nEnd Property\r\n");
                    }
                }
                sb2.Append("\r\n");
                sb.Append("\r\n" + (rbC.Checked ? "}" : "End Class"));
            }
            textBox3.Text = sbClass.ToString() + sb2.ToString() + sb.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            chkQuickProperties.Enabled = !rbVB.Checked;
        }

        private void rbC_CheckedChanged(object sender, EventArgs e)
        {
            chkQuickProperties.Enabled = !rbVB.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox3.Text);
            MessageBox.Show("Copied");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            config.AppSettings.Settings.Remove("SQLConnectionString");
            config.AppSettings.Settings.Add("SQLConnectionString", textBox1.Text);
            config.Save(ConfigurationSaveMode.Minimal);
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                textBox2.Text = instructions;
                textBox2.ForeColor = SystemColors.GrayText;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == instructions)
            {
                textBox2.Text = "";
                textBox2.ForeColor = SystemColors.WindowText;
            }
        }
    }
}
