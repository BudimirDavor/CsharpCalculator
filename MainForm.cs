
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
			double Var1, Var2, Var3=0;
			
			Var1 = Convert.ToDouble(textBox1.Text);
			Var2 = Convert.ToDouble(textBox2.Text);
			
			if (radioButton1.Checked==true)
			{
				Var3=Var1+Var2;
			}
			if (radioButton2.Checked==true)
			{
				Var3=Var1-Var2;
			}
			if (radioButton3.Checked==true)
			{
				Var3=Var1*Var2;
			}
			if (radioButton4.Checked==true)
			{
				Var3=Var1/Var2;
			}
			
			textBox3.Text = Var3.ToString();
		}
	}
}
