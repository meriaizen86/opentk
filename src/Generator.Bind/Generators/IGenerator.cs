﻿/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */

using System;
using System.Collections.Generic;
using Bind.Structures;
using Bind.Versioning;
using JetBrains.Annotations;

namespace Bind.Generators
{
    /// <summary>
    /// Interface for API generation configuration objects.
    /// </summary>
    internal interface IGenerator
    {
        /// <summary>
        /// Gets a short-name identifier for the API (such as GL, GL4, ES10, etc).
        /// </summary>
        [NotNull]
        string APIIdentifier { get; }

        /// <summary>
        /// Gets the namespace that the output classes and enums should live in.
        /// </summary>
        [NotNull]
        string Namespace { get; }

        /// <summary>
        /// Gets the name of the subfolder where the generated files should be placed.
        /// </summary>
        [NotNull]
        string OutputSubfolder { get; }

        /// <summary>
        /// Gets the name of the output class.
        /// </summary>
        [NotNull]
        string ClassName { get; }

        /// <summary>
        /// Gets the prefix of the functions in the API.
        /// </summary>
        [NotNull]
        string FunctionPrefix { get; }

        /// <summary>
        /// Gets the prefix of the constants defined in the API.
        /// </summary>
        [NotNull]
        string ConstantPrefix { get; }

        /// <summary>
        /// Gets the path to the directory that contains the API documentation.
        /// </summary>
        [NotNull]
        string SpecificationDocumentationPath { get; }

        /// <summary>
        /// Gets or a set of paths, indicating files to scan for specification overrides.
        /// </summary>
        IEnumerable<string> OverrideFiles { get; }

        /// <summary>
        /// Gets the name that corresponds to the "profile" attribute in the OpenGL registry. We use this to distinguish
        /// between different profiles (e.g. "gl", "glcore", "gles1", "gles2").
        /// </summary>
        [NotNull]
        string ProfileName { get; }

        /// <summary>
        /// Gets the name of the profile's base profile, that is, the profile that the current profile is a subset of.
        /// </summary>
        [CanBeNull]
        string BaseProfileName { get; }

        /// <summary>
        /// Gets the path to the file that contains the API specification.
        /// </summary>
        [NotNull]
        string SpecificationFile { get; }

        /// <summary>
        /// Gets the path to the file that contains the language typemap.
        /// </summary>
        [NotNull]
        string LanguageTypemap { get; }

        /// <summary>
        /// Gets the path to the file that contains the API typemap.
        /// </summary>
        [NotNull]
        string APITypemap { get; }

        /// <summary>
        /// Gets the versions to generate for.
        /// </summary>
        [NotNull]
        VersionRange Versions { get; }

        /// <summary>
        /// Gets the delegates that were loaded from the API specification.
        /// </summary>
        [NotNull, Obsolete]
        DelegateCollection Delegates { get; }

        /// <summary>
        /// Gets the enums that were generated from the API specification.
        /// </summary>
        [NotNull, Obsolete]
        EnumCollection Enums { get; }

        /// <summary>
        /// Gets the function wrappers that were generated from the API specification.
        /// </summary>
        [NotNull, Obsolete]
        FunctionCollection Wrappers { get; }

        /// <summary>
        /// Gets the API typemap.
        /// </summary>
        [NotNull, Obsolete]
        IDictionary<string, string> APITypes { get; }

        /// <summary>
        /// Gets the language typemap.
        /// </summary>
        [NotNull, Obsolete]
        IDictionary<string, string> LanguageTypes { get; }

        /// <summary>
        /// Loads the data that the generator wraps.
        /// </summary>
        [Obsolete]
        void LoadData();
    }
}
