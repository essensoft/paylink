using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerbaseinfoCreateModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniInnerbaseinfoCreateModel : AlipayObject
    {
        /// <summary>
        /// 小程序应用名称
        /// </summary>
        [JsonPropertyName("app_alias_name")]
        public string AppAliasName { get; set; }

        /// <summary>
        /// 小程序类目ID列表
        /// </summary>
        [JsonPropertyName("app_category_ids")]
        public string AppCategoryIds { get; set; }

        /// <summary>
        /// 小程序应用描述，20-200个字
        /// </summary>
        [JsonPropertyName("app_desc")]
        public string AppDesc { get; set; }

        /// <summary>
        /// 小程序英文名称
        /// </summary>
        [JsonPropertyName("app_english_name")]
        public string AppEnglishName { get; set; }

        /// <summary>
        /// 淘宝鉴权key
        /// </summary>
        [JsonPropertyName("app_key")]
        public string AppKey { get; set; }

        /// <summary>
        /// 小程序logo图标，建议上传像素为180*180
        /// </summary>
        [JsonPropertyName("app_logo")]
        public string AppLogo { get; set; }

        /// <summary>
        /// 小程序中文名名称
        /// </summary>
        [JsonPropertyName("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 应用来源
        /// </summary>
        [JsonPropertyName("app_origin")]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 小程序应用简介，一句话描述小程序功能
        /// </summary>
        [JsonPropertyName("app_slogan")]
        public string AppSlogan { get; set; }

        /// <summary>
        /// 小程序类型  普通小程序：TINYAPP_NORMAL
        /// </summary>
        [JsonPropertyName("app_sub_type")]
        public string AppSubType { get; set; }

        /// <summary>
        /// 小程序类型，H5 or RN，区分于 app_sub_type
        /// </summary>
        [JsonPropertyName("app_type")]
        public string AppType { get; set; }

        /// <summary>
        /// 多端类型
        /// </summary>
        [JsonPropertyName("client_type")]
        public string ClientType { get; set; }

        /// <summary>
        /// 租户编码，不同租户下的数据是隔离的 支付宝：alipay 淘宝：taobao
        /// </summary>
        [JsonPropertyName("inst_code")]
        public string InstCode { get; set; }

        /// <summary>
        /// 需要同步的小程序ID
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
        /// 小程序管理员虚拟 ID
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 客服邮箱
        /// </summary>
        [JsonPropertyName("service_mail")]
        public string ServiceMail { get; set; }

        /// <summary>
        /// 客服电话
        /// </summary>
        [JsonPropertyName("service_phone")]
        public string ServicePhone { get; set; }
    }
}
