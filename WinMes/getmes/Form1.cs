using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace getmessagec
{
    public partial class FomGetMessage : Form
    {
        //COPYDATASTRUCT構造体 
        public struct COPYDATASTRUCT
        {
			public IntPtr dwData;        //送信する32ビット値
			public uint cbData;    //lpDataのバイト数
			public IntPtr lpData;   //送信するデータへのポインタ(0も可能)
		}
		public const int WM_COPYDATA = 0x4A;
        public const int WM_USER = 0x400;
        public FomGetMessage()
        {
            InitializeComponent();
        }
 
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_USER:
                    //数値が送信されて来た
                    txtInt1.Text = m.WParam.ToString();
                    txtInt2.Text = m.LParam.ToString(); 
                    break;
                case WM_COPYDATA:
					COPYDATASTRUCT cds = (COPYDATASTRUCT)Marshal.PtrToStructure(m.LParam, typeof(COPYDATASTRUCT));
					byte[] bytes = new byte[cds.cbData];
					Marshal.Copy(cds.lpData, bytes, 0, (int)cds.cbData);
					string msg = Encoding.Unicode.GetString(bytes);
					txtMessage.Text = msg;

					//文字が送信されて来た
					//COPYDATASTRUCT mystr = new COPYDATASTRUCT();
					//               Type mytype = mystr.GetType();
					//               mystr = (COPYDATASTRUCT)m.GetLParam(mytype);
					//txtMessage.Text = mystr.lpData;
					break;
            }
            base.WndProc(ref m);
        }
        //テキストボックスのクリア
        private void butCls_Click(object sender, EventArgs e)
        {
            txtMessage.Text = string.Empty;
            txtInt1.Text = string.Empty;
            txtInt2.Text = string.Empty;
        }
    }
}
