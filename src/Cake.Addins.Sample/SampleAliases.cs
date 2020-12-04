// Copyright 2020 C. Augusto Proiete & Contributors
//
// Licensed under the MIT (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://opensource.org/licenses/MIT
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using Cake.Common.Diagnostics;
using Cake.Core;
using Cake.Core.Annotations;

namespace Cake.Addins.Sample
{
    /// <summary>
    /// Sample aliases
    /// </summary>
    [CakeAliasCategory("Sample")]
    [CakeNamespaceImport("Cake.Addins.Sample")]
    public static class SampleAliases
    {
        /// <summary>
        /// Run the Sample alias.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <example>
        /// <code>
        /// <![CDATA[
        /// Sample();
        /// 
        /// // ...
        /// ]]>
        /// </code>
        /// </example>
        [CakeMethodAlias]
        [CakeAliasCategory("Sample")]
        public static void Sample(this ICakeContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            context.Sample(new SampleSettings
            {
                Name = Environment.UserName,
            });
        }

        /// <summary>
        /// Run the Sample alias using the specified settings.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <para>Display a name</para>
        /// <code>
        /// <![CDATA[
        /// var settings = new SampleSettings
        /// {
        ///     Name = "Augusto",
        /// };
        /// 
        /// Sample(settings);
        /// 
        /// // ...
        /// ]]>
        /// </code>
        /// </example>
        [CakeMethodAlias]
        [CakeAliasCategory("Sample")]
        public static void Sample(this ICakeContext context, SampleSettings settings)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (settings == null)
            {
                throw new ArgumentNullException(nameof(settings));
            }

            AddInInformation.LogVersionInformation(context.Log);

            context.Information(string.Empty);
            context.Information(
                $"Hello {settings.Name} from {AddInInformation.AssemblyName} v{AddInInformation.AssemblyVersion} ({AddInInformation.InformationalVersion})");
        }
    }
}
