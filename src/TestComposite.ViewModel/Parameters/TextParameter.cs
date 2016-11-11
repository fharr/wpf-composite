using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestComposite.ViewModel.Parameters
{
    public class TextParameter : ViewModelBase, IParameter
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

        public TextParameter(string name)
        {
            this.Name = name;
        }
    }

}
