/*
 * Created by SharpDevelop.
 * User: Davor
 * Date: 3.10.2019.
 * Time: 16:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DemoApi
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
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void OKbtnClick(object sender, EventArgs e)
		{
			if (radioButton1.Checked==true)
			{
				textBox2.Text=textBox1.Text;
				textBox1.Text="";
			}
		}
	}
}
