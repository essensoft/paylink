using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniAliminiabilityprodJsapiModifyModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniAliminiabilityprodJsapiModifyModel : AlipayObject
    {
        /// <summary>
        /// appx最低版本
        /// </summary>
        [JsonPropertyName("appx_min_version")]
        public string AppxMinVersion { get; set; }

        /// <summary>
        /// 来源端,高德:com.amap.app,IOT:com.alipay.iot.xpaas,微博:com.weibo.app,优酷:com.youku.app,网商银行:com.mybank.phone,菜鸟:com.cainiao.app,天猫精灵:com.alibaba.ailabs.genie.webapps,UC:com.uc.app,支付宝:com.alipay.alipaywallet,口碑:com.koubei.mobile.KoubeiClient,财富:com.alipay.antfortune,学习强国:com.xuexi.app,支付宝香港:com.alipay.wallethk,手淘:com.taobao.app
        /// </summary>
        [JsonPropertyName("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 客户端最低版本
        /// </summary>
        [JsonPropertyName("bundle_min_version")]
        public string BundleMinVersion { get; set; }

        /// <summary>
        /// DemoUrl
        /// </summary>
        [JsonPropertyName("demo_url")]
        public string DemoUrl { get; set; }

        /// <summary>
        /// 英文名称
        /// </summary>
        [JsonPropertyName("en_name")]
        public string EnName { get; set; }

        /// <summary>
        /// 交换中心接口版本
        /// </summary>
        [JsonPropertyName("instance_version")]
        public string InstanceVersion { get; set; }

        /// <summary>
        /// 域账号
        /// </summary>
        [JsonPropertyName("owner")]
        public string Owner { get; set; }

        /// <summary>
        /// 已发布:published,已删除:deleted
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
