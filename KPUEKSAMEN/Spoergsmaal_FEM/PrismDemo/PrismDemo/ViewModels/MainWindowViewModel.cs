using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Controls;
using Prism.Commands;
using Prism.Mvvm;
using PrismDemo.Models;
using PrismDemo.Views;

namespace PrismDemo.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private Models.ICustomerStore _customerStore = null;

        public MainWindowViewModel(Models.ICustomerStore customerStore)
        {
            _customerStore = customerStore;
        }

        public ObservableCollection<string> Customers { get; private set; } =
            new ObservableCollection<string>();


        private string _selectedCustomer = null;
        public string SelectedCustomer
        {
            get => _selectedCustomer;
            set
            {
                if (SetProperty<string>(ref _selectedCustomer, value))
                {
                    Debug.WriteLine(_selectedCustomer ?? "no customer selected");
                }
            }
        }

        private DelegateCommand _commandLoad = null;
        public DelegateCommand CommandLoad =>
            _commandLoad ?? (_commandLoad = new DelegateCommand(CommandLoadExecute));

        private void CommandLoadExecute()
        {
            Customers.Clear();
            List<string> list = _customerStore.GetAll();
            foreach (string item in list)
                Customers.Add(item);
        }
    }
}
