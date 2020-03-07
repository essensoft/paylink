using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundTransBatchCreateorderModel Data Structure.
    /// </summary>
    public class AlipayFundTransBatchCreateorderModel : AlipayObject
    {
        /// <summary>
        /// 批次编号：创建批次时生成的批次号；表示这笔付款是这个批次下面的一条明细
        /// </summary>
        [JsonPropertyName("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 必须是map<String,String>的json串，长度限制为100
        /// </summary>
        [JsonPropertyName("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 金额，单位为元
        /// </summary>
        [JsonPropertyName("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 收款方userId
        /// </summary>
        [JsonPropertyName("payee_id")]
        public string PayeeId { get; set; }

        /// <summary>
        /// 付款方userId
        /// </summary>
        [JsonPropertyName("payer_id")]
        public string PayerId { get; set; }

        /// <summary>
        /// token；创建批次时和批次编号一起下发的token串
        /// </summary>
        [JsonPropertyName("token")]
        public string Token { get; set; }
    }
}
