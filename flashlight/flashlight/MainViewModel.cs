using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace flashlight
{
    public class MainViewModel
    {
        public ICommand LightOnCommand { get; }
        public ICommand LightOffCommand { get; }
        public MainViewModel()
        {
            LightOnCommand = new Command(LightOn);
            LightOffCommand = new Command(LightOff);
        }
        public bool LightStatus { get; set; } = false;
        async void LightOn()
        {
            await Flashlight.TurnOnAsync();
        }
        async void LightOff()
        {
            await Flashlight.TurnOffAsync();
        }
    }
}
