using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onshape.Api
{
    internal static class Constants
    {

        #region Configuration environment variables

        internal const string ONSHAPE_OAUTH_REFRESH_TOKEN = @"ONSHAPE_OAUTH_REFRESH_TOKEN";
        internal const string ONSHAPE_CLIENT_SECRET = @"ONSHAPE_CLIENT_SECRET";
        internal const string ONSHAPE_OAUTH_TOKEN = @"ONSHAPE_OAUTH_TOKEN";
        internal const string ONSHAPE_CLIENT_ID = @"ONSHAPE_CLIENT_ID";
        internal const string ONSHAPE_BASE_URI = @"ONSHAPE_BASE_URI";

        #endregion

        #region OAuth

        internal const string AUTH_FORM_TEMPLATE = "code={0}&client_id={1}&client_secret={2}&grant_type=authorization_code&redirect_uri={3}";
        internal const string TOKEN_URI_TEMPLATE = @"{0}/oauth/token";

        #endregion

        #region Onshape REST API URIs

        public const string DOCUMENTS_API_URI = @"/api/documents";
        public const string DOCUMENT_API_URI = @"/api/documents/{0}";

        public const string WORKSPACES_API_URI = @"/api/documents/d/{0}/workspaces";
        public const string WORKSPACE_API_URI = @"/api/documents/d/{0}/workspaces/{1}";

        public const string VERSIONS_API_URI = @"/api/documents/d/{0}/versions";
        public const string VERSION_API_URI = @"/api/documents/d/{0}/versions/{1}";

        public const string ELEMENTS_API_URI = @"/api/documents/d/{0}/{1}/{2}/elements";
        public const string ELEMENT_API_URI = @"/api/documents/d/{0}/{1}/{2}/elements?elementId={3}";

        public const string USER_API_URI = @"/api/users/{0}";

        public const string EXPORT_PARTSTUDIO_API_URI = @"/api/partstudios/d/{0}/{1}/{2}/e/{3}/{4}";
        public const string EXPORT_PART_API_URI = @"/api/parts/d/{0}/{1}/{2}/e/{3}/partid/{4}/{5}";

        public const string PURCHASES_API_URI = @"/api/accounts/purchases";
        public const string PURCHASE_API_URI = @"/api/accounts/purchases/{0}";
        public const string CONSUME_PURCHASE_API_URI = @"/api/accounts/purchases/{0}/consume";
        public const string BILLING_PLAN_API_URI = @"/api/billing/plans/{0}";
        public const string CLIENT_BILLING_PLANS_API_URI = @"/api/billing/plans/client/{0}";

        public const string ELEMENT_TRANSLATIONS_API_URI = @"/api/{0}/d/{1}/w/{2}/e/{3}/translations";
        public const string ELEMENT_TRANSLATION_FORMATS_API_URI = @"/api/{0}/d/{1}/w/{2}/e/{3}/translationformats";

        public const string CREATE_TRANSLATION_API_URI = @"/api/translations/d/{0}/w/{1}";
        public const string DOCUMENT_TRANSLATIONS_API_URI = @"/api/translations/d/{0}";
        public const string TRANSLATION_API_URI = @"/api/translations/{0}";

        public const string BLOB_ELEMENTS_API_URI = @"/api/blobelements/d/{0}/{1}/{2}";
        public const string BLOB_ELEMENT_API_URI = @"/api/blobelements/d/{0}/{1}/{2}/e/{3}";

        #endregion

        #region Misc constants

        public const string ASSEMBLIES_PATH_NAME = @"assemblies";
        public const string PARTSTUDIOS_PATH_NAME = @"partstudios";
        public const string BLOBELEMENTS_PATH_NAME = @"blobelements";

        public const string PARASOLID_FORMAT_NAME = @"parasolid";
        public const string STL_FORMAT_NAME = @"stl";

        public const int USE_API_DEFAULT = -1;

        internal const string REGISTRY_KEY_FORMAT = @"HKEY_CURRENT_USER\Software\{0}\{1}";
        internal const string DEFAULT_LOGING_LEVEL = @"Info";
        internal const string INTERACTIVE_PROMPT = @"> ";
        internal const int MAX_FILE_LENGTH_TO_PRINT_OUT = 65536;
        internal const string REFRESH_TOKEN_KEY_NAME = @"t";
        internal const int TOKEN_REFRESH_TIME_OUT = 1000;

        #endregion

        #region Tokens

        internal const string UPLOAD = @"UPLOAD";
        internal const string HELP = @"HELP";
        internal const string GET = @"GET";
        internal const string POST = @"POST";
        internal const string DELETE = @"DELETE";
        internal const string DOCUMENT_ID = @"DOCUMENT_ID";
        internal const string WORKSPACE_ID = @"WORKSPACE_ID";
        internal const string VERSION_ID = @"VERSION_ID";
        internal const string USER_ID = @"USER_ID";
        internal const string ELEMENT_ID = @"ELEMENT_ID";
        internal const string VALUE = @"VALUE";
        internal const string DOCUMENTS = @"DOCUMENTS";
        internal const string DOCUMENT = @"DOCUMENT";
        internal const string WORKSPACES = @"WORKSPACES";
        internal const string VERSIONS = @"VERSIONS";
        internal const string USERS = @"USERS";
        internal const string ELEMENTS = @"ELEMENTS";
        internal const string PART = @"PART";
        internal const string ASSEMBLY = @"ASSEMBLY";
        internal const string PARTSTUDIO = @"PARTSTUDIO";
        internal const string BLOBELEMENT = @"BLOBELEMENT";
        internal const string TRANSLATION_ID = @"TRANSLATION_ID";
        internal const string TRANSLATION = @"TRANSLATION";
        internal const string FORMATS = @"FORMATS";
        internal const string DEBUG = @"DEBUG";
        internal const string CONTEXT = @"CONTEXT";
        internal const string CLEAR = @"CLEAR";
        internal const string CREATE = @"CREATE";
        internal const string EXPORT = @"EXPORT";
        internal const string DOWNLOAD = @"DOWNLOAD";
        internal const string THUMBNAIL = @"THUMBNAIL";
        internal const string PLANS = @"PLANS";
        internal const string PURCHASE = @"PURCHASE";
        internal const string PURCHASES = @"PURCHASES";
        internal const string CONSUME = @"CONSUME";
        internal const string CANCEL = @"CANCEL";
        internal const string FILE = @"FILE";
        internal const string FORMAT = @"FORMAT";
        internal const string FORMAT_VERSION = @"FORMAT_VERSION";
        internal const string STORE_IN_DOCUMENT = @"STORE_IN_DOCUMENT";
        internal const string Y_AXIS_IS_UP = @"Y_AXIS_IS_UP";
        internal const string FLATTEN_ASSEMBLIES = @"FLATTEN_ASSEMBLIES";
        internal const string GROUPING = @"GROUPING";
        internal const string SCALE = @"SCALE";
        internal const string UNITS = @"UNITS";
        internal const string ANGLE_TOLERANCE = @"ANGLE_TOLERANCE";
        internal const string CHORD_TOLERANCE = @"CHORD_TOLERANCE";
        internal const string MAX_FACET_WIDTH = @"MAX_FACET_WIDTH";
        internal const string MIN_FACET_WIDTH = @"MIN_FACET_WIDTH";
        internal const string MODE = @"MODE";
        internal const string PART_ID = @"PART_ID";
        internal const string BASE_URI = @"BASE_URI";
        internal const string OAUTH_TOKEN = @"TOKEN";
        internal const string OAUTH_REFRESH_TOKEN = @"REFRESH_TOKEN";
        internal const string LOGGING_LEVEL = @"LOGING_LEVEL";
        internal const string INTERACTIVE_MODE = @"INTERACTIVE_MODE";
        internal const string OUTPUT_FORMAT = @"OUTPUT_FORMAT";
        internal const string EXIT = @"EXIT";

        #endregion
    }
}
