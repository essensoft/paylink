using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceEducateFacefeatureFileApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateFacefeatureFileApplyModel : AlipayObject
    {
        /// <summary>
        /// 学校团餐
        /// </summary>
        [JsonProperty("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 需要请求的特征版本
        /// </summary>
        [JsonProperty("feature_version")]
        public string FeatureVersion { get; set; }

        /// <summary>
        /// 需要请求的文件日期
        /// </summary>
        [JsonProperty("file_date")]
        public string FileDate { get; set; }

        /// <summary>
        /// 需要请求的文件类型,ALL:全量,INCREASE:增量,REALTIME:实时
        /// </summary>
        [JsonProperty("file_type")]
        public string FileType { get; set; }

        /// <summary>
        /// 机构ID
        /// </summary>
        [JsonProperty("institution_id")]
        public string InstitutionId { get; set; }

        /// <summary>
        /// 合作机构简称
        /// </summary>
        [JsonProperty("isv_name")]
        public string IsvName { get; set; }
    }
}
