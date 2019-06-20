using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserCharityRecordexistQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserCharityRecordexistQueryModel : AlipayObject
    {
        /// <summary>
        /// 公益的业务类型(缺省是所有类型)
        /// </summary>
        [JsonProperty("biz_type")]
        public long BizType { get; set; }

        /// <summary>
        /// 捐赠记录的结束时间（默认是查询当前自然年一年的记录）
        /// </summary>
        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 商户和支付宝交互时，用于代表支付宝分配给商户ID
        /// </summary>
        [JsonProperty("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 捐赠记录的开始时间（默认是查询当前自然年一年的记录）
        /// </summary>
        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
