namespace testbinding
{
    public class MainViewModel : ObservableObject
    {
        private FilterParams _filterParams;

        public MainViewModel()
        {
            FilterParams = new GaussianFilterParams();
            //((GaussianFilterParams) FilterParams).Kernel[2][2] = 10;  //<- this works and goes to ProcessFilter(..)
        }

        public FilterParams FilterParams
        {
            get => _filterParams;
            set
            {
                if (SetProperty(ref _filterParams, value))
                    _filterParams.OnUpdate = ProcessFilter;
            }
        }

        private void ProcessFilter(FilterParams obj)
        {
            // SHOUT FIRE THIS METHOD!!!!
        }
    }
}