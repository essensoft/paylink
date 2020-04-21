using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingDataSceneParkingoutUploadModel Data Structure.
    /// </summary>
    public class KoubeiMarketingDataSceneParkingoutUploadModel : AlipayObject
    {
        /// <summary>
        /// 停车出库场景业务参数
        /// </summary>
        [JsonPropertyName("biz_info")]
        public ParkingOutScene BizInfo { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 外部请求号，确保唯一，用于幂等控制
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 场景类型
        /// </summary>
        [JsonPropertyName("scene_type")]
        public string SceneType { get; set; }

        /// <summary>
        /// 支付宝用户的userId
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
