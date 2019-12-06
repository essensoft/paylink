using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoCplifeResidentinfoUploadModel Data Structure.
    /// </summary>
    public class AlipayEcoCplifeResidentinfoUploadModel : AlipayObject
    {
        /// <summary>
        /// 请求流水号，由商户自定义，在商户系统内唯一标示一次业务请求。
        /// </summary>
        [JsonPropertyName("batch_id")]
        public string BatchId { get; set; }

        /// <summary>
        /// 业主所在物业小区ID(支付宝平台唯一小区ID标示)
        /// </summary>
        [JsonPropertyName("community_id")]
        public string CommunityId { get; set; }

        /// <summary>
        /// 请求上传的住户信息列表，单次至多上传200条住户信息.
        /// </summary>
        [JsonPropertyName("resident_info")]
        public List<CplifeResidentInfo> ResidentInfo { get; set; }
    }
}
