﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apoteka
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}


			private void btnLekovi_Click(object sender, EventArgs e)
			{
				Form2 Lekovi = new Form2();
				Lekovi.Show();
			}
		}
	}
