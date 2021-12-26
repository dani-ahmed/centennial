using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseCalculator
{
    class Budget : IBudget
    {
        public string ReqID { get; set; }
        public string Interval { get; set; }
        public double Income { get; set; }
        public double Food { get; set; }
        public double Recreation { get; set; }
        public double Travel { get; set; }
        public double Bills { get; set; }
        public double TotalExpenses { get; set; }
        public double Balance { get; set; }
        

        public void CreateBudget(string interval, string income, string food, string rec, string travel, string bills)
        {
            this.ReqID = Guid.NewGuid().ToString();

            this.Interval = interval;
            this.Income = Convert.ToDouble(income);
            this.Food = Convert.ToDouble(food);
            this.Recreation = Convert.ToDouble(rec);
            this.Travel = Convert.ToDouble(travel);
            this.Bills = Convert.ToDouble(bills);

            double expenses = Convert.ToDouble(food) + Convert.ToDouble(rec) + Convert.ToDouble(travel) + Convert.ToDouble(bills);
            this.TotalExpenses = expenses;

            this.Balance = Convert.ToDouble(income) - Convert.ToDouble(expenses);
        }



        public double AnnualCash()
        {
            int i = 0;

            if (this.Interval == "MONTHLY")
            {
                i = 12;
            }
            else if (this.Interval == "WEEKLY")
            {
                i = 52;
            }
            else if (this.Interval == "BIWEEKLY")
            {
                i = 26;
            }
            else if (this.Interval == "YEARLY")
            {
                i = 1;
            }

            return this.Balance * i;
        }

        public override string ToString()
        {
            return $"Your income is {this.Income}\n" +
                $"Your total expenses are{String.Format("{0:C}", this.Food + this.Recreation + this.Travel + this.Bills + this.Balance)}\n" +
                $"Your Cash for this interval is {String.Format("{0:C}", this.Balance)}\n";
            

        }
            
        
    }
}
