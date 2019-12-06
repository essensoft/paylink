using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOfflineProviderShopactionRecordModel Data Structure.
    /// </summary>
    public class AlipayOfflineProviderShopactionRecordModel : AlipayObject
    {
        /// <summary>
        /// 详情设置会根据action_type字段类型不同而格式不同，请详细查看开放平台文案，会详细说明如果设置，整体是json结构。参考文档：https://doc.open.alipay.com/docs/doc.htm?spm=a219a.7629140.0.0.u6pJ7Q&treeId=193&articleId=105281&docType=1#s1
        /// </summary>
        [JsonPropertyName("action_detail")]
        public string ActionDetail { get; set; }

        /// <summary>
        /// 每次请求的唯一id，需开发者自行保证此参数值每次请求的唯一性。后续可以通过当前唯一id进行问题排查。
        /// </summary>
        [JsonPropertyName("action_outer_id")]
        public string ActionOuterId { get; set; }

        /// <summary>
        /// 支持的操作类型    1. insert_table(插入桌位)    2. update_table(更新桌位)    3. insert_dish(插入菜品)    4. delete_dish(删除菜品)    5. soldout_dish(估清菜品)    6. modify_dish(修改菜品)    7. modify_shop_status(店铺状态变更)  每一种操作行为对应的action_detail都不同，action_detail结构都是json串。   8.insert_one_shop_all_table(批量覆盖单个店铺桌位)  9.service_card_config(定制服务卡配置数据)
        /// </summary>
        [JsonPropertyName("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 商户行为发生时间 格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("date_time")]
        public string DateTime { get; set; }

        /// <summary>
        /// 参数值固定为shop，代表店铺行为
        /// </summary>
        [JsonPropertyName("entity")]
        public string Entity { get; set; }

        /// <summary>
        /// 当action_type的参数值是 insert_table、update_table、insert_dish、delete_dish、soldout_dish、modify_dish、insert_dish、insert_one_shop_all_table时，此参数的值固定为：REPAST
        /// </summary>
        [JsonPropertyName("industry")]
        public string Industry { get; set; }

        /// <summary>
        /// 传入店铺关联关系。标记当前接口涉及到的店铺信息，同时如果传入的数据在口碑不存在，口碑会建立一条shop_id+ outer_id+ type的关联数据
        /// </summary>
        [JsonPropertyName("outer_shop_do")]
        public OuterShopDO OuterShopDo { get; set; }

        /// <summary>
        /// 从第三方平台进入开发者应用后产生的数据，传入第三方平台域名。比如是支付宝扫码后产生的，传入支付宝域名alipay.com，是微信打开后产生的，传入微信域名weixin.qq.com，如果数据不是从第三方平台进入后产生的，设置自己的域名即可，该字段内容不做强制校验。
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }

        /// <summary>
        /// 支付宝账户ID，这里传入门店的商户id。如果获取不到支付宝账户ID，一定不能设置。如何获取支付宝账户ID,获取用户uid的接口调用文档：https://doc.open.alipay.com/docs/doc.htm?spm=a219a.7629140.0.0.jokL1V&treeId=193&articleId=105656&docType=1#s3
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
