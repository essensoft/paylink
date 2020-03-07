using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundTransAacollectPayorderCreateModel Data Structure.
    /// </summary>
    public class AlipayFundTransAacollectPayorderCreateModel : AlipayObject
    {
        /// <summary>
        /// 批次号，创建批次返回
        /// </summary>
        [JsonPropertyName("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 创建批次返回的batchToken
        /// </summary>
        [JsonPropertyName("batch_token")]
        public string BatchToken { get; set; }

        /// <summary>
        /// 调用方扩充参数，json格式map
        /// </summary>
        [JsonPropertyName("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 支付金额
        /// </summary>
        [JsonPropertyName("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 当前支付宝userId，即付款方支付宝用户uid
        /// </summary>
        [JsonPropertyName("payer_user_id")]
        public string PayerUserId { get; set; }

        /// <summary>
        /// 进入付款来源，仅记录      吱口令：shakeCode      二维码：qrCode      小程序：mini      其他来源（包括正常流程）：null
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }
    }
}
