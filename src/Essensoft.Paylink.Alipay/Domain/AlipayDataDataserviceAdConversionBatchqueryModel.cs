using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdConversionBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayDataDataserviceAdConversionBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 灯火平台提供给外部系统的访问token
        /// </summary>
        [JsonPropertyName("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 转化事件ID列表
        /// </summary>
        [JsonPropertyName("conversion_id_list")]
        public List<string> ConversionIdList { get; set; }

        /// <summary>
        /// 转化事件类型： COLLECT_NORMAL - 免费留资 COLLECT_TRADE - 付费留资 CPA_TMALL_MEMBER_JOIN - 入会 等等
        /// </summary>
        [JsonPropertyName("conversion_type")]
        public string ConversionType { get; set; }

        /// <summary>
        /// 分页参数之页数，从1开始
        /// </summary>
        [JsonPropertyName("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页参数之每页大小，最大为1000
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 商家在灯火侧的id
        /// </summary>
        [JsonPropertyName("principal_id")]
        public long PrincipalId { get; set; }
    }
}
