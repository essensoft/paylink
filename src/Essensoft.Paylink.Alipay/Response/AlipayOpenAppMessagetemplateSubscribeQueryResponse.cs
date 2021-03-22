using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenAppMessagetemplateSubscribeQueryResponse.
    /// </summary>
    public class AlipayOpenAppMessagetemplateSubscribeQueryResponse : AlipayResponse
    {
        /// <summary>
        /// true:显示订阅组件，false:不显示订阅组件
        /// </summary>
        [JsonPropertyName("show_component")]
        public bool ShowComponent { get; set; }

        /// <summary>
        /// 用户对消息模板的订阅关系列表，为入参中的用户id对消息模板id的订阅关系
        /// </summary>
        [JsonPropertyName("subscribe_relations")]
        public List<SubscribeRelation> SubscribeRelations { get; set; }
    }
}
