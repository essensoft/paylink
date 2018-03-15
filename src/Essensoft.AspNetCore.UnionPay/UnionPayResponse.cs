namespace Essensoft.AspNetCore.UnionPay
{
    public abstract class UnionPayResponse : UnionPayObject
    {
        public string Body { get; set; }
    }
}
