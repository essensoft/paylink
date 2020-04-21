using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerappCreateModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniInnerappCreateModel : AlipayObject
    {
        /// <summary>
        /// 小程序类目，二级类目与三级类目下划线隔开，最多可以选择3个类目，类目之间以;隔开
        /// </summary>
        [JsonPropertyName("app_category_ids")]
        public string AppCategoryIds { get; set; }

        /// <summary>
        /// 小程序描述
        /// </summary>
        [JsonPropertyName("app_desc")]
        public string AppDesc { get; set; }

        /// <summary>
        /// 小程序英文名称
        /// </summary>
        [JsonPropertyName("app_english_name")]
        public string AppEnglishName { get; set; }

        /// <summary>
        /// 小程序logo
        /// </summary>
        [JsonPropertyName("app_logo")]
        public string AppLogo { get; set; }

        /// <summary>
        /// 小程序名称
        /// </summary>
        [JsonPropertyName("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 来源的业务方,接入文档中申请的业务来源
        /// </summary>
        [JsonPropertyName("app_origin")]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 小程序简介，在搜索透出
        /// </summary>
        [JsonPropertyName("app_slogan")]
        public string AppSlogan { get; set; }

        /// <summary>
        /// 应用子类型
        /// </summary>
        [JsonPropertyName("app_sub_type")]
        public string AppSubType { get; set; }

        /// <summary>
        /// 应用类型
        /// </summary>
        [JsonPropertyName("app_type")]
        public string AppType { get; set; }

        /// <summary>
        /// 三方应用ID，仅在创建模板小程序时需要传入
        /// </summary>
        [JsonPropertyName("isv_app_id")]
        public string IsvAppId { get; set; }

        /// <summary>
        /// 小程序ID，仅特殊场景使用，普通业务方无需关注该参数
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 创建的小程序所属的PID
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 邮箱，与客服电话二选一
        /// </summary>
        [JsonPropertyName("service_email")]
        public string ServiceEmail { get; set; }

        /// <summary>
        /// 客服电话
        /// </summary>
        [JsonPropertyName("service_phone")]
        public string ServicePhone { get; set; }
    }
}
