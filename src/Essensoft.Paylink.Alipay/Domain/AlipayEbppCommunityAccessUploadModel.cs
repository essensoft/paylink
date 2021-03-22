using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppCommunityAccessUploadModel Data Structure.
    /// </summary>
    public class AlipayEbppCommunityAccessUploadModel : AlipayObject
    {
        /// <summary>
        /// 小区code
        /// </summary>
        [JsonPropertyName("community_short_name")]
        public string CommunityShortName { get; set; }

        /// <summary>
        /// 设备ID
        /// </summary>
        [JsonPropertyName("dev_id")]
        public string DevId { get; set; }

        /// <summary>
        /// 如果开门失败，记录失败原因（sdk错误码）
        /// </summary>
        [JsonPropertyName("enter_error_message")]
        public string EnterErrorMessage { get; set; }

        /// <summary>
        /// 进门记录编号
        /// </summary>
        [JsonPropertyName("enter_record_id")]
        public string EnterRecordId { get; set; }

        /// <summary>
        /// 进门结果，1成功，0失败
        /// </summary>
        [JsonPropertyName("enter_success")]
        public string EnterSuccess { get; set; }

        /// <summary>
        /// 进门时间
        /// </summary>
        [JsonPropertyName("enter_time")]
        public string EnterTime { get; set; }

        /// <summary>
        /// 用户id（加密后）
        /// </summary>
        [JsonPropertyName("user_id_encrypt")]
        public string UserIdEncrypt { get; set; }
    }
}
