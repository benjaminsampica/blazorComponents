using Microsoft.AspNetCore.Components;

namespace WebUi.Components
{
    public partial class BoolSelectList : ComponentBase
    {
        private string? _selectedItem;
        [Parameter]
        public bool? SelectedItem
        {
            get => ParseValue(_selectedItem);
            set
            {
                if (ParseValue(_selectedItem) == value) return;
                _selectedItem = value switch
                {
                    true => "True",
                    false => "False",
                    _ => ""
                };
                SelectedItemChanged.InvokeAsync(value);
            }
        }

        [Parameter] public EventCallback<bool?> SelectedItemChanged { get; set; }

        private void OnSelectionChanged(ChangeEventArgs args)
        {
            var selectedValue = args.Value.ToString();

            SelectedItem = ParseValue(selectedValue);
        }

        private static bool? ParseValue(string selectedValue)
        {
            var conversionSucceeded = bool.TryParse(selectedValue, out var boolValue);

            return conversionSucceeded ? boolValue : null;
        }
    }
}
