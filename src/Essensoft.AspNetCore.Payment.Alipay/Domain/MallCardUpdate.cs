using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MallCardUpdate Data Structure.
    /// </summary>
    public class MallCardUpdate : AlipayObject
    {
        /// <summary>
        /// 资金卡余额，单位：元，精确到小数点后两位。
        /// </summary>
        [JsonPropertyName("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// 会员业务卡号   说明：   1、开卡成功后返回该参数，需要保存留用；   2、开卡/更新/删卡/查询卡接口请求中都需要传该参数；
        /// </summary>
        [JsonPropertyName("biz_card_no")]
        public string BizCardNo { get; set; }

        /// <summary>
        /// 商户外部会员卡卡号   说明：   1、会员卡开卡接口，如果卡类型为外部会员卡，请求中则必须提供该参数；   2、更新、查询、删除等接口，请求中则不需要提供该参数值；
        /// </summary>
        [JsonPropertyName("external_card_no")]
        public string ExternalCardNo { get; set; }

        /// <summary>
        /// 会员卡等级（由商户自定义，并可以在卡模板创建时，定义等级信息）
        /// </summary>
        [JsonPropertyName("level")]
        public string Level { get; set; }

        /// <summary>
        /// 会员卡积分，积分必须为数字型
        /// </summary>
        [JsonPropertyName("point")]
        public long Point { get; set; }
    }
}
