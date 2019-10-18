using System;
using Xamarin.Forms;

namespace GroupList
{
    public class ListaTemplateSelect : DataTemplateSelector
    {
        private DataTemplate _templateEmail;
        private DataTemplate _templateTelefone;
        public ListaTemplateSelect()
        {
            _templateEmail = new DataTemplate(typeof(ViewCellEmail));
            _templateTelefone = new DataTemplate(typeof(ViewCellTelefone));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item is Email)
            {
                return _templateEmail;
            }
            else
            {
                return _templateTelefone;
            }
        }
    }
}
