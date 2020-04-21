using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniBaseinfoQueryResponse.
    /// </summary>
    public class AlipayOpenMiniBaseinfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 小程序应用描述
        /// </summary>
        [JsonPropertyName("app_desc")]
        public string AppDesc { get; set; }

        /// <summary>
        /// 小程序应用英文名称
        /// </summary>
        [JsonPropertyName("app_english_name")]
        public string AppEnglishName { get; set; }

        /// <summary>
        /// 小程序应用logo图标
        /// </summary>
        [JsonPropertyName("app_logo")]
        public string AppLogo { get; set; }

        /// <summary>
        /// 小程序应用名称
        /// </summary>
        [JsonPropertyName("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 小程序应用简介，一句话描述小程序功能
        /// </summary>
        [JsonPropertyName("app_slogan")]
        public string AppSlogan { get; set; }

        /// <summary>
        /// 类目名称，格式为第一个一级类目_第一个二级类目;第二个一级类目_第二个二级类目;
        /// </summary>
        [JsonPropertyName("category_names")]
        public string CategoryNames { get; set; }

        /// <summary>
        /// 功能包名称
        /// </summary>
        [JsonPropertyName("package_names")]
        public List<string> PackageNames { get; set; }

        /// <summary>
        /// 域白名单
        /// </summary>
        [JsonPropertyName("safe_domains")]
        public List<string> SafeDomains { get; set; }

        /// <summary>
        /// 小程序客服邮箱
        /// </summary>
        [JsonPropertyName("service_email")]
        public string ServiceEmail { get; set; }

        /// <summary>
        /// 小程序客服电话
        /// </summary>
        [JsonPropertyName("service_phone")]
        public string ServicePhone { get; set; }
    }
}
