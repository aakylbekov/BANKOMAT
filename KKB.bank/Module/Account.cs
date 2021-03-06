﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKB.bank.Module
{
    public class Account
    {
        public Account()
        {
            ListCards = new List<Cards>();
            //Balance = 0;
        }
        public DateTime CreateDate { get; set; }
        public DateTime CloseDate { get; set; }
        public string AccountName { get; set; }
        public double Balance { get; set; } = 0;
        public List<Cards> ListCards;
        void printCardInfo()
        {
            foreach (Cards item in ListCards)
            {
                string info = string.Format("{0}\t {{1}} - {{2}}", item.GetCardNumber(), item.CardType, item.ExpDate);
                Console.WriteLine(info);
            }
        }
    }
}
