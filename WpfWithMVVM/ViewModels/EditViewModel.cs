using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfWithMVVM.Command;
using WpfWithMVVM.Models;
using WpfWithMVVM.Views;

namespace WpfWithMVVM.ViewModels
{
   public class EditViewModel:BaseViewModel
    {
        public EditView EditView { get; set; }
        private Printer _printer;

        public Printer EditPrinter
        {
            get { return _printer; }
            set { _printer = value;OnPropertyChanged(); }
        }

        public RelayCommand SaveCommand { get; set; }



        public EditViewModel()
        {
            SaveCommand = new RelayCommand((e) =>
              {

                  EditView.Close();
                  MessageBox.Show("Saved data successfully");
              });
        }


    }
}
