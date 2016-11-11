using System;
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
    /// Interaction logic for TextParameterControl.xaml
    /// </summary>
    public partial class TextParameterControl : UserControl
    {
        #region param name

        public string ParamName
        {
            get { return (string)GetValue(ParamNameProperty); }
            set { SetValue(ParamNameProperty, value); }
        }

        public static readonly DependencyProperty ParamNameProperty =
            DependencyProperty.Register("ParamName", typeof(string), typeof(TextParameterControl), new PropertyMetadata(String.Empty));

        #endregion

        #region value

        public string Value
        {
            get { return (string)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(string), typeof(TextParameterControl), new PropertyMetadata(String.Empty));

        #endregion

        public TextParameterControl()
        {
            InitializeComponent();
        }

    }
}
