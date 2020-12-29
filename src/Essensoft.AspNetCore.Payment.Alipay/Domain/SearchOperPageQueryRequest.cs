using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SearchOperPageQueryRequest Data Structure.
    /// </summary>
    public class SearchOperPageQueryRequest : AlipayObject
    {
        /// <summary>
        /// 申请类型 BASE：基础信息， BRAND_BOX：品牌直达，SERVICE_BOX服务直达
        /// </summary>
        [JsonPropertyName("access_type")]
        public string AccessType { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [JsonPropertyName("appid")]
        public string Appid { get; set; }

        /// <summary>
        /// 当前页
        /// </summary>
        [JsonPropertyName("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 每页显示条数
        /// </summary>
        [JsonPropertyName("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [JsonPropertyName("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 服务类型 SP_MINI_APP 小程序 SP_PUBLIC_APP 生活号
        /// </summary>
        [JsonPropertyName("spec_code")]
        public string SpecCode { get; set; }
    }
}
