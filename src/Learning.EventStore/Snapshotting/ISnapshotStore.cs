﻿using System.Threading.Tasks;

namespace Learning.EventStore.Snapshotting
{
    /// <summary>
    /// Defines the methods needed from the snapshot store.
    /// </summary>
    public interface ISnapshotStore
    {
        /// <summary>
        /// Check for an existing snapshot
        /// </summary>
        /// <param name="id">Id of aggregate</param>
        /// <returns>Task with bool indicating whether or not the snapshot exists</returns>
        Task<bool> ExistsAsync(string id);

        /// <summary>
        /// Get snapshot from store
        /// </summary>
        /// <param name="id">Id of aggregate</param>
        /// <returns>Task with snapshot</returns>
        Task<Snapshot> GetAsync(string id);

        /// <summary>
        /// Save snapshot to store
        /// </summary>
        /// <param name="snapshot">The snapshot to save</param>
        /// <returns>Task of operation</returns>
        Task SaveAsync(Snapshot snapshot);
    }
}
