using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignAssetDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignAssetDetailQueryModel : AlipayObject
    {
        /// <summary>
        /// 用户资产id，配合《用户口碑优惠资产查询接口koubei.marketing.campaign.user.asset.query》使用，返回信息列表中的asset_id则为传递的入参值。
        /// </summary>
        [JsonProperty("asset_id")]
        [XmlElement("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// 配合《用户口碑优惠资产查询接口koubei.marketing.campaign.user.asset.query》查询券列表数据使用，如果获取的是voucher_asset_list数据，则对应的枚举为：VOUCHER；（目前只支持该类型）
        /// </summary>
        [JsonProperty("asset_type")]
        [XmlElement("asset_type")]
        public string AssetType { get; set; }
    }
}
