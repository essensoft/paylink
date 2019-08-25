using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundAccountBillQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundAccountBillQueryModel : AlipayObject
    {
        /// <summary>
        /// 开户场景码
        /// </summary>
        [JsonProperty("account_scene_code")]
        public string AccountSceneCode { get; set; }

        /// <summary>
        /// 支付宝用户uid
        /// </summary>
        [JsonProperty("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 账单开始时间
        /// </summary>
        [JsonProperty("bill_begin_time")]
        public string BillBeginTime { get; set; }

        /// <summary>
        /// 账单结束时间
        /// </summary>
        [JsonProperty("bill_end_time")]
        public string BillEndTime { get; set; }

        /// <summary>
        /// JSON格式，传递业务扩展参数，使用前请与支付宝工程师联系！
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 商户会员的唯一标识
        /// </summary>
        [JsonProperty("merchant_user_id")]
        public string MerchantUserId { get; set; }

        /// <summary>
        /// 查询页码，必须大于0
        /// </summary>
        [JsonProperty("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 分页大小，每页条目数需满足0< page_size < 100
        /// </summary>
        [JsonProperty("page_size")]
        public long PageSize { get; set; }
    }
}
