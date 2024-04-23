/*
# Name: Shelby Sash, Sidney Huschart, Caitlin Hutchins
# email: sashsk@mail.uc.edu, hutchicu@mail.uc.edu, huschash@mail.uc.edu
# Assignment Title: Final Project
# Due Date: April 23, 2024
# Course: IS 3050
# Semester/Year: Spring 2024
# Brief Description: Creates web forms for easy, medium, hard leet code problems and displays them when a button is clicked. 
# Citations: Reference our individual web forms for what we each cited 
# Anything else that's relevant: N/A
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group6_FinalProject
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnRedirect_Click(object sender, EventArgs e)
        {
            Response.Redirect("LeetCodeHard.aspx");
        }

        protected void btnRedirect2_Click(object sender, EventArgs e)
        {
            Response.Redirect("LeetCodeMedium.aspx");
        }
        protected void btnRedirect3_Click(object sender, EventArgs e)
        {
            Response.Redirect("LeetCodeEasy.aspx");
        }
    }
}