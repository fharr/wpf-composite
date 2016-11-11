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
        public ObservableCollection<IParameter> Parameters { get; private set; }

        public TextParameter Text { get; set; }

        public ParameterList List { get; set; }

        public MainViewModel()
        {
            Text = new TextParameter("Test");

            List = new ParameterList("Test", new List<IParameter>
            {
                new TextParameter("Test 1"),
                new TextParameter("Test 2")
            });

            this.Parameters = new ObservableCollection<IParameter>();

            this.Parameters.Add(new TextParameter("Param 1"));
            this.Parameters.Add(new TextParameter("Param 2"));
            this.Parameters.Add(new ParameterList("Param 3", new List<IParameter>
            {
                new TextParameter("Param 3.1"),
                new TextParameter("Param 3.2"),
                new TextParameter("Param 3.3")
            }));
            this.Parameters.Add(new TextParameter("Param 4"));
            this.Parameters.Add(new TextParameter("Param 5"));
        }
    }
}
