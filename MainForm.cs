/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 6/6/2024
 * Time: 2:17 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace bitwiseopPGr
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TO DO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		public int sumacifrelor(int pa)
		{
			int pb = pa;
			int counter = 0;
			while(pb>0)
			{
				counter += pb%10;
				pb = pb/10;
			}
			return counter;
		}
		int a = 2;
		void Button1Click(object sender, EventArgs e)
		{
			a=a<<1;
			textBox1.Text+="\r\n"+ a.ToString() + " : " + sumacifrelor(a).ToString();
		}
		/*
		 
4 : 4
8 : 8
16 : 7
32 : 5
64 : 10
128 : 11
256 : 13
512 : 8
1024 : 7
2048 : 14
4096 : 19
8192 : 20
16384 : 22
32768 : 26
65536 : 25
131072 : 14
262144 : 19
524288 : 29
1048576 : 31
2097152 : 26
4194304 : 25
8388608 : 41
16777216 : 37
33554432 : 29
67108864 : 40
134217728 : 35
268435456 : 43
536870912 : 41
		 */
	}
}
