using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ArrangementOpenQueryResultVO Data Structure.
    /// </summary>
    [Serializable]
    public class ArrangementOpenQueryResultVO : AlipayObject
    {
        /// <summary>
        /// 合约编号
        /// </summary>
        [JsonProperty("ar_no")]
        public string ArNo { get; set; }

        /// <summary>
        /// 合约状态  未生效：UN_INVALID  已取消：CANCEL  已生效：VALID  已失效：INVALID
        /// </summary>
        [JsonProperty("ar_status")]
        public string ArStatus { get; set; }

        /// <summary>
        /// JSON结构的扩展字段，备用字段
        /// </summary>
        [JsonProperty("ext_data")]
        public string ExtData { get; set; }

        /// <summary>
        /// 有效期截止时间
        /// </summary>
        [JsonProperty("invalid_date")]
        public string InvalidDate { get; set; }

        /// <summary>
        /// 签约时间
        /// </summary>
        [JsonProperty("sign_date")]
        public string SignDate { get; set; }

        /// <summary>
        /// 有效期起始时间
        /// </summary>
        [JsonProperty("valid_date")]
        public string ValidDate { get; set; }
    }
}
