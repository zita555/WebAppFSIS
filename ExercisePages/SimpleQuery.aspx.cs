
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using FSISSystem.BLL;
using FSISSystem.ENTITIES;


namespace WebApp.ExercisePages

{
    public partial class SimpleQuery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MessageLabel.Text = "";
        }

        protected void Fetch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PlayerIDArg.Text))
            {
                MessageLabel.Text = "Enter a Player id value.";
            }
            else
            {
                int PlayerID = 0;
                if (int.TryParse(PlayerIDArg.Text, out PlayerID))
                {
                    if (PlayerID > 0)
                    {
                        PlayerController sysmgr = new PlayerController();
                        Player info = null;
                        info = sysmgr.Players_FindByID(PlayerID); //BLL controller method
                        if (info == null)
                        {
                            MessageLabel.Text = "Player ID not found.";
                            PlayerID.Text = "";
                            AlbertaHealthCareNumber.Text = "";
                        }
                        else
                        {
                            PlayerID.Text = info.PlayerID.ToString();
                            AlbertaHealthCareNumber.Text = info.AlbertaHealthCareNumber;
                        }
                    }
                    else
                    {
                        MessageLabel.Text = "Player id must be greater than 0";
                    }

                }
                else
                {
                    MessageLabel.Text = "Player id must be a number.";
                }
            }
        }
    }
}