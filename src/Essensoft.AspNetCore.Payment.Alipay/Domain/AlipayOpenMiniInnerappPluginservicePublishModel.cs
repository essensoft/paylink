using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerappPluginservicePublishModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniInnerappPluginservicePublishModel : AlipayObject
    {
        /// <summary>
        /// 功能类型，目前支持的有：1039支付, 1040会员, 1041基础, 1056资金, 1058信用, 1111口碑, 330120安全, 360101营销
        /// </summary>
        [JsonPropertyName("ability_type_list")]
        public List<string> AbilityTypeList { get; set; }

        /// <summary>
        /// 服务发布logo
        /// </summary>
        [JsonPropertyName("app_logo")]
        public string AppLogo { get; set; }

        /// <summary>
        /// 业务来源
        /// </summary>
        [JsonPropertyName("app_origin")]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 服务描述
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 移动端详情，用于能力中心展示
        /// </summary>
        [JsonPropertyName("detail_for_client")]
        public string DetailForClient { get; set; }

        /// <summary>
        /// pc端详，用于能力中心展示
        /// </summary>
        [JsonPropertyName("detail_for_pc")]
        public string DetailForPc { get; set; }

        /// <summary>
        /// 插件id
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 可订购人群，1003个人, 1004企业，-1无限制
        /// </summary>
        [JsonPropertyName("sell_crowd")]
        public string SellCrowd { get; set; }

        /// <summary>
        /// 发布后是否展示，01展示（默认）、02隐藏
        /// </summary>
        [JsonPropertyName("show_type")]
        public string ShowType { get; set; }

        /// <summary>
        /// 服务标题
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// pc端url地址，不需要则为空
        /// </summary>
        [JsonPropertyName("visit_url_for_pc")]
        public string VisitUrlForPc { get; set; }
    }
}
