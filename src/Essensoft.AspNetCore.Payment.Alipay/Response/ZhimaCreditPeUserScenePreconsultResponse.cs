using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditPeUserScenePreconsultResponse.
    /// </summary>
    public class ZhimaCreditPeUserScenePreconsultResponse : AlipayResponse
    {
        /// <summary>
        /// 极速退开通标识true 开通 false 否
        /// </summary>
        [JsonPropertyName("accessible")]
        public bool Accessible { get; set; }

        /// <summary>
        /// 剩余可用额度（场景维度，且只对特定场景开放）
        /// </summary>
        [JsonPropertyName("available_amount")]
        public string AvailableAmount { get; set; }

        /// <summary>
        /// 剩余可用件数（场景维度，且只对特定场景开放）
        /// </summary>
        [JsonPropertyName("available_goods_count")]
        public string AvailableGoodsCount { get; set; }

        /// <summary>
        /// 买家的蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 芝麻预咨询单号
        /// </summary>
        [JsonPropertyName("eval_invoke_id")]
        public string EvalInvokeId { get; set; }

        /// <summary>
        /// 场景等级 A,B ,C等,A B C D分别代表业务方不同的差异化服务
        /// </summary>
        [JsonPropertyName("scene_level")]
        public string SceneLevel { get; set; }

        /// <summary>
        /// 人维度的封顶金额
        /// </summary>
        [JsonPropertyName("top_amount")]
        public string TopAmount { get; set; }

        /// <summary>
        /// 人维度的封顶件数
        /// </summary>
        [JsonPropertyName("top_goods_count")]
        public string TopGoodsCount { get; set; }
    }
}
