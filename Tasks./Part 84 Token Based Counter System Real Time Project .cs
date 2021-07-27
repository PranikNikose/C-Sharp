using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Token_Counter_Project
{
    public partial class TokenCounterWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["TokenQueue"] == null)
            {
                Queue<int> queueToken = new Queue<int>();
                Session["TokenQueue"] = queueToken;
            }
        }

        protected void btnprintToken_Click(object sender, EventArgs e)
        {
            Queue<int> TokenQueue = (Queue<int>)Session["TokenQueue"];
            lblStatus.Text = "There are " + TokenQueue.Count.ToString() + " People in the queue";

            if (Session["LastTokenNoIssued"] == null)
            {
                Session["LastTokenNoIssued"] = 0;
            }

            int NextTokenNoIssued = (int)Session["LastTokenNoIssued"] + 1;
            Session["LastTokenNoIssued"] = NextTokenNoIssued;
            TokenQueue.Enqueue(NextTokenNoIssued);

            AddItemsToList(TokenQueue);

        }

        private void AddItemsToList(Queue<int> TokenQueue)
        {
            listOfTokens.Items.Clear();
            foreach (int k in TokenQueue)
            {
                listOfTokens.Items.Add(k.ToString());
            }
        }

        private void ServeTokens(TextBox TextboxNumber, int Counter)
        {
            Queue<int> TokenQueue = (Queue<int>)Session["TokenQueue"];
            
            if (TokenQueue.Count == 0)
            {
                TextboxNumber.Text = "Queue Ended";
                
            }
            else
            {
                int TokenServed = TokenQueue.Dequeue();
                TextboxNumber.Text = TokenServed.ToString();
                txtboxDisplay.Text = "Token Number: " + TokenServed.ToString() + " Please Go To Counter Number " + Counter.ToString();
                if (TokenQueue.Count - 1<0)
                {
                    lblStatus.Text = "There is no customers in queue";
                }
                else if (TokenQueue.Count - 1 == 0)
                {
                    lblStatus.Text = "Next Token Number is Yours";
                }
                else 
                { 
                    lblStatus.Text = "There are " + (TokenQueue.Count-1).ToString() + " People in the queue";
                }
                AddItemsToList(TokenQueue);
            }
            
        }

        protected void btnCounter1_Click(object sender, EventArgs e)
        {
            ServeTokens(txtboxCounter1, 1);

        }
        protected void btnCounter2_Click(object sender, EventArgs e)
        {
            ServeTokens(txtboxCounter2, 2);
        }

        protected void btnCounter3_Click(object sender, EventArgs e)
        {
            ServeTokens(txtboxCounter3, 3);
        }

        protected void txtboxCounter1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
