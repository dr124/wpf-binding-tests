using System;

namespace testbinding
{
    public abstract class FilterParams : ObservableObject
    {
        public Action<FilterParams> OnUpdate { get; set; }
    }
}