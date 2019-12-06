using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicMenuBatchqueryResponse.
    /// </summary>
    public class AlipayOpenPublicMenuBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 菜单数量，包括默认菜单和个性化菜单
        /// </summary>
        [JsonPropertyName("count")]
        public string Count { get; set; }

        /// <summary>
        /// 菜单列表
        /// </summary>
        [JsonPropertyName("menus")]
        public List<QueryMenu> Menus { get; set; }
    }
}
