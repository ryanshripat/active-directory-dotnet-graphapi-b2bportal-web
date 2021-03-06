﻿using B2BPortal.Interfaces;
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;

namespace B2BPortal.Data
{
    public class InviteTemplate : DocModelBase, IDocModelBase, IInviteTemplate
    {
        /// <summary>
        /// Site name displayed on home page (above description)
        /// </summary>
        [DisplayName("Template Name")]
        [Required]
        [JsonProperty(PropertyName = "templateName")]
        public string TemplateName { get; set; }

        /// <summary>
        /// Name of inviting organization
        /// </summary>
        [DisplayName("Template Content")]
        [AllowHtml]
        [Required]
        [JsonProperty(PropertyName = "templateContent")]
        public string TemplateContent { get; set; }

        /// <summary>
        /// Welcome message displayed on the home page - HTML allowed
        /// </summary>
        [DisplayName("Subject Template")]
        [JsonProperty(PropertyName = "subjectTemplate")]
        public string SubjectTemplate { get; set; }

        /// <summary>
        /// Date this version of settings was committed
        /// </summary>
        [ScaffoldColumn(false)]
        [DisplayName("Last Updated")]
        [JsonProperty(PropertyName = "lastUpdated")]
        public DateTime LastUpdated { get; set; }

        [ScaffoldColumn(false)]
        [DisplayName("Template Version")]
        [JsonProperty(PropertyName = "templateVersion")]
        public int TemplateVersion { get; set; }

        [DisplayName("Template Author")]
        [JsonProperty(PropertyName = "templateAuthor")]
        public string TemplateAuthor { get; set; }
    }
}