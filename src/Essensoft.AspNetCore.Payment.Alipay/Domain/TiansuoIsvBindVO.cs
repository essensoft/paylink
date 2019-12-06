using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TiansuoIsvBindVO Data Structure.
    /// </summary>
    public class TiansuoIsvBindVO : AlipayObject
    {
        /// <summary>
        /// 间连商户入驻时填写的营业执照号
        /// </summary>
        [JsonPropertyName("business_license_no")]
        public string BusinessLicenseNo { get; set; }

        /// <summary>
        /// 服务商pid
        /// </summary>
        [JsonPropertyName("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 操作类型  bind 绑定  unbind 解绑
        /// </summary>
        [JsonPropertyName("operation")]
        public string Operation { get; set; }
    }
}
