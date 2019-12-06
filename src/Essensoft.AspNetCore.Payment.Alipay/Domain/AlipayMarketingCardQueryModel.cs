using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCardQueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingCardQueryModel : AlipayObject
    {
        /// <summary>
        /// 用户信息 填写则作为附加条件查询
        /// </summary>
        [JsonPropertyName("card_user_info")]
        public CardUserInfo CardUserInfo { get; set; }

        /// <summary>
        /// 扩展信息，暂时没有
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 操作卡号。  若target_card_no_type为BIZ_CARD，则该值为业务卡号（即开卡接口返回结果中的card_info.biz_card_no）；若target_card_no_type为D_QR_CODE或D_BAR_CODE，则该值为动态码值
        /// </summary>
        [JsonPropertyName("target_card_no")]
        public string TargetCardNo { get; set; }

        /// <summary>
        /// 卡号ID类型（会员卡查询，只能提供支付宝端的卡号）  BIZ_CARD：支付宝卡号  D_QR_CODE：动态二维码（业务卡号对应的）  D_BAR_CODE：动态条码（业务卡号对应的）
        /// </summary>
        [JsonPropertyName("target_card_no_type")]
        public string TargetCardNoType { get; set; }
    }
}
