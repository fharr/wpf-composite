using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestComposite.Controls
{
    /// <summary>
    /// Interaction logic for ParameterListControl.xaml
    /// </summary>
    public partial class ParameterListControl : UserControl
    {
        #region param name

        public string ParamName
        {
            get { return (string)GetValue(ParamNameProperty); }
            set { SetValue(ParamNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ParamName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ParamNameProperty =
            DependencyProperty.Register("ParamName", typeof(string), typeof(ParameterListControl), new PropertyMetadata(String.Empty));

        #endregion

        #region items

        public IEnumerable Items
        {
            get { return (IEnumerable)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        public static readonly DependencyProperty ItemsProperty =
            DependencyProperty.Register("Items", typeof(IEnumerable), typeof(ParameterListControl), new PropertyMetadata(new List<object>()));

        #endregion

        public ParameterListControl()
        {
            InitializeComponent();
        }
    }
}
