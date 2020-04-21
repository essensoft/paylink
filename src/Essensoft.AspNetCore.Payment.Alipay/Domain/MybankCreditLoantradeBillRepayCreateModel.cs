using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditLoantradeBillRepayCreateModel Data Structure.
    /// </summary>
    public class MybankCreditLoantradeBillRepayCreateModel : AlipayObject
    {
        /// <summary>
        /// 账单编号
        /// </summary>
        [JsonPropertyName("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 账单还款请求详情
        /// </summary>
        [JsonPropertyName("bill_repay_request")]
        public BillRepayRequest BillRepayRequest { get; set; }

        /// <summary>
        /// 外部请求号
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 必填，网商结算户的卡号外标
        /// </summary>
        [JsonPropertyName("pay_card_no")]
        public string PayCardNo { get; set; }

        /// <summary>
        /// 方案合约编号
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 用户信息
        /// </summary>
        [JsonPropertyName("user")]
        public UserVo User { get; set; }
    }
}
