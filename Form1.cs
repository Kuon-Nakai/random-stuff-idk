using Microsoft.VisualBasic.Devices;
using System.Runtime.InteropServices;
using System.Text;

namespace SSPasteHelper
{
    public partial class Form1 : Form {

        [Flags()]
        public enum KeyModifiers
        {
            None = 0,
            Alt = 1,
            Ctrl = 2,
            Shift = 4,
            WindowsKey = 8
        }


        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, KeyModifiers fsModifiers, Keys vk);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            
        }

        private void button1_Click(object sender, EventArgs e) {
            html_txtbx.Clear();
            if(src_txtbx.Text.Length == 0)
            {
                //MessageBox.Show((string)Clipboard.GetText(TextDataFormat.Text));
                src_txtbx.AppendText((string)Clipboard.GetText(TextDataFormat.Text));
            }
            StringBuilder build = new StringBuilder();
            foreach(string s in src_txtbx.Lines) {
                build.Append("<p>");
                build.Append(s.Replace("    ", "&nbsp; &nbsp; ").Replace("<", "&lt; ").Replace(">", "&gt; "));
                build.Append("</p>\r\n");
                html_txtbx.AppendText(build.ToString());
                build.Clear();
            }
            Clipboard.SetText(html_txtbx.Text);
        }

        private void EmulateStart()
        {
            string str = "";
            foreach(char ch in src_txtbx.Text.ToCharArray())
            {
                if (ch == '\r') continue;
                if (ch == '\n') str = "{ENTER}";
                else if (ch == ' ') str = " ";
                else str = String.Format("{{{0}}}", ch);
                SendKeys.Send(str);
                //Thread.Sleep(1);
            }
        }

        private void emu_btn_Click(object sender, EventArgs e)
        {
            if (src_txtbx.Text.Length == 0)
            {
                //MessageBox.Show((string)Clipboard.GetText(TextDataFormat.Text));
                src_txtbx.AppendText((string)Clipboard.GetText(TextDataFormat.Text));
            }
            Thread.Sleep(5000);
            EmulateStart();
            MessageBox.Show("Emulation complete!", "SSPasteHelper", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            RegisterHotKey(Handle, 100, KeyModifiers.Ctrl, Keys.B);
            RegisterHotKey(Handle, 101, KeyModifiers.Alt,  Keys.B);
        }

        private void Form1_Leave(object sender, EventArgs e)
        {
            UnregisterHotKey(Handle, 100);
            UnregisterHotKey(Handle, 101);
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;
            if(m.Msg == WM_HOTKEY)
            {
                if(m.WParam.ToInt32() == 100)
                {
                    src_txtbx.Clear();
                    src_txtbx.AppendText(Clipboard.GetText(TextDataFormat.Text));
                    button1_Click(0,new EventArgs());
                }else if(m.WParam.ToInt32() == 101)
                {
                    src_txtbx.Clear();
                    src_txtbx.AppendText(Clipboard.GetText(TextDataFormat.Text));
                    EmulateStart();
                }
            }
            base.WndProc(ref m);
        }
    }
}