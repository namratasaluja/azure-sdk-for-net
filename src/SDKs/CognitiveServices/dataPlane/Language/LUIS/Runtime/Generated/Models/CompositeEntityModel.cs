// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Runtime.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// LUIS Composite Entity.
    /// </summary>
    public partial class CompositeEntityModel
    {
        /// <summary>
        /// Initializes a new instance of the CompositeEntityModel class.
        /// </summary>
        public CompositeEntityModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CompositeEntityModel class.
        /// </summary>
        /// <param name="parentType">Type/name of parent entity.</param>
        /// <param name="value">Value for composite entity extracted by
        /// LUIS.</param>
        /// <param name="children">Child entities.</param>
        public CompositeEntityModel(string parentType, string value, IList<CompositeChildModel> children)
        {
            ParentType = parentType;
            Value = value;
            Children = children;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets type/name of parent entity.
        /// </summary>
        [JsonProperty(PropertyName = "parentType")]
        public string ParentType { get; set; }

        /// <summary>
        /// Gets or sets value for composite entity extracted by LUIS.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets child entities.
        /// </summary>
        [JsonProperty(PropertyName = "children")]
        public IList<CompositeChildModel> Children { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ParentType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ParentType");
            }
            if (Value == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Value");
            }
            if (Children == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Children");
            }
            if (Children != null)
            {
                foreach (var element in Children)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}