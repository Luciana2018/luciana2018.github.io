using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;



public partial class _Default : System.Web.UI.Page
{
    private string textarea;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SendMail()
    {
        // mail Address from where you send the mail
        //var fromAddress = "Lucysilver39@outlook.com";
        var fromAddress = "Lucysilver39@gmail.com";
        // any address where the email will be sending
        //var toAddress = "Lucysilver39@outlook.com";
        var toAddress = "Lucysilver39@gmail.com";
        //var toAddress = YourEmail.Text.ToString();
        //Password of your gmail address
        const string fromPassword = "Lucy654321";
        // Passing the values and make a email formate to display
        string subject = "MAJESTIC  - " + typeservice.Text.ToString();
        string body = customer.Text + " - " + city.Text + "\n";
        //body += "Email: " + YourEmail.Text + "\n";
        body += " SERVICE SCOPE: \n" + comments.Text.ToString() + "\n\n";
        body += "Payment Detail:  " + payment.Text + ".\n";
        body += "Total Payment: \n" + "U$" + total.Text + "\n";
        
        // smtp settings
        var smtp = new System.Net.Mail.SmtpClient();
        {
            smtp.Host = "smtp.gmail.com";
            //smtp.Host = " smtp-mail.outlook.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(fromAddress, fromPassword);
            smtp.Timeout = 20000;
            
        }
        // Passing values to smtp object
        smtp.Send(fromAddress, toAddress, subject, body);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            //here on button click what will done 
            SendMail();
            //DisplayMessage.Text = "Your Comments after sending the mail";
            //DisplayMessage.Visible = true;
            customer.Text = "";
            city.Text = "";
            typeservice.Text = "";
            comments.Text = "";
            total.Text = "";
            payment.Text = "";
        }
        catch (Exception ex) 
        {
            ex.Message.ToString();
        }

    }
}
