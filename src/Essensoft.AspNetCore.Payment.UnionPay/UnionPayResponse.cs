namespace Essensoft.AspNetCore.Payment.UnionPay
{
    public abstract class UnionPayResponse : UnionPayObject
    {
        public string Body { get; set; }
    }
}
