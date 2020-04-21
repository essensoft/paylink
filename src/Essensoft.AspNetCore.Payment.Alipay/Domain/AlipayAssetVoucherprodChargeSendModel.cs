using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayAssetVoucherprodChargeSendModel Data Structure.
    /// </summary>
    public class AlipayAssetVoucherprodChargeSendModel : AlipayObject
    {
        /// <summary>
        /// 卡资金总金额，单位元
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 资产总面额，单位元
        /// </summary>
        [JsonPropertyName("asset_amount")]
        public string AssetAmount { get; set; }

        /// <summary>
        /// 资产详情
        /// </summary>
        [JsonPropertyName("asset_details")]
        public List<VcpAssetDetail> AssetDetails { get; set; }

        /// <summary>
        /// 资产id
        /// </summary>
        [JsonPropertyName("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// 资产id类型 模板/资产id实例 ASSET_INSTANCE(实例)/ASSET_TEMPLATE(模板)
        /// </summary>
        [JsonPropertyName("asset_id_type")]
        public string AssetIdType { get; set; }

        /// <summary>
        /// 资产平台类型卡/券
        /// </summary>
        [JsonPropertyName("asset_type")]
        public string AssetType { get; set; }

        /// <summary>
        /// 业务发生时间
        /// </summary>
        [JsonPropertyName("biz_dt")]
        public string BizDt { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 资金流场景
        /// </summary>
        [JsonPropertyName("fund_scence")]
        public string FundScence { get; set; }

        /// <summary>
        /// 比如某种业务标准外部订单号,比如交易外部订单号，代表商户端自己订单号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 用户userId
        /// </summary>
        [JsonPropertyName("publisher_user_id")]
        public string PublisherUserId { get; set; }
    }
}
