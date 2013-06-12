//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18047
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Google.Apis.Translate.v2.Data {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    
    
    public class DetectionsListResponse : Google.Apis.Requests.IDirectResponseSchema {
        
        private System.Collections.Generic.IList<DetectionsResource> _detections;
        
        private string _ETag;
        
        /// <summary>A detections contains detection results of several text</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detections")]
        public virtual System.Collections.Generic.IList<DetectionsResource> Detections {
            get {
                return this._detections;
            }
            set {
                this._detections = value;
            }
        }
        
        public virtual string ETag {
            get {
                return this._ETag;
            }
            set {
                this._ETag = value;
            }
        }
    }
    
    /// <summary>An array of languages which we detect for the given text The most likely language list first.</summary>
    public class DetectionsResource : System.Collections.Generic.List<DetectionsResource.Entry> {
        
        public class Entry {
            
            private System.Nullable<double> _confidence;
            
            private System.Nullable<bool> _isReliable;
            
            private string _language;
            
            /// <summary>The confidence of the detection resul of this language.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
            public virtual System.Nullable<double> Confidence {
                get {
                    return this._confidence;
                }
                set {
                    this._confidence = value;
                }
            }
            
            /// <summary>A boolean to indicate is the language detection result reliable.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("isReliable")]
            public virtual System.Nullable<bool> IsReliable {
                get {
                    return this._isReliable;
                }
                set {
                    this._isReliable = value;
                }
            }
            
            /// <summary>The language we detect</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("language")]
            public virtual string Language {
                get {
                    return this._language;
                }
                set {
                    this._language = value;
                }
            }
        }
    }
    
    public class LanguagesListResponse : Google.Apis.Requests.IDirectResponseSchema {
        
        private System.Collections.Generic.IList<LanguagesResource> _languages;
        
        private string _ETag;
        
        /// <summary>List of source/target languages supported by the translation API. If target parameter is unspecified, the list is sorted by the ASCII code point order of the language code. If target parameter is specified, the list is sorted by the collation order of the language name in the target language.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languages")]
        public virtual System.Collections.Generic.IList<LanguagesResource> Languages {
            get {
                return this._languages;
            }
            set {
                this._languages = value;
            }
        }
        
        public virtual string ETag {
            get {
                return this._ETag;
            }
            set {
                this._ETag = value;
            }
        }
    }
    
    public class LanguagesResource {
        
        private string _language;
        
        private string _name;
        
        /// <summary>The language code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("language")]
        public virtual string Language {
            get {
                return this._language;
            }
            set {
                this._language = value;
            }
        }
        
        /// <summary>The localized name of the language if target parameter is given.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name {
            get {
                return this._name;
            }
            set {
                this._name = value;
            }
        }
    }
    
    public class TranslationsListResponse : Google.Apis.Requests.IDirectResponseSchema {
        
        private System.Collections.Generic.IList<TranslationsResource> _translations;
        
        private string _ETag;
        
        /// <summary>Translations contains list of translation results of given text</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("translations")]
        public virtual System.Collections.Generic.IList<TranslationsResource> Translations {
            get {
                return this._translations;
            }
            set {
                this._translations = value;
            }
        }
        
        public virtual string ETag {
            get {
                return this._ETag;
            }
            set {
                this._ETag = value;
            }
        }
    }
    
    public class TranslationsResource {
        
        private string _detectedSourceLanguage;
        
        private string _translatedText;
        
        /// <summary>Detected source language if source parameter is unspecified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedSourceLanguage")]
        public virtual string DetectedSourceLanguage {
            get {
                return this._detectedSourceLanguage;
            }
            set {
                this._detectedSourceLanguage = value;
            }
        }
        
        /// <summary>The translation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("translatedText")]
        public virtual string TranslatedText {
            get {
                return this._translatedText;
            }
            set {
                this._translatedText = value;
            }
        }
    }
}
namespace Google.Apis.Translate.v2 {
    using System;
    using System.IO;
    using System.Collections.Generic;
    using Google.Apis;
    using Google.Apis.Discovery;
    
    
    public partial class TranslateService : Google.Apis.Services.BaseClientService {
        
        public const string Version = "v2";
        
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;
        
        private System.Collections.Generic.IDictionary<string, Google.Apis.Discovery.IParameter> _serviceParameters;
        
        public TranslateService(Google.Apis.Services.BaseClientService.Initializer initializer) : 
                base(initializer) {
            this._detections = new DetectionsResource(this, Authenticator);
            this._languages = new LanguagesResource(this, Authenticator);
            this._translations = new TranslationsResource(this, Authenticator);
            this.InitParameters();
        }
        
        public TranslateService() : 
                this(new Google.Apis.Services.BaseClientService.Initializer()) {
        }
        
