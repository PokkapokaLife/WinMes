using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
// 以下を追加
using System.Windows.Interop;
using System.Runtime.InteropServices;

namespace WinMes
{
	/// <summary>
	/// MainWindow.xaml の相互作用ロジック
	/// </summary>
	public partial class MainWindow : Window
	{
		private static readonly int WM_USER = 0x0400;

		[DllImport("user32.dll")]
		public static extern IntPtr FindWindow(string lpClassName, String lpWindowName);
		
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

		[DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
		public static extern uint RegisterWindowMessage(string lpString);


		private uint _myMessage = RegisterWindowMessage("MyMsg");

		public MainWindow()
		{
			InitializeComponent();

			Loaded += (o, e) =>
			{
				var source = HwndSource.FromHwnd(new WindowInteropHelper(this).Handle);
				source.AddHook(new HwndSourceHook(WndProc));
			};
		}
		private IntPtr WndProc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
		{
			if (msg == WM_USER)
			{
				string timstr = DateTime.Now.ToLongTimeString();
				Console.WriteLine("Mouse Wheel : " + timstr);
			}
			else if (msg == _myMessage)
			{
				string timstr = DateTime.Now.ToLongTimeString();
				Console.WriteLine("Mouse Wheel : " + timstr);
			}
			return IntPtr.Zero;
		}

		private void B_send_Click(object sender, RoutedEventArgs e)
		{
			IntPtr win = FindWindow(null, "MainWindow");
			SendMessage(win, (int)WM_USER, IntPtr.Zero, IntPtr.Zero);
		}
	}
}
