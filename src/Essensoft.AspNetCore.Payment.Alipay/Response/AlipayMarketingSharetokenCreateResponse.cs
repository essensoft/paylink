using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingSharetokenCreateResponse.
    /// </summary>
    public class AlipayMarketingSharetokenCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 吱口令失效时间，若为空则表示永久有效
        /// </summary>
        [JsonPropertyName("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// 吱口令引导文案一，示例值中的：『#吱口令# 长按复制此条消息即可分享，』
        /// </summary>
        [JsonPropertyName("guider_str_1")]
        public string GuiderStr1 { get; set; }

        /// <summary>
        /// 吱口令引导文案二，示例值中的：『，赶紧去分享吧』
        /// </summary>
        [JsonPropertyName("guider_str_2")]
        public string GuiderStr2 { get; set; }

        /// <summary>
        /// 吱口令
        /// </summary>
        [JsonPropertyName("share_token")]
        public string ShareToken { get; set; }

        /// <summary>
        /// 吱口令生效时间
        /// </summary>
        [JsonPropertyName("start_date")]
        public List<string> StartDate { get; set; }
    }
}
