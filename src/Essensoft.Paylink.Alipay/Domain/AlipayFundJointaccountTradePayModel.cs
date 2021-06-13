using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayFundJointaccountTradePayModel Data Structure.
    /// </summary>
    public class AlipayFundJointaccountTradePayModel : AlipayObject
    {
        /// <summary>
        /// 企业账户ID
        /// </summary>
        [JsonPropertyName("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [JsonPropertyName("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 跳端扩展参数
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 是否隐藏付款码页面相关功能性操作按钮
        /// </summary>
        [JsonPropertyName("hide_menu")]
        public string HideMenu { get; set; }

        /// <summary>
        /// 销售产品码
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 支付方式： scan-正扫 qrcode-反扫
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
