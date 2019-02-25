using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using RapidTrainSimulator.Graphics;
using RapidTrainSimulator.Graphics.MapEntities;

namespace RapidTrainSimulator.ControlTest
{
    public class InputParser
    {
        public static Station ParseStation(string str, Canvas canvas)
        {
            var split = str.Split(' ');
            var top = int.Parse(split[1]);
            var left = int.Parse(split[2]);
            var name = split[3];
            var size = 20;
            var fill = new SolidColorBrush(Colors.Red);
            var id = Guid.NewGuid();

            var station = new Station
            {
                UniqueId = id,
                Top = top,
                Left = left,
                Name = name,
                Size = size,
                RelatedObject = new Ellipse
                {
                    Height = size,
                    Width = size,
                    Fill = fill,
                    ToolTip = new TextBlock() { Text = name + "\n" + id }
                }
            };

            Canvas.SetTop((UIElement)station.RelatedObject, top);
            Canvas.SetLeft((UIElement)station.RelatedObject, left);
            canvas.Children.Add((UIElement)station.RelatedObject);

            return station;
        }


    }
}
