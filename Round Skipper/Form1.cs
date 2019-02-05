using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PS3Lib;
using System.Threading;

namespace Round_Skipper
{
    public partial class Form1 : Form
    {
        static PS3API PS3 = new PS3API();
        public class RPC
        {
            public static uint function_address = 0x6e34e0;

            public static uint Call(uint func_address, params object[] parameters)
            {
                int length = parameters.Length;
                uint num2 = 0;
                for (uint i = 0; i < length; i++)
                {
                    if (parameters[i] is int)
                    {
                        byte[] array = BitConverter.GetBytes((int)parameters[i]);
                        Array.Reverse(array);
                        PS3.SetMemory(0x10050000 + ((i + num2) * 4), array);
                    }
                    else if (parameters[i] is uint)
                    {
                        byte[] buffer2 = BitConverter.GetBytes((uint)parameters[i]);
                        Array.Reverse(buffer2);
                        PS3.SetMemory(0x10050000 + ((i + num2) * 4), buffer2);
                    }
                    else if (parameters[i] is string)
                    {
                        byte[] buffer = Encoding.UTF8.GetBytes(Convert.ToString(parameters[i]) + "\0");
                        PS3.SetMemory(0x10050054 + (i * 0x400), buffer);
                        uint num4 = 0x10050054 + (i * 0x400);
                        byte[] buffer4 = BitConverter.GetBytes(num4);
                        Array.Reverse(buffer4);
                        PS3.SetMemory(0x10050000 + ((i + num2) * 4), buffer4);
                    }
                    else if (parameters[i] is float)
                    {
                        num2++;
                        byte[] buffer5 = BitConverter.GetBytes((float)parameters[i]);
                        Array.Reverse(buffer5);
                        PS3.SetMemory(0x10050024 + ((num2 - 1) * 4), buffer5);
                    }
                }
                byte[] bytes = BitConverter.GetBytes(func_address);
                Array.Reverse(bytes);
                PS3.SetMemory(0x1005004c, bytes);
                Thread.Sleep(20);
                byte[] buffer7 = new byte[4];
                PS3.GetMemory(0x10050050, buffer7);
                Array.Reverse(buffer7);
                return BitConverter.ToUInt32(buffer7, 0);
            }

