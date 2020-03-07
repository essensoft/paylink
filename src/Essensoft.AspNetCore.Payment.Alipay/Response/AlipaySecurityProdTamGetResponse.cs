using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityProdTamGetResponse.
    /// </summary>
    public class AlipaySecurityProdTamGetResponse : AlipayResponse
    {
        /// <summary>
        /// encrypted_ta_bin（ta二进制文件的加密字符串）+ 不唯一+用于传递加密后的ta文件给OEM厂商服务端+获取方式为支付宝服务端加密后生成+特殊说明：输入框长度有限，示例值并非真实的值，实际文件长度可能会超过4096
        /// </summary>
        [JsonPropertyName("encrypted_ta_bin")]
        public string EncryptedTaBin { get; set; }

        /// <summary>
        /// 加密后的用于ta访问的数据+不唯一+用于传递给OEM厂商服务端下发到支付宝客户端+获取方式为支付宝服务端加密后生成+特殊说明：输入框长度有限，示例值并非实际传输的值，传输的值的实际长度可能超过2048
        /// </summary>
        [JsonPropertyName("encrypted_ta_data")]
        public string EncryptedTaData { get; set; }

        /// <summary>
        /// ext_info+不唯一+补充说明协议中不明确的信息+无枚举值
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// return_code(错误码)+不唯一+用于响应OEM厂商服务端的请求+是枚举值，000000含义为成功+生成方式由具体执行情况确定+其它枚举值进一步约定
        /// </summary>
        [JsonPropertyName("return_code")]
        public string ReturnCode { get; set; }

        /// <summary>
        /// return_desc(响应描述)+不唯一+用于描述响应信息+有枚举值：OPERATION_SUCCESS ERR_DEV_STATE_MISMATCH ERR_INVALID_UUID ERR_OCSP_INVALID ERR_OWE_NOT_TRUSTED ERR_REQUEST_INVALID ERR_SD_NOT_EMPTY ERR_SDID_ALREADY_USED ERR_SPCERT_INVALID ERR_TA_ALREADY_INSTALLED ERR_TA_INVALID ERR_TA_NOT_FOUND ERR_TEE_BUSY ERR_TEE_FAIL ERR_TEE_RESOURCE_FULL ERR_TEE_UNKNOWN ERR_TFW_NOT_TRUSTED ERR_UNSUPPORTED_CRYPTO_ALG ERR_UNSUPPORTED_MSG_VERSION ERR_UPDATING_DATA+获取方式：由具体执行情况确定
        /// </summary>
        [JsonPropertyName("return_desc")]
        public string ReturnDesc { get; set; }

        /// <summary>
        /// ta_hash+不唯一+ta源文件进行SHA-256哈希计算再进行BASE64编码得到的哈希值字符串信息。
        /// </summary>
        [JsonPropertyName("ta_hash")]
        public string TaHash { get; set; }

        /// <summary>
        /// ext_info+不唯一+JSON形式的map，包含关于ta摘要算法等信息+枚举值：BASE64_OVER_SHA256；BASE64_OVER_SHA512;BASE64_OVER_SM3+支付宝服务端返回TA哈希时放在入参里+缺省值为BASE64_OVER_SHA256
        /// </summary>
        [JsonPropertyName("ta_info")]
        public string TaInfo { get; set; }
    }
}
