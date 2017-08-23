using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilmark_winform
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();

            comboMethod.Items.AddRange(Enum.GetNames(typeof(RestSharp.Method)));
            comboMethod.SelectedIndex = 0;
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSendReq_Click(object sender, EventArgs e)
        {
            RestSharp.RestClient restClient = new RestSharp.RestClient(textBaseUrl.Text);
            var req = new RestSharp.RestRequest(textResource.Text, GetRequestMethod());
            req.AddHeader("Authorization", "BEARER " + textToken.Text);
            restClient.ExecuteAsync(req, (r, h) =>
            {
                textResponse.BeginInvoke(new Action(() =>
                {
                    textResponse.Text = r.Content;
                }));

            });
        }

        private RestSharp.Method GetRequestMethod()
        {
            RestSharp.Method method;
            if (Enum.TryParse((string)comboMethod.SelectedItem, out method))
                return method;
            else
                throw new InvalidEnumArgumentException();
        }

        private void buttonGetToken_Click(object sender, EventArgs e)
        {
            RestSharp.RestClient restClient = new RestSharp.RestClient(textBaseUrl.Text);
            var req = new RestSharp.RestRequest("/token", RestSharp.Method.POST);
            req.AddParameter("username", textUsername.Text);
            req.AddParameter("password", textPassword.Text);
            restClient.ExecuteAsync(req, (r, h) =>
            {
                textResponse.BeginInvoke(new Action(() =>
                {
                    if (r.Content.ToLower().Contains("token"))
                    {
                        var settings = new Jose.JwtSettings();

                        dynamic token = JsonConvert.DeserializeObject(r.Content);
                        string _token = token.token;
                        
                    }

                    textGeneratedToken.Text = r.Content;
                }));
            });
        }
    }
}
