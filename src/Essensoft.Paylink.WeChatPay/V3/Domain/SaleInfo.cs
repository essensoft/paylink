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
        /// 经营场景类型
        /// </summary>
        /// <remarks>
        /// 1、请勾选实际售卖商品/提供服务场景（至少一项），以便为你开通需要的支付权限。
        /// 2、建议只勾选目前必须的场景，以便尽快通过入驻审核，其他支付权限可在入驻后再根据实际需要发起申请。
        /// SALES_SCENES_STORE：线下场所
        /// SALES_SCENES_MP：公众号
        /// SALES_SCENES_MINI_PROGRAM：小程序
        /// SALES_SCENES_WEB：互联网网站
        /// SALES_SCENES_APP：APP
        /// SALES_SCENES_WEWORK：企业微信
        /// <para>示例值：SALES_SCENES_STORE</para>
        /// </remarks>
        [JsonPropertyName("sales_scenes_type")]
        public List<string> SalesScenesType { get; set; }
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
        [JsonPropertyName("wework_info")]
        public WeworkInfo WeWorkInfo { get; set; }
    }
}
