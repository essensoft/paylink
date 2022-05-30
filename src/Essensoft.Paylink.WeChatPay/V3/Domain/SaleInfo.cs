using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 经营场景
    /// </summary>
    public class SaleInfo
    {
        /// <summary>
        /// 线下场所场景
        /// </summary>
        [JsonPropertyName("biz_store_info")]
        public BizStoreInfo BizStoreInfo { get; set; }
        /// <summary>
        /// 公众号场景
        /// </summary>
        [JsonPropertyName("mp_info")]
        public MpInfo MpInfo { get; set; }

        /// <summary>
        /// 小程序场景
        /// </summary>
        [JsonPropertyName("mini_program_info")]
        public MiniProgramInfo MiniProgramInfo { get; set; }

        /// <summary>
        /// App场景
        /// </summary>
        [JsonPropertyName("app_info")]
        public AppInfo AppInfo { get; set; }

        /// <summary>
        /// 互联网网站场景
        /// </summary>
        [JsonPropertyName("web_info")]
        public WebInfo WebInfo { get; set; }

        /// <summary>
        /// 企业微信场景
        /// </summary>
        [JsonPropertyName("wework_info	")]
        public WeworkInfo WeWorkInfo { get; set; }
    }
}
