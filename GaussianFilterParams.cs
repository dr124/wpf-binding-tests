using System.Collections.ObjectModel;

namespace testbinding
{
    public class GaussianFilterParams : FilterParams
    {
        private ObservableCollection<ObservableCollection<float>> _kernel;

        public GaussianFilterParams()
        {
            Kernel = new ObservableCollection<ObservableCollection<float>>
            {
                new ObservableCollection<float> {0, .2f, 0},
                new ObservableCollection<float> {.2f, .2f, .2f},
                new ObservableCollection<float> {0, .2f, 0}
            };
        }

        public ObservableCollection<ObservableCollection<float>> Kernel
        {
            get => _kernel;
            set
            {
                if (SetProperty(ref _kernel, value))
                {
                    //anything changes then update!!!
                    OnUpdate?.Invoke(this);
                    Kernel.CollectionChanged += (s, e) => OnUpdate?.Invoke(this);
                    foreach (var k in Kernel)
                        k.CollectionChanged += (s, e) => OnUpdate?.Invoke(this);
                }
            }
        }
    }
}