using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMerchantWeikeBilltaxModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantWeikeBilltaxModifyModel : AlipayObject
    {
        /// <summary>
        /// 实际报税金额，单位元
        /// </summary>
        [JsonProperty("actual_tax")]
        public string ActualTax { get; set; }

        /// <summary>
        /// 退税支付宝转账流水号
        /// </summary>
        [JsonProperty("alipay_trans_serial_no")]
        public string AlipayTransSerialNo { get; set; }

        /// <summary>
        /// 申报个税账单的月份，比如在2019年4月申报3月的个税，则创："201903"
        /// </summary>
        [JsonProperty("bill_month")]
        public string BillMonth { get; set; }

        /// <summary>
        /// 账单编号
        /// </summary>
        [JsonProperty("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 账单版本号
        /// </summary>
        [JsonProperty("bill_version")]
        public long BillVersion { get; set; }

        /// <summary>
        /// 预扣税金额
        /// </summary>
        [JsonProperty("expect_tax")]
        public string ExpectTax { get; set; }

        /// <summary>
        /// 账单更新时间
        /// </summary>
        [JsonProperty("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 当月已退个税金额
        /// </summary>
        [JsonProperty("tax_rebate")]
        public string TaxRebate { get; set; }

        /// <summary>
        /// 退税支付时间
        /// </summary>
        [JsonProperty("tax_rebate_gmt_pay")]
        public string TaxRebateGmtPay { get; set; }

        /// <summary>
        /// 退税转账流水号
        /// </summary>
        [JsonProperty("tax_rebate_serial_no")]
        public string TaxRebateSerialNo { get; set; }

        /// <summary>
        /// 微客用户编码
        /// </summary>
        [JsonProperty("weike_user_id")]
        public long WeikeUserId { get; set; }
    }
}
