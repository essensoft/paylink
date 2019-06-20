using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditSupplychainInventoryOutApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditSupplychainInventoryOutApplyModel : AlipayObject
    {
        /// <summary>
        /// 贷款合约编号
        /// </summary>
        [JsonProperty("ar_no")]
        public string ArNo { get; set; }

        /// <summary>
        /// 资产列表
        /// </summary>
        [JsonProperty("asset_info_list")]
        public List<InventoryInfo> AssetInfoList { get; set; }

        /// <summary>
        /// 客户身份信息，在预付融资中代表的是买家的身份
        /// </summary>
        [JsonProperty("customer")]
        public Member Customer { get; set; }

        /// <summary>
        /// 外部订单号，格式：机构ipRoleId_外部订单号
        /// </summary>
        [JsonProperty("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 幂等编号，用于幂等控制，格式：机构ipRoleId_yyyymmddhhmmss_8位uniqId
        /// </summary>
        [JsonProperty("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 销售产品码
        /// </summary>
        [JsonProperty("sale_pd_code")]
        public string SalePdCode { get; set; }

        /// <summary>
        /// FACTORING：保理，PREPAYMENT：预付融资，CREDITPAY：信任付
        /// </summary>
        [JsonProperty("trade_type")]
        public string TradeType { get; set; }
    }
}
