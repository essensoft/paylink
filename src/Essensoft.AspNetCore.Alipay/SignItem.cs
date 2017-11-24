namespace Essensoft.AspNetCore.Alipay
{
    public class SignItem
    {
        public string SignSourceDate { get; set; }
        public string Sign { get; set; }
        public override string ToString() => "{" + "Sign:" + Sign + ",SignSourceDate:" + SignSourceDate + "}";
    }
}
