using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MS_Control.DataBase
{
    public partial class Form_CMD : MS_Mother_Mali
    {
        public Form_CMD()
        {
            InitializeComponent();
        }

        private static StringBuilder cmdOutput = null;
        Process cmdProcess;
        StreamWriter cmdStreamWriter;

        private static void SortOutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
        {
            if (!String.IsNullOrEmpty(outLine.Data))
            {
                cmdOutput.Append(Environment.NewLine + outLine.Data);
            }
        }

        private void Form_CMD_Shown(object sender, EventArgs e)
        {
            cmdOutput = new StringBuilder("");
            cmdProcess = new Process();

            cmdProcess.StartInfo.FileName = "cmd.exe";
            cmdProcess.StartInfo.UseShellExecute = false;
            cmdProcess.StartInfo.CreateNoWindow = true;
            cmdProcess.StartInfo.RedirectStandardOutput = true;

            cmdProcess.OutputDataReceived += new DataReceivedEventHandler(SortOutputHandler);
            cmdProcess.StartInfo.RedirectStandardInput = true;
            cmdProcess.Start();

            cmdStreamWriter = cmdProcess.StandardInput;
            cmdProcess.BeginOutputReadLine();
        }

        private void ms_RunCommand_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ms_Command.Text))
            {
                ms_Command.Focus(); return;
            }
            cmdStreamWriter.WriteLine(ms_Command.Text);
            ms_Timer.Enabled = true;
            ms_Timer.Start();
        }

        private void ms_Timer_Tick(object sender, EventArgs e)
        {
            if (cmdOutput != null)
                ms_Result.Text = cmdOutput.ToString();
        }

        private void ms_ResetResult_Click(object sender, EventArgs e)
        {
            cmdOutput = new StringBuilder("");
            cmdProcess = new Process();

            cmdProcess.StartInfo.FileName = "cmd.exe";
            cmdProcess.StartInfo.UseShellExecute = false;
            cmdProcess.StartInfo.CreateNoWindow = true;
            cmdProcess.StartInfo.RedirectStandardOutput = true;

            cmdProcess.OutputDataReceived += new DataReceivedEventHandler(SortOutputHandler);
            cmdProcess.StartInfo.RedirectStandardInput = true;
            cmdProcess.Start();

            cmdStreamWriter = cmdProcess.StandardInput;
            cmdProcess.BeginOutputReadLine();

            ms_Command.Focus();
        }
    }
}
