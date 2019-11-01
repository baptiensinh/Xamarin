using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIKit;
using Xamarin.Forms;

namespace btt3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private void PickerSelectedIndexChanged(object sender, EventArgs e)
        {
            var PageValue = new Label();
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;
            if (selectedIndex != -1)
            {
                PageValue.Text = (string)ThePicker.ItemsSource[ThePicker.SelectedIndex];

            }
        }
        private void DatePickerDateSelected(object sender,DateChangedEventArgs e)
        {
            var EventValue = new Label();
            var PageValue = new Label();
            EventValue.Text = e.NewDate.ToString();
            PageValue.Text = TheDatePicker.Date.ToString();

        }
        void TimePickerPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            var PageValue = new Label();
            if (e.PropertyName == TimePicker.TimeProperty.PropertyName)
            {
                PageValue.Text = TheTimePicker.Time.ToString();
            }
        }
        void StepperValueChanged(object sender, ValueChangedEventArgs e)
        {
            var EventValue = new Label();
            var PageValue = new Label();
            EventValue.Text = String.Format("Stepper value is {0:F1}",e.NewValue);
            PageValue.Text = TheStepper.Value.ToString();  
        }
        void SliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            var EventValue = new Label();
            var PageValue = new Label();
            EventValue.Text = String.Format("Slider value is {0:F1}",e.NewValue);
            PageValue.Text = TheSlider.Value.ToString();
        }
        void SwitchToggled(object sender, ToggledEventArgs e)
        {
            var EventValue = new Label();
            var PageValue = new Label();
            EventValue.Text = String.Format("Switch is now {0}", e.Value ? "On" : "Off");
            PageValue.Text = TheSwitch.IsToggled.ToString();
        }




    }

}

