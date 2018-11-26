using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RefundUnfreezeResult Data Structure.
    /// </summary>
    [Serializable]
    public class RefundUnfreezeResult : AlipayObject
    {
        /// <summary>
        /// 冻结单号
        /// </summary>
        [JsonProperty("freeze_no")]
        [XmlElement("freeze_no")]
        public string FreezeNo { get; set; }

        /// <summary>
        /// 解冻结果码
        /// </summary>
        [JsonProperty("result_code")]
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 解冻状态。S成功，F失败。
        /// </summary>
        [JsonProperty("status")]
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 解冻金额
        /// </summary>
        [JsonProperty("unfreeze_amount")]
        [XmlElement("unfreeze_amount")]
        public string UnfreezeAmount { get; set; }

        /// <summary>
        /// 解冻单号
        /// </summary>
        [JsonProperty("unfreeze_no")]
        [XmlElement("unfreeze_no")]
        public string UnfreezeNo { get; set; }

        /// <summary>
        /// 解冻时间
        /// </summary>
        [JsonProperty("unfreeze_time")]
        [XmlElement("unfreeze_time")]
        public string UnfreezeTime { get; set; }
    }
}
