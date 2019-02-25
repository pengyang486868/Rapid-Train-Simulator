using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using RapidTrainSimulator.ControlTest.Annotations;
using RapidTrainSimulator.Graphics;
using RapidTrainSimulator.Graphics.MapEntities;

namespace RapidTrainSimulator.ControlTest
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : INotifyPropertyChanged
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            _stations=new List<Station>();
        }

        private string _inputText;
        public string InputText
        {
            get => _inputText; set
            {
                _inputText = value;
                OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private List<Station> _stations;
        private void ButtonInput_OnClick(object sender, RoutedEventArgs e)
        {
            // st 200 500 grwg
            if (_inputText.StartsWith("st"))
                _stations.Add(InputParser.ParseStation(_inputText, MainCanvas));
            InputText = null;
        }


    }
}
