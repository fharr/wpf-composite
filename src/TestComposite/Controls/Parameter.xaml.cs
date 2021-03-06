﻿using System;
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
    /// Interaction logic for Parameter.xaml
    /// </summary>
    public partial class Parameter : UserControl
    {
        public Parameter()
        {
            InitializeComponent();
        }

        public object ViewModel
        {
            get { return (object)GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ViewModel.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ViewModelProperty =
            DependencyProperty.Register("ViewModel", typeof(object), typeof(Parameter), new PropertyMetadata(null));

    }
}
