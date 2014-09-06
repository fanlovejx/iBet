using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Windows.Controls.Ribbon;

namespace iBet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
        WebPaserWP w;
        public MainWindow()
        {
            InitializeComponent();

            w = new WebPaserWP(Urls.bong88);
            w.Show();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            //richTextBox1.Document.Blocks.Clear();
            //richTextBox1.Document.Blocks.Add(new Paragraph(new Run(w._web.Document.Window.Frames[2].Document.Body.InnerHtml)));
            WebPaserWP re = new WebPaserWP(w._web.Document.Window.Frames[2].Document.Body.InnerHtml);
            re.Show();
        }
    }
}
