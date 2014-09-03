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
using System.Windows.Shapes;
using System.Threading;

namespace iBet
{
    public enum Urls
    {
        bong88,
        sbo33 
    }
    public partial class WebPaser : Window
    {
        Urls _url;
        public WebPaser(Urls _url)
        {
            InitializeComponent();
            this._url = _url;
            _web.LoadCompleted += new System.Windows.Navigation.LoadCompletedEventHandler(_web_LoadCompleted);
            if (_url == Urls.bong88)
            {
                Login("TV7AF08ttt", "Qqqq1111", _web);
            }
        }

        void _web_LoadCompleted(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            if (_step == Steps.LoadLoginPage)
            {
                if (_url == Urls.bong88)
                {
                    InvokeScript("document.getElementById('txtID').value  = '" + _U + "'", _web);
                    InvokeScript("document.getElementById('txtPW').value  = '" + _P + "'", _web);
                    Thread.Sleep(200);
                    InvokeScript("callSubmit('','D')", _web);
                    _step = Steps.DoLogin;
                }
            }
        }

        public enum Steps
        {
            LoadLoginPage,
            DoLogin,
            LoadLogoutPage,
            LoadMainPage,
        }
        Steps _step;
        String _U, _P;
        public void Login(String U, String P, WebBrowser W)
        {
            _step = Steps.LoadLoginPage;
            _U = U;
            _P = P;
            if (_url == Urls.bong88)
            {
                W.Navigate(@"http://www.bong88.com/login888.aspx");
            }
        }

        void InvokeScript(String Script, WebBrowser _w)
        {
            _w.InvokeScript("eval", new object[] { Script });
        }

    }
}
