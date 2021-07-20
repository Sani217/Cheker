using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Reflection;
using System.Diagnostics;
using System.Threading;
using System.Runtime.InteropServices;
using hcwgenericclasses;
using editform;


namespace winbench
{
    public partial class Form1 : Form
    {
        StringBuilder sb = new StringBuilder();
        List<XMLItem> Xitem = new List<XMLItem>();
        List<string> WsFiles = new List<string>();
        List<string> LockedFiles = new List<string>();
        List<string> AssessmentFileNames = new List<string>();
        ListInfoStack HeaderStack = new ListInfoStack();
        private BackgroundWorker bw = new BackgroundWorker();
        string CmdLine = "formal";
        const int PAD = 6;
        bool CancelProcessDir = false;
        bool EnabletscbSelectedIndexChangedHandler = true;
        private Int32 ProcessID;
        private IntPtr ProcessHandle;
        private Color SavedBackColor;
        private Color SavedTextColor;

        private static string DataStorePath = "c:\\Windows\\Performance\\WinSAT\\DataStore";
        private static string WinSATFileName = GlobalRes.ExePathFor64BitApplication;

        private static bool is64BitProcess = (IntPtr.Size == 8);
        private static bool is64BitOperatingSystem = is64BitProcess || InternalCheckIsWow64();


        DragDropTools DDT = new DragDropTools();
        ExceptionHandlerTools EHT = new ExceptionHandlerTools();
        DialogTools DT = new DialogTools();
        FileTools FT = new FileTools();
        AboutBoxTools ABT = new AboutBoxTools();

        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("kernel32.dll", SetLastError = true, CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool IsWow64Process(
             [In] IntPtr hProcess,
             [Out] out bool wow64Process
         );
        private static bool InternalCheckIsWow64()
        {
            if ((Environment.OSVersion.Version.Major == 5 && Environment.OSVersion.Version.Minor >= 1) ||
                Environment.OSVersion.Version.Major >= 6)
            {
                using (Process p = Process.GetCurrentProcess())
                {
                    bool retVal;
                    if (!IsWow64Process(p.Handle, out retVal))
                    {
                        return false;
                    }
                    return retVal;
                }
            }
            else
            {
                return false;
            }
        }

        public class Win64Interop
        {
            [DllImport("Kernel32.Dll", EntryPoint = "Wow64EnableWow64FsRedirection")]
            public static extern bool EnableWow64FSRedirection(bool enable);
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateDataFileList();
            PopulateAssessmentFileNames();
            if (AssessmentFileNames.Count > 0)
            {
                ParseXml(AssessmentFileNames[AssessmentFileNames.Count - 1]);
            }


            bw.DoWork += new DoWorkEventHandler(bwDoWork);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bwCompleted);
            SavedBackColor = this.lbDisk.BackColor;
            SavedTextColor = this.lbDisk.ForeColor;

        }

