using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingActivityDeliverychannelQueryResponse.
    /// </summary>
    public class AlipayMarketingActivityDeliverychannelQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 可投放的渠道信息列表。 用于表达当前可以投放的渠道列表信息
        /// </summary>
        [JsonPropertyName("delivery_channel_info_list")]
        public List<DeliveryChannelInfo> DeliveryChannelInfoList { get; set; }

        /// <summary>
        /// 查询的页码。 特别说明： 页码从1开始。
        /// </summary>
        [JsonPropertyName("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 每页查询个数
        /// </summary>
        [JsonPropertyName("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 可返回的渠道总数
        /// </summary>
        [JsonPropertyName("total_size")]
        public string TotalSize { get; set; }
    }
}
