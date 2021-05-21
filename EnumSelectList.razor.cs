using Microsoft.AspNetCore.Components;
using System;

namespace WebUi.Components
{
    public partial class EnumSelectList<T> : ComponentBase where T : struct, Enum
    {
        private T? _selectedItem;
        [Parameter]
        public T? SelectedItem
        {
            get => _selectedItem;
            set
            {
                if (_selectedItem.Equals(value)) return;
                _selectedItem = value;
                SelectedItemChanged.InvokeAsync(value);
            }
        }

        [Parameter] public EventCallback<T?> SelectedItemChanged { get; set; }
    }
}
