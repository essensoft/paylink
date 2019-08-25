using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FengdieEditorGetRespModel Data Structure.
    /// </summary>
    [Serializable]
    public class FengdieEditorGetRespModel : AlipayObject
    {
        /// <summary>
        /// 云凤蝶编辑器访问地址，可通过iframe集成在后台系统，由系统用户编辑H5应用内容。url的有效期为15秒，因此每次需要编辑h5页面的时候应该重新调用Api生成。
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
