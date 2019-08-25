using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenOperationBizfeeAftechUnsubscribeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenOperationBizfeeAftechUnsubscribeModel : AlipayObject
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
        /// 业务发生时间
        /// </summary>
        [JsonProperty("gmt_service")]
        public string GmtService { get; set; }

        /// <summary>
        /// 订购终止时间
        /// </summary>
        [JsonProperty("gmt_stop")]
        public string GmtStop { get; set; }

        /// <summary>
        /// 外部业务流水号
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 需退还的订购费用金额 单位元，最多两位小数。
        /// </summary>
        [JsonProperty("return_fee_amount")]
        public string ReturnFeeAmount { get; set; }

        /// <summary>
        /// 需退还的订购费用币种 币种数字编码。
        /// </summary>
        [JsonProperty("return_fee_currency")]
        public string ReturnFeeCurrency { get; set; }

        /// <summary>
        /// 租户Id
        /// </summary>
        [JsonProperty("tnt_inst_id")]
        public string TntInstId { get; set; }

        /// <summary>
        /// 已使用的订购服务量 传天数/次数等数值，用于校验退费金额正确性。
        /// </summary>
        [JsonProperty("used_service_amount")]
        public string UsedServiceAmount { get; set; }
    }
}
