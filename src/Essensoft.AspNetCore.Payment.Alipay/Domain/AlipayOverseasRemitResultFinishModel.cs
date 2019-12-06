using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOverseasRemitResultFinishModel Data Structure.
    /// </summary>
    public class AlipayOverseasRemitResultFinishModel : AlipayObject
    {
        /// <summary>
        /// 汇款结果
        /// </summary>
        [JsonPropertyName("biz_result_code")]
        public string BizResultCode { get; set; }

        /// <summary>
        /// 汇款结果描述
        /// </summary>
        [JsonPropertyName("biz_result_msg")]
        public string BizResultMsg { get; set; }

        /// <summary>
        /// 失败
        /// </summary>
        [JsonPropertyName("biz_result_status")]
        public string BizResultStatus { get; set; }

        /// <summary>
        /// 完成时间
        /// </summary>
        [JsonPropertyName("complete_time")]
        public string CompleteTime { get; set; }

        /// <summary>
        /// 发端的单据号
        /// </summary>
        [JsonPropertyName("external_biz_no")]
        public string ExternalBizNo { get; set; }

        /// <summary>
        /// 接收端的mid
        /// </summary>
        [JsonPropertyName("receiver_mid")]
        public string ReceiverMid { get; set; }

        /// <summary>
        /// 发端的mid
        /// </summary>
        [JsonPropertyName("sender_mid")]
        public string SenderMid { get; set; }
    }
}
