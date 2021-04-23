using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayInsDataAuthorizationQueryModel Data Structure.
    /// </summary>
    public class AlipayInsDataAuthorizationQueryModel : AlipayObject
    {
        /// <summary>
        /// 授权业务唯一单号 投保场景为保单号；理赔场景为报案号。
        /// </summary>
        [JsonPropertyName("auth_biz_no")]
        public string AuthBizNo { get; set; }

        /// <summary>
        /// 机构编码
        /// </summary>
        [JsonPropertyName("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 授权场景码。枚举值： 1-投保，2-理赔
        /// </summary>
        [JsonPropertyName("scene_code")]
        public string SceneCode { get; set; }
    }
}
