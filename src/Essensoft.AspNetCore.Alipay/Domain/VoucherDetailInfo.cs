using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// VoucherDetailInfo Data Structure.
    /// </summary>
    public class VoucherDetailInfo : AlipayObject
    {
        /// <summary>
        /// 资产id
        /// </summary>
        [JsonProperty("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// 资产生效时间
        /// </summary>
        [JsonProperty("effect_time")]
        public string EffectTime { get; set; }

        /// <summary>
        /// 扩展字段信息，通过map存储的json串
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 不可用时间段（只支持到天）
        /// </summary>
        [JsonProperty("forbbiden_time")]
        public ForbbidenTime ForbbidenTime { get; set; }

        /// <summary>
        /// 资产过期时间
        /// </summary>
        [JsonProperty("invalid_time")]
        public string InvalidTime { get; set; }

        /// <summary>
        /// 单品id中间用“,”分隔
        /// </summary>
        [JsonProperty("sku_codes")]
        public string SkuCodes { get; set; }

        /// <summary>
        /// 可用时段条款
        /// </summary>
        [JsonProperty("time_rules")]
        public List<UseTime> TimeRules { get; set; }

        /// <summary>
        /// 券使用条件
        /// </summary>
        [JsonProperty("use_condition")]
        public string UseCondition { get; set; }

        /// <summary>
        /// 全资产描述
        /// </summary>
        [JsonProperty("voucher_desc")]
        public string VoucherDesc { get; set; }

        /// <summary>
        /// 券类型(ALIPAY_FIX_VOUCHER:全场券；ALIPAY_ITEM_VOUCHER：单品券,KOUBEI_BUY_EXCHANGE_VOUCHER:兑换券)
        /// </summary>
        [JsonProperty("voucher_type")]
        public string VoucherType { get; set; }
    }
}
