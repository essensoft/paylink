using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsMarketingCampaignPrizeSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsMarketingCampaignPrizeSendModel : AlipayObject
    {
        /// <summary>
        /// 账户id，如支付宝userId：2088102161835009
        /// </summary>
        [JsonProperty("account_id")]
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 账号类型
        /// </summary>
        [JsonProperty("account_type")]
        [XmlElement("account_type")]
        public long AccountType { get; set; }

        /// <summary>
        /// 营销保险活动Id
        /// </summary>
        [JsonProperty("campaign_id")]
        [XmlElement("campaign_id")]
        public string CampaignId { get; set; }

        /// <summary>
        /// 发奖规则因子
        /// </summary>
        [JsonProperty("factors")]
        [XmlArray("factors")]
        [XmlArrayItem("ins_mkt_factor_d_t_o")]
        public List<InsMktFactorDTO> Factors { get; set; }

        /// <summary>
        /// 发奖接口幂等字段
        /// </summary>
        [JsonProperty("out_biz_no")]
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 请求流水Id
        /// </summary>
        [JsonProperty("request_id")]
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
