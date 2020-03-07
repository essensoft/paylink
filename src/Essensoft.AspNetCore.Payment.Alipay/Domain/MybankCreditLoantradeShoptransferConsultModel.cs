using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditLoantradeShoptransferConsultModel Data Structure.
    /// </summary>
    public class MybankCreditLoantradeShoptransferConsultModel : AlipayObject
    {
        /// <summary>
        /// 咨询业务类型,TRANSFER(转让)/RECEIVE(接收)
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 接收方支付宝id
        /// </summary>
        [JsonPropertyName("receive_alipay_id")]
        public string ReceiveAlipayId { get; set; }

        /// <summary>
        /// 淘宝userId
        /// </summary>
        [JsonPropertyName("taobao_id")]
        public string TaobaoId { get; set; }

        /// <summary>
        /// 转让流程编号
        /// </summary>
        [JsonPropertyName("trans_no")]
        public string TransNo { get; set; }

        /// <summary>
        /// 转让方支付宝id
        /// </summary>
        [JsonPropertyName("transfer_alipay_id")]
        public string TransferAlipayId { get; set; }
    }
}
