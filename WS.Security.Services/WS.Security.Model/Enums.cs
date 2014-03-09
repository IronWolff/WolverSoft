using System;

namespace WS.Security.Model
{
    public enum BatchStatusEnum
    {
        /// <summary>
        /// Represents a batch that hasn't been assigned by a DE-Coordinator.
        /// </summary>
        Unassigned = 1,

        /// <summary>
        /// Represents a batch that has been assigned by a DE-Coordinator.
        /// </summary>
        Assigned = 2,

        /// <summary>
        /// Represents a batch that has been submited by a HomeWorker.
        /// </summary>
        Submitted = 3,

        /// <summary>
        /// Represents a batch that has been accepted by a HomeWorker.
        /// </summary>
        Accepted = 4,

        /// <summary>
        /// Represents a batch that has been rejected by a HomeWorker.
        /// </summary>
        Rejected = 5,

        /// <summary>
        /// Represents a batch that has been exported to CASS.
        /// </summary>
        CASSExported = 6,

        /// <summary>
        /// Represents a batch that has been exported to another DB.
        /// </summary>
        Imported = 7,

        /// <summary>
        /// Represents a batch that is waiting to be processed.
        /// </summary>
        OnHold = 8
    }

    /// <summary>
    /// Indicates the status of the Department
    /// </summary>
    public enum DepartmentStatusEnum
    {
        /// <summary>
        /// Represents when a department is active, working and beign used.
        /// </summary>
        Active = 1,

        /// <summary>
        /// Represents when a department is going to be used but not ready.
        /// </summary>
        Preliminary = 2,

        /// <summary>
        /// Represents when a department is inactive.
        /// </summary>
        Inactive = 3
    }

    /// <summary>
    /// Indicates the Permission level to use in the User and Roles
    /// </summary>
    public enum PermissionLevelEnum
    {
        /// <summary>
        /// Represents rejection on everything that uses this permission level
        /// </summary>
        Invalid = 1,

        /// <summary>
        /// No writing actions will be allowed using this permission level.
        /// </summary>
        ReadOnly = 2,

        /// <summary>
        /// Represents read and write permission.
        /// </summary>
        Full = 3,

        /// <summary>
        /// This level means that writing or reading operations are not beign applied or rejected.
        /// </summary>
        Undefined = 4
    }
}
