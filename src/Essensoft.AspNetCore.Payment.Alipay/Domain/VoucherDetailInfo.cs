using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// VoucherDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherDetailInfo : AlipayObject
    {
        /// <summary>
        /// 资产id
        /// </summary>
        [JsonProperty("asset_id")]
        [XmlElement("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// 资产生效时间
        /// </summary>
        [JsonProperty("effect_time")]
        [XmlElement("effect_time")]
        public string EffectTime { get; set; }

        /// <summary>
        /// 扩展字段信息，通过map存储的json串
        /// </summary>
        [JsonProperty("ext_info")]
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 不可用时间段（只支持到天）
        /// </summary>
        [JsonProperty("forbbiden_time")]
        [XmlElement("forbbiden_time")]
        public ForbbidenTime ForbbidenTime { get; set; }

        /// <summary>
        /// 资产过期时间
        /// </summary>
        [JsonProperty("invalid_time")]
        [XmlElement("invalid_time")]
        public string InvalidTime { get; set; }

        /// <summary>
        /// 单品id中间用“,”分隔
        /// </summary>
        [JsonProperty("sku_codes")]
        [XmlElement("sku_codes")]
        public string SkuCodes { get; set; }

        /// <summary>
        /// 可用时段条款
        /// </summary>
        [JsonProperty("time_rules")]
        [XmlArray("time_rules")]
        [XmlArrayItem("use_time")]
        public List<UseTime> TimeRules { get; set; }

        /// <summary>
        /// 券使用条件
        /// </summary>
        [JsonProperty("use_condition")]
        [XmlElement("use_condition")]
        public string UseCondition { get; set; }

        /// <summary>
        /// 全资产描述
        /// </summary>
        [JsonProperty("voucher_desc")]
        [XmlElement("voucher_desc")]
        public string VoucherDesc { get; set; }

        /// <summary>
        /// 券类型(ALIPAY_FIX_VOUCHER:全场券；ALIPAY_ITEM_VOUCHER：单品券,KOUBEI_BUY_EXCHANGE_VOUCHER:兑换券)
        /// </summary>
        [JsonProperty("voucher_type")]
        [XmlElement("voucher_type")]
        public string VoucherType { get; set; }
    }
}
