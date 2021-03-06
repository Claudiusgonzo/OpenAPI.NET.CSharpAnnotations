﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// ------------------------------------------------------------

using System.Collections.Generic;
using Microsoft.OpenApi.CSharpAnnotations.DocumentGeneration.Models;
using Microsoft.OpenApi.CSharpAnnotations.DocumentGeneration.PostProcessingDocumentFilters;
using Microsoft.OpenApi.Models;

namespace Microsoft.OpenApi.CSharpAnnotations.DocumentGeneration.Tests.OpenApiDocumentGeneratorTests
{
    /// <summary>
    /// Updates the description in open API document.
    /// </summary>
    internal class UpdateDescriptionFilter : IPostProcessingDocumentFilter
    {
        /// <summary>
        /// Updates the description in open API document.
        /// </summary>
        /// <param name="openApiDocument">The open API document to update.</param>
        /// <param name="settings">The filter settings.</param>
        /// <returns>The list of generation errors, if any produced when processing the filter.</returns>
        public IList<GenerationError> Apply(
            OpenApiDocument openApiDocument,
            PostProcessingDocumentFilterSettings settings)
        {
            openApiDocument.Info.Description = "Updated Description";

            return new List<GenerationError>();
        }
    }
}