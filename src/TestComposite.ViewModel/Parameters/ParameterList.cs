using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestComposite.ViewModel.Parameters
{
    public class ParameterList : ViewModelBase, IParameter
    {
        private string _value;

        public string Name { get; private set; }

        public string Value
        {
            get { return _value; }
            set
            {
                _value = value;
                RaisePropertyChanged();
            }
        }

        public ObservableCollection<IParameter> SubParameters { get; set; }

        public ParameterList(string name, IEnumerable<IParameter> parameters = null)
        {
            this.Name = name;
            this.SubParameters = new ObservableCollection<IParameter>(parameters ?? new List<IParameter>());
        }
    }
}
