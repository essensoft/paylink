using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayUserFamilyShareZmgoInitializeResponse.
    /// </summary>
    public class AlipayUserFamilyShareZmgoInitializeResponse : AlipayResponse
    {
        /// <summary>
        /// 共享组件链接
        /// </summary>
        [JsonPropertyName("family_sharing_link")]
        public string FamilySharingLink { get; set; }

        /// <summary>
        /// 是否已经存在共享关系
        /// </summary>
        [JsonPropertyName("has_sharing")]
        public bool HasSharing { get; set; }

        /// <summary>
        /// 是否可共享
        /// </summary>
        [JsonPropertyName("shareable")]
        public bool Shareable { get; set; }
    }
}