        private void ParseXml(string filename)
        {


            GetXmlFromFile(filename);
            string systemscore = GetDataValue("WinSPR", "SystemScore");
            lblLastUpdate.Text = GetAttributeValue("SystemEnvironment", "ExecDateTOD", 1);
            lbDisk.Text = GetDataValue("WinSPR", "DiskScore");
            if (lbDisk.Text == systemscore)
            {
                lbDisk.BackColor = tbBaseScore.BackColor;
                lbDisk.ForeColor = tbBaseScore.ForeColor;
            }
            else
            {
                lbDisk.BackColor = SavedBackColor;
                lbDisk.ForeColor = SavedTextColor;
            }
            lbGaming.Text = GetDataValue("WinSPR", "GamingScore");
            if (lbGaming.Text == systemscore)
            {
                lbGaming.BackColor = tbBaseScore.BackColor;
                lbGaming.ForeColor = tbBaseScore.ForeColor;
            }
            else
            {
                lbGaming.BackColor = SavedBackColor;
                lbGaming.ForeColor = SavedTextColor;
            }
            lbGraphics.Text = GetDataValue("WinSPR", "GraphicsScore");
            if (lbGraphics.Text == systemscore)
            {
                lbGraphics.BackColor = tbBaseScore.BackColor;
                lbGraphics.ForeColor = tbBaseScore.ForeColor;
            }
            else
            {
                lbGraphics.BackColor = SavedBackColor;
                lbGraphics.ForeColor = SavedTextColor;
            }
            lbRam.Text = GetDataValue("WinSPR", "MemoryScore");
            if (lbRam.Text == systemscore)
            {
                lbRam.BackColor = tbBaseScore.BackColor;
                lbRam.ForeColor = tbBaseScore.ForeColor;
            }
            else
            {
                lbRam.BackColor = SavedBackColor;
                lbRam.ForeColor = SavedTextColor;
            }
            lbProcessor.Text = GetDataValue("WinSPR", "CpuScore");
            if (lbProcessor.Text == systemscore)
            {
                lbProcessor.BackColor = tbBaseScore.BackColor;
                lbProcessor.ForeColor = tbBaseScore.ForeColor;
            }
            else
            {
                lbProcessor.BackColor = SavedBackColor;
                lbProcessor.ForeColor = SavedTextColor;
            }
            tbBaseScore.Text = GetDataValue("WinSPR", "SystemScore");
            this.btnRunBench.Select();

        }
        private void ExitBtn(object sender, EventArgs e)
        {
            this.Close();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void GetXmlFromFile(string filename)
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.DtdProcessing = DtdProcessing.Parse;
            XmlReader reader = XmlReader.Create(filename, settings);
            Xitem.Clear();
            int count = 0;
            int x = 0;
            bool AddToXi = false;

            while (reader.Read())
            {
                XMLItem dataitem = new XMLItem();
                AddToXi = false;
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        dataitem.name = reader.Name.ToString();
                        if (!HeaderStack.IsEmpty())
                        {
                            dataitem.header = HeaderStack.GetLastItem();
                            HeaderStack.Push(dataitem.name);
                        }
                        else
                        {
                            dataitem.header = "";
                            HeaderStack.Push(dataitem.name);
                        }

                        dataitem.data = reader.Value;
                        AddToXi = true;
                        break;
                    case XmlNodeType.Text:
                        Xitem[Xitem.Count - 1].data = reader.Value.ToString();
                        break;
                    case XmlNodeType.CDATA:
                        Xitem[Xitem.Count - 1].data = reader.Value.ToString();
                        break;
                    case XmlNodeType.ProcessingInstruction:
                        dataitem.name = reader.Name;
                        dataitem.data = reader.Value;
                        dataitem.header = "PROCESSING INSTRUCTION";
                        AddToXi = true;
                        break;
                    case XmlNodeType.Comment:
                        dataitem.name = reader.Name;
                        dataitem.data = reader.Value;
                        dataitem.header = "COMMENT";
                        AddToXi = true;
                        break;
                    case XmlNodeType.XmlDeclaration:
                        dataitem.header = "XML DECLARATION";
                        dataitem.name = reader.Name;
                        dataitem.data = reader.Value;
                        AddToXi = true;

                        break;
                    case XmlNodeType.Document:
                        break;
                    case XmlNodeType.DocumentType:
                        dataitem.name = "<!DOCTYPE " + reader.Name + " " + reader.Value;
                        dataitem.header = "";
                        dataitem.data = reader.Value.ToString();
                        AddToXi = true;
                        break;
                    case XmlNodeType.EntityReference:
                        dataitem.name = "ENTITY REFERENCE";
                        dataitem.data = reader.Name.ToString();
                        dataitem.header = "";
                        AddToXi = true;
                        break;
                    case XmlNodeType.EndElement:
                        HeaderStack.Pop();
                        break;
                }
                if (reader.HasAttributes)
                {
                    for (x = 0; x < reader.AttributeCount; x++)
                    {
                        reader.MoveToAttribute(x);
                        XMLAttribute xa = new XMLAttribute();
                        xa.aname = reader.Name;
                        xa.avalue = reader.Value;
                        dataitem.attributes.Add(xa);
                    }
                }
                if (AddToXi)
                {
                    Xitem.Add(dataitem);
                    count++;
                }

            }
        }

