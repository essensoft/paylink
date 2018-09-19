namespace Essensoft.AspNetCore.Payment.QPay
{
    public class QPayOptions
    {
        public const string DefaultClientName = "Payment.QPay.Client";
        public const string CertificateClientName = "Payment.QPay.CertificateClient";

        /// <summary>
        /// 应用ID
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        public string MchId { get; set; }

        /// <summary>
        /// API秘钥
        /// </summary>
        public string Key { get; set; }
    }
}
