using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceOperationContentApplyResponse.
    /// </summary>
    public class AlipayCommerceOperationContentApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 运营扩展数据 .
        /// </summary>
        [JsonPropertyName("ext_data")]
        public OperationExtDataModel ExtData { get; set; }

        /// <summary>
        /// 外部业务单号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 申请记录id
        /// </summary>
        [JsonPropertyName("record_id")]
        public string RecordId { get; set; }

        /// <summary>
        /// 申请的内容相关的下游数据 ID ，比如 发奖对应奖品流水 id .
        /// </summary>
        [JsonPropertyName("target_id")]
        public string TargetId { get; set; }
    }
}
