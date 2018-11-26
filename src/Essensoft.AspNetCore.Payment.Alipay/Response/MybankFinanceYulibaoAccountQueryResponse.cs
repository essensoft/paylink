using System.Xml.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankFinanceYulibaoAccountQueryResponse.
    /// </summary>
    public class MybankFinanceYulibaoAccountQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 可用份额，单位为元
        /// </summary>
        [JsonProperty("available_amount")]
        [XmlElement("available_amount")]
        public string AvailableAmount { get; set; }

        /// <summary>
        /// 业务冻结份额，单位为元
        /// </summary>
        [JsonProperty("freeze_amount")]
        [XmlElement("freeze_amount")]
        public string FreezeAmount { get; set; }

        /// <summary>
        /// 系统冻结份额，单位为元（建议不展示给用户）
        /// </summary>
        [JsonProperty("sys_freeze_amount")]
        [XmlElement("sys_freeze_amount")]
        public string SysFreezeAmount { get; set; }

        /// <summary>
        /// 余利宝总余额，单位为元
        /// </summary>
        [JsonProperty("total_amount")]
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 余利宝收益详情
        /// </summary>
        [JsonProperty("ylb_profit_detail_info")]
        [XmlElement("ylb_profit_detail_info")]
        public YLBProfitDetailInfo YlbProfitDetailInfo { get; set; }
    }
}
