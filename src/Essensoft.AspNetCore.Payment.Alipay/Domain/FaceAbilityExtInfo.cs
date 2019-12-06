using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FaceAbilityExtInfo Data Structure.
    /// </summary>
    public class FaceAbilityExtInfo : AlipayObject
    {
        /// <summary>
        /// 年龄
        /// </summary>
        [JsonPropertyName("age")]
        public string Age { get; set; }

        /// <summary>
        /// 算法的辅助因子如blur、pitch、yaw、roll值
        /// </summary>
        [JsonPropertyName("algfactors")]
        public string Algfactors { get; set; }

        /// <summary>
        /// 姓名信息
        /// </summary>
        [JsonPropertyName("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 证件号信息
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类别
        /// </summary>
        [JsonPropertyName("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 比对源渠道信息
        /// </summary>
        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// maxRule:选择最大脸规则；  centerRule：选择中心脸规则；  默认空字符串表示不进行选脸
        /// </summary>
        [JsonPropertyName("choose_face_rule")]
        public string ChooseFaceRule { get; set; }

        /// <summary>
        /// 2D或者3D，默认2D
        /// </summary>
        [JsonPropertyName("face_data_type")]
        public string FaceDataType { get; set; }

        /// <summary>
        /// 人脸加密后的特征
        /// </summary>
        [JsonPropertyName("feature")]
        public string Feature { get; set; }

        /// <summary>
        /// 是否存在攻击
        /// </summary>
        [JsonPropertyName("hasrisk")]
        public string Hasrisk { get; set; }

        /// <summary>
        /// 质量分
        /// </summary>
        [JsonPropertyName("quality")]
        public string Quality { get; set; }

        /// <summary>
        /// 特征矩形区域"442,231,412,262"
        /// </summary>
        [JsonPropertyName("rect")]
        public string Rect { get; set; }

        /// <summary>
        /// 男女
        /// </summary>
        [JsonPropertyName("sex")]
        public string Sex { get; set; }

        /// <summary>
        /// 活体源，customer：业务方自定义采集；alisp:支付宝小程序
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }
    }
}
