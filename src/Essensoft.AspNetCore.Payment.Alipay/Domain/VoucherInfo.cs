using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// VoucherInfo Data Structure.
    /// </summary>
    public class VoucherInfo : AlipayObject
    {
        /// <summary>
        /// 是否可转赠。默认true
        /// </summary>
        [JsonPropertyName("can_give_friend")]
        public bool CanGiveFriend { get; set; }

        /// <summary>
        /// 使用规则
        /// </summary>
        [JsonPropertyName("use_rule")]
        public UseRuleInfo UseRule { get; set; }

        /// <summary>
        /// 有效期
        /// </summary>
        [JsonPropertyName("valid_date")]
        public ValidDateInfo ValidDate { get; set; }

        /// <summary>
        /// 券详情描述
        /// </summary>
        [JsonPropertyName("voucher_desc")]
        public string VoucherDesc { get; set; }

        /// <summary>
        /// 券背景图。该值调用接口:alipay.offline.material.image.upload生成
        /// </summary>
        [JsonPropertyName("voucher_img")]
        public string VoucherImg { get; set; }

        /// <summary>
        /// logo图片id。该值调用接口:alipay.offline.material.image.upload生成
        /// </summary>
        [JsonPropertyName("voucher_logo")]
        public string VoucherLogo { get; set; }

        /// <summary>
        /// 券名称
        /// </summary>
        [JsonPropertyName("voucher_name")]
        public string VoucherName { get; set; }

        /// <summary>
        /// 券上的详情描述信息
        /// </summary>
        [JsonPropertyName("voucher_terms")]
        public List<VoucherTermInfo> VoucherTerms { get; set; }

        /// <summary>
        /// 券类型
        /// </summary>
        [JsonPropertyName("voucher_type")]
        public string VoucherType { get; set; }
    }
}
