using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenOperationBizfeeAftechCreateandpayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenOperationBizfeeAftechCreateandpayModel : AlipayObject
    {
        /// <summary>
        /// 系统/应用名称
        /// </summary>
        [JsonProperty("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 订单币种 币种数字编码。
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 客户信息（JSON对象） 包含principalType主体类型、principalId主体Id、extInfo扩展信息等字段。其中，需要从extInfo透传消费的key有：relEntityId关联主体Id。
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// 业务发生时间
        /// </summary>
        [JsonProperty("gmt_service")]
        public string GmtService { get; set; }

        /// <summary>
        /// 机构OU编码
        /// </summary>
        [JsonProperty("inst_code")]
        public string InstCode { get; set; }

        /// <summary>
        /// 订单金额 单位元，最多两位小数。
        /// </summary>
        [JsonProperty("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 订单流水号
        /// </summary>
        [JsonProperty("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 外部业务流水号
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [JsonProperty("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 扩展属性（Map的JSON对象） key和value中不能有英文逗号及等于符号。
        /// </summary>
        [JsonProperty("properties")]
        public string Properties { get; set; }

        /// <summary>
        /// 可退金额 可退金额=本次订单金额+前序订单转移金额。 单位元，最多两位小数。
        /// </summary>
        [JsonProperty("refundable_amount")]
        public string RefundableAmount { get; set; }

        /// <summary>
        /// 租户Id
        /// </summary>
        [JsonProperty("tnt_inst_id")]
        public string TntInstId { get; set; }
    }
}
