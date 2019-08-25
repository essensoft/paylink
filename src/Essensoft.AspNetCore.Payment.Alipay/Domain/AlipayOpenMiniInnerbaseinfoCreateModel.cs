using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerbaseinfoCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerbaseinfoCreateModel : AlipayObject
    {
        /// <summary>
        /// 小程序应用名称
        /// </summary>
        [JsonProperty("app_alias_name")]
        public string AppAliasName { get; set; }

        /// <summary>
        /// 小程序类目ID列表
        /// </summary>
        [JsonProperty("app_category_ids")]
        public string AppCategoryIds { get; set; }

        /// <summary>
        /// 小程序应用描述，20-200个字
        /// </summary>
        [JsonProperty("app_desc")]
        public string AppDesc { get; set; }

        /// <summary>
        /// 小程序英文名称
        /// </summary>
        [JsonProperty("app_english_name")]
        public string AppEnglishName { get; set; }

        /// <summary>
        /// 淘宝鉴权key
        /// </summary>
        [JsonProperty("app_key")]
        public string AppKey { get; set; }

        /// <summary>
        /// 小程序logo图标，建议上传像素为180*180
        /// </summary>
        [JsonProperty("app_logo")]
        public string AppLogo { get; set; }

        /// <summary>
        /// 小程序中文名名称
        /// </summary>
        [JsonProperty("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 应用来源
        /// </summary>
        [JsonProperty("app_origin")]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 小程序应用简介，一句话描述小程序功能
        /// </summary>
        [JsonProperty("app_slogan")]
        public string AppSlogan { get; set; }

        /// <summary>
        /// 小程序类型  普通小程序：TINYAPP_NORMAL
        /// </summary>
        [JsonProperty("app_sub_type")]
        public string AppSubType { get; set; }

        /// <summary>
        /// 小程序类型，H5 or RN，区分于 app_sub_type
        /// </summary>
        [JsonProperty("app_type")]
        public string AppType { get; set; }

        /// <summary>
        /// 多端类型
        /// </summary>
        [JsonProperty("client_type")]
        public string ClientType { get; set; }

        /// <summary>
        /// 租户编码，不同租户下的数据是隔离的 支付宝：alipay 淘宝：taobao
        /// </summary>
        [JsonProperty("inst_code")]
        public string InstCode { get; set; }

        /// <summary>
        /// 需要同步的小程序ID
        /// </summary>
        [JsonProperty("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 应用主体
        /// </summary>
        [JsonProperty("owner_entity")]
        public string OwnerEntity { get; set; }

        /// <summary>
        /// 应用来源  MAYI：蚂蚁域内应用  ALIBABA：阿里域内应用
        /// </summary>
        [JsonProperty("partner_domain")]
        public string PartnerDomain { get; set; }

        /// <summary>
        /// 小程序管理员虚拟 ID
        /// </summary>
        [JsonProperty("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 客服邮箱
        /// </summary>
        [JsonProperty("service_mail")]
        public string ServiceMail { get; set; }

        /// <summary>
        /// 客服电话
        /// </summary>
        [JsonProperty("service_phone")]
        public string ServicePhone { get; set; }
    }
}
