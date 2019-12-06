using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayYebLqdDataResult Data Structure.
    /// </summary>
    public class AlipayYebLqdDataResult : AlipayObject
    {
        /// <summary>
        /// 申购预测，单位:元
        /// </summary>
        [JsonPropertyName("predict_purchase_amt")]
        public string PredictPurchaseAmt { get; set; }

        /// <summary>
        /// 赎回预测,单位:元
        /// </summary>
        [JsonPropertyName("predict_redeem_amt")]
        public string PredictRedeemAmt { get; set; }

        /// <summary>
        /// 预测日期，格式为yyyymmdd
        /// </summary>
        [JsonPropertyName("target_date")]
        public string TargetDate { get; set; }
    }
}
