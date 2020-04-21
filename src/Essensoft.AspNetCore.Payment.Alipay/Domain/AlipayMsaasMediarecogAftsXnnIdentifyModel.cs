using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogAftsXnnIdentifyModel Data Structure.
    /// </summary>
    public class AlipayMsaasMediarecogAftsXnnIdentifyModel : AlipayObject
    {
        /// <summary>
        /// 算法业务标识id，调用对应算法前请联系接口负责人获取
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 入参图片信息，
        /// </summary>
        [JsonPropertyName("image_info_list")]
        public List<ImageInfo> ImageInfoList { get; set; }

        /// <summary>
        /// config
        /// </summary>
        [JsonPropertyName("params")]
        public string Params { get; set; }

        /// <summary>
        /// 分类算法传入Common_Classify  检测算法传入Common_Detect  1.1版本后已废除
        /// </summary>
        [JsonPropertyName("request_type")]
        public string RequestType { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
