using Essensoft.AspNetCore.Payment.LcswPay.Utility;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.LcswPay
{
    /// <summary>
    /// 利楚商务扫呗支付响应的通用信息
    /// </summary>
    public abstract class LcswPayResponse
    {
        /// <summary>
        /// 响应码：01成功 ，02失败，响应码仅代表通信状态，不代表业务结果
        /// </summary>
        [JsonProperty("return_code")]
        public string ReturnCode { get; set; }
        /// <summary>
        /// 返回信息提示，“网络错误”“访问受限”等
        /// </summary>
        [JsonProperty("return_msg")]
        public string ReturnMsg { get; set; }
        /// <summary>
        /// 签名字符串,拼装所有传递参数，32位md5加密转换
        /// </summary>
        [JsonProperty("key_sign")]
        public string KeySign { get; set; }
        /// <summary>
        /// 响应的原始字符串
        /// </summary>
        [JsonIgnore]
        public string Body { get; set; }
        /// <summary>
        /// 是否响应码为成功
        /// </summary>
        [JsonIgnore]
        public bool IsReturnCodeSuccess => ReturnCode == "01";
        /// <summary>
        /// 获取所有参与签名计算的参数列表
        /// </summary>
        public abstract void AddSignedParasWhenReturnCodeSuccess(List<LcswPayParaInfo> signedParas);
        /// <summary>
        /// 是否签名正确
        /// </summary>
        public void CheckSign()
        {
            if (IsReturnCodeSuccess)
            {
                var signedParas = new List<LcswPayParaInfo>();
                signedParas.Add(new LcswPayParaInfo("return_code", ReturnCode));
                signedParas.Add( new LcswPayParaInfo("return_msg", ReturnMsg));
                AddSignedParasWhenReturnCodeSuccess(signedParas);

                var sign = LcswPaySignature.CalcSignWithAllRequiredPara(signedParas);

                if (!sign.Equals(KeySign, System.StringComparison.OrdinalIgnoreCase))
                {
                    throw new LcswPayException($"返回的签名不正确,应该是：{sign},实际是:{KeySign},原始字符串：{Body}");
                }
            }           
        }

    }
}
