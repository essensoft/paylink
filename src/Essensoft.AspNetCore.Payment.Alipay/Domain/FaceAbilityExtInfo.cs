using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FaceAbilityExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FaceAbilityExtInfo : AlipayObject
    {
        /// <summary>
        /// 年龄
        /// </summary>
        [JsonProperty("age")]
        public string Age { get; set; }

        /// <summary>
        /// 算法的辅助因子如blur、pitch、yaw、roll值
        /// </summary>
        [JsonProperty("algfactors")]
        public string Algfactors { get; set; }

        /// <summary>
        /// 姓名信息
        /// </summary>
        [JsonProperty("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 证件号信息
        /// </summary>
        [JsonProperty("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类别
        /// </summary>
        [JsonProperty("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 比对源渠道信息
        /// </summary>
        [JsonProperty("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// maxRule:选择最大脸规则；  centerRule：选择中心脸规则；  默认空字符串表示不进行选脸
        /// </summary>
        [JsonProperty("choose_face_rule")]
        public string ChooseFaceRule { get; set; }

        /// <summary>
        /// 2D或者3D，默认2D
        /// </summary>
        [JsonProperty("face_data_type")]
        public string FaceDataType { get; set; }

        /// <summary>
        /// 人脸加密后的特征
        /// </summary>
        [JsonProperty("feature")]
        public string Feature { get; set; }

        /// <summary>
        /// 是否存在攻击
        /// </summary>
        [JsonProperty("hasrisk")]
        public string Hasrisk { get; set; }

        /// <summary>
        /// 质量分
        /// </summary>
        [JsonProperty("quality")]
        public string Quality { get; set; }

        /// <summary>
        /// 特征矩形区域"442,231,412,262"
        /// </summary>
        [JsonProperty("rect")]
        public string Rect { get; set; }

        /// <summary>
        /// 男女
        /// </summary>
        [JsonProperty("sex")]
        public string Sex { get; set; }

        /// <summary>
        /// 活体源，customer：业务方自定义采集；alisp:支付宝小程序
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }
    }
}
