using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using TestComposite.ViewModel.Parameters;

namespace TestComposite.Utils
{
    class ParameterTemplateSelector : DataTemplateSelector
    {
        public DataTemplate ParameterListTemplate { get; set; }
        public DataTemplate TextParameterTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item is TextParameter)
            {
                return this.TextParameterTemplate;
            }
            else if (item is ParameterList)
            {
                return this.ParameterListTemplate;
            }

            throw new Exception(String.Format("This parameter ({0}) is not handled in the application", item.GetType().Name));
        }

    }
}
