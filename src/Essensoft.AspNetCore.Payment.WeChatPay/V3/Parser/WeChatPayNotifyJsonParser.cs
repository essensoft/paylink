using System;
using System.Text.Encodings.Web;
using System.Text.Json;
using Essensoft.AspNetCore.Payment.Security;
using Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Parser
{
    public class WeChatPayNotifyJsonParser<T> where T : WeChatPayNotify
    {
        private static readonly JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions { IgnoreNullValues = true, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping };

        public T Parse(string body, string v3key)
        {
            T result = null;
            var notifyCiphertext = default(NotifyCiphertext);
            var resourcePlaintext = string.Empty;

            try
            {
                if (body.StartsWith("{") && body.EndsWith("}"))
                {
                    notifyCiphertext = JsonSerializer.Deserialize<NotifyCiphertext>(body, jsonSerializerOptions);
                }
            }
            catch { }

            switch (notifyCiphertext.Resource.Algorithm)
            {
                case nameof(AEAD_AES_256_GCM):
                    {
                        resourcePlaintext = AEAD_AES_256_GCM.Decrypt(notifyCiphertext.Resource.Nonce, notifyCiphertext.Resource.Ciphertext, notifyCiphertext.Resource.AssociatedData, v3key);
                    }
                    break;
                default:
                    throw new WeChatPayException("Unknown algorithm!");
            }

            try
            {
                result = JsonSerializer.Deserialize<T>(resourcePlaintext, jsonSerializerOptions);
            }
            catch { }

            if (result == null)
            {
                result = Activator.CreateInstance<T>();
            }

            result.Body = body;
            result.NotifyCiphertext = notifyCiphertext;
            result.ResourcePlaintext = resourcePlaintext;

            return result;
        }
    }
}
