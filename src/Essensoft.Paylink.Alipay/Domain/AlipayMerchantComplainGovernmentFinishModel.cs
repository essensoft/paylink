using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayMerchantComplainGovernmentFinishModel Data Structure.
    /// </summary>
    public class AlipayMerchantComplainGovernmentFinishModel : AlipayObject
    {
        /// <summary>
        /// 支付宝侧投诉工单号
        /// </summary>
        [JsonPropertyName("complain_event_id")]
        public string ComplainEventId { get; set; }

        /// <summary>
        /// 平台完结时的结案陈词
        /// </summary>
        [JsonPropertyName("finish_memo")]
        public string FinishMemo { get; set; }

        /// <summary>
        /// 处理该笔投诉的政府单位
        /// </summary>
        [JsonPropertyName("government_agency")]
        public string GovernmentAgency { get; set; }
    }
}
