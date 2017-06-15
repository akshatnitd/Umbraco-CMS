﻿using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Umbraco.Web.Models.ContentEditing
{
    [DataContract(Name = "userGroup", Namespace = "")]
    public class UserGroupBasic : EntityBasic, INotificationModel
    {
        public UserGroupBasic()
        {
            Notifications = new List<Notification>();
        }        

        /// <summary>
        /// This is used to add custom localized messages/strings to the response for the app to use for localized UI purposes.
        /// </summary>
        [DataMember(Name = "notifications")]
        public List<Notification> Notifications { get; private set; }
        
        [DataMember(Name = "sections")]
        public IEnumerable<Section> Sections { get; set; }
        
        [DataMember(Name = "startContentId")]
        public EntityBasic StartContentId { get; set; }

        [DataMember(Name = "startMediaId")]
        public EntityBasic StartMediaId { get; set; }
    }
}