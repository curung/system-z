using System;
using System.Management;
using System.Windows.Forms;
namespace system_z
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int cpuCore = Environment.ProcessorCount;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_Processor");
            ManagementObjectCollection collection = searcher.Get();
            foreach (ManagementObject obj in collection)
            {
                string cpuName = obj["Name"].ToString();
                label.Text = "cpu name:" + cpuName;
                label2.Text = "cpu cores:" + cpuCore;
            }
        }
    }
}
