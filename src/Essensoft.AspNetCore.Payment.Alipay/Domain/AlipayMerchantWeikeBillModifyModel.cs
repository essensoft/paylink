using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMerchantWeikeBillModifyModel Data Structure.
    /// </summary>
    public class AlipayMerchantWeikeBillModifyModel : AlipayObject
    {
        /// <summary>
        /// 当月实发劳务费，单位元
        /// </summary>
        [JsonPropertyName("actual_service_charge")]
        public string ActualServiceCharge { get; set; }

        /// <summary>
        /// 本次劳务费发放的支付宝转账流水号
        /// </summary>
        [JsonPropertyName("alipay_trans_serial_no")]
        public string AlipayTransSerialNo { get; set; }

        /// <summary>
        /// 修改的账单月份，比如2019年4月1号修改3月的账单，则传201903
        /// </summary>
        [JsonPropertyName("bill_month")]
        public string BillMonth { get; set; }

        /// <summary>
        /// 账单编号
        /// </summary>
        [JsonPropertyName("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 账单版本号
        /// </summary>
        [JsonPropertyName("bill_version")]
        public long BillVersion { get; set; }

        /// <summary>
        /// 本次实际发放劳务费金额，单位元
        /// </summary>
        [JsonPropertyName("current_actual_service_charge")]
        public string CurrentActualServiceCharge { get; set; }

        /// <summary>
        /// 本次应放劳务费金额，单位元
        /// </summary>
        [JsonPropertyName("current_expect_service_charge")]
        public string CurrentExpectServiceCharge { get; set; }

        /// <summary>
        /// 本次发放劳务费的用户任务编号总笔数
        /// </summary>
        [JsonPropertyName("current_user_task_count")]
        public long CurrentUserTaskCount { get; set; }

        /// <summary>
        /// 当月应发劳务费金额，单位元
        /// </summary>
        [JsonPropertyName("expect_service_charge")]
        public string ExpectServiceCharge { get; set; }

        /// <summary>
        /// 预扣个税金额，单位元
        /// </summary>
        [JsonPropertyName("expect_tax")]
        public string ExpectTax { get; set; }

        /// <summary>
        /// 账单更新时间
        /// </summary>
        [JsonPropertyName("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 支付时间
        /// </summary>
        [JsonPropertyName("gmt_pay")]
        public string GmtPay { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 包含税费的已发放劳务费
        /// </summary>
        [JsonPropertyName("paid_charge_tax_include")]
        public string PaidChargeTaxInclude { get; set; }

        /// <summary>
        /// 已发放的劳务费金额，单位元
        /// </summary>
        [JsonPropertyName("paid_service_charge")]
        public string PaidServiceCharge { get; set; }

        /// <summary>
        /// 劳务发放流水号
        /// </summary>
        [JsonPropertyName("service_charge_serial_no")]
        public string ServiceChargeSerialNo { get; set; }

        /// <summary>
        /// 待发放劳务费金额，单位元
        /// </summary>
        [JsonPropertyName("to_pay_service_charge")]
        public string ToPayServiceCharge { get; set; }

        /// <summary>
        /// 微客用户编码
        /// </summary>
        [JsonPropertyName("weike_user_id")]
        public long WeikeUserId { get; set; }
    }
}