            public static void Enable_RPC()
            {
                PS3.SetMemory(function_address, new byte[] { 0x4e, 0x80, 0, 0x20 });
                Thread.Sleep(20);
                byte[] buffer = new byte[] { 
                    0x7c, 8, 2, 0xa6, 0xf8, 1, 0, 0x80, 60, 0x60, 0x10, 5, 0x81, 0x83, 0, 0x4c, 
                    0x2c, 12, 0, 0, 0x41, 130, 0, 100, 0x80, 0x83, 0, 4, 0x80, 0xa3, 0, 8, 
                    0x80, 0xc3, 0, 12, 0x80, 0xe3, 0, 0x10, 0x81, 3, 0, 20, 0x81, 0x23, 0, 0x18, 
                    0x81, 0x43, 0, 0x1c, 0x81, 0x63, 0, 0x20, 0xc0, 0x23, 0, 0x24, 0xc0, 0x43, 0, 40, 
                    0xc0, 0x63, 0, 0x2c, 0xc0, 0x83, 0, 0x30, 0xc0, 0xa3, 0, 0x34, 0xc0, 0xc3, 0, 0x38, 
                    0xc0, 0xe3, 0, 60, 0xc1, 3, 0, 0x40, 0xc1, 0x23, 0, 0x48, 0x80, 0x63, 0, 0, 
                    0x7d, 0x89, 3, 0xa6, 0x4e, 0x80, 4, 0x21, 60, 0x80, 0x10, 5, 0x38, 160, 0, 0, 
                    0x90, 0xa4, 0, 0x4c, 0x90, 100, 0, 80, 0xe8, 1, 0, 0x80, 0x7c, 8, 3, 0xa6, 
                    0x38, 0x21, 0, 0x70, 0x4e, 0x80, 0, 0x20
                 };
                PS3.SetMemory(function_address + 4, buffer);
                PS3.SetMemory(0x10050000, new byte[0x2854]);
                PS3.SetMemory(function_address, new byte[] { 0xf8, 0x21, 0xff, 0x91 });
            }
        }
        public void Cbuf_AddText(int localClient, string command)
        {
            RPC.Call(0x395ba8, new object[] { localClient, command });
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void monoFlat_RadioButton1_CheckedChanged(object sender)
        {
            PS3.ChangeAPI(SelectAPI.TargetManager);
        }

        private void monoFlat_RadioButton2_CheckedChanged(object sender)
        {
            PS3.ChangeAPI(SelectAPI.ControlConsole);
        }

        private void monoFlat_Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (PS3.ConnectTarget() && PS3.AttachProcess())
                {
                    RPC.Enable_RPC();
                    byte[] buffer = new byte[0x530];
                    byte[] buffer2 = buffer;
                    byte[] buffer3 = new byte[] { 
                    0x38, 0x60, 0, 0, 60, 0x80, 2, 0, 0x30, 0x84, 80, 0, 0x4b, 0xf3, 0x35, 9, 
                    0x4b, 0xff, 0xfb, 0x7c
                 };
                    byte[] buffer4 = new byte[] { 
                    130, 0xb9, 0, 0, 60, 0xe0, 0, 0xd7, 0x3d, 0x80, 0, 0x92, 0x56, 0xa4, 0x38, 0x30, 
                    0x56, 0xbb, 0x18, 0x38
                 };
                    byte[] buffer5 = new byte[] { 
                    0x73, 0x65, 0x74, 0x20, 0x70, 0x61, 0x72, 0x74, 0x79, 0x5f, 0x68, 0x6f, 0x73, 0x74, 0x20, 0x31, 
                    0x3b, 0x6f, 110, 0x6c, 0x69, 110, 0x65, 0x67, 0x61, 0x6d, 0x65, 0x20, 0x31, 0x3b, 0x6f, 110, 
                    0x6c, 0x69, 110, 0x65, 0x67, 0x61, 0x6d, 0x65, 0x61, 110, 100, 0x68, 0x6f, 0x73, 0x74, 0x20, 
                    0x31, 0x3b, 0x6f, 110, 0x6c, 0x69, 110, 0x65, 0x75, 110, 0x72, 0x61, 110, 0x6b, 0x65, 100, 
                    0x67, 0x61, 0x6d, 0x65, 0x61, 110, 100, 0x68, 0x6f, 0x73, 0x74, 0x20, 0x30, 0x3b, 0x6d, 0x69, 
                    0x67, 0x72, 0x61, 0x74, 0x69, 0x6f, 110, 0x5f, 0x6d, 0x73, 0x67, 0x74, 0x69, 0x6d, 0x65, 0x6f, 
                    0x75, 0x74, 0x20, 0x30, 0x3b, 0x6d, 0x69, 0x67, 0x72, 0x61, 0x74, 0x69, 0x6f, 110, 0x5f, 0x74, 
                    0x69, 0x6d, 0x65, 0x42, 0x65, 0x74, 0x77, 0x65, 0x65, 110, 0x20, 0x39, 0x39, 0x39, 0x39, 0x39, 
                    0x39, 0x3b, 0x6d, 0x69, 0x67, 0x72, 0x61, 0x74, 0x69, 0x6f, 110, 80, 0x69, 110, 0x67, 0x54, 
                    0x69, 0x6d, 0x65, 0x20, 0x30, 0x3b, 0x70, 0x61, 0x72, 0x74, 0x79, 0x5f, 0x6d, 0x69, 110, 0x70, 
                    0x6c, 0x61, 0x79, 0x65, 0x72, 0x73, 0x20, 0x31, 0x3b, 0x70, 0x61, 0x72, 0x74, 0x79, 0x5f, 0x6d, 
                    0x61, 0x74, 0x63, 0x68, 0x65, 100, 80, 0x6c, 0x61, 0x79, 0x65, 0x72, 0x43, 0x6f, 0x75, 110, 
                    0x74, 0x20, 0x30, 0x3b, 0x70, 0x61, 0x72, 0x74, 0x79, 0x5f, 0x63, 0x6f, 110, 110, 0x65, 0x63, 
                    0x74, 0x54, 0x69, 0x6d, 0x65, 0x6f, 0x75, 0x74, 0x20, 0x31, 0x30, 0x30, 0x30, 0x3b, 0x70, 0x61, 
                    0x72, 0x74, 0x79, 0x5f, 0x63, 0x6f, 110, 110, 0x65, 0x63, 0x74, 0x54, 0x69, 0x6d, 0x65, 0x6f, 
                    0x75, 0x74, 0x20, 0x31, 0x22, 0
                 };
                    buffer = new byte[] { 0x41 };
                    byte[] buffer6 = buffer;
                    buffer = new byte[] { 0x40 };
                    byte[] buffer7 = buffer;
                    PS3.SetMemory(0x2005000, buffer5);
                    PS3.SetMemory(0x466298, buffer6);
                    PS3.SetMemory(0x4667b4, buffer3);
                    Thread.Sleep(15);
                    PS3.SetMemory(0x466298, buffer7);
                    PS3.SetMemory(0x4667b4, buffer4);
                    PS3.SetMemory(0x2005000, buffer2);
                    MessageBox.Show("Connected !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Not Connected !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Not Connected !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void monoFlat_Button2_Click(object sender, EventArgs e)
        {
            Cbuf_AddText(0, "set timescale 5");
            timer1.Start();
            RPC.Enable_RPC();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Cbuf_AddText(0, "xblive_privatematch 0");
            Cbuf_AddText(0, "xblive_rankedmatch 1");
            Cbuf_AddText(0, "onlinegame 1");
            Cbuf_AddText(0, "ai axis delete");
        }

        private void monoFlat_Button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Cbuf_AddText(0, "set timescale 1");
            RPC.Enable_RPC();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
