namespace Essensoft.AspNetCore.Payment.Alipay
{
    /// <summary>
    /// 签名项目
    /// </summary>
    public class SignItem
    {
        public string SignSourceDate { get; set; }

        public string Sign { get; set; }

        public override string ToString()
        {
            return "{" + "Sign:" + Sign + ",SignSourceDate:" + SignSourceDate + "}";
        }
    }
}
