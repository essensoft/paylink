using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenOperationBizfeeAftechSubscribeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenOperationBizfeeAftechSubscribeModel : AlipayObject
    {
        /// <summary>
        /// 系统/应用名称
        /// </summary>
        [JsonProperty("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 合约编号
        /// </summary>
        [JsonProperty("ar_no")]
        public string ArNo { get; set; }

        /// <summary>
        /// 客户信息（JSON对象） 包含principalType主体类型、principalId主体Id、extInfo扩展信息等字段。其中，需要从extInfo透传消费的key有：relEntityId关联主体Id。
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// 订购费用金额 单位元，最多两位小数。
        /// </summary>
        [JsonProperty("fee_amount")]
        public string FeeAmount { get; set; }

        /// <summary>
        /// 订购费用币种 币种数字编码。
        /// </summary>
        [JsonProperty("fee_currency")]
        public string FeeCurrency { get; set; }

        /// <summary>
        /// 订购开始时间
        /// </summary>
        [JsonProperty("gmt_begin")]
        public string GmtBegin { get; set; }

        /// <summary>
        /// 订购结束时间
        /// </summary>
        [JsonProperty("gmt_end")]
        public string GmtEnd { get; set; }

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
        /// 外部业务流水号
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 订购包量类型 SERVICE_TIME: 包时间 SERVICE_QUANTITY: 包量
        /// </summary>
        [JsonProperty("pkg_type")]
        public string PkgType { get; set; }

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
        /// 关联订单流水号
        /// </summary>
        [JsonProperty("rel_order_no")]
        public string RelOrderNo { get; set; }

        /// <summary>
        /// 订购服务量 传天数/次数等数值。
        /// </summary>
        [JsonProperty("service_amount")]
        public string ServiceAmount { get; set; }

        /// <summary>
        /// 租户Id
        /// </summary>
        [JsonProperty("tnt_inst_id")]
        public string TntInstId { get; set; }
    }
}
