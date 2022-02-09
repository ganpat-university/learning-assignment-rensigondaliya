using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo9
{
    internal class PlatinumAccount :AccountState
    {
        public PlatinumAccount(AccountState state)
           : this(state.Balance, state.Account)
        {

        }

        public PlatinumAccount(double balance, BankAccount account)
        {
            base.balance = balance;
            base.Account = account;
            base.upperLimit = double.MaxValue;
            base.lowerLimit = 100000.00;
        }

        public override void Deposit(double amount)
        {
            base.balance += amount;
            changeState();
        }

        public override void Withdraw(double amount)
        {
            base.balance -= amount;
            changeState();
        }

        private void changeState()
        {
            if (base.balance < base.lowerLimit)
            {
                base.account.State = new GoldAccount(base.balance, account);
            }
        }
    }
}
