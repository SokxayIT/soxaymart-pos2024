using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using POS.ClassControl;

namespace POS
{
    public partial class FrmConfirmPayment : Form
    {
        public FrmConfirmPayment()
        {
            InitializeComponent();
        }
        public PaymentRequest pay = new PaymentRequest();
        public APIRespone res = new APIRespone();
        HttpClient http = new HttpClient();
        public bool Conf = false;
        private void btnOk_Click(object sender, EventArgs e)
        {
            res = new APIRespone();
            Task.Run(() =>
            {
                if (pic_loading.InvokeRequired)
                {
                    pic_loading.Invoke(new MethodInvoker(delegate
                    {
                        pic_loading.Visible = true;
                        pic_loading.BringToFront();
                    }));
                }
            });
            Task.Run(() =>
            {
                Thread.Sleep(500);
                var obj = http.PostAsJsonAsync("https://apipayment.sokxaycard.com/api/Statement/PaymentStatus", pay).Result;
                res = obj.Content.ReadAsAsync<APIRespone>().Result;
                if (res.resultCode == "OK")
                {
                    Thread.Sleep(1000);
                    if (pic_complete.InvokeRequired)
                    {
                        pic_complete.Invoke(new MethodInvoker(delegate
                        {
                            pic_complete.Visible = true;
                            pic_complete.BringToFront();
                        }));
                    }
                    Thread.Sleep(1000);
                    if (this.InvokeRequired)
                    {
                        this.Invoke(new MethodInvoker(delegate
                        {
                            Conf = true;
                            this.Close();
                        }));
                    }

                }
                else if (res.resultMessage == "Error")
                {
                    Thread.Sleep(1000);
                    if (pic_error.InvokeRequired)
                    {
                        pic_error.Invoke(new MethodInvoker(delegate
                        {
                            pic_error.Visible = true;
                            pic_error.BringToFront();
                        }));
                    }
                    if (lbmessage.InvokeRequired)
                    {
                        lbmessage.Invoke(new MethodInvoker(delegate
                        {
                            lbmessage.Text = res.resultMessage;
                        }));
                    }
                }
            });

            //Task.Run(() =>
            //{
            //    Thread.Sleep(3000);
            //    if (pic_complete.InvokeRequired)
            //    {
            //        pic_complete.Invoke(new MethodInvoker(delegate {
            //            pic_complete.Visible = true;
            //            pic_complete.BringToFront();
            //        }));
            //    }
            //});
            //Task.Run(() =>
            //{
            //    Thread.Sleep(6000);
            //    if (pic_error.InvokeRequired)
            //    {
            //        pic_error.Invoke(new MethodInvoker(delegate {
            //            pic_error.Visible = true;
            //            pic_error.BringToFront();
            //        }));
            //    }
            //});

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Conf = false;
            this.Close();
        }
    }
}
