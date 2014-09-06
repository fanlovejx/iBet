using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;

namespace iBet
{
    public partial class WebPaserWP : Form
    {
        Urls _url;
        public WebPaserWP(Urls _url)
        {
            InitializeComponent();
            this._url = _url;
            _web.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(DocumentCompleted);
            HideScriptErrors(_web, true);
            if (_url == Urls.bong88)
            {
                Login("TV7AF08ttt", "Qqqq1111", _web);
            }
        }


        public WebPaserWP(String innerHtml)
        {
            InitializeComponent();
            _web.DocumentText = innerHtml;
        }

        void DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
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
            if (_step == Steps.DoLogin)
            {
                if (_web.Url.ToString().Contains(@"bong88.com/main.aspx"))
                    _step = Steps.LoginSuccess;
                else
                    _step = Steps.LoginFail;
            }
        }

        public void HideScriptErrors(WebBrowser wb, bool Hide)
        {
            FieldInfo fiComWebBrowser = typeof(WebBrowser).GetField("_axIWebBrowser2", BindingFlags.Instance | BindingFlags.NonPublic);
            if (fiComWebBrowser == null) return;
            object objComWebBrowser = fiComWebBrowser.GetValue(wb);
            if (objComWebBrowser == null) return;
            objComWebBrowser.GetType().InvokeMember("Silent", BindingFlags.SetProperty, null, objComWebBrowser, new object[] { Hide });
        }

        public enum Steps
        {
            LoadLoginPage,
            DoLogin,
            LoginSuccess,
            LoginFail,
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
            _w.Document.InvokeScript("eval", new object[] { Script });
        }
    }
}
