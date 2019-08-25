using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditSupplychainInventoryOutConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditSupplychainInventoryOutConsultModel : AlipayObject
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
        /// 扩展字段，在特定场景下必填
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 外部订单号，格式：机构ipRoleId_外部订单号
        /// </summary>
        [JsonProperty("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 销售产品码
        /// </summary>
        [JsonProperty("sale_pd_code")]
        public string SalePdCode { get; set; }

        /// <summary>
        /// FACTORING：保理，PREPAYMENT：预付融资，CREDITPAY：信任付，UN_TRADE_SCENE：非交易出库
        /// </summary>
        [JsonProperty("trade_type")]
        public string TradeType { get; set; }
    }
}
