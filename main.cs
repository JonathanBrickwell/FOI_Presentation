using System;

namespace WebApplication
{
    public partial class _Default : App 
    {
        public _Default()
        {

        }

        protected void Button1_Click(object sender, EventArgs e) 
        {
            int aqty = 0;
            SQLConnection cn = new SQLConnection("data source = (local); initial catalog = Books; integratedSecurity = SSPI");
            SQLDataReader dr1;
            string s = "select quantity from bookdetail where bookname='" + TextBox3.Text + "'";
            SQLCommand cmd1 = new SQLCommand(s, cn);
            cn.Open();
            dr1 = cmd1.ExecuteReader();
            aqty = dr1.GetInt32(0);
            if(aqty == 0)
            {
                Response.Write("book is not in stock, please select another book");
            }
            else
            {
                Response.Write("book is issued");
            }
            dr1.Close();
            cn.Close();
        }

    }
}