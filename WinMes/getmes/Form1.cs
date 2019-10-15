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
        //COPYDATASTRUCT�\���� 
        public struct COPYDATASTRUCT
        {
			public IntPtr dwData;        //���M����32�r�b�g�l
			public uint cbData;    //lpData�̃o�C�g��
			public IntPtr lpData;   //���M����f�[�^�ւ̃|�C���^(0���\)
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
                    //���l�����M����ė���
                    txtInt1.Text = m.WParam.ToString();
                    txtInt2.Text = m.LParam.ToString(); 
                    break;
                case WM_COPYDATA:
					COPYDATASTRUCT cds = (COPYDATASTRUCT)Marshal.PtrToStructure(m.LParam, typeof(COPYDATASTRUCT));
					byte[] bytes = new byte[cds.cbData];
					Marshal.Copy(cds.lpData, bytes, 0, (int)cds.cbData);
					string msg = Encoding.Unicode.GetString(bytes);
					txtMessage.Text = msg;

					//���������M����ė���
					//COPYDATASTRUCT mystr = new COPYDATASTRUCT();
					//               Type mytype = mystr.GetType();
					//               mystr = (COPYDATASTRUCT)m.GetLParam(mytype);
					//txtMessage.Text = mystr.lpData;
					break;
            }
            base.WndProc(ref m);
        }
        //�e�L�X�g�{�b�N�X�̃N���A
        private void butCls_Click(object sender, EventArgs e)
        {
            txtMessage.Text = string.Empty;
            txtInt1.Text = string.Empty;
            txtInt2.Text = string.Empty;
        }
    }
}
