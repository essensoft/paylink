using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsFaceMatchModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsFaceMatchModel : AlipayObject
    {
        /// <summary>
        /// 业务类型标识，比如 刷脸开柜，刷脸支付, 值由支付宝分配
        /// </summary>
        [JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 人脸集合标识-对于自提柜刷脸开柜验证场景，对应 柜子编号,注意不是格口的编号 ，
        /// </summary>
        [JsonProperty("face_group")]
        public string FaceGroup { get; set; }

        /// <summary>
        /// 刷脸取件用户的人脸图片字节数组进行Base64编码后的字符串
        /// </summary>
        [JsonProperty("face_image")]
        public string FaceImage { get; set; }

        /// <summary>
        /// 识别的人脸矩形，格式为 "left,top,width,height"
        /// </summary>
        [JsonProperty("face_rectangle")]
        public string FaceRectangle { get; set; }

        /// <summary>
        /// 商户编码-物流体系里的编码
        /// </summary>
        [JsonProperty("merchant_code")]
        public string MerchantCode { get; set; }
    }
}
