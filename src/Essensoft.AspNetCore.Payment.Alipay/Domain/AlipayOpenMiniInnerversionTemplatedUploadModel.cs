using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionTemplatedUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerversionTemplatedUploadModel : AlipayObject
    {
        /// <summary>
        /// 来源类型，新接入方需要向支付宝申请专用来源，否则不予接入。
        /// </summary>
        [JsonProperty("app_origin")]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 格式为: x.y.z，其中x、y、z均为整型数字，版本不能重复构建，且新版本号必须高于旧版本
        /// </summary>
        [JsonProperty("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 端id
        /// </summary>
        [JsonProperty("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 模板的配置参数，完整内容请参见：https://docs.alipay.com/mini/isv/ortga1
        /// </summary>
        [JsonProperty("ext")]
        public string Ext { get; set; }

        /// <summary>
        /// 需要构建的小程序appId
        /// </summary>
        [JsonProperty("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 模板id，模板必须已经处于上架/下架状态
        /// </summary>
        [JsonProperty("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 模板版本，必须处于上架/下架状态。如果为空，默认取当前在架，或者最新下架的版本。
        /// </summary>
        [JsonProperty("template_version")]
        public string TemplateVersion { get; set; }
    }
}
