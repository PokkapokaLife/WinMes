using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace sendmessagec
{
    public partial class FomSendMessage : Form
    {
        [DllImport("User32.dll", EntryPoint = "FindWindow")]
		private extern static IntPtr FindWindow(string lpClassName, string lpWindowName);

		[DllImport("User32.dll", EntryPoint = "SendMessage")]
		private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

		[DllImport("User32.dll", EntryPoint = "SendMessage")]
        public static extern Int32 SendMessage(Int32 hWnd, Int32 Msg, Int32 wParam, Int32 lParam);

		[DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
		public static extern uint RegisterWindowMessage(string lpString);

		private uint _myMessage = RegisterWindowMessage("MyMsg");

		public const Int32 WM_COPYDATA = 0x4A;
        public const Int32 WM_USER = 0x400;

        //COPYDATASTRUCT構造体 
        public struct COPYDATASTRUCT
        {
            public IntPtr dwData;        //送信する32ビット値
            public uint cbData;　　　　//lpDataのバイト数
            public IntPtr lpData;　　 //送信するデータへのポインタ(0も可能)
        }

        public FomSendMessage()
        {
            InitializeComponent();
        }

        //送信ボタン押下
        private void butSend_Click(object sender, EventArgs e)
        {
            Int32 result = 0;

			//相手のウィンドウハンドルを取得します
			IntPtr hWnd = FindWindow(null, txtName.Text);
            if (hWnd == IntPtr.Zero)
            {
                //ハンドルが取得できなかった
                MessageBox.Show("相手Windowのハンドルが取得できません");
                return;
            }

            //文字列メッセージを送信します
            if (txtMessage.Text != string.Empty)
            {
				string s = txtMessage.Text;

				COPYDATASTRUCT cds;
				cds.dwData = IntPtr.Zero;
				cds.lpData = Marshal.StringToHGlobalUni(s);
				cds.cbData = (uint)((s.Length + 1) * 2);

				IntPtr pnt = Marshal.AllocHGlobal(Marshal.SizeOf(cds));
				Marshal.StructureToPtr(cds, pnt, false);

				SendMessage(hWnd, WM_COPYDATA, IntPtr.Zero, pnt);

				//送信データをByte配列に格納
				//byte[] bytearry = System.Text.Encoding.Default.GetBytes(txtMessage.Text);
				//            Int32 len = bytearry.Length;
				//            COPYDATASTRUCT cds;
				//            cds.dwData = 0;　　　　　　　　//使用しない
				//            cds.lpData = txtMessage.Text;　//テキストのポインターをセット
				//            cds.cbData = len + 1;　　　　　//長さをセット
				//            //文字列を送る
				//            result = SendMessage(hWnd, WM_COPYDATA, 0, ref cds);
			}

            //数値メッセージを送信します
            //if (txtInt1.Text != string.Empty && txtInt2.Text != string.Empty)
            //{
            //    Int32 int1 = 0;
            //    Int32 int2 = 0;
            //    try
            //    {
            //        //数値に正しく変換出来るか？
            //        int1 = int.Parse(txtInt1.Text);
            //        int2 = int.Parse(txtInt2.Text);
            //    }
            //    catch
            //    {
            //        MessageBox.Show("入力された数値が正しく有りません");
            //        return;
            //    }
            //    //数値を送る
            //    result = SendMessage(hWnd, (int)_myMessage, int1, int2);
            //}
        }
    }
}