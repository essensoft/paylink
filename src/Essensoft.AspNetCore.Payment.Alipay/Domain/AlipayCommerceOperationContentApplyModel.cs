using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceOperationContentApplyModel Data Structure.
    /// </summary>
    public class AlipayCommerceOperationContentApplyModel : AlipayObject
    {
        /// <summary>
        /// 展台
        /// </summary>
        [JsonPropertyName("booth")]
        public string Booth { get; set; }

        /// <summary>
        /// 渠道
        /// </summary>
        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 活动 id 加密串
        /// </summary>
        [JsonPropertyName("content_id_str")]
        public string ContentIdStr { get; set; }

        /// <summary>
        /// 扩展参数 , json 串 , 可选的 key 列表 :     prize_id : 奖品 id , ( 指定奖品返奖场景 )
        /// </summary>
        [JsonPropertyName("ext_params")]
        public string ExtParams { get; set; }

        /// <summary>
        /// 外部业务号，只由可由字母、数字、下划线组成。同一个活动中不可重复，相同的外部业务号会被幂等并返回之前的结果。不填时，系统会生成一个默认固定的外部业务号。
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 运营场景
        /// </summary>
        [JsonPropertyName("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 展台
        /// </summary>
        [JsonPropertyName("touch_point")]
        public string TouchPoint { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
