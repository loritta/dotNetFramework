using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataSourcesP1
{
    public partial class SimpleExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //Yes, No, Maybe, OK
                //Drop down list binding
                var answers = new string[] { "Yes", "No", "Maybe", "Ok" };

                //1-Source 2-Binding
                ddlQuestions.DataBinding += this.ddlQuestions_BindingEvent;
                ddlQuestions.DataSource = answers;
                ddlQuestions.DataBind();

                //List Box Binding: Array of towns, where each town has an ID and a name

                var towns = new[]
                {
                    new{ID=1, Name="Montreal"},
                    new{ID=2, Name="Toronto"},
                    new{ID=3, Name="Laval"},
                    new{ID=4, Name="Ottawa"},
                    new{ID=5, Name="Vancouver"},
                };

                //1-source 2-binding
                lbBinding.DataSource = towns;
                lbBinding.DataBind();


                //Bulleted list with links/urls

                var searchEngines = new[]
                {
                new{Name="Google", URL="http://www.google.com"},
                 new{Name="Bing!", URL="http://www.bing.com"},
                  new{Name="MSDN", URL="http://msdn.microsoft.com"},
                   new{Name="Yahoo", URL="http://www.yahoo.com"},
                   new{Name="DuckDuckGo", URL="http://www.DuckDuckGo.com"}
            };
                blBinding.DataSource = searchEngines;
                blBinding.DataBind();
            }
        }

        protected void ddlQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDeopDown.Text = "Your answer is: " +
                ddlQuestions.SelectedValue.ToString();
        }
        protected void ddlQuestions_BindingEvent(object sender, EventArgs e)
        {
            lblOptions.Text = "Your data is now binded";
        }

        protected void lbBinding_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblListBox.Text = "You have selected: " +
                lbBinding.SelectedItem.ToString() +
                " - ID # " + lbBinding.SelectedValue.ToString();
        }
    }
}