        private bool ItemContainsData(int itemnumber)
        {
            if (itemnumber < 0 || itemnumber > Xitem.Count - 1)
            {
                return false;
            }
            if (Xitem[itemnumber].data.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private string FormatXmlForDisplay()
        {

            sb.Clear();
            sb.Append("File Name: " + tscbAssessmentFiles.SelectedItem.ToString() + "\r\n\n");
            int itemcount = 1;
            int attributecount = 1;
            foreach (XMLItem i in Xitem)
            {

                sb.Append("Item     : " + itemcount.ToString() + "\r\n");
                sb.Append("Header   : " + i.header.PadRight(PAD) + "\r\n");
                sb.Append("Name     : " + i.name.PadRight(PAD) + "\r\n");
                attributecount = 1;
                foreach (XMLAttribute s in i.attributes)
                {
                    sb.Append("Attr (" + attributecount.ToString() + ") : " + s.aname.PadRight(PAD) + " " + s.avalue.PadRight(PAD) + "\r\n");
                    attributecount++;
                }
                sb.Append("Data     : " + i.data.PadRight(PAD) + "\r\n\n");
                itemcount++;
            }
            return sb.ToString();

        }

        private string GetAttributeValue(string header, string name, int number)
        {
            string result = "";
            int x = 0;
            for (x = 0; x < Xitem.Count; x++)
            {
                if (Xitem[x].header == header && Xitem[x].name == name)
                {
                    if (Xitem[x].attributes.Count >= number)
                    {
                        result = Xitem[x].attributes[number - 1].avalue;
                        break;
                    }

                }
            }
            return result;
        }
        private string GetDataValue(string header, string name)
        {
            string result = "";
            int x = 0;
            for (x = 0; x < Xitem.Count; x++)
            {
                if (Xitem[x].header == header && Xitem[x].name == name)
                {
                    result = Xitem[x].data;
                }
            }
            return result;
        }

        private void PopulateDataFileList()
        {
            if (!Directory.Exists(DataStorePath))
            {
                DT.NotifyDialog(this, "WEXEP.EXE \r\n No benchmark files found. \r\n Click the RunBenchmark Button.", 4000);
                btnRunBench.Select();
                return;
            }
            WsFiles.Clear();
            LockedFiles.Clear();
            WsFiles.Add(DataStorePath);
            FT.ProcessDirectories(ref WsFiles, ref LockedFiles, false, ref CancelProcessDir);

        }

        private void PopulateAssessmentFileNames()
        {
            AssessmentFileNames.Clear();
            foreach (string s in WsFiles)
            {
                if (s.Contains("Formal.Assessment"))
                {
                    AssessmentFileNames.Add(s);
                }
            }
            AssessmentFileNames.Sort();             
            tscbAssessmentFiles.Items.Clear();
            foreach (string s in AssessmentFileNames)
            {
                tscbAssessmentFiles.Items.Add(s);
            }
            EnabletscbSelectedIndexChangedHandler = false;  
            tscbAssessmentFiles.SelectedIndex = tscbAssessmentFiles.Items.Count - 1;   
            EnabletscbSelectedIndexChangedHandler = true;  
           
        }



        private void btnGetBenchMark_Click(object sender, EventArgs e)
        {
            
            bool result = true;
            Process n = new Process();
            Int32 ID = 0;

            n.StartInfo.FileName = WinSATFileName;

            n.StartInfo.Arguments = CmdLine;
            n.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
            Exception StartEx = new Exception("(Application) - Unable to Start WinSAT.exe, althought path is valid.");
            try
            {
                if (is64BitOperatingSystem)
                {
                    Win64Interop.EnableWow64FSRedirection(false);
                    n.Start();
                    ID = n.Id;
                    Win64Interop.EnableWow64FSRedirection(true);
                }
                else
                {
                    n.Start();
                    ID = n.Id;
                    ProcessHandle = n.Handle;
                }
                
            }
            catch (Exception ex)
            {
                EHT.GeneralExceptionHandler("Error Rerunning Benchmark", n.StartInfo.FileName, false, ex);
                result = false;
            }
            finally
            {
                if (result)
                {
                    DT.NotifyDialog(this, "Starting Benchmark...");
                    lblLastUpdate.Text = "";
                    lblLastUpdate.Text = "Update is Running";
                    ProcessID = n.Id;
                    this.btnClose.Select(); 
                }
            }
            
            btnRunBench.Enabled = false;
            bw.RunWorkerAsync();
            return;
        }
        private void bwDoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            FileWatcher FSW = new FileWatcher(DataStorePath, "*.*");        
            FSW.Start();
            while (!FSW.Completed)
            {

            }

        }
        private void bwCompleted(object sender, RunWorkerCompletedEventArgs e)
        { 
            Thread.Sleep(3000);  
            PopulateDataFileList();
            PopulateAssessmentFileNames();
            if (AssessmentFileNames.Count > 0)
            {
                ParseXml(AssessmentFileNames[AssessmentFileNames.Count - 1]);
            }
            btnRunBench.Enabled = true;
        }
        private void tscbAssessmentFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!EnabletscbSelectedIndexChangedHandler)
            {
                return;
            }
            int x = tscbAssessmentFiles.SelectedIndex;
            string s = tscbAssessmentFiles.SelectedItem.ToString();
            ParseXml(s);
        }
        private void reloadAssessmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DT.NotifyDialog(this, "Rescanning DataStore Folder");
            PopulateDataFileList();
            PopulateAssessmentFileNames();
            if (AssessmentFileNames.Count > 0)
            {
                ParseXml(AssessmentFileNames[AssessmentFileNames.Count - 1]);
            }
        }

        private void lblLastUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
