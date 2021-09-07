using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfWithMVVM.Command;
using WpfWithMVVM.Models;
using WpfWithMVVM.Repo;
using WpfWithMVVM.Views;

namespace WpfWithMVVM.ViewModels
{
   public class AppViewModel : BaseViewModel
    {

        public FakeRepo PrinterRepository { get; set; }
        public ObservableCollection<Printer> Printers { get; set; }

        private Printer _printer;
        public Printer Printer { get {return _printer; } set {
                _printer = value; 
                OnPropertyChanged(); 
            } }


        public RelayCommand ShowCommand { get; set; }
        public RelayCommand EditCommand { get; set; }

        public EditViewModel EditViewModel { get; set; }

        public AppViewModel()
        {
            Printer = new Printer
            {
                Model="Envy",
                Vendor="HP",
                Color="Aqua"
            };


            PrinterRepository = new FakeRepo();
            Printers = new ObservableCollection<Printer>(PrinterRepository.GetAll());


            ShowCommand = new RelayCommand((e) =>
              {
                  MessageBox.Show($"{Printer.Model} - {Printer.Vendor} ");
              },(c) => {
                  if (Printer.Color.Length < 10)
                  {
                      return true;
                  }
                  return false;
              });


            EditCommand = new RelayCommand(e =>
              {
                  var view = new EditView();
                  EditViewModel = new EditViewModel();
                  EditViewModel.EditPrinter = Printer;
                  EditViewModel.EditView = view;
                  view.DataContext = EditViewModel;
                  view.ShowDialog();
              });


        }


        
    }
}
