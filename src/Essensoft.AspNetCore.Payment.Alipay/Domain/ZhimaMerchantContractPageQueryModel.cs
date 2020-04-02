using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaMerchantContractPageQueryModel Data Structure.
    /// </summary>
    public class ZhimaMerchantContractPageQueryModel : AlipayObject
    {
        /// <summary>
        /// 查询开始时间
        /// </summary>
        [JsonPropertyName("begin_time")]
        public string BeginTime { get; set; }

        /// <summary>
        /// 要查询的合约状态列表，多选 ，逗号分隔 初始化,待应约状态:INIT 生效 :EFFECT 完结: COMPLETE 关闭:CLOSE 失效:INVALID
        /// </summary>
        [JsonPropertyName("contract_status_list")]
        public string ContractStatusList { get; set; }

        /// <summary>
        /// 当前页,从1开始
        /// </summary>
        [JsonPropertyName("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 查询结束时间
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 是否包含合约履约事件信息，如打卡信息等。默认false
        /// </summary>
        [JsonPropertyName("include_event_detail")]
        public bool IncludeEventDetail { get; set; }

        /// <summary>
        /// 是否查询事项,默认false
        /// </summary>
        [JsonPropertyName("include_item")]
        public bool IncludeItem { get; set; }

        /// <summary>
        /// 发约单号
        /// </summary>
        [JsonPropertyName("offer_no")]
        public string OfferNo { get; set; }

        /// <summary>
        /// 每页条数，默认5条，最多支持10条
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 应约者主体id(淘宝id/支付宝user_id/商户id)
        /// </summary>
        [JsonPropertyName("sign_principal_id")]
        public string SignPrincipalId { get; set; }
    }
}
