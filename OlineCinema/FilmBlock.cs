using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace OlineCinema
{
    class FilmBlock
    {
        public Border MainBorder { get; set; }
        public Border ImageBorder { get; set; }
        public Border LabelBorder { get; set; }
        public Grid MainGrid { get; set; }
        public Label FilmName { get; set; }
        public Image FilmImage { get; set; }

        public FilmBlock()
        {
            MainBorder = new Border();
            ImageBorder = new Border();
            LabelBorder = new Border();
            MainGrid = new Grid();
            FilmName = new Label();
            FilmImage = new Image();
        }

        public void CreateBlock()
        {
            MainBorder.Width = 190;
            MainBorder.Height = 250;
            MainBorder.Child = MainGrid;
            /*RowDefinitionCollection rdc = new RowDefinitionCollection();
            rdc.Add(new RowDefinition());
            rdc.Add();
            rdc[0].Height = new GridLength(49);
            rdc[1].Height = new GridLength(49);*/
        }
    }
}
