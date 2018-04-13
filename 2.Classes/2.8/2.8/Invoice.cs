namespace _2._8
{
    class Invoice
    {
        readonly int account;
        readonly string customer;
        readonly string provider;

        string article;
        int quantity;

        public Invoice(int account, string customer, string provider, string article, int quantity)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
            this.article = article;
            this.quantity = quantity;
        }
        
        public double GetCost(bool withNDS)
        {
            double cost = 0;
            const double nds = 0.14;
            const double costOfOneArticle = 3.75;

            cost = quantity * costOfOneArticle;

            if (!withNDS)
                return cost;
            else
                return cost * nds + cost;
        }
    }
}
