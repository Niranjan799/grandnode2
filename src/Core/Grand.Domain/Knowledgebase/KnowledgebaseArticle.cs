﻿using Grand.Domain.Localization;
using Grand.Domain.Permissions;
using Grand.Domain.Seo;
using Grand.Domain.Stores;

namespace Grand.Domain.Knowledgebase
{
    public class KnowledgebaseArticle : BaseEntity, ITreeNode, ITranslationEntity, ISlugEntity, IGroupLinkEntity, IStoreLinkEntity
    {
        public KnowledgebaseArticle()
        {
            CustomerGroups = new List<string>();
            Locales = new List<TranslationEntity>();
            RelatedArticles = new List<string>();
            Stores = new List<string>();
        }

        /// <summary>
        /// Gets or sets title of the article
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets content of the article
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Gets or sets parent category Id
        /// </summary>
        public string ParentCategoryId { get; set; }

        /// <summary>
        /// Gets or sets display order
        /// </summary>
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Gets or sets published
        /// </summary>
        public bool Published { get; set; }

        /// <summary>
        /// Gets or sets the collection of locales
        /// </summary>
        public IList<TranslationEntity> Locales { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the entity is subject to ACL
        /// </summary>
        public bool LimitedToGroups { get; set; }
        public IList<string> CustomerGroups { get; set; }

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string SeName { get; set; }

        /// <summary>
        /// Gets or sets meta keywords
        /// </summary>
        public string MetaKeywords { get; set; }

        /// <summary>
        /// Gets or sets meta description
        /// </summary>
        public string MetaDescription { get; set; }

        /// <summary>
        /// Gets or sets meta title
        /// </summary>
        public string MetaTitle { get; set; }

        /// <summary>
        /// Gets or sets value indicating whether to show article on knowledgebase homepage
        /// </summary>
        public bool ShowOnHomepage { get; set; }

        /// <summary>
        /// Gets or sets list of related articles ids
        /// </summary>
        public IList<string> RelatedArticles { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the comments are allowed 
        /// </summary>
        public bool AllowComments { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the entity is limited/restricted to certain stores
        /// </summary>
        public bool LimitedToStores { get; set; }
        public IList<string> Stores { get; set; }
    }
}
