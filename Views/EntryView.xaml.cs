﻿using System;
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
using System.Windows.Shapes;
using OperationManagement_UI.ViewModel;

namespace OperationManagement_UI.Views
{
	/// <summary>
	/// Interaction logic for EntryView.xaml
	/// </summary>
	public partial class EntryView : Window
	{
		public EntryView()
		{
			InitializeComponent();
			DataContext = new JobCardEntryDetailsViewViewModel();
		}
	}
}