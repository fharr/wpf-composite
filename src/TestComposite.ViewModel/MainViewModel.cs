using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestComposite.ViewModel.Parameters;

namespace TestComposite.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public IParameter Parameter { get; private set; }
      
        public MainViewModel()
        {
            var parameters = new ObservableCollection<IParameter>();

            parameters.Add(new TextParameter("Param 1"));
            parameters.Add(new TextParameter("Param 2"));
            parameters.Add(new ParameterList("Param 3", new List<IParameter>
            {
                new TextParameter("Param 3.1"),
                new TextParameter("Param 3.2"),
                new TextParameter("Param 3.3")
            }));
            parameters.Add(new TextParameter("Param 4"));
            parameters.Add(new TextParameter("Param 5"));

            this.Parameter = new ParameterList("Param", parameters);
        }
    }
}
