using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceEducateFacefeatureFileApplyModel Data Structure.
    /// </summary>
    public class AlipayCommerceEducateFacefeatureFileApplyModel : AlipayObject
    {
        /// <summary>
        /// SCHOOL_PAYMENT
        /// </summary>
        [JsonPropertyName("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 需要请求的特征版本
        /// </summary>
        [JsonPropertyName("feature_version")]
        public string FeatureVersion { get; set; }

        /// <summary>
        /// 需要请求的文件日期
        /// </summary>
        [JsonPropertyName("file_date")]
        public string FileDate { get; set; }

        /// <summary>
        /// 需要请求的文件类型,ALL:全量,INCREASE:增量,REALTIME:实时
        /// </summary>
        [JsonPropertyName("file_type")]
        public string FileType { get; set; }

        /// <summary>
        /// 国家统一分配的学校社会信用代码(institution_id)
        /// </summary>
        [JsonPropertyName("institution_id")]
        public string InstitutionId { get; set; }

        /// <summary>
        /// 必须是由支付宝业务方分配的英文简称(例如:yikeshi),不能是中文
        /// </summary>
        [JsonPropertyName("isv_name")]
        public string IsvName { get; set; }
    }
}
