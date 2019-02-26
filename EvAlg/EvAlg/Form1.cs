using System;
using System.Timers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvAlg
{
    public partial class Form1 : Form
    {
        //TODO: move this into it's own class as a manager, should not be part of the form
        


        List<Investor> myInvestorList;
        public Form1()
        {
            InitializeComponent();
        }

        private void b_test_Click(object sender, EventArgs e)
        {
            //should this be a timer or should it just fire as soon as enough time has elapsed?
            //TODO: if performance suffers switch this to a standard for list.

        }

        private void runGen()
        {

        }
    }

    public class EvAlgManager
    {
        private int popSize = 1000;
        private int popSafe = 100;//amount to directly copy and breed
        private int popFail = 600;//amount that is removed before breeding
        private int popReserve = 0;//amount to spawn as new to keep the gene pool diverse
        private bool runFitness = false;
        List<Investor> myInvestorList;

        public EvAlgManager()
        {
            //populate the list
        }

        public void populate()
        {
            for(int i = myInvestorList.Count; i < popSize; i++)
            {
                myInvestorList.Add(new Investor());
            }
        }

        public void runGen()
        {
            foreach (Investor current in myInvestorList)
            {
                current.step();
            }
        }
    }

    public class Investor
    {
        //needs to have a formula, how much money it has available, and which stocks it currently has purchased
        //among those stocks purchased it should probably track purchase price and trade time.
        //if you trade the same stock within the same day more than three times within 2 weeks your account gets flagged for daytrading.
        //need to have none of them do this.
        //each of the investors only invest in a single stock while it seems like a good choice may prevent something.
        //start off that way?
        //TODO: fix that, worry about it later
        List<Trade> myTradeList;
        decimal funds;
        decimal currentWorth;//not sure if this is required, may need to be a function
        string formula;
        private decimal fitness;
        public decimal Fitness
        {
            get { return fitness; }
        }
        List<int> tracking;//need to figure out how to track data with a list or even if I want one.

        public Investor()
        {
            myTradeList = new List<Trade>();
        }


        /// <summary>
        /// use this to process one turns actions
        /// </summary>
        /// <returns>true if completed without issues</returns>
        public Boolean step()
        {
            return true;
        }

    }
    public class Trade
    {
        string Symbol;
        DateTime TradeTime;
        int Amount;
        decimal Cost;

        public Trade(string symbol, int amount, decimal cost)
        {
            TradeTime = DateTime.Now;
            Symbol = symbol;
            Amount = amount;
            Cost = cost;
        }
    }
}

/*
 * ok, what do I need to make this work
 * first I'm going to need a way to store the breeding pool
 * then I'm going to need the class for all of the population
 * then to make the population work I'm a little stumped.
 * 
 */
