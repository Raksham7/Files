using Files.App.Views;
using System.Collections.ObjectModel;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace Files.App.Helpers
{
    public class ItemsDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate ParentItems { get; set; }
        public DataTemplate CurrentItem { get; set; }

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            var itemsControl = ItemsControl.ItemsControlFromItemContainer(container);
            return itemsControl.IndexFromContainer(container) == (itemsControl.ItemsSource as ObservableCollection<PathBoxItem>).Count - 1 ? CurrentItem : ParentItems;
        }
    }
}