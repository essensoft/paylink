using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundBatchCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundBatchCreateModel : AlipayObject
    {
        /// <summary>
        /// 业务场景。不同场景值不同，具体值联系支付宝确认。
        /// </summary>
        [JsonProperty("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// JSON格式，传递业务扩展参数。
        /// </summary>
        [JsonProperty("business_params")]
        public string BusinessParams { get; set; }

        /// <summary>
        /// 转账标题，用于收银台展示标题
        /// </summary>
        [JsonProperty("order_title")]
        public string OrderTitle { get; set; }

        /// <summary>
        /// 商户的批次号
        /// </summary>
        [JsonProperty("out_batch_no")]
        public string OutBatchNo { get; set; }

        /// <summary>
        /// 公用回传参数，如果请求时传递了该参数，则异步通知商户时会回传该参数。
        /// </summary>
        [JsonProperty("passback_params")]
        public string PassbackParams { get; set; }

        /// <summary>
        /// 付款方信息
        /// </summary>
        [JsonProperty("payer_info")]
        public Participant PayerInfo { get; set; }

        /// <summary>
        /// 业务产品码。不同产品值不同，具体值联系支付宝确认。
        /// </summary>
        [JsonProperty("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 转账备注
        /// </summary>
        [JsonProperty("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 绝对超时时间，格式为yyyy-MM-dd HH:mm。
        /// </summary>
        [JsonProperty("time_expire")]
        public string TimeExpire { get; set; }

        /// <summary>
        /// 批次总笔数
        /// </summary>
        [JsonProperty("total_count")]
        public string TotalCount { get; set; }

        /// <summary>
        /// 批次总金额，单位为元，精确到小数点后两位，取值范围[0.01,9999999999999.99]
        /// </summary>
        [JsonProperty("total_trans_amount")]
        public string TotalTransAmount { get; set; }

        /// <summary>
        /// 收款信息列表
        /// </summary>
        [JsonProperty("trans_order_list")]
        public List<TransOrderDetail> TransOrderList { get; set; }
    }
}
