using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerbaseinfoPrecreateModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniInnerbaseinfoPrecreateModel : AlipayObject
    {
        /// <summary>
        /// 小程序类目ID列表
        /// </summary>
        [JsonPropertyName("app_category_ids")]
        public string AppCategoryIds { get; set; }

        /// <summary>
        /// 小程序应用描述
        /// </summary>
        [JsonPropertyName("app_desc")]
        public string AppDesc { get; set; }

        /// <summary>
        /// 小程序英文名称
        /// </summary>
        [JsonPropertyName("app_english_name")]
        public string AppEnglishName { get; set; }

        /// <summary>
        /// 小程序logo图片地址
        /// </summary>
        [JsonPropertyName("app_logo")]
        public string AppLogo { get; set; }

        /// <summary>
        /// 小程序中文名
        /// </summary>
        [JsonPropertyName("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 应用创建方，接入时请联系minicenter owner添加
        /// </summary>
        [JsonPropertyName("app_origin")]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 应用简介
        /// </summary>
        [JsonPropertyName("app_slogan")]
        public string AppSlogan { get; set; }

        /// <summary>
        /// 小程序应用类型  普通小程序: TINYAPP_NORMAL
        /// </summary>
        [JsonPropertyName("app_sub_type")]
        public string AppSubType { get; set; }

        /// <summary>
        /// 新小程序前台类目，一级与二级、三级用下划线隔开，最多可以选四个类目，类目之间;隔开。使用后不再读取app_category_ids值，老前台类目将废弃
        /// </summary>
        [JsonPropertyName("mini_category_ids")]
        public string MiniCategoryIds { get; set; }

        /// <summary>
        /// 小程序业务主体
        /// </summary>
        [JsonPropertyName("owner_entity")]
        public string OwnerEntity { get; set; }

        /// <summary>
        /// 接入方所属域，接入前请联系系统owner提供  MAYI：蚂蚁域内应用  ALIBABA：阿里域内应用
        /// </summary>
        [JsonPropertyName("partner_domain")]
        public string PartnerDomain { get; set; }

        /// <summary>
        /// 小程序主账户ID
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 小程序客服电话
        /// </summary>
        [JsonPropertyName("service_phone")]
        public string ServicePhone { get; set; }
    }
}
