using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul10_1302204090
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void calculate_Click(object sender, EventArgs e)
		{
			int num_1 = int.Parse(this.num_1.Text);
			int num_2 = int.Parse(this.num_2.Text);

			int pangkat = CariNilaiPangkatClass.CariNilaiPangkat(num_1, num_2);

			result.Text = $"Result: {pangkat}";
		}

	}
}
