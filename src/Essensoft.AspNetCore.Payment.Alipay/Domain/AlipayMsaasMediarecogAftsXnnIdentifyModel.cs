using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogAftsXnnIdentifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasMediarecogAftsXnnIdentifyModel : AlipayObject
    {
        /// <summary>
        /// 算法业务标识id，调用对应算法前请联系接口负责人获取
        /// </summary>
        [JsonProperty("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 入参图片信息，
        /// </summary>
        [JsonProperty("image_info_list")]
        public List<ImageInfo> ImageInfoList { get; set; }

        /// <summary>
        /// config
        /// </summary>
        [JsonProperty("params")]
        public string Params { get; set; }

        /// <summary>
        /// 分类算法传入Common_Classify  检测算法传入Common_Detect  1.1版本后已废除
        /// </summary>
        [JsonProperty("request_type")]
        public string RequestType { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
