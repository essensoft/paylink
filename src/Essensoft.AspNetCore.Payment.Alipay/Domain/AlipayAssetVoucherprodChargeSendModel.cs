using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayAssetVoucherprodChargeSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAssetVoucherprodChargeSendModel : AlipayObject
    {
        /// <summary>
        /// 卡资金总金额，单位元
        /// </summary>
        [JsonProperty("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 资产总面额，单位元
        /// </summary>
        [JsonProperty("asset_amount")]
        public string AssetAmount { get; set; }

        /// <summary>
        /// 资产详情
        /// </summary>
        [JsonProperty("asset_details")]
        public List<VcpAssetDetail> AssetDetails { get; set; }

        /// <summary>
        /// 资产id
        /// </summary>
        [JsonProperty("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// 资产id类型 模板/资产id实例 ASSET_INSTANCE(实例)/ASSET_TEMPLATE(模板)
        /// </summary>
        [JsonProperty("asset_id_type")]
        public string AssetIdType { get; set; }

        /// <summary>
        /// 资产平台类型卡/券
        /// </summary>
        [JsonProperty("asset_type")]
        public string AssetType { get; set; }

        /// <summary>
        /// 业务发生时间
        /// </summary>
        [JsonProperty("biz_dt")]
        public string BizDt { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonProperty("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 资金流场景
        /// </summary>
        [JsonProperty("fund_scence")]
        public string FundScence { get; set; }

        /// <summary>
        /// 比如某种业务标准外部订单号,比如交易外部订单号，代表商户端自己订单号
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 用户userId
        /// </summary>
        [JsonProperty("publisher_user_id")]
        public string PublisherUserId { get; set; }
    }
}
