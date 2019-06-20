using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BizResData Data Structure.
    /// </summary>
    [Serializable]
    public class BizResData : AlipayObject
    {
        /// <summary>
        /// 支用金额
        /// </summary>
        [JsonProperty("biz_amount")]
        public long BizAmount { get; set; }

        /// <summary>
        /// 支用日期
        /// </summary>
        [JsonProperty("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 业务借据号
        /// </summary>
        [JsonProperty("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 业务消费者唯一标志
        /// </summary>
        [JsonProperty("biz_user_id")]
        public string BizUserId { get; set; }
    }
}
