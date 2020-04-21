using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CreditFreezeSubOrder Data Structure.
    /// </summary>
    public class CreditFreezeSubOrder : AlipayObject
    {
        /// <summary>
        /// 用信冻结额度，单位为元，取值范围[0.01,100000000]，精确到小数点后2位
        /// </summary>
        [JsonPropertyName("credit_amount")]
        public string CreditAmount { get; set; }

        /// <summary>
        /// 子订单扩展信息，json格式字符串，该部分信息根据不同业务需要传入不同的内容，需要提前与业务方进行沟通
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 应履约时间(用户应该支付尾款的最后截止时间)，格式必须为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("fulfill_cutoff_time")]
        public string FulfillCutoffTime { get; set; }

        /// <summary>
        /// 物品价值，单位为元，取值范围[0.01,100000000]，精确到小数点后2位
        /// </summary>
        [JsonPropertyName("goods_amount")]
        public string GoodsAmount { get; set; }

        /// <summary>
        /// 物品名称描述，如：iPhone XS Max，商品原始显示名称，已通过脱敏处理
        /// </summary>
        [JsonPropertyName("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商户子订单号，如果只有主订单与子订单为1:1，子订单号可以与主订单号一致
        /// </summary>
        [JsonPropertyName("sub_out_order_no")]
        public string SubOutOrderNo { get; set; }
    }
}
