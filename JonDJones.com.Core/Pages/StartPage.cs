﻿using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using JonDJones.Com.Core.Pages.Base;
using EPiServer.DataAbstraction;
using JonDJones.com.Core.Interfaces;
using JonDJones.com.Core.Resources;
using JonDJones.com.Core.Entities;
using System.Collections.Generic;
using EPiServer.Cms.Shell.UI.ObjectEditing.EditorDescriptors;

namespace JonDJones.Com.Core.Pages
{
    [ContentType(
        DisplayName = "Start Page",
        GUID = "6671aa96-0a1b-4618-88e3-c98e1a78dcb4",
        Description = "Start Page",
        GroupName = "Standard")]
    public class StartPage : GlobalBasePage, IHeaderProperties, IFooterProperties
    {
        //[Display(
        //    Name = "Awards",
        //    Description = "Awards",
        //    GroupName = SystemTabNames.Content,
        //    Order = 10)]
        //[EditorDescriptor(EditorDescriptorType = typeof(CollectionEditorDescriptor<Award>))]
        //public virtual IList<Award> Awards { get; set; }

        [Display(
            Name = "Site Title",
            Description = "Site Title",
            GroupName = SystemTabNames.Content,
            Order = 50)]
        public virtual string SiteTitle { get; set; }

        [Display(
            Name = "Page Title",
            Description = "Page Title",
            GroupName = SystemTabNames.Content,
            Order = 100)]
        [CultureSpecific]
        public virtual string PageTitle { get; set; }

        [Display(
            Name = "Main Title",
            Description = "Main Title",
            GroupName = SystemTabNames.Content,
            Order = 200)]
        public virtual string MainTitle { get; set; }

        [Display(
            Name = "Main Description",
            Description = "Main Description",
            GroupName = SystemTabNames.Content,
            Order = 300)]
        public virtual XhtmlString MainDescription { get; set; }

        [Display(
            Name = "Main Content Area",
            Description = "Region where content blocks can be placed",
            GroupName = SystemTabNames.Content,
            Order = 400)]
        public virtual ContentArea MainContentArea { get; set; }

        #region Footer Settings

        [Display(
            Name = "Facebok Url",
            GroupName = ResourceDefinitions.TabNames.Footer,
            Order = 4000)]
        public virtual string FacebookUrl { get; set; }

        [Display(
            Name = "Github Url",
            GroupName = ResourceDefinitions.TabNames.Footer,
            Order = 4100)]
        public virtual string GitHubUrl { get; set; }

        [Display(
            Name = "Twitter Url",
            GroupName = ResourceDefinitions.TabNames.Footer,
            Order = 4200)]
        public virtual string TwitterUrl { get; set; }

        [Display(
            Name = "CopyRightNotice",
            GroupName = ResourceDefinitions.TabNames.Footer,
            Order = 500)]
        [Required]
        public string CopyRightNotice { get; set; }
        #endregion

        #region Header Settings

        [Display(
            Name = "Search Bar",
            Description = "Region where content blocks can be placed",
            GroupName = SystemTabNames.Content,
            Order = 400)]
        public virtual ContentArea SearchBar { get; set; }

        #endregion
    }
}