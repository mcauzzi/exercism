using System;
using System.Diagnostics.CodeAnalysis;

public class BankAccount
{
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:ElementsMustBeDocumented", Justification = "Reviewed. Suppression is OK here.")]
    private decimal balance;

    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:ElementsMustBeDocumented", Justification = "Reviewed. Suppression is OK here.")]
    private bool isOpen;

    private readonly object sem = new object();

    public void Open()
    {
        Balance = 0;
        this.isOpen = true;
    }

    public void Close()
    {
        this.isOpen = false;
    }

    public decimal Balance
    {
        get
        {
            if (this.isOpen)
            {
                return this.balance;
            }
            else
            {
                throw new InvalidOperationException("Account Closed");
            }
        }

        private set => this.balance = value;
    }

    public void UpdateBalance(decimal change)
    {

        lock (sem)
        {
            if (this.isOpen)
            {
                this.Balance += change;
            }
            else
            {
                throw new InvalidOperationException("Account Closed");
            }
        }
    }
}
