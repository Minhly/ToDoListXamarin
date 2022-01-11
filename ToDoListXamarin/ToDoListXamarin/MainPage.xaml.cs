using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ToDoListXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void HandleTextChanged(object sender, TextChangedEventArgs args)
        {
            Console.WriteLine(args.NewTextValue);
        }

        public void HandleEnterPress(object sender, EventArgs args)
        {
            Console.WriteLine("Enter Pressed");
            Label newToDo = new Label();
            newToDo.Text = InputField.Text;
            newToDo.FontSize = 20;
            ToDoList.Children.Add(newToDo);
            InputField.Text = "";
        }
    }
}
