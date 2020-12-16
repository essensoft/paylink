using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AnttechAiCvDsbIdentifyModel Data Structure.
    /// </summary>
    public class AnttechAiCvDsbIdentifyModel : AlipayObject
    {
        /// <summary>
        /// 蚂蚁内部单号
        /// </summary>
        [JsonPropertyName("ant_estimate_no")]
        public string AntEstimateNo { get; set; }

        /// <summary>
        /// 外部保险单号
        /// </summary>
        [JsonPropertyName("estimate_request_no")]
        public string EstimateRequestNo { get; set; }

        /// <summary>
        /// 定损图片信息
        /// </summary>
        [JsonPropertyName("image_info")]
        public List<DsbImageInfo> ImageInfo { get; set; }
    }
}
