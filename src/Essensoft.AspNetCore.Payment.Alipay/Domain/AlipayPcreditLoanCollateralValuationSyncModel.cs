using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditLoanCollateralValuationSyncModel Data Structure.
    /// </summary>
    public class AlipayPcreditLoanCollateralValuationSyncModel : AlipayObject
    {
        /// <summary>
        /// 业务流水号，即用户授信申请的单号，每次授信申请由借呗平台生成的唯一编号，通知估值时给到机构
        /// </summary>
        [JsonPropertyName("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 估值时间，格式为yyyy-MM-dd HH:mm:ss，若更新估值，时间要晚于上一次估值时间
        /// </summary>
        [JsonPropertyName("eval_time")]
        public string EvalTime { get; set; }

        /// <summary>
        /// JSON格式的扩展信息，具体操作和机构约定具体的扩展信息。  {"annualIncome":"200000.00","downPayment":"30000.00","installmentNum":"12","installmentOrg":"0","isInstallment":"1","isLocal":"1","isMortgaged":"1","monthlyPayment":"11000.00","paidNum":"3","serviceProvider":"杭州服务商","totalAmount":"150000.00","unpaidAmount":"99000.00"}
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 机构请求流水号，请求的幂等字段，作为业务幂等性控制
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 拒绝码，如车辆黑名单，客户黑名单等
        /// </summary>
        [JsonPropertyName("rejected_code")]
        public string RejectedCode { get; set; }

        /// <summary>
        /// 拒绝原因，可以用于排查问题以及跟用户解释，如：  存量客户拒单  黑名单拒绝  铭牌缺失  限制车辆  虚假资料  备用钥匙不符  限制人群  非本人到场签约  非申请车辆到场
        /// </summary>
        [JsonPropertyName("rejected_reason")]
        public string RejectedReason { get; set; }

        /// <summary>
        /// 请求ID，在平台发起押品估值通知时提供给机构的request_id
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 资产估值，单位为元，拒绝时为0，精确到小数点后两位
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
