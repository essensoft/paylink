using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayTradeServiceFundWithdrawModel Data Structure.
    /// </summary>
    public class AlipayTradeServiceFundWithdrawModel : AlipayObject
    {
        /// <summary>
        /// 用户支付宝UID
        /// </summary>
        [JsonPropertyName("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 提现金额,单位:元，精确到小数点后两位
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 服务对应的业务场景,由支付宝分配. 枚举值列表: LARGE_INFINITE_V2:无限付2.0; YUEBAO_TRANSFER:余额宝大额申购; AD_CHARGE:灯火平台广告费充值; PERSONAL_ACCOUNT_RECHARGE:灯火平台广告费充值; ETC_B2B:区块链ETC_B2B
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 商户端的唯一订单号，对于同一笔提现请求，商户需保证该订单号唯一。
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 子业务场景，由支付宝分配.枚举值列表: 1.ACS模式: 2.FUND_ACCOUNT:场景余额 3.SHBANK:上海银行
        /// </summary>
        [JsonPropertyName("sub_biz_type")]
        public string SubBizType { get; set; }
    }
}
