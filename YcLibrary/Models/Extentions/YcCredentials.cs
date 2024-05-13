namespace YcLibrary.Models.Extentions
{
    public class YcCredentials
    {
        #region Ctors
        public YcCredentials()
        {
        }

        /// <summary>
        /// Данный конструктор устанавливет BEARER TOKEN
        /// </summary>
        /// <param name="bearer">YcTranslateBearer</param>
        public YcCredentials(string bearer)
        {
            YcTranslateBearer = bearer;
        }

        /// <summary>
        /// Данный конструктор заполняет поля для доступа к API
        /// </summary>
        /// <param name="bearer">YcTranslateBearer</param>
        /// <param name="folderId">YcFolderId</param>
        public YcCredentials(string bearer, string folderId)
        {
            YcTranslateBearer = bearer;
            YcFolderId = folderId;
        }

        /// <summary>
        /// Данный конструктор заполняет все поля класса
        /// </summary>
        /// <param name="translateUrl">YcTranslateUrl</param>
        /// <param name="translateDetectUrl">YcTraslateDetectUrl</param>
        /// <param name="bearer">YcTranslateBearer</param>
        /// <param name="folderId">YcFolderId</param>
        public YcCredentials(string translateUrl, string translateDetectUrl, string bearer, string folderId)
        {
            YcTranslateUrl = translateUrl;
            YcTraslateDetectUrl = translateDetectUrl;
            YcTranslateBearer = bearer;
            YcFolderId = folderId;
        }
        #endregion

        #region Urls
        public string YcTranslateUrl
        {
            get
            {
                return "https://translate.api.cloud.yandex.net/translate/v2/translate";
            }
            set
            {
            }
        }
        public string YcTraslateDetectUrl
        {
            get
            {
                return "https://translate.api.cloud.yandex.net/translate/v2/detect";
            }
            set
            {
            }
        }
        #endregion

        #region Credentials
        public string YcFolderId
        {
            get
            {
                return "b1gjp7bv9f2ncvubo5gc";
            }
            set
            {
            }
        }
        #endregion

        #region Authorization
        public string YcTranslateBearer
        {
            get
            {
                return "t1.9euelZrGi8udj8bNlZyVl4udy5vGzu3rnpWaxpzNnpfJmMmKlZGUlZSVi57l8_dgX0hm-e83LnAD_t3z9yAORmb57zcucAP-.0cSf2vXu46MJoR_rUJUzAFvx-YQuoyBy6FgE_TnhSx1ZUhxt9zAl4phF4P5LOgk1EjckLNWoJ23rewMS5Ry2Bg";
            }
            set
            {
            }
        }
        #endregion

    }
}
