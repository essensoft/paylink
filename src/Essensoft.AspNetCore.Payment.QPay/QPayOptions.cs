namespace Essensoft.AspNetCore.Payment.QPay
{
    public class QPayOptions
    {
        /// <summary>
        /// 应用账号(公众账号ID)
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

        /// <summary>
        /// API证书文件 Base64字符串
        /// </summary>
        public string Certificate { get; set; }
    }
}
