using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiShopExternalDataSyncModel Data Structure.
    /// </summary>
    public class KoubeiShopExternalDataSyncModel : AlipayObject
    {
        /// <summary>
        /// 操作类型：Bind:建立口碑门店和饿了么外卖关系  unBind：解除口碑门店和饿了么外卖关系  sync：同步门店营业时间、营业状态、店铺状态
        /// </summary>
        [JsonPropertyName("action")]
        public string Action { get; set; }

        /// <summary>
        /// shop_status:OPEN（生效）||CLOSE（失效） ，饿了么签约状态  business_time：08：00-11：30,13：00-20：30，营业时间，多个逗号分隔  business_status：OPEN（营业）||CLOSE（歇业）  饿了么营业状态。  ext_info：map结构, 记录bindType-绑定类型: ELE_LEADS(饿了么leads开店)、KB_ELE_OPEN_SHOP_ONLINE(口碑在线开饿了么门店)、KB_ELE_BIND_ONLINE(口碑接饿了么在线修改绑定关系)、ELE_ALGO_CALC(饿了么算法计算)、ELE_OPERATION(饿了么运营操作); bindRelation-绑定关系:STRONG(强)、WEAK(弱)
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// 数据来源。固定值:elm
        /// </summary>
        [JsonPropertyName("data_source")]
        public string DataSource { get; set; }

        /// <summary>
        /// 数据版本（时间戳）。用于判断请求是否乱序。
        /// </summary>
        [JsonPropertyName("data_version")]
        public long DataVersion { get; set; }

        /// <summary>
        /// 外部的门店id
        /// </summary>
        [JsonPropertyName("external_shop_id")]
        public string ExternalShopId { get; set; }

        /// <summary>
        /// 口碑店铺Id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
