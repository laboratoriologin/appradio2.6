﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RadioPlayer.Beans.ValueObject.Xml.Promocao
{
    /// <summary>
    /// Classe Value Object ImageChannelPromocaoVO.
    /// </summary>
    [KnownType(typeof(ImageChannelPromocaoVO))]
    [DataContractAttribute]
    public class ImageChannelPromocaoVO : BindableBaseVO
    {
        /// <summary>
        /// Atríbuto url
        /// </summary>
        private string url;

        /// <summary>
        /// Atríbuto link
        /// </summary>
        private string link;

        /// <summary>
        /// Atríbuto title
        /// </summary>
        private string title;

        /// <summary>
        /// Atríbuto description
        /// </summary>
        private string description;

        /// <summary>
        /// Atríbuto description
        /// </summary>
        private string guid;

        public string Guid
        {
            get { return guid; }
            set { this.SetProperty(ref this.guid, value); }
        }



        /// <summary>
        /// Gets or sets - propriedade Url.
        /// </summary>
        public string Url
        {
            get { return this.url; }
            set { this.SetProperty(ref this.url, value); }
        }

        /// <summary>
        /// Gets or sets - propriedade Link.
        /// </summary>
        public string Link
        {
            get { return this.link; }
            set { this.SetProperty(ref this.link, value); }
        }

        /// <summary>
        /// Gets or sets - propriedade Title.
        /// </summary>
        public string Title
        {
            get { return this.title; }
            set { this.SetProperty(ref this.title, value); }
        }

        /// <summary>
        /// Gets or sets - propriedade Description.
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.SetProperty(ref this.description, value); }
        }


    }
}
