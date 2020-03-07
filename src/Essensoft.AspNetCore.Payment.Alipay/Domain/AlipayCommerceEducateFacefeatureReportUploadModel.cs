using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceEducateFacefeatureReportUploadModel Data Structure.
    /// </summary>
    public class AlipayCommerceEducateFacefeatureReportUploadModel : AlipayObject
    {
        /// <summary>
        /// 参数来源 客户端BehaviourLog-> aesCypher 参数
        /// </summary>
        [JsonPropertyName("aes_cypher")]
        public string AesCypher { get; set; }

        /// <summary>
        /// 参数来源 客户端BehaviourLog->imageBlob 参数
        /// </summary>
        [JsonPropertyName("auth_img")]
        public string AuthImg { get; set; }

        /// <summary>
        /// 学校团餐
        /// </summary>
        [JsonPropertyName("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 商户机具编码即机具sn号
        /// </summary>
        [JsonPropertyName("device_num")]
        public string DeviceNum { get; set; }

        /// <summary>
        /// 国家统一分配的学校社会信用代码(institution_id)
        /// </summary>
        [JsonPropertyName("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 必须是由支付宝业务方分配的英文简称(例如:yikeshixx),不能是中文
        /// </summary>
        [JsonPropertyName("isv_name")]
        public string IsvName { get; set; }

        /// <summary>
        /// 没有特殊情况固定传internal+alipay+atomicZolozBio+faceFeature
        /// </summary>
        [JsonPropertyName("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 商户透传人脸客户端信息json格式字符串， 参数来源 客户端BehaviourLog-> logBlob 参数
        /// </summary>
        [JsonPropertyName("z_face_info")]
        public string ZFaceInfo { get; set; }
    }
}
