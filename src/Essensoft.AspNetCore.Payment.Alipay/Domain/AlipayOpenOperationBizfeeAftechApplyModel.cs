using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenOperationBizfeeAftechApplyModel Data Structure.
    /// </summary>
    public class AlipayOpenOperationBizfeeAftechApplyModel : AlipayObject
    {
        /// <summary>
        /// 系统/应用名称
        /// </summary>
        [JsonPropertyName("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 合约号
        /// </summary>
        [JsonPropertyName("ar_no")]
        public string ArNo { get; set; }

        /// <summary>
        /// 业务流水号
        /// </summary>
        [JsonPropertyName("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 客户信息（JSON对象） 包含principalType主体类型、principalId主体Id、extInfo扩展信息等字段。其中，需要从extInfo透传消费的key有：relEntityId关联主体Id。
        /// </summary>
        [JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// 费用金额 单位元，最多两位小数。在FEE_SETTLE模式下消费。
        /// </summary>
        [JsonPropertyName("fee_amount")]
        public string FeeAmount { get; set; }

        /// <summary>
        /// 费用币种 币种数字编码。在FEE_SETTLE模式下消费。
        /// </summary>
        [JsonPropertyName("fee_currency")]
        public string FeeCurrency { get; set; }

        /// <summary>
        /// 生效价格匹配时间 在FEE_SETTLE模式下消费。
        /// </summary>
        [JsonPropertyName("gmt_charge")]
        public string GmtCharge { get; set; }

        /// <summary>
        /// 业务指定的结算应收时间
        /// </summary>
        [JsonPropertyName("gmt_receive")]
        public string GmtReceive { get; set; }

        /// <summary>
        /// 业务发生时间
        /// </summary>
        [JsonPropertyName("gmt_service")]
        public string GmtService { get; set; }

        /// <summary>
        /// 业务操作模式 FEE_SETTLE: 费用结算 VOL_AMORTIZE: 走量摊销
        /// </summary>
        [JsonPropertyName("op_mode")]
        public string OpMode { get; set; }

        /// <summary>
        /// 外部业务流水号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 扩展属性（Map<String, String>的JSON对象） key和value中不能有英文逗号及等于符号。
        /// </summary>
        [JsonPropertyName("properties")]
        public string Properties { get; set; }

        /// <summary>
        /// 服务量 传天数/次数/服务金额等数值，如不使用传0。
        /// </summary>
        [JsonPropertyName("service_amount")]
        public string ServiceAmount { get; set; }

        /// <summary>
        /// 结算周期 1#M（按自然月汇总） 在FEE_SETTLE模式下消费。
        /// </summary>
        [JsonPropertyName("settle_period")]
        public string SettlePeriod { get; set; }

        /// <summary>
        /// 结算延迟时间 9#D（延迟9日结算，如至下月10日） 在FEE_SETTLE模式下消费。
        /// </summary>
        [JsonPropertyName("settle_postponed_time")]
        public string SettlePostponedTime { get; set; }

        /// <summary>
        /// 结算类型 REALTIME: 实时结算 AUTO_CYCLE: 自动周期结算 在FEE_SETTLE模式下消费。
        /// </summary>
        [JsonPropertyName("settle_type")]
        public string SettleType { get; set; }

        /// <summary>
        /// 租户Id
        /// </summary>
        [JsonPropertyName("tnt_inst_id")]
        public string TntInstId { get; set; }
    }
}
