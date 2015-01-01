// This file is part of AlarmWorkflow.
// 
// AlarmWorkflow is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// AlarmWorkflow is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with AlarmWorkflow.  If not, see <http://www.gnu.org/licenses/>.

using System.Runtime.InteropServices;
using AlarmWorkflow.Shared.Core;

namespace AlarmWorkflow.Job.OperationPrinter
{
    /// <summary>
    /// Object that is used for scripting within the internal web browser.
    /// </summary>
    [ComVisible(true)]
    public class ScriptingObject
    {
        #region Properties

        /// <summary>
        /// Gets whether or not the client-side script code is ready.
        /// See documentation for further information.
        /// </summary>
        /// <remarks>This is a necessity for the job to know when it is safe to continue.
        /// The reason behind this is that the JS-code may contain asynchronous code that may take some time to load.
        /// For this reason, the JS-code needs to set this variable by calling the <see cref="setReady()"/> method.</remarks>
        public bool IsClientSideScriptReady { get; private set; }

        /// <summary>
        /// Gets/sets the source of the route.
        /// </summary>
        public PropertyLocation Source { get; set; }
        /// <summary>
        /// Gets/sets the operation that is printed.
        /// </summary>
        public Operation Operation { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Marks that the client-side JS code is done with its work.
        /// </summary>
        public void setReady()
        {
            IsClientSideScriptReady = true;
        }

        #endregion
    }
}