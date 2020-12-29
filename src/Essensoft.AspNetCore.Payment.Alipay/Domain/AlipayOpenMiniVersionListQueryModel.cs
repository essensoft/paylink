using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniVersionListQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniVersionListQueryModel : AlipayObject
    {
        /// <summary>
        /// 端参数，用于查询多端版本，不传默认为支付宝端。 高德端：com.amap.app
        /// </summary>
        [JsonPropertyName("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 版本状态列表，用英文逗号","分割，可选；不填默认不返回，状态可选值以及说明如下-INIT: 开发中, AUDITING: 审核中, AUDIT_REJECT: 审核驳回, WAIT_RELEASE: 待上架, GRAY: 灰度中, RELEASE: 已上架, OFFLINE: 已下架, AUDIT_OFFLINE: 已下架;
        /// </summary>
        [JsonPropertyName("version_status")]
        public string VersionStatus { get; set; }
    }
}