        public override System.Collections.Generic.IList<string> Features {
            get {
                return new string[] {
                        "dataWrapper"};
            }
        }
        
        public override string Name {
            get {
                return "translate";
            }
        }
        
        public override string BaseUri {
            get {
                return "https://www.googleapis.com/language/translate/";
            }
        }
        
        public override string BasePath {
            get {
                return "/language/translate/";
            }
        }
        
        public override System.Collections.Generic.IDictionary<string, Google.Apis.Discovery.IParameter> ServiceParameters {
            get {
                return this._serviceParameters;
            }
        }
        
        private void InitParameters() {
            System.Collections.Generic.Dictionary<string, Google.Apis.Discovery.IParameter> parameters = new System.Collections.Generic.Dictionary<string, Google.Apis.Discovery.IParameter>();
            parameters.Add("alt", Google.Apis.Util.Utilities.CreateRuntimeParameter("alt", false, "query", "json", null, new string[] {
                            "json"}));
            parameters.Add("fields", Google.Apis.Util.Utilities.CreateRuntimeParameter("fields", false, "query", null, null, new string[0]));
            parameters.Add("key", Google.Apis.Util.Utilities.CreateRuntimeParameter("key", false, "query", null, null, new string[0]));
            parameters.Add("oauth_token", Google.Apis.Util.Utilities.CreateRuntimeParameter("oauth_token", false, "query", null, null, new string[0]));
            parameters.Add("prettyPrint", Google.Apis.Util.Utilities.CreateRuntimeParameter("prettyPrint", false, "query", "true", null, new string[0]));
            parameters.Add("quotaUser", Google.Apis.Util.Utilities.CreateRuntimeParameter("quotaUser", false, "query", null, null, new string[0]));
            parameters.Add("userIp", Google.Apis.Util.Utilities.CreateRuntimeParameter("userIp", false, "query", null, null, new string[0]));
            this._serviceParameters = new Google.Apis.Util.ReadOnlyDictionary<string, Google.Apis.Discovery.IParameter>(parameters);
        }
    }
    
    public class DetectionsResource {
        
        private TranslateService service;
        
        private Google.Apis.Authentication.IAuthenticator authenticator;
        
        private const string Resource = "detections";
        
        public DetectionsResource(TranslateService service, Google.Apis.Authentication.IAuthenticator authenticator) {
            this.service = service;
            this.authenticator = authenticator;
        }
        
        /// <summary>Detect the language of text.</summary>
        /// <param name="q">Required - The text to detect</param>
        public virtual ListRequest List(Google.Apis.Util.Repeatable<string> q) {
            return new ListRequest(service, q);
        }
        
        public class ListRequest : Google.Apis.Requests.ClientServiceRequest<Google.Apis.Translate.v2.Data.DetectionsListResponse> {
            
            private string _alt;
            
            private string _fields;
            
            private string _oauth_token;
            
            private System.Nullable<bool> _prettyPrint;
            
            private string _quotaUser;
            
            private string _userIp;
            
            private Google.Apis.Util.Repeatable<string> _q;
            
            public ListRequest(Google.Apis.Services.IClientService service, Google.Apis.Util.Repeatable<string> q) : 
                    base(service) {
                this._q = q;
                this.InitParameters();
            }
            
            /// <summary>Data format for the response.</summary>
            [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Alt {
                get {
                    return this._alt;
                }
                set {
                    this._alt = value;
                }
            }
            
            /// <summary>Selector specifying which fields to include in a partial response.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Fields {
                get {
                    return this._fields;
                }
                set {
                    this._fields = value;
                }
            }
            
            /// <summary>OAuth 2.0 token for the current user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Oauth_token {
                get {
                    return this._oauth_token;
                }
                set {
                    this._oauth_token = value;
                }
            }
            
