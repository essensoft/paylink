using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditPeVisaReportQueryModel Data Structure.
    /// </summary>
    public class ZhimaCreditPeVisaReportQueryModel : AlipayObject
    {
        /// <summary>
        /// 接口是否要返回报告文件
        /// </summary>
        [JsonPropertyName("include_file")]
        public bool IncludeFile { get; set; }

        /// <summary>
        /// 申请场景，报告申请国家
        /// </summary>
        [JsonPropertyName("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
