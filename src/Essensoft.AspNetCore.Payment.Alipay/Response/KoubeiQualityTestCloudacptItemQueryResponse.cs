using Newtonsoft.Json;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiQualityTestCloudacptItemQueryResponse.
    /// </summary>
    public class KoubeiQualityTestCloudacptItemQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [JsonProperty("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 批次id
        /// </summary>
        [JsonProperty("batch_id")]
        public string BatchId { get; set; }

        /// <summary>
        /// 批次状态  0，未检测  1，检测中  2，未通过  3，已通过
        /// </summary>
        [JsonProperty("batch_status")]
        public string BatchStatus { get; set; }

        /// <summary>
        /// 失败单品书列表
        /// </summary>
        [JsonProperty("fail_list")]
        public List<OpenItem> FailList { get; set; }

        /// <summary>
        /// 失败数
        /// </summary>
        [JsonProperty("fail_num")]
        public string FailNum { get; set; }

        /// <summary>
        /// 单品列表
        /// </summary>
        [JsonProperty("item_list")]
        public List<OpenItem> ItemList { get; set; }

        /// <summary>
        /// 单品数
        /// </summary>
        [JsonProperty("item_num")]
        public string ItemNum { get; set; }

        /// <summary>
        /// 通过单品列表
        /// </summary>
        [JsonProperty("pass_list")]
        public List<OpenItem> PassList { get; set; }

        /// <summary>
        /// 通过数
        /// </summary>
        [JsonProperty("pass_num")]
        public string PassNum { get; set; }
    }
}
