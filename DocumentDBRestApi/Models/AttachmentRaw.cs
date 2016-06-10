﻿

using System;
using Newtonsoft.Json.Linq;

namespace DocumentDBRestApi.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class AttachmentRaw
    {
        /// <summary>
        ///     Initializes a new instance of the AttachmentRaw class.
        /// </summary>
        public AttachmentRaw()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the AttachmentRaw class with required
        ///     arguments.
        /// </summary>
        public AttachmentRaw(string contentType, string slug)
            : this()
        {
            if (contentType == null)
            {
                throw new ArgumentNullException(nameof(contentType));
            }
            if (slug == null)
            {
                throw new ArgumentNullException(nameof(slug));
            }
            ContentType = contentType;
            Slug = slug;
        }

        /// <summary>
        ///     Optional. This is a system generated property representing the
        ///     resource etag required for optimistic concurrency control.
        /// </summary>
        public string Etag { get; set; }

        /// <summary>
        ///     Optional. This is a system generated property denoting the
        ///     addressable path of the feed of permissions resource.
        /// </summary>
        public string Permissions { get; set; }

        /// <summary>
        ///     Optional. This is a system generated property.
        /// </summary>
        public string Rid { get; set; }

        /// <summary>
        ///     Optional. This is a system generated property.
        /// </summary>
        public string Self { get; set; }

        /// <summary>
        ///     Optional. This is a system generated property. It specifies the
        ///     last updated timestamp of the resource. The value is a timestamp.
        /// </summary>
        public string TS { get; set; }

        /// <summary>
        ///     Required. The content type of the attachment.
        /// </summary>
        public string ContentType { get; set; }

        /// <summary>
        ///     Optional. This is the attachment name and type.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        ///     Required. The name of the attachment
        /// </summary>
        public string Slug { get; set; }

        /// <summary>
        ///     Optional. The client user agent performing the request
        /// </summary>
        public string UserAgent { get; set; }

        /// <summary>
        ///     Serialize the object
        /// </summary>
        /// <returns>
        ///     Returns the json model for the type AttachmentRaw
        /// </returns>
        public virtual JToken SerializeJson(JToken outputObject)
        {
            if (outputObject == null)
            {
                outputObject = new JObject();
            }
            if (ContentType == null)
            {
                throw new ArgumentNullException(nameof(ContentType));
            }
            if (Slug == null)
            {
                throw new ArgumentNullException(nameof(Slug));
            }
            if (Etag != null)
            {
                outputObject["_etag"] = Etag;
            }
            if (Permissions != null)
            {
                outputObject["_permissions"] = Permissions;
            }
            if (Rid != null)
            {
                outputObject["_rid"] = Rid;
            }
            if (Self != null)
            {
                outputObject["_self"] = Self;
            }
            if (TS != null)
            {
                outputObject["_ts"] = TS;
            }
            if (ContentType != null)
            {
                outputObject["ContentType"] = ContentType;
            }
            if (Id != null)
            {
                outputObject["id"] = Id;
            }
            if (Slug != null)
            {
                outputObject["Slug"] = Slug;
            }
            if (UserAgent != null)
            {
                outputObject["User-Agent"] = UserAgent;
            }
            return outputObject;
        }

        /// <summary>
        ///     Deserialize the object
        /// </summary>
        public virtual void DeserializeJson(JToken inputObject)
        {
            if (inputObject != null && inputObject.Type != JTokenType.Null)
            {
                var etagValue = inputObject["_etag"];
                if (etagValue != null && etagValue.Type != JTokenType.Null)
                {
                    Etag = (string) etagValue;
                }
                var permissionsValue = inputObject["_permissions"];
                if (permissionsValue != null && permissionsValue.Type != JTokenType.Null)
                {
                    Permissions = (string) permissionsValue;
                }
                var ridValue = inputObject["_rid"];
                if (ridValue != null && ridValue.Type != JTokenType.Null)
                {
                    Rid = (string) ridValue;
                }
                var selfValue = inputObject["_self"];
                if (selfValue != null && selfValue.Type != JTokenType.Null)
                {
                    Self = (string) selfValue;
                }
                var tsValue = inputObject["_ts"];
                if (tsValue != null && tsValue.Type != JTokenType.Null)
                {
                    TS = (string) tsValue;
                }
                var contentTypeValue = inputObject["ContentType"];
                if (contentTypeValue != null && contentTypeValue.Type != JTokenType.Null)
                {
                    ContentType = (string) contentTypeValue;
                }
                var idValue = inputObject["id"];
                if (idValue != null && idValue.Type != JTokenType.Null)
                {
                    Id = (string) idValue;
                }
                var slugValue = inputObject["Slug"];
                if (slugValue != null && slugValue.Type != JTokenType.Null)
                {
                    Slug = (string) slugValue;
                }
                var userAgentValue = inputObject["User-Agent"];
                if (userAgentValue != null && userAgentValue.Type != JTokenType.Null)
                {
                    UserAgent = (string) userAgentValue;
                }
            }
        }
    }
}