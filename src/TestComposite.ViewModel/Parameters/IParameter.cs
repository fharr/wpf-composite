using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestComposite.ViewModel.Parameters
{
    public interface IParameter : INotifyPropertyChanged
    {
        string Name { get; }
        string Value { get; set; }
    }
}
