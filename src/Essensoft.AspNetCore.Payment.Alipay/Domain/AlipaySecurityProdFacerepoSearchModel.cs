using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityProdFacerepoSearchModel Data Structure.
    /// </summary>
    public class AlipaySecurityProdFacerepoSearchModel : AlipayObject
    {
        /// <summary>
        /// 商户的业务单据号，用于核对与问题排查
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 待搜索的人脸图片字节数组进行Base64编码后的字符串
        /// </summary>
        [JsonPropertyName("face_str")]
        public string FaceStr { get; set; }

        /// <summary>
        /// 人脸库分组,在指定的人脸库分组中搜索
        /// </summary>
        [JsonPropertyName("group_id")]
        public string GroupId { get; set; }
    }
}
