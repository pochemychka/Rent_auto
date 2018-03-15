﻿using OOP.Model;
using OOP.View;
using OOP.ViewModel.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP.ViewModel
{
	public class AppViewModel : INotifyPropertyChanged
	{

		public AdminAuthorization adminLogin = new AdminAuthorization();
		public CarAction carAct = new CarAction();
		public ClientAction clientAct = new ClientAction();

		public CarAction CarAct
		{
			get => carAct;
			set
			{
				carAct = value;
				OnPropertyChanged();
			}
		}
		public ClientAction ClientAct
		{
			get => clientAct;
			set
			{
				clientAct = value;
				OnPropertyChanged();
			}
		}

		public string opa;
		public string Opa
		{
			get => opa;
			set
			{
				opa = value;
				OnPropertyChanged();
			}
		}

		private RelayCommand adminLoginCommand;

		#region RelayCommand
		public RelayCommand AdminLoginCommand
		{
			get => adminLoginCommand ?? (adminLoginCommand = new
				RelayCommand(obj =>
				{

				}));
		}
		#endregion

		public event PropertyChangedEventHandler PropertyChanged;
		public void OnPropertyChanged([CallerMemberName]string prop = "")
		{
			if (PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs(prop));
		}
	}
}