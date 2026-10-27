/*
 * Created by SharpDevelop.
 * User: CC2_PC09
 * Date: 26/10/2026
 * Time: 07:38 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace operaciones
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
		
		void Button1Click(object sender, EventArgs e)
		{
			label1.Text="*";
			double a=Convert.ToDouble(textBox1.Text)*Convert.ToDouble(textBox2.Text);
			label3.Text=Convert.ToString(a);
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			label1.Text="/";
			double a=Convert.ToDouble(textBox1.Text)/Convert.ToDouble(textBox2.Text);
			label3.Text=Convert.ToString(a);			
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			label1.Text="+";
			double a=Convert.ToDouble(textBox1.Text)+Convert.ToDouble(textBox2.Text);
			label3.Text=Convert.ToString(a);			
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			label1.Text="-";
			double a=Convert.ToDouble(textBox1.Text)-Convert.ToDouble(textBox2.Text);
			label3.Text=Convert.ToString(a);			
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			label1.Text="%";
			double a=Convert.ToDouble(textBox1.Text)%Convert.ToDouble(textBox2.Text);
			label3.Text=Convert.ToString(a);	
		}
	}
}
