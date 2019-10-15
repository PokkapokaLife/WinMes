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

        //COPYDATASTRUCT�\���� 
        public struct COPYDATASTRUCT
        {
            public IntPtr dwData;        //���M����32�r�b�g�l
            public uint cbData;�@�@�@�@//lpData�̃o�C�g��
            public IntPtr lpData;�@�@ //���M����f�[�^�ւ̃|�C���^(0���\)
        }

        public FomSendMessage()
        {
            InitializeComponent();
        }

        //���M�{�^������
        private void butSend_Click(object sender, EventArgs e)
        {
            Int32 result = 0;

			//����̃E�B���h�E�n���h�����擾���܂�
			IntPtr hWnd = FindWindow(null, txtName.Text);
            if (hWnd == IntPtr.Zero)
            {
                //�n���h�����擾�ł��Ȃ�����
                MessageBox.Show("����Window�̃n���h�����擾�ł��܂���");
                return;
            }

            //�����񃁃b�Z�[�W�𑗐M���܂�
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

				//���M�f�[�^��Byte�z��Ɋi�[
				//byte[] bytearry = System.Text.Encoding.Default.GetBytes(txtMessage.Text);
				//            Int32 len = bytearry.Length;
				//            COPYDATASTRUCT cds;
				//            cds.dwData = 0;�@�@�@�@�@�@�@�@//�g�p���Ȃ�
				//            cds.lpData = txtMessage.Text;�@//�e�L�X�g�̃|�C���^�[���Z�b�g
				//            cds.cbData = len + 1;�@�@�@�@�@//�������Z�b�g
				//            //������𑗂�
				//            result = SendMessage(hWnd, WM_COPYDATA, 0, ref cds);
			}

            //���l���b�Z�[�W�𑗐M���܂�
            //if (txtInt1.Text != string.Empty && txtInt2.Text != string.Empty)
            //{
            //    Int32 int1 = 0;
            //    Int32 int2 = 0;
            //    try
            //    {
            //        //���l�ɐ������ϊ��o���邩�H
            //        int1 = int.Parse(txtInt1.Text);
            //        int2 = int.Parse(txtInt2.Text);
            //    }
            //    catch
            //    {
            //        MessageBox.Show("���͂��ꂽ���l���������L��܂���");
            //        return;
            //    }
            //    //���l�𑗂�
            //    result = SendMessage(hWnd, (int)_myMessage, int1, int2);
            //}
        }
    }
}