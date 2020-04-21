using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceTransportWorldCarddataApplyResponse.
    /// </summary>
    public class AlipayCommerceTransportWorldCarddataApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 卡号
        /// </summary>
        [JsonPropertyName("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 生码时间戳
        /// </summary>
        [JsonPropertyName("card_timestamp")]
        public long CardTimestamp { get; set; }

        /// <summary>
        /// 虚拟卡卡类型
        /// </summary>
        [JsonPropertyName("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 请求失败时的错误信息
        /// </summary>
        [JsonPropertyName("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 是否首次使用
        /// </summary>
        [JsonPropertyName("first_use_time")]
        public bool FirstUseTime { get; set; }

        /// <summary>
        /// 请求失败时返回的子错误码信息
        /// </summary>
        [JsonPropertyName("sub_error_code")]
        public string SubErrorCode { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 基础响应信息
        /// </summary>
        [JsonPropertyName("world_base_rpc_response_info")]
        public WorldBaseRPCResponseInfo WorldBaseRpcResponseInfo { get; set; }

        /// <summary>
        /// 密钥数据
        /// </summary>
        [JsonPropertyName("world_offline_data_info")]
        public WorldOfflineDataInfo WorldOfflineDataInfo { get; set; }
    }
}
