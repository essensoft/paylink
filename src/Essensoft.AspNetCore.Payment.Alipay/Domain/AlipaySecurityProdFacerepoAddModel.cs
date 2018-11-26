using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityProdFacerepoAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdFacerepoAddModel : AlipayObject
    {
        /// <summary>
        /// 商户的业务单据号，用于核对与问题排查
        /// </summary>
        [JsonProperty("biz_id")]
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 人脸图片字节数组进行Base64编码后的字符串
        /// </summary>
        [JsonProperty("face_str")]
        [XmlElement("face_str")]
        public string FaceStr { get; set; }

        /// <summary>
        /// 人脸库分组。每个商户可以使用多个人脸库分组，人脸搜索时会在指定的人脸库分组中搜索
        /// </summary>
        [JsonProperty("group_id")]
        [XmlElement("group_id")]
        public string GroupId { get; set; }
    }
}
