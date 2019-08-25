using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TiansuoIsvBindVO Data Structure.
    /// </summary>
    [Serializable]
    public class TiansuoIsvBindVO : AlipayObject
    {
        /// <summary>
        /// 间连商户入驻时填写的营业执照号
        /// </summary>
        [JsonProperty("business_license_no")]
        public string BusinessLicenseNo { get; set; }

        /// <summary>
        /// 服务商pid
        /// </summary>
        [JsonProperty("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 操作类型  bind 绑定  unbind 解绑
        /// </summary>
        [JsonProperty("operation")]
        public string Operation { get; set; }
    }
}
