using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Specialized;

namespace RulesEngine
{
    public partial class Form1 : Form
    {
        public ListDictionary myRulesList;
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            myRulesList = new ListDictionary();

            myRulesList.Add("LongTerm",new LongTermDiscount());
            myRulesList.Add("BirthdayDiscount", new BirthdayDiscount());
            myRulesList.Add("LastPurchaseDiscount", new LastPurchaseDiscount());




        }

        private void button2_Click(object sender, EventArgs e)
        {
            customer mycust= new customer();
            float fTotalDiscount=0;

            foreach(DictionaryEntry de in myRulesList)
            {
                fTotalDiscount += ((IRules)de.Value).Run(mycust);
            }
            Console.WriteLine("Total Disc " + fTotalDiscount.ToString());
        }
    }
}
