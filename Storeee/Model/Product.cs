using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    public class Product : INotifyPropertyChanged
    {
        private double price;
        private string? name;
        public int Id { get; set; }
        public string? Name { get => name; set { name = value; RaisePropertyChanged(); } }
        public double Price { get => price; set { price = value; RaisePropertyChanged(); } }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void RaisePropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
