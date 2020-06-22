﻿using Umbraco.Composing;
using Umbraco.Core.IO;
using Umbraco.Core.Services;
using Umbraco.Web.BackOffice.Filters;
using Umbraco.Web.BackOffice.Trees;
using Umbraco.Web.Common.Attributes;
using Umbraco.Web.Composing;
using Umbraco.Web.Mvc;
using Umbraco.Web.WebApi;
using Umbraco.Web.WebApi.Filters;
using Constants = Umbraco.Core.Constants;

namespace Umbraco.Web.Trees
{
    /// <summary>
    /// Tree for displaying partial views in the settings app
    /// </summary>
    [Tree(Core.Constants.Applications.Settings, Core.Constants.Trees.PartialViews, SortOrder = 7, TreeGroup = Core.Constants.Trees.Groups.Templating)]
    [UmbracoTreeAuthorize(Constants.Trees.PartialViews)]
    [PluginController("UmbracoTrees")]
    [CoreTree]
    public class PartialViewsTreeController : FileSystemTreeController
    {
        protected override IFileSystem FileSystem { get; }

        private static readonly string[] ExtensionsStatic = {"cshtml"};

        protected override string[] Extensions => ExtensionsStatic;

        protected override string FileIcon => "icon-article";

        public PartialViewsTreeController(
            ILocalizedTextService localizedTextService,
            UmbracoApiControllerTypeCollection umbracoApiControllerTypeCollection,
            IMenuItemCollectionFactory menuItemCollectionFactory,
            IFileSystems fileSystems)
            : base(localizedTextService, umbracoApiControllerTypeCollection, menuItemCollectionFactory)
        {
            FileSystem = fileSystems.PartialViewsFileSystem;
        }
    }
}