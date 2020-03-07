using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerbaseinfoTransferModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniInnerbaseinfoTransferModel : AlipayObject
    {
        /// <summary>
        /// 应用来源
        /// </summary>
        [JsonPropertyName("app_origin")]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 支付宝登陆账号
        /// </summary>
        [JsonPropertyName("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 需要迁移的小程序ID
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 应用主体
        /// </summary>
        [JsonPropertyName("owner_entity")]
        public string OwnerEntity { get; set; }

        /// <summary>
        /// 应用来源  MAYI：蚂蚁域内应用  ALIBABA：阿里域内应用
        /// </summary>
        [JsonPropertyName("partner_domain")]
        public string PartnerDomain { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }
    }
}