            /// <summary>Returns response with indentations and line breaks.</summary>
            [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> PrettyPrint {
                get {
                    return this._prettyPrint;
                }
                set {
                    this._prettyPrint = value;
                }
            }
            
            /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided.</summary>
            [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string QuotaUser {
                get {
                    return this._quotaUser;
                }
                set {
                    this._quotaUser = value;
                }
            }
            
            /// <summary>IP address of the site where the request originates. Use this if you want to enforce per-user limits.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userIp", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserIp {
                get {
                    return this._userIp;
                }
                set {
                    this._userIp = value;
                }
            }
            
            /// <summary>The text to detect</summary>
            [Google.Apis.Util.RequestParameterAttribute("q", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Q {
                get {
                    return this._q;
                }
            }
            
            public override string MethodName {
                get {
                    return "list";
                }
            }
            
            public override string HttpMethod {
                get {
                    return "GET";
                }
            }
            
            public override string RestPath {
                get {
                    return "v2/detect";
                }
            }
            
            private void InitParameters() {
                System.Collections.Generic.Dictionary<string, Google.Apis.Discovery.IParameter> parameters = new System.Collections.Generic.Dictionary<string, Google.Apis.Discovery.IParameter>();
                parameters.Add("q", Google.Apis.Util.Utilities.CreateRuntimeParameter("q", true, "query", null, null, new string[0]));
                this._requestParameters = new Google.Apis.Util.ReadOnlyDictionary<string, Google.Apis.Discovery.IParameter>(parameters);
            }
        }
    }
    
    public class LanguagesResource {
        
        private TranslateService service;
        
        private Google.Apis.Authentication.IAuthenticator authenticator;
        
        private const string Resource = "languages";
        
        public LanguagesResource(TranslateService service, Google.Apis.Authentication.IAuthenticator authenticator) {
            this.service = service;
            this.authenticator = authenticator;
        }
        
        /// <summary>List the source/target languages supported by the API</summary>
        public virtual ListRequest List() {
            return new ListRequest(service);
        }
        
        public class ListRequest : Google.Apis.Requests.ClientServiceRequest<Google.Apis.Translate.v2.Data.LanguagesListResponse> {
            
            private string _alt;
            
            private string _fields;
            
            private string _oauth_token;
            
            private System.Nullable<bool> _prettyPrint;
            
            private string _quotaUser;
            
            private string _userIp;
            
            private string _target;
            
            public ListRequest(Google.Apis.Services.IClientService service) : 
                    base(service) {
                this.InitParameters();
            }
            
            /// <summary>Data format for the response.</summary>
            [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Alt {
                get {
                    return this._alt;
                }
                set {
                    this._alt = value;
                }
            }
            
            /// <summary>Selector specifying which fields to include in a partial response.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Fields {
                get {
                    return this._fields;
                }
                set {
                    this._fields = value;
                }
            }
            
            /// <summary>OAuth 2.0 token for the current user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Oauth_token {
                get {
                    return this._oauth_token;
                }
                set {
                    this._oauth_token = value;
                }
            }
            
            /// <summary>Returns response with indentations and line breaks.</summary>
            [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> PrettyPrint {
                get {
                    return this._prettyPrint;
                }
                set {
                    this._prettyPrint = value;
                }
            }
            
            /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided.</summary>
            [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string QuotaUser {
                get {
                    return this._quotaUser;
                }
                set {
                    this._quotaUser = value;
                }
            }
            
            /// <summary>IP address of the site where the request originates. Use this if you want to enforce per-user limits.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userIp", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserIp {
                get {
                    return this._userIp;
                }
                set {
                    this._userIp = value;
                }
            }
            
            /// <summary>the language and collation in which the localized results should be returned</summary>
            [Google.Apis.Util.RequestParameterAttribute("target", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Target {
                get {
                    return this._target;
                }
                set {
                    this._target = value;
                }
            }
            
            public override string MethodName {
                get {
                    return "list";
                }
            }
            
            public override string HttpMethod {
                get {
                    return "GET";
                }
            }
            
            public override string RestPath {
                get {
                    return "v2/languages";
                }
            }
            
            private void InitParameters() {
                System.Collections.Generic.Dictionary<string, Google.Apis.Discovery.IParameter> parameters = new System.Collections.Generic.Dictionary<string, Google.Apis.Discovery.IParameter>();
                parameters.Add("target", Google.Apis.Util.Utilities.CreateRuntimeParameter("target", false, "query", null, null, new string[0]));
                this._requestParameters = new Google.Apis.Util.ReadOnlyDictionary<string, Google.Apis.Discovery.IParameter>(parameters);
            }
        }
    }
    
    public class TranslationsResource {
        
        private TranslateService service;
        
        private Google.Apis.Authentication.IAuthenticator authenticator;
        
        private const string Resource = "translations";
        
        public TranslationsResource(TranslateService service, Google.Apis.Authentication.IAuthenticator authenticator) {
            this.service = service;
            this.authenticator = authenticator;
        }
        
        /// <summary>Returns text translations from one language to another.</summary>
        /// <param name="q">Required - The text to translate</param>
        /// <param name="target">Required - The target language into which the text should be translated</param>
        public virtual ListRequest List(Google.Apis.Util.Repeatable<string> q, string target) {
            return new ListRequest(service, q, target);
        }
        
        /// <summary>The format of the text</summary>
        public enum Format {
            
            /// <summary>Specifies the input is in HTML</summary>
            [Google.Apis.Util.StringValueAttribute("html")]
            Html,
            
            /// <summary>Specifies the input is in plain textual format</summary>
            [Google.Apis.Util.StringValueAttribute("text")]
            Text,
        }
        
        public class ListRequest : Google.Apis.Requests.ClientServiceRequest<Google.Apis.Translate.v2.Data.TranslationsListResponse> {
            
            private string _alt;
            
            private string _fields;
            
            private string _oauth_token;
            
            private System.Nullable<bool> _prettyPrint;
            
            private string _quotaUser;
            
            private string _userIp;
            
            private Google.Apis.Util.Repeatable<string> _cid;
            
            private System.Nullable<Format> _format;
            
            private Google.Apis.Util.Repeatable<string> _q;
            
            private string _source;
            
            private string _target;
            
            public ListRequest(Google.Apis.Services.IClientService service, Google.Apis.Util.Repeatable<string> q, string target) : 
                    base(service) {
                this._q = q;
                this._target = target;
                this.InitParameters();
            }
            
            /// <summary>Data format for the response.</summary>
            [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Alt {
                get {
                    return this._alt;
                }
                set {
                    this._alt = value;
                }
            }
            
            /// <summary>Selector specifying which fields to include in a partial response.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Fields {
                get {
                    return this._fields;
                }
                set {
                    this._fields = value;
                }
            }
            
            /// <summary>OAuth 2.0 token for the current user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Oauth_token {
                get {
                    return this._oauth_token;
                }
                set {
                    this._oauth_token = value;
                }
            }
            
            /// <summary>Returns response with indentations and line breaks.</summary>
            [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> PrettyPrint {
                get {
                    return this._prettyPrint;
                }
                set {
                    this._prettyPrint = value;
                }
            }
            
            /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided.</summary>
            [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string QuotaUser {
                get {
                    return this._quotaUser;
                }
                set {
                    this._quotaUser = value;
                }
            }
            
            /// <summary>IP address of the site where the request originates. Use this if you want to enforce per-user limits.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userIp", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserIp {
                get {
                    return this._userIp;
                }
                set {
                    this._userIp = value;
                }
            }
            
            /// <summary>The customization id for translate</summary>
            [Google.Apis.Util.RequestParameterAttribute("cid", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Cid {
                get {
                    return this._cid;
                }
                set {
                    this._cid = value;
                }
            }
            
            /// <summary>The format of the text</summary>
            [Google.Apis.Util.RequestParameterAttribute("format", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<Format> Format {
                get {
                    return this._format;
                }
                set {
                    this._format = value;
                }
            }
            
            /// <summary>The text to translate</summary>
            [Google.Apis.Util.RequestParameterAttribute("q", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Q {
                get {
                    return this._q;
                }
            }
            
            /// <summary>The source language of the text</summary>
            [Google.Apis.Util.RequestParameterAttribute("source", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Source {
                get {
                    return this._source;
                }
                set {
                    this._source = value;
                }
            }
            
            /// <summary>The target language into which the text should be translated</summary>
            [Google.Apis.Util.RequestParameterAttribute("target", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Target {
                get {
                    return this._target;
                }
            }
            
            public override string MethodName {
                get {
                    return "list";
                }
            }
            
            public override string HttpMethod {
                get {
                    return "GET";
                }
            }
            
            public override string RestPath {
                get {
                    return "v2";
                }
            }
            
            private void InitParameters() {
                System.Collections.Generic.Dictionary<string, Google.Apis.Discovery.IParameter> parameters = new System.Collections.Generic.Dictionary<string, Google.Apis.Discovery.IParameter>();
                parameters.Add("cid", Google.Apis.Util.Utilities.CreateRuntimeParameter("cid", false, "query", null, null, new string[0]));
                parameters.Add("format", Google.Apis.Util.Utilities.CreateRuntimeParameter("format", false, "query", null, null, new string[] {
                                "html",
                                "text"}));
                parameters.Add("q", Google.Apis.Util.Utilities.CreateRuntimeParameter("q", true, "query", null, null, new string[0]));
                parameters.Add("source", Google.Apis.Util.Utilities.CreateRuntimeParameter("source", false, "query", null, null, new string[0]));
                parameters.Add("target", Google.Apis.Util.Utilities.CreateRuntimeParameter("target", true, "query", null, null, new string[0]));
                this._requestParameters = new Google.Apis.Util.ReadOnlyDictionary<string, Google.Apis.Discovery.IParameter>(parameters);
            }
        }
    }
    
    public partial class TranslateService {
        
        private const string Resource = "";
        
        private DetectionsResource _detections;
        
        private LanguagesResource _languages;
        
        private TranslationsResource _translations;
        
        private Google.Apis.Services.IClientService service {
            get {
                return this;
            }
        }
        
        public virtual DetectionsResource Detections {
            get {
                return this._detections;
            }
        }
        
        public virtual LanguagesResource Languages {
            get {
                return this._languages;
            }
        }
        
        public virtual TranslationsResource Translations {
            get {
                return this._translations;
            }
        }
    }
}
