using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayTradeServiceSignModel Data Structure.
    /// </summary>
    public class AlipayTradeServiceSignModel : AlipayObject
    {
        /// <summary>
        /// 用户发生协议签约的设备终端标识，支付宝分配，目前支持PC/APP
        /// </summary>
        [JsonPropertyName("access_channel")]
        public string AccessChannel { get; set; }

        /// <summary>
        /// 用户的支付宝id
        /// </summary>
        [JsonPropertyName("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 服务对应的业务场景,由支付宝分配. 枚举值列表: LARGE_INFINITE_V2:无限付2.0; YUEBAO_TRANSFER:余额宝大额申购; AD_CHARGE:灯火平台广告费充值; PERSONAL_ACCOUNT_RECHARGE:灯火平台广告费充值; ETC_B2B:区块链ETC_B2B
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 用户在商户网站的会员登录标识
        /// </summary>
        [JsonPropertyName("external_logon_id")]
        public string ExternalLogonId { get; set; }

        /// <summary>
        /// 用户在商户网站的会员标识
        /// </summary>
        [JsonPropertyName("external_user_id")]
        public string ExternalUserId { get; set; }

        /// <summary>
        /// 子业务场景，由支付宝分配.枚举值列表: 1.ACS模式: 2.FUND_ACCOUNT:场景余额 3.SHBANK:上海银行
        /// </summary>
        [JsonPropertyName("sub_biz_type")]
        public string SubBizType { get; set; }
    }
}
