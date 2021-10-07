using System;
namespace s6cpo
{
    public class Compte
    {
        private double _solde;
        public double Solde { get{return _solde;}}
        private double _code { get;}
        private static int numberCode = 0;
        public Compte()
        {
            this._solde = 0;
            numberCode += 1;
            this._code = numberCode;
        }
        public Compte(double solde)
        {
            this._solde = solde;
            numberCode += 1;
            this._code = numberCode;
        }

        public virtual void AddCash(double amount)
        {
            this._solde += amount;
        }
        public virtual void SubtractCash(double amount)
        {
            this._solde -= amount;
        }

        public override string ToString()
        {
            return $"{this._solde}";
        }
    }

    public class CompteEpargne : Compte
    {
        private int interestValue { get; set; }
        public CompteEpargne() : base()
        {
            this.interestValue = 6;
        }
        public CompteEpargne(double solde) : base(solde)
        {
            this.interestValue = 6;
        }
        public void InterestCalcul()
        {
            base.AddCash(this.Solde*this.interestValue/100); 
        }
    }

    public class ComptePayant : Compte
    {
        public ComptePayant() : base() {}
        public ComptePayant(double amount) : base(amount) {}

        public override void AddCash(double amount)
        {
            //this._solde += amount - 5;
            base.AddCash(amount);
            base.SubtractCash(5);
        }

        public override void SubtractCash(double amount)
        {
            //this._solde -= amount - 5; 
            base.SubtractCash(amount + 5);

        }
    }
}