using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// QueryInstBillInfo Data Structure.
    /// </summary>
    public class QueryInstBillInfo : AlipayObject
    {
        /// <summary>
        /// 账单金额
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 余额
        /// </summary>
        [JsonPropertyName("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// 账单日期
        /// </summary>
        [JsonPropertyName("bill_date")]
        public string BillDate { get; set; }

        /// <summary>
        /// 明细说明
        /// </summary>
        [JsonPropertyName("bill_detail")]
        public List<QueryInstBillDetail> BillDetail { get; set; }

        /// <summary>
        /// 滞纳金
        /// </summary>
        [JsonPropertyName("bill_fines")]
        public string BillFines { get; set; }

        /// <summary>
        /// 账单流水
        /// </summary>
        [JsonPropertyName("bill_key")]
        public string BillKey { get; set; }

        /// <summary>
        /// 户名
        /// </summary>
        [JsonPropertyName("bill_user_name")]
        public string BillUserName { get; set; }

        /// <summary>
        /// JDBXINHUI
        /// </summary>
        [JsonPropertyName("charge_inst")]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 查询欠费单的惟一标识
        /// </summary>
        [JsonPropertyName("charge_uniq_id")]
        public string ChargeUniqId { get; set; }

        /// <summary>
        /// 销账机构
        /// </summary>
        [JsonPropertyName("chargeoff_inst")]
        public string ChargeoffInst { get; set; }

        /// <summary>
        /// 销账机构给出账机构分配的ID
        /// </summary>
        [JsonPropertyName("company_id")]
        public string CompanyId { get; set; }

        /// <summary>
        /// 扩展属性
        /// </summary>
        [JsonPropertyName("extend")]
        public string Extend { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [JsonPropertyName("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 外部流水号
        /// </summary>
        [JsonPropertyName("out_id")]
        public string OutId { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonPropertyName("return_message")]
        public string ReturnMessage { get; set; }

        /// <summary>
        /// 子业务类型
        /// </summary>
        [JsonPropertyName("sub_order_type")]
        public string SubOrderType { get; set; }
    }
}
