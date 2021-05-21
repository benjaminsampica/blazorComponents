using Microsoft.AspNetCore.Components;
using System;

namespace WebUi.Components
{
    public partial class DateRangePicker : ComponentBase
    {
        private DateTime _startDate;
        [Parameter]
        public DateTime StartDate
        {
            get => _startDate;
            set
            {
                if (_startDate == value) return;
                _startDate = value;
                StartDateChanged.InvokeAsync(value);
            }
        }
        [Parameter] public EventCallback<DateTime> StartDateChanged { get; set; }

        private DateTime _endDate;
        [Parameter]
        public DateTime EndDate
        {
            get => _endDate;
            set
            {
                if (_endDate == value) return;
                _endDate = value;
                EndDateChanged.InvokeAsync(value);
            }
        }
        [Parameter] public EventCallback<DateTime> EndDateChanged { get; set; }

        [Parameter] public DateTime? Maximum { get; set; }
    }
}
