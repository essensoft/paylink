using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FaceExtParams Data Structure.
    /// </summary>
    [Serializable]
    public class FaceExtParams : AlipayObject
    {
        /// <summary>
        /// 业务类型：7，基于1:N人脸搜索的刷脸支付场景；8，基于姓名和身份证号的刷脸支付场景。
        /// </summary>
        [JsonProperty("biz_type")]
        public string BizType { get; set; }
    }
}
