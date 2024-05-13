using MODELINT.Models;
using Newtonsoft.Json;
using RequestsLibrary;
using System;
using System.Linq;
using System.Threading.Tasks;
using YcLibrary.Exceptions;
using YcLibrary.Interfaces;
using YcLibrary.Models;
using YcLibrary.Models.Extentions;

namespace MODELINT.Servises
{
    public class YcTranslateService : IYcTranslateService
    {
        private readonly YcCredentials _ycCredentials;

        public YcTranslateService(YcCredentials ycCredentials)
        {
            _ycCredentials = ycCredentials;
        }

        public YcTranslateService(string ycTranslateUrl, string ycDetectUrl, string ycTranslateBearer, string ycFolderId, YcCredentials ycCredentials)
        {
            _ycCredentials = ycCredentials;

            if (!string.IsNullOrEmpty(ycTranslateUrl))
            {
                _ycCredentials.YcTranslateUrl = ycTranslateUrl;
            }

            if (!string.IsNullOrEmpty(ycDetectUrl))
            {
                _ycCredentials.YcTraslateDetectUrl = ycDetectUrl;
            }

            if (!string.IsNullOrEmpty(ycTranslateBearer))
            {
                _ycCredentials.YcTranslateBearer = ycTranslateBearer;
            }

            if (!string.IsNullOrEmpty(ycFolderId))
            {
                _ycCredentials.YcFolderId = ycFolderId;
            }
        }

        public async Task<string> DetectLanguage(string source)
        {
            var responce = new YcTranslateResponce();
            var request = new YcTranslateRequest()
            {
                FolderId = _ycCredentials.YcFolderId,
                Text = source
            };

            try
            {
                responce = await RequestsService.PostAsync<YcTranslateResponce>(_ycCredentials.YcTraslateDetectUrl, JsonConvert.SerializeObject(request), _ycCredentials.YcTranslateBearer);
            }
            catch(Exception e)
            {
                throw new YcResponceException(e.Message);
            }

            if (!string.IsNullOrEmpty(responce.Code))
            {
                throw new YcResponceException(responce.Code, responce.Message);
            }

            return responce.LanguageCode;
        }

        public async Task<string> Translate(string source)
        {

            var responce = new YcTranslateResponce();
            var request = new YcTranslateRequest()
            {
                FolderId = _ycCredentials.YcFolderId,
                SourceLanguageCode = "ru",
                TargetLanguageCode = "en",
                Texts = new[] { source }
            };

            try
            {
                responce = await RequestsService.PostAsync<YcTranslateResponce>(_ycCredentials.YcTranslateUrl, JsonConvert.SerializeObject(request), _ycCredentials.YcTranslateBearer);
            }
            catch(Exception e)
            {
                throw new YcResponceException(e.Message);
            }

            if (!string.IsNullOrEmpty(responce.Code))
            {
                throw new YcResponceException(responce.Code, responce.Message);
            }


            return responce.Translations.FirstOrDefault().Text;
        }

    }
}
