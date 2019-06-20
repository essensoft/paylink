using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserCharityCommonwealCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserCharityCommonwealCreateModel : AlipayObject
    {
        /// <summary>
        /// 业务时间；格式yyyy-MM-dd hh:mm:ss
        /// </summary>
        [JsonProperty("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 预留扩展信息，JSON格式；
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 业务数值，例如 捐赠金额，无业务数值传0；
        /// </summary>
        [JsonProperty("numerical")]
        public long Numerical { get; set; }

        /// <summary>
        /// 其他业务信息，JSON格式；
        /// </summary>
        [JsonProperty("original_data")]
        public string OriginalData { get; set; }

        /// <summary>
        /// 商户和支付宝交互时，用于代表支付宝分配给商户ID
        /// </summary>
        [JsonProperty("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 唯一ID，用于防重控制，同一个unique_id重复提交多次只处理一次
        /// </summary>
        [JsonProperty("unique_id")]
        public string UniqueId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
