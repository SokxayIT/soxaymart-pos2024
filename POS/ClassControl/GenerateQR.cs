using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using QRCoder;
using System.IO;

public class GenerateQR
{
    public string mcid { get; set; } = "mch5edef3606f1e8";
    public string mcc { get; set; } = "5131";
    public string ccy { get; set; } = "418";
    public string country { get; set; } = "LA";
    public string province { get; set; } = "VTE";
    public string amount { get; set; } = "1";
    public string invoiceid { get; set; } = "123";
    public string transactionid { get; set; } = "1234567890";
    public string terminalid { get; set; } = "000001";
    public string store { get; set; } = "";
    public string GenNumberBCEL()
    {

        string[,] rawqr = new string[,]
        {
             { "00" , "01"},
             {"01" , "11"},
             {"33" , BuildQR(new string[,]{
                 {"00","BCEL"},
                 {"01","ONEPAY"},
                 {"02",mcid}
             }) },
             {"52" , mcc},
             {"53" , ccy},
             {"54" , amount},
             {"58" , country},
             {"60" , province},
             {"62" , BuildQR(new string[,]{
                 {"01",invoiceid},
                 {"03",store},
                 {"05",transactionid},
                 {"07",terminalid}
             }) }
        };
        return BuildQR(rawqr);
    }
    private string BuildQR(string[,] ra)
    {
        string str = "";
        int bound0 = ra.GetUpperBound(0);
        int bound1 = ra.GetUpperBound(1);
        for (int i = 0; i <= bound0; i++)
        {
            str += ra[i, 0].PadLeft(2, '0') + ra[i, 1].Length.ToString().PadLeft(2, '0') + ra[i, 1];
        }
        return str;
    }
    public Image QRImage_BCEL(string str)
    {
        Image img = null;
        QRCodeGenerator qr = new QRCodeGenerator();
        QRCodeData data = qr.CreateQrCode(str, QRCodeGenerator.ECCLevel.Q);
        QRCode code = new QRCode(data);
        img = code.GetGraphic(5);
        return img;
    }
    public byte[] ImageToByteArray(System.Drawing.Image imageIn)
    {
        using (MemoryStream ms = new MemoryStream())
        {
            try
            {
                imageIn.Save(ms, imageIn.RawFormat);
            }
            catch (Exception)
            {
            }

            return ms.ToArray();
        }
    }
}