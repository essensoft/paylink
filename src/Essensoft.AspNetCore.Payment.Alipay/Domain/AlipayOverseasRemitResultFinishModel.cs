using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOverseasRemitResultFinishModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasRemitResultFinishModel : AlipayObject
    {
        /// <summary>
        /// 汇款结果
        /// </summary>
        [JsonProperty("biz_result_code")]
        public string BizResultCode { get; set; }

        /// <summary>
        /// 汇款结果描述
        /// </summary>
        [JsonProperty("biz_result_msg")]
        public string BizResultMsg { get; set; }

        /// <summary>
        /// 完成时间
        /// </summary>
        [JsonProperty("complete_time")]
        public string CompleteTime { get; set; }

        /// <summary>
        /// 发端的单据号
        /// </summary>
        [JsonProperty("external_biz_no")]
        public string ExternalBizNo { get; set; }

        /// <summary>
        /// 接收端的mid
        /// </summary>
        [JsonProperty("receiver_mid")]
        public string ReceiverMid { get; set; }

        /// <summary>
        /// 发端的mid
        /// </summary>
        [JsonProperty("sender_mid")]
        public string SenderMid { get; set; }
    }
}